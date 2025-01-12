// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Xml;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

internal sealed class InstructionProcessor
{
    private readonly InstructionSet _instructionSet;
    private readonly List<Instruction> _instructions;
    private readonly Dictionary<string, (VectorArrangementValues Values, HashSet<string> Variations, int Count)> _vectorArrangementItemsUsage = new();
    private readonly Dictionary<string, List<Instruction>> _memoryOperands = new();
    private readonly Dictionary<string, List<Instruction>> _immediateBitShiftSimdSpecial = new();

    private readonly Dictionary<int, List<Instruction>> _operandCountToInstructions = new();

    private readonly Dictionary<string, int> _barrierOperationLimitEnumValues = new();
    private readonly Dictionary<string, int> _prefetchOperationEnumValues = new();
    private readonly Dictionary<string, int> _rangePrefetchOperationEnumValues = new();
    private bool _hasErrors;
    
    public InstructionProcessor(InstructionSet instructionSet)
    {
        _instructionSet = instructionSet;
        _instructions = instructionSet.Instructions;
    }

    public void DumpAllOperands()
    {
        int maxOperandCount = 0;
        Dictionary<OperandKind, HashSet<string>> operandSignatures = new();
        
        foreach (var instruction in _instructions)
        {
            maxOperandCount = Math.Max(maxOperandCount, instruction.Operands.Count);
            foreach (var operand in instruction.Operands)
            {
                var signature = $"{operand.Items.Count:0} {operand}";

                if (!operandSignatures.TryGetValue(operand.Kind, out var set))
                {
                    set = new HashSet<string>();
                    operandSignatures.Add(operand.Kind, set);
                }

                set.Add(signature);
            }


            if (!_operandCountToInstructions.TryGetValue(instruction.Operands.Count, out var instructions))
            {
                instructions = new List<Instruction>();
                _operandCountToInstructions.Add(instruction.Operands.Count, instructions);
            }
            instructions.Add(instruction);
        }

        foreach (var operandSignature in operandSignatures.OrderBy(x => (int)x.Key))
        {
            Console.WriteLine($"Operand kind: {operandSignature.Key}");
            foreach (var signature in operandSignature.Value.Order())
            {
                Console.WriteLine($"  {signature}");
            }
        }

        //Console.WriteLine($"Max operand count: {maxOperandCount}");


        //foreach (var pair in _operandCountToInstructions.OrderByDescending(x => x.Key))
        //{
        //    Console.WriteLine($"Operand count: {pair.Key} -> {pair.Value.Count}");
        //}
    }
    
