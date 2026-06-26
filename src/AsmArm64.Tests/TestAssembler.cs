// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
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
        var label = asm.CreateLabel("Hello");
        asm.B(Arm64ConditionalKind.AL, label);
        asm.Label(label);
        asm.End();

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

        var label = asm.CreateLabel("target");
        asm.B(Arm64ConditionalKind.AL, label);
        Assert.IsTrue(asm.HasPendingPatches);

        asm.Label(label);
        asm.End();

        Assert.IsFalse(asm.HasPendingPatches);
        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        var instruction = Arm64Instruction.Decode(instructions[0]);
        var labelOperand = (Arm64LabelOperand)instruction.GetOperand(1);
        Assert.AreEqual(4, labelOperand.Offset);
    }

    [TestMethod]
    public void TestGeneratedAssemblerMethodsAreFluent()
    {
        using var asm = new Arm64Assembler();

        var returned = asm.MOVZ(X0, 1)
                          .ADD(X0, X0, 2)
                          .RET()
                          .End();

        Assert.AreSame(asm, returned);
        Assert.AreEqual(12u, asm.SizeInBytes);
        Assert.IsTrue(asm.IsFinalized);
    }

    [TestMethod]
    public void TestObjectLabelHelpers()
    {
        using var asm = new Arm64Assembler(0x4000);

        asm.Label(out var inferred);
        Assert.AreEqual("inferred", inferred.Name);
        Assert.AreEqual(0x4000UL, inferred.Address);

        asm.LabelForward("done", out var done)
           .CBZ(X0, done)
           .MOVZ(X0, 1)
           .Label(done)
           .RET()
           .End();

        Assert.AreEqual("done", done.Name);
        Assert.IsTrue(done.IsBound);
        Assert.AreEqual(0x4008UL, done.Address);

        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        var branch = Arm64Instruction.Decode(instructions[0]);
        var labelOperand = (Arm64LabelOperand)branch.GetOperand(1);
        Assert.AreEqual(8, labelOperand.Offset);
    }

    [TestMethod]
    public void TestGeneratedForwardLabelOverload()
    {
        using var asm = new Arm64Assembler(0x5000);

        asm.CBZ(X0, out var done)
           .MOVZ(X0, 1)
           .Label(done)
           .RET()
           .End();

        Assert.AreEqual("done", done.Name);
        Assert.AreEqual(0x5008UL, done.Address);

        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        var branch = Arm64Instruction.Decode(instructions[0]);
        var labelOperand = (Arm64LabelOperand)branch.GetOperand(1);
        Assert.AreEqual(8, labelOperand.Offset);
    }

    [TestMethod]
    public void TestRepresentativeGeneratedForwardLabelOverloads()
    {
        using var b = new Arm64Assembler();
        b.B(out var branchTarget).Label(branchTarget).End();
        Assert.IsTrue(branchTarget.IsBound);

        using var bl = new Arm64Assembler();
        bl.BL(out var callTarget).Label(callTarget).End();
        Assert.IsTrue(callTarget.IsBound);

        using var tbz = new Arm64Assembler();
        tbz.TBZ(X0, 0, out var testTarget).Label(testTarget).End();
        Assert.IsTrue(testTarget.IsBound);

        using var adr = new Arm64Assembler();
        adr.ADR(X0, out var addressTarget).Label(addressTarget).End();
        Assert.IsTrue(addressTarget.IsBound);
    }

    [TestMethod]
    public void TestLabelBindingCoverage()
    {
        using var asm = new Arm64Assembler(0x8000);

        asm.Label(out var start)
           .B(out var forward)
           .NOP()
           .Label(forward)
           .B(start)
           .End();

        Assert.AreEqual(0x8000UL, start.Address);
        Assert.AreEqual(0x8008UL, forward.Address);

        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        var forwardBranch = Arm64Instruction.Decode(instructions[0]);
        var backwardBranch = Arm64Instruction.Decode(instructions[2]);

        Assert.AreEqual(8, ((Arm64LabelOperand)forwardBranch.GetOperand(0)).Offset);
        Assert.AreEqual(-8, ((Arm64LabelOperand)backwardBranch.GetOperand(0)).Offset);

        var duplicate = Assert.Throws<InvalidOperationException>(() => asm.Label(forward));
        StringAssert.Contains(duplicate.Message, "forward");

        asm.Label(forward, force: true);
        Assert.AreEqual(asm.CurrentAddress, forward.Address);
    }

    [TestMethod]
    public void TestUnboundLabelDiagnostic()
    {
        using var asm = new Arm64Assembler(0x9000);

        asm.B(out var missing);

        var exception = Assert.Throws<Arm64AssemblerException>(() => asm.End());

        StringAssert.Contains(exception.Message, "missing");
        Assert.AreEqual(1, exception.Diagnostics.Count);
        var diagnostic = exception.Diagnostics[0];
        Assert.AreEqual(Arm64AssemblerDiagnosticSeverity.Error, diagnostic.Severity);
        Assert.AreEqual("missing", diagnostic.LabelName);
        Assert.AreEqual(0u, diagnostic.Offset);
        Assert.AreEqual(0x9000UL, diagnostic.Address);
        Assert.AreEqual(Arm64InstructionId.B_only_branch_imm, diagnostic.InstructionId);
    }

    [TestMethod]
    public void TestOutOfRangeLabelDiagnostic()
    {
        using var asm = new Arm64Assembler(0xA000);
        var far = new Arm64Label(0x2000_0000UL, "far");

        var exception = Assert.Throws<Arm64AssemblerException>(() => asm.B(far));

        StringAssert.Contains(exception.Message, "far");
        StringAssert.Contains(exception.Message, "out of range");
        Assert.AreEqual(1, exception.Diagnostics.Count);
        Assert.AreEqual("far", exception.Diagnostics[0].LabelName);
        Assert.AreEqual(Arm64InstructionId.B_only_branch_imm, exception.Diagnostics[0].InstructionId);
    }

    [TestMethod]
    public void TestTryEndReturnsDiagnostics()
    {
        using var asm = new Arm64Assembler();

        asm.B(out var missing);

        var success = asm.TryEnd(out var diagnostics);

        Assert.IsFalse(success);
        Assert.AreEqual(1, diagnostics.Count);
        Assert.AreEqual("missing", diagnostics[0].LabelName);
    }

    [TestMethod]
    public void TestDebugMapCapturesGeneratedCallerInfo()
    {
        using var asm = new Arm64Assembler(0xB000);

        var expectedLine = CurrentLine() + 1;
        asm.ADC(X0, X1, X2);

        Assert.IsNotNull(asm.DebugMap);
        var entries = asm.DebugMap.Entries.Where(x => x.Kind == Arm64AssemblerDebugInfoKind.LineInfo).ToArray();
        Assert.AreEqual(1, entries.Length);
        var entry = entries[0];
        Assert.AreEqual(0u, entry.Offset);
        Assert.AreEqual(0xB000UL, entry.Address);
        Assert.AreEqual(Arm64InstructionId.ADC_64_addsub_carry, entry.InstructionId);
        StringAssert.EndsWith(entry.FilePath, "TestAssembler.cs");
        Assert.AreEqual(expectedLine, entry.LineNumber);
    }

    [TestMethod]
    public void TestDebugMapCapturesSectionAndFunctionMarkers()
    {
        using var asm = new Arm64Assembler(0xB100);

        var expectedLine = CurrentLine() + 1;
        asm.BeginFunction("sum")
           .BeginCodeSection("text")
           .NOP()
           .EndCodeSection()
           .BeginDataSection("rodata")
           .AppendUInt32(0x12345678)
           .EndDataSection()
           .EndFunction("sum")
           .End();

        Assert.IsNotNull(asm.DebugMap);
        var entries = asm.DebugMap.Entries;
        var functionBegin = entries.Single(x => x.Kind == Arm64AssemblerDebugInfoKind.FunctionBegin);
        Assert.AreEqual("sum", functionBegin.Name);
        Assert.AreEqual(0u, functionBegin.Offset);
        Assert.AreEqual(0xB100UL, functionBegin.Address);
        StringAssert.EndsWith(functionBegin.FilePath, "TestAssembler.cs");
        Assert.AreEqual(expectedLine, functionBegin.LineNumber);

        Assert.IsTrue(entries.Any(x => x.Kind == Arm64AssemblerDebugInfoKind.CodeSectionBegin && x.Name == "text"));
        Assert.IsTrue(entries.Any(x => x.Kind == Arm64AssemblerDebugInfoKind.CodeSectionEnd && x.Offset == 4));
        Assert.IsTrue(entries.Any(x => x.Kind == Arm64AssemblerDebugInfoKind.DataSectionBegin && x.Name == "rodata" && x.Offset == 4));
        Assert.IsTrue(entries.Any(x => x.Kind == Arm64AssemblerDebugInfoKind.DataSectionEnd && x.Offset == 8));
        Assert.IsTrue(entries.Any(x => x.Kind == Arm64AssemblerDebugInfoKind.FunctionEnd && x.Name == "sum" && x.Offset == 8));
    }

    [TestMethod]
    public void TestExpressionEvaluationAfterLabelsAreBound()
    {
        using var asm = new Arm64Assembler(0xC000);

        asm.Label(out var labelA)
           .NOP()
           .NOP()
           .Label(out var labelB);

        Arm64Expression delta = labelB - labelA;
        Arm64AddressExpression adjusted = labelA + 12;

        Assert.AreEqual(8, delta.Evaluate());
        Assert.AreEqual(0xC00CUL, (ulong)adjusted.Evaluate());

        var labels = new HashSet<Arm64Label>();
        adjusted.CollectLabels(labels);
        CollectionAssert.Contains(labels.ToArray(), labelA);
    }

    [TestMethod]
    public void TestLabelArithmeticBranchAndAdrOperands()
    {
        using var branchAsm = new Arm64Assembler(0xD000);
        branchAsm.B(out var branchTarget)
                 .NOP()
                 .Label(branchTarget)
                 .B(branchTarget + 4)
                 .End();

        var branchInstructions = MemoryMarshal.Cast<byte, uint>(branchAsm.Buffer);
        Assert.AreEqual(Arm64InstructionFactory.B(8), branchInstructions[0]);
        Assert.AreEqual(Arm64InstructionFactory.B(4), branchInstructions[2]);
        var firstBranch = Arm64Instruction.Decode(branchInstructions[0]);
        var secondBranch = Arm64Instruction.Decode(branchInstructions[2]);
        Assert.AreEqual(8, ((Arm64LabelOperand)firstBranch.GetOperand(0)).Offset);
        Assert.AreEqual(4, ((Arm64LabelOperand)secondBranch.GetOperand(0)).Offset);

        using var adrAsm = new Arm64Assembler(0xE000);
        adrAsm.Label(out var adrBase)
              .ADR(X0, adrBase + 16)
              .End();

        var adrInstruction = Arm64Instruction.Decode(MemoryMarshal.Cast<byte, uint>(adrAsm.Buffer)[0]);
        Assert.AreEqual(Arm64InstructionFactory.ADR(X0, 16), MemoryMarshal.Cast<byte, uint>(adrAsm.Buffer)[0]);
        Assert.AreEqual(16, ((Arm64LabelOperand)adrInstruction.GetOperand(1)).Offset);
    }

    [TestMethod]
    public void TestAddressPageHelpersAndAdrpPageSemantics()
    {
        var symbol = new Arm64Label(0x3008UL, "symbol");
        Assert.AreEqual(0x3000, symbol.Page().Evaluate());
        Assert.AreEqual(8, symbol.PageOffset().Evaluate());

        using var asm = new Arm64Assembler(0x1000);
        asm.NOP()
           .ADRP(X0, symbol)
           .End();

        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        Assert.AreEqual(Arm64InstructionFactory.ADRP(X0, 0x2000), instructions[1]);
        var adrp = Arm64Instruction.Decode(instructions[1]);
        Assert.AreEqual(0x2000, ((Arm64LabelOperand)adrp.GetOperand(1)).Offset);
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
    public void TestArrangeBlocksFixedFloatingAlignmentAndOverlap()
    {
        using var asm = new Arm64Assembler(0x1000);
        var fixedLabel = asm.CreateLabel("fixed");
        var floatingLabel = asm.CreateLabel("floating");

        asm.AppendByte(0xAA)
           .ArrangeBlocks(
               new Arm64Block(floatingLabel, [0x11, 0x22], alignment: 4),
               new Arm64Block(fixedLabel, [0xBB], address: 0x1004));

        CollectionAssert.AreEqual(new byte[] { 0xAA, 0, 0, 0, 0xBB, 0, 0, 0, 0x11, 0x22 }, asm.ToArray());
        Assert.AreEqual(0x1004UL, fixedLabel.Address);
        Assert.AreEqual(0x1008UL, floatingLabel.Address);

        using var overlapAsm = new Arm64Assembler(0x2000);
        overlapAsm.AppendBytes(4);
        var overlap = overlapAsm.CreateLabel("overlap");
        Assert.Throws<InvalidOperationException>(() => overlapAsm.ArrangeBlocks(new Arm64Block(overlap, [0xCC], address: 0x2002)));
    }

    [TestMethod]
    public void TestLiteralPoolAndExternalRelocation()
    {
        using var asm = new Arm64Assembler(0x3000);
        var literal = asm.Literal(0x1122334455667788UL, "constant");
        var external = asm.ExternalLabel("puts");

        asm.LDR(X0, literal)
           .BL(external)
           .FlushLiteralPool()
           .End();

        var instructions = MemoryMarshal.Cast<byte, uint>(asm.Buffer);
        Assert.AreEqual(Arm64InstructionFactory.LDR(X0, 8), instructions[0]);
        Assert.AreEqual(0x3008UL, literal.Address);
        CollectionAssert.AreEqual(new byte[] { 0x88, 0x77, 0x66, 0x55, 0x44, 0x33, 0x22, 0x11 }, asm.Buffer.Slice(8, 8).ToArray());
        Assert.AreEqual(1, asm.Relocations.Count);
        Assert.AreEqual(Arm64RelocationKind.PcRelative, asm.Relocations[0].Kind);
        Assert.AreEqual(4u, asm.Relocations[0].Offset);
        Assert.AreSame(external, asm.Relocations[0].Label);
    }

    [TestMethod]
    public void TestRawFactoryApisWorkWithoutAssemblerLifecycle()
    {
        var raw = Arm64InstructionFactory.ADD(X0, X1, 1);
        var instruction = Arm64Instruction.Decode(raw);

        Assert.AreEqual(Arm64InstructionId.ADD_64_addsub_imm, instruction.Id);
        Assert.AreEqual(Arm64Mnemonic.ADD, instruction.Mnemonic);
    }

    [TestMethod]
    public void TestRealisticFunctionGenerationWithDebugComments()
    {
        using var asm = new Arm64Assembler(0x4000);
        var helper = asm.ExternalLabel("helper");
        var literal = asm.Literal(0x0102030405060708UL, "constant");

        asm.BeginFunction("sum")
           .BeginCodeSection("text")
           .MOVZ(X0, 4)
           .MOVZ(X1, 0)
           .Label(out var loop)
           .ADD(X1, X1, X0)
           .SUBS(X0, X0, 1)
           .B(GT, loop)
           .BL(helper)
           .LDR(X2, literal)
           .RET()
           .EndCodeSection()
           .BeginDataSection("literals")
           .FlushLiteralPool()
           .EndDataSection()
           .EndFunction("sum")
           .End();

        Assert.AreEqual(1, asm.Relocations.Count);
        Assert.AreEqual("helper", asm.Relocations[0].Label.Name);
        Assert.IsTrue(asm.SizeInBytes >= 40);

        var disassembler = new Arm64Disassembler
        {
            Options =
            {
                BaseAddress = (long)asm.BaseAddress,
                TryFormatComment = (long offset, Arm64Instruction instruction, Span<char> destination, out int written) =>
                {
                    var entry = asm.DebugMap!.Entries.LastOrDefault(x => x.Offset == (uint)offset && x.Kind == Arm64AssemblerDebugInfoKind.LineInfo);
                    if (entry.InstructionId != Arm64InstructionId.Invalid)
                    {
                        return destination.TryWrite($"{entry.InstructionId}", out written);
                    }

                    written = 0;
                    return false;
                }
            }
        };

        var text = disassembler.Disassemble(asm.Buffer);
        StringAssert.Contains(text, "b.gt LL_");
        StringAssert.Contains(text, "ldr x2, LL_");
        StringAssert.Contains(text, "// MOVZ_64_movewide");
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
    public void TestDisassemblerTrailingByteModes()
    {
        var instructionBuffer = Arm64InstructionFactory.NOP();
        var bytes = MemoryMarshal.AsBytes(new[] { instructionBuffer }.AsSpan()).ToArray();
        var buffer = bytes.Concat(new byte[] { 0xAA, 0xBB }).ToArray();

        var throwingDisassembler = new Arm64Disassembler();
        var exception = Assert.Throws<ArgumentException>(() => throwingDisassembler.Disassemble(buffer));
        StringAssert.Contains(exception.Message, "6 bytes");
        StringAssert.Contains(exception.Message, "4-byte");

        var emitDisassembler = new Arm64Disassembler
        {
            Options =
            {
                InvalidDataMode = Arm64InvalidDataMode.EmitBytes,
                PrintLabelBeforeFirstInstruction = false,
                PrintNewLineBeforeLabel = false
            }
        };

        var emitText = emitDisassembler.Disassemble(buffer);
        StringAssert.Contains(emitText, "nop");
        StringAssert.Contains(emitText, ".byte 0xAA, 0xBB");

        var ignoreDisassembler = new Arm64Disassembler
        {
            Options =
            {
                InvalidDataMode = Arm64InvalidDataMode.Ignore,
                PrintLabelBeforeFirstInstruction = false,
                PrintNewLineBeforeLabel = false
            }
        };

        var ignoreText = ignoreDisassembler.Disassemble(buffer);
        StringAssert.Contains(ignoreText, "nop");
        Assert.IsFalse(ignoreText.Contains(".byte", StringComparison.Ordinal));
    }

    [TestMethod]
    public void TestDisassemblerAutoLabelKindsControlAdrAndLiteralLabels()
    {
        using var asm = new Arm64Assembler(0xF000);
        asm.ADR(X0, out var adrTarget)
           .LDR(X1, out var literalTarget)
           .B(out var branchTarget)
           .Label(adrTarget)
           .NOP()
           .Label(literalTarget)
           .NOP()
           .Label(branchTarget)
           .RET()
           .End();

        var branchOnlyDisassembler = new Arm64Disassembler
        {
            Options =
            {
                AutoLabelKinds = Arm64DisassemblerAutoLabelKind.FirstInstruction | Arm64DisassemblerAutoLabelKind.Branches,
                PrintNewLineBeforeLabel = false,
                PrintNewLineAfterBranch = false,
            }
        };

        var branchOnlyText = branchOnlyDisassembler.Disassemble(asm.Buffer);
        StringAssert.Contains(branchOnlyText, "adr x0, #12");
        StringAssert.Contains(branchOnlyText, "ldr x1, #12");
        StringAssert.Contains(branchOnlyText, "b LL_02");

        var allPcRelativeDisassembler = new Arm64Disassembler
        {
            Options =
            {
                AutoLabelKinds = Arm64DisassemblerAutoLabelKind.All,
                PrintNewLineBeforeLabel = false,
                PrintNewLineAfterBranch = false,
            }
        };

        var allText = allPcRelativeDisassembler.Disassemble(asm.Buffer);
        StringAssert.Contains(allText, "adr x0, LL_02");
        StringAssert.Contains(allText, "ldr x1, LL_03");
        StringAssert.Contains(allText, "b LL_04");
    }

    [TestMethod]
    public void TestDisassembleConvenienceRoundtrip()
    {
        using var asm = new Arm64Assembler(0x1234_0000);

        asm.Label(out var start)
           .MOVZ(X0, 1)
           .B(out var done)
           .ADD(X0, X0, 1)
           .Label(done)
           .RET()
           .End();

        var instanceText = asm.Disassemble();
        StringAssert.Contains(instanceText, "LL_01:");
        StringAssert.Contains(instanceText, "mov x0, #1");
        StringAssert.Contains(instanceText, "b LL_02");
        StringAssert.Contains(instanceText, "ret");
        Assert.AreEqual(0x1234_0000UL, start.Address);

        var staticText = Arm64Disassembler.DisassembleToString(asm.Buffer, 0x1234_0000);
        Assert.AreEqual(instanceText, staticText);
    }

    [TestMethod]
    public void TestDisassemblerFormattingOptions()
    {
        using var asm = new Arm64Assembler(0x1000);
        asm.NOP().End();

        var disassembler = new Arm64Disassembler
        {
            Options =
            {
                BaseAddress = 0x1000,
                PrintAddress = true,
                PrintAssemblyBytes = true,
                UseUppercaseHex = false,
                AddressPrefix = "0x",
                LocalLabelFormat = ".L{0}",
                CommentPrefix = ";",
                TryFormatComment = (long offset, Arm64Instruction instruction, Span<char> destination, out int written) =>
                {
                    written = "comment".Length;
                    return "comment".AsSpan().TryCopyTo(destination);
                }
            }
        };

        var text = disassembler.Disassemble(asm.Buffer);
        StringAssert.Contains(text, ".L1:");
        StringAssert.Contains(text, "0x0000000000001000");
        StringAssert.Contains(text, "1f 20 03 d5");
        StringAssert.Contains(text, "; comment");

        disassembler.Options.Style = Arm64DisassemblyStyle.Llvm;
        Assert.AreEqual(".LBB0_{0}", disassembler.Options.LocalLabelFormat);
        Assert.IsFalse(disassembler.Options.UseUppercaseHex);
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
        asm.Label("_start", out var labelStart);
        //     mov     x0, #5         // Call sum_loop(5)
        asm.MOVZ(X0, 5);
        //     bl      sum_loop       // Call the function, result in x0
        var labelSumLoop = asm.CreateLabel("sum_loop");
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
        asm.Label(labelSumLoop);
        //     mov     x1, #0         // Accumulator (sum)
        asm.MOVZ(X1, 0);
        //     mov     x2, #0         // Counter
        asm.MOVZ(X2, 0);
        // 
        // loop_start:
        asm.Label("loop_start", out var labelLoopStart);
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

#if NETFRAMEWORK
        return MemoryMarshal.Cast<uint, byte>(bufferList.Instructions.ToArray()).ToArray();
#else
        return MemoryMarshal.Cast<uint, byte>(CollectionsMarshal.AsSpan(bufferList.Instructions)).ToArray();
#endif
    }

    private static int CurrentLine([CallerLineNumber] int lineNumber = 0) => lineNumber;
}
