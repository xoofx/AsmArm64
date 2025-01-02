// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections.Frozen;
using System.Diagnostics;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

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
    }

    private void GenerateMnemonicEnum()
    {
        using var w = GetWriter("Arm64Mnemonic.gen.cs");

        var mnemonics = _instructions.Select(x => x.Mnemonic).ToHashSet();

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 mnemonics.");
        w.WriteLine("public enum Arm64Mnemonic");
        w.OpenBraceBlock();
        w.WriteSummary("This mnemonic is invalid.");
        w.WriteLine("Invalid,");
        foreach (var mnemonic in mnemonics.Order())
        {
            w.WriteSummary($"This {mnemonic} mnemonic.");
            w.WriteLine($"{mnemonic},");
        }
        w.CloseBraceBlock();
    }

    private void GenerateInstructionIdEnum()
    {
        using var w = GetWriter("Arm64InstructionId.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("A list of all ARM64 instruction ids.");
        w.WriteLine("public enum Arm64InstructionId");
        w.OpenBraceBlock();
        w.WriteSummary("This instruction is invalid / undefined.");
        w.WriteLine("Invalid,");
        foreach (var instruction in _instructions)
        {
            w.WriteSummary($"Instruction {instruction.Mnemonic} - {instruction.Summary}.");
            w.WriteLine($"{instruction.NormalizedName},");
        }
        w.CloseBraceBlock();
    }
    
    private CodeWriter GetWriter(string fileName)
    {
        var sw = new StreamWriter(Path.Combine(_basedOutputFolder, fileName));
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