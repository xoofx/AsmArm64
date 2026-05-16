# AsmArm64 2.0 migration notes

AsmArm64 2.0 keeps the low-level strongly typed instruction APIs, but adds a higher-level assembler workflow for day-to-day code generation.

## Assembler construction and finalization

Prefer an owned-buffer assembler for simple code generation:

```csharp
using var asm = new Arm64Assembler(0x1000);
asm.MOVZ(X0, 1)
   .RET()
   .End();

ReadOnlySpan<byte> code = asm.Buffer;
byte[] stableCopy = asm.ToArray();
```

`Assemble()` remains as a compatibility alias for `End()`. New code should call `End()`.

Advanced callers can continue to pass a custom `Arm64InstructionBuffer`; byte-oriented APIs such as `Buffer`, `Append`, raw data, literal pools, and `ToArray()` require the owned byte buffer.

## Labels

Prefer object labels:

```csharp
asm.Label(out var loop)
   .ADD(X0, X0, 1)
   .B(loop)
   .End();
```

Replace older label-id code:

```csharp
var id = asm.CreateLabelId("loop");
asm.BindLabel(id);
asm.B(id);
```

with:

```csharp
asm.Label("loop", out var loop);
asm.B(loop);
```

Forward labels can be declared explicitly with `LabelForward(out var label)` or inline on generated label operands:

```csharp
asm.CBZ(X0, out var done)
   .ADD(X0, X0, 1)
   .Label(done)
   .RET()
   .End();
```

## Fluent generated methods

Generated assembler instruction methods now return the assembler so calls can be chained. Statement-style calls are still valid when the return value is ignored.

## Disassembly labels

`Arm64DisassemblerOptions.TryFormatLabel` receives absolute target addresses. This makes symbol lookup from PDBs, map files, or object metadata straightforward.

## Diagnostics and metadata

Label finalization errors throw `Arm64AssemblerException` with structured diagnostics. Use `TryEnd(out var diagnostics)` for non-throwing workflows.

Status flag metadata is available through `Arm64Instruction.ReadStatusFlags`, `Arm64Instruction.WrittenStatusFlags`, and `Arm64InstructionId` extension methods.

## Scope

AsmArm64 remains an assembler/disassembler library. It does not include an ARM64 simulator or emulator.
