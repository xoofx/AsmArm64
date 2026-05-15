// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

using static Arm64Factory;

[TestClass]
public class TestInstructionStatusFlags
{
    [TestMethod]
    public void TestAddSubCompareAndTestFlagWriters()
    {
        AssertStatusFlags(Arm64InstructionFactory.ADDS(X0, X1, X2), Arm64StatusFlags.None, Arm64StatusFlags.NZCV);
        AssertStatusFlags(Arm64InstructionFactory.SUBS(X0, X1, X2), Arm64StatusFlags.None, Arm64StatusFlags.NZCV);
        AssertStatusFlags(Arm64InstructionFactory.CMP(X2, X0), Arm64StatusFlags.None, Arm64StatusFlags.NZCV);
        AssertStatusFlags(Arm64InstructionFactory.CMN(X2, X0), Arm64StatusFlags.None, Arm64StatusFlags.NZCV);
        AssertStatusFlags(Arm64InstructionFactory.TST(X2, X0), Arm64StatusFlags.None, Arm64StatusFlags.NZCV);
    }

    [TestMethod]
    public void TestCarryAndConditionalFlagReaders()
    {
        AssertStatusFlags(Arm64InstructionFactory.ADC(X0, X1, X2), Arm64StatusFlags.C, Arm64StatusFlags.None);
        AssertStatusFlags(Arm64InstructionFactory.ADCS(X0, X1, X2), Arm64StatusFlags.C, Arm64StatusFlags.NZCV);
        AssertStatusFlags(Arm64InstructionFactory.B(Arm64ConditionalKind.EQ, 4), Arm64StatusFlags.NZCV, Arm64StatusFlags.None);
        AssertStatusFlags(Arm64InstructionFactory.CSEL(X0, X1, X2, Arm64ConditionalKind.EQ), Arm64StatusFlags.NZCV, Arm64StatusFlags.None);
        AssertStatusFlags(Arm64InstructionFactory.CCMP(X0, X1, 0, Arm64ConditionalKind.EQ), Arm64StatusFlags.NZCV, Arm64StatusFlags.NZCV);
    }

    [TestMethod]
    public void TestNonFlagInstructionHasNoFlagAccess()
    {
        AssertStatusFlags(Arm64InstructionFactory.MOVZ(X0, 1), Arm64StatusFlags.None, Arm64StatusFlags.None);
        Assert.AreEqual(default, Arm64InstructionId.Invalid.GetStatusFlagAccess());
    }

    private static void AssertStatusFlags(uint rawInstruction, Arm64StatusFlags expectedRead, Arm64StatusFlags expectedWritten)
    {
        var instruction = Arm64Instruction.Decode(rawInstruction);
        Assert.AreEqual(expectedRead, instruction.ReadStatusFlags);
        Assert.AreEqual(expectedWritten, instruction.WrittenStatusFlags);
        Assert.AreEqual(expectedRead, instruction.StatusFlags.Read);
        Assert.AreEqual(expectedWritten, instruction.StatusFlags.Written);
        Assert.AreEqual(expectedRead, instruction.Id.GetReadStatusFlags());
        Assert.AreEqual(expectedWritten, instruction.Id.GetWrittenStatusFlags());
    }
}
