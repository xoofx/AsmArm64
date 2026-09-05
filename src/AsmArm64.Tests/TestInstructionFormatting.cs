// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Globalization;
using static AsmArm64.Arm64Factory;
using static AsmArm64.Arm64InstructionFactory;

namespace AsmArm64.Tests;

[TestClass]
public class TestInstructionFormatting
{
    [TestMethod]
    public void TypedOptionsSeparateTextHexAndAliasModes()
    {
        var instruction = Arm64Instruction.Decode(MOVZ(X0, 0xAB, default, 16));
        var options = new Arm64InstructionFormattingOptions
        {
            AliasMode = Arm64InstructionAliasMode.BaseInstruction,
            UseUppercaseText = true,
            ImmediateFormat = Arm64NumericFormat.Hexadecimal,
        };
        AssertFormat(instruction, options, "MOVZ X0, #0xab, LSL #16");
        options.UseUppercaseHex = true;
        options.UseUppercaseText = false;
        AssertFormat(instruction, options, "movz x0, #0xAB, lsl #16");
        options.AliasMode = Arm64InstructionAliasMode.Preferred;
        AssertFormat(instruction, options, "mov x0, #0xAB0000");
    }

    [TestMethod]
    public void DisassemblerSharesInstructionOptions()
    {
        var options = new Arm64InstructionFormattingOptions
        {
            AliasMode = Arm64InstructionAliasMode.BaseInstruction,
            UseUppercaseText = true,
            ImmediateFormat = Arm64NumericFormat.Hexadecimal,
            LabelOffsetFormat = Arm64NumericFormat.Hexadecimal,
        };
        var disassembler = new Arm64Disassembler(new Arm64DisassemblerOptions
        {
            InstructionFormatting = options,
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None,
            IndentSize = 0,
        });
        foreach (var raw in new[] { MOVZ(X0, 0xAB, default, 16), B(-256) })
            Assert.AreEqual(Arm64Instruction.Decode(raw).ToString(options), disassembler.Disassemble(BitConverter.GetBytes(raw)).Trim());

        disassembler.Options.Style = Arm64DisassemblyStyle.Gas;
        Assert.IsTrue(options.UseUppercaseText);
        Assert.AreEqual(Arm64InstructionAliasMode.BaseInstruction, options.AliasMode);
        Assert.Throws<ArgumentNullException>(() => disassembler.Options.InstructionFormatting = null!);
    }

    [TestMethod]
    [DataRow(0, "#0")]
    [DataRow(9, "#9")]
    [DataRow(10, "#0xa")]
    [DataRow(-9, "#-9")]
    [DataRow(-10, "#-0xa")]
    public void AutoNumericFormatHasDocumentedBoundary(int value, string expected)
    {
        var options = new Arm64InstructionFormattingOptions { LabelOffsetFormat = Arm64NumericFormat.Auto };
        AssertFormat(Arm64Instruction.Decode(ADR(X0, value)), options, "adr x0, " + expected);
        options.MemoryOffsetFormat = Arm64NumericFormat.Auto;
        AssertFormat(Arm64Instruction.Decode(LDUR(X0, _[X1, value])), options,
            value == 0 ? "ldur x0, [x1]" : "ldur x0, [x1, " + expected + "]");
    }

    [TestMethod]
    public void MemoryFormattingIncludesPreAndPostIndexedDisplacements()
    {
        var options = new Arm64InstructionFormattingOptions { MemoryOffsetFormat = Arm64NumericFormat.Hexadecimal };
        AssertFormat(Arm64Instruction.Decode(LDR(X0, _[X1, 256])), options, "ldr x0, [x1, #0x100]");
        AssertFormat(Arm64Instruction.Decode(LDR(X0, _[X1, -16].Pre)), options, "ldr x0, [x1, #-0x10]!");
        AssertFormat(Arm64Instruction.Decode(LDR(X0, _[X1], -16)), options, "ldr x0, [x1], #-0x10");
        AssertFormat(Arm64Instruction.Decode(ADD(X0, X1, (ushort)256)), options, "add x0, x1, #256");
        options.ImmediateFormat = Arm64NumericFormat.Hexadecimal;
        AssertFormat(Arm64Instruction.Decode(FMOV(D0, 0.5f)), options, "fmov d0, #0.50000000");
        AssertFormat(Arm64Instruction.Decode(MOVN(X0, 0)), options, "mov x0, #-0x1");
    }

    [TestMethod]
    public void ExplicitOptionsOverrideBitMaskDefaults()
    {
        var instruction = Arm64Instruction.Decode(AND(X0, X1, Arm64LogicalImmediate64.Encode(0xFF00)));
        var options = new Arm64InstructionFormattingOptions { UseUppercaseHex = true };
        AssertFormat(instruction, options, "and x0, x1, #0xFF00");
        options.ImmediateFormat = Arm64NumericFormat.Decimal;
        AssertFormat(instruction, options, "and x0, x1, #65280");
        options.ImmediateFormat = Arm64NumericFormat.Hexadecimal;
        AssertFormat(Arm64Instruction.Decode(AND(X0, X1, Arm64LogicalImmediate64.Encode(0x8000000000000000))), options,
            "and x0, x1, #0x8000000000000000");
    }

    [TestMethod]
    public void OptionalDefaultsCanBePrinted()
    {
        var options = new Arm64InstructionFormattingOptions { PrintDefaultOperands = true };
        AssertFormat(Arm64Instruction.Decode(RET()), options, "ret x30");
        AssertFormat(Arm64Instruction.Decode(LDR(X0, _[X1, 0])), options, "ldr x0, [x1, #0]");
        options.AliasMode = Arm64InstructionAliasMode.BaseInstruction;
        AssertFormat(Arm64Instruction.Decode(MOVZ(X0, 1)), options, "movz x0, #1, lsl #0");
    }

    [TestMethod]
    public void StringFormattingGrowsForLongNumericProviders()
    {
        var provider = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
        provider.NegativeSign = new string('~', 300);
        var options = new Arm64InstructionFormattingOptions { FormatProvider = provider };
        var instruction = Arm64Instruction.Decode(B(-4));
        AssertFormat(instruction, options, "b #" + provider.NegativeSign + "4");
        Assert.AreEqual(instruction.ToString(options), instruction.ToString(null, provider));
    }

    [TestMethod]
    public void FormattingOptionsRejectInvalidValues()
    {
        var options = new Arm64InstructionFormattingOptions();
        Assert.Throws<ArgumentOutOfRangeException>(() => options.AliasMode = (Arm64InstructionAliasMode)(-1));
        Assert.Throws<ArgumentOutOfRangeException>(() => options.ImmediateFormat = (Arm64NumericFormat)99);
        Assert.Throws<ArgumentOutOfRangeException>(() => options.MemoryOffsetFormat = (Arm64NumericFormat)(-1));
        Assert.Throws<ArgumentOutOfRangeException>(() => options.LabelOffsetFormat = (Arm64NumericFormat)99);
        Assert.Throws<ArgumentNullException>(() => default(Arm64Instruction).ToString((Arm64InstructionFormattingOptions)null!));
    }

    internal static void AssertFormat(Arm64Instruction instruction, Arm64InstructionFormattingOptions options, string expected)
    {
        Assert.AreEqual(expected, instruction.ToString(options));
        Span<char> destination = new char[expected.Length];
        Assert.IsTrue(instruction.TryFormat(destination, out var written, options));
        Assert.AreEqual(expected, destination[..written].ToString());
        Assert.IsFalse(instruction.TryFormat(destination[..^1], out written, options));
        Assert.AreEqual(0, written);
    }

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