    public void Run()
    {
        foreach (var instruction in _instructions)
        {
            //bool hasMemory = instruction.Operands.Any(x => x.Kind == OperandKind.Memory);
            //if (hasMemory)
            //{
            //    Console.WriteLine($"Instruction {instruction.Id}");
            //}
            for (var operandIndex = 0; operandIndex < instruction.Operands.Count; operandIndex++)
            {
                var operand = instruction.Operands[operandIndex];
                try
                {
                    switch (operand.Kind)
                    {
                        case OperandKind.Register:
                            Debug.Assert(operand.Items.Count == 1);
                            operand.Descriptor = ProcessRegister(instruction, (RegisterOperandItem)operand.Items[0]);
                            break;
                        case OperandKind.RegisterGroup:
                        {
                            Debug.Assert(operand.Items.Count == 1);
                            operand.Descriptor = ProcessRegisterGroup(instruction, (RegisterGroupOperandItem)operand.Items[0]);
                            break;
                        }
                        case OperandKind.ConstAndImmediate:
                        {
                            break;
                        }
                        case OperandKind.Immediate:
                        {
                            Debug.Assert(operand.Items.Count == 1);
                            operand.Descriptor = ProcessImmediate(instruction, (ImmediateOperandItem)operand.Items[0]);
                            break;
                        }
                        case OperandKind.Memory:
                        {
                            operand.Descriptor = ProcessMemory(instruction, operand, operandIndex);
                            break;
                        }
                        case OperandKind.Select:
                        {
                            Debug.Assert(operand.Items.Count == 1);
                            var selectOperand = (SelectOperandItem)operand.Items[0];
                            operand.Descriptor = ProcessSelectOperand(instruction, selectOperand);
                            break;
                        }
                        case OperandKind.Value:
                            Debug.Assert(operand.Items.Count == 1);
                            var selectedValue = (ValueOperandItem)operand.Items[0];
                            ProcessValue(instruction, selectedValue);
                            break;
                        case OperandKind.Enum:
                            break;
                        case OperandKind.OptionalGroup:
                            Debug.Assert(operand.Items.Count == 1);
                            var optionalGroup = (OptionalGroupOperandItem)operand.Items[0];
                            ProcessOptionalGroup(instruction, optionalGroup);
                            break;
                        case OperandKind.Const:
                            break;
                        default:
                            throw new InvalidOperationException($"Enum not supported {operand.Kind} in instruction {instruction.Id} for operand {operand}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing instruction {instruction.Id} for operand {operand}");
                    Console.WriteLine(ex);
                    _hasErrors = true;
                }
            }
        }

        foreach (var vectorArrangementItems in _vectorArrangementItemsUsage.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            var values = vectorArrangementItems.Value.Values;
            values.Index = _instructionSet.VectorArrangementValues.Count;

            //Console.WriteLine($"[{values.Index}] VectorArrangement {vectorArrangementItems.Key} - {values}");
            //foreach (var variation in vectorArrangementItems.Value.Variations.Order())
            //{
            //    Console.WriteLine($"  {variation}");
            //}
            _instructionSet.VectorArrangementValues.Add(values);
        }

        //foreach (var pair in _memoryOperands.OrderBy(x => x.Key))
        //{
        //    Console.WriteLine($"Memory {pair.Key}");
        //    foreach (var instruction in pair.Value)
        //    {
        //        Console.WriteLine($"  {instruction.Id}");
        //    }
        //}

        //int index = 0;
        //foreach (var pair in _immediateBitShiftSimdSpecial.OrderBy(x => x.Key))
        //{
        //    Console.WriteLine($"[{index}] Immediate\n{pair.Key}");
        //    Console.Write("    ");
        //    foreach (var instruction in pair.Value)
        //    {
        //        Console.Write($"{instruction.Id},");
        //    }
        //    Console.WriteLine();
        //    index++;
        //}

        if (_hasErrors)
        {
            throw new InvalidOperationException("Errors found during processing");
        }
    }

    private OperandDescriptor ProcessOptionalGroup(Instruction instruction, OptionalGroupOperandItem optionalGroup)
    {
        var items = optionalGroup.Items;
        Debug.Assert(items.Count > 0);

        var item0 = items[0];
        var elt0 = item0.TextElements[0];
        var name0 = elt0.Text;
        var symbol0 = elt0.Symbol;

        if (items.Count == 1)
        {
            if (name0 == "shift")
            {
                Debug.Assert(symbol0 is not null && symbol0.BitValues.Count == 2 && symbol0.BitValues[0].Value == "LSL #0" && symbol0.BitValues[1].Value == "LSL #12");

                var shiftOperandDescriptor = new ShiftOperandDescriptor()
                {
                    Kind = Arm64OperandKind.Shift,
                    Name = name0,
                    ShiftKind = Arm64ShiftEncodingKind.Fixed,
                };

                var encoding = new List<BitRange>();
                var size = CollectEncodingForSymbol(instruction, symbol0, encoding);
                Debug.Assert(size == 1);
                Debug.Assert(encoding.Count == 1);
                shiftOperandDescriptor.ShiftEncoding = encoding[0];

                return shiftOperandDescriptor;
            }
            else if (name0 == "LSL")
            {
                var shiftOperandDescriptor = new ShiftOperandDescriptor()
                {
                    Kind = Arm64OperandKind.Shift,
                    Name = name0,
                    ShiftKind = Arm64ShiftEncodingKind.Lsl,
                };

                if (item0.TextElements.Count == 3)
                {
                    Debug.Assert(item0.TextElements[1].Text == " #");
                    if (item0.TextElements[2].Text == "0")
                    {
                        shiftOperandDescriptor.ShiftKind = Arm64ShiftEncodingKind.Lsl0;
                    }
                    else
                    {
                        var symbol = item0.TextElements[2].Symbol;
                        Debug.Assert(symbol is not null);

                        var encoding = new List<BitRange>();
                        shiftOperandDescriptor.AmountSize = CollectEncodingForSymbol(instruction, symbol, encoding);
                        Debug.Assert(encoding.Count == 1);
                        shiftOperandDescriptor.AmountEncoding = encoding[0];

                    }
                }
                else if (item0.TextElements[1].Text == "#0")
                {
                    shiftOperandDescriptor.ShiftKind = Arm64ShiftEncodingKind.Lsl0;
                }
                else
                {
                    Debug.Assert(false, $"Unsupported shift [{string.Join(",", item0.TextElements)}]");
                }

                return shiftOperandDescriptor;
            }
            else if (name0 == "targets")
            {
                Console.WriteLine($"Instruction {instruction.Id,-30} {instruction.Signature}");

                return null;
            }
            else if (name0 == "imm")
            {
                var imm = ProcessImmediate(instruction, items[0]);
                return imm;
            }
        }
        else if (items.Count == 2)
        {
            var item1 = items[1];

            if (name0 == "extend")
            {
                Console.WriteLine($"Instruction {instruction.Id, -30} {instruction.Signature}");
                foreach (var bitValue in symbol0.BitValues)
                {
                    Console.WriteLine($"  {string.Join(":", bitValue.BitFields)} = {bitValue.Value}");
                }

                return null;
            }
            else if (name0 == "shift")
            {
                Debug.Assert(symbol0 is not null);
                var shiftOperandDescriptor = new ShiftOperandDescriptor()
                {
                    Kind = Arm64OperandKind.Shift,
                    ShiftKind = Arm64ShiftEncodingKind.Shift3,
                    Name = name0,
                };

                Debug.Assert(symbol0 is not null && symbol0.BitValues.Count == 4 && symbol0.BitValues[0].Value == "LSL" && symbol0.BitValues[1].Value == "LSR" && symbol0.BitValues[2].Value == "ASR" && (
                    symbol0.BitValues[3].Value == "RESERVED" || symbol0.BitValues[3].Value == "ROR"));


                shiftOperandDescriptor.ShiftKind = symbol0.BitValues[3].Value == "RESERVED" ? Arm64ShiftEncodingKind.Shift3 : Arm64ShiftEncodingKind.Shift4;
                
                var encoding = new List<BitRange>();
                var size = CollectEncodingForSymbol(instruction, symbol0, encoding);
                Debug.Assert(size == 2);
                Debug.Assert(encoding.Count == 1);
                shiftOperandDescriptor.ShiftEncoding = encoding[0];
                
                var amountSymbol = item1.TextElements[0].Symbol;
                Debug.Assert(amountSymbol is not null);

                encoding.Clear();
                shiftOperandDescriptor.AmountSize = CollectEncodingForSymbol(instruction, amountSymbol, encoding);
                Debug.Assert(encoding.Count == 1);
                shiftOperandDescriptor.AmountEncoding = encoding[0];

                return shiftOperandDescriptor;
            }
            else if (name0 == "option")
            {
                Console.WriteLine($"Instruction {instruction.Id,-30} {instruction.Signature}");

                return null;
            }
        }

        Debug.Assert(false, $"Unsupported optional group `{optionalGroup}` for instruction {instruction.Id}");

        return null;
    }

    /// <summary>
    /// List of identified labels kind for instruction. I was not able to find a better way to identify them from the XML file.
    /// </summary>
    private static readonly Dictionary<string, Arm64ImmediateEncodingKind> InstructionIdToLabelOffsetKind = new()
    {
        { "ADR_only_pcreladdr", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "ADRP_only_pcreladdr", Arm64ImmediateEncodingKind.LabelPageOffset },
        { "AUTIASPPC_only_dp_1src_imm", Arm64ImmediateEncodingKind.LabelNegativeEncodedAsUnsigned },
        { "AUTIBSPPC_only_dp_1src_imm", Arm64ImmediateEncodingKind.LabelNegativeEncodedAsUnsigned },
        { "B_only_branch_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "BL_only_branch_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBBEQ_8_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBBGE_8_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBBGT_8_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBBHI_8_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBBHS_8_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBBNE_8_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBEQ_32_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBEQ_32_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBEQ_64_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBEQ_64_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBGE_32_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBGE_64_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBGT_32_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBGT_32_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBGT_64_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBGT_64_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHEQ_16_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHGE_16_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHGT_16_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHHI_16_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHHS_16_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHI_32_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHI_32_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHI_64_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHI_64_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHNE_16_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHS_32_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBHS_64_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBLO_32_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBLO_64_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBLT_32_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBLT_64_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBNE_32_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBNE_32_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBNE_64_imm", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBNE_64_regs", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBNZ_32_compbranch", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBNZ_64_compbranch", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBZ_32_compbranch", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "CBZ_64_compbranch", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "LDR_32_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "LDR_64_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "LDR_d_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "LDR_q_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "LDR_s_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "LDRSW_64_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "PRFM_p_loadlit", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "RETAASPPC_only_miscbranch", Arm64ImmediateEncodingKind.LabelNegativeEncodedAsUnsigned },
        { "RETABSPPC_only_miscbranch", Arm64ImmediateEncodingKind.LabelNegativeEncodedAsUnsigned },
        { "TBNZ_only_testbranch", Arm64ImmediateEncodingKind.LabelStandardOffset },
        { "TBZ_only_testbranch", Arm64ImmediateEncodingKind.LabelStandardOffset },
    };

    private OperandDescriptor ProcessValue(Instruction instruction, ValueOperandItem selectedValue)
    {
        var name = selectedValue.TextElements[0].Text;
        var symbol = selectedValue.TextElements[0].Symbol;
        if (symbol is null)
        {
            Console.WriteLine($"Instruction {instruction.Id} {selectedValue} <<<<");
        }
        else
        {
            if (symbol.BitValues.Count == 0 && name == "label")
            {
                if (!InstructionIdToLabelOffsetKind.TryGetValue(instruction.Id, out var labelOffsetKind))
                {
                    labelOffsetKind = Arm64ImmediateEncodingKind.LabelStandardOffset;
                    Console.WriteLine($"Unsupported label kind for instruction {instruction.Id}");
                    _hasErrors = true;
                }
                
                var immediate = ProcessImmediate(instruction, selectedValue);
                immediate.ImmediateKind = labelOffsetKind;
                immediate.Name = name;

                return immediate;
            }
            else if (symbol.BitValues.Count > 0)
            {
                var descriptor = new ImmediateByteValuesOperandDescriptor()
                {

                    Kind = Arm64OperandKind.ImmediateByteValues,
                    Name = name,
                };
                descriptor.Size = CollectEncodingForSymbol(instruction, symbol, descriptor.Encoding);

                Debug.Assert(symbol.BitValues.Count <= 4);

                for (var i = 0; i < symbol.BitValues.Count; i++)
                {
                    var bitValue = symbol.BitValues[i];
                    var encodingValue = bitValue.GetBitFieldsAsInt();
                    Debug.Assert(i == encodingValue);
                    Debug.Assert(bitValue.Value.StartsWith("#"));
                    var userValue = byte.Parse(bitValue.Value.Substring(1));

                    descriptor.Values.Add(userValue);
                }

                Debug.Assert(descriptor.Encoding.Count == 1 || descriptor.Encoding.Count == 2);
                return descriptor;
            }
            else
            {
                Debug.Assert(false, $"Operand {selectedValue} is not supported in instruction {instruction.Id}. Symbol: {symbol}");
            }
        }

        return null;
    }
    
    private OperandDescriptor ProcessSelectOperand(Instruction instruction, SelectOperandItem selectOperand)
    {
        Debug.Assert(selectOperand.Items.Count == 2);
        var item0 = selectOperand.Items[0];
        var name = item0.TextElements[0];
        var immediate = new ImmediateOperandDescriptor()
        {
            Kind = Arm64OperandKind.Immediate,
            Name = name.Text,
        };

        if (item0.TextElements[0].Text == "systemreg")
        {
            // Select MRRS_rs_systemmovepr - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MRS_rs_systemmove - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MSR_sr_systemmove - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MSRR_sr_systemmovepr - (systemreg|Sop0_op1_Cn_Cm_op2)
            Debug.Assert(instruction.Id == "MRRS_rs_systemmovepr" || instruction.Id == "MRS_rs_systemmove" || instruction.Id == "MSR_sr_systemmove" || instruction.Id == "MSRR_sr_systemmovepr");

            immediate.ImmediateKind = Arm64ImmediateEncodingKind.SystemRegister;
            immediate.Size = CollectEncodingForSymbol(instruction, item0.TextElements[0].Symbol!, immediate.Encoding);

            return immediate;
        }
        else if (instruction.Id == "DMB_bo_barriers" || instruction.Id == "DSB_bo_barriers")
        {
            // Select DMB_bo_barriers - (option|#imm)
            // Select DSB_bo_barriers - (option|#imm)

            immediate.ImmediateKind = Arm64ImmediateEncodingKind.BarrierOperationLimit;
            immediate.Size = CollectEncodingForSymbol(instruction, name.Symbol!, immediate.Encoding);
            CollectEnumValues(name.Symbol!, _barrierOperationLimitEnumValues);

            return immediate;
        }
        else if (instruction.Id == "PRFM_p_ldst_pos" || instruction.Id == "PRFM_p_loadlit" || instruction.Id == "PRFM_p_ldst_regoff" || instruction.Id == "PRFUM_p_ldst_unscaled")
        {
            // Select PRFM_p_ldst_pos - (prfop|#imm5)
            // Select PRFM_p_loadlit - (prfop|#imm5)
            // Select PRFM_p_ldst_regoff - (prfop|#imm5)
            // Select PRFUM_p_ldst_unscaled - (prfop|#imm5)

            immediate.ImmediateKind = Arm64ImmediateEncodingKind.PrefetchOperation;
            immediate.Size = CollectEncodingForSymbol(instruction, name.Symbol!, immediate.Encoding);
            CollectEnumValues(name.Symbol!, _prefetchOperationEnumValues);

            return immediate;
        }
        else if (instruction.Id == "RPRFM_r_ldst_regoff")
        {
            // Select RPRFM_r_ldst_regoff - (rprfop|#imm6)
            immediate.ImmediateKind = Arm64ImmediateEncodingKind.RangePrefetchOperation;
            immediate.Size = CollectEncodingForSymbol(instruction, name.Symbol!, immediate.Encoding);
            CollectEnumValues(name.Symbol!, _rangePrefetchOperationEnumValues);

            return immediate;
        }
        else
        {
            var imm = selectOperand.Items[1].TextElements[0];
            Console.WriteLine($"Unsupported Select instruction {instruction.Id} - {selectOperand} -> ({name.Text}|{imm.Text})");

            foreach (var keyVal in name.Symbol!.BitValues)
            {
                Console.WriteLine($"  {string.Join(":", keyVal.BitFields)} = {keyVal.Value}");
            }
            throw new NotSupportedException($"Unsupported Select instruction {instruction.Id} - {selectOperand}");
        }
    }

    private RegisterOperandDescriptor ProcessRegister(Instruction instruction, RegisterOperandItem register)
    {
        var elt0 = register.TextElements[0];
        var name0 = elt0.Text;
        var isSP = name0.EndsWith("SP");
        Debug.Assert(!isSP || name0.Contains('|') );

        int indexOfIndexEncoding = 0;

        Arm64RegisterEncodingKind kind;

        DynamicRegisterSelector? dynamicDescriptor = null;

        for (int i = 0; i < register.TextElements.Count; i++)
        {
            var textElement = register.TextElements[i];
            if (textElement.Symbol is not null && textElement.Symbol.BitInfos.Count == 1 && textElement.Symbol.BitInfos[0].Name.StartsWith("R"))
            {
                indexOfIndexEncoding = i;
                break;
            }
        }

        var c = char.ToUpperInvariant(name0[0]);
        switch (c)
        {
            case 'X':
                kind = isSP ? Arm64RegisterEncodingKind.RegXOrSP : Arm64RegisterEncodingKind.RegX;
                break;
            case 'W':
                kind = isSP ? Arm64RegisterEncodingKind.RegWOrWSP : Arm64RegisterEncodingKind.RegW;
                break;
            case 'B':
                kind = Arm64RegisterEncodingKind.RegB;
                break;
            case 'H':
                kind = Arm64RegisterEncodingKind.RegH;
                break;
            case 'S':
                kind = Arm64RegisterEncodingKind.RegS;
                break;
            case 'D':
                kind = Arm64RegisterEncodingKind.RegD;
                break;
            case 'C':
                kind = Arm64RegisterEncodingKind.RegC;
                break;
            case 'V':
                if (indexOfIndexEncoding != 0 && elt0.Symbol is not null && elt0.Symbol.BitValues.Count > 0)
                {
                    // This is not a vector but a scalar register
                    kind = Arm64RegisterEncodingKind.DynamicRegVScalar;
                    dynamicDescriptor = ParseDynamicRegister(instruction, register);
                }
                else
                {
                    kind = Arm64RegisterEncodingKind.RegV;
                }
                break;
            case 'Q':
                kind = Arm64RegisterEncodingKind.RegQ;
                break;
            //case 'Z':
            //    kind = RegisterKind.Z;
            //    break;
            default:
                if (c == 'R')
                {
                    // Case of a dynamic X or W register
                    Debug.Assert(elt0.Symbol is not null);
                    kind = Arm64RegisterEncodingKind.DynamicRegXOrW;
                    dynamicDescriptor = ParseDynamicRegister(instruction, register);
                    indexOfIndexEncoding = 1;
                }
                else
                {
                    throw new NotSupportedException($"Unsupported 1st register letter `{c}` in register name `{name0}` in instruction `{instruction.Id}`");
                }

                break;
        }

        var descriptor = new RegisterOperandDescriptor()
        {
            Kind = Arm64OperandKind.Register,
            RegisterKind = kind,
            DynamicRegisterXOrWSelector = dynamicDescriptor
        };

        var symbol = register.TextElements[indexOfIndexEncoding].Symbol;
        if (symbol is not null && symbol.BitInfos.Count > 0)
        {
            int size = CollectEncodingForSymbol(instruction, symbol, descriptor.IndexEncoding);

            if (symbol.BitValues.Count == 0 && (descriptor.IndexEncoding.Count == 1 && (size == 5 || size == 4)))
            {
                descriptor.RegisterIndexEncodingKind = size == 4
                    ? Arm64RegisterIndexEncodingKind.Regular4
                    : Arm64RegisterIndexEncodingKind.Regular5;
            }
            else //if (symbol.BitInfos.Count != 1 || size != 5 || symbol.BitValues.Count != 0)
            {
                // There is a special case
                // (23:2),(20:1),(19:4)
                // BitFields = 00, Value = RESERVED
                // BitFields = 01, Value = UInt('0':Rm)
                // BitFields = 10, Value = UInt(M:Rm)
                // BitFields = 11, Value = RESERVED
                var encodingSignature = $"Match `{string.Join(":", symbol.BitValueNames)}` {{{string.Join("|", symbol.BitValues)}}} - {string.Join(",", descriptor.IndexEncoding)}";
                var expectedSignature = "Match `size` {BitFields = 00, Value = RESERVED|BitFields = 01, Value = UInt('0':Rm)|BitFields = 10, Value = UInt(M:Rm)|BitFields = 11, Value = RESERVED} - (23:2),(20:5)";
                if (encodingSignature != expectedSignature)
                {
                    var errorMessage = new StringBuilder();
                    errorMessage.AppendLine($"Unsupported register encoding `{name0}` Size: {size}, Count: {symbol.BitInfos.Count} for instruction `{instruction.Id}` - {string.Join(",", descriptor.IndexEncoding)} - BitMatch: {string.Join(":", symbol.BitValueNames)}");
                    symbol.BitValues.ForEach(x => Console.WriteLine($"  {x}"));
                    //throw new NotSupportedException(errorMessage.ToString());
                    //Console.WriteLine(errorMessage);
                }
                else
                {
                    descriptor.RegisterIndexEncodingKind = Arm64RegisterIndexEncodingKind.SpecialMRm;
                    // We don't need to store the bit, as we know it is a special encoding
                    descriptor.IndexEncoding.Clear();
                }
            }
        }
        else
        {
            Debug.Assert(false, $"No encoding found for {instruction.Id}");
        }

        if (kind == Arm64RegisterEncodingKind.RegV && register.TextElements.Count > 1)
        {
            descriptor.VectorArrangement = ParseVectorArrangement(instruction, register);
        }
        
        ProcessIndexer(instruction, register);
        
        return descriptor;
    }

    private DynamicRegisterSelector ParseDynamicRegister(Instruction instruction, RegisterOperandItem register)
    {
        var symbol = register.TextElements[0].Symbol!;
        var dynamicDescriptor = new DynamicRegisterSelector();
        dynamicDescriptor.SelectorSize = CollectEncodingForSymbol(instruction, symbol.BitValueNames, dynamicDescriptor.SelectorEncoding);

        foreach (var bitValue in symbol.BitValues)
        {
            var registerOperandKind = bitValue.Value switch
            {
                "B" => Arm64RegisterEncodingKind.RegB,
                "S" => Arm64RegisterEncodingKind.RegS,
                "H" => Arm64RegisterEncodingKind.RegH,
                "D" => Arm64RegisterEncodingKind.RegD,
                "W" => Arm64RegisterEncodingKind.RegW,
                "X" => Arm64RegisterEncodingKind.RegX,
                "RESERVED" => Arm64RegisterEncodingKind.None,
                _ => throw new NotSupportedException($"Unsupported dynamic register value `{bitValue.Value}` in instruction `{instruction.Id}`")
            };

            dynamicDescriptor.MapBitValueToRegister.Add(new(string.Join("", bitValue.BitFields), registerOperandKind));
        }
        Debug.Assert(register.TextElements.Count == 2 && register.TextElements[1].Symbol is not null, $"Invalid encoding for instruction {instruction.Id}");

        return dynamicDescriptor;
    }

    private void ProcessIndexer(Instruction instruction, OperandItem item)
    {
        var indexer = item.Indexer;
        if (indexer is null) return;
        
        Debug.Assert(indexer.TextElements.Count == 1);
        var text = indexer.TextElements[0].Text;
        var symbol = indexer.TextElements[0].Symbol;

        //Console.WriteLine($"{instruction.Id} {item} => Indexer {symbol}");
        
        //var bitRangeInfo = instruction.BitRangeMap[encodingBitInfo.Name];
    }

    private VectorArrangement ParseVectorArrangement(Instruction instruction, RegisterOperandItem register)
    {
        // Detect arrangement
        int index;
        if (register.TextElements[1].Text == ".")
        {
            index = 2;
        }
        else
        {
            // Case where the encoding is simply Vd where V has the encoding (H,B,S...) and d is the register index
            Debug.Assert(register.TextElements[0].Symbol is not null);
            index = 0;
        }

        var text = register.TextElements[index].Text;
        var symbol = register.TextElements[index].Symbol;

        // Fix special case for H hardcoded in a special way
        if (text == "V" && symbol is not null && symbol.Link == "V_hv")
        {
            text = "H";
            symbol = null;
        }

        var vectorArrangement = new VectorArrangement
        {
            ArrangementKind = ParseArrangementKind(text)
        };

        if (symbol is not null && symbol.BitValues.Count > 0)
        {
            vectorArrangement.EncodingSize = CollectEncodingForSymbol(instruction, symbol, vectorArrangement.Encoding);
            
            var values = new VectorArrangementValues();
            foreach (var bitValue in symbol.BitValues)
            {
                var elementKind = ParseArrangementKind(bitValue.Value);
                var bitValues = string.Join(":", bitValue.BitFields);
                var element = new VectorArrangementValue(elementKind, bitValues);
                values.Add(element);
            }

            var id = values.Id;

            if (!_vectorArrangementItemsUsage.TryGetValue(id, out var valuesAndCount))
            {
                valuesAndCount = (values, new HashSet<string>(), 0);
                _vectorArrangementItemsUsage.Add(id, valuesAndCount);
            }

            vectorArrangement.Values = valuesAndCount.Values;
            valuesAndCount.Variations.Add(vectorArrangement.Id);
            _vectorArrangementItemsUsage[id] = (valuesAndCount.Values, valuesAndCount.Variations,  valuesAndCount.Count + 1);
        }

        return vectorArrangement;
    }


    private static Arm64RegisterVectorArrangementEncodingKind ParseArrangementKind(string text)
    {
        switch (text)
        {
            case "16B":
                return Arm64RegisterVectorArrangementEncodingKind.T_16B;
            case "8B":
                return Arm64RegisterVectorArrangementEncodingKind.T_8B;
            case "4B":
                return Arm64RegisterVectorArrangementEncodingKind.T_4B;
            case "2B":
                return Arm64RegisterVectorArrangementEncodingKind.T_2B;
            case "2H":
                return Arm64RegisterVectorArrangementEncodingKind.T_2H;
            case "4H":
                return Arm64RegisterVectorArrangementEncodingKind.T_4H;
            case "8H":
                return Arm64RegisterVectorArrangementEncodingKind.T_8H;
            case "2S":
                return Arm64RegisterVectorArrangementEncodingKind.T_2S;
            case "4S":
                return Arm64RegisterVectorArrangementEncodingKind.T_4S;
            case "2D":
                return Arm64RegisterVectorArrangementEncodingKind.T_2D;
            case "1D":
                return Arm64RegisterVectorArrangementEncodingKind.T_1D;
            case "1Q":
                return Arm64RegisterVectorArrangementEncodingKind.T_1Q;
            case "T":
                return Arm64RegisterVectorArrangementEncodingKind.T;
            case "D":
                return Arm64RegisterVectorArrangementEncodingKind.D;
            case "H":
                return Arm64RegisterVectorArrangementEncodingKind.H;
            case "B":
                return Arm64RegisterVectorArrangementEncodingKind.B;
            case "S":
                return Arm64RegisterVectorArrangementEncodingKind.S;
            case "RESERVED":
                return Arm64RegisterVectorArrangementEncodingKind.Reserved;
            default:
                if (text.StartsWith("T"))
                {
                    return Arm64RegisterVectorArrangementEncodingKind.T;
                }
                else
                {
                    throw new NotSupportedException($"Unsupported arrangement `{text}`");
                }
        }
    }
    
    private RegisterGroupOperandDescriptor ProcessRegisterGroup(Instruction instruction, RegisterGroupOperandItem group)
    {
        var descriptors = new List<RegisterOperandDescriptor>();
        var ids = new HashSet<string>();

        foreach (var register in group.Items)
        {
            Debug.Assert(register.Kind == OperandItemKind.Register);
            descriptors.Add(ProcessRegister(instruction, (RegisterOperandItem)register));
        }

        // We are expecting all registers in a group to point to the same register (e.g. they are consecutive but pointing to X0 when passing X0, X1, X2, X3)
        // What matters is the size of the group and the first register
        foreach (var descriptor in descriptors)
        {
            ids.Add(descriptor.ToString());
        }

        Debug.Assert(ids.Count == 1);
        if (group.Items.Count == 0 || group.Items.Count > 4)
        {
            throw new NotSupportedException(
                $"Unsupported number of register groups {group.Items.Count}. Must be <= 4 for instruction {instruction.Id}");
        }

        var registerGroup = new RegisterGroupOperandDescriptor()
        {
            Kind = Arm64OperandKind.RegisterGroup,
            Register = descriptors[0],
            Count = group.Items.Count,
        };

        return registerGroup;
    }

    private ImmediateOperandDescriptor ProcessImmediate(Instruction instruction, OperandItem item)
    {
        var immediate = new ImmediateOperandDescriptor()
        {
            Kind = Arm64OperandKind.Immediate,
            Name = item.GetName(),
        };

        // TODO: can we handle it better than by name?
        if (immediate.Name.StartsWith("simm"))
        {
            immediate.IsSigned = true;
        }
        
        var c = item.TextElements[0].Text[0];
        if (char.IsAsciiDigit(c) || c == '-')
        {
            var fixedValue = new StringBuilder();
            foreach (var textElement in item.TextElements)
            {
                fixedValue.Append(textElement.Text);
                Debug.Assert(textElement.Symbol is null);
            }
            var fixedValueStr = fixedValue.ToString();
            if (fixedValueStr.Contains('.'))
            {
                Debug.Assert(fixedValueStr.EndsWith("0.0"));
                immediate.ImmediateKind = Arm64ImmediateEncodingKind.FixedFloatZero;
                immediate.FixedValue = 0;
            }
            else
            {
                immediate.ImmediateKind = Arm64ImmediateEncodingKind.FixedInt;
                immediate.FixedValue = sbyte.Parse(fixedValueStr);
            }
        }
        else
        {

            Debug.Assert(item.TextElements.Count == 1);
            var symbol = item.TextElements[0].Symbol;
            Debug.Assert(symbol != null);
            immediate.Size = CollectEncodingForSymbol(instruction, symbol, immediate.Encoding);
            Debug.Assert(immediate.Encoding.Count > 0);
            immediate.ImmediateKind = Arm64ImmediateEncodingKind.Regular;

            if (symbol.BitValues.Count != 0)
            {
                var kind = $"[{string.Join(",", symbol.BitValues.Select(bitValue => $"{bitValue.BitFields[0]} = {bitValue.Value}"))}]";
                if (immediate.Size == 7 && immediate.Encoding[0] == new BitRange(22, 7) && symbol.BitValues.Count == 4 && symbol.BitValueNames.Count == 1 && symbol.BitValueNames[0] == "immh")
                {
                    switch (kind)
                    {
                        case "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdBitShiftType0;
                            break;
                        case "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = RESERVED]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdBitShiftType1;
                            break;
                        case "[0001 = RESERVED,001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdBitShiftType2;
                            break;
                        case "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = RESERVED]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdBitShiftType3;
                            break;
                        case "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = UInt(immh:immb) - 64]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdBitShiftType4;
                            break;
                        default:
                            throw new NotSupportedException($"Unsupported immediate kind `{kind}` in instruction `{instruction.Id}`");
                    }
                }
                else if (symbol.BitValueNames.Count == 1 && symbol.BitValueNames[0] == "rot")
                {
                    switch (kind)
                    {
                        case "[0 = 90,1 = 270]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.Rotate90Or270;
                            break;
                        case "[00 = 0,01 = 90,10 = 180,11 = 270]":
                            immediate.ImmediateKind = Arm64ImmediateEncodingKind.Rotate0Or90Or180Or270;
                            break;
                        default:
                            throw new NotSupportedException($"Unsupported immediate kind `{kind}` in instruction `{instruction.Id}`");
                    }
                }
                else if (symbol.BitValueNames.Count == 1 && symbol.BitValueNames[0] == "cmode<0>" && immediate.Encoding.Count == 1)
                {
                    Debug.Assert(immediate.Encoding[0] == new BitRange(15,4));
                    immediate.ImmediateKind = Arm64ImmediateEncodingKind.EnumAmount8Or16;
                    immediate.Size = 1;
                    immediate.Encoding[0] = new BitRange(12, 1);
                }
                else if (instruction.Id == "SHLL_asimdmisc_s")
                {
                    // Special immediate #shift Size: 2 in instruction id SHLL_asimdmisc_s - [(23:2)] - Selector: size
                    // 00 = 8
                    // 01 = 16
                    // 10 = 32
                    // 11 = RESERVED
                    Debug.Assert(symbol.BitValues.Count == 4);
                    immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdLeftShift8Or16Or32;
                }
                else if (instruction.Id == "EXT_asimdext_only")
                {
                    // special immediate #index Size: 5 in instruction id EXT_asimdext_only - [(30:1),(14:4)] - Selector: Q,imm4<3>
                    // 0:0 = UInt(imm4<2:0>)
                    // 0:1 = RESERVED
                    // 1:x = UInt(imm4)
                    immediate.Encoding.Clear();
                    immediate.Size = 0;
                    immediate.ImmediateKind = Arm64ImmediateEncodingKind.SimdExtIndex;
                }
                else
                {
                    Console.WriteLine($"Unsupported special immediate {item} Size: {immediate.Size} in instruction id {instruction.Id} - [{string.Join(",", immediate.Encoding)}] - Selector: {string.Join(",", symbol.BitValueNames)}");
                    foreach (var bitValue in symbol.BitValues)
                    {
                        Console.WriteLine($"  {string.Join(":", bitValue.BitFields)} = {bitValue.Value}");
                    }

                    _hasErrors = true;
                }
            }
            else
            {
                var kind = string.Join(":", symbol.BitInfos.Select(x => x.Name));
                if (kind == "a:b:c:d:e:f:g:h")
                {
                    if (immediate.Name == "imm")
                    {
                        // 64-bit immediate 'aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh'
                        // immediate.Name == "imm"
                        immediate.ImmediateKind = Arm64ImmediateEncodingKind.Imm64;
                    }
                }
                else if (symbol.BitInfos.Count > 3)
                {
                    Console.WriteLine($"Watch out special immediate #{immediate.Name} Size: {immediate.Size} in instruction id {instruction.Id} - [{string.Join(",", immediate.Encoding)}] - Selector: {string.Join(":", symbol.BitInfos.Select(x => x.Name))}");
                    _hasErrors = true;
                }
            }
        }

        return immediate;
    }

    private MemoryOperandDescriptor ProcessMemory(Instruction instruction, Operand operand, int operandIndex)
    {
        var items = operand.Items;
        var baseRegister = ProcessRegister(instruction, (RegisterOperandItem)items[0]);
        OperandDescriptor? indexRegisterOrImmediate = null;

        //Console.WriteLine($"Memory instruction {instruction.Id,-30} - {instruction.Signature}");

        Arm64MemoryEncodingKind kind;
        var extendKind = Arm64MemoryExtendEncodingKind.NoLsl;
        sbyte fixedValue = 0;

        // 1 [Xd]!
        // 1 [Xn|SP]
        // 1 [Xs]!
        if (items.Count == 1)
        {
            kind = Arm64MemoryEncodingKind.BaseRegisterXn;
        }
        else if (items.Count == 2)
        {
            // 2 [Xn|SP,#-16]!
            // 2 [Xn|SP,#-4]!
            // 2 [Xn|SP,#-8]!
            // 2 [Xn|SP,#imm]!
            // 2 [Xn|SP,#simm]!
            // 2 [Xn|SP{,#imm}]
            // 2 [Xn|SP{,#pimm}]
            // 2 [Xn|SP{,#simm}]
            // 2 [Xn|SP{,#simm}]!
            var imm = items[1];
            ImmediateOperandDescriptor immediate;
            if (imm.Kind == OperandItemKind.Immediate)
            {
                immediate = ProcessImmediate(instruction, (ImmediateOperandItem)imm);
                kind = immediate.FixedValue != 0 ? Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate : Arm64MemoryEncodingKind.BaseRegisterXnOrSPAndImmediate;
                fixedValue = immediate.FixedValue;
            }
            else if (imm.Kind == OperandItemKind.OptionalGroup)
            {
                var group = (OptionalGroupOperandItem)imm;
                Debug.Assert(group.Items.Count == 1);
                immediate = ProcessImmediate(instruction, (ImmediateOperandItem)group.Items[0]);
                kind = Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Unsupported operand `{imm}` in {instruction.Id}");
            }

            indexRegisterOrImmediate = immediate;
        }
        else if (items.Count == 3 || items.Count == 4)
        {
            // 3 [Xn|SP,(Wm|Xm){,extend,{amount}}]
            // 3 [Xn|SP,Xm{,LSLamount}]
            // 4 [Xn|SP,(Wm|Xm),extend{,amount}]

            var index = items[1];

            if (index.Kind == OperandItemKind.Register)
            {
                indexRegisterOrImmediate = ProcessRegister(instruction, (RegisterOperandItem)index);
                kind = Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount;
            }
            else if (index.Kind == OperandItemKind.Select)
            {
                var selectOperandItem = (SelectOperandItem)index;
                Debug.Assert(selectOperandItem.Items.Count == 2);
                var firstReg = ProcessRegister(instruction, (RegisterOperandItem)selectOperandItem.Items[0]);
                var secondReg = ProcessRegister(instruction, (RegisterOperandItem)selectOperandItem.Items[1]);
                Debug.Assert(firstReg.IndexEncoding.Count == 1);
                Debug.Assert(secondReg.IndexEncoding.Count == 1);
                Debug.Assert(firstReg.IndexEncoding[0] == secondReg.IndexEncoding[0]);
                kind = Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend;
                indexRegisterOrImmediate = firstReg;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Unsupported operand `{operand}` in {instruction.Id}");
            }

            // Examples:

            if (items.Count == 3)
            {
                var item2 = (OptionalGroupOperandItem)items[2];
                
                if (item2.Items.Count == 1)
                {
                    // Addressing [Xn|SP,Xm{,LSLamount}]
                    // LDRSB_64bl_ldst_regoff
                    // LDRSB       Xt, [Xn|SP, Xm{, LSLamount}]
                    // NoLsl
                }
                else
                {
                    // Addressing [Xn|SP,(Wm|Xm){,extend,amount}]
                    // LDR_64_ldst_regoff
                    // LDR         Xt, [Xn|SP, (Wm|Xm){, extend, {amount}}]
                    Debug.Assert(item2.Items.Count == 2);

                    var extend = item2.Items[0];
                    var amount = ((OptionalGroupOperandItem)item2.Items[1]).Items[0];
                    extendKind = DetectMemoryExtendKind(instruction, extend, amount);
                }
            }
            else
            {
                // Addressing [Xn|SP,(Wm|Xm),extend{,amount}]
                // LDRSB_64b_ldst_regoff
                // LDRSB       Xt, [Xn|SP, (Wm|Xm), extend{, amount}]

                var extend = items[2];
                var amount = ((OptionalGroupOperandItem)items[3]).Items[0];
                extendKind = DetectMemoryExtendKind(instruction, extend, amount);
            }
        }
        else
        {
            throw new NotSupportedException($"Unsupported number of memory items {items.Count}");
        }

        var memoryOperandDescriptor = new MemoryOperandDescriptor()
        {
            Kind = Arm64OperandKind.Memory,
            MemoryEncodingKind = kind,
            Name = "mem", // TODO: name it better between src/dst
            FixedValue = fixedValue,
            IsPreIncrement = operand.HasBang,
            ExtendKind = extendKind,
        };

        Debug.Assert(baseRegister.IndexEncoding.Count == 1);
        memoryOperandDescriptor.BaseRegister = baseRegister.IndexEncoding[0];
        Debug.Assert(memoryOperandDescriptor.BaseRegister.Width == 5);

        if (indexRegisterOrImmediate is RegisterOperandDescriptor indexDesc)
        {
            Debug.Assert(indexDesc.IndexEncoding.Count ==  1);
            memoryOperandDescriptor.IndexRegisterOrImmediate.Add(indexDesc.IndexEncoding[0]);
            Debug.Assert(indexDesc.IndexEncoding[0].Width == 5);
        }
        else if (indexRegisterOrImmediate is ImmediateOperandDescriptor immediate)
        {
            memoryOperandDescriptor.IndexRegisterOrImmediate.AddRange(immediate.Encoding);
        }

        // Record memory operand
        var id = operand.ToString();
        if (!_memoryOperands.TryGetValue(id, out var instructions))
        {
            instructions = new List<Instruction>();
            _memoryOperands.Add(id, instructions);
        }
        instructions.Add(instruction);

        return memoryOperandDescriptor;

    }

    static Arm64MemoryExtendEncodingKind DetectMemoryExtendKind(Instruction instruction, OperandItem extend, OperandItem amount)
    {
        var extendSymbol = extend.TextElements[0].Symbol!;
        var amountSymbol = amount.TextElements[0].Symbol!;

        var extendBitRange = instruction.BitRangeMap[extendSymbol.BitInfos[0].Name];
        var amountBitRange = instruction.BitRangeMap[amountSymbol.BitInfos[0].Name];

        // The bits are always at the same location, so we don't need to encode them
        // But we just verify it here
        Debug.Assert(extendBitRange.HiBit == 15 && extendBitRange.Width == 3);
        Debug.Assert(amountBitRange.HiBit == 12 && amountBitRange.Width == 1);

        Arm64MemoryExtendEncodingKind extendKind = Arm64MemoryExtendEncodingKind.NoLsl;

        if (extendSymbol.BitValues.Count == 3)
        {
            extendKind = Arm64MemoryExtendEncodingKind.NoLsl;
        }
        else
        {
            Debug.Assert(extendSymbol.BitValues.Count == 4);
            Debug.Assert(amountSymbol.BitValues.Count == 2);
            Debug.Assert(amountSymbol.BitValues[0].Value == "#0"); // Always 0
            extendKind = amountSymbol.BitValues[1].Value switch
            {
                "#1" => Arm64MemoryExtendEncodingKind.Shift1,
                "#2" => Arm64MemoryExtendEncodingKind.Shift2,
                "#3" => Arm64MemoryExtendEncodingKind.Shift3,
                "#4" => Arm64MemoryExtendEncodingKind.Shift4,
                _ => throw new NotSupportedException($"Unsupported amount {amountSymbol.BitValues[1].Value}")
            };
        }

        return extendKind;
    }

    private static int CollectEncodingForSymbol(Instruction instruction, List<string> bitNames, List<BitRange> encoding)
    {
        int size = 0;
        foreach (var bitName in bitNames)
        {
            var bitRangeInfo = instruction.BitRangeMap[bitName];

            if (encoding.Count > 0)
            {
                var previousEncoding = encoding[^1];
                if (previousEncoding.HiBit - previousEncoding.Width == bitRangeInfo.HiBit)
                {
                    // Merge with previous encoding
                    encoding[^1] = new(previousEncoding.HiBit, previousEncoding.Width + bitRangeInfo.Width);
                    size += bitRangeInfo.Width;
                    continue;
                }
            }

            encoding.Add(new(bitRangeInfo.HiBit, bitRangeInfo.Width));
            size += bitRangeInfo.Width;
        }
        
        // We support a maximum of 3 bit-range encodings
        if (encoding.Count > 3)
        {
            throw new NotSupportedException($"Maximum number of encoding reached {encoding.Count} for instruction {instruction.Id} for symbol {string.Join(",", bitNames)}");
        }

        return size;
    }

    private static int CollectEncodingForSymbol(Instruction instruction, EncodingSymbol symbol, List<BitRange> encoding)
    {
        int size = 0;
        foreach (var encodingBitInfo in symbol.BitInfos)
        {
            var bitRangeInfo = instruction.BitRangeMap[encodingBitInfo.Name];

            if (encoding.Count > 0)
            {
                var previousEncoding = encoding[^1];
                if (previousEncoding.HiBit - previousEncoding.Width == bitRangeInfo.HiBit)
                {
                    // Merge with previous encoding
                    encoding[^1] = new(previousEncoding.HiBit, previousEncoding.Width + bitRangeInfo.Width);
                    size += bitRangeInfo.Width;
                    continue;
                }
            }

            encoding.Add(new(bitRangeInfo.HiBit, bitRangeInfo.Width));
            size += bitRangeInfo.Width;
        }

        // We support a maximum of 3 bit-range encodings
        if (encoding.Count > 3)
        {
            throw new NotSupportedException($"Maximum number of encoding reached {encoding.Count} for instruction {instruction.Id} for symbol {symbol}");
        }

        return size;
    }

    private void CollectEnumValues(EncodingSymbol symbol, Dictionary<string, int> enumToInt)
    {
        foreach (var keyVal in symbol.BitValues)
        {
            var value = keyVal.Value;
            if (value == "RESERVED" || keyVal.BitFields.Contains("x")) continue;

            var bitValue = keyVal.GetBitFieldsAsInt();

            if (!enumToInt.TryGetValue(value, out var previousValue))
            {
                enumToInt.Add(value, bitValue);
            }
            else
            {
                Debug.Assert(previousValue == bitValue);
            }
        }
    }

    private sealed class ByteListEqualityComparer : IEqualityComparer<List<byte>>
    {
        public static ByteListEqualityComparer Instance { get; } = new();

        public bool Equals(List<byte>? x, List<byte>? y)
        {
            if (x == null || y == null)
            {
                return x == y;
            }
            if (x.Count != y.Count)
            {
                return false;
            }
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] != y[i])
                {
                    return false;
                }
            }
            return true;

        }

        public int GetHashCode(List<byte> obj)
        {
            var hashCode = obj.Count;
            foreach (var b in obj)
            {
                hashCode = HashCode.Combine(hashCode, b);
            }
            return hashCode;
        }
    }
}
