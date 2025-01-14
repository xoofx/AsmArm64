// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

// Feature
// Docvars ideas
// https://github.com/google/EXEgesis/blob/master/exegesis/arm/xml/docvars.cc

partial class Arm64Processor
{
    private void GenerateCode()
    {
        GenerateMnemonicEnum();
        GenerateInstructionIdEnum();
        GenerateInstructionClass();
        GenerateArchitecture();
        GenerateFeatures();
        GenerateFeatureExpressions();
        GenerateInstructionIdDecoderTable();
        GenerateInstructionDecoderTable();
        GenerateInstructionIdTests();
        GenerateVectorArrangements();
        GenerateDynamicRegister();
    }

    private void GenerateMnemonicEnum()
    {
        using var w = GetWriter("Arm64Mnemonic.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 mnemonics.");
        w.WriteLine("public enum Arm64Mnemonic : ushort");
        w.OpenBraceBlock();
        {
            w.WriteSummary("This mnemonic is invalid.");
            w.WriteLine("Invalid,");
            foreach (var mnemonic in _instructionSet.OrderedMnemonics)
            {
                w.WriteSummary($"This `{mnemonic}` mnemonic.");
                w.WriteLine($"{mnemonic} = {_instructionSet.OrderedMnemonics.IndexOf(mnemonic) + 1},");
            }
        }
        w.CloseBraceBlock();
        w.WriteLine();
        w.WriteLine("partial class Arm64Extensions");
        w.OpenBraceBlock();
        {
            w.WriteLine("private static readonly string[] MnemonicLowerTable = new string[]");
            w.OpenBraceBlock();
            {
                w.WriteLine("\"???\",");
                foreach (var mnemonic in _instructionSet.OrderedMnemonics)
                {
                    w.WriteLine($"\"{mnemonic.ToLowerInvariant()}\",");
                }
            }
            w.CloseBraceBlockStatement();
            w.WriteLine();
            w.WriteLine("private static readonly string[] MnemonicUpperTable = new string[]");
            w.OpenBraceBlock();
            {
                w.WriteLine("\"???\",");
                foreach (var mnemonic in _instructionSet.OrderedMnemonics)
                {
                    w.WriteLine($"\"{mnemonic.ToUpperInvariant()}\",");
                }
            }
            w.CloseBraceBlockStatement();
        }
        w.CloseBraceBlock();
        w.WriteLine();
}

    private void GenerateInstructionIdEnum()
    {
        using var w = GetWriter("Arm64InstructionId.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 instruction ids.");
        w.WriteLine("public enum Arm64InstructionId : ushort");
        w.OpenBraceBlock();
        w.WriteSummary("This instruction is invalid / undefined.");
        w.WriteLine("Invalid,");
        foreach (var instruction in _instructions)
        {
            w.WriteSummary($"Instruction `{instruction.Mnemonic}` - {instruction.Summary}.");
            w.WriteLine($"{instruction.Id} = {instruction.IdIndex},");
        }
        w.CloseBraceBlock();
    }

    private void GenerateInstructionClass()
    {
        using var w = GetWriter("Arm64InstructionClass.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 instruction classes.");
        w.WriteLine("public enum Arm64InstructionClass : byte");
        w.OpenBraceBlock();
        w.WriteSummary("The instruction class is invalid / unknown.");
        w.WriteLine("Invalid,");
        foreach (var iClass in _instructionSet.OrderedInstructionClass)
        {
            w.WriteSummary($"Class `{iClass}`.");
            w.WriteLine($"{iClass} = {_instructionSet.OrderedInstructionClass.IndexOf(iClass) + 1},");
        }
        w.CloseBraceBlock();
    }

