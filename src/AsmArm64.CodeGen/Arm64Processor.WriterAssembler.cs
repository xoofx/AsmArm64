// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Numerics;
using System.Reflection.Emit;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{
    private void GenerateAssembler()
    {
        var mapClassToMnemonicToInstructionVariations = GenerateInstructionVariations();

        foreach (var (instClass, mapMnemonicToInstructions) in mapClassToMnemonicToInstructionVariations)
        {
            WriteInstructions(instClass, mapMnemonicToInstructions);
            WriteInstructionTests(instClass, mapMnemonicToInstructions);
        }
    }

    private void GetOperandVariations(int operandIndex, Instruction instruction, Operand operand, List<OperandVariation> operandVariations)
    {
        var descriptor = operand.Descriptor;
        Debug.Assert(descriptor is not null);
        Debug.Assert(descriptor.Name.Length > 0);

        switch (descriptor.Kind)
        {
            case Arm64OperandKind.Register:
                GetRegisterOperandVariation(operandIndex, instruction, (RegisterOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.RegisterGroup:
                GetRegisterGroupOperandVariation(operandIndex, instruction, (RegisterGroupOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.SystemRegister:
                GetSystemRegisterVariation(instruction, (SystemRegisterOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Memory:
                GetMemoryOperandVariation(operandIndex, instruction, (MemoryOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Immediate:
                GetImmediateVariation(instruction, (ImmediateOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Label:
                GetLabelVariation(instruction, (LabelOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Shift:
                GetShiftOperandVariations(instruction, (ShiftOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Extend:
                GetExtendOperandVariations(instruction, (ExtendOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Enum:
                GetEnumVariations((EnumOperandDescriptor)descriptor, operandVariations);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    // Returns a map of instruction class to a map of mnemonic to a list of instruction variations
    private Dictionary<string, Dictionary<string, List<InstructionVariation>>> GenerateInstructionVariations()
    {
        var mapClassToMnemonicToInstructionVariations = new Dictionary<string, Dictionary<string, List<InstructionVariation>>>();

        var mapClassToInstructions = new Dictionary<string, List<Instruction>>();

        foreach (var instruction in _instructions)
        {
            if (instruction.IsDiscardedByPreferredAlias) continue;

            if (!mapClassToInstructions.TryGetValue(instruction.InstructionClass, out var instructions))
            {
                instructions = new List<Instruction>();
                mapClassToInstructions.Add(instruction.InstructionClass, instructions);
            }
            instructions.Add(instruction);
        }

        foreach (var (instClass, instructions) in mapClassToInstructions)
        {
            var mnemonicToInstructionVariations = new Dictionary<string, List<InstructionVariation>>();
            mapClassToMnemonicToInstructionVariations.Add(instClass, mnemonicToInstructionVariations);

            // We group by mnemonic, as certain instructions require merging (Instructions with memory operand and different LSL + EXTEND instructions)
            var mapMnemonicToInstructions = new Dictionary<string, List<Instruction>>();
            foreach (var instruction in instructions)
            {
                if (instruction.Id.StartsWith("SMS")) continue; // TODO: skip SMSTART/SMSTOP

                var mnemonic = GetInstructionMnemonic(instruction);
                if (!mapMnemonicToInstructions.TryGetValue(mnemonic, out var list))
                {
                    list = new List<Instruction>();
                    mapMnemonicToInstructions.Add(mnemonic, list);
                }

                list.Add(instruction);
            }

            foreach (var pair in mapMnemonicToInstructions.OrderBy(x => x.Key))
            {
                List<InstructionVariation> variations = new();
                GetInstructionVariations(pair.Key, pair.Value, variations);
                mnemonicToInstructionVariations.Add(pair.Key, variations);

                foreach (var instructionVariation in variations)
                {
                    // Prepare the instructions before writing them (in case we find a variation that matches operands and improve the encoding)
                    for (var i = 0; i < instructionVariation.Operands.Count; i++)
                    {
                        var operand = instructionVariation.Operands[i];

                        if (operand.PrepareWriteEncodings.Count > 0)
                        {
                            // As prepare can modify an operand, and an operand can be shared between variations, we need to clone the operand
                            operand = operand.Clone();
                            instructionVariation.Operands[i] = operand;

                            foreach (var prepare in operand.PrepareWriteEncodings)
                            {
                                prepare(instructionVariation, operand, i);
                            }
                        }
                    }
                }
            }
        }

        return mapClassToMnemonicToInstructionVariations;
    }

    private void WriteInstructions(string instClass, Dictionary<string, List<InstructionVariation>> mapMnemonicToInstructions)
    {
        using var w = GetWriter($"Arm64InstructionFactory.{instClass}.gen.cs");

        w.WriteLine("using System.Runtime.CompilerServices;");

        w.WriteLine("namespace AsmArm64;");

        w.WriteLine("static partial class Arm64InstructionFactory");
        w.OpenBraceBlock();

        foreach (var pair in mapMnemonicToInstructions.OrderBy(x => x.Key))
        {
            foreach (var variation in pair.Value)
            {
                WriteInstructionVariation(w, variation);
            }
        }

        w.CloseBraceBlock();
    }

    private void WriteInstructionVariation(CodeWriter w, InstructionVariation instructionVariation)
    {
        var instruction = instructionVariation.Instruction;

        w.WriteSummary($"{EscapeHtmlEntities(instruction.Summary)}.");
        w.WriteDoc($"<remarks><code>{EscapeHtmlEntities(MatchSpace.Replace(instruction.FullSyntax, " "))}</code></remarks>");
        w.WriteLine($"[Arm64LinkInstructionId(Arm64InstructionId.{instruction.Id}), MethodImpl(MethodImplOptions.AggressiveInlining)]");
        w.Write($"public static uint {instructionVariation.Mnemonic}(");

        for (var i = 0; i < instructionVariation.Operands.Count; i++)
        {
            var operand = instructionVariation.Operands[i];

            if (i > 0)
            {
                w.Write(", ");
            }

            operand.WriterParameters(w);
        }

        w.WriteLine(")");
        w.OpenBraceBlock();
        {
            w.Write($"uint raw = 0x{instructionVariation.BitfieldValue:X8}U; // Encoding for: {instruction.Id}");
            if (instructionVariation.ElseVariation is not null)
            {
                w.WriteLine($" and memory variation with 0x{instructionVariation.ElseVariation.BitfieldValue:X8} {instructionVariation.ElseVariation.Instruction.Id}");
            }
            else
            {
                w.WriteLine();

            }

            for (var operandIndex = 0; operandIndex < instructionVariation.Operands.Count; operandIndex++)
            {
                var operand = instructionVariation.Operands[operandIndex];
                foreach(var writeEncoding in operand.WriteEncodings)
                {
                    writeEncoding(w, "raw", instructionVariation, operand, operandIndex);
                }
            }

            w.WriteLine("return raw;");
        }
        w.CloseBraceBlock();
    }
    
    private void CombineInstructionVariations(string mnemonic, string id1, string id2, List<Instruction> instructions, List<InstructionVariation> variations)
    {
        var i1 = instructions.Find(x => x.Id == id1);
        if (i1 is null)
        {
            return;
        }
        instructions.Remove(i1);
        var i2 = instructions.First(x => x.Id == id2)!;
        instructions.Remove(i2);
        
        var v1 = new List<InstructionVariation>();
        GetInstructionVariations(mnemonic, i1, v1);

        var v2 = new List<InstructionVariation>();
        GetInstructionVariations(mnemonic, i2, v2);

        Debug.Assert((v1.Count == 1 && v2.Count == 2) || (v1.Count == 2 && v2.Count == 1));

        if (v1.Count == 2)
        {
            variations.AddRange(v1);
            foreach (var v in v1)
            {
                v.ElseVariation = v2[0];
            }
        }
        else
        {
            variations.AddRange(v2);
            foreach (var v in v2)
            {
                v.ElseVariation = v1[0];
            }
        }
    }

    private static readonly List<(string Mnemonic, string Id1, string Id2)> CombinedInstructionList =
    [
        ("LDR", "LDR_b_ldst_regoff", "LDR_bl_ldst_regoff"),
        ("STR", "STR_b_ldst_regoff", "STR_bl_ldst_regoff"),
        ("LDRB", "LDRB_32b_ldst_regoff", "LDRB_32bl_ldst_regoff"),
        ("LDRSB", "LDRSB_32b_ldst_regoff", "LDRSB_32bl_ldst_regoff"),
        ("LDRSB", "LDRSB_64b_ldst_regoff", "LDRSB_64bl_ldst_regoff"),
        ("STRB", "STRB_32b_ldst_regoff", "STRB_32bl_ldst_regoff"),
    ];

    private void GetInstructionVariations(string mnemonic, List<Instruction> instructions, List<InstructionVariation> variations)
    {
        // Special case where instructions are combined because of memory operand differing only with LSL / EXTEND
        foreach (var combined in CombinedInstructionList)
        {
            if (combined.Mnemonic  == mnemonic)
            {
                CombineInstructionVariations(mnemonic, combined.Id1, combined.Id2, instructions, variations);
            }
        }

        foreach (var instruction in instructions)
        {
            GetInstructionVariations(mnemonic, instruction, variations);
        }
    }

    private void GetInstructionVariations(string mnemonic, Instruction instruction, List<InstructionVariation> variations)
    {
        var allOperandVariations = new List<List<OperandVariation>>();

        for (var i = 0; i < instruction.Operands.Count; i++)
        {
            var operand = instruction.Operands[i];

            var operandVariations = new List<OperandVariation>();

            GetOperandVariations(i, instruction, operand, operandVariations);
            allOperandVariations.Add(operandVariations);
        }

        // Simplest case, we don't have a variation
        if (allOperandVariations.Count == 0 || allOperandVariations.All(x => x.Count == 1))
        {
            var instructionVariation = new InstructionVariation()
            {
                Mnemonic = mnemonic,
                BitfieldValue = instruction.BitfieldValue,
                Instruction = instruction,
            };

            foreach (var operandVariations in allOperandVariations)
            {
                instructionVariation.Operands.Add(operandVariations[0]);
            }

            variations.Add(instructionVariation);
        }
        else
        {
            var encodingSymbolExtracts = allOperandVariations.SelectMany(x => x.Select(z => z.EncodingExtract)).Distinct().ToList();

            // Slightly more complicated case. We have one producer of a variation.
            if (encodingSymbolExtracts.Count == 1)
            {
                var encodingSymbolExtract = encodingSymbolExtracts[0];
                var variationCount = allOperandVariations.Find(x => x.Any(y => y.EncodingExtract == encodingSymbolExtract))!.Count;
                
                for(int i = 0; i < variationCount; i++)
                {
                    var instructionVariation = new InstructionVariation()
                    {
                        Mnemonic = mnemonic,
                        BitfieldMask = instruction.BitfieldMask,
                        BitfieldValue = instruction.BitfieldValue,
                        Instruction = instruction,
                    };

                    foreach (var allOperandVariation in allOperandVariations)
                    {
                        var operandVariation = allOperandVariation.Count == 1 ? allOperandVariation[0] : allOperandVariation[i];
                        instructionVariation.BitfieldMask |= operandVariation.BitfieldMask;
                        instructionVariation.BitfieldValue |= operandVariation.BitfieldSets;
                        instructionVariation.Operands.Add(operandVariation);
                    }

                    variations.Add(instructionVariation);
                }
            }
            else
            {
                encodingSymbolExtracts = encodingSymbolExtracts.Where(x => x is not null).ToList();

                int maximumVariation = 0;
                int operandIndexWithMaximumVariation = -1;
                for (var operandIndex = 0; operandIndex < allOperandVariations.Count; operandIndex++)
                {
                    var operandVariations = allOperandVariations[operandIndex];
                    var variationCount = operandVariations.Count;
                    if (variationCount > maximumVariation)
                    {
                        maximumVariation = variationCount;
                        operandIndexWithMaximumVariation = operandIndex;
                    }
                }

                foreach (var operandVariation in allOperandVariations[operandIndexWithMaximumVariation])
                {
                    var instructionVariation = new InstructionVariation()
                    {
                        Mnemonic = mnemonic,
                        BitfieldMask = instruction.BitfieldMask,
                        BitfieldValue = instruction.BitfieldValue,
                        Instruction = instruction,
                    };

                    for (var operandIndex = 0; operandIndex < allOperandVariations.Count; operandIndex++)
                    {
                        var operandVariations = allOperandVariations[operandIndex];
                        if (operandVariations.Count == 1)
                        {
                            instructionVariation.Operands.Add(operandVariations[0]);
                        }
                        else if (operandIndex == operandIndexWithMaximumVariation)
                        {
                            instructionVariation.BitfieldMask |= operandVariation.BitfieldMask;
                            instructionVariation.BitfieldValue |= operandVariation.BitfieldSets;
                            instructionVariation.Operands.Add(operandVariation);
                        }
                        else
                        {
                            OperandVariation? otherOperandVariation = null;
                            foreach (var otherOperand in operandVariations)
                            {
                                if (otherOperand.AcceptedBitValues.Any(x => operandVariation.AcceptedBitValues.Any(y =>
                                {
                                    var sharedMask = x.BitSelectorMask & y.BitSelectorMask;


                                    return sharedMask != 0 && (x.BitSelectorValue & sharedMask) == (y.BitSelectorValue & sharedMask);
                                })))
                                {
                                    Debug.Assert(otherOperandVariation is null);
                                    otherOperandVariation = otherOperand;
                                }
                            }
                            Debug.Assert(otherOperandVariation is not null);
                            instructionVariation.Operands.Add(otherOperandVariation);
                        }
                    }

                    variations.Add(instructionVariation);
                }

                /*
                if (sameBitNameCheck)
                {
                   
                }
                else
                {
                    // More complicated case. We have multiple producer of variations, but they are all sharing the same encoding
                    // For example, Vn.T has {8B} and implies that Vd is {B}:
                    //
                    // Instruction ADDV_asimdall_only - ADDV        Vd, Vn.T - Count Selectors: 2 - Encoding Variations: 5
                    //         Vn.T,    Vd
                    //     [0] Vn.8B,   B
                    //     [1] Vn.16B,  B
                    //     [2] Vn.4H,   H
                    //     [3] Vn.8H,   H
                    //     [4] Vn.4S,   S
                    var bestEncodingExtra = encodingSymbolExtracts.Where(x => x?.Selector is not null).OrderByDescending(x => x.Selector!.BitSize).First();
                    var selector = bestEncodingExtra!.Selector!;

                    // For now, we only support a selector that is overlapping with all other selectors
                    // So that we can "merge" their output instead of "multiplying" their output
                    // After this loop, we have the guarantee that best selector can encode the other selectors and that it forces a value for the other selectors.
                    var otherEncodingExtras = encodingSymbolExtracts.Where(x => x != bestEncodingExtra).ToList();
                    foreach (var otherEncodingExtra in otherEncodingExtras)
                    {
                        // Check that the encoding both selectors is overlapping
                        Debug.Assert((selector.BitEncodingMask & otherEncodingExtra.Selector!.BitEncodingMask) != 0);
                        // Check that the encoding of other selectors are not outside the best selector
                        Debug.Assert((~selector.BitEncodingMask & otherEncodingExtra.Selector!.BitEncodingMask) == 0);
                    }

                    // Then for each variation of the best selector, we are going to find the associated variations of the other selectors
                    var encodingVariations = new List<List<(EncodingSymbolExtract SymbolExtract, EncodingBitValue SelectedSymbol)>>();

                    foreach (var bitValue in selector.BitValues)
                    {
                        var bitValuesForVariation = new List<(EncodingSymbolExtract SymbolExtract, EncodingBitValue SelectedSymbol)>
                    {
                        (bestEncodingExtra, bitValue)
                    };

                        foreach (var otherEncodingExtra in otherEncodingExtras)
                        {
                            var otherSelector = otherEncodingExtra.Selector!;
                            foreach (var otherBitValue in otherSelector.BitValues)
                            {
                                var sharedMask = (otherBitValue.BitSelectorMask & bitValue.BitSelectorMask);
                                if ((sharedMask & bitValue.BitSelectorValue) == (sharedMask & otherBitValue.BitSelectorValue))
                                {
                                    bitValuesForVariation.Add((otherEncodingExtra, otherBitValue));
                                    break;
                                }
                            }
                        }

                        var instructionVariation = new InstructionVariation()
                        {
                            Mnemonic = mnemonic,
                            BitfieldMask = instruction.BitfieldMask,
                            BitfieldValue = instruction.BitfieldValue,
                            Instruction = instruction,
                        };

                        foreach (var listOfVariationForOneOperand in allOperandVariations)
                        {
                            OperandVariation? operandVariation = null;
                            if (listOfVariationForOneOperand.Count == 1)
                            {
                                operandVariation = listOfVariationForOneOperand[0];
                            }
                            else
                            {
                                foreach (var operandVariationTry in listOfVariationForOneOperand)
                                {
                                    var selectedSymbol = bitValuesForVariation.First(x => x.SymbolExtract == operandVariationTry.EncodingExtract).SelectedSymbol;
                                    if (operandVariationTry.AcceptedBitValues.Contains(selectedSymbol))
                                    {
                                        operandVariation = operandVariationTry;
                                        break;
                                    }
                                }

                                Debug.Assert(operandVariation is not null);
                            }

                            instructionVariation.BitfieldMask |= operandVariation.BitfieldMask;
                            instructionVariation.BitfieldValue |= operandVariation.BitfieldSets;
                            instructionVariation.Operands.Add(operandVariation);
                        }

                        variations.Add(instructionVariation);

                        encodingVariations.Add(bitValuesForVariation);
                    }
                }
                */
                // Uncomment the following code to print the variations
                //Console.WriteLine($"Instruction {instruction.Id} - {instruction.FullSyntax} - Count Selectors: {encodingSymbolExtracts.Count} - Encoding Variations: {encodingVariations.Count}");
                //for (var i = 0; i < encodingVariations.Count; i++)
                //{
                //    var variationList = encodingVariations[i];
                //    Console.WriteLine($"    [{i}] {string.Join(",", variationList.Select(x => x.SelectedSymbol.Text))}");
                //}
            }
        }
    }



    private void GetSystemRegisterVariation(Instruction instruction, SystemRegisterOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var operandVariation = new OperandVariation()
        {
            Descriptor = descriptor,
            OperandName = GetNormalizedOperandName(descriptor.Name),
            OperandType = "Arm64SystemRegister"
        };

        GenerateBitRangeEncodingFromValue($"{operandVariation.OperandName}.Value", "system register", descriptor.Encoding, operandVariation.WriteEncodings, 16); // Arm64SystemRegister.Value is 16 bits

        operandVariations.Add(operandVariation);

        var systemRegisterKind = GetSystemRegisterKind(descriptor.SystemRegisterKindIndex);
        foreach (var sysRegister in _systemRegisters.Values)
        {
            if (sysRegister.UsageKinds.Contains(systemRegisterKind))
            {
                operandVariation.TestArguments.Add(new RawTestArgument(sysRegister.Name, sysRegister.Name));
                break;
            }
        }
    }
    
    private void GetLabelVariation(Instruction instruction, LabelOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var operandVariation = new OperandVariation()
        {
            Descriptor = descriptor,
            OperandName = GetNormalizedOperandName(descriptor.Name),
            OperandType = "Arm64LabelOffset",
        };

        var originalOperandPath = $"{operandVariation.OperandName}.Value";
        var operandPath = originalOperandPath;

        var testArguments = new List<ImmediateTestArgument>();
        switch (descriptor.LabelKind)
        {
            case Arm64LabelEncodingKind.ByteOffset:
                testArguments.Add(new(11));
                break;
            case Arm64LabelEncodingKind.OffsetMul4:
                operandPath = $"({originalOperandPath} >> 2)";
                testArguments.Add(new(32));
                break;
            case Arm64LabelEncodingKind.NegativeEncodedAsUnsigned:
                operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
                {
                    w.WriteLine($"if ({originalOperandPath} > 0) throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), \"The label offset must be negative.\");");
                });
                operandPath = $"(-{originalOperandPath} >> 2)";
                testArguments.Add(new((int)-32));
                break;
            case Arm64LabelEncodingKind.PageOffset:
                operandPath = $"({originalOperandPath} >> 12)";
                testArguments.Add(new((int)(3 << 12)));
                break;
            default:
                Debug.Assert(false, $"Invalid label kind {descriptor.LabelKind}");
                break;
        }

        operandVariation.TestArguments.AddRange(testArguments);
        GenerateBitRangeEncodingFromValue(operandPath, "label", descriptor.BitSize, descriptor.Encoding, operandVariation.WriteEncodings);
        operandVariations.Add(operandVariation);
    }
    
    private void GetMemoryOperandVariation(int operandIndex, Instruction instruction, MemoryOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var operandTypePair = GetMemoryOperandType((MemoryOperandDescriptor)descriptor);

        var operandVariation = new OperandVariation()
        {
            Descriptor = descriptor,
            OperandName = GetNormalizedOperandName(descriptor.Name),
            OperandType = descriptor.IsPreIncrement ? $"{operandTypePair.Default}.PreIncrement" : operandTypePair.Default,
        };

        operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
        {
            w.WriteLine($"{variable} |= (uint){operand.OperandName}.BaseRegister.Index << {descriptor.BaseRegister.LowBit};");
        });

        // We have a register with an immediate or with a register + extend/LSL
        var bitSize = descriptor.IndexRegisterOrImmediate.Select(x => x.Width).Sum();

        var testArguments = new List<MemoryTestArgument>();

        bool hasLslOrExtend = false;
        switch (descriptor.MemoryEncodingKind)
        {
            case Arm64MemoryEncodingKind.BaseRegisterAndImmediate:
            case Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional:

                string operandValue = $"{operandVariation.OperandName}.Immediate";
                if (descriptor.ImmediateValueEncodingKind != Arm64ImmediateValueEncodingKind.None)
                {
                    operandValue = GenerateImmediateValueEncoding(descriptor.ImmediateValueEncodingKind, operandValue);
                }

                testArguments.Add(new(new RegisterTestArgument("X", 1 + operandIndex), BuildTestImmediateValue(descriptor.ImmediateValueEncodingKind, 5))
                {
                    PreIncrement = descriptor.IsPreIncrement
                });

                GenerateBitRangeEncodingFromValue(operandValue, "immediate", bitSize, descriptor.IndexRegisterOrImmediate, operandVariation.WriteEncodings);
                break;
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional:
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount:
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend:
                GenerateBitRangeEncodingFromValue($"{operandVariation.OperandName}.IndexRegister.Index", "index register", bitSize, descriptor.IndexRegisterOrImmediate, operandVariation.WriteEncodings, bitSize == 5 ? bitSize : 0);
                hasLslOrExtend = true;

                var extendValue = GetExtendValue(descriptor.ExtendKind);
                testArguments.Add(new(new RegisterTestArgument("X", 1 + operandIndex), new RegisterTestArgument("X", 2 + operandIndex), "LSL", extendValue)
                {
                    PreIncrement = descriptor.IsPreIncrement
                });
                break;
            case Arm64MemoryEncodingKind.BaseRegisterXn:
            case Arm64MemoryEncodingKind.BaseRegister:
                // Nothing to do for these
                testArguments.Add(new(new RegisterTestArgument("X", 1 + operandIndex))
                {
                    PreIncrement = descriptor.IsPreIncrement
                });
                break;
            case Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate:
            case Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional:
                // If the optional immediate value is 0, let's just use a Arm64BaseMemoryAccessor instead of having an immediate
                if (descriptor.FixedValue == 0)
                {
                    operandVariation.OperandType = descriptor.IsPreIncrement ? "Arm64BaseMemoryAccessor.PreIncrement" : "Arm64BaseMemoryAccessor";
                    testArguments.Add(new(new RegisterTestArgument("X", 1 + operandIndex))
                    {
                        PreIncrement = descriptor.IsPreIncrement
                    });
                }
                else
                {
                    testArguments.Add(new(new RegisterTestArgument("X", 1 + operandIndex), descriptor.FixedValue)
                    {
                        PreIncrement = descriptor.IsPreIncrement
                    });
                    operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
                    {
                        w.WriteLine($"if ({operand.OperandName}.Immediate != {descriptor.FixedValue}) throw new {nameof(ArgumentOutOfRangeException)}(nameof({operand.OperandName}), $\"Invalid immediate value '{{{operand.OperandName}.Immediate}}'. Expecting the fixed value `{descriptor.FixedValue}`\");");
                    });
                }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        operandVariation.TestArguments.AddRange(testArguments);
        operandVariations.Add(operandVariation);

        if (operandTypePair.IndexRegisterW is not null)
        {
            // var option = (rawValue >> 13) & 0b111;
            // (option & 1) == 0 -> W else X
            // operandVariation is X
            operandVariation.BitfieldMask |= 1 << 13;
            operandVariation.BitfieldSets |= 1 << 13;

            // Create a fake encoding symbol selector to generate the W/X operand variation
            var encodingExtract = new EncodingSymbolExtract();
            encodingExtract.BitRanges.Add(new BitRange(13, 1));
            var selector = new EncodingSymbolSelector
            {
                BitEncodingMask = 1 << 13,
                BitSize = 1
            };
            var bitValueW = new EncodingBitValue()
            {
                Text = "W",
                BitSelectorMask = 1 << 13,
                BitSelectorValue = 0,
            };
            var bitValueX = new EncodingBitValue()
            {
                Text = "X",
                BitSelectorMask = 1 << 13,
                BitSelectorValue = 1 << 13,
            };
            selector.BitValues.Add(bitValueW);
            selector.BitValues.Add(bitValueX);

            encodingExtract.Selector = selector;
            
            operandVariation.EncodingExtract = encodingExtract;
            operandVariation.AcceptedBitValues.Add(bitValueX);

            // operandVariation2 is W
            var operandVariation2 = new OperandVariation()
            {
                Descriptor = descriptor,
                OperandName = operandVariation.OperandName,
                OperandType = descriptor.IsPreIncrement ? $"{operandTypePair.IndexRegisterW}.PreIncrement" : operandTypePair.IndexRegisterW,
                BitfieldMask = 1 << 13,
                EncodingExtract = encodingExtract,
            };
            operandVariation2.AcceptedBitValues.Add(bitValueW);

            operandVariation2.WriteEncodings.AddRange(operandVariation.WriteEncodings);
            operandVariations.Add(operandVariation2);

            operandVariation2.TestArguments.Add(new MemoryTestArgument(new RegisterTestArgument("X", 1 + operandIndex), new RegisterTestArgument("W", 2 + operandIndex), "UXTW", GetExtendValue(descriptor.ExtendKind))
            {
                PreIncrement = descriptor.IsPreIncrement
            });

            if (hasLslOrExtend)
            {
                AddExtendEncoding(operandVariation, true);
                AddExtendEncoding(operandVariation2, false);
            }
        }
        else if (hasLslOrExtend)
        {
            AddExtendEncoding(operandVariation, true);
        }


        void AddExtendEncoding(OperandVariation operandVariation, bool isX)
        {
            operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
            {
                //Debug.Assert(extendBitRange.HiBit == 15 && extendBitRange.Width == 3);
                //Debug.Assert(amountBitRange.HiBit == 12 && amountBitRange.Width == 1);
                
                if (isX)
                {
                    w.WriteLine($"switch({operand.OperandName}.Extend.Kind)");
                    w.OpenBraceBlock();
                    {
                        if (descriptor.MemoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional)
                        {
                            w.WriteLine($"case Arm64ExtendKind.None:");
                            w.Indent();
                            {
                                w.WriteLine($"{variable} |= 0x{(0b011U << 13):X8}U;");
                                w.WriteLine($"if ({operand.OperandName}.Extend.HasExplicitZeroAmount || {operand.OperandName}.Extend.Amount != 0)");
                                w.OpenBraceBlock();
                                {
                                    w.WriteLine($"throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Unsupported extend `{{{operand.OperandName}.Extend}}`. A default extend must have a zero amount not explicit set.\");");
                                }
                                w.CloseBraceBlock();
                                w.WriteLine("break;");
                            }
                            w.UnIndent();
                        }
                        w.WriteLine($"case Arm64ExtendKind.LSL:");
                        w.Indent();
                        {
                            w.WriteLine($"{variable} |= 0x{(0b011U << 13):X8}U;");
                            w.WriteLine($"if (!{operand.OperandName}.Extend.HasExplicitZeroAmount && {operand.OperandName}.Extend.Amount == 0)");
                            w.OpenBraceBlock();
                            {
                                w.WriteLine($"throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Unsupported extend `{{{operand.OperandName}.Extend}}`. A LSL extend is expecting an explicit amount.\");");
                            }
                            w.CloseBraceBlock();
                            w.WriteLine("break;");
                        }
                        w.UnIndent();
                        w.WriteLine($"case Arm64ExtendKind.SXTX:");
                        w.Indent();
                        {
                            w.WriteLine($"{variable} |= 0x{(0b111U << 13):X8}U;");
                            w.WriteLine("break;");
                        }
                        w.UnIndent();
                        w.WriteLine($"default:");
                        w.Indent();
                        {
                            w.WriteLine($"throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Unsupported extend `{{{operand.OperandName}.Extend.Kind}}`. Only LSL or SXTX are valid for this memory operand.\");");
                        }
                        w.UnIndent();
                    }
                    w.CloseBraceBlock();
                }
                else
                {
                    w.WriteLine($"{variable} |= {operand.OperandName}.Extend.Kind switch");
                    w.OpenBraceBlock();
                    {
                        w.WriteLine($"Arm64ExtendKind.UXTW => 0x{(0b010U << 13):X8}U,");
                        w.WriteLine($"Arm64ExtendKind.SXTW => 0x{(0b110U << 13):X8}U,");
                        w.WriteLine($"_ => throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Unsupported extend `{{{operand.OperandName}.Extend.Kind}}`. Only UXTW or SXTW are valid for this memory operand.\"),");
                    }
                    w.CloseBraceBlockStatement();
                }

                if (descriptor.ExtendKind == Arm64MemoryExtendEncodingKind.Shift0)
                {
                    w.WriteLine($"if ({operand.OperandName}.Extend.HasExplicitZeroAmount)");
                    w.OpenBraceBlock();
                    {
                        w.WriteLine($"{variable} |= 0x{(1 << 12):X8}U;");
                    }
                    w.CloseBraceBlock();
                }
                else
                {
                    w.WriteLine($"{variable} |= {operand.OperandName}.Extend.Amount switch");
                    w.OpenBraceBlock();

                    Debug.Assert(descriptor.ExtendKind != Arm64MemoryExtendEncodingKind.None);
                    string expectedNonZeroValue = descriptor.ExtendKind switch
                    {
                        Arm64MemoryExtendEncodingKind.Shift1 => "1",
                        Arm64MemoryExtendEncodingKind.Shift2 => "2",
                        Arm64MemoryExtendEncodingKind.Shift3 => "3",
                        Arm64MemoryExtendEncodingKind.Shift4 => "4",
                        _ => throw new ArgumentOutOfRangeException(),
                    };
                    w.WriteLine($"0 => 0U,");
                    w.WriteLine($"{expectedNonZeroValue} => 0x{(1 << 12):X8}U,");
                    w.WriteLine($"_ => throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Unsupported extend amount `{{{operand.OperandName}.Extend.Amount}}`. Only 0 or {expectedNonZeroValue} are valid for this memory operand.\"),");
                    w.CloseBraceBlockStatement();
                }
            });
        }
    }

    private static int GetExtendValue(Arm64MemoryExtendEncodingKind extendKind)
    {
        var extendValue = extendKind switch
        {
            Arm64MemoryExtendEncodingKind.Shift0 => 0,
            Arm64MemoryExtendEncodingKind.Shift1 => 1,
            Arm64MemoryExtendEncodingKind.Shift2 => 2,
            Arm64MemoryExtendEncodingKind.Shift3 => 3,
            Arm64MemoryExtendEncodingKind.Shift4 => 4,
            _ => throw new ArgumentOutOfRangeException()
        };
        return extendValue;
    }
    
    private string GenerateImmediateValueEncoding(Arm64ImmediateValueEncodingKind kind, string operandPath)
    {
        string operandValue = operandPath;
        switch (kind)
        {
            case Arm64ImmediateValueEncodingKind.ValueMulBy2:
                operandValue = $"({operandPath} >> 1)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueMulBy4:
                operandValue = $"({operandPath} >> 2)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueMulBy8:
                operandValue = $"({operandPath} >> 3)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueMulBy16:
                operandValue = $"({operandPath} >> 4)";
                break;
            case Arm64ImmediateValueEncodingKind._32_Minus_Value_Mod32:
                operandValue = $"((32 - {operandPath}) & 0x1F)";
                break;
            case Arm64ImmediateValueEncodingKind._64_Minus_Value_Mod64:
                operandValue = $"((64 - {operandPath}) & 0x3F)";
                break;
            case Arm64ImmediateValueEncodingKind._32_Minus_Value:
                operandValue = $"(32 - {operandPath})";
                break;
            case Arm64ImmediateValueEncodingKind._64_Minus_Value:
                operandValue = $"(64 - {operandPath})";
                break;
            case Arm64ImmediateValueEncodingKind._128_Minus_Value:
                operandValue = $"(128 - {operandPath})";
                break;
            case Arm64ImmediateValueEncodingKind.Value_Minus_64:
                operandValue = $"({operandPath} - 64)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueMod64Plus1:
                operandValue = $"(({operandPath} - 1) & 0x3F)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueImmsMinusImmrPlus1:
                // encoded in imms:immr (reversed from the order in the instruction)
                //return ((value >> 6) & 0b111_1111) - (value & 0b111_111) + 1;
                operandValue = $"(lsb + width - 1)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueImmsPlus1:
                // encoded in imms:immr (reversed from the order in the instruction)
                //return ((value >> 6) & 0b111_1111) + 1;
                operandValue = $"(width - 1)";
                break;
            case Arm64ImmediateValueEncodingKind.ValueMsrImmediate:
                // This is handled at encoding time
                break;
            case Arm64ImmediateValueEncodingKind.InvertValueShiftWide32:
            case Arm64ImmediateValueEncodingKind.ValueShiftWide64:
            case Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4:
            case Arm64ImmediateValueEncodingKind.DecodeBitMask32:
            case Arm64ImmediateValueEncodingKind.DecodeBitMask64:
            case Arm64ImmediateValueEncodingKind.ValueImm64:
                operandValue = $"{operandPath}.EncodedValue";
                break;
            case Arm64ImmediateValueEncodingKind.None:
                // Nothing to do
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(kind), kind, null);
        }

        return operandValue;
    }

    private static int BuildTestImmediateValue(Arm64ImmediateValueEncodingKind valueEncodingKind, int value)
    {
        switch (valueEncodingKind)
        {
            case Arm64ImmediateValueEncodingKind.ValueMulBy2:
                return value * 2;
            case Arm64ImmediateValueEncodingKind.ValueMulBy4:
                return value * 4;
            case Arm64ImmediateValueEncodingKind.ValueMulBy8:
                return value * 8;
            case Arm64ImmediateValueEncodingKind.ValueMulBy16:
                return value * 16;
            //case Arm64ImmediateValueEncodingKind.ValueImmsMinusImmrPlus1:
            //    // encoded in imms:immr (reversed from the order in the instruction)
            //    return ((value >> 6) & 0b111_1111) - (value & 0b111_111) + 1;
            //case Arm64ImmediateValueEncodingKind.ValueImmsPlus1:
            //    // encoded in imms:immr (reversed from the order in the instruction)
            //    return ((value >> 6) & 0b111_1111) + 1;
            //case Arm64ImmediateValueEncodingKind._32_Minus_Value_Mod32:
            //    return ((32 - value) & 0x1F);
            //case Arm64ImmediateValueEncodingKind._64_Minus_Value_Mod64:
            //    return ((64 - value) & 0x3F);
            //case Arm64ImmediateValueEncodingKind._32_Minus_Value:
            //    return 32 - value;
            //case Arm64ImmediateValueEncodingKind._64_Minus_Value:
            //    return 64 - value;
            //case Arm64ImmediateValueEncodingKind.Value_Minus_64:
            //    return value - 64;
            //case Arm64ImmediateValueEncodingKind._128_Minus_Value:
            //    return 128 - value;
            //case Arm64ImmediateValueEncodingKind.ValueMod64Plus1:
            //    return (value & 0x3F) + 1;
            //case Arm64ImmediateValueEncodingKind.InvertValueShiftWide32:
            //    return ~(uint)((int)value >> 2) << ((value & 0x3) << 4);
            //case Arm64ImmediateValueEncodingKind.ValueShiftWide64:
            //    return ((long)value >> 2) << ((value & 0x3) << 4);
            default:
                return value;
        }
    }

    private void GetEnumVariations(EnumOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        string enumType;
        string? fixedValue = null;
        var rawArguments = new List<RawTestArgument>();
        switch (descriptor.EnumKind)
        {
            case Arm64EnumKind.Conditional:
            case Arm64EnumKind.InvertedConditional:
                enumType = "Arm64ConditionalKind";
                rawArguments.Add(new("NE", "NE"));
                rawArguments.Add(new("AL", "AL"));
                break;
            case Arm64EnumKind.BranchTargetIdentification:
                enumType = "Arm64BranchTargetIdentificationKind";
                rawArguments.Add(new("C", "C"));
                rawArguments.Add(new("J", "J"));
                break;
            case Arm64EnumKind.DataSynchronizationOption:
                enumType = "Arm64DataSynchronizationKind";
                rawArguments.Add(new("OSH", "OSH"));
                break;
            case Arm64EnumKind.StoredSharedHintPolicy:
                enumType = "Arm64StoredSharedHintPolicyKind";
                rawArguments.Add(new("STRM", "STRM"));
                break;
            case Arm64EnumKind.ProcessStateField:
                enumType = "Arm64ProcessStateField";
                rawArguments.Add(new("DAIFSet", "DAIFSet"));
                break;
            case Arm64EnumKind.BarrierOperationLimit:
                enumType = "Arm64BarrierOperationLimitKind";
                rawArguments.Add(new("OSHLD", "OSHLD"));
                break;
            case Arm64EnumKind.PrefetchOperation:
                enumType = "Arm64PrefetchOperationKind";
                rawArguments.Add(new("PLDL1KEEP", "PLDL1KEEP"));
                break;
            case Arm64EnumKind.RangePrefetchOperation:
                enumType = "Arm64RangePrefetchOperationKind";
                rawArguments.Add(new("PLDSTRM", "PLDSTRM"));
                break;
            case Arm64EnumKind.DataSync:
                enumType = "Arm64DataSyncKind";
                fixedValue = "Arm64DataSyncKind.DSYNC";
                rawArguments.Add(new("DSYNC", "DSYNC"));
                break;
            case Arm64EnumKind.CodeSync:
                enumType = "Arm64CodeSyncKind";
                fixedValue = "Arm64CodeSyncKind.CSYNC";
                rawArguments.Add(new("CSYNC", "CSYNC"));
                break;
            case Arm64EnumKind.RestrictionByContext:
                enumType = "Arm64RestrictionByContextKind";
                fixedValue = "Arm64RestrictionByContextKind.RCTX";
                rawArguments.Add(new("RCTX", "RCTX"));
                break;
            default:
                throw new ArgumentOutOfRangeException($"Invalid enum kind  {descriptor.EnumKind}");
        }

        var name = GetNormalizedOperandName(descriptor.Name);

        // We don't create variation as it would conflict with other variations.
        // Instead, user will have to cast to enum in order to pass a value
        var operandVariation = new OperandVariation()
        {
            Descriptor = descriptor,
            OperandName = name,
            OperandType = enumType,
        };
        operandVariation.TestArguments.AddRange(rawArguments);

        if (descriptor.EnumKind == Arm64EnumKind.RangePrefetchOperation)
        {
            // (12:4),(0:5)
            // option: 13-15
            // S: 12
            // Rt: 0-4
            // imm6 option<2>:option<0>:S:Rt<2:0>
            var bitRanges = new List<BitRange>
            {
                new(15, 1),
                new(12, 2),
                new(0, 3),
            };

            GenerateBitRangeEncodingFromValue($"(byte){operandVariation.OperandName}", "immediate", 6, bitRanges, operandVariation.WriteEncodings);
        }
        else if (descriptor.EnumKind == Arm64EnumKind.ProcessStateField)
        {
            // ExtractBitRange
            var extract = descriptor.BitMapExtract;
            Debug.Assert(extract is not null);

            var selector = extract.Selector;
            Debug.Assert(selector is not null);
            var bitValues = selector.BitValues;

            var localEncodings = new List<WriteEncodingDelegate>();
            GenerateBitRangeEncodingFromValue($"(uint){operandVariation.OperandName}", "ProcessStateField", selector.BitSize, selector.BitRanges, localEncodings);

            operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
            {
                w.WriteLine($"switch ({operandVariation.OperandName})");
                w.OpenBraceBlock();
                {
                    foreach (var bitValue in bitValues)
                    {
                        w.WriteLine($"case Arm64ProcessStateField.{bitValue.Text}:");
                        w.Indent();
                        w.WriteLine($"{variable} |= 0x{bitValue.BitSelectorValue:X}U;");
                        w.WriteLine("break;");
                        w.UnIndent();
                    }
                    w.WriteLine("default:");
                    localEncodings[0](w, variable, variation, operand, index);
                    w.WriteLine("break;");
                }
                w.CloseBraceBlockStatement();
            });
        }
        else
        {
            operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
            {
                if (fixedValue is not null)
                {
                    w.WriteLine($"if ({operand.OperandName} != {fixedValue}) throw new {nameof(ArgumentOutOfRangeException)}(nameof({operand.OperandName}), $\"Invalid enum value '{{{operand.OperandName}}}'. Expecting the fixed value `{fixedValue}`\");");
                }
                else
                {
                    var operandPath = operand.OperandName;

                    if (descriptor.EnumKind == Arm64EnumKind.InvertedConditional)
                    {
                        operandPath = $"{operandPath}.Invert()";
                    }

                    Debug.Assert(descriptor.BitSize != 0);
                    w.WriteLine($"{variable} |= (uint)((byte){operandPath} & (byte)0x{(1 << descriptor.BitSize) - 1:X}) << {descriptor.EnumEncoding.LowBit};");
                }
            });
        }
        
        operandVariations.Add(operandVariation);
    }

    private void GetImmediateVariation(Instruction instruction, ImmediateOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        bool hasFixedValue = descriptor.HasFixedValue;
        string? fixedValue = hasFixedValue  ? $"{descriptor.FixedValue}" : null;
        List<ImmediateTestArgument> testArguments = new();
        var name = GetNormalizedOperandName(descriptor.Name);
        if (descriptor.Name == "0.0")
        {
            name = "zero";
            fixedValue = "0.0f";
            hasFixedValue = true;
            testArguments.Add(new(0.0f));
        }
        else if (!descriptor.Name.Contains('.') && char.IsAsciiDigit(descriptor.Name[0]))
        {
            name = $"value{descriptor.Name}";
            hasFixedValue = true;
            fixedValue = $"{sbyte.Parse(descriptor.Name)}";
            testArguments.Add(new(sbyte.Parse(descriptor.Name)));
        }

        var operandTypeBitSize = 0;

        string? operandType = descriptor.IsSigned ? "int" : "uint";

        // If there is no value encoding, we can use a more precise type
        if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.None)
        {
            switch (descriptor.BitSize)
            {
                case <= 8:
                    operandType = descriptor.IsSigned ? "sbyte" : "byte";
                    if (descriptor.BitSize == 8)
                    {
                        operandTypeBitSize = 8;
                    }
                    break;
                case <= 16:
                    operandType = descriptor.IsSigned ? "short" : "ushort";
                    if (descriptor.BitSize == 16)
                    {
                        operandTypeBitSize = 16;
                    }
                    break;
            }
        }

        if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.ValueImm64)
        {
            operandType = "Arm64BitMaskImmediate64";
            operandTypeBitSize = 8;
            testArguments.Add(new(0xFF00FFL));
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask32)
        {
            operandType = "Arm64LogicalImmediate32";
            operandTypeBitSize = 13; // We specify that the exact size is 13 bits and we don't need to mask it as it is already done by the type
            testArguments.Add(new(0x03030303, true));
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask64)
        {
            operandType = "Arm64LogicalImmediate64";
            testArguments.Add(new(0x03030303_03030303UL));
            operandTypeBitSize = 13; // idem as above
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4)
        {
            operandType = "Arm64FloatImmediate";
            operandTypeBitSize = 8;
            testArguments.Add(new(0.5f));
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.ValueShiftWide64)
        {
            operandType = "Arm64ShiftedImmediate64";
            testArguments.Add(new(0x1234, 16, false));
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.InvertValueShiftWide32)
        {
            operandType = "Arm64InvertedShiftedImmediate32";
            testArguments.Add(new(0x1234, 16, true));
        }

        if (descriptor.ImmediateKind == Arm64ImmediateEncodingKind.FixedFloatZero)
        {
            operandType = "float";
            operandTypeBitSize = 0;
        }

        var operandVariation = new OperandVariation
        {
            Descriptor = descriptor,
            OperandName = name,
            OperandType = operandType,
        };
        
        if (descriptor.IsOptional)
        {
            operandVariation.DefaultValue = "default";
        }

        if (hasFixedValue)
        {
            operandVariation.DefaultValue = $"{fixedValue}";
        }

        var operandPath = GenerateImmediateValueEncoding(descriptor.ValueEncodingKind, operandVariation.OperandName);

        var bitSize = descriptor.BitSize;
        var bitRanges = new List<BitRange>();
        bitRanges.AddRange(descriptor.Encoding);
        if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.ValueImmsMinusImmrPlus1 || descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.ValueImmsPlus1)
        {
            Debug.Assert(descriptor.ImmediateKind == Arm64ImmediateEncodingKind.Regular);
            Debug.Assert(bitRanges.Count == 2);
            bitRanges.RemoveAt(1);
            bitSize = bitRanges[0].Width;
            operandVariation.OperandType = "byte";
            operandTypeBitSize = 8;
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.ValueMsrImmediate)
        {
            operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
            {
                // switch (processStateField)
                // {
                //     case Arm64ProcessStateField.ALLINT:
                //     case Arm64ProcessStateField.PM:
                //     case Arm64ProcessStateField.SVCRSM:
                //     case Arm64ProcessStateField.SVCRSMZA:
                //     case Arm64ProcessStateField.SVCRZA:
                //         return value & 1;
                // }

                w.WriteLine($"switch (pstatefield)");
                w.OpenBraceBlock();

                w.WriteLine("case Arm64ProcessStateField.ALLINT:");
                w.WriteLine("case Arm64ProcessStateField.PM:");
                w.WriteLine("case Arm64ProcessStateField.SVCRSM:");
                w.WriteLine("case Arm64ProcessStateField.SVCRSMZA:");
                w.WriteLine("case Arm64ProcessStateField.SVCRZA:");
                w.Indent();
                w.WriteLine($"{operandVariation.OperandName} = {operandVariation.OperandName} & 1;");
                w.WriteLine("break;");
                w.UnIndent();
                w.CloseBraceBlock();
            });
        }

        switch (descriptor.ImmediateKind)
        {
            case Arm64ImmediateEncodingKind.Regular:
            case Arm64ImmediateEncodingKind.IsbOption:
                GenerateBitRangeEncodingFromValue(operandPath, "immediate", bitSize, bitRanges, operandVariation.WriteEncodings, operandTypeBitSize);
                break;
            case Arm64ImmediateEncodingKind.BitMapExtract:
                var selector = descriptor.Extract!.Selector;
                if (selector is not null)
                {
                    if (selector.BitValues.Any(x => x.Kind == EncodingBitValueKind.BitExtract))
                    {
                        foreach (var bitValue in selector.BitValues)
                        {
                            var newOperandVariation = new OperandVariation()
                            {
                                Descriptor = descriptor,
                                EncodingExtract = descriptor.Extract,
                                OperandName = operandVariation.OperandName,
                                OperandType = operandType,
                                BitfieldMask = bitValue.BitSelectorMask,
                                BitfieldSets = bitValue.BitSelectorValue,
                            };
                            newOperandVariation.AcceptedBitValues.Add(bitValue);

                            AddDefaultTestArguments(newOperandVariation);
                            newOperandVariation.TestArguments.AddRange(testArguments);
                            
                            if (selector.BitRanges.Count == 1)
                            {
                                var bitIndex = BitOperations.TrailingZeroCount(bitValue.Addend);
                                var size = bitIndex;
                                if (bitValue.HasNegativeExtract)
                                {
                                    // Special encoding, for example:
                                    // 16 - UInt(immh:immb)
                                    // 32 - UInt(immh:immb)
                                    // 64 - UInt(immh:immb)
                                    // 128 - UInt(immh:immb)
                                    operandPath = $"({(1 << size)} - ({operandVariation.OperandName} & 0x{(1 << size) - 1:X}))";
                                }
                                else
                                {
                                    // UInt(immh:immb) - 8
                                    // UInt(immh:immb) - 16
                                    // UInt(immh:immb) - 32
                                    // UInt(immh:immb) - 64
                                    operandPath = $"({operandVariation.OperandName} & 0x{(1 << size) - 1:X})";
                                }
                                GenerateBitRangeEncodingFromValue($"{operandPath}", operandVariation.OperandName, new BitRange(16, size), newOperandVariation.WriteEncodings, size);
                            }
                            else
                            {
                                GenerateEncodingForExtract(instruction, descriptor.Extract, newOperandVariation, null, "immediate");
                            }

                            operandVariations.Add(newOperandVariation);
                        }
                        return;
                    }
                    else
                    {
                        Debug.Assert(selector.BitValues.All(x => x.Kind == EncodingBitValueKind.Integer));
                        var valuesPairs = selector.BitValues.Select(x => (Value: x.IntegerValue, BitMask: x.BitSelectorMask, BitSets: x.BitSelectorValue)).ToArray();
                        var maxAbsValue = valuesPairs.Select(x => Math.Abs(x.Value)).Max();
                        if (descriptor.IsSigned)
                        {
                            // It should be ok even for negative numbers, it is not a big deal to over estimate the type
                            if (maxAbsValue > short.MaxValue) operandType = "int";
                            else if (maxAbsValue > sbyte.MaxValue) operandType = "short";
                            else operandType = "sbyte";
                        }
                        else
                        {
                            if (maxAbsValue > ushort.MaxValue) operandType = "int";
                            else if (maxAbsValue > byte.MaxValue) operandType = "ushort";
                            else operandType = "byte";
                        }

                        operandVariation.OperandType = operandType;
                        GenerateSwitchCaseFromValue(operandVariation.OperandName, valuesPairs.ToList(), operandVariation);
                    }
                }
                else
                {
                    GenerateEncodingForExtract(instruction, descriptor.Extract, operandVariation, null, "immediate");
                }
                break;
            case Arm64ImmediateEncodingKind.FixedInt:
                Debug.Assert(hasFixedValue);
                operandVariation.DefaultValue = $"{fixedValue}";
                operandVariation.WriteEncodings.Add((w, raw, instructionVariation, operand, operandIndex) =>
                {
                    w.WriteLine($"if ({operandVariation.OperandName} != {fixedValue}) throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Invalid Immediate. Expecting the fixed value {fixedValue} instead of {{{operandVariation.OperandName}}}\");");
                });
                break;
            case Arm64ImmediateEncodingKind.FixedFloatZero:
                operandVariation.DefaultValue = "0.0f";
                operandVariation.WriteEncodings.Add((w, raw, instructionVariation, operand, operandIndex) =>
                {
                    w.WriteLine($"if ({operandVariation.OperandName} != 0.0f) throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), $\"Invalid Immediate. Expecting 0.0f instead of {{{operandVariation.OperandName}}}\");");
                });
                break;
            default:
                throw new ArgumentOutOfRangeException($"The ImmediateKind {descriptor.ImmediateKind} is not supported");
        }

        AddDefaultTestArguments(operandVariation);
        operandVariation.TestArguments.AddRange(testArguments);
        operandVariations.Add(operandVariation);


        void AddDefaultTestArguments(OperandVariation localOperandVariation)
        {
            if (testArguments.Count == 0)
            {
                // TEMP instructions not handle correctly
                if (descriptor.ValueEncodingKind != Arm64ImmediateValueEncodingKind.ValueImmsMinusImmrPlus1 && descriptor.ValueEncodingKind != Arm64ImmediateValueEncodingKind.ValueImmsPlus1)
                {
                    if (localOperandVariation.OperandName == "rotate")
                    {
                        testArguments.Add(new(90));
                    }
                    else
                    {
                        var valueToTest = BuildTestImmediateValue(descriptor.ValueEncodingKind, 5);
                        testArguments.Add(new((int)valueToTest));
                    }
                }
            }
        }
    }

    private void GetShiftOperandVariations(Instruction instruction, ShiftOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        bool requiresShiftEncoding = false;
        bool requiresAmountEncoding = false;

        var testArguments = new List<ShiftTestArgument>();

        string? operandType;
        switch (descriptor.ShiftKind)
        {
            case Arm64ShiftEncodingKind.Shift3:
                operandType = "Arm64ShiftKind3";
                requiresShiftEncoding = true;
                requiresAmountEncoding = true;
                testArguments.Add(new("LSL", 0, descriptor.IsOptional));
                testArguments.Add(new("LSL", 1, descriptor.IsOptional));
                testArguments.Add(new("LSR", 10, descriptor.IsOptional));
                testArguments.Add(new("ASR", 12, descriptor.IsOptional));
                break;
            case Arm64ShiftEncodingKind.Shift4:
                operandType = "Arm64ShiftKind4";
                requiresShiftEncoding = true;
                requiresAmountEncoding = true;
                testArguments.Add(new("LSL", 0, descriptor.IsOptional));
                testArguments.Add(new("LSL", 1, descriptor.IsOptional));
                testArguments.Add(new("LSR", 10, descriptor.IsOptional));
                testArguments.Add(new("ASR", 12, descriptor.IsOptional));
                testArguments.Add(new("ROR", 7, descriptor.IsOptional));
                break;
            case Arm64ShiftEncodingKind.Lsl0Or12:
                operandType = "LSLShiftKind";
                requiresAmountEncoding = true;
                testArguments.Add(new("LSL", 0, descriptor.IsOptional));
                testArguments.Add(new("LSL", 12, descriptor.IsOptional));
                break;
            case Arm64ShiftEncodingKind.Lsl0:
            case Arm64ShiftEncodingKind.Lsl:
                operandType = "LSLShiftKind";
                testArguments.Add(new("LSL", 0, descriptor.IsOptional));
                break;
            case Arm64ShiftEncodingKind.LslScale8:
                operandType = "LSLShiftKind";
                requiresAmountEncoding = true;
                testArguments.Add(new("LSL", 8, descriptor.IsOptional));
                break;
            case Arm64ShiftEncodingKind.Msl:
                operandType = "MSLShiftKind";
                requiresAmountEncoding = true;
                testArguments.Add(new("MSL", 16, descriptor.IsOptional));
                break;
            case Arm64ShiftEncodingKind.LslScale16:
                operandType = "LSLShiftKind";
                testArguments.Add(new("LSL", 16, descriptor.IsOptional));
                requiresAmountEncoding = true;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        var operandVariation = new OperandVariation
        {
            Descriptor = descriptor,
            OperandName = GetNormalizedOperandName(descriptor.Name),
            OperandType = operandType,
            OperandName2 = "amount",
            OperandType2 = "int"
        };

        operandVariation.TestArguments.AddRange(testArguments);

        if (descriptor.IsOptional)
        {
            operandVariation.DefaultValue = "default";
            operandVariation.DefaultValue2 = "0";
        }

        var amountOperandPath = operandVariation.OperandName2;

        if (requiresShiftEncoding)
        {
            Debug.Assert(descriptor.ShiftEncoding.Width != 0);
            GenerateBitRangeEncodingFromValue($"(byte){operandVariation.OperandName}.ShiftKind", "shift", descriptor.ShiftEncoding, operandVariation.WriteEncodings);
        }

        if (requiresAmountEncoding)
        {
            Debug.Assert(descriptor.AmountEncoding.Width != 0);
            switch (descriptor.ShiftKind)
            {
                case Arm64ShiftEncodingKind.Lsl0Or12:
                    amountOperandPath = $"({amountOperandPath} == 0 ? 0 : {amountOperandPath} == 12 ? 1 : throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName2}), $\"Invalid amount value '{{{operandVariation.OperandName2}}}'. Expecting 0 or 12\"))";
                    break;
                case Arm64ShiftEncodingKind.LslScale8:
                    amountOperandPath = $"({amountOperandPath} >> 3)";
                    break;
                case Arm64ShiftEncodingKind.Msl:
                    amountOperandPath = $"(({amountOperandPath} >> 3) - 1)";
                    break;
                case Arm64ShiftEncodingKind.LslScale16:
                    amountOperandPath = $"({amountOperandPath} >> 4)";
                    break;
            }
            GenerateBitRangeEncodingFromValue(amountOperandPath, "amount", descriptor.AmountEncoding, operandVariation.WriteEncodings);
        }
        else
        {
            if (descriptor.ShiftKind == Arm64ShiftEncodingKind.Lsl0)
            {
                operandVariation.WriteEncodings.Add((w, variable, variation, operand, index) =>
                {
                    w.WriteLine($"if ({operand.OperandName2} != 0) throw new {nameof(ArgumentOutOfRangeException)}(nameof({operand.OperandName2}), $\"Invalid amount value '{{{operand.OperandName2}}}'. Expecting 0\");");
                });
            }
        }

        operandVariations.Add(operandVariation);
    }

    private static void GetExtendOperandVariations(Instruction instruction, ExtendOperandDescriptor descriptor, List<OperandVariation> variations)
    {
        var dynamicRegisterXOrW = instruction.Operands.Where(x => x.Descriptor is RegisterOperandDescriptor registerDescriptor && registerDescriptor.DynamicRegisterXOrWSelector != null).Select(x => x.Descriptor).FirstOrDefault();

        if (dynamicRegisterXOrW is null)
        {
            var operandVariation = new OperandVariation
            {
                Descriptor = descriptor,
                OperandName = GetNormalizedOperandName(descriptor.Name),
                OperandType = "Arm64ExtendKind",
                OperandName2 = "amount",
                OperandType2 = "int"
            };

            if (descriptor.IsOptional)
            {
                operandVariation.DefaultValue = "Arm64ExtendKind.LSL";
                operandVariation.DefaultValue2 = "0";
            }

            operandVariation.WriteEncodings.Add((w, variable, instruction, operand, index) =>
            {
                w.WriteLine($"var _extend_ = {operandVariation.OperandName} switch");
                w.OpenBraceBlock();
                w.WriteLine($"Arm64ExtendKind.None => throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariation.OperandName}), \"Invalid extend value `None`. Expecting a valid extend kind\"),");
                w.WriteLine($"Arm64ExtendKind.LSL => (byte){(descriptor.Is64Bit ? "Arm64ExtendKind.UXTX" : "Arm64ExtendKind.UXTW")},");
                w.WriteLine($"_ => (byte){operandVariation.OperandName}");
                w.CloseBraceBlockStatement();
            });

            GenerateBitRangeEncodingFromValue($"(byte)(_extend_ - 1)", "extend", descriptor.ExtendEncoding, operandVariation.WriteEncodings);
            GenerateBitRangeEncodingFromValue($"(byte){operandVariation.OperandName2}", "amount", descriptor.AmountEncoding, operandVariation.WriteEncodings);

            operandVariation.TestArguments.Add(new ExtendTestArgument("LSL", 1));
            operandVariation.TestArguments.Add(new ExtendTestArgument("UXTB", 2));

            variations.Add(operandVariation);
        }
        else
        {
            Debug.Assert(descriptor.Is64Bit);
            {
                var operandVariationX = new OperandVariation
                {
                    Descriptor = descriptor,
                    OperandName = GetNormalizedOperandName(descriptor.Name),
                    OperandType = "Arm64ExtendXKind",
                    OperandName2 = "amount",
                    OperandType2 = "int",
                    EncodingExtract = descriptor.ExtendExtract,
                };
                operandVariationX.AcceptedBitValues.AddRange(descriptor.ExtendExtract!.Selector!.BitValues.Where(x => x.Text.EndsWith("X")));

                if (descriptor.IsOptional)
                {
                    operandVariationX.DefaultValue = "default";
                    operandVariationX.DefaultValue2 = "0";
                }

                operandVariationX.WriteEncodings.Add((w, variable, instruction, operand, index) =>
                {
                    w.WriteLine($"var _extend_ = {operandVariationX.OperandName}.ExtendKind switch");
                    w.OpenBraceBlock();
                    w.WriteLine($"Arm64ExtendKind.None => (byte)Arm64ExtendKind.UXTX,");
                    w.WriteLine($"Arm64ExtendKind.LSL => (byte)Arm64ExtendKind.UXTX,");
                    w.WriteLine($"_ => (byte){operandVariationX.OperandName}.ExtendKind");
                    w.CloseBraceBlockStatement();
                });

                GenerateBitRangeEncodingFromValue($"(byte)(_extend_ - 1)", "extend", descriptor.ExtendEncoding, operandVariationX.WriteEncodings);
                GenerateBitRangeEncodingFromValue($"(byte){operandVariationX.OperandName2}", "amount", descriptor.AmountEncoding, operandVariationX.WriteEncodings);

                operandVariationX.TestArguments.Add(new ExtendTestArgument("LSL", 1));
                operandVariationX.TestArguments.Add(new ExtendTestArgument("SXTX", 1));

                variations.Add(operandVariationX);
            }
            {
                var operandVariationW = new OperandVariation
                {
                    Descriptor = descriptor,
                    OperandName = GetNormalizedOperandName(descriptor.Name),
                    OperandType = "Arm64ExtendWKind",
                    OperandName2 = "amount",
                    OperandType2 = "int",
                    EncodingExtract = descriptor.ExtendExtract,
                };
                operandVariationW.AcceptedBitValues.AddRange(descriptor.ExtendExtract!.Selector!.BitValues.Where(x => !x.Text.EndsWith("X")));

                operandVariationW.WriteEncodings.Add((w, variable, instruction, operand, index) =>
                {
                    w.WriteLine($"var _extend_ = {operandVariationW.OperandName}.ExtendKind switch");
                    w.OpenBraceBlock();
                    w.WriteLine($"Arm64ExtendKind.None => throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariationW.OperandName}), \"Invalid extend value `None`. Expecting a valid extend kind\"),");
                    w.WriteLine($"Arm64ExtendKind.LSL => throw new {nameof(ArgumentOutOfRangeException)}(nameof({operandVariationW.OperandName}), \"Invalid extend value `LSL`. Expecting a valid extend kind\"),");
                    w.WriteLine($"_ => (byte){operandVariationW.OperandName}.ExtendKind");
                    w.CloseBraceBlockStatement();
                });

                GenerateBitRangeEncodingFromValue($"(byte)(_extend_ - 1)", "extend", descriptor.ExtendEncoding, operandVariationW.WriteEncodings);
                GenerateBitRangeEncodingFromValue($"(byte){operandVariationW.OperandName2}", "amount", descriptor.AmountEncoding, operandVariationW.WriteEncodings);

                operandVariationW.TestArguments.Add(new ExtendTestArgument("UXTW", 1));
                operandVariationW.TestArguments.Add(new ExtendTestArgument("UXTB", 2));

                variations.Add(operandVariationW);
            }
        }
    }

    private static (string Default, string? IndexRegisterW) GetMemoryOperandType(MemoryOperandDescriptor memory)
    {
        switch (memory.MemoryEncodingKind)
        {
            case Arm64MemoryEncodingKind.BaseRegisterXn:
                return ("Arm64BaseXMemoryAccessor", null);
            case Arm64MemoryEncodingKind.BaseRegister:
                return ("Arm64BaseMemoryAccessor", null);
            case Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate:
            case Arm64MemoryEncodingKind.BaseRegisterAndImmediate:
            case Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional:
            case Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional:
                return ("Arm64ImmediateMemoryAccessor", null);
                break;
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount:
                return ("Arm64RegisterXExtendMemoryAccessor", null);
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend:
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional:
                return ("Arm64RegisterXExtendMemoryAccessor", "Arm64RegisterWExtendMemoryAccessor");
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
    private void GetRegisterGroupOperandVariation(int operandIndex, Instruction instruction, RegisterGroupOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var registerVariations = new List<OperandVariation>();
        GetRegisterOperandVariation(operandIndex, instruction, descriptor.Register, registerVariations);
        foreach (var registerVariation in registerVariations)
        {
            var operandName = GetNormalizedOperandName(descriptor.Name);
            var operandType = $"Arm64RegisterGroup{descriptor.Count}<{registerVariation.OperandType}>";

            if (descriptor.IndexerExtract != null)
            {
                operandType = $"{operandType}.Indexed";
            }
            
            var operandVariation = new OperandVariation
            {
                Descriptor = descriptor,
                OperandName = operandName,
                OperandType = operandType,
                BitfieldMask = registerVariation.BitfieldMask,
                BitfieldSets = registerVariation.BitfieldSets,
                EncodingExtract = registerVariation.EncodingExtract,
            };
            operandVariation.AcceptedBitValues.AddRange(registerVariation.AcceptedBitValues);

            // Add tests arguments
            operandVariation.TestArguments.AddRange(registerVariation.TestArguments.OfType<RegisterTestArgument>().Select(x => new RegisterGroupTestArgument(x, descriptor.Count)
            {
                Indexer = descriptor.IndexerExtract is not null ? 1 : null
            }));
            
            operandVariation.WriteEncodings.AddRange(registerVariation.WriteEncodings);
            GenerateEncodingForExtract(instruction, descriptor.IndexerExtract, operandVariation, "ElementIndex", "element indexer");

            operandVariations.Add(operandVariation);
        }
    }

    private static void GetRegisterOperandVariation(int operandIndex, Instruction instruction, RegisterOperandDescriptor register, List<OperandVariation> operandVariations)
    {
        var kind = register.RegisterKind;

        string? baseType;

        var operandName = GetNormalizedOperandName(register.Name);

        List<WriteEncodingDelegate> encodings = new();

        var testArguments = new List<RegisterTestArgument>();
        
        switch (kind)
        {
            case Arm64RegisterEncodingKind.X:
                baseType = "Arm64RegisterX";
                if (instruction.Id == "CHKFEAT_hf_hints")
                {
                    testArguments.Add(new("X", 16));
                }
                else
                {
                    testArguments.Add(new("X", 0 + operandIndex));
                    testArguments.Add(new("X", 15 + operandIndex));

                    if (register.Condition != BitRangeCondition.AllNonOne)
                    {
                        if (!register.IsOptional) testArguments.Add(new("X", 31));
                    }
                }
                break;
            case Arm64RegisterEncodingKind.XOrSP:
                baseType = "Arm64RegisterXOrSP";
                testArguments.Add(new("X", 1 + operandIndex));
                testArguments.Add(new("X", 17 + operandIndex));
                testArguments.Add(new("SP", 31));
                break;
            case Arm64RegisterEncodingKind.W:
                baseType = "Arm64RegisterW";
                testArguments.Add(new("W", 0 + operandIndex));
                testArguments.Add(new("W", 15 + operandIndex));
                if (!register.IsOptional) testArguments.Add(new("W", 31));
                break;
            case Arm64RegisterEncodingKind.WOrWSP:
                baseType = "Arm64RegisterWOrWSP";
                testArguments.Add(new("W", 1 + operandIndex));
                testArguments.Add(new("W", 17 + operandIndex));
                testArguments.Add(new("WSP", 31));
                break;
            case Arm64RegisterEncodingKind.DynamicXOrW:
                baseType = "Arm64RegisterXOrW";
                var xOrWExtract = register.DynamicRegisterXOrWSelector;
                Debug.Assert(xOrWExtract is not null);
                var xOrWSelector = xOrWExtract.Selector;
                Debug.Assert(xOrWSelector is not null);
                //Debug.Assert(encoding is null);

                if (xOrWSelector.BitValues.Count == 2)
                {
                    // Simple case, bit 0 is W, bit 1 is X
                    var xSet = xOrWSelector.BitValues.Find(x => x.Text == "X")!;
                    var wSet = xOrWSelector.BitValues.Find(x => x.Text == "W")!;
                    Debug.Assert(wSet.BitSelectorValue == 0);
                    if (instruction.Id == "TBZ_only_testbranch" || instruction.Id == "TBNZ_only_testbranch")
                    {
                        encodings.Add((w, variable, instr, op, opIndex) =>
                        {
                            Debug.Assert(xSet.BitSelectorValue != 0);
                            // From the doc, In assembler source code an 'X' specifier is always permitted, but a 'W' specifier is only permitted when the bit number is less than 32.
                            w.WriteLine($"if ({operandName}.Kind == Arm64RegisterKind.W && imm > 0x1F) throw new {nameof(ArgumentOutOfRangeException)}(nameof(imm), $\"Invalid register W and immediate value '{{imm}}'. The register must be X for a value > 31\");");
                        });
                    }
                    else
                    {
                        encodings.Add((w, variable, instr, op, opIndex) =>
                        {
                            Debug.Assert(xSet.BitSelectorValue != 0);
                            w.WriteLine($"if ({operandName}.Kind == Arm64RegisterKind.X) {variable} |= 0x{xSet!.BitSelectorValue:X8}U;");
                        });
                    }

                    testArguments.Add(new("X", 1 + operandIndex));
                    testArguments.Add(new("W", 1 + operandIndex));
                    testArguments.Add(new("X", 14 + operandIndex));
                    testArguments.Add(new("W", 14 + operandIndex));
                    if (register.Condition != BitRangeCondition.AllNonOne)
                    {
                        if (!register.IsOptional) testArguments.Add(new("X", 31));
                        if (!register.IsOptional) testArguments.Add(new("W", 31));
                    }
                }
                else
                {
                    var operandVariationX = new OperandVariation()
                    {
                        Descriptor = register,
                        EncodingExtract = xOrWExtract,
                        OperandName = operandName,
                        OperandType = "Arm64RegisterX",
                    };
                    operandVariationX.AcceptedBitValues.AddRange(xOrWSelector.BitValues.Where(x => x.Text == "X"));
                    operandVariationX.TestArguments.Add(new RegisterTestArgument("X", 1 + operandIndex));
                    if (register.Condition != BitRangeCondition.AllNonOne)
                    {
                        operandVariationX.TestArguments.Add(new RegisterTestArgument("X", 31));
                    }

                    var encodingX = GetRegisterIndexEncoding(instruction, register, operandVariationX);
                    Debug.Assert(encodingX is not null);
                    operandVariationX.WriteEncodings.Add(encodingX);
                    
                    var operandVariationW = new OperandVariation()
                    {
                        Descriptor = register,
                        EncodingExtract = xOrWExtract,
                        OperandName = operandName,
                        OperandType = "Arm64RegisterW",
                    };
                    operandVariationW.TestArguments.Add(new RegisterTestArgument("W", 1 + operandIndex));
                    if (register.Condition != BitRangeCondition.AllNonOne)
                    {
                        operandVariationW.TestArguments.Add(new RegisterTestArgument("W", 31));
                    }
                    operandVariationW.AcceptedBitValues.AddRange(xOrWSelector.BitValues.Where(x => x.Text == "W"));

                    var encodingW = GetRegisterIndexEncoding(instruction, register, operandVariationW);
                    Debug.Assert(encodingW is not null);
                    operandVariationW.WriteEncodings.Add(encodingW);
                    
                    operandVariations.Add(operandVariationX);
                    operandVariations.Add(operandVariationW);
                    Debug.Assert(register.IndexerExtract is null);
                    return;

                    //encodings.Add((w, variable, instr, op, opIndex) =>
                    //    {
                    //        string? expectingRegister = null;
                    //        foreach (var bitValue in xOrWSelector.BitValues)
                    //        {
                    //            var sharedMask = (bitValue.BitSelectorMask & instr.BitfieldMask);
                    //            if (sharedMask != 0 && (sharedMask & bitValue.BitSelectorValue) == (sharedMask & instr.BitfieldValue))
                    //            {
                    //                if (expectingRegister != null)
                    //                {
                    //                    Debug.Assert(expectingRegister == bitValue.Text);
                    //                }
                    //                else
                    //                {
                    //                    expectingRegister = bitValue.Text;
                    //                }
                    //            }
                    //        }

                    //        if (expectingRegister == null)
                    //        {
                    //            Console.WriteLine($"No Matching for {instr.Instruction.Id}");
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine($"Matching OK {instr.Instruction.Id} with {expectingRegister}");
                    //        }
                    //    }
                    //);
                }



                //// For X, this will be handled by Extend
                //operandVariations.Add(new OperandVariation
                //{
                //    Descriptor = register,
                //    EncodingExtract = null,
                //    OperandName = operandName,
                //    OperandType = "Arm64RegisterX",
                //});

                //// For W, this will be handled by Extend
                //operandVariations.Add(new OperandVariation
                //{
                //    Descriptor = register,
                //    EncodingExtract = null,
                //    OperandName = operandName,
                //    OperandType = "Arm64RegisterW",
                //});

                //return;
                break;
            case Arm64RegisterEncodingKind.B:
                baseType = "Arm64RegisterB";
                testArguments.Add(new("B", 0 + operandIndex));
                testArguments.Add(new("B", 31));
                break;
            case Arm64RegisterEncodingKind.H:
                baseType = "Arm64RegisterH";
                testArguments.Add(new("H", 0 + operandIndex));
                testArguments.Add(new("H", 31));
                break;
            case Arm64RegisterEncodingKind.S:
                baseType = "Arm64RegisterS";
                testArguments.Add(new("S", 0 + operandIndex));
                testArguments.Add(new("S", 31));
                break;
            case Arm64RegisterEncodingKind.D:
                baseType = "Arm64RegisterD";
                testArguments.Add(new("D", 0 + operandIndex));
                testArguments.Add(new("D", 31));
                break;
            case Arm64RegisterEncodingKind.Q:
                baseType = "Arm64RegisterQ";
                testArguments.Add(new("Q", 0 + operandIndex));
                testArguments.Add(new("Q", 31));
                break;
            case Arm64RegisterEncodingKind.Z:
                baseType = "Arm64RegisterZ";
                testArguments.Add(new("Z", 0 + operandIndex));
                testArguments.Add(new("Z", 31));
                break;
            case Arm64RegisterEncodingKind.C:
                baseType = "Arm64RegisterC";
                testArguments.Add(new("C", 0 + operandIndex));
                testArguments.Add(new("C", 15));
                break;
            case Arm64RegisterEncodingKind.DynamicVScalar:
            {
                baseType = "Arm64Register";
                var dynamicRegisterExtract = register.DynamicRegisterXOrWSelector;
                Debug.Assert(dynamicRegisterExtract is not null);
                var dynamicRegisterSelector = dynamicRegisterExtract.Selector;
                Debug.Assert(dynamicRegisterSelector is not null);
                Debug.Assert(dynamicRegisterSelector.BitValues.Count > 0);

                foreach (var bitValue in dynamicRegisterSelector.BitValues)
                {
                    var registerType = $"{baseType}{bitValue.Text}";
                    Debug.Assert(!string.IsNullOrEmpty(bitValue.Text));

                    testArguments.Clear();
                    if (register.IndexerExtract != null)
                    {
                        registerType = $"{registerType}.Indexed";
                        testArguments.Add(new(bitValue.Text, 0 + operandIndex, 0));
                        testArguments.Add(new(bitValue.Text, 31 + operandIndex, 1));
                    }
                    else
                    {
                        testArguments.Add(new(bitValue.Text, 1 + operandIndex));
                        testArguments.Add(new(bitValue.Text, 31 + operandIndex));
                    }

                    var operandVariation = new OperandVariation
                    {
                        Descriptor = register,
                        EncodingExtract = dynamicRegisterExtract,
                        OperandName = operandName,
                        OperandType = registerType,
                        BitfieldMask = bitValue.BitSelectorMask,
                        BitfieldSets = bitValue.BitSelectorValue,
                    };
                    operandVariation.AcceptedBitValues.Add(bitValue);
                    operandVariation.TestArguments.AddRange(testArguments);

                        var indexEncoding = GetRegisterIndexEncoding(instruction, register, operandVariation);
                    if (indexEncoding != null)
                    {
                        operandVariation.WriteEncodings.Add(indexEncoding);
                    }

                    GenerateEncodingForExtract(instruction, register.IndexerExtract, operandVariation, "ElementIndex", "element indexer");
                    operandVariations.Add(operandVariation);
                }
                return;
            }
            case Arm64RegisterEncodingKind.V:
                baseType = "Arm64RegisterV";
                var vectorArrangement = register.VectorArrangement;
                if (vectorArrangement != null)
                {
                    if (vectorArrangement.Kind == Arm64RegisterVectorArrangementEncodingKind.T)
                    {
                        var selector = vectorArrangement.Selector;
                        Debug.Assert(selector is not null);

                        foreach (var bitValue in selector.BitValues)
                        {
                            var vArrangementType = $"{baseType}_{bitValue.Text}";

                            testArguments.Clear();
                            if (register.IndexerExtract != null)
                            {
                                vArrangementType = $"{vArrangementType}.Indexed";
                                testArguments.Add(new("V", 0 + operandIndex, bitValue.Text, 0));
                                testArguments.Add(new("V", 30 + operandIndex, bitValue.Text, 1));
                            }
                            else
                            {
                                testArguments.Add(new("V", 0 + operandIndex, bitValue.Text));
                                testArguments.Add(new("V", 30 + operandIndex, bitValue.Text));
                            }

                            var operandVariation = new OperandVariation
                            {
                                Descriptor = register,
                                EncodingExtract = vectorArrangement,
                                OperandName = operandName,
                                OperandType = vArrangementType,
                                BitfieldMask = bitValue.BitSelectorMask,
                                BitfieldSets = bitValue.BitSelectorValue,
                            };
                            operandVariation.AcceptedBitValues.Add(bitValue);
                            operandVariation.TestArguments.AddRange(testArguments);

                            var indexEncoding = GetRegisterIndexEncoding(instruction, register, operandVariation);
                            if (indexEncoding is not null)
                            {
                                operandVariation.WriteEncodings.Add(indexEncoding!);
                            }

                            GenerateEncodingForExtract(instruction, register.IndexerExtract, operandVariation, "ElementIndex", "element indexer");
                            operandVariations.Add(operandVariation);
                        }

                        return;
                    }
                    else
                    {
                        var (vKind, elementCount) = GetVKindAndElementCount(vectorArrangement.Kind);

                        if (elementCount == 0)
                        {
                            baseType += $"_{vKind}";
                            testArguments.Add(new("V", 0 + operandIndex, vKind));
                            testArguments.Add(new("V", 30 + operandIndex, vKind));
                        }
                        else
                        {
                            baseType += $"_{elementCount}{vKind}";
                            testArguments.Add(new("V", 0 + operandIndex, $"{elementCount}{vKind}"));
                            testArguments.Add(new("V", 30 + operandIndex, $"{elementCount}{vKind}"));
                        }
                    }
                }
                else
                {
                    testArguments.Add(new RegisterTestArgument("V", 0 + operandIndex));
                }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (register.IndexerExtract != null)
        {
            baseType = $"{baseType}.Indexed";
            var newTestArguments = testArguments.Select(x => new RegisterTestArgument(x.BaseRegisterName, x.Index, x.VKind, 1)).ToList();
            testArguments.Clear();
            testArguments.AddRange(newTestArguments);
        }
        
        var opVar = new OperandVariation
        {
            Descriptor = register,
            OperandName = operandName,
            OperandType = baseType,
        };

        if (register.RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Std5Plus1)
        {
            opVar.TestArguments.Add(new RegisterPlus1TestArgument());
        }
        else
        {
            opVar.TestArguments.AddRange(testArguments);
        }

        var directIndexEncoding = GetRegisterIndexEncoding(instruction, register, opVar);
        if (directIndexEncoding is not null)
        {
            encodings.Add(directIndexEncoding);
        }
        opVar.WriteEncodings.AddRange(encodings);

        GenerateEncodingForExtract(instruction, register.IndexerExtract, opVar, "ElementIndex", "element indexer");
        operandVariations.Add(opVar);
    }

    private static void GenerateEncodingForExtract(Instruction instruction, EncodingSymbolExtract? extract, OperandVariation operandVariation, string? memberName, string memberComment)
    {
        if (extract is null) return;

        var selector = extract.Selector;

        int bitSize = 0;
        List<BitRange> bitRanges = new();

        var memberPath = operandVariation.OperandName;
        if (memberName != null)
        {
            memberPath += $".{memberName}";
        }
        
        // Support for indexers with an associated vector arrangement
        if (selector is not null)
        {
            if (selector.BitValues.Count == 0)
            {
                Debug.Assert(operandVariation.BitfieldMask == 0);

                bitSize = selector.BitSize;
                bitRanges.AddRange(selector.BitRanges);
            }
            else if (selector.BitValues.All(x => x.Kind == EncodingBitValueKind.BitExtract))
            {
                // We expect that we generate a selector from a context that has already selected a subset of it (4H => you can only have few bits encoded)
                EncodingBitValue? bitValueFound = null;
                foreach (var bitValue in selector.BitValues)
                {
                    var sharedMask = bitValue.BitSelectorMask & operandVariation.BitfieldMask;
                    if (sharedMask != 0 && (bitValue.BitSelectorValue & sharedMask) == (operandVariation.BitfieldSets & sharedMask))
                    {
                        Debug.Assert(bitValueFound is null); // We don't expect to have multiple bit values that match, so we don't break the loop to make sure
                        bitValueFound = bitValue;
                    }
                }

                Debug.Assert(bitValueFound is not null);
                operandVariation.BitfieldMask |= bitValueFound.BitSelectorMask;
                operandVariation.BitfieldSets |= bitValueFound.BitSelectorValue;

                bitSize = bitValueFound.LocalBitSelectorSize;
                bitRanges.AddRange(bitValueFound.BitItems.Select(x => x.Range));
                //Console.WriteLine($"{instruction.Id} - {instruction.FullSyntax} - {selector}");
            }
            else
            {
                Debug.Assert(false, "We should not arrive here");
            }
        }
        else
        {
            // Otherwise it is a simple indexer
            bitSize = extract.BitSize;
            bitRanges.AddRange(extract.BitRanges);
        }

        GenerateBitRangeEncodingFromValue($"{memberPath}", memberComment, bitSize, bitRanges, operandVariation.WriteEncodings);
    }

    private static void GenerateBitRangeEncodingFromValue(string valuePath, string comment, BitRange bitRange, List<WriteEncodingDelegate> encodings, int operandBitSize = 0)
    {
        GenerateBitRangeEncodingFromValue(valuePath, comment, bitRange.Width, [bitRange], encodings, operandBitSize);
    }

    private static void GenerateBitRangeEncodingFromValue(string valuePath, string comment, int bitSize, List<BitRange> bitRanges, List<WriteEncodingDelegate> encodings, int operandBitSize = 0)
    {
        encodings.Add(
            (w, variable, variation, operand, index) =>
            {
                if (bitRanges.Count == 1)
                {
                    var bitRange = bitRanges[0];
                    w.WriteLine(operandBitSize == 0 || operandBitSize != bitRange.Width
                        ? $"{variable} |= (uint)({valuePath} & 0x{((1 << bitRange.Width) - 1):X}) << {bitRange.LowBit};"
                        : $"{variable} |= (uint){valuePath} << {bitRange.LowBit};");
                }
                else
                {
                    w.OpenBraceBlock();
                    w.WriteLine($"// Write the {comment} for {valuePath}");
                    w.WriteLine($"var _i_ = {valuePath} & 0x{((1 << bitSize) - 1):X};");
                    for (var i = bitRanges.Count - 1; i >= 0; i--)
                    {
                        var bitRange = bitRanges[i];
                        if (bitRange.LowBit != 0)
                        {
                            w.WriteLine($"{variable} |= (uint)(_i_ & 0x{((1 << bitRange.Width) - 1):X}) << {bitRange.LowBit};");
                        }
                        else
                        {
                            w.WriteLine($"{variable} |= (uint)(_i_ & 0x{((1 << bitRange.Width) - 1):X});");
                        }
                        if (i > 0)
                        {
                            w.WriteLine($"_i_ >>= {bitRange.Width};");
                        }
                    }
                    w.CloseBraceBlock();
                }
            }
        );
    }

    private static void GenerateSwitchCaseFromValue(string valuePath, List<(int Value, uint BitMask, uint BitSet)> selections, OperandVariation operandVariation)
    {
        operandVariation.PrepareWriteEncodings.Add((instruction, operand, index) =>
            {
                int? expectedValue = null;
                foreach (var (value, mask, bitset) in selections)
                {
                    var sharedMask = instruction.BitfieldMask & mask;
                    if (sharedMask != 0 && (instruction.BitfieldValue & sharedMask) == bitset)
                    {
                        Debug.Assert(!expectedValue.HasValue);
                        expectedValue = value;
                    }
                }

                if (expectedValue.HasValue)
                {
                    operand.DefaultValue = $"{expectedValue.Value}";
                    operand.TestArguments.Clear();
                    operand.TestArguments.Add(new ImmediateTestArgument(expectedValue.Value));
                }
            }
        );

        operandVariation.WriteEncodings.Add(
            (w, variable, variation, operand, index) =>
            {
                if (operand.DefaultValue != null)
                {
                    w.WriteLine($"if ({valuePath} != {operand.DefaultValue}) throw new {nameof(ArgumentOutOfRangeException)}(nameof({valuePath}), $\"Invalid immediate value. Expecting the fixed value {operand.DefaultValue} instead of {{{valuePath}}}\");");
                }
                else
                {
                    w.WriteLine($"{variable} |= {valuePath} switch");
                    w.OpenBraceBlock();
                    foreach (var (value, mask, bitset) in selections)
                    {
                        w.WriteLine($"{value} => 0x{bitset:X8}U,");
                    }

                    w.WriteLine($"_ => throw new {nameof(ArgumentOutOfRangeException)}(nameof({valuePath}), \"Invalid immediate `{{{valuePath}}}`. The value must be in [{string.Join(", ", selections.Select(x => x.Value))}]\")");
                    w.CloseBraceBlockStatement();
                }
            }
        );
    }

    private static WriteEncodingDelegate? GetRegisterIndexEncoding(Instruction instruction, RegisterOperandDescriptor register, OperandVariation operandVariation)
    {
        switch (register.RegisterIndexEncodingKind)
        {
            case Arm64RegisterIndexEncodingKind.Std5:
            {
                if (register.LowBitIndexEncoding == 0)
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint){op.OperandName}.Index;");
                }
                else
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint){op.OperandName}.Index << {register.LowBitIndexEncoding};");
                }
            }
            case Arm64RegisterIndexEncodingKind.Std4:
            {
                if (register.LowBitIndexEncoding == 0)
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint)({op.OperandName}.Index & 0xF);"); // 4 bits so we mask by security
                }
                else
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint)({op.OperandName}.Index & 0xF) << {register.LowBitIndexEncoding};");
                }
            }
            case Arm64RegisterIndexEncodingKind.Std5Plus1:
                return (w, variable, instr, op, opIndex) =>
                {
                    var previousOp = instr.Operands[opIndex - 1];
                    w.WriteLine($"if ({op.OperandName}.Index != (({previousOp.OperandName}.Index + 1) & 0x1F)) throw new {nameof(ArgumentOutOfRangeException)}(nameof({op.OperandName}), $\"Invalid Register. Index `{{{op.OperandName}.Index}}` must be + 1 from operand {previousOp.OperandName} with index `{{{previousOp.OperandName}.Index}}`\");");
                };
            case Arm64RegisterIndexEncodingKind.BitMapExtract:
                GenerateEncodingForExtract(instruction, register.RegisterIndexExtract, operandVariation, "Index", "register index");
                break;
            case Arm64RegisterIndexEncodingKind.Fixed:
                return (w, variable, instr, op, opIndex) =>
                {
                    w.WriteLine($"if ({operandVariation.OperandName}.Index != {register.FixedRegisterIndex}) throw new {nameof(ArgumentOutOfRangeException)}(nameof({op.OperandName}), $\"Invalid Register. Expecting the fixed index {register.FixedRegisterIndex} instead of {{{operandVariation.OperandName}}}\");");
                };
            default:
                Debug.Assert(false,"register", $"RegisterIndexEncodingKind `{register.RegisterIndexEncodingKind}` is not supported");
                break;
        }

        return null;
    }
    
    private static string GetNormalizedOperandName(string name)
    {
        return name.Replace('.', '_').Replace('|', '_').Replace('(', '_').Replace('+', '_').Replace(")", "");
    }

    private static string GetInstructionMnemonic(Instruction instruction)
    {
        // Special casing for MOV_MOVN that would conflict with MOV_movz
        if (instruction.Id == "MOV_movn_32_movewide" || instruction.Id == "MOV_movn_64_movewide")
        {
            return "MOV_MOVN";
        }

        return instruction.Mnemonic;
    }


    private class InstructionVariation
    {
        public required string Mnemonic { get; init; }

        public required Instruction Instruction { get; init; }

        public uint BitfieldMask { get; set; }

        public uint BitfieldValue { get; set; }
        
        public List<OperandVariation> Operands { get; } = new();

        public InstructionVariation? ElseVariation { get; set; }
    }

    private class OperandVariation
    {
        public required OperandDescriptor Descriptor { get; init; }

        public EncodingSymbolExtract? EncodingExtract { get; set; }

        public required string OperandType { get; set; }

        public required string OperandName { get; init; }
        
        public string? OperandType2 { get; init; }

        public string? OperandName2 { get; init; }
        
        public uint BitfieldMask { get; set; }

        public uint BitfieldSets { get; set; }

        public List<EncodingBitValue> AcceptedBitValues { get; } = new();

        public string? DefaultValue { get; set; }

        public string? DefaultValue2 { get; set; }

        public List<TestArgument> TestArguments { get; } = new();

        public List<PrepareWriteEncodingDelegate> PrepareWriteEncodings { get; } = new();

        public List<WriteEncodingDelegate> WriteEncodings { get; } = new();

        public OperandVariation Clone()
        {
            var clone = new OperandVariation
            {
                Descriptor = Descriptor,
                EncodingExtract = EncodingExtract,
                OperandType = OperandType,
                OperandName = OperandName,
                OperandType2 = OperandType2,
                OperandName2 = OperandName2,
                BitfieldMask = BitfieldMask,
                BitfieldSets = BitfieldSets,
                DefaultValue = DefaultValue,
                DefaultValue2 = DefaultValue2,
            };
            clone.AcceptedBitValues.AddRange(AcceptedBitValues);
            clone.TestArguments.AddRange(TestArguments);
            clone.PrepareWriteEncodings.AddRange(PrepareWriteEncodings);
            clone.WriteEncodings.AddRange(WriteEncodings);
            return clone;
        }

        public void WriterParameters(CodeWriter writer)
        {
            writer.Write($"{OperandType} {OperandName}");
            if (Descriptor.IsOptional || DefaultValue != null)
            {
                writer.Write($" = {DefaultValue ?? "default"}");
            }
            if (OperandType2 is not null)
            {
                writer.Write($", {OperandType2} {OperandName2}");
                if (Descriptor.IsOptional || DefaultValue2 != null)
                {
                    writer.Write($" = {DefaultValue2 ?? "default"}");
                }
            }
        }
    }

    private delegate void WriteEncodingDelegate(CodeWriter writer, string variable, InstructionVariation instruction, OperandVariation operand, int operandIndex);

    private delegate void PrepareWriteEncodingDelegate(InstructionVariation instruction, OperandVariation operand, int operandIndex);
}