// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

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
        GenerateInstructionDecoderTable();
        GenerateInstructionIdTests();
    }

    private void GenerateMnemonicEnum()
    {
        using var w = GetWriter("Arm64Mnemonic.gen.cs");

        var mnemonics = _instructions.Select(x => x.Mnemonic).ToHashSet();

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 mnemonics.");
        w.WriteLine("public enum Arm64Mnemonic : ushort");
        w.OpenBraceBlock();
        {
            w.WriteSummary("This mnemonic is invalid.");
            w.WriteLine("Invalid,");
            foreach (var mnemonic in mnemonics.Order())
            {
                w.WriteSummary($"This `{mnemonic}` mnemonic.");
                w.WriteLine($"{mnemonic},");
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
                foreach (var mnemonic in mnemonics.Order())
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
                foreach (var mnemonic in mnemonics.Order())
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
            w.WriteLine($"{instruction.NormalizedName},");
        }
        w.CloseBraceBlock();
    }

    private void GenerateInstructionClass()
    {
        using var w = GetWriter("Arm64InstructionClass.gen.cs");

        var instructionClasses = _instructions.Select(x => x.InstructionClass).ToHashSet().Order();

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 instruction classes.");
        w.WriteLine("public enum Arm64InstructionClass : byte");
        w.OpenBraceBlock();
        w.WriteSummary("The instruction class is invalid / unknown.");
        w.WriteLine("Invalid,");
        foreach (var iClass in instructionClasses)
        {
            w.WriteSummary($"Class `{iClass}`.");
            w.WriteLine($"{iClass},");
        }
        w.CloseBraceBlock();
    }

    private void GenerateArchitecture()
    {
        var variants = _archVariantNameToArchitectureId.Values.ToHashSet().Order().ToList();
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
                w.WriteSummary($"Feature `{EscapeHtmlEntities(featureExpression.FeatureExpression)}` for `{featureExpression.Name}`.");
            }
            else
            {
                w.WriteSummary($"Feature `{EscapeHtmlEntities(featureExpression.FeatureExpression)}`.");
            }
            w.WriteLine($"{featureExpression.FeatureExpressionId},");
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
            var buffer = _tableGenEncoder.Buffer;
            w.WriteLine($"public static ReadOnlySpan<byte> Buffer => new byte[{buffer.Length}]");
            w.OpenBraceBlock();
            for (var i = 0; i < buffer.Length; i++)
            {
                w.Write($"{buffer[i]},");
                if (i % 16 == 15)
                {
                    w.WriteLine();
                }
            }
            if (buffer.Length % 16 != 0)
            {
                w.WriteLine();
            }
            w.CloseBraceBlockStatement();
        }
        w.CloseBraceBlock();
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
                    w.WriteLine($"[DataRow(0x{instruction.BitfieldValueForTest:X8}U, Arm64InstructionId.{instruction.NormalizedName})]");
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