    private void GenerateArchitecture()
    {
        var variants = _featureRequirementIdToArchitectureId.Values.ToHashSet().Order().ToList();
        {
            using var w = GetWriter("Arm64ArchitectureId.gen.cs");
            w.WriteLine("namespace AsmArm64;");
            w.WriteLine();
            w.WriteSummary("A list of all ARM64 architectures.");
            w.WriteLine("public enum Arm64ArchitectureId : byte");
            w.OpenBraceBlock();
            w.WriteSummary("The architecture is invalid / unknown.");
            w.WriteLine("Invalid,");
            foreach (var arch in variants)
            {
                w.WriteSummary($"Architecture `{arch}`.");
                w.WriteLine($"{arch},");
            }
            w.CloseBraceBlock();

        }

        {
            using var w = GetWriter("Arm64Architecture.gen.cs");
            w.WriteLine("namespace AsmArm64;");
            w.WriteLine();
            w.WriteLine("partial class Arm64Architecture");
            w.OpenBraceBlock();
            {
                // Arm64ArchitectureId.ARMv8_0_A => new (id, 8, 0, Arm64ArchitectureProfile.A),
                var regexDecodeArch = new Regex(@"ARMv(?<Major>\d+)_(?<Minor>\d+)_(?<Profile>[A-Z])");
                foreach (var variant in variants)
                {
                    // arch: Arm64ArchitectureId.ARMv8_0_A
                    var match = regexDecodeArch.Match(variant);
                    Debug.Assert(match.Success);
                    var major = int.Parse(match.Groups["Major"].Value);
                    var minor = int.Parse(match.Groups["Minor"].Value);
                    var profile = match.Groups["Profile"].Value;
                    w.WriteSummary($"Architecture {variant}.");
                    w.WriteLine($"public static readonly Arm64Architecture {variant} = new(Arm64ArchitectureId.{variant}, {major}, {minor}, Arm64ArchitectureProfile.{profile});");
                }
                
                w.WriteSummary("Converts an architecture id to an architecture.");
                w.WriteDoc($"<param name=\"id\">The id of the architecture.</param>");
                w.WriteDoc("<returns>The architecture.</returns>");
                w.WriteLine("public static Arm64Architecture FromId(Arm64ArchitectureId id)");
                w.OpenBraceBlock();
                {
                    w.WriteLine("return id switch");
                    w.OpenBraceBlock();
                    {
                        // Arm64ArchitectureId.ARMv8_0_A => new (id, 8, 0, Arm64ArchitectureProfile.A),
                        foreach (var variant in variants)
                        {
                            w.WriteLine($"Arm64ArchitectureId.{variant} => {variant},");
                        }

                        w.WriteLine("_ => new(id, 0, 0, Arm64ArchitectureProfile.Invalid),");
                    }
                    w.CloseBraceBlockStatement();
                }
                w.CloseBraceBlock();
            }
            w.CloseBraceBlock();
        }
    }

    private void GenerateFeatures()
    {
        using var w = GetWriter("Arm64Feature.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of ARM64 CPU features.");
        w.WriteLine("public enum Arm64Feature : byte");
        w.OpenBraceBlock();
        w.WriteSummary("The feature is invalid / unknown.");
        w.WriteLine("Invalid,");
        for (var i = 0; i < _features.Count; i++)
        {
            var feature = _features[i];
            w.WriteSummary($"Feature `{feature}`.");
            w.WriteLine($"{feature},");
        }

        w.CloseBraceBlock();
    }

    private void GenerateFeatureExpressions()
    {
        using var w = GetWriter("Arm64FeatureExpressionId.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of ARM64 CPU features.");
        w.WriteLine("public enum Arm64FeatureExpressionId : byte");
        w.OpenBraceBlock();
        w.WriteSummary("The feature is invalid / unknown.");
        w.WriteLine("Invalid,");
        for (var i = 0; i < _featureExpressions.Count; i++)
        {
            var featureExpression = _featureExpressions[i];
            if (featureExpression.Name.StartsWith("ARM"))
            {
                w.WriteSummary($"Feature `{EscapeHtmlEntities(featureExpression.Expression)}` for `{featureExpression.Name}`.");
            }
            else
            {
                w.WriteSummary($"Feature `{EscapeHtmlEntities(featureExpression.Expression)}`.");
            }
            w.WriteLine($"{featureExpression.Id} = {_mapFeatureExpressionIdToIndex[featureExpression.Id]},");
        }

        w.CloseBraceBlock();
    }

    private void GenerateInstructionIdDecoderTable()
    {
        using var w = GetWriter("Arm64InstructionIdDecoderTable.gen.cs");
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteLine("partial class Arm64InstructionIdDecoderTable");
        w.OpenBraceBlock();
        {
            var buffer = _tableGenEncoder.Buffer;
            WriteBuffer(w, buffer, "Buffer", "Decoder table to get an instruction id from a raw ARM64 instruction uint");
        }
        w.CloseBraceBlock();
    }

