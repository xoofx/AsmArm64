// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

using static Arm64Factory;

[TestClass]
public class SimpleTests
{
    [TestMethod]
    public void TestRegistersToString()
    {
        Assert.AreEqual("x0", X0.ToString());
        Assert.AreEqual("x1", X1.ToString());
        Assert.AreEqual("sp", SP.ToString());
        Assert.AreEqual("xzr", XZR.ToString());
    }

    [TestMethod]
    public void TestSTR_64_ldst_pos()
    {
        Span<byte> rawInstruction = [0xe1, 0x0b, 0x00, 0xf9];
        var instruction = Arm64Instruction.Decode(BitConverter.ToUInt32(rawInstruction));
        Assert.AreEqual("str x1, [sp, #16]", instruction.ToString());
    }

    [TestMethod]
    public void TestSTP_64_ldstpair_off()
    {
        Span<byte> rawInstruction = [0xFD, 0x7B, 0x01, 0xA9];
        var instruction = Arm64Instruction.Decode(BitConverter.ToUInt32(rawInstruction));
        Assert.AreEqual("stp x29, x30, [sp, #16]", instruction.ToString());
    }

    [TestMethod]
    public void DecodeArm64Simple()
    {
        // add x12, x7, x1
        var rawInstruction = 0x8B0100EC;
        var instruction = Arm64Instruction.Decode(rawInstruction);
        Assert.AreEqual(Arm64Mnemonic.ADD, instruction.Mnemonic);

        Assert.AreEqual(4, instruction.OperandCount);
        Assert.AreEqual(Arm64OperandKind.Register, instruction.GetOperand(0).Kind);
        Assert.AreEqual(Arm64OperandKind.Register, instruction.GetOperand(1).Kind);
        Assert.AreEqual(Arm64OperandKind.Register, instruction.GetOperand(2).Kind);
        Assert.AreEqual(Arm64OperandKind.Shift, instruction.GetOperand(3).Kind);

        var op0 = (Arm64RegisterOperand)instruction.GetOperand(0);
        var op1 = (Arm64RegisterOperand)instruction.GetOperand(1);
        var op2 = (Arm64RegisterOperand)instruction.GetOperand(2);
        var op3 = (Arm64ShiftOperand)instruction.GetOperand(3);
        var op0RegX = (Arm64RegisterX)op0.Value;
        var op1RegX = (Arm64RegisterX)op1.Value;
        var op2RegX = (Arm64RegisterX)op2.Value;

        Assert.AreEqual(X12, op0RegX);
        Assert.AreEqual(X7, op1RegX);
        Assert.AreEqual(X1, op2RegX);
        Assert.AreEqual(0, op3.Amount);
        Assert.AreEqual(Arm64ShiftKind.LSL, op3.ShiftKind);

        Assert.AreEqual("add x12, x7, x1", instruction.ToString());
        Assert.AreEqual("ADD X12, X7, X1", instruction.ToString("H", null));
    }

    // Test `IEquatable<Arm64Instruction>` implementation behavior of Arm64Instruction.
    [TestMethod]
    public void TestArm64InstructionEquality()
    {
        {
            // mov x0, #0x100
            uint rawInstruction = Arm64InstructionFactory.MOV(Arm64RegisterX.X0, 0x100);
            var instruction1 = Arm64Instruction.Decode(rawInstruction);
            var instruction2 = Arm64Instruction.Decode(rawInstruction);

            Assert.AreEqual(instruction1, instruction2);

            var baseInstruction = instruction1.AsBaseInstruction(); // orr x0, xzr, #0x100
            Assert.AreNotEqual(instruction1, baseInstruction);
        }
        {
            // movz x0, #256
            uint rawInstruction = Arm64InstructionFactory.MOVZ(Arm64RegisterX.X0, 0x100);
            var instruction1 = Arm64Instruction.Decode(rawInstruction); // mov x0, #256
            var instruction2 = Arm64Instruction.Decode(rawInstruction); // mov x0, #256

            Assert.AreEqual(instruction1, instruction2);

            var baseInstruction = instruction1.AsBaseInstruction(); // movz x0, #256
            Assert.AreNotEqual(instruction1, baseInstruction);
        }
        {
            // Operators, hash code, and object equality
            var instruction1 = Arm64Instruction.Decode(Arm64InstructionFactory.MOVZ(Arm64RegisterX.X0, 0x100));
            var instruction2 = Arm64Instruction.Decode(Arm64InstructionFactory.MOVZ(Arm64RegisterX.X0, 0x100));
            var otherEncoding = Arm64Instruction.Decode(Arm64InstructionFactory.MOVZ(Arm64RegisterX.X1, 0x100));

            Assert.IsTrue(instruction1 == instruction2);
            Assert.IsFalse(instruction1 != instruction2);
            Assert.AreEqual(instruction1.GetHashCode(), instruction2.GetHashCode());
            Assert.IsTrue(instruction1.Equals((object)instruction2));

            Assert.IsFalse(instruction1 == otherEncoding);
            Assert.IsTrue(instruction1 != otherEncoding);
            Assert.IsFalse(instruction1 == instruction1.AsBaseInstruction());
            Assert.IsFalse(instruction1.Equals(null));
            Assert.IsFalse(instruction1.Equals((object)instruction1.RawInstruction));
        }
    }

    static Arm64Instruction Print(uint rawValue)
    {
        var instruction = Arm64Instruction.Decode(rawValue);
        Console.WriteLine($"{string.Join(" ", BitConverter.GetBytes(rawValue).Select(x => x.ToString("X2")))} -> {instruction}");
        return instruction;
    }
}
