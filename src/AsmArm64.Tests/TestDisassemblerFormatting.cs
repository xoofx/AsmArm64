// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Globalization;
using static AsmArm64.Arm64Factory;
using static AsmArm64.Arm64InstructionFactory;

namespace AsmArm64.Tests;

[TestClass]
public class TestDisassemblerFormatting
{
    [TestMethod]
    public void RelativeAndAbsoluteFallbackAreIndependentOfRadix()
    {
        var options = new Arm64DisassemblerOptions
        {
            BaseAddress = 0x1000,
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None,
        };
        var disassembler = new Arm64Disassembler(options);
        var bytes = BitConverter.GetBytes(B(-256));
        Assert.AreEqual("b #-256", disassembler.Disassemble(bytes).Trim());
        options.InstructionFormatting.LabelOffsetFormat = Arm64NumericFormat.Hexadecimal;
        Assert.AreEqual("b #-0x100", disassembler.Disassemble(bytes).Trim());
        options.LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress;
        Assert.AreEqual("b #0x0000000000000F00", disassembler.Disassemble(bytes).Trim());
        options.UseUppercaseHex = false;
        options.AddressPrefix = "$";
        Assert.AreEqual("b #$0000000000000f00", disassembler.Disassemble(bytes).Trim());
        options.AddressPrefix = string.Empty;
        Assert.AreEqual("adrp x0, #0x0000000000002000", disassembler.Disassemble(BitConverter.GetBytes(ADRP(X0, 4096))).Trim());
        Assert.Throws<ArgumentOutOfRangeException>(() => options.LabelFallback = (Arm64DisassemblerLabelFallback)99);
    }

    [TestMethod]
    [DataRow(long.MaxValue - 3, 4, "8000000000000000")]
    [DataRow(long.MinValue, -4, "7FFFFFFFFFFFFFFC")]
    public void AbsoluteAddressesWrapAt64Bits(long baseAddress, int offset, string target)
    {
        var disassembler = new Arm64Disassembler(new Arm64DisassemblerOptions
        {
            BaseAddress = baseAddress,
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None,
            LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress,
        });
        Assert.AreEqual("b #0x" + target, disassembler.Disassemble(BitConverter.GetBytes(B(offset))).Trim());
    }

    [TestMethod]
    public void ListingProviderOverridesSharedProvider()
    {
        var sharedProvider = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
        sharedProvider.NegativeSign = "!";
        var listingProvider = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
        listingProvider.NegativeSign = "~";
        var options = new Arm64DisassemblerOptions
        {
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None,
            FormatProvider = listingProvider,
            InstructionFormatting = new Arm64InstructionFormattingOptions { FormatProvider = sharedProvider },
        };
        var disassembler = new Arm64Disassembler(options);
        Assert.AreEqual("b #~4", disassembler.Disassemble(BitConverter.GetBytes(B(-4))).Trim());
        options.FormatProvider = null;
        Assert.AreEqual("b #!4", disassembler.Disassemble(BitConverter.GetBytes(B(-4))).Trim());
    }

    public static IEnumerable<object[]> PcRelativeExamples()
    {
        yield return [B(256), "b #0x0000000000001104"];
        yield return [B(EQ, 256), "b.eq #0x0000000000001104"];
        yield return [CBZ(X0, 256), "cbz x0, #0x0000000000001104"];
        yield return [TBZ(W0, 2, 256), "tbz w0, #2, #0x0000000000001104"];
        yield return [TBZ(X0, 33, 256), "tbz x0, #33, #0x0000000000001104"];
        yield return [ADR(X0, 256), "adr x0, #0x0000000000001104"];
        yield return [LDR(X0, 256), "ldr x0, #0x0000000000001104"];
        yield return [ADRP(X0, 4096), "adrp x0, #0x0000000000002000"];
    }

    [TestMethod]
    [DynamicData(nameof(PcRelativeExamples))]
    public void AbsoluteFallbackUsesCurrentPc(uint raw, string expected)
    {
        var disassembler = new Arm64Disassembler(new Arm64DisassemblerOptions
        {
            BaseAddress = 0x1000,
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None,
            LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress,
        });
        var bytes = BitConverter.GetBytes(NOP()).Concat(BitConverter.GetBytes(raw)).ToArray();
        StringAssert.Contains(disassembler.Disassemble(bytes), expected);
    }

