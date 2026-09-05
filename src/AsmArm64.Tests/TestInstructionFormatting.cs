// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

[TestClass]
public class TestInstructionFormatting
{
    [TestMethod]
    [DataRow(256, "X", "#0x100")]
    [DataRow(-256, "X", "#-0x100")]
    [DataRow(0, "x", "#0x0")]
    [DataRow(172, "x", "#0xac")]
    [DataRow(172, "X", "#0xAC")]
    [DataRow(134217724, null, "#134217724")]
    [DataRow(-134217728, "H", "#-134217728")]
    public void LabelFormatsAgree(int offset, string? format, string expected)
    {
        var instruction = Arm64Instruction.Decode(Arm64InstructionFactory.B(offset));
        var operand = (Arm64LabelOperand)instruction.GetOperand(0);
        var label = new Arm64LabelOffset(offset);
        Assert.AreEqual(expected, operand.ToString(format, null));
        Assert.AreEqual(expected, label.ToString(format, null));
        Assert.AreEqual((format == "H" ? "B " : "b ") + expected, instruction.ToString(format, null));

        Span<char> destination = stackalloc char[expected.Length];
        Assert.IsTrue(operand.TryFormat(destination, out var written, format, null));
        Assert.AreEqual(expected, destination[..written].ToString());
        Assert.IsTrue(label.TryFormat(destination, out written, format, null));
        Assert.AreEqual(expected, destination[..written].ToString());
        Assert.IsFalse(operand.TryFormat(destination[..^1], out written, format, null));
        Assert.AreEqual(0, written);
        Assert.IsFalse(label.TryFormat(destination[..^1], out written, format, null));
        Assert.AreEqual(0, written);
    }

    [TestMethod]
    public void LabelOffsetFormatsMinimumValue()
    {
        var label = new Arm64LabelOffset(int.MinValue);
        Assert.AreEqual("#-0x80000000", label.ToString("X", null));
        Assert.AreEqual("#-2147483648", label.ToString());
    }

    [TestMethod]
    public void LabelCallbackTakesPrecedenceOverNumericFormat()
    {
        var instruction = Arm64Instruction.Decode(Arm64InstructionFactory.B(256));
        Span<char> destination = stackalloc char[64];
        Assert.IsTrue(instruction.TryFormat(destination, out var written, "X", null,
            (long offset, Span<char> text, out int count) =>
            {
                Assert.AreEqual(256L, offset);
                count = 6;
                return "target".AsSpan().TryCopyTo(text);
            }));
        Assert.AreEqual("b target", destination[..written].ToString());
    }
}