    private void GenerateInstructionDecoderTable()
    {
        using var w = GetWriter("Arm64InstructionDecoderTable.gen.cs");
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteLine("partial class Arm64InstructionDecoderTable");
        w.OpenBraceBlock();
        {
            var offsets = _instructionProcessor.InstructionEncodingOffsets;
            w.WriteLine($"public static ReadOnlySpan<ushort> InstructionIdToBufferOffset => new ushort[{_instructionProcessor.InstructionEncodingOffsets.Count}]");
            w.OpenBraceBlock();
            for (var i = 0; i < offsets.Count; i++)
            {
                var offset = offsets[i];
                Debug.Assert(offset % 4 == 0);
                Debug.Assert(offset / 4 <= ushort.MaxValue);
                w.WriteLine($"{offset/4}, // {(i == 0 ? "Undefined" : _instructions[i - 1].Id)}");
            }
            w.CloseBraceBlockStatement();

            var buffer = _instructionProcessor.InstructionEncodingBuffer.ToArray();
            int indexInOffset = 0;

            w.WriteSummary("Decoder table to get the instruction details");
            w.WriteLine($"public static ReadOnlySpan<byte> Buffer => new byte[{buffer.Length}]");
            w.OpenBraceBlock();

            int wrapping = 8;
            var nextWrapping = new Stack<int>();
            int startingOffset = 0;
            for (var i = 0; i < buffer.Length; i++)
            {
                if (indexInOffset < offsets.Count && i == offsets[indexInOffset])
                {
                    startingOffset = 0;
                    wrapping = 8;
                    nextWrapping.Clear();
                    if (indexInOffset == 0)
                    {
                        w.WriteLine($"// Undefined");
                    }
                    else
                    {
                        var instruction = _instructions[indexInOffset - 1];
                        w.WriteLine($"// {instruction.Id,-30} - {instruction.Mnemonic,-11}{(instruction.OperandsSyntax.Length > 0 ? $" {instruction.OperandsSyntax}" : string.Empty)}");
                        nextWrapping.Push(instruction.UseOperandEncoding8Bytes ? 8 : 4);

                        if (instruction.VectorArrangementIndices.Count > 0)
                        {
                            nextWrapping.Push(4); // We want to separate the vector arrangement on its own line
                        }
                    }
                    indexInOffset++;
                }

                w.Write($"{buffer[i]},");
                if (startingOffset % wrapping == (wrapping - 1))
                {
                    w.WriteLine();
                    if (nextWrapping.Count > 0)
                    {
                        wrapping = nextWrapping.Pop();
                    }
                }

                startingOffset++;
            }

            if (buffer.Length % wrapping != 0)
            {
                w.WriteLine();
            }
            w.CloseBraceBlockStatement();
        }
        w.CloseBraceBlock();
    }

    private void WriteBuffer(CodeWriter w, ReadOnlySpan<byte> buffer, string name, string summary, int wrapping = 16)
    {
        w.WriteSummary(summary);
        w.WriteLine($"public static ReadOnlySpan<byte> {name} => new byte[{buffer.Length}]");
        w.OpenBraceBlock();
        for (var i = 0; i < buffer.Length; i++)
        {
            w.Write($"{buffer[i]},");
            if (i % wrapping == (wrapping - 1))
            {
                w.WriteLine();
            }
        }
        if (buffer.Length % wrapping != 0)
        {
            w.WriteLine();
        }
        w.CloseBraceBlockStatement();
    }
    
    private void GenerateInstructionIdTests()
    {
        using var w = GetWriter("InstructionIdTests.gen.cs", true);
        w.WriteLine("namespace AsmArm64.Tests;");
        w.WriteLine();
        w.WriteLine("[TestClass]");
        w.WriteLine("public class InstructionIdTests");
        w.OpenBraceBlock();
        {
            w.WriteLine("[TestMethod]");
            foreach (var instruction in _instructions)
            {
                // Some instructions are not testable
                if (instruction.IsBitFieldValueTestable)
                {
                    w.WriteLine($"[DataRow(0x{instruction.BitfieldValueForTest:X8}U, Arm64InstructionId.{instruction.Id})]");
                }
            }
            w.WriteLine($"public void Test(uint instruction, Arm64InstructionId expected)");
            w.OpenBraceBlock();
            {
                w.WriteLine("var actual = Arm64Instruction.DecodeId(instruction);");
                w.WriteLine("Assert.AreEqual(expected, actual);");
            }
            w.CloseBraceBlock();
        }
        w.CloseBraceBlock();
    }

