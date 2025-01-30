// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{
    private void GenerateAssembler()
    {
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
            WriteInstructions(instClass, instructions);
        }
    }

    private void WriteInstructions(string instClass, List<Instruction> instructions)
    {
        using var w = GetWriter($"Arm64InstructionFactory.{instClass}.gen.cs");

        w.WriteLine("using System.Runtime.CompilerServices;");

        w.WriteLine("namespace AsmArm64;");

        w.WriteLine("static partial class Arm64InstructionFactory");
        w.OpenBraceBlock();

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

        List<InstructionVariation> variations = new();
        foreach (var pair in mapMnemonicToInstructions.OrderBy(x => x.Key))
        {
            variations.Clear();
            GetInstructionVariations(pair.Key, pair.Value, variations);

            foreach (var variation in variations)
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


    private bool TryGetCombinedInstructionVariations(string mnemonic, string id1, string id2, List<Instruction> instructions, [NotNullWhen(true)] out InstructionVariation? variation)
    {
        variation = null;
        var i1 = instructions.Find(x => x.Id == id1);
        if (i1 is null)
        {
            return false;
        }
        instructions.Remove(i1);
        var i2 = instructions.First(x => x.Id == id2)!;
        instructions.Remove(i2);
        
        var v1 = new List<InstructionVariation>();
        GetInstructionVariations(mnemonic, i1, v1);

        var v2 = new List<InstructionVariation>();
        GetInstructionVariations(mnemonic, i2, v2);

        Debug.Assert(v1.Count == 1);
        Debug.Assert(v2.Count == 1);

        variation = v1[0];
        variation.ElseVariation = v2[0];
        return true;
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
            if (combined.Mnemonic  == mnemonic
                && TryGetCombinedInstructionVariations(mnemonic, combined.Id1, combined.Id2, instructions, out var variation))
            {
                variations.Add(variation);
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

            GetOperandVariations(instruction, operand, operandVariations);
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
                        BitfieldValue = instruction.BitfieldValue,
                        Instruction = instruction,
                    };

                    foreach (var allOperandVariation in allOperandVariations)
                    {
                        var operandVariation = allOperandVariation.Count == 1 ? allOperandVariation[0] : allOperandVariation[i];
                        instructionVariation.BitfieldValue |= operandVariation.BitfieldSets;
                        instructionVariation.Operands.Add(operandVariation);
                    }

                    variations.Add(instructionVariation);
                }
            }
            else
            {
                encodingSymbolExtracts = encodingSymbolExtracts.Where(x => x is not null).ToList();

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
                var bestEncodingExtra = encodingSymbolExtracts.Where(x => x.Selector is not null).OrderByDescending(x => x.Selector!.BitSize).First();
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
                                if (operandVariationTry.BitValue == selectedSymbol)
                                {
                                    operandVariation = operandVariationTry;
                                    break;
                                }
                            }

                            Debug.Assert(operandVariation is not null);
                        }

                        instructionVariation.BitfieldValue |= operandVariation.BitfieldSets;
                        instructionVariation.Operands.Add(operandVariation);
                    }

                    variations.Add(instructionVariation);

                    encodingVariations.Add(bitValuesForVariation);
                }

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

    private void GetOperandVariations(Instruction instruction, Operand operand, List<OperandVariation> operandVariations)
    {
        var descriptor = operand.Descriptor;
        Debug.Assert(descriptor is not null);
        Debug.Assert(descriptor.Name.Length > 0);

        switch (descriptor.Kind)
        {
            case Arm64OperandKind.Register:
                GetRegisterOperandVariation(instruction, (RegisterOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.RegisterGroup:
                GetRegisterGroupOperandVariation(instruction,(RegisterGroupOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.SystemRegister:
                operandVariations.Add(
                    new OperandVariation()
                    {
                        Descriptor = descriptor,
                        OperandName = GetNormalizedOperandName(descriptor.Name),
                        OperandType = "Arm64SystemRegister"
                    }
                );
                break;
            case Arm64OperandKind.Memory:
                operandVariations.Add(
                    new OperandVariation()
                    {
                        Descriptor = descriptor,
                        OperandName = GetNormalizedOperandName(descriptor.Name),
                        OperandType = GetMemoryOperandType((MemoryOperandDescriptor)descriptor),
                    }
                );
                
                break;
            case Arm64OperandKind.Immediate:
                GetImmediateVariation((ImmediateOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Label:
                operandVariations.Add(
                    new OperandVariation()
                    {
                        Descriptor = descriptor,
                        OperandName = GetNormalizedOperandName(descriptor.Name),
                        OperandType = "Arm64Label",
                    }
                );
                break;
            case Arm64OperandKind.Shift:
                GetShiftOperandVariations((ShiftOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Extend:
                GetExtendOperandVariations((ExtendOperandDescriptor)descriptor, operandVariations);
                break;
            case Arm64OperandKind.Enum:
                GetEnumVariations((EnumOperandDescriptor)descriptor, operandVariations);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void GetEnumVariations(EnumOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        string enumType;
        switch (descriptor.EnumKind)
        {
            case Arm64EnumKind.Conditional:
            case Arm64EnumKind.InvertedConditional:
                enumType = "Arm64ConditionalKind";
                break;
            case Arm64EnumKind.BranchTargetIdentification:
                enumType = "Arm64BranchTargetIdentificationKind";
                break;
            case Arm64EnumKind.DataSynchronizationOption:
                enumType = "Arm64DataSynchronizationKind";
                break;
            case Arm64EnumKind.StoredSharedHintPolicy:
                enumType = "Arm64StoredSharedHintPolicyKind";
                break;
            case Arm64EnumKind.ProcessStateField:
                enumType = "Arm64ProcessStateField";
                break;
            case Arm64EnumKind.BarrierOperationLimit:
                enumType = "Arm64BarrierOperationLimitKind";
                break;
            case Arm64EnumKind.PrefetchOperation:
                enumType = "Arm64PrefetchOperationKind";
                break;
            case Arm64EnumKind.RangePrefetchOperation:
                enumType = "Arm64RangePrefetchOperationKind";
                break;
            case Arm64EnumKind.DataSync:
                enumType = "Arm64DataSyncKind";
                break;
            case Arm64EnumKind.CodeSync:
                enumType = "Arm64CodeSyncKind";
                break;
            case Arm64EnumKind.RestrictionByContext:
                enumType = "Arm64RestrictionByContextKind";
                break;
            default:
                throw new ArgumentOutOfRangeException($"Invalid enum kind  {descriptor.EnumKind}");
        }

        var name = GetNormalizedOperandName(descriptor.Name);
        operandVariations.Add(
            new OperandVariation()
            {
                Descriptor = descriptor,
                OperandName = name,
                OperandType = enumType,
            }
        );
         
        // We don't create variation as it would conflict with other variations.
        // Instead, user will have to cast to enum in order to pass a value

        //if (descriptor.AllowImmediate)
        //{
        //    operandVariations.Add(
        //        new OperandVariation()
        //        {
        //            Descriptor = descriptor,
        //            OperandName = name,
        //            OperandType = "int",
        //        }
        //    );
        //}
    }

    private void GetImmediateVariation(ImmediateOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var name = GetNormalizedOperandName(descriptor.Name);
        if (descriptor.Name == "0.0")
        {
            name = "zero";
        }
        else if (!descriptor.Name.Contains('.') && char.IsAsciiDigit(descriptor.Name[0]))
        {
            name = $"value{descriptor.Name}";
        }

        var operandType = "int";
        if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.ValueImm64)
        {
            operandType = "ulong";
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask32)
        {
            operandType = "Arm64LogicalImmediate32";
        }
        else if (descriptor.ValueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask64)
        {
            operandType = "Arm64LogicalImmediate64";
        }

        var operandVariation = new OperandVariation
        {
            Descriptor = descriptor,
            OperandName = name,
            OperandType = operandType
        };
        
        if (descriptor.IsOptional)
        {
            operandVariation.DefaultValue = "0";
        }
        
        operandVariations.Add(operandVariation);
    }


    private void GetShiftOperandVariations(ShiftOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var operandType = descriptor.ShiftKind switch
        {
            Arm64ShiftEncodingKind.Fixed => "LSLShiftKind",
            Arm64ShiftEncodingKind.Shift3 => "Arm64ShiftKind3",
            Arm64ShiftEncodingKind.Shift4 => "Arm64ShiftKind4",
            Arm64ShiftEncodingKind.Lsl0 => "LSLShiftKind",
            Arm64ShiftEncodingKind.Lsl => "LSLShiftKind",
            Arm64ShiftEncodingKind.LslScale8 => "LSLShiftKind",
            Arm64ShiftEncodingKind.Msl => "MSLShiftKind",
            Arm64ShiftEncodingKind.LslScale16 => "LSLShiftKind",
            _ => throw new ArgumentOutOfRangeException()
        };

        var operandVariation = new OperandVariation
        {
            Descriptor = descriptor,
            OperandName = GetNormalizedOperandName(descriptor.Name),
            OperandType = operandType,
            OperandName2 = "amount",
            OperandType2 = "int"
        };

        if (descriptor.IsOptional)
        {
            operandVariation.DefaultValue = "default";
            operandVariation.DefaultValue2 = "0";
        }

        operandVariations.Add(operandVariation);
    }

    private void GetExtendOperandVariations(ExtendOperandDescriptor descriptor, List<OperandVariation> variations)
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

        variations.Add(operandVariation);
    }

    private static string GetMemoryOperandType(MemoryOperandDescriptor memory)
    {
        // Arm64BaseMemoryAccessor
        // Arm64BaseXnMemoryAccessor
        // Arm64ImmediateMemoryAccessor
        // Arm64OptionalImmediateMemoryAccessor
        // Arm64RegisterExtendMemoryAccessor
        // Arm64OptionalRegisterExtendMemoryAccessor

        switch (memory.MemoryEncodingKind)
        {
            case Arm64MemoryEncodingKind.BaseRegisterXn:
                return "Arm64BaseXnMemoryAccessor";
            case Arm64MemoryEncodingKind.BaseRegister:
                return "Arm64BaseMemoryAccessor";
            case Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate:
            case Arm64MemoryEncodingKind.BaseRegisterAndImmediate:
                return memory.IsPreIncrement ? "Arm64ImmediateMemoryAccessorPreIncrement" : "Arm64ImmediateMemoryAccessor";
            case Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional:
            case Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional:
                return memory.IsPreIncrement ? "Arm64OptionalImmediateMemoryAccessorPreIncrement" : "Arm64OptionalImmediateMemoryAccessor";
                break;
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount:
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend:
                return memory.IsPreIncrement ? "Arm64RegisterExtendMemoryAccessorPreIncrement" : "Arm64RegisterExtendMemoryAccessor";
                break;
            case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional:
                return "Arm64OptionalRegisterExtendMemoryAccessor";
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
    private void GetRegisterGroupOperandVariation(Instruction instruction, RegisterGroupOperandDescriptor descriptor, List<OperandVariation> operandVariations)
    {
        var registerVariations = new List<OperandVariation>();
        GetRegisterOperandVariation(instruction, descriptor.Register, registerVariations);
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
                BitValue = registerVariation.BitValue,
                EncodingExtract = registerVariation.EncodingExtract,
            };
            operandVariation.WriteEncodings.AddRange(registerVariation.WriteEncodings);

            GenerateEncodingForExtract(instruction, descriptor.IndexerExtract, operandVariation, true);

            operandVariations.Add(operandVariation);
        }
    }

    private static void GetRegisterOperandVariation(Instruction instruction, RegisterOperandDescriptor register, List<OperandVariation> operandVariations)
    {
        var kind = register.RegisterKind;

        string? baseType;

        var operandName = GetNormalizedOperandName(register.Name);

        List<WriteEncodingDelegate> encodings = new();


        switch (kind)
        {
            case Arm64RegisterEncodingKind.X:
                baseType = "Arm64RegisterX";
                break;
            case Arm64RegisterEncodingKind.XOrSP:
                baseType = "Arm64RegisterXOrSP";
                break;
            case Arm64RegisterEncodingKind.W:
                baseType = "Arm64RegisterW";
                break;
            case Arm64RegisterEncodingKind.WOrWSP:
                baseType = "Arm64RegisterWOrWSP";
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
                    var xSet = xOrWSelector.BitValues.Find(x => x.Text == "X")!;
                    var wSet = xOrWSelector.BitValues.Find(x => x.Text == "W")!;
                    Debug.Assert(wSet.BitSelectorValue == 0);
                    encodings.Add((w, variable, instr, op, opIndex) =>
                    {
                        Debug.Assert(xSet.BitSelectorValue != 0);
                        w.WriteLine($"if ({operandName}.Kind == Arm64RegisterKind.X) {variable} = 0x{xSet!.BitSelectorValue:X8}U;");
                    });
                }
                else
                {
                    //Debug.Assert(xOrWSelector.BitValues.Count == 5, $"Unexpected DynamicXOrW Count = {xOrWSelector.BitValues.Count} while expecting 5");
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
                break;
            case Arm64RegisterEncodingKind.H:
                baseType = "Arm64RegisterH";
                break;
            case Arm64RegisterEncodingKind.S:
                baseType = "Arm64RegisterS";
                break;
            case Arm64RegisterEncodingKind.D:
                baseType = "Arm64RegisterD";
                break;
            case Arm64RegisterEncodingKind.Q:
                baseType = "Arm64RegisterQ";
                break;
            case Arm64RegisterEncodingKind.Z:
                baseType = "Arm64RegisterZ";
                break;
            case Arm64RegisterEncodingKind.C:
                baseType = "Arm64RegisterC";
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

                    if (register.IndexerExtract != null)
                    {
                        registerType = $"{registerType}.Indexed";
                    }

                    var operandVariation = new OperandVariation
                    {
                        Descriptor = register,
                        EncodingExtract = dynamicRegisterExtract,
                        OperandName = operandName,
                        OperandType = registerType,
                        BitfieldMask = bitValue.BitSelectorMask,
                        BitfieldSets = bitValue.BitSelectorValue,
                        BitValue = bitValue,
                    };

                    var indexEncoding = GetRegisterIndexEncoding(instruction, register, operandVariation);
                    if (indexEncoding != null)
                    {
                        operandVariation.WriteEncodings.Add(indexEncoding);
                    }
                    GenerateEncodingForExtract(instruction, register.IndexerExtract, operandVariation, true);
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

                            if (register.IndexerExtract != null)
                            {
                                vArrangementType = $"{vArrangementType}.Indexed";
                            }

                            var operandVariation = new OperandVariation
                            {
                                Descriptor = register,
                                EncodingExtract = vectorArrangement,
                                OperandName = operandName,
                                OperandType = vArrangementType,
                                BitfieldMask = bitValue.BitSelectorMask,
                                BitfieldSets = bitValue.BitSelectorValue,
                                BitValue = bitValue,
                            };

                            var indexEncoding = GetRegisterIndexEncoding(instruction, register, operandVariation);
                            if (indexEncoding is not null)
                            {
                                operandVariation.WriteEncodings.Add(indexEncoding!);
                            }
                            GenerateEncodingForExtract(instruction, register.IndexerExtract, operandVariation, true);
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
                        }
                        else
                        {
                            baseType += $"_{elementCount}{vKind}";
                        }
                    }
                }

                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (register.IndexerExtract != null)
        {
            baseType = $"{baseType}.Indexed";
        }


        var opVar = new OperandVariation
        {
            Descriptor = register,
            OperandName = operandName,
            OperandType = baseType,
        };

        var directIndexEncoding = GetRegisterIndexEncoding(instruction, register, opVar);
        if (directIndexEncoding is not null)
        {
            encodings.Add(directIndexEncoding);
        }
        opVar.WriteEncodings.AddRange(encodings);
        GenerateEncodingForExtract(instruction, register.IndexerExtract, opVar, true);
        operandVariations.Add(opVar);
    }

    private static void GenerateEncodingForExtract(Instruction instruction, EncodingSymbolExtract? extract, OperandVariation operandVariation, bool isIndexer)
    {
        if (extract is null) return;

        var selector = extract.Selector;

        int bitSize = 0;
        List<BitRange> bitRanges = new();

        // Support for indexers with an associated vector arrangement
        if (selector is not null)
        {
            if (selector.BitValues.Count == 0)
            {
                Debug.Assert(operandVariation.BitfieldMask == 0);

                bitSize = selector.BitSize;
                bitRanges.AddRange(selector.BitRanges);
            }
            else
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

                bitSize = bitValueFound.LocalBitSelectorSize;
                bitRanges.AddRange(bitValueFound.BitItems.Select(x => x.Range));
                //Console.WriteLine($"{instruction.Id} - {instruction.FullSyntax} - {selector}");
            }
        }
        else
        {
            // Otherwise it is a simple indexer
            bitSize = extract.BitSize;
            bitRanges.AddRange(extract.BitRanges);
        }

        var memberName = isIndexer ? "ElementIndex" : "Index";

        // Write the encoding
        operandVariation.WriteEncodings.Add(
            (w, variable, variation, operand, index) =>
            {
                if (bitRanges.Count == 1)
                {
                    var bitRange = bitRanges[0];
                    w.WriteLine($"{variable} |= ((uint)({operandVariation.OperandName}.{memberName} & 0x{((1 << bitRange.Width) - 1):X}) << {bitRange.LowBit});");
                }
                else
                {
                    w.OpenBraceBlock();
                    w.WriteLine($"// Write the {(isIndexer?"element indexer" : "register index")} for {operandVariation.OperandName}");
                    w.WriteLine($"var _i_ = {operandVariation.OperandName}.{memberName} & 0x{((1 << bitSize) - 1):X};");
                    for (var i = bitRanges.Count - 1; i >= 0; i--)
                    {
                        var bitRange = bitRanges[i];
                        w.WriteLine($"{variable} |= ((uint)(_i_ & 0x{((1 << bitRange.Width) - 1):X}) << {bitRange.LowBit});");
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
    
    private static WriteEncodingDelegate? GetRegisterIndexEncoding(Instruction instruction, RegisterOperandDescriptor register, OperandVariation operandVariation)
    {
        switch (register.RegisterIndexEncodingKind)
        {
            case Arm64RegisterIndexEncodingKind.None:
                break;
            case Arm64RegisterIndexEncodingKind.Std5:
            {
                if (register.LowBitIndexEncoding == 0)
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint)({op.OperandName}.Index);");
                }
                else
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint)({op.OperandName}.Index << {register.LowBitIndexEncoding});");
                }
            }
            case Arm64RegisterIndexEncodingKind.Std4:
            {
                if (register.LowBitIndexEncoding == 0)
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint)({op.OperandName}.Index) & 0xF;"); // 4 bits so we mask by security
                }
                else
                {
                    return (w, variable, instr, op, opIndex) => w.WriteLine($"{variable} |= (uint)(({op.OperandName}.Index & 0xF) << {register.LowBitIndexEncoding});");
                }
            }
            case Arm64RegisterIndexEncodingKind.Std5Plus1:
                return (w, variable, instr, op, opIndex) =>
                {
                    var previousOp = instr.Operands[opIndex - 1];
                    w.WriteLine($"{variable} = {op.OperandName}.Index == {previousOp.OperandName}.Index + 1 ? 0U : throw new {nameof(ArgumentOutOfRangeException)}(nameof({op.OperandName}), $\"Invalid Register. Index `{{{op.OperandName}.Index}}` must be + 1 from operand {previousOp.OperandName} with index `{{{previousOp.OperandName}.Index}}`\");");
                };
            case Arm64RegisterIndexEncodingKind.BitMapExtract:
                GenerateEncodingForExtract(instruction, register.RegisterIndexExtract, operandVariation, false);
                break;
            case Arm64RegisterIndexEncodingKind.Fixed:
                // TODO: verify that the value passed is matching the expected fixed value
                break;
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

        public uint BitfieldValue { get; set; }
        
        public List<OperandVariation> Operands { get; } = new();

        public InstructionVariation? ElseVariation { get; set; }
    }

    private record OperandVariation
    {
        public required OperandDescriptor Descriptor { get; init; }

        public EncodingSymbolExtract? EncodingExtract { get; init; }

        public required string OperandType { get; init; }

        public required string OperandName { get; init; }
        
        public string? OperandType2 { get; init; }

        public string? OperandName2 { get; init; }
        
        public uint BitfieldMask { get; set; }

        public uint BitfieldSets { get; init; }

        public EncodingBitValue? BitValue { get; init; }

        public string? DefaultValue { get; set; }

        public string? DefaultValue2 { get; set; }

        public List<WriteEncodingDelegate> WriteEncodings { get; } = new();
        
        public void WriterParameters(CodeWriter writer)
        {
            writer.Write($"{OperandType} {OperandName}");
            if (Descriptor.IsOptional)
            {
                writer.Write($" = {DefaultValue ?? "default"}");
            }
            if (OperandType2 is not null)
            {
                writer.Write($", {OperandType2} {OperandName2}");
                if (Descriptor.IsOptional)
                {
                    writer.Write($" = {DefaultValue2 ?? "default"}");
                }
            }
        }
    }

    private delegate void WriteEncodingDelegate(CodeWriter writer, string variable, InstructionVariation instruction, OperandVariation operand, int operandIndex);
}