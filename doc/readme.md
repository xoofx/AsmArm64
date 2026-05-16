# AsmArm64 User Guide

The library is composed of an extensive assembler and disassembler API.

## The Disassembler API

### Detecting an instruction

The API `Arm64Instruction.DecodeId` is a lightweight API that will return the instruction ID of the instruction at the given address. The instruction ID is a unique identifier for each instruction that can be used to identify the instruction.

```c#
var instructionId = Arm64Instruction.DecodeId(0x5AC02000U);
// Prints "ABS_32_dp_1src"
Console.WriteLine(instructionId);
```

### Disassembling an instruction

The API `Arm64Instruction.Decode` is a more comprehensive API that will return an `Arm64Instruction` object that contains all the information about the instruction at the given address.

```c#
var instruction = Arm64Instruction.Decode(0x5AC02000U);
// Prints "abs w0, w0"
Console.WriteLine(instruction.ToString());
```

> Notice that the library accepts only little endian byte order for the instruction bytes. You need to reverse the bytes before processing them if you have big endian configuration to decode (which is less common these days).

### Inspecting instruction operands

The `Arm64Instruction` object contains a list of `Arm64Operand` objects that represent the operands of the instruction. The `Arm64Operand` object contains information about the operand kind and can be casted to a more specific kind of operand.

```c#
var instruction = Arm64Instruction.Decode(0x5AC02000U);
foreach (var operand in instruction.Operands)
{
    if (operand.Kind == Arm64OperandKind.Register)
    {
        var registerOperand = (Arm64RegisterOperand)operand;
        // Prints "w0 - Flags: Write" for the first register
        // Prints "w0 - Flags: Read" for the 2nd register
        Console.WriteLine($"{registerOperand} - Flags: {registerOperand.Flags}");
    }
}
```
### Disassembling a sequence of instructions

The API `Arm64Disassembler` is a more advanced API that can be used to disassemble a sequence of instructions. The `Arm64Disassembler` object can be used to disassemble instructions from a given byte buffer (`byte[]`, `Span<byte>`, or `ReadOnlySpan<byte>`).

```c#
var buffer = new byte[] { 0xA0, 0x00, 0x80, 0xD2, 0xC0, 0x03, 0x5F, 0xD6 };
var disassembler = new Arm64Disassembler();
var text = disassembler.Disassemble(buffer);
Console.WriteLine(text);
```

will print:

```asm
LL_01:
    mov x0, #5
    ret
```