    private void GenerateVectorArrangements()
    {
        using var w = GetWriter("Arm64VectorArrangementHelper.gen.cs");
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("Decode vector arrangements from raw instruction.");
        w.WriteLine("static class Arm64VectorArrangementHelper");
        w.OpenBraceBlock();
        {
            // ---------------------------------------------
            // Write the VectorArrangement decoding
            // ---------------------------------------------
            // public static bool TryDecode(Arm64RawInstruction rawValue, byte valueArrangementIndex, out Arm64RegisterVKind vKind, out int elementCount)
            // {
            //     switch (valueArrangementIndex)
            //     {
            //         case 0:
            //             return TryDecodeFromBitValues((rawValue >> 10) & 0x1F, 14, out vKind, out elementCount);
            //         default:
            //             elementCount = 0;
            //             vKind = Arm64RegisterVKind.Default;
            //             return false;
            //     }
            // }

            w.WriteLine("public static bool TryDecode(Arm64RawInstruction rawValue, byte valueArrangementIndex, out Arm64RegisterVKind vKind, out int elementCount)");
            w.OpenBraceBlock();
            {
                w.WriteLine("switch (valueArrangementIndex)");
                w.OpenBraceBlock();
                {
                    var builder = new StringBuilder();
                    foreach (var vectorArrangement in _instructionSet.VectorArrangements)
                    {
                        w.WriteLine($"case {vectorArrangement.Index}:");
                        w.Indent();

                        if (vectorArrangement.Encoding.Count > 0)
                        {
                            builder.Clear();
                            // We start from the lowest bits to the highest bits
                            int accumulation = 0;
                            for (var i = vectorArrangement.Encoding.Count - 1; i >= 0; i--)
                            {
                                var bitRange = vectorArrangement.Encoding[i];
                                var mask = ((1U << bitRange.Width) - 1) << accumulation;

                                if (i < vectorArrangement.Encoding.Count - 1)
                                {
                                    builder.Append(" | ");
                                }

                                builder.Append($"((rawValue >> {bitRange.LowBit - accumulation}) & 0x{mask:X})");
                                accumulation += bitRange.Width;
                            }

                            w.WriteLine($"return TryDecodeFromBitValues({builder}, {vectorArrangement.VectorArrangementValuesIndex}, out vKind, out elementCount);");
                        }
                        else
                        {
                            var (vKind, elementCount) = GetVKindAndElementCount(vectorArrangement.ArrangementKind);
                            w.WriteLine($"vKind = Arm64RegisterVKind.{vKind};");
                            w.WriteLine($"elementCount = {elementCount};");
                            w.WriteLine("return true;");
                        }
                        w.UnIndent();
                    }
                }
                w.CloseBraceBlock();
                w.WriteLine();
                w.WriteLine("elementCount = 0;");
                w.WriteLine("vKind = Arm64RegisterVKind.Default;");
                w.WriteLine("return false;");
            }
            w.CloseBraceBlock();

            // ---------------------------------------------
            // Write the VectorArrangementValues decoding
            // ---------------------------------------------
            // private static bool TryDecodeFromBitValues(uint bitValues, byte valueArrangementValuesIndex, out Arm64RegisterVKind vKind, out int elementCount)
            // {
            //     switch (valueArrangementValuesIndex)
            //     {
            //         case 0:
            //             switch (bitValues)
            //             {
            //                 case 0:
            //                     vKind = Arm64RegisterVKind.D;
            //                     elementCount = 16;
            //                     return true;
            //                     break;
            //             }

            //             break;
            //     }
            //     elementCount = 0;
            //     vKind = Arm64RegisterVKind.Default;
            //     return false;
            // }

            w.WriteLine("public static bool TryDecodeFromBitValues(uint bitValues, byte valueArrangementValuesIndex, out Arm64RegisterVKind vKind, out int elementCount)");
            w.OpenBraceBlock();
            {
                w.WriteLine("switch (valueArrangementValuesIndex)");
                w.OpenBraceBlock();
                {
                    foreach(var vectorArrangementValues in _instructionSet.VectorArrangementValues)
                    {
                        w.WriteLine($"case {vectorArrangementValues.Index}:");
                        w.Indent();
                        if (vectorArrangementValues.MappingKind == BitValuesMappingKind.Regular)
                        {
                            w.WriteLine($"switch (bitValues)");
                            w.OpenBraceBlock();
                            {
                                foreach (var value in vectorArrangementValues.Items)
                                {
                                    if (value.Kind == Arm64RegisterVectorArrangementEncodingKind.Reserved || value.Kind == Arm64RegisterVectorArrangementEncodingKind.None)
                                    {
                                        continue;
                                    }
                                    w.WriteLine($"case {value.BitValue}:");
                                    w.Indent();
                                    var (vKind, elementCount) = GetVKindAndElementCount(value.Kind);
                                    w.WriteLine($"vKind = Arm64RegisterVKind.{vKind};");
                                    w.WriteLine($"elementCount = {elementCount};");
                                    w.WriteLine("return true;");
                                    w.UnIndent();
                                }
                            }
                            w.CloseBraceBlock();
                            w.WriteLine("break;");
                        }
                        else
                        {
                            Debug.Assert(vectorArrangementValues.MappingKind == BitValuesMappingKind.Masked);

                            // Order from the highest number of bits sets to the lowest number
                            // If the mask is 0, it means that all bits are sets
                            var values = vectorArrangementValues.Items.Where(x => x.Kind != Arm64RegisterVectorArrangementEncodingKind.Reserved).OrderByDescending(x => BitOperations.PopCount(x.MaskValue == 0 ? uint.MaxValue : x.MaskValue)).ToList();

                            foreach (var value in values)
                            {
                                w.WriteLine(value.MaskValue == 0
                                    ? $"if (bitValues == {value.BitValue})"
                                    : $"if ((bitValues & 0x{value.MaskValue:x}) == {value.BitValue})"
                                );
                                w.OpenBraceBlock();
                                {
                                    var (vKind, elementCount) = GetVKindAndElementCount(value.Kind);
                                    w.WriteLine($"vKind = Arm64RegisterVKind.{vKind};");
                                    w.WriteLine($"elementCount = {elementCount};");
                                    w.WriteLine("return true;");
                                }
                                w.CloseBraceBlock();
                            }

                            w.WriteLine("break;");
                        }
                        w.UnIndent();
                    }
                }
                w.CloseBraceBlock();
                w.WriteLine();
                w.WriteLine("elementCount = 0;");
                w.WriteLine("vKind = Arm64RegisterVKind.Default;");
                w.WriteLine("return false;");
            }
            w.CloseBraceBlock();
        }
        w.CloseBraceBlock();
    }

