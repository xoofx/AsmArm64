# Converting ARM64 assembly snippets to AsmArm64 C#

This guide shows how to translate common ARM64 assembly patterns into the fluent AsmArm64 API.

## Function with a loop

Assembly:

```asm
sum_loop:
    mov     x1, #0
    mov     x2, #0
loop:
    add     x1, x1, x2
    add     x2, x2, #1
    cmp     x2, x0
    b.lt    loop
    mov     x0, x1
    ret
```

C#:

```csharp
using static AsmArm64.Arm64Factory;

using var asm = new Arm64Assembler(0x1000);

asm.BeginFunction("sum_loop")
   .Label(out var sumLoop)
   .MOVZ(X1, 0)
   .MOVZ(X2, 0)
   .Label(out var loop)
   .ADD(X1, X1, X2)
   .ADD(X2, X2, 1)
   .CMP(X2, X0)
   .B(LT, loop)
   .MOV(X0, X1)
   .RET()
   .EndFunction("sum_loop")
   .End();
```

## Forward branches

Assembly:

```asm
    cbz x0, done
    add x0, x0, #1
done:
    ret
```

C#:

```csharp
asm.CBZ(X0, out var done)
   .ADD(X0, X0, 1)
   .Label(done)
   .RET()
   .End();
```

## Raw data and alignment

```csharp
asm.Align(16)
   .BeginDataSection("constants")
   .AppendUInt64(0x1122334455667788UL)
   .EndDataSection();
```

## Address materialization

For page-relative materialization, use the page helpers:

```csharp
var symbol = new Arm64Label(0x1234_5678, "symbol");

asm.ADRP(X0, symbol.Page())
   .ADD(X0, X0, (uint)symbol.PageOffset().Evaluate());
```

## Literal pools

```csharp
var literal = asm.Literal(0x1122334455667788UL, "constant");
asm.LDR(X0, literal)
   .FlushLiteralPool()
   .End();
```

## Disassemble with symbols

```csharp
var text = new Arm64Disassembler
{
    Options =
    {
        BaseAddress = (long)asm.BaseAddress,
        TryFormatLabel = (address, destination, out int written) =>
        {
            if ((ulong)address == loop.Address) return destination.TryWrite("loop", out written);
            written = 0;
            return false;
        }
    }
}.Disassemble(asm.Buffer);
```
