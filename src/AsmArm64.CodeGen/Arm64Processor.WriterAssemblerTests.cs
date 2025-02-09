// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{
    private void WriteInstructionTests(string instClass, Dictionary<string, List<InstructionVariation>> mapMnemonicToInstructions)
    {
        bool isFirst = true;
        foreach (var pair in mapMnemonicToInstructions.OrderBy(x => x.Key))
        {
            // We skip this instruction
            // Reason: it is conflicting with existing instruction.
            //
            // Additional reasons from the XML doc:
            // - A disassembler will disassemble the allocated instruction, rather than the HINT instruction.
            // - An assembler may support assembly of allocated encodings using <instruction>HINT</instruction> with the corresponding <syntax>&lt;imm&gt;</syntax> value, but it is not required to do so.
            if (pair.Key == "HINT") // instruction.Id = HINT_HM_hints
            {
                continue;
            }
            
            using var w = GetWriter(Path.Combine(instClass, $"Arm64InstructionFactoryTests_{pair.Key}.gen.cs"), isTest: true);

            w.WriteLine("using System.Runtime.CompilerServices;");
            w.WriteLine("using static AsmArm64.Arm64InstructionFactory;");
            w.WriteLine("using static AsmArm64.Arm64Factory;");

            w.WriteLine($"namespace AsmArm64.Tests.{instClass};");

            w.WriteLine();
            w.WriteLine("[TestClass]");
            w.WriteLine($"public class Arm64InstructionFactoryTests_{pair.Key}_{instClass}");
            w.OpenBraceBlock();

            for (var i = 0; i < pair.Value.Count; i++)
            {
                var variation = pair.Value[i];
                if (variation.Instruction.IsDiscardedByPreferredAlias || variation.Instruction.Alias is not null || variation.Instruction.AliasesIn.Count > 0) continue;

                if (!isFirst)
                {
                    w.WriteLine();
                }

                isFirst = false;
                WriteInstructionVariationTest(w, variation, i);
            }

            w.CloseBraceBlock();
        }

    }
    
    private void WriteInstructionVariationTest(CodeWriter w, InstructionVariation instructionVariation, int variationIndex)
    {
        var instruction = instructionVariation.Instruction;
        w.WriteSummary($"Test of <see cref=\"Arm64InstructionFactory.{instructionVariation.Mnemonic}\"/>.");
        w.WriteLine("[TestMethod]");
        w.WriteLine($"public void Test_{instructionVariation.Instruction.Id}_{variationIndex}()");
        w.OpenBraceBlock();
        {
            // Write variations
            WriteInstructionVariationFromOperandsTest(w, instructionVariation);
        }
        w.CloseBraceBlock();
    }

    private void WriteInstructionVariationFromOperandsTest(CodeWriter w, InstructionVariation instructionVariation)
    {
        if (instructionVariation.Operands.Any(x => x.TestArguments.Count == 0))
        {
            w.WriteLine("Assert.Inconclusive(\"TODO\");");
            return;
        }

        var operandTestVariations = instructionVariation.Operands.Select(x => x.TestArguments).ToList();
        int varCount = 1;
        foreach (var count in operandTestVariations.Select(x => x.Count))
        {
            varCount *= count;
        }

        var varIndices = new List<int>();
        for (var i = 0; i < operandTestVariations.Count; i++)
        {
            varIndices.Add(0);
        }

        for (int i = 0; i < varCount; i++)
        {
            var testArguments = new List<TestArgument>();

            var localI = i;
            for (var j = 0; j < operandTestVariations.Count; j++)
            {
                int varIndex = varIndices[j];
                var localVarCount = operandTestVariations[j].Count;
                varIndex = localI % localVarCount;
                varIndices[j] = varIndex;
                localI /= localVarCount;
            }

            for (var j = 0; j < operandTestVariations.Count; j++)
            {
                int varIndex = varIndices[j];
                testArguments.Add(operandTestVariations[j][varIndex]);
            }
            
            var instruction = instructionVariation.Instruction;
            w.WriteLine();
            w.OpenBraceBlock();
            //     var raw = ADD(X0, X1, X2);

            for (var argIndex = 0; argIndex < testArguments.Count; argIndex++)
            {
                var testArgument = testArguments[argIndex];
                testArgument.InitializeFromArguments(testArguments, argIndex);
            }
            
            w.WriteLine($"var raw = {instruction.Mnemonic}({string.Join(", ", testArguments.Select(x => x.CSharp))});");
            w.WriteLine("var instruction = Arm64Instruction.Decode(raw);");

            // Special case for LSL instructions that are folded into a single instruction
            if (instructionVariation.ElseVariation is not null && testArguments.OfType<MemoryTestArgument>().Any(x => x.Extend == "LSL"))
            {
                w.WriteLine($"Assert.AreEqual(Arm64InstructionId.{instructionVariation.ElseVariation.Instruction.Id}, instruction.Id);");
            }
            else
            {
                w.WriteLine($"Assert.AreEqual(Arm64InstructionId.{instruction.Id}, instruction.Id);");
            }
            w.WriteLine($"Assert.AreEqual(Arm64Mnemonic.{instruction.Mnemonic}, instruction.Mnemonic);");
            w.WriteLine("var asm = instruction.ToString(\"H\", null);");
            w.WriteLine(testArguments.Count == 0
                ? $"Assert.AreEqual(\"{instruction.Mnemonic}\", asm);"
                : $"Assert.AreEqual(\"{instruction.Mnemonic} {string.Join(", ", testArguments.Select(x => x.Asm))}\", asm);"
            );
            w.CloseBraceBlock();
        }
    }



    private abstract record TestArgument
    {
        public abstract string CSharp { get; }

        public abstract string Asm { get; }

        public virtual void InitializeFromArguments(IReadOnlyList<TestArgument> arguments, int index)
        {
        }
    }

    private record RawTestArgument : TestArgument
    {
        public RawTestArgument(string cSharp, string asm)
        {
            CSharp = cSharp;
            Asm = asm;
        }

        public override string CSharp { get; }
        public override string Asm { get; }
    }

    private record ImmediateTestArgument : TestArgument
    {
        public ImmediateTestArgument(float value)
        {
            Value = BitConverter.SingleToUInt32Bits(value);
            Is32 = true;
            IsFloat = true;
        }

        public ImmediateTestArgument(ulong value, bool hexa = true)
        {
            Value = value;
            Is32 = false;
            IsHexa = hexa;
        }

        public ImmediateTestArgument(ushort value, int shift, bool is32)
        {
            Value = value;
            Shift = shift;
            Is32 = is32;
            IsShift = true;
        }

        public ImmediateTestArgument(int value, bool hexa = false)
        {
            Value = (ulong)(long)value;
            Is32 = true;
            IsHexa = hexa;
        }

        public ulong Value { get; }

        public bool Is32 { get; }

        public bool IsShift { get; }

        public int Shift { get; }

        public bool IsFloat { get; }

        public bool IsHexa { get; }

        public override string CSharp => GetAsText(false);

        public override string Asm => GetAsText(true);

        private string GetAsText(bool isAsm)
        {
            string text;
            if (IsFloat)
            {
                text = Value == 0 ? "0.0" : $"{BitConverter.UInt32BitsToSingle((uint)Value).ToString("0.00000000")}";
                if (!isAsm) text += "f";
            }
            else if (IsShift)
            {
                    text = isAsm ? (Value << Shift).ToString() : $"new({Value}, {Shift})";
            }
            else
            {
                text = IsHexa ? $"0x{Value:x}" : Value.ToString();
                if (!isAsm && !Is32 && IsHexa)
                {
                    text += "UL";
                }
            }

            return isAsm ? $"#{text}" : text;
        }
    }

    private record RegisterGroupTestArgument : TestArgument
    {
        public RegisterGroupTestArgument(RegisterTestArgument baseRegister, int count)
        {
            BaseRegister = baseRegister;
            Count = count;
        }

        public RegisterTestArgument BaseRegister { get; }

        public int? Indexer { get; init; }

        public int Count { get; }

        public override string CSharp => GetAsText(false);

        public override string Asm => GetAsText(true);

        private string GetAsText(bool isAsm)
        {
            if (isAsm)
            {
                var builder = new StringBuilder();
                builder.Append("{ ");
                for (var i = 0; i < Count; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var reg = new RegisterTestArgument(BaseRegister.BaseRegisterName, BaseRegister.Index + i, BaseRegister.VKind);
                    builder.Append(reg.Asm);
                }

                builder.Append(" }");
                if (Indexer.HasValue)
                {
                    builder.Append($"[{Indexer.Value}]");
                }
                return builder.ToString();
            }
            else
            {
                if (Indexer.HasValue)
                {
                    return $"{BaseRegister.CSharp}.Group{Count}()[{Indexer.Value}]";
                }
                else
                {
                    return $"{BaseRegister.CSharp}.Group{Count}()";
                }
            }
        }
    }

    private record MemoryTestArgument : TestArgument
    {
        public MemoryTestArgument(RegisterTestArgument baseRegister, RegisterTestArgument? indexRegister, string? extend, int? amount)
        {
            BaseRegister = baseRegister;
            IndexRegister = indexRegister;
            Extend = extend;
            Amount = amount;
        }

        public MemoryTestArgument(RegisterTestArgument baseRegister, RegisterTestArgument? indexRegister)
        {
            BaseRegister = baseRegister;
            IndexRegister = indexRegister;
        }

        public MemoryTestArgument(RegisterTestArgument baseRegister, int? immediate)
        {
            BaseRegister = baseRegister;
            Immediate = immediate;
        }

        public MemoryTestArgument(RegisterTestArgument baseRegister)
        {
            BaseRegister = baseRegister;
        }

        public RegisterTestArgument BaseRegister { get; }

        public RegisterTestArgument? IndexRegister { get; }

        public int? Immediate { get; }

        public string? Extend { get; }

        public int? Amount { get; }

        public bool PreIncrement { get; init; }

        public override string CSharp => GetAsText(false);

        public override string Asm => GetAsText(true);

        private string GetAsText(bool isAsm)
        {
            var immediate = Immediate?.ToString();
            var extend = Extend;
            var amount = Amount?.ToString();
            if (isAsm)
            {
                var baseRegister = BaseRegister.Asm;
                var indexRegister = IndexRegister?.Asm;

                var builder = new StringBuilder();
                builder.Append("[");
                builder.Append(baseRegister);
                if (indexRegister is not null)
                {
                    builder.Append(", ");
                    builder.Append(indexRegister);
                    if (extend is not null)
                    {
                        builder.Append(", ");
                        builder.Append(extend);
                        if (amount is not null)
                        {
                            builder.Append(" #");
                            builder.Append(amount);
                        }
                    }
                }
                else if (immediate is not null)
                {
                    builder.Append(", #");
                    builder.Append(immediate);
                }
                builder.Append("]");
                if (PreIncrement)
                {
                    builder.Append('!');
                }
                return builder.ToString();
            }
            else
            {
                var baseRegister = BaseRegister.CSharp;
                var indexRegister = IndexRegister?.CSharp;

                var builder = new StringBuilder();
                builder.Append("_[");
                builder.Append(baseRegister);
                if (indexRegister is not null)
                {
                    builder.Append(", ");
                    builder.Append(indexRegister);
                    if (extend is not null)
                    {
                        builder.Append(", _");
                        builder.Append(extend);
                        if (amount is not null)
                        {
                            builder.Append(", ");
                            builder.Append(amount);
                        }
                    }
                }
                else if (immediate is not null)
                {
                    builder.Append(", ");
                    builder.Append(immediate);
                }
                builder.Append("]");
                if (PreIncrement)
                {
                    builder.Append(".Pre");
                }
                return builder.ToString();
            }
        }
    }


    private record RegisterPlus1TestArgument : TestArgument
    {
        private RegisterTestArgument? _baseRegister;

        public RegisterPlus1TestArgument()
        {
        }

        public override string CSharp => _baseRegister?.CSharp ?? string.Empty;
        public override string Asm => _baseRegister?.Asm ?? string.Empty;

        public override void InitializeFromArguments(IReadOnlyList<TestArgument> arguments, int index)
        {
            var baseRegister = (RegisterTestArgument)arguments[index - 1];
            _baseRegister = new RegisterTestArgument(baseRegister.BaseRegisterName, baseRegister.Index + 1, baseRegister.VKind, baseRegister.Indexer);
        }
    }


    private record RegisterTestArgument : TestArgument
    {
        public RegisterTestArgument(string baseRegisterName, int index, int? indexer = null)
        {
            BaseRegisterName = baseRegisterName;
            Index = index % 32;
            Indexer = indexer;
        }

        public RegisterTestArgument(string baseRegisterName, int index, string? vKind, int? indexer = null) : this(baseRegisterName, index, indexer)
        {
            VKind = vKind;
        }

        public string BaseRegisterName { get; }

        public int Index { get; }

        public string? VKind { get; }

        public int? Indexer { get; }

        public override string CSharp => GetAsText(false);

        public override string Asm => GetAsText(true);


        private string GetAsText(bool isAsm)
        {
            var registerName = BaseRegisterName;
            if ((registerName == "SP" || registerName == "WSP"))
            {
                if (Index != 31)
                {
                    registerName = registerName == "SP" ? "X" : "W";
                    registerName = $"{registerName}{Index}";
                }
            }
            else
            {
                if (Index == 31)
                {
                    registerName = registerName == "X" ? "XZR" : registerName == "W" ? "WZR" : $"{registerName}{Index}";
                }
                else
                {
                    registerName = $"{registerName}{Index}";
                }
            }

            if (VKind is not null)
            {
                if (char.IsDigit(VKind[0]))
                {
                    if (isAsm)
                    {
                        return Indexer.HasValue ? $"{registerName}.{VKind}[{Indexer.Value}]" : $"{registerName}.{VKind}";
                    }
                    else
                    {
                        return Indexer.HasValue ? $"{registerName}.T_{VKind}[{Indexer.Value}]" : $"{registerName}.T_{VKind}";
                    }
                }
                else
                {
                    return Indexer.HasValue ? $"{registerName}.{VKind}[{Indexer.Value}]" : $"{registerName}.{VKind}";
                }
            }
            else
            {
                return Indexer.HasValue ? $"{registerName}[{Indexer.Value}]" : registerName;
            }
        }
    }
}