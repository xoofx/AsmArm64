# AsmArm64 [![ci](https://github.com/xoofx/AsmArm64/actions/workflows/ci.yml/badge.svg)](https://github.com/xoofx/AsmArm64/actions/workflows/ci.yml) [![NuGet](https://img.shields.io/nuget/v/AsmArm64.svg)](https://www.nuget.org/packages/AsmArm64/)

<img align="right" width="160px" height="160px" src="https://raw.githubusercontent.com/xoofx/AsmArm64/main/img/AsmArm64.png">

AsmArm64 is a powerful ARM64 Assembler and Disassembler .NET library.

## ✨ Features

- **Full support of `2448+` ARM64 v8.x/v9.x instructions**
  - Automatically generated from ARM XML specification files from latest update `2024-12`.
  - Note that SVE/SVE2/SME are not yet supported.
- Unique **strongly typed** assembler API
- **Easily disassemble** instructions and operands, including the knowledge of which operands are being read/write.
- **High performance** / **zero allocation** library for disassembling / assembling instructions.
- `15,000+` unit tests battle testing this library
- Compatible with `net8.0+` and NativeAOT.

## 💻 Example

### Strongly Typed Assembler API

```c#
var bufferList = new Arm64InstructionBufferByList();
var asm = new Arm64Assembler(bufferList);

// // Main entry point
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
// Instructions available in bufferList.Instructions
```
### Disassembler API

```c#
var instructionBuffer = ...; /// Retrieve the buffer from above
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

## 📖 User Guide

For more details on how to use AsmArm64, please visit the [user guide](https://github.com/xoofx/AsmArm64/blob/main/doc/readme.md).

## 🪪 License

This software is released under the [BSD-2-Clause license](https://opensource.org/licenses/BSD-2-Clause). 

## 🤗 Author

Alexandre Mutel aka [xoofx](https://xoofx.github.io).
