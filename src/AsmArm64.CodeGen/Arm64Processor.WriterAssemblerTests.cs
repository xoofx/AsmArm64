// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{
    private void WriteInstructionTests(string instClass, Dictionary<string, List<InstructionVariation>> mapMnemonicToInstructions)
    {
        using var w = GetWriter($"Arm64InstructionFactoryTests.{instClass}.gen.cs", isTest: true);

        w.WriteLine("using System.Runtime.CompilerServices;");

        w.WriteLine("namespace AsmArm64.Tests;");

        w.WriteLine();
        w.WriteLine("public partial class Arm64InstructionFactoryTests");
        w.OpenBraceBlock();

        bool isFirst = true;
        foreach (var pair in mapMnemonicToInstructions.OrderBy(x => x.Key))
        {
            for (var i = 0; i < pair.Value.Count; i++)
            {
                var variation = pair.Value[i];
                if (!isFirst)
                {
                    w.WriteLine();
                }

                isFirst = false;
                WriteInstructionVariationTest(w, variation, i);
            }
        }

        w.CloseBraceBlock();
    }
    
    private void WriteInstructionVariationTest(CodeWriter w, InstructionVariation instructionVariation, int variationIndex)
    {
        var instruction = instructionVariation.Instruction;
        w.WriteSummary($"Test of <see cref=\"Arm64InstructionFactory.{instructionVariation.Mnemonic}\"/>.");
        w.WriteLine("[TestMethod]");
        w.WriteLine($"public void Test_{instructionVariation.Instruction.Id}_{variationIndex}()");
        w.OpenBraceBlock();
        {
            // Write the parameters
            w.WriteLine("// TODO");
        }
        w.CloseBraceBlock();
    }
}