You can create an `Arm64Disassembler` with `Arm64DisassemblerOptions` to customize the disassembler behavior. For example, you can:
- Set the base address of the disassembled instructions via `Arm64DisassemblerOptions.BaseAddress`
- Print the address of each instruction via `Arm64DisassemblerOptions.PrintAddress`
- Print the bytes of each instruction via `Arm64DisassemblerOptions.PrintBytes`
- Add a comment to each instructions via `Arm64DisassemblerOptions.TryFormatComment`
- Add a line before/after each instructions
- Resolve absolute addresses to label or symbol names, for example from PDB data, via `Arm64DisassemblerOptions.TryFormatLabel`
- And many more... See the class [Arm64DisassemblerOptions.cs](https://github.com/xoofx/AsmArm64/blob/main/src/AsmArm64/Arm64DisassemblerOptions.cs)

## The Assembler API

The AsmArm64 assembler API is unique in its genre as it provides a strongly typed API. The API is designed to be used in a fluent way to build instructions, similarly to what you would do in a plain asm code.

In order to use the API it is recommended to use the static class `Arm64Factory` that provides access to all registers (e.g. `X0`, `X1`), system registerse and enums.

``` c#
// Add this using directive at the beginning of your file
using static AsmArm64.Arm64Factory;
```

### Assembling a single instruction

The API `Arm64InstructionFactory` provides a way to encode an instruction directly to a raw value.

```c#
var rawValue = Arm64InstructionFactory.MOVZ(X0, 5);
// Prints "0xD28000A0"
Console.WriteLine($"0x{rawValue:X8}");
```

Because the code behind the API is strongly typed, the instruction above will be **encoded as a constant at JIT compile time**:

```C#
public static uint Tester()
{
    return Arm64InstructionFactory.MOVZ(X0, 5);
}
```

```asm
; Method Tester():uint (FullOpts)
G_M000_IG01:                ;; offset=0x0000

G_M000_IG02:                ;; offset=0x0000
       mov      eax, 0xFFFFFFFFD28000A0

G_M000_IG03:                ;; offset=0x0005
       ret      
; Total bytes of code: 6
```

### Advanced operand encoding

The assembler supports all the complicated operands, including register indexing (e.g. `v0.d[0]`)...etc.

For example:

* Using the syntax `V0.T_8B` for encoding `V0.8B`
  ```c#
  Arm64InstructionFactory.ABS(V0.T_8B, V1.T_8B); // ABS V0.8B, V1.8B
  ```
* The register indexer `V2.T_2H[1]` syntax
  ```c#
  Arm64InstructionFactory.BFDOT(V0.T_2S, V1.T_4H, V2.T_2H[1]); // BFDOT V0.2S, V1.4H, V2.2H[1]
  ```
* The memory operand `_[...]`
  ```c#
  Arm64InstructionFactory.LDFADD(H0, H1, _[X3]); .// LDFADD H0, H1, [X3]
  Arm64InstructionFactory.LDRSB(W0, _[X2, X3, _LSL, 0]); // LDRSB W0, [X2, X3, LSL #0]
  ```
* Grouped registers `{ ... }`
  ```c#
  Arm64InstructionFactory.LD1(V0.T_16B.Group2(), _[X2]); // LD1 { V0.16B, V1.16B }, [X2]
  ```
* Extend encoding e.g. `_SXTX`, or `_LSL`...etc.
  ```c#
  Arm64InstructionFactory.ADD(SP, X18, X3, _SXTX, 1); // ADD SP, X18, X3, SXTX #1
  ```
### Assembling a sequence of instructions

The API `Arm64Assembler` is a more advanced API that can be used to assemble a sequence of instructions. By default, the `Arm64Assembler` object owns a byte buffer exposed through `Buffer` and `ToArray()`.

Advanced callers can still provide a custom instruction buffer:
- A list of instruction via `Arm64InstructionBufferByList`
- A stream of instruction via `Arm64InstructionBufferByStream`
- A memory buffer via `Arm64InstructionBufferByMemory`
- An unsafe memory buffer via `Arm64InstructionBufferByUnsafeMemory`

Supposed that we want to encode the following code:
```asm
_start:
    mov     x0, #5         // Call sum_loop(5)
    bl      sum_loop       // Call the function, result in x0

    // Do something with result (for now, just returning)
    ret                    // Return from _start (normally would return to a caller)

// Function: sum_loop(x0)
// - Takes x0 as the loop limit
// - Returns the sum in x0
sum_loop:
    mov     x1, #0         // Accumulator (sum)
    mov     x2, #0         // Counter

loop_start:
    add     x1, x1, x2     // Add counter (x2) to sum (x1)
    add     x2, x2, #1     // Increment counter

    cmp     x2, x0         // Compare counter with limit
    blt     loop_start     // If counter < limit, continue loop

    mov     x0, x1         // Store result in x0 (return value)
    ret                    // Return to caller
```

The same program can be encoded in a fluent API with the following code:

```c#
using static Arm64Factory;

using var asm = new Arm64Assembler(0x1_0000);
// Main entry point
// _start:
asm.Label("_start", out var labelStart);
//     mov     x0, #5         // Call sum_loop(5)
//     bl      sum_loop       // Call the function, result in x0
//     ret                    // Return from _start (normally would return to a caller)
var labelSumLoop = asm.CreateLabel("sum_loop");
asm.MOVZ(X0, 5)
   .BL(labelSumLoop)
   .RET();
// 
// 
// // Function: sum_loop(x0)
// // - Takes x0 as the loop limit
// // - Returns the sum in x0
// sum_loop:
asm.Label(labelSumLoop);
//     mov     x1, #0         // Accumulator (sum)
//     mov     x2, #0         // Counter
asm.MOVZ(X1, 0)
   .MOVZ(X2, 0);
// 
// loop_start:
asm.Label("loop_start", out var labelLoopStart);
//     add     x1, x1, x2     // Add counter (x2) to sum (x1)
//     add     x2, x2, #1     // Increment counter
//     cmp     x2, x0         // Compare counter with limit
//     blt     loop_start     // If counter < limit, continue loop
//     mov     x0, x1         // Store result in x0 (return value)
//     ret                    // Return to caller
asm.ADD(X1, X1, X2)
   .ADD(X2, X2, 1)
   .CMP(X2, X0)
   .B(LT, labelLoopStart)
   .MOV(X0, X1)
   .RET()
   .End();
ReadOnlySpan<byte> code = asm.Buffer;
```

Generated instruction methods return the assembler, so calls can be chained as shown above. Statement-style calls still work when the returned assembler is ignored.

Notice the API to create and use the labels:
- `Arm64Assembler.CreateLabel` or `Arm64Assembler.LabelForward` to create an unbound label
  - A label can be associated with an absolute address if required.
- `Arm64Assembler.Label` to bind a label to the current position in the buffer

### Diagnostics and debug maps

`End()` validates pending label patches before returning. If a label is still unbound or a label target cannot be encoded in the instruction's immediate field, the assembler throws `Arm64AssemblerException`. The exception exposes structured `Arm64AssemblerDiagnostic` entries with the offset, address, label name, instruction id, and source file/line when available.

```csharp
using var asm = new Arm64Assembler(0x1000);

asm.B(out var missing);

if (!asm.TryEnd(out var diagnostics))
{
    foreach (var diagnostic in diagnostics)
    {
        Console.WriteLine(diagnostic);
    }
}
```

Generated assembler overloads record caller file/line information in `Arm64Assembler.DebugMap` when caller-info parameters can be added without creating ambiguous optional-operand overloads. Section and function helpers add markers to the same map:

```csharp
using var asm = new Arm64Assembler(0x1000);

asm.BeginFunction("sum")
   .BeginCodeSection("text")
   .MOVZ(X0, 5)
   .RET()
   .EndCodeSection()
   .BeginDataSection("rodata")
   .AppendUInt32(0x12345678)
   .EndDataSection()
   .EndFunction("sum")
   .End();

foreach (var entry in asm.DebugMap!.Entries)
{
    Console.WriteLine(entry);
}
```

Set `DebugMap` to `null` to disable logging, or replace it with a custom `IArm64AssemblerDebugMap` implementation. A disassembler comment formatter can use the debug map to annotate instruction addresses:

```csharp
var disassembler = new Arm64Disassembler
{
    Options =
    {
        BaseAddress = (long)asm.BaseAddress,
        TryFormatComment = (offset, instruction, destination, out int written) =>
        {
            var entry = asm.DebugMap?.Entries.LastOrDefault(x => x.Offset == (uint)offset);
            if (entry is { FilePath: not null })
            {
                return destination.TryWrite($"{Path.GetFileName(entry.FilePath)}:{entry.LineNumber}", out written);
            }

            written = 0;
            return false;
        }
    }
};
```

The same `TryFormatLabel` hook can resolve symbols from PDBs, linker map files, or any application-owned symbol table because it receives the absolute target address:

```csharp
var symbols = new Dictionary<long, string>
{
    [0x1000] = "start",
    [0x1040] = "loop",
};

disassembler.Options.TryFormatLabel = (address, destination, out int written) =>
{
    if (symbols.TryGetValue(address, out var name))
    {
        written = name.Length;
        return name.AsSpan().TryCopyTo(destination);
    }

    written = 0;
    return false;
};
```

### Label expressions

Label operands accept `Arm64AddressExpression`, so a label can be adjusted by a signed addend and patched once all referenced labels are bound:

```csharp
using var asm = new Arm64Assembler(0x1000);

asm.B(out var target)
   .NOP()
   .Label(target)
   .B(target + 4)
   .End();
```

Use label subtraction for diagnostics or layout calculations after labels are bound:

```csharp
asm.Label(out var start)
   .NOP()
   .Label(out var end);

long byteLength = (end - start).Evaluate();
```

For ARM64 page-relative address materialization, `ADRP` uses the 4KB page delta between the current instruction page and the target page. The address helper methods make that explicit:

```csharp
var symbol = new Arm64Label(0x1234_5678, "symbol");

asm.ADRP(X0, symbol.Page())
   .ADD(X0, X0, (uint)symbol.PageOffset().Evaluate());
```

`ADRP(Xd, label)` applies the same page-relative semantics even when the label itself is not page-aligned.

### Disassembler invalid data handling

ARM64 instructions are 4 bytes wide. By default the disassembler throws `ArgumentException` when the input length is not a multiple of 4. Configure `Arm64DisassemblerOptions.InvalidDataMode` to emit or ignore trailing bytes:

```csharp
var disassembler = new Arm64Disassembler
{
    Options =
    {
        InvalidDataMode = Arm64InvalidDataMode.EmitBytes
    }
};

Console.WriteLine(disassembler.Disassemble(codeWithTrailingBytes));
```

### Blocks, literal pools, and relocations

Use `Arm64Block` with `ArrangeBlocks` for simple fixed/floating layout. Fixed blocks are placed by absolute address with zero-filled gaps; floating blocks are placed afterward with their requested alignment:

```csharp
var data = asm.CreateLabel("data");
asm.ArrangeBlocks(new Arm64Block(data, [1, 2, 3, 4], alignment: 4, address: 0x2000));
```

Literal pools are explicit. Create a literal label, use it with an `LDR literal`, then flush the pool where it should be emitted. Normal label range checks run during `End()`:

```csharp
var literal = asm.Literal(0x1122334455667788UL, "constant");
asm.LDR(X0, literal)
   .FlushLiteralPool()
   .End();
```

External symbols can remain unresolved and produce relocation records instead of label diagnostics:

```csharp
var puts = asm.ExternalLabel("puts");
asm.BL(puts).End();

foreach (var relocation in asm.Relocations)
{
    Console.WriteLine($"{relocation.Kind} at 0x{relocation.Offset:X}: {relocation.Label.Name}");
}
```

### Disassembler auto-labels

`Arm64DisassemblerOptions.AutoLabelKinds` controls which PC-relative operands are turned into generated local labels. Use this to keep data references such as `ADR` and `LDR literal` as absolute addresses while still labeling control flow:

```csharp
var disassembler = new Arm64Disassembler
{
    Options =
    {
        AutoLabelKinds = Arm64DisassemblerAutoLabelKind.FirstInstruction |
                         Arm64DisassemblerAutoLabelKind.Branches |
                         Arm64DisassemblerAutoLabelKind.Calls |
                         Arm64DisassemblerAutoLabelKind.ConditionalBranches |
                         Arm64DisassemblerAutoLabelKind.TestCompareBranches
    }
};
```

The default is `Arm64DisassemblerAutoLabelKind.All`, which preserves the previous behavior of labeling all supported PC-relative operands plus the first instruction when `PrintLabelBeforeFirstInstruction` is enabled.

### Disassembler formatting options

Formatting can be tuned without replacing the disassembler. `Arm64DisassemblerOptions.Style` applies a preset (`Default`, `Gas`, or `Llvm`), and individual options can customize generated label text, comment prefix, address prefix, and disassembler-owned hex casing:

```csharp
var disassembler = new Arm64Disassembler
{
    Options =
    {
        Style = Arm64DisassemblyStyle.Gas,
        LocalLabelFormat = ".L{0}",
        CommentPrefix = ";",
        AddressPrefix = "0x",
        UseUppercaseHex = false
    }
};
```

Status flag access can be shown today with `TryFormatComment`:

```csharp
disassembler.Options.TryFormatComment = (offset, instruction, destination, out int written) =>
{
    var access = instruction.StatusFlags;
    if (!access.ReadsAny && !access.WritesAny)
    {
        written = 0;
        return false;
    }

    return destination.TryWrite($"reads: {access.Read}; writes: {access.Written}", out written);
};
```

### Quick assemble/disassemble roundtrip

When an assembler owns its byte buffer, call `Disassemble()` after `End()` for a quick listing using the assembler base address:

```csharp
using var asm = new Arm64Assembler(0x1000);

asm.MOVZ(X0, 1)
   .RET()
   .End();

string text = asm.Disassemble();
```

For a standalone buffer, use the static helper:

```csharp
string text = Arm64Disassembler.DisassembleToString(code, baseAddress: 0x1000);
```

### Performance guidance and scope

The default `Arm64Assembler` owns a growable byte buffer and is optimized for convenient code generation. Reuse an assembler with `Begin(...)`/`Reset()` when repeatedly generating code, and call `ToArray()` only when a stable copy is required. Advanced users that only emit instructions can still provide a custom `Arm64InstructionBuffer` to control storage.

AsmArm64 is scoped to assembly, disassembly, metadata, diagnostics, and layout helpers. It is not an ARM64 simulator or emulator.

