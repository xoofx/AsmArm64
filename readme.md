# AsmArm64 [![ci](https://github.com/xoofx/AsmArm64/actions/workflows/ci.yml/badge.svg)](https://github.com/xoofx/AsmArm64/actions/workflows/ci.yml) [![NuGet](https://img.shields.io/nuget/v/AsmArm64.svg)](https://www.nuget.org/packages/AsmArm64/)

<img align="right" width="160px" height="160px" src="https://raw.githubusercontent.com/xoofx/AsmArm64/main/img/AsmArm64.png">

AsmArm64 is a powerful ARM64 Assembler and Disassembler .NET library.

## ✨ Features

- **Full support of `2448+` ARM64 v8.x/v9.x instructions**
  - Automatically generated from ARM XML specification files from latest update `2024-12`.
  - Note that SVE/SVE2/SME are not yet supported.
- Unique **strongly typed** assembler API
- **Easily disassemble** instructions and operands, including the knowledge of which operands and status flags are being read/write.
- **High performance** / **zero allocation** library for disassembling / assembling instructions.
- `15,000+` unit tests battle testing this library
- Compatible with `net8.0+` and NativeAOT.

## 💻 Example

### Strongly Typed Assembler API

```c#
using var asm = new Arm64Assembler(0x1_0000);

// // Main entry point
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
// Bytes available in asm.Buffer or asm.ToArray()
```

Generated instruction methods return the assembler, so calls can be chained. Statement-style calls still work when the returned assembler is ignored.

### Disassembler API

```c#
ReadOnlySpan<byte> instructionBuffer = asm.Buffer;
var disassembler = new Arm64Disassembler();
var textWriter = new StringWriter();
disassembler.Disassemble(instructionBuffer, textWriter);
Console.WriteLine(textWriter);
```

will print:

```asm
LL_01:
    mov x0, #5
    bl LL_02

    ret

LL_02:
    mov x1, #0
    mov x2, #0

LL_03:
    add x1, x1, x2
    add x2, x2, #1
    cmp x2, x0
    b.lt LL_03

    mov x0, x1
    ret
```

`Arm64DisassemblerOptions.TryFormatLabel` can be used to resolve absolute addresses to label or symbol names, for example from PDB data.

## 📖 User Guide

For more details on how to use AsmArm64, please visit the [user guide](https://github.com/xoofx/AsmArm64/blob/main/doc/readme.md).

## 🪪 License

This software is released under the [BSD-2-Clause license](https://opensource.org/licenses/BSD-2-Clause). 

## 🤗 Author

Alexandre Mutel aka [xoofx](https://xoofx.github.io).
