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
    public void TestDefaultAssemblerOwnsByteBuffer()
    {
        using var asm = new Arm64Assembler(0x1800_0000);

        asm.MOVZ(X0, 5);
        asm.RET();
        asm.End();

        Assert.AreEqual(8u, asm.CurrentOffset);
        Assert.AreEqual(8u, asm.SizeInBytes);
        Assert.AreEqual(0x1800_0008UL, asm.CurrentAddress);
        Assert.IsTrue(asm.IsFinalized);
        Assert.IsFalse(asm.HasPendingPatches);

        var bytes = asm.ToArray();
        CollectionAssert.AreEqual(bytes, asm.Buffer.ToArray());

        var instructions = MemoryMarshal.Cast<byte, uint>(bytes);
        Assert.AreEqual(2, instructions.Length);
        Assert.AreEqual(Arm64InstructionId.MOV_movz_64_movewide, Arm64Instruction.Decode(instructions[0]).Id);
        Assert.AreEqual(Arm64InstructionId.RET_64r_branch_reg, Arm64Instruction.Decode(instructions[1]).Id);
    }

    [TestMethod]
    public void TestDefaultAssemblerLifecycleAndCallbacks()
    {
        using var asm = new Arm64Assembler();
        var callbackCount = 0;

        asm.AppendByte(0xFF)
           .OnResolveEnd(() => callbackCount++)
           .Begin(0x2000)
           .AppendUInt32(0x12345678)
           .End();

        Assert.AreEqual(0, callbackCount, "Begin should clear callbacks from a previous assembly session.");
        Assert.AreEqual(0x2004UL, asm.CurrentAddress);
        CollectionAssert.AreEqual(new byte[] { 0x78, 0x56, 0x34, 0x12 }, asm.ToArray());
        Assert.IsTrue(asm.IsFinalized);

        asm.OnResolveEnd(() => callbackCount++).End();

        Assert.AreEqual(1, callbackCount);
        asm.End();
        Assert.AreEqual(1, callbackCount, "Callbacks should be one-shot after End().");

        asm.Begin(0x2000)
           .AppendUInt32(0xAABBCCDD)
           .Org(0x3000);

        Assert.AreEqual(0x3000UL, asm.CurrentAddress);
    }

    [TestMethod]
    public void TestRawAppendAndAlignDirectives()
    {
        using var asm = new Arm64Assembler();

        asm.AppendByte(0x12)
           .AppendUInt16(0x3456)
           .AppendUInt32(0x789ABCDE)
           .AppendUInt64(0x0102030405060708UL)
           .AppendBytes(2, 0xEE)
           .Align(4, 0xCC)
           .AppendInstruction(Arm64InstructionFactory.NOP());

        CollectionAssert.AreEqual(new byte[]
        {
            0x12,
            0x56, 0x34,
            0xDE, 0xBC, 0x9A, 0x78,
            0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01,
            0xEE, 0xEE,
            0xCC, 0xCC, 0xCC,
            0x1F, 0x20, 0x03, 0xD5,
        }, asm.ToArray());

        Assert.AreEqual(24u, asm.SizeInBytes);
    }

    [TestMethod]
    public void TestDefaultAssemblerPatchesLabelsInOwnedBuffer()
    {
        using var asm = new Arm64Assembler();

        var label = asm.CreateLabelId("target");
        asm.B(Arm64ConditionalKind.AL, label);
        Assert.IsTrue(asm.HasPendingPatches);

        asm.BindLabel(label);
        asm.End();

        Assert.IsFalse(asm.HasPendingPatches);
        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        var instruction = Arm64Instruction.Decode(instructions[0]);
        var labelOperand = (Arm64LabelOperand)instruction.GetOperand(1);
        Assert.AreEqual(4, labelOperand.Offset);
    }

    [TestMethod]
    public void TestCustomInstructionBufferStillSupported()
    {
        var instructionBuffer = new Arm64InstructionBufferByList();
        var asm = new Arm64Assembler(instructionBuffer);

        asm.Nop().End();

        Assert.AreSame(instructionBuffer, asm.InstructionBuffer);
        Assert.AreEqual(1, instructionBuffer.Instructions.Count);
        Assert.AreEqual(Arm64InstructionFactory.NOP(), instructionBuffer.Instructions[0]);
        Assert.Throws<NotSupportedException>(() => asm.ToArray());
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
    public void TestDisassemblerReadOnlySpan()
    {
        var instructionBuffer = AssembleInstructionsSample();
        var disassembler = new Arm64Disassembler();

        ReadOnlySpan<byte> readOnlyBuffer = instructionBuffer;
        var disassembledText = disassembler.Disassemble(readOnlyBuffer);

        using var textWriter = new StringWriter();
        disassembler.Disassemble(readOnlyBuffer, textWriter);

        StringAssert.Contains(disassembledText, "mov x0, #5");
        StringAssert.Contains(disassembledText, "ret");
        Assert.AreEqual(disassembledText, textWriter.ToString());
    }

    [TestMethod]
    public async Task TestDisassemblerCustomLabels()
    {
        var instructionBuffer = AssembleInstructionsSample();
        var disassembler = new Arm64Disassembler()
        {
            Options =
            {
                BaseAddress = 0x1800_0000,
                TryFormatLabel = (long address, Span<char> destination, out int written) =>
                {
                    switch (address)
                    {
                        case 0x1800_0000:
                            return destination.TryWrite($"_start", out written);
                        case 0x1800_000C:
                            return destination.TryWrite($"sum_loop", out written);
                        case 0x1800_0014:
                            return destination.TryWrite($"loop_start", out written);
                        default:
                            written = 0;
                            return false;
                    }
                }
            }
        };
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
