// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Reflection.Metadata;
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
            if (pair.Key == "HINT" || MnemonicsRequiringManualHandlingBecauseOfAliases.Contains(pair.Key)) // instruction.Id = HINT_HM_hints
            {
                continue;
            }
            
            using var w = GetWriter(Path.Combine(instClass, $"Arm64InstructionFactoryTests_{pair.Key}.gen.cs"), isTest: true);

            w.WriteLine("using static AsmArm64.Arm64InstructionFactory;");
            w.WriteLine("using static AsmArm64.Arm64Factory;");

            w.WriteLine($"namespace AsmArm64.Tests.{instClass};");

            w.WriteLine();
            w.WriteLine("[TestClass]");
            w.WriteLine($"public class Arm64InstructionFactoryTests_{pair.Key}_{instClass} : Arm64InstructionFactoryTests");
            w.OpenBraceBlock();

            for (var i = 0; i < pair.Value.Count; i++)
            {
                var variation = pair.Value[i];
                //if (variation.Instruction.IsDiscardedByPreferredAlias || variation.Instruction.Alias is not null || variation.Instruction.AliasesIn.Count > 0) continue;

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
            w.WriteLine($"Assert.Inconclusive(\"Not handled {instructionVariation.Instruction.Id} - {instructionVariation.Instruction.FullSyntax}\");");
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
            //     var raw = ADD(X0, X1, X2);

            for (var argIndex = 0; argIndex < testArguments.Count; argIndex++)
            {
                var testArgument = testArguments[argIndex];
                testArgument.InitializeFromArguments(instructionVariation, testArguments, argIndex);
            }

            FindBestAlias(instructionVariation, testArguments, out var preferredInstruction, out var expectedAsm);

            var cSharpMnemonic = GetInstructionMnemonic(instruction);
            
            // Test Arm64Assembler
            var labelIndex = instructionVariation.Operands.FindIndex(x => x.Descriptor is LabelOperandDescriptor);
            if (labelIndex >= 0)
            {
                w.Write($"TestInst({cSharpMnemonic}({string.Join(", ", testArguments.Select(x => x.CSharp))}), null");
            }
            else
            {
                w.Write($"TestInst({cSharpMnemonic}({string.Join(", ", testArguments.Select(x => x.CSharp))})");
                w.Write($", asm => asm.{cSharpMnemonic}({string.Join(", ", testArguments.Select(x => x.CSharp))})");
            }

            // Special case for LSL instructions that are folded into a single instruction
            if (instructionVariation.ElseVariation is not null && testArguments.OfType<MemoryTestArgument>().Any(x => x.Extend == "LSL"))
            {
                w.Write($", Arm64InstructionId.{instructionVariation.ElseVariation.Instruction.Id}");
            }
            else
            {
                w.Write($", Arm64InstructionId.{preferredInstruction.Id}");
            }
            w.Write($", Arm64Mnemonic.{preferredInstruction.Mnemonic}");
            w.WriteLine($", \"{expectedAsm}\");");
        }
    }

    private void FindBestAlias(InstructionVariation instructionVariation, List<TestArgument> testArguments, out Instruction preferredInstruction, out string? asm)
    {
        var instruction = instructionVariation.Instruction;
        preferredInstruction = instruction;
        Instruction? potentialPreferredAlias = null;
        if (instruction.IsDiscardedByPreferredAlias)
        {
            if (instruction.Alias is not null)
            {
                Debug.Assert(instruction.Alias.IsNever);
                preferredInstruction = MapIdToInstruction[instruction.Alias.InstructionId];
            }
            else
            {
                Debug.Assert(instruction.AliasesIn.Count > 0);
                var bestAlias = instruction.AliasesIn.First(x => x.IsAlways);
                preferredInstruction = MapIdToInstruction[bestAlias.InstructionId];
            }
        }
        else
        {
            foreach (var potentialAlias in instruction.AliasesIn)
            {
                var alias = MapIdToInstruction[potentialAlias.InstructionId];
                if (alias.IsAliasPreferredByMoreSelectiveBitMask)
                {
                    potentialPreferredAlias = alias;
                    break;
                }
            }
        }
        potentialPreferredAlias ??= preferredInstruction;

        var mnemonic = preferredInstruction.Mnemonic;
        var localArguments = new List<TestArgument>(testArguments);

        switch (instruction.Id)
        {
            case "B_only_condbranch":
            case "BC_only_condbranch":
                // `BC.NE #32` instead of `BC NE, #32`
                mnemonic = $"{instruction.Mnemonic}.{testArguments[0].Asm}";
                localArguments.RemoveAt(0);
                break;
            case "ADDS_32_addsub_shift":
            case "ADDS_32s_addsub_ext":
            case "ADDS_32s_addsub_imm":
            case "ADDS_64_addsub_shift":
            case "ADDS_64s_addsub_ext":
            case "ADDS_64s_addsub_imm":
            case "ANDS_32_log_shift":
            case "ANDS_32s_log_imm":
            case "ANDS_64_log_shift":
            case "ANDS_64s_log_imm":
            case "SUBPS_64s_dp_2src":
            case "SUBS_32s_addsub_ext":
            case "SUBS_32s_addsub_imm":
            case "SUBS_64s_addsub_ext":
            case "SUBS_64s_addsub_imm":
                // First argument is WZR, so the preferred alias is the one without it

                if (IsWZR(localArguments[0]))
                {
                    preferredInstruction = potentialPreferredAlias;
                    mnemonic = potentialPreferredAlias.Mnemonic;
                    localArguments.RemoveAt(0);
                }
                break;
            case "BFI_bfm_32m_bitfield":
                // Second argument is WZR, so the preferred alias is the one without it
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["BFC_bfm_32m_bitfield"];
                    mnemonic = "BFC";
                    localArguments.RemoveAt(1);
                }
                break;
            case "ORR_32_log_imm":
            case "ORR_64_log_imm":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = potentialPreferredAlias;
                    mnemonic = potentialPreferredAlias.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "ORR_32_log_shift":
            case "ORR_64_log_shift":
            {
                if (IsWZR(localArguments[1]) && localArguments[3] is ShiftTestArgument shiftArg && shiftArg.Kind == "LSL" && shiftArg.Amount == 0)
                {
                    preferredInstruction = potentialPreferredAlias;
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                    localArguments.RemoveAt(1);
                }

                break;
            }
            case "ORN_32_log_shift":
            case "ORN_64_log_shift":
                {
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = potentialPreferredAlias;
                    mnemonic = preferredInstruction.Mnemonic;

                    if (localArguments[3] is ShiftTestArgument shiftArg && shiftArg.Kind == "LSL" && shiftArg.Amount == 0)
                    {
                        localArguments.RemoveAt(3);
                    }
                    localArguments.RemoveAt(1);
                }

                break;
            }
            case "SUB_32_addsub_shift":
            case "SUB_64_addsub_shift":
            {
                    if (IsWZR(localArguments[1]))
                    {
                        preferredInstruction = potentialPreferredAlias;
                        mnemonic = preferredInstruction.Mnemonic;
                        //if (localArguments[3] is ExtendTestArgument shiftArg && shiftArg.Extend == "LSL" && shiftArg.Amount == 0)
                        //{
                        //    localArguments.RemoveAt(3);
                        //}

                        localArguments.RemoveAt(1);
                    }
                    else if (IsWZR(localArguments[0]))
                    {
                        if (localArguments[3] is ShiftTestArgument shiftArg)
                        {
                            if (shiftArg.Kind == "LSL" && shiftArg.Amount == 0)
                            {
                                localArguments.RemoveAt(3);
                            }
                        }
                        else
                        {
                            preferredInstruction = potentialPreferredAlias;
                            mnemonic = preferredInstruction.Mnemonic;
                            localArguments.RemoveAt(0);
                        }
                    }

                    break;
            }
            case "SUBS_32_addsub_shift":
            case "SUBS_64_addsub_shift":
            {
                if (IsWZR(localArguments[0]))
                {
                    preferredInstruction = potentialPreferredAlias;
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(0);
                }
                else if (IsWZR(localArguments[1]))
                {
                    if (localArguments[3] is ShiftTestArgument shiftArg && shiftArg.Kind == "LSL" && shiftArg.Amount == 0)
                    {
                        localArguments.RemoveAt(3);
                    }

                    preferredInstruction = MapIdToInstruction[instruction.Id == "SUBS_32_addsub_shift"
                        ? "NEGS_subs_32_addsub_shift"
                        : "NEGS_subs_64_addsub_shift"];
                    mnemonic = preferredInstruction.Mnemonic;

                    localArguments.RemoveAt(1);
                }
                break;
            }

            case "CINC_csinc_32_condsel":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["CSET_csinc_32_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "CINC_csinc_64_condsel":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["CSET_csinc_64_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "CINV_csinv_32_condsel":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["CSETM_csinv_32_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "CINV_csinv_64_condsel":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["CSETM_csinv_64_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }

                break;
            case "CSINC_32_condsel":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["CSET_csinc_32_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(2);
                    localArguments.RemoveAt(1);
                    var cond = ((RawTestArgument)localArguments[1]);
                    localArguments[1] = new RawTestArgument(cond.CSharp, InvertConditional(cond.Asm));
                }
                break;
            case "CSINC_64_condsel":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["CSET_csinc_64_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(2);
                    localArguments.RemoveAt(1);
                    var cond = ((RawTestArgument)localArguments[1]);
                    localArguments[1] = new RawTestArgument(cond.CSharp, InvertConditional(cond.Asm));
                }
                break;
            case "CSINV_32_condsel":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["CSETM_csinv_32_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(2);
                    localArguments.RemoveAt(1);
                    var cond = ((RawTestArgument)localArguments[1]);
                    localArguments[1] = new RawTestArgument(cond.CSharp, InvertConditional(cond.Asm));
                }
                break;
            case "CSINV_64_condsel":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["CSETM_csinv_64_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(2);
                    localArguments.RemoveAt(1);
                    var cond = ((RawTestArgument)localArguments[1]);
                    localArguments[1] = new RawTestArgument(cond.CSharp, InvertConditional(cond.Asm));
                }
                break;
            case "CSNEG_32_condsel":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["CNEG_csneg_32_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                    var cond = ((RawTestArgument)localArguments[2]);
                    localArguments[2] = new RawTestArgument(cond.CSharp, InvertConditional(cond.Asm));
                }
                break;
            case "CSNEG_64_condsel":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["CNEG_csneg_64_condsel"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                    var cond = ((RawTestArgument)localArguments[2]);
                    localArguments[2] = new RawTestArgument(cond.CSharp, InvertConditional(cond.Asm));
                }
                break;
            case "BFM_32m_bitfield":

                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["BFC_bfm_32m_bitfield"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                    localArguments[1] = new ImmediateTestArgument(27);
                    localArguments[2] = new ImmediateTestArgument(6);
                }
                else
                {
                    preferredInstruction = MapIdToInstruction["BFXIL_bfm_32m_bitfield"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments[3] = new ImmediateTestArgument(1);
                }
                break;
            case "UBFM_32m_bitfield":
                preferredInstruction = MapIdToInstruction["UBFX_ubfm_32m_bitfield"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments[3] = new ImmediateTestArgument(1);
                break;

            case "UBFM_64m_bitfield":
                preferredInstruction = MapIdToInstruction["UBFX_ubfm_64m_bitfield"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments[3] = new ImmediateTestArgument(1);
                break;

            case "BFM_64m_bitfield":

                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["BFC_bfm_64m_bitfield"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                    localArguments[1] = new ImmediateTestArgument(59);
                    localArguments[2] = new ImmediateTestArgument(6);
                }
                else
                {
                    preferredInstruction = MapIdToInstruction["BFXIL_bfm_64m_bitfield"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments[3] = new ImmediateTestArgument(1);
                }
                break;
            case "BFXIL_bfm_32m_bitfield":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["BFC_bfm_32m_bitfield"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                    localArguments[1] = new ImmediateTestArgument(27);
                    localArguments[2] = new ImmediateTestArgument(6);
                }
                break;
            case "BFXIL_bfm_64m_bitfield":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["BFC_bfm_64m_bitfield"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                    localArguments[1] = new ImmediateTestArgument(59);
                    localArguments[2] = new ImmediateTestArgument(6);
                }
                break;
            case "EXTR_32_extract":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["ROR_extr_32_extract"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(2);
                }
                break;
            case "EXTR_64_extract":
                if (IsWZR(localArguments[1]) && IsWZR(localArguments[2]))
                {
                    preferredInstruction = MapIdToInstruction["ROR_extr_64_extract"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(2);
                }
                break;
            case "SBFM_32m_bitfield":
                // Complicated alias rules, we cover only one in the unit tests
                preferredInstruction = MapIdToInstruction["SBFX_sbfm_32m_bitfield"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments[3] = new ImmediateTestArgument(1);
                break;
            case "SBFM_64m_bitfield":
                // Complicated alias rules, we cover only one in the unit tests
                preferredInstruction = MapIdToInstruction["SBFX_sbfm_64m_bitfield"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments[3] = new ImmediateTestArgument(1);
                break;
            case "SBC_32_addsub_carry":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["NGC_sbc_32_addsub_carry"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "SBC_64_addsub_carry":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["NGC_sbc_64_addsub_carry"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "SBCS_32_addsub_carry":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["NGCS_sbcs_32_addsub_carry"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "SBCS_64_addsub_carry":
                if (IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["NGCS_sbcs_64_addsub_carry"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(1);
                }
                break;
            case "SMADDL_64wa_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["SMULL_smaddl_64wa_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "MSUB_32a_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["MNEG_msub_32a_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "MSUB_64a_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["MNEG_msub_64a_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "NEGS_subs_32_addsub_shift":
                if (IsWZR(localArguments[0]))
                {
                    preferredInstruction = MapIdToInstruction["CMP_subs_32_addsub_shift"];
                    mnemonic = preferredInstruction.Mnemonic;
                    if (localArguments[2] is ShiftTestArgument shiftArg && shiftArg.Amount == 0)
                    {
                        localArguments.RemoveAt(2);
                    }
                }
                break;
            case "LSL_ubfm_32m_bitfield":
                // Complicated alias rules, we cover only one in the unit tests
                preferredInstruction = MapIdToInstruction["UBFIZ_ubfm_32m_bitfield"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments.Add(new ImmediateTestArgument(1));
                break;
            case "LSL_ubfm_64m_bitfield":
                // Complicated alias rules, we cover only one in the unit tests
                preferredInstruction = MapIdToInstruction["UBFIZ_ubfm_64m_bitfield"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments.Add(new ImmediateTestArgument(1));
                break;
            case "MADD_32a_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["MUL_madd_32a_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "MADD_64a_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["MUL_madd_64a_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "UMADDL_64wa_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["UMULL_umaddl_64wa_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "UMSUBL_64wa_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["UMNEGL_umsubl_64wa_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "SMSUBL_64wa_dp_3src":
                if (IsWZR(localArguments[3]))
                {
                    preferredInstruction = MapIdToInstruction["SMNEGL_smsubl_64wa_dp_3src"];
                    mnemonic = preferredInstruction.Mnemonic;
                    localArguments.RemoveAt(3);
                }
                break;
            case "MOV_add_32_addsub_imm":
                // Revert the change from auto-detection above
                if (!IsWZR(localArguments[0]) && !IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["MOV_orr_32_log_shift"];
                    mnemonic = preferredInstruction.Mnemonic;
                }
                break;
            case "MOV_add_64_addsub_imm":
                // Revert the change from auto-detection above
                if (!IsWZR(localArguments[0]) && !IsWZR(localArguments[1]))
                {
                    preferredInstruction = MapIdToInstruction["MOV_orr_64_log_shift"];
                    mnemonic = preferredInstruction.Mnemonic;
                }

                break;
            case "MOVN_32_movewide":
                preferredInstruction = MapIdToInstruction["MOV_movn_32_movewide"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments.RemoveAt(2);
                localArguments.RemoveAt(1);
                localArguments.Add(new ImmediateTestArgument(5, 16, true, true));
                break;
            case "MOVN_64_movewide":
                preferredInstruction = MapIdToInstruction["MOV_movn_64_movewide"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments.RemoveAt(2);
                localArguments.RemoveAt(1);
                localArguments.Add(new ImmediateTestArgument(5, 16, false, true));
                break;
            case "MOVZ_32_movewide":
                preferredInstruction = MapIdToInstruction["MOV_movz_32_movewide"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments.RemoveAt(2);
                localArguments.RemoveAt(1);
                localArguments.Add(new ImmediateTestArgument(5, 16, true, false));
                break;
            case "MOVZ_64_movewide":
                preferredInstruction = MapIdToInstruction["MOV_movz_64_movewide"];
                mnemonic = preferredInstruction.Mnemonic;
                localArguments.RemoveAt(2);
                localArguments.RemoveAt(1);
                localArguments.Add(new ImmediateTestArgument(5, 16, false, false));
                break;
            case "UMOV_asimdins_w_w":
                preferredInstruction = testArguments[1] is RegisterTestArgument regArg && regArg.VKind == "S"
                    ? MapIdToInstruction["MOV_umov_asimdins_w_w"]
                    : MapIdToInstruction["UMOV_asimdins_w_w"];
                mnemonic = preferredInstruction.Mnemonic;
                break;
                //case "UMOV_asimdins_x_x":
                //    preferredInstruction = MapIdToInstruction["MOV_umov_asimdins_x_x"];
                //    mnemonic = preferredInstruction.Mnemonic;
                //    break;
        }

        // Swap arguments
        if (MnemonicsToInvertFirstTwoOperands.Contains(instruction.Mnemonic) && localArguments[1] is RegisterTestArgument)
        {
            (localArguments[0], localArguments[1]) = (localArguments[1], localArguments[0]);
        }
        else if (SpecialLDMnemonicsAndWZR.Contains(instruction.Mnemonic) && IsWZR(localArguments[1]))
        {
            preferredInstruction = MapIdToInstruction[instruction.AliasesIn[0].InstructionId];
            mnemonic = preferredInstruction.Mnemonic;
            localArguments.RemoveAt(1);
        }

        asm = testArguments.Count == 0
            ? mnemonic
            : $"{mnemonic} {GetAsmArguments(localArguments)}";
    }

    private static bool IsWZR(TestArgument testArgument) => testArgument is RegisterTestArgument regArg && regArg.Index == 31;


    private static string GetAsmArguments(IEnumerable<TestArgument> arguments)
    {
        // Trim empty (optional) last argument
        return string.Join(", ", arguments.Select(x => x.Asm)).Trim().Trim(',');
    }

    private abstract record TestArgument
    {
        public abstract string CSharp { get; }

        public abstract string Asm { get; }

        public virtual void InitializeFromArguments(InstructionVariation instructionVariation, IReadOnlyList<TestArgument> arguments, int index)
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

    private record ExtendTestArgument : TestArgument
    {
        public ExtendTestArgument(string extend, int? amount)
        {
            Extend = extend;
            Amount = amount;
        }
        public string Extend { get; private set; }

        public int? Amount { get; }
        
        public override string CSharp => GetText(false);
        public override string Asm => GetText(true);

        public override void InitializeFromArguments(InstructionVariation instructionVariation, IReadOnlyList<TestArgument> arguments, int index)
        {
            var descriptor = (ExtendOperandDescriptor)instructionVariation.Operands[index].Descriptor;

            var rd = (RegisterTestArgument)arguments[0];
            var rn = (RegisterTestArgument)arguments[1];
            RegisterTestArgument rm;

            if (arguments[2] is RegisterTestArgument regArg)
            {
                rm = regArg;
            }
            else
            {
                // Alias instructions with RD = XZR
                rm = rn;
                rn = rd;
                rd = new RegisterTestArgument("X", 31);
            }

            var lslAlternative =  descriptor.Is64Bit ? "UXTX" : "UXTW";

            if (Extend == lslAlternative || Extend == "LSL")
            {
                if (descriptor.EncodingKind == Arm64ExtendEncodingKind.PreferLSLIfRnIs11111)
                {
                    if (rn.Index == 31)
                    {
                        Extend = "LSL";
                    }
                    else if (Extend == "LSL")
                    {
                        Extend = lslAlternative;
                    }
                }
                else
                {
                    if ((rn.Index == 31 || rd.Index == 31))
                    {
                        Extend = "LSL";
                    }
                    else if (Extend == "LSL")
                    {
                        Extend = lslAlternative;
                    }
                }
            }
        }

        private string GetText(bool isAsm)
        {
            if (isAsm)
            {
                return Amount.HasValue ? $"{Extend} #{Amount.Value}" : Extend;
            }
            else
            {
                return Amount.HasValue ? $"_{Extend}, {Amount.Value}" : $"_{Extend}";
            }
        }
    }

    private record ShiftTestArgument : TestArgument
    {
        public ShiftTestArgument(string kind, int amount, bool optional)
        {
            Kind = kind;
            Amount = amount;
            IsOptional = optional;
        }
        public string Kind { get; private set; }

        public int Amount { get; }

        public bool IsOptional { get; }

        public override string CSharp => $"_{Kind}, {Amount}";

        public override string Asm => IsOptional && Amount == 0 ? "" : $"{Kind} #{Amount}";
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
            Value = (long)value;
            Is32 = false;
            IsHexa = hexa;
        }

        public ImmediateTestArgument(ushort value, int shift, bool is32, bool inverted)
        {
            Value = value;
            Shift = shift;
            Is32 = is32;
            IsShift = true;
            IsInverted = inverted;
        }

        public ImmediateTestArgument(int value, bool hexa = false)
        {
            Value = (long)value;
            Is32 = true;
            IsHexa = hexa;
        }

        public long Value { get; private set; }

        public bool Is32 { get; }

        public bool IsShift { get; }

        public int Shift { get; }

        public bool IsFloat { get; }

        public bool IsHexa { get; }

        public bool IsInverted { get; }

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
                if (Is32)
                {
                    if (IsInverted)
                    {
                        text = isAsm ? (~((int)Value << Shift)).ToString() : $"InvertShift32({Value}, {Shift})";
                    }
                    else
                    {
                        text = isAsm ? ((int)Value << Shift).ToString() : $"Shift32({Value}, {Shift})";
                    }
                }
                else
                {
                    if (IsInverted)
                    {
                        text = isAsm ? (~(Value << Shift)).ToString() : $"InvertShift64({Value}, {Shift})";
                    }
                    else
                    {
                        text = isAsm ? (Value << Shift).ToString() : $"Shift64({Value}, {Shift})";
                    }
                }
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

        public override void InitializeFromArguments(InstructionVariation instructionVariation, IReadOnlyList<TestArgument> arguments, int index)
        {
            var instruction = instructionVariation.Instruction;
            if ((instruction.Id == "TBZ_only_testbranch" || instruction.Id == "TBNZ_only_testbranch") && index == 1)
            {
                var registerArg = (RegisterTestArgument)arguments[0];
                if (registerArg.BaseRegisterName == "W")
                {
                    Value = 5;
                }
                else
                {
                    Debug.Assert(registerArg.BaseRegisterName == "X");
                    Value = 37;
                }
            }
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

        public override void InitializeFromArguments(InstructionVariation instructionVariation, IReadOnlyList<TestArgument> arguments, int index)
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

        public Func<RegisterTestArgument, uint>? Encode { get; set; }

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

    private static readonly HashSet<string> MnemonicsToInvertFirstTwoOperands =
    [
        "CBBLE",
        "CBBLO",
        "CBBLS",
        "CBBLT",
        "CBHLE",
        "CBHLO",
        "CBHLS",
        "CBHLT",
        "CBLE",
        "CBLO",
        "CBLS",
        "CBLT",
    ];

    private static readonly HashSet<string> SpecialLDMnemonicsAndWZR =
    [
        "LDADD",
        "LDADDB",
        "LDADDH",
        "LDADDL",
        "LDADDLB",
        "LDADDLH",
        "LDCLR",
        "LDCLRB",
        "LDCLRH",
        "LDCLRL",
        "LDCLRLB",
        "LDCLRLH",
        "LDEOR",
        "LDEORB",
        "LDEORH",
        "LDEORL",
        "LDEORLB",
        "LDEORLH",
        "LDSET",
        "LDSETB",
        "LDSETH",
        "LDSETL",
        "LDSETLB",
        "LDSETLH",
        "LDSMAX",
        "LDSMAXB",
        "LDSMAXH",
        "LDSMAXL",
        "LDSMAXLB",
        "LDSMAXLH",
        "LDSMIN",
        "LDSMINB",
        "LDSMINH",
        "LDSMINL",
        "LDSMINLB",
        "LDSMINLH",
        "LDTADD",
        "LDTADDL",
        "LDTCLR",
        "LDTCLRL",
        "LDTSET",
        "LDTSETL",
        "LDUMAX",
        "LDUMAXB",
        "LDUMAXH",
        "LDUMAXL",
        "LDUMAXLB",
        "LDUMAXLH",
        "LDUMIN",
        "LDUMINB",
        "LDUMINH",
        "LDUMINL",
        "LDUMINLB",
        "LDUMINLH",
    ];

    private static readonly HashSet<string> MnemonicsRequiringManualHandlingBecauseOfAliases =
    [
        //"BFM",
        //"BFXIL",
        //"EXTR",
        //"LSL",
        //"MADD",
        //"MOV_MOVN",
        //"MOV",
        //"MOVN",
        //"MOVZ",
        //"MSUB",
        //"NEGS",
        //"ORN",
        //"ROR",
        //"SBC",
        //"SBCS",
        //"SBFM",
        //"SMADDL",
        //"UBFM",
        //"UMADDL",
        //"UMSUBL",
    ];
}