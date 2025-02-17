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

The API `Arm64Disassembler` is a more advanced API that can be used to disassemble a sequence of instructions. The `Arm64Disassembler` object can be used to disassemble instructions from a given buffer.

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
- Resolve labels offset to label names (The given offset is relative to the beginning of the buffer)
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

The API `Arm64Assembler` is a more advanced API that can be used to assemble a sequence of instructions. The `Arm64Assembler` object can be used to assemble instructions to a given buffer.

The output buffer can be:
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

var bufferList = new Arm64InstructionBufferByList();
var asm = new Arm64Assembler(bufferList);
// Main entry point
// _start:
var labelStart = asm.CreateLabelId("_start");
asm.BindLabel(labelStart);
//     mov     x0, #5         // Call sum_loop(5)
asm.MOVZ(X0, 5);
//     bl      sum_loop       // Call the function, result in x0
var labelSumLoop = asm.CreateLabelId("sum_loop");
asm.BL(labelSumLoop);
// 
//     // Do something with result (for now, just returning)
//     ret                    // Return from _start (normally would return to a caller)
asm.RET();
// 
// 
// // Function: sum_loop(x0)
// // - Takes x0 as the loop limit
// // - Returns the sum in x0
// sum_loop:
asm.BindLabel(labelSumLoop);
//     mov     x1, #0         // Accumulator (sum)
asm.MOVZ(X1, 0);
//     mov     x2, #0         // Counter
asm.MOVZ(X2, 0);
// 
// loop_start:
var labelLoopStart = asm.CreateLabelId("loop_start");
asm.BindLabel(labelLoopStart);
//     add     x1, x1, x2     // Add counter (x2) to sum (x1)
asm.ADD(X1, X1, X2);
//     add     x2, x2, #1     // Increment counter
asm.ADD(X2, X2, 1);
// 
//     cmp     x2, x0         // Compare counter with limit
asm.CMP(X2, X0);
//     blt     loop_start     // If counter < limit, continue loop
asm.B(LT, labelLoopStart);
// 
//     mov     x0, x1         // Store result in x0 (return value)
asm.MOV(X0, X1);
//     ret                    // Return to caller
asm.RET();
asm.Assemble();
```

Notice the API to create and use the labels:
- `Arm64Assembler.CreateLabelId` to create a label with a unique identifier
  - A label can be associated with an absolute address if required.
- `Arm64Assembler.BindLabel` to bind a label to the current position in the buffer

