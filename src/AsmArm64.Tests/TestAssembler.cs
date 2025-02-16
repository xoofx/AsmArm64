// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.InteropServices;

namespace AsmArm64.Tests;

using static Arm64Factory;

[TestClass]
public class TestAssembler : VerifyBase
{
    [TestMethod]
    public void TestSimple()
    {
        var accessor = new Arm64InstructionBufferByList();
        var asm = new Arm64Assembler(accessor);
        var label = asm.CreateLabelId("Hello");
        asm.B(Arm64ConditionalKind.AL, label);
        asm.BindLabel(label);
        asm.Assemble();

        var instructions = accessor.Instructions;
        Assert.AreEqual(1, instructions.Count);

        var instruction = Arm64Instruction.Decode(instructions[0]);
        Assert.AreEqual(Arm64InstructionId.B_only_condbranch, instruction.Id);
        var operand1 = instruction.GetOperand(0);
        Assert.AreEqual(Arm64OperandKind.Enum, operand1.Kind);
        
        var operand2 = instruction.GetOperand(1);
        Assert.AreEqual(Arm64OperandKind.Label, operand2.Kind);

        var labelOperand2 = (Arm64LabelOperand)operand2;
        Assert.AreEqual(4, labelOperand2.Offset);
    }

    [TestMethod]
    public async Task TestDisassemblerSimple()
    {
        var instructionBuffer = AssembleInstructionsSample();
        var disassembler = new Arm64Disassembler();
        var textWriter = new StringWriter();
        disassembler.Disassemble(instructionBuffer, textWriter);

        var disassembledText = textWriter.ToString();

        await Verify(disassembledText);
    }

    [TestMethod]
    public async Task TestDisassemblerDetailed()
    {
        var instructionBuffer = AssembleInstructionsSample();
        var disassembler = new Arm64Disassembler
        {
            Options =
            {
                PrintAddress = true,
                PrintAssemblyBytes = true
            }
        };

        var textWriter = new StringWriter();
        
        disassembler.Disassemble(instructionBuffer, textWriter);

        var disassembledText = textWriter.ToString();
        await Verify(disassembledText);
    }

    [TestMethod]
    public async Task TestDisassemblerAdvanced()
    {
        var instructionBuffer = AssembleInstructionsSample();
        var disassembler = new Arm64Disassembler
        {
            Options =
            {
                PrintAddress = true,
                PrintAssemblyBytes = true,
                PreInstructionPrinter = (offset, instruction, writer) => writer.WriteLine($"// Id: {instruction.Id}, Class: {instruction.Class}, Flags: {instruction.Flags}, OperandCount: {instruction.OperandCount}"),
                PostInstructionPrinter = (offset, instruction, writer) => writer.WriteLine($"// End of instruction {instruction.Id}"),
                TryFormatComment = (long offset, Arm64Instruction instruction, Span<char> destination, out int written) => destination.TryWrite($"<- {instruction.Id}, Feature: {instruction.FeatureExpressionId}", out written)
            }
        };

        var textWriter = new StringWriter();

        disassembler.Disassemble(instructionBuffer, textWriter);

        var disassembledText = textWriter.ToString();
        await Verify(disassembledText);
    }

    private static byte[] AssembleInstructionsSample()
    {
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

        return MemoryMarshal.Cast<uint, byte>(CollectionsMarshal.AsSpan(bufferList.Instructions)).ToArray();
    }
}