    private void GenerateDynamicRegister()
    {
        using var w = GetWriter("Arm64DynamicRegisterHelper.gen.cs");
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("Decode dynamic register from raw instruction.");
        w.WriteLine("static class Arm64DynamicRegisterHelper");
        w.OpenBraceBlock();
        {
            w.WriteLine("public static bool TryDecode(Arm64RawInstruction rawValue, byte dynamicSelectorIndex, out Arm64RegisterEncodingKind registerEncodingKind)");
            w.OpenBraceBlock();
            {
                w.WriteLine("switch (dynamicSelectorIndex)");
                w.OpenBraceBlock();
                {
                    var builder = new StringBuilder();
                    foreach (var dynamicRegisterSelector in _instructionSet.DynamicRegisterSelectorList)
                    {
                        w.WriteLine($"case {dynamicRegisterSelector.Index}:");
                        w.OpenBraceBlock();
                        {
                            var bitRange = dynamicRegisterSelector.BitEncoding;
                            var mask = ((1U << bitRange.Width) - 1);
                            w.WriteLine($"var bitValues = (rawValue >> {bitRange.LowBit}) & 0x{mask:X};");

                            if (dynamicRegisterSelector.MappingKind == BitValuesMappingKind.Regular)
                            {
                                w.WriteLine($"switch (bitValues)");
                                w.OpenBraceBlock();
                                {
                                    foreach (var value in dynamicRegisterSelector.BitValues)
                                    {
                                        if (value.RegisterKind == Arm64RegisterEncodingKind.None)
                                        {
                                            continue;
                                        }

                                        w.WriteLine($"case {value.BitValue}:");
                                        w.Indent();
                                        w.WriteLine($"registerEncodingKind = Arm64RegisterEncodingKind.{value.RegisterKind};");
                                        w.WriteLine("return true;");
                                        w.UnIndent();
                                    }
                                }
                                w.CloseBraceBlock();
                                w.WriteLine("break;");
                            }
                            else
                            {
                                Debug.Assert(dynamicRegisterSelector.MappingKind == BitValuesMappingKind.Masked);

                                // Order from the highest number of bits sets to the lowest number
                                // If the mask is 0, it means that all bits are sets
                                var values = dynamicRegisterSelector.BitValues.Where(x => x.RegisterKind != Arm64RegisterEncodingKind.None).OrderByDescending(x => BitOperations.PopCount(x.MaskValue == 0 ? uint.MaxValue : x.MaskValue))
                                    .ToList();

                                foreach (var value in values)
                                {
                                    w.WriteLine(value.MaskValue == 0
                                        ? $"if (bitValues == {value.BitValue})"
                                        : $"if ((bitValues & 0x{value.MaskValue:x}) == {value.BitValue})"
                                    );
                                    w.OpenBraceBlock();
                                    {
                                        w.WriteLine($"registerEncodingKind = Arm64RegisterEncodingKind.{value.RegisterKind};");
                                        w.WriteLine("return true;");
                                    }
                                    w.CloseBraceBlock();
                                }

                                w.WriteLine("break;");
                            }
                        }
                        w.CloseBraceBlock();
                    }
                }
                w.CloseBraceBlock();
                w.WriteLine();
                w.WriteLine("registerEncodingKind = Arm64RegisterEncodingKind.None;");
                w.WriteLine("return false;");
            }
            w.CloseBraceBlock();
        }
        w.CloseBraceBlock();
    }