    [TestMethod]
    public void SymbolsPrecedeEligibleLocalLabelsAndFallback()
    {
        var options = new Arm64DisassemblerOptions
        {
            BaseAddress = 0x1000,
            PrintLabelBeforeFirstInstruction = false,
            LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress,
        };
        var disassembler = new Arm64Disassembler(options);
        var bytes = BitConverter.GetBytes(B(4)).Concat(BitConverter.GetBytes(NOP())).ToArray();
        StringAssert.Contains(disassembler.Disassemble(bytes), "b LL_01");
        options.TryFormatLabel = (long address, Span<char> destination, out int written) =>
        {
            Assert.AreEqual(0x1004L, address);
            written = 6;
            return "symbol".AsSpan().TryCopyTo(destination);
        };
        var text = disassembler.Disassemble(bytes);
        StringAssert.Contains(text, "b symbol");
        StringAssert.Contains(text, "symbol:");
        options.TryFormatLabel = (long address, Span<char> destination, out int written) => { written = 0; return false; };
        StringAssert.Contains(disassembler.Disassemble(bytes), "b LL_01");
        options.AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None;
        text = disassembler.Disassemble(bytes);
        StringAssert.Contains(text, "b #0x0000000000001004");
        Assert.IsFalse(text.Contains("LL_"));
    }

    [TestMethod]
    public void ExcludedTargetKindsDoNotReuseOtherKindsLabels()
    {
        var options = new Arm64DisassemblerOptions
        {
            PrintLabelBeforeFirstInstruction = false,
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.Branches,
        };
        var bytes = BitConverter.GetBytes(ADR(X0, 8)).Concat(BitConverter.GetBytes(B(4))).Concat(BitConverter.GetBytes(NOP())).ToArray();
        var text = new Arm64Disassembler(options).Disassemble(bytes);
        StringAssert.Contains(text, "adr x0, #8");
        StringAssert.Contains(text, "b LL_01");
        StringAssert.Contains(text, "LL_01:");
    }

    [TestMethod]
    public void LargePageOffsetDoesNotWrapToAnInternalLabel()
    {
        // ADRP x0, #-4294967296: the signed displacement cannot be represented by Arm64LabelOffset's int.
        var bytes = BitConverter.GetBytes(0x90800000U);
        var options = new Arm64DisassemblerOptions { BaseAddress = 0x1000 };
        var disassembler = new Arm64Disassembler(options);
        StringAssert.Contains(disassembler.Disassemble(bytes), "adrp x0, #-4294967296");
        options.LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress;
        StringAssert.Contains(disassembler.Disassemble(bytes), "adrp x0, #0xFFFFFFFF00001000");
    }

    [TestMethod]
    [DataRow(0x1234L, 4096, 0x2000L)]
    [DataRow(0x1234L, -4096, 0L)]
    [DataRow(-4092L, 0, -4096L)]
    public void AdrpResolverReceivesPageRelativeTarget(long baseAddress, int offset, long target)
    {
        var options = new Arm64DisassemblerOptions
        {
            BaseAddress = baseAddress,
            AutoLabelKinds = Arm64DisassemblerAutoLabelKind.None,
            TryFormatLabel = (long address, Span<char> destination, out int written) =>
            {
                Assert.AreEqual(target, address);
                written = 4;
                return "page".AsSpan().TryCopyTo(destination);
            },
        };
        Assert.AreEqual("adrp x0, page", new Arm64Disassembler(options).Disassemble(BitConverter.GetBytes(ADRP(X0, offset))).Trim());
    }

    [TestMethod]
    public void AdrpAutoLabelUsesPageRatherThanInstructionAddress()
    {
        var options = new Arm64DisassemblerOptions
        {
            BaseAddress = 0x1000,
            PrintLabelBeforeFirstInstruction = false,
            PrintNewLineBeforeLabel = false,
            PrintNewLineAfterBranch = false,
            IndentSize = 0,
        };
        var bytes = BitConverter.GetBytes(NOP()).Concat(BitConverter.GetBytes(ADRP(X0, 0))).ToArray();
        Assert.AreEqual("LL_01:\nnop\nadrp x0, LL_01\n", new Arm64Disassembler(options).Disassemble(bytes).Replace(Environment.NewLine, "\n"));
    }

