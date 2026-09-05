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

`Arm64InstructionFormattingOptions` is shared by single-instruction formatting and
`Arm64DisassemblerOptions.InstructionFormatting`. Preferred aliases remain the
default; select `AliasMode = Arm64InstructionAliasMode.BaseInstruction` to print
base mnemonics and operands. Existing string-format overloads remain supported.

Numeric label operands now honor `x`/`X`, including signed hexadecimal offsets.
`Arm64LabelOffset.ToString(format, provider)` now agrees with its other formatting
methods (`#256`, rather than the former diagnostic `Value: 256`).

Unresolved full-disassembler targets still default to relative offsets. Set
`LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress` to request absolute
hexadecimal targets explicitly. ADRP target calculations now use the PC page;
unaligned targets no longer produce undefined generated labels, and excluded
auto-label kinds no longer reuse other kinds' labels.

Lines exceeding `FormatLineBufferLength` now throw `InvalidOperationException`
instead of silently truncating output. Increase the configured capacity if needed.

## Diagnostics and metadata

Label finalization errors throw `Arm64AssemblerException` with structured diagnostics. Use `TryEnd(out var diagnostics)` for non-throwing workflows.

## Scope

AsmArm64 remains an assembler/disassembler library. It does not include an ARM64 simulator or emulator.