    private (string VKind, int ElementCount) GetVKindAndElementCount(Arm64RegisterVectorArrangementEncodingKind kind)
    {
        switch (kind)
        {
            case Arm64RegisterVectorArrangementEncodingKind.B:
                return ("B", 0);
            case Arm64RegisterVectorArrangementEncodingKind.H:
                return ("H", 0);
            case Arm64RegisterVectorArrangementEncodingKind.S:
                return ("S", 0);
            case Arm64RegisterVectorArrangementEncodingKind.D:
                return ("D", 0);
            case Arm64RegisterVectorArrangementEncodingKind.T_16B:
                return ("B", 16);
            case Arm64RegisterVectorArrangementEncodingKind.T_8B:
                return ("B", 8);
            case Arm64RegisterVectorArrangementEncodingKind.T_4B:
                return ("B", 4);
            case Arm64RegisterVectorArrangementEncodingKind.T_2B:
                return ("B", 2);
            case Arm64RegisterVectorArrangementEncodingKind.T_2H:
                return ("H", 2);
            case Arm64RegisterVectorArrangementEncodingKind.T_4H:
                return ("H", 4);
            case Arm64RegisterVectorArrangementEncodingKind.T_8H:
                return ("H", 8);
            case Arm64RegisterVectorArrangementEncodingKind.T_2S:
                return ("S", 2);
            case Arm64RegisterVectorArrangementEncodingKind.T_4S:
                return ("S", 4);
            case Arm64RegisterVectorArrangementEncodingKind.T_1D:
                return ("D", 1);
            case Arm64RegisterVectorArrangementEncodingKind.T_2D:
                return ("D", 2);
            case Arm64RegisterVectorArrangementEncodingKind.T_1Q:
                return ("Q", 1);
            default:
                throw new ArgumentOutOfRangeException(nameof(kind), kind, null);
        }
    }

    private static string EscapeHtmlEntities(string text) => text.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");

    private CodeWriter GetWriter(string fileName, bool isTest = false)
    {
        var sw = new StreamWriter(Path.Combine(isTest ? _basedOutputTestFolder : _basedOutputFolder, "generated", fileName));
        var w = new CodeWriter(sw);

        w.WriteLine(
            """
            // Copyright (c) Alexandre Mutel. All rights reserved.
            // Licensed under the BSD-Clause 2 license.
            // See license.txt file in the project root for full license information.
            // ------------------------------------------------------------------------------
            // This code was generated by AsmArm64.CodeGen.
            //     Changes to this file may cause incorrect behavior and will be lost if
            //     the code is regenerated.
            // ------------------------------------------------------------------------------
            // ReSharper disable All
            // ------------------------------------------------------------------------------
            
            """
        );

        return w;
    }
}