    [TestMethod]
    public void NonInstructionTargetsDoNotBecomeUndefinedLabels()
    {
        var options = new Arm64DisassemblerOptions { PrintLabelBeforeFirstInstruction = false };
        var text = new Arm64Disassembler(options).Disassemble(BitConverter.GetBytes(ADR(X0, 1)));
        Assert.AreEqual("adr x0, #1", text.Trim());
    }

    [TestMethod]
    public void SmallLineBufferDoesNotSilentlyDropInstructionText()
    {
        var options = new Arm64DisassemblerOptions
        {
            FormatLineBufferLength = 256,
            IndentSize = 250,
            PrintLabelBeforeFirstInstruction = false,
        };
        var exception = Assert.Throws<InvalidOperationException>(() => new Arm64Disassembler(options).Disassemble(BitConverter.GetBytes(MOVZ(X0, 256))));
        StringAssert.Contains(exception.Message, nameof(options.FormatLineBufferLength));
    }

    [TestMethod]
    public void OversizedAddressAndLabelPrefixesFailClearly()
    {
        var options = new Arm64DisassemblerOptions
        {
            FormatLineBufferLength = 256,
            PrintLabelBeforeFirstInstruction = false,
            PrintAddress = true,
            AddressPrefix = new string('a', 300),
        };
        var disassembler = new Arm64Disassembler(options);
        Assert.Throws<InvalidOperationException>(() => disassembler.Disassemble(BitConverter.GetBytes(NOP())));
        options.PrintAddress = false;
        options.PrintLabelBeforeFirstInstruction = true;
        options.LocalLabelPrefix = new string('L', 300);
        Assert.Throws<InvalidOperationException>(() => disassembler.Disassemble(BitConverter.GetBytes(NOP())));
    }

    [TestMethod]
    public void ExactLineCapacityWorksAndTrailingBytesRespectCapacity()
    {
        var options = new Arm64DisassemblerOptions
        {
            FormatLineBufferLength = 256,
            IndentSize = 253,
            PrintLabelBeforeFirstInstruction = false,
            InvalidDataMode = Arm64InvalidDataMode.EmitBytes,
        };
        var disassembler = new Arm64Disassembler(options);
        Assert.AreEqual(new string(' ', 253) + "nop" + Environment.NewLine, disassembler.Disassemble(BitConverter.GetBytes(NOP())));
        Assert.Throws<InvalidOperationException>(() => disassembler.Disassemble(new byte[] { 0xAB }));
        options.IndentSize = 0;
        Assert.AreEqual(".byte 0xAB", disassembler.Disassemble(new byte[] { 0xAB }).Trim());
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(10000)]
    public void InvalidCallbackCountsFailClearly(int count)
    {
        var options = new Arm64DisassemblerOptions
        {
            PrintLabelBeforeFirstInstruction = false,
            TryFormatLabel = (long address, Span<char> destination, out int written) => { written = count; return true; },
        };
        var disassembler = new Arm64Disassembler(options);
        Assert.Throws<InvalidOperationException>(() => disassembler.Disassemble(BitConverter.GetBytes(B(256))));
        options.PrintLabelBeforeFirstInstruction = true;
        Assert.Throws<InvalidOperationException>(() => disassembler.Disassemble(BitConverter.GetBytes(NOP())));
        options.TryFormatLabel = null;
        options.TryFormatComment = (long offset, Arm64Instruction instruction, Span<char> destination, out int written) => { written = count; return true; };
        Assert.Throws<InvalidOperationException>(() => disassembler.Disassemble(BitConverter.GetBytes(NOP())));
    }

    [TestMethod]
    public void AbsoluteTargetsNeverSilentlyFallBackWhenBufferIsTooSmall()
    {
        var options = new Arm64DisassemblerOptions
        {
            FormatLineBufferLength = 256,
            IndentSize = 240,
            PrintLabelBeforeFirstInstruction = false,
            LabelFallback = Arm64DisassemblerLabelFallback.AbsoluteAddress,
        };
        Assert.Throws<InvalidOperationException>(() => new Arm64Disassembler(options).Disassemble(BitConverter.GetBytes(B(256))));
        Assert.Throws<ArgumentNullException>(() => new Arm64Disassembler(null!));
    }
}
