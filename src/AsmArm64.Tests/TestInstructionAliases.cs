// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using static AsmArm64.Arm64Factory;
using static AsmArm64.Arm64InstructionFactory;

namespace AsmArm64.Tests;

[TestClass]
public class TestInstructionAliases
{
    public static IEnumerable<object[]> AliasExamples()
    {
        yield return [MOVZ(X0, 0x100), "mov x0, #256", "movz x0, #256"];
        yield return [MOVZ(X0, 0x100, default, 16), "mov x0, #16777216", "movz x0, #256, lsl #16"];
        yield return [MOVZ(W0, 1, default, 16), "mov w0, #65536", "movz w0, #1, lsl #16"];
        yield return [MOVZ(X0, 0, default, 16), "movz x0, #0, lsl #16", "movz x0, #0, lsl #16"];
        yield return [MOVN(X0, 0), "mov x0, #-1", "movn x0, #0"];
        yield return [MOV(X0, X1), "mov x0, x1", "orr x0, xzr, x1"];
        yield return [CMP(X0, (ushort)1), "cmp x0, #1", "subs xzr, x0, #1"];
        yield return [CSET(X0, EQ), "cset x0, eq", "csinc x0, xzr, xzr, ne"];
        yield return [UBFM(X0, X1, 61, 60), "lsl x0, x1, #3", "ubfm x0, x1, #61, #60"];
        yield return [ROR(W0, W1, (byte)3), "ror w0, w1, #3", "extr w0, w1, w1, #3"];
        yield return [ADD(X0, X1, (ushort)1), "add x0, x1, #1", "add x0, x1, #1"];
        yield return [uint.MaxValue, "???", "???"];
    }

    [TestMethod]
    [DynamicData(nameof(AliasExamples))]
    public void BaseViewUsesBaseOperands(uint raw, string preferredText, string baseText)
    {
        var instruction = Arm64Instruction.Decode(raw);
        var baseInstruction = instruction.AsBaseInstruction();
        Assert.AreEqual(preferredText, instruction.ToString());
        Assert.AreEqual(baseText, baseInstruction.ToString());
        TestInstructionFormatting.AssertFormat(instruction,
            new Arm64InstructionFormattingOptions { AliasMode = Arm64InstructionAliasMode.BaseInstruction }, baseText);
        Assert.AreEqual(raw, baseInstruction.RawInstruction);
        Assert.AreEqual(instruction.Id.GetBaseInstructionId(), baseInstruction.Id);
        Assert.AreEqual(baseInstruction.Mnemonic, baseInstruction.Id.GetMnemonic());
        Assert.AreEqual(baseInstruction.Id, baseInstruction.AsBaseInstruction().Id);
        Assert.AreEqual(instruction.Id, Arm64Instruction.DecodeId(baseInstruction.RawInstruction));
    }

    [TestMethod]
    public void MetadataCoversAllInstructionIds()
    {
        foreach (Arm64InstructionId id in Enum.GetValues(typeof(Arm64InstructionId)))
        {
            var baseId = id.GetBaseInstructionId();
            Assert.IsTrue(Enum.IsDefined(typeof(Arm64InstructionId), baseId), id.ToString());
            Assert.AreEqual(baseId, baseId.GetBaseInstructionId(), id.ToString());
            if (id != Arm64InstructionId.Invalid)
            {
                Assert.AreNotEqual(Arm64Mnemonic.Invalid, id.GetMnemonic(), id.ToString());
                Assert.AreNotEqual(Arm64Mnemonic.Invalid, baseId.GetMnemonic(), id.ToString());
            }
        }

        Assert.AreEqual(Arm64Mnemonic.MOV, Arm64InstructionId.MOV_movz_64_movewide.GetMnemonic());
        Assert.AreEqual(Arm64Mnemonic.MOVZ, Arm64InstructionId.MOV_movz_64_movewide.GetBaseInstructionId().GetMnemonic());
        Assert.AreEqual(Arm64Mnemonic.Invalid, Arm64InstructionId.Invalid.GetMnemonic());
        Assert.Throws<ArgumentOutOfRangeException>(() => ((Arm64InstructionId)ushort.MaxValue).GetMnemonic());
        Assert.Throws<ArgumentOutOfRangeException>(() => ((Arm64InstructionId)ushort.MaxValue).GetBaseInstructionId());
    }
}
