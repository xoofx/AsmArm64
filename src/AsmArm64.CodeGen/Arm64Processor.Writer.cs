// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

// Feature
// Docvars ideas
// https://github.com/google/EXEgesis/blob/master/exegesis/arm/xml/docvars.cc
partial class Arm64Processor
{
    private void GenerateCode()
    {
        // Generate system registers
        GenerateSystemRegistersCode();

        // Generate instruction related code/data
        GenerateMnemonicEnum();
        GenerateInstructionIdEnum();
        GenerateInstructionClass();
        GenerateArchitecture();
        GenerateFeatures();
        GenerateFeatureExpressions();
        GenerateInstructionIdDynamicDecoder();
        GenerateInstructionIdTests();
        GenerateAssembler();
        
        // Write extracts
        GenerateVectorArrangements();
        GenerateDynamicRegister();
        GenerateIndexers();
        GenerateImmediates();
        GenerateProcessStateField();
        GenerateRegisterIndex();

        // Generate enums
        GenerateEnums();
    }

    private void GenerateDecoderTables()
    {
        GenerateInstructionIdDecoderTable();
        GenerateInstructionDecoderTable();
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
            foreach (var mnemonic in InstructionSet.OrderedMnemonics)
            {
                w.WriteSummary($"This `{mnemonic}` mnemonic.");
                w.WriteLine($"{mnemonic} = {InstructionSet.OrderedMnemonics.IndexOf(mnemonic) + 1},");
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
                foreach (var mnemonic in InstructionSet.OrderedMnemonics)
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
                foreach (var mnemonic in InstructionSet.OrderedMnemonics)
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
            w.WriteLine($"{instruction.Id} = {instruction.Index},");
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
        foreach (var iClass in InstructionSet.OrderedInstructionClass)
        {
            w.WriteSummary($"Class `{iClass}`.");
            w.WriteLine($"{iClass} = {InstructionSet.OrderedInstructionClass.IndexOf(iClass) + 1},");
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

    private void GenerateInstructionIdDynamicDecoder()
    {
        using var w = GetWriter("Arm64InstructionIdDynamicDecoder.gen.cs");
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteLine("static partial class Arm64InstructionIdDynamicDecoder");
        w.OpenBraceBlock();
        {
            var instructionWithDynamicDecoding = new List<(Instruction, List<(AliasInfo, Instruction)>)>();
            foreach (var instruction in _instructions)
            {
                if (!instruction.HasAliasesInAndRequiringDynamicResolution)
                {
                    continue;
                }

                var list = new List<(AliasInfo, Instruction)>();
                foreach (var alias in instruction.AliasesIn)
                {
                    var targetInstruction = MapIdToInstruction[alias.InstructionId];
                    if (targetInstruction.IsAliasWithDynamicCondition)
                    {
                        list.Add((alias, targetInstruction));
                    }
                }
                Debug.Assert(list.Count > 0);
                instructionWithDynamicDecoding.Add((instruction, list));
            }

            w.WriteLine("public static Arm64InstructionId ResolveBetterAlias(Arm64InstructionId id, Arm64RawInstruction rawValue)");
            {
                w.Indent();
                w.WriteLine("=> id switch");
                w.OpenBraceBlock();
                {
                    foreach (var instructionPair in instructionWithDynamicDecoding)
                    {
                        var instruction = instructionPair.Item1;
                        w.WriteLine($"Arm64InstructionId.{instruction.Id} => Resolve_{instruction.Id}(rawValue),");
                    }
                    w.WriteLine("_ => throw new InvalidOperationException($\"Invalid instruction id {id} not supported by dynamic better alias resolution\")");
                }
                w.CloseBraceBlockStatement();
                w.UnIndent();
            }

            w.WriteLine();

            foreach (var instructionPair in instructionWithDynamicDecoding)
            {
                var instruction = instructionPair.Item1;
                w.WriteDoc("<summary>");
                foreach (var aliasPair in instructionPair.Item2)
                {
                    w.WriteDoc($"Condition: {aliasPair.Item1.Condition.Replace("&", "&amp;", StringComparison.Ordinal).Replace("<", "&lt;", StringComparison.Ordinal)} => {aliasPair.Item2.Id}");
                }
                w.WriteDoc("</summary>");
                if (instruction.Id == "SYS_cr_systeminstrs")
                {
                    w.WriteLine($"private static Arm64InstructionId Resolve_{instruction.Id}(Arm64RawInstruction rawValue)");
                    w.OpenBraceBlock();
                    {
                        w.WriteLine($"var sysValue = (rawValue >> 5) & 0b_111_1111_1111_111;");
                        w.WriteLine("return sysValue switch");
                        w.OpenBraceBlock();
                        {
                            foreach (var sysEncoding in InstructionSet.SysDynamicDispatchEntries)
                            {
                                foreach (var encoding in sysEncoding.Encodings)
                                {
                                    w.WriteLine($"0b{encoding} => Arm64InstructionId.{sysEncoding.Category}_sys_cr_systeminstrs,");
                                }
                            }
                            w.WriteLine("_ => Arm64InstructionId.SYS_cr_systeminstrs,");
                        }
                        w.CloseBraceBlockStatement();
                    }
                    w.CloseBraceBlock();
                }
                else
                {
                    w.WriteLine($"private static partial Arm64InstructionId Resolve_{instruction.Id}(Arm64RawInstruction rawValue);");
                }
            }
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
                    string? preferredId = null;

                    if (instruction.IsDiscardedByPreferredAlias)
                    {
                        Debug.Assert(instruction.AliasesIn.Count == 1);
                        preferredId = instruction.AliasesIn[0].InstructionId;
                        //Console.WriteLine($"Is discard {instruction.Id} {instruction.FullSyntax}");
                    }
                    else
                    {
                        switch (instruction.Id)
                        {
                            case "LSL_ubfm_32m_bitfield":
                                preferredId = "UBFX_ubfm_32m_bitfield";
                                break;
                            case "SBFIZ_sbfm_64m_bitfield":
                                preferredId = "SBFX_sbfm_64m_bitfield";
                                break;
                            case "EXTR_64_extract":
                                preferredId = "ROR_extr_64_extract";
                                break;
                            case "BFI_bfm_64m_bitfield":
                                preferredId = "BFXIL_bfm_64m_bitfield";
                                break;
                            case "SBFIZ_sbfm_32m_bitfield":
                                preferredId = "SBFX_sbfm_32m_bitfield";
                                break;
                            case "EXTR_32_extract":
                                preferredId = "ROR_extr_32_extract";
                                break;
                            case "LSL_ubfm_64m_bitfield":
                                preferredId = "UBFX_ubfm_64m_bitfield";
                                break;
                            case "DC_sys_cr_systeminstrs":
                                preferredId = "SYS_cr_systeminstrs";
                                break;
                            case "BFI_bfm_32m_bitfield":
                                preferredId = "BFXIL_bfm_32m_bitfield";
                                break;

                        }
                    }

                    var preferredInstruction = instruction;
                    if (preferredId != null)
                    {
                        preferredInstruction = MapIdToInstruction[preferredId];
                    }

                    w.WriteLine($"[DataRow(0x{instruction.BitfieldValueForTest:X8}U, Arm64InstructionId.{preferredInstruction.Id})]");
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


    private void GenerateEnums()
    {
        GenerateEnums("Arm64PrefetchOperationKind", "The kind of prefetch operation for the PRFM instruction.", _instructionProcessor.PrefetchOperationEnumValues, PrefetchOperationEnumDescriptions);

        // Don't generate this enum as it is changed manually
        //GenerateEnums("Arm64RangePrefetchOperationKind", "The kind of range prefetch operation for the RPRFM instruction.", _instructionProcessor.RangePrefetchOperationEnumValues, RangePrefetchOperationDescriptions);
    }

    public static readonly Dictionary<string, string> PrefetchOperationEnumDescriptions = new Dictionary<string, string>
    {
        { "PLDL1KEEP", "Prefetch Data Level 1, keep in cache." },
        { "PLDL1STRM", "Prefetch Data Level 1, stream (do not retain in cache)." },
        { "PLDL2KEEP", "Prefetch Data Level 2, keep in cache." },
        { "PLDL2STRM", "Prefetch Data Level 2, stream (do not retain in cache)." },
        { "PLDL3KEEP", "Prefetch Data Level 3, keep in cache." },
        { "PLDL3STRM", "Prefetch Data Level 3, stream (do not retain in cache)." },
        { "PLDSLCKEEP", "Prefetch Data SLC (System Level Cache), keep in cache." },
        { "PLDSLCSTRM", "Prefetch Data SLC (System Level Cache), stream (do not retain in cache)." },
        { "PLIL1KEEP", "Prefetch Instruction Level 1, keep in cache." },
        { "PLIL1STRM", "Prefetch Instruction Level 1, stream (do not retain in cache)." },
        { "PLIL2KEEP", "Prefetch Instruction Level 2, keep in cache." },
        { "PLIL2STRM", "Prefetch Instruction Level 2, stream (do not retain in cache)." },
        { "PLIL3KEEP", "Prefetch Instruction Level 3, keep in cache." },
        { "PLIL3STRM", "Prefetch Instruction Level 3, stream (do not retain in cache)." },
        { "PLISLCKEEP", "Prefetch Instruction SLC (System Level Cache), keep in cache." },
        { "PLISLCSTRM", "Prefetch Instruction SLC (System Level Cache), stream (do not retain in cache)." },
        { "PSTL1KEEP", "Prefetch Store Level 1, keep in cache." },
        { "PSTL1STRM", "Prefetch Store Level 1, stream (do not retain in cache)." },
        { "PSTL2KEEP", "Prefetch Store Level 2, keep in cache." },
        { "PSTL2STRM", "Prefetch Store Level 2, stream (do not retain in cache)." },
        { "PSTL3KEEP", "Prefetch Store Level 3, keep in cache." },
        { "PSTL3STRM", "Prefetch Store Level 3, stream (do not retain in cache)." },
        { "PSTSLCKEEP", "Prefetch Store SLC (System Level Cache), keep in cache." },
        { "PSTSLCSTRM", "Prefetch Store SLC (System Level Cache), stream (do not retain in cache)." },
        { "IR", "Immediate Read." }
    };

    public static readonly Dictionary<string, string> RangePrefetchOperationDescriptions = new Dictionary<string, string>
    {
        { "PLDKEEP", "Prefetch Load, keep in cache." },
        { "PSTKEEP", "Prefetch Store, keep in cache." },
        { "PLDSTRM", "Prefetch Load, stream (do not retain in cache)." },
        { "PSTSTRM", "Prefetch Store, stream (do not retain in cache)." }
    };

    private void GenerateEnums(string name, string summary, Dictionary<string, int> enums, Dictionary<string, string> description)
    {
        using var w = GetWriter($"{name}.gen.cs");
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary(summary);
        w.WriteLine($"public enum {name} : byte");
        w.OpenBraceBlock();
        {
            w.WriteSummary("Not a valid value.");
            foreach (var pair in enums.OrderBy(x => x.Value))
            {
                if (description.TryGetValue(pair.Key, out var itemSummary))
                {
                    w.WriteSummary(itemSummary);
                }
                else
                {
                    Console.WriteLine($"No summary found for enum {name} - item: {pair.Key}");
                }
                w.WriteLine($"{pair.Key} = {pair.Value},");
            }
            w.WriteLine("Undefined = 0xFF,");
        }
        w.CloseBraceBlock();
    }
    
    private void GenerateVectorArrangements()
    {
        var vectorArrangements = InstructionSet.ExtractMaps.First(x => x.Kind == EncodingSymbolExtractMapKind.VectorArrangement);

        GenerateEncodingSymbolExtractMap<EncodingVectorArrangementExtract>(vectorArrangements,
            "Arm64VectorArrangementHelper",
            [("Arm64RegisterVKind", "vKind"), ("int", "elementCount")],
            (w, extract) =>
            {
                var (vKind, elementCount) = GetVKindAndElementCount(extract.Kind);
                w.WriteLine($"vKind = Arm64RegisterVKind.{vKind};");
                w.WriteLine($"elementCount = {elementCount};");
            },
            (w, selector, bitValue) =>
            {
                var kind = EncodingVectorArrangementExtract.ParseArrangementKind(bitValue.Text);
                var (vKind, elementCount) = GetVKindAndElementCount(kind);
                w.WriteLine($"vKind = Arm64RegisterVKind.{vKind};");
                w.WriteLine($"elementCount = {elementCount};");
            }
        );
    }

    private void GenerateDynamicRegister()
    {
        var dynamicRegisterMap = InstructionSet.ExtractMaps.First(x => x.Kind == EncodingSymbolExtractMapKind.DynamicRegister);

        GenerateEncodingSymbolExtractMap<EncodingSymbolExtract>(dynamicRegisterMap,
            "Arm64DynamicRegisterHelper",
            [("Arm64RegisterEncodingKind", "registerEncodingKind")],
            (w, extract) =>
            {
                // We don't have any bit ranges for dynamic registers
            },
            (w, selector, bitValue) =>
            {
                w.WriteLine($"registerEncodingKind = Arm64RegisterEncodingKind.{bitValue.Text};");
            }
        );
    }
    
    private void GenerateIndexers()
    {
        var indexerMap = InstructionSet.ExtractMaps.First(x => x.Kind == EncodingSymbolExtractMapKind.Indexer);

        // We support encoding only up to 63 items (RegisterIndexer in register operand encoding)
        Debug.Assert(indexerMap.ExtractList.Count <= 63);

        GenerateEncodingSymbolExtractMap<EncodingIndexerExtract>(indexerMap,
            "Arm64IndexerHelper",
            [("int", "index")],
            (w, extract) =>
            {
                w.WriteLine($"index = {extract.FixedIndex};");
            },
            (w, selector, bitValue) =>
            {
                w.WriteLine($"index = {bitValue.Text};");
            }
        );
    }

    private void GenerateImmediates()
    {
        var immediateMap = InstructionSet.ExtractMaps.First(x => x.Kind == EncodingSymbolExtractMapKind.Immediate);

        GenerateEncodingSymbolExtractMap<EncodingIndexerExtract>(immediateMap,
            "Arm64ImmediateHelper",
            [("int", "imm")],
            (w, extract) =>
            {
                throw new InvalidOperationException("Immediate should have bit ranges");
            },
            (w, selector, bitValue) =>
            {
                w.WriteLine($"imm = (int){bitValue.Text.TrimStart('#')};");
            }
        );
    }


    private void GenerateProcessStateField()
    {
        var processStateFields = InstructionSet.ExtractMaps.First(x => x.Kind == EncodingSymbolExtractMapKind.ProcessStateField);

        GenerateEncodingSymbolExtractMap<EncodingSymbolExtract>(processStateFields,
            "Arm64ProcessStateFieldHelper",
            [("Arm64ProcessStateField", "processStateField")],
            (w, extract) =>
            {
                // We don't have any bit ranges for dynamic registers
            },
            (w, selector, bitValue) =>
            {
                w.WriteLine($"processStateField = Arm64ProcessStateField.{bitValue.Text};");
            }
        );
    }

    private void GenerateRegisterIndex()
    {
        var immediateMap = InstructionSet.ExtractMaps.First(x => x.Kind == EncodingSymbolExtractMapKind.RegisterIndex);

        GenerateEncodingSymbolExtractMap<EncodingIndexerExtract>(immediateMap,
            "Arm64RegisterIndexHelper",
            [("int", "regIndex")],
            (w, extract) =>
            {
                throw new InvalidOperationException("Immediate should have bit ranges");
            },
            (w, selector, bitValue) =>
            {
                w.WriteLine($"regIndex = (int){bitValue.Text};");
            }
        );
    }
    
    private void GenerateEncodingSymbolExtractMap<TExtract>(EncodingSymbolExtractMap map, string name, List<(string ParameterType, string ParameterName)> parameters,
            Action<CodeWriter, TExtract> writeBitToSelector,
            Action<CodeWriter, EncodingSymbolSelector, EncodingBitValue> writeSelector
        ) where TExtract : EncodingSymbolExtract
    {
        using var w = GetWriter($"{name}.gen.cs");
        w.WriteLine();
        w.WriteLine("using System.Runtime.CompilerServices;");
        w.WriteLine();
        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary($"Decode {map.Kind} class.");
        w.WriteLine($"static class {name}");
        w.OpenBraceBlock();
        {
            // ---------------------------------------------
            // Write the VectorArrangement decoding
            // ---------------------------------------------
            // public static bool TryDecode(Arm64RawInstruction rawValue, byte mapIndex, out Arm64RegisterVKind vKind, out int elementCount)
            // {
            //     switch (mapIndex)
            //     {
            //         case 0:
            //             return TryDecodeFromBitValues((rawValue >> 10) & 0x1F, 14, out vKind, out elementCount);
            //         default:
            //             elementCount = 0;
            //             vKind = Arm64RegisterVKind.Default;
            //             return false;
            //     }
            // }

            var parameterSignature = string.Join(", ", parameters.Select(x => $"out {x.ParameterType} {x.ParameterName}"));
            w.WriteLine($"public static bool TryDecode(Arm64RawInstruction rawValue, byte mapIndex, {parameterSignature})");
            w.OpenBraceBlock();
            {
                w.WriteLine("switch (mapIndex)");
                w.OpenBraceBlock();
                {
                    var builder = new StringBuilder();
                    foreach (var extract in map.ExtractList)
                    {
                        // Dump all usages for debugging
                        foreach (var usage in extract.Usages.OrderBy(x => x.Instruction.Id))
                        {
                            w.WriteLine($"// {usage.Instruction.Id,-30}: {usage.Instruction.FullSyntax} <- Operand: {usage.OperandItem}");
                        }
                        
                        w.WriteLine($"case {extract.Index}:");
                        w.OpenBraceBlock();

                        if (extract.BitRanges.Count > 0)
                        {
                            var bitValueExtractString = ExtractBitRangeString(extract.BitRanges, "rawValue", "bitValue");
                            w.WriteLine(bitValueExtractString);

                            if (extract.SelectorIndex == 0)
                            {
                                Debug.Assert(parameters.Count == 1, "We support only one parameter when no selector");
                                w.WriteLine($"{parameters[0].ParameterName} = ({parameters[0].ParameterType})bitValue;");
                                w.WriteLine($"return true;");
                            }
                            else
                            {
                                WriteSelectorCode(w, extract.Selector!, parameters, writeSelector);
                                //w.WriteLine($"return TryDecodeFromBitValues(bitValue, {extract.SelectorIndex}, {string.Join(",", parameters.Select(x => $"out {x.ParameterName}"))});");
                            }
                        }
                        else
                        {
                            writeBitToSelector(w, (TExtract)extract);
                            w.WriteLine("return true;");
                        }
                        w.CloseBraceBlock();
                    }
                }
                w.CloseBraceBlock();
                w.WriteLine();
                foreach (var parameter in parameters)
                {
                    w.WriteLine($"{parameter.ParameterName} = default;");
                }
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

            //if (map.SelectorList.Count > 0)
            //{
            //    w.WriteLine();
            //    // We inline aggressively because the selectorIndex is a constant passed as it seems that the vast majority of selectorIndex are unique to an extract.
            //    w.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
            //    w.WriteLine($"public static bool TryDecodeFromBitValues(uint bitValue, byte selectorIndex, {parameterSignature})");
            //    w.OpenBraceBlock();
            //    {
            //        w.WriteLine("switch (selectorIndex)");
            //        w.OpenBraceBlock();
            //        {
            //            foreach (var selector in map.SelectorList)
            //            {
            //                w.WriteLine($"case {selector.Index}:");
            //                w.OpenBraceBlock();
            //                WriteSelectorCode(w, selector, parameters, writeSelector);

            //                w.CloseBraceBlock();
            //            }
            //        }
            //        w.CloseBraceBlock();
            //        w.WriteLine();
            //        foreach (var parameter in parameters)
            //        {
            //            w.WriteLine($"{parameter.ParameterName} = default;");
            //        }

            //        w.WriteLine("return false;");
            //    }
            //    w.CloseBraceBlock();
            //}
        }
        w.CloseBraceBlock();
    }

    private void WriteSelectorCode(CodeWriter w, EncodingSymbolSelector selector, List<(string ParameterType, string ParameterName)> parameters, Action<CodeWriter, EncodingSymbolSelector, EncodingBitValue> writeSelector)
    {
        var outputSelectorValue = selector.BitValues.Count == 0 ? "extractedValue" : "bitsToTest";
        w.WriteLine(ExtractBitRangeString(selector.BitRanges, "bitValue", outputSelectorValue));

        if (selector.Kind == EncodingSymbolSelectorKind.Regular)
        {
            if (selector.BitValues.Count == 0)
            {
                w.WriteLine($"{parameters[0].ParameterName} = ({parameters[0].ParameterType}){outputSelectorValue};");
                w.WriteLine("return true;");
            }
            else
            {
                w.WriteLine($"switch (bitsToTest)");
                w.OpenBraceBlock();
                {
                    foreach (var bitValue in selector.BitValues)
                    {
                        w.WriteLine($"case {bitValue.LocalBitSelectorValue}:");
                        w.OpenBraceBlock();
                        if (bitValue.Kind == EncodingBitValueKind.BitExtract)
                        {
                            var bitRanges = bitValue.BitItems.Select(x => x.Range).ToList();
                            var bitValueExtractString = ExtractBitRangeString(bitRanges, "bitValue", "extractedValue");
                            Debug.Assert(parameters.Count == 1);
                            w.WriteLine(bitValueExtractString);

                            if (bitValue.Addend != 0)
                            {
                                w.WriteLine(bitValue.HasNegativeExtract
                                    ? $"{parameters[0].ParameterName} = {bitValue.Addend} - ({parameters[0].ParameterType})extractedValue;"
                                    : $"{parameters[0].ParameterName} = ({parameters[0].ParameterType})extractedValue - {bitValue.Addend};");
                            }
                            else
                            {
                                w.WriteLine($"{parameters[0].ParameterName} = ({parameters[0].ParameterType})extractedValue;");
                            }
                        }
                        else
                        {
                            writeSelector(w, selector, bitValue);
                        }
                        w.WriteLine("return true;");
                        w.CloseBraceBlock();
                    }
                }
                w.CloseBraceBlock();
                w.WriteLine("break;");
            }
        }
        else
        {
            Debug.Assert(selector.Kind == EncodingSymbolSelectorKind.Masked);

            // Order from the highest number of bits sets to the lowest number
            // If the mask is 0, it means that all bits are sets
            var bitValues = selector.BitValues.OrderByDescending(x => BitOperations.PopCount(x.LocalBitSelectorMask == 0 ? uint.MaxValue : x.LocalBitSelectorMask)).ToList();

            foreach (var bitValue in bitValues)
            {
                w.WriteLine(bitValue.LocalBitSelectorMask == 0
                    ? $"if (bitsToTest == {bitValue.LocalBitSelectorValue})"
                    : $"if ((bitsToTest & 0x{bitValue.LocalBitSelectorMask:x}) == {bitValue.LocalBitSelectorValue})"
                );
                w.OpenBraceBlock();
                {
                    if (bitValue.Kind == EncodingBitValueKind.BitExtract)
                    {
                        var bitRanges = bitValue.BitItems.Select(x => x.Range).ToList();
                        var bitValueExtractString = ExtractBitRangeString(bitRanges, "bitValue", "extractedValue");
                        Debug.Assert(parameters.Count == 1);
                        w.WriteLine(bitValueExtractString);
                        if (bitValue.Addend != 0)
                        {
                            w.WriteLine(bitValue.HasNegativeExtract
                                ? $"{parameters[0].ParameterName} = {bitValue.Addend} - ({parameters[0].ParameterType})extractedValue;"
                                : $"{parameters[0].ParameterName} = ({parameters[0].ParameterType})extractedValue - {bitValue.Addend};");
                        }
                        else
                        {
                            w.WriteLine($"{parameters[0].ParameterName} = ({parameters[0].ParameterType})extractedValue;");
                        }
                    }
                    else
                    {
                        writeSelector(w, selector, bitValue);
                    }
                    w.WriteLine("return true;");
                }
                w.CloseBraceBlock();
            }

            w.WriteLine("break;");
        }
    }

    private string ExtractBitRangeString(List<BitRange> bitRanges, string inputValue, string outputValue)
    {
        StringBuilder builder = new();
        builder.Clear();
        // We start from the lowest bits to the highest bits
        int accumulation = 0;
        for (var i = bitRanges.Count - 1; i >= 0; i--)
        {
            var bitRange = bitRanges[i];
            var mask = ((1U << bitRange.Width) - 1) << accumulation;

            if (i < bitRanges.Count - 1)
            {
                builder.Append(" | ");
            }

            var shift = bitRange.LowBit - accumulation;

            if (shift > 0)
            {
                builder.Append($"(({inputValue} >> {shift}) & 0x{mask:X})");
            }
            else if (shift < 0)
            {
                builder.Append($"(({inputValue} << {-shift}) & 0x{mask:X})");
            }
            else
            {
                builder.Append($"({inputValue} & 0x{mask:X})");
            }
            accumulation += bitRange.Width;
        }

        return $"var {outputValue} = {builder};";
    }
    
    private static (string VKind, int ElementCount) GetVKindAndElementCount(Arm64RegisterVectorArrangementEncodingKind kind)
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

    private CodeWriter GetWriter(string fileName, bool isTest = false, bool header = true)
    {
        var sw = new StreamWriter(Path.Combine(isTest ? _basedOutputTestFolder : _basedOutputFolder, "generated", fileName));
        var w = new CodeWriter(sw);

        if (header)
        {
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
        }

        return w;
    }
}