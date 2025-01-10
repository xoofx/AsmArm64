// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
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

        //foreach (var operandSignature in operandSignatures.OrderBy(x => (int)x.Key))
        //{
        //    Console.WriteLine($"Operand kind: {operandSignature.Key}");
        //    foreach (var signature in operandSignature.Value.Order())
        //    {
        //        Console.WriteLine($"  {signature}");
        //    }
        //}
        
        //Console.WriteLine($"Max operand count: {maxOperandCount}");


        //foreach (var pair in _operandCountToInstructions.OrderByDescending(x => x.Key))
        //{
        //    Console.WriteLine($"Operand count: {pair.Key} -> {pair.Value.Count}");
        //}
    }
    
    public void ProcessRegisterKind()
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
                            var selectOperand = (SelectOperandItem)operand.Items[0];
                            ProcessSelectOperand(instruction, selectOperand);
                            break;
                        }
                        case OperandKind.Value:
                            break;
                        case OperandKind.Enum:
                            break;
                        case OperandKind.Group:
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
    }

    private OperandDescriptor ProcessSelectOperand(Instruction instruction, SelectOperandItem selectOperand)
    {
        Debug.Assert(selectOperand.Items.Count == 2);
        var item0 = selectOperand.Items[0];
        var name = item0.TextElements[0];
        var immediate = new ImmediateOperandDescriptor()
        {
            Kind = OperandDescriptorKind.Immediate,
            Name = name.Text,
        };

        if (item0.TextElements[0].Text == "systemreg")
        {
            // Select MRRS_rs_systemmovepr - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MRS_rs_systemmove - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MSR_sr_systemmove - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MSRR_sr_systemmovepr - (systemreg|Sop0_op1_Cn_Cm_op2)
            Debug.Assert(instruction.Id == "MRRS_rs_systemmovepr" || instruction.Id == "MRS_rs_systemmove" || instruction.Id == "MSR_sr_systemmove" || instruction.Id == "MSRR_sr_systemmovepr");

            immediate.ImmediateKind = ImmediateKind.SystemRegister;
            immediate.Size = CollectEncodingForSymbol(instruction, item0.TextElements[0].Symbol!, immediate.Encoding);

            return immediate;
        }
        else if (instruction.Id == "DMB_bo_barriers" || instruction.Id == "DSB_bo_barriers")
        {
            // Select DMB_bo_barriers - (option|#imm)
            // Select DSB_bo_barriers - (option|#imm)

            immediate.ImmediateKind = ImmediateKind.BarrierOperationLimit;
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

            immediate.ImmediateKind = ImmediateKind.PrefetchOperation;
            immediate.Size = CollectEncodingForSymbol(instruction, name.Symbol!, immediate.Encoding);
            CollectEnumValues(name.Symbol!, _prefetchOperationEnumValues);

            return immediate;
        }
        else if (instruction.Id == "RPRFM_r_ldst_regoff")
        {
            // Select RPRFM_r_ldst_regoff - (rprfop|#imm6)
            immediate.ImmediateKind = ImmediateKind.RangePrefetchOperation;
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

        OperandDescriptorKind kind;

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
                kind = isSP ? OperandDescriptorKind.RegXOrSP : OperandDescriptorKind.RegX;
                break;
            case 'W':
                kind = isSP ? OperandDescriptorKind.RegWOrWSP : OperandDescriptorKind.RegW;
                break;
            case 'B':
                kind = OperandDescriptorKind.RegB;
                break;
            case 'H':
                kind = OperandDescriptorKind.RegH;
                break;
            case 'S':
                kind = OperandDescriptorKind.RegS;
                break;
            case 'D':
                kind = OperandDescriptorKind.RegD;
                break;
            case 'V':
                if (indexOfIndexEncoding != 0 && elt0.Symbol is not null && elt0.Symbol.BitValues.Count > 0)
                {
                    // This is not a vector but a scalar register
                    kind = OperandDescriptorKind.DynamicRegVScalar;
                    dynamicDescriptor = ParseDynamicRegister(instruction, register);
                }
                else
                {
                    kind = OperandDescriptorKind.RegV;
                }
                break;
            case 'Q':
                kind = OperandDescriptorKind.RegQ;
                break;
            //case 'Z':
            //    kind = RegisterKind.Z;
            //    break;
            default:
                if (c == 'R')
                {
                    // Case of a dynamic X or W register
                    Debug.Assert(elt0.Symbol is not null);
                    kind = OperandDescriptorKind.DynamicRegXOrW;
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
            Kind = kind,
            DynamicRegisterXOrWSelector = dynamicDescriptor
        };

        var symbol = register.TextElements[indexOfIndexEncoding].Symbol;
        if (symbol is not null && symbol.BitInfos.Count > 0)
        {
            int size = CollectEncodingForSymbol(instruction, symbol, descriptor.IndexEncoding);

            if (symbol.BitValues.Count == 0 && (descriptor.IndexEncoding.Count == 1 && (size == 5 || size == 4)))
            {
                descriptor.RegisterIndexEncodingKind = size == 4
                    ? RegisterIndexEncodingKind.Regular4
                    : RegisterIndexEncodingKind.Regular5;
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
                    descriptor.RegisterIndexEncodingKind = RegisterIndexEncodingKind.SpecialMRm;
                    // We don't need to store the bit, as we know it is a special encoding
                    descriptor.IndexEncoding.Clear();
                }
            }
        }
        else
        {
            Debug.Assert(false, $"No encoding found for {instruction.Id}");
        }

        if (descriptor.Kind == OperandDescriptorKind.RegV && register.TextElements.Count > 1)
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
                "B" => OperandDescriptorKind.RegB,
                "S" => OperandDescriptorKind.RegS,
                "H" => OperandDescriptorKind.RegH,
                "D" => OperandDescriptorKind.RegD,
                "W" => OperandDescriptorKind.RegW,
                "X" => OperandDescriptorKind.RegX,
                "RESERVED" => OperandDescriptorKind.None,
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


    private static RegisterVArrangementKind ParseArrangementKind(string text)
    {
        switch (text)
        {
            case "16B":
                return RegisterVArrangementKind.T_16B;
            case "8B":
                return RegisterVArrangementKind.T_8B;
            case "4B":
                return RegisterVArrangementKind.T_4B;
            case "2B":
                return RegisterVArrangementKind.T_2B;
            case "2H":
                return RegisterVArrangementKind.T_2H;
            case "4H":
                return RegisterVArrangementKind.T_4H;
            case "8H":
                return RegisterVArrangementKind.T_8H;
            case "2S":
                return RegisterVArrangementKind.T_2S;
            case "4S":
                return RegisterVArrangementKind.T_4S;
            case "2D":
                return RegisterVArrangementKind.T_2D;
            case "1D":
                return RegisterVArrangementKind.T_1D;
            case "1Q":
                return RegisterVArrangementKind.T_1Q;
            case "T":
                return RegisterVArrangementKind.T;
            case "D":
                return RegisterVArrangementKind.D;
            case "H":
                return RegisterVArrangementKind.H;
            case "B":
                return RegisterVArrangementKind.B;
            case "S":
                return RegisterVArrangementKind.S;
            case "RESERVED":
                return RegisterVArrangementKind.Reserved;
            default:
                if (text.StartsWith("T"))
                {
                    return RegisterVArrangementKind.T;
                }
                else
                {
                    throw new NotSupportedException($"Unsupported arrangement `{text}`");
                }
        }
    }
    
    private GroupRegisterOperandDescriptor ProcessRegisterGroup(Instruction instruction, RegisterGroupOperandItem group)
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

        OperandDescriptorKind kind;
        switch (group.Items.Count)
        {
            case 1:
                kind = OperandDescriptorKind.MultiReg1;
                break;
            case 2:
                kind = OperandDescriptorKind.MultiReg2;
                break;
            case 3:
                kind = OperandDescriptorKind.MultiReg3;
                break;
            case 4:
                kind = OperandDescriptorKind.MultiReg4;
                break;
            default:
                throw new NotSupportedException(
                    $"Unsupported number of register groups {group.Items.Count}. Must be <= 4 for instruction {instruction.Id}");
                break;
        }

        var registerGroup = new GroupRegisterOperandDescriptor()
        {
            Kind = kind,
            Register = descriptors[0],
            Size = group.Items.Count,
        };

        return registerGroup;
    }

    private ImmediateOperandDescriptor ProcessImmediate(Instruction instruction, ImmediateOperandItem item)
    {
        var immediate = new ImmediateOperandDescriptor()
        {
            Kind = OperandDescriptorKind.Immediate,
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
                immediate.ImmediateKind = ImmediateKind.FixedFloatZero;
                immediate.FixedValue = 0;
            }
            else
            {
                immediate.ImmediateKind = ImmediateKind.FixedInt;
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
            immediate.ImmediateKind = ImmediateKind.Regular;

            if (symbol.BitValues.Count != 0)
            {
                var kind = $"[{string.Join(",", symbol.BitValues.Select(bitValue => $"{bitValue.BitFields[0]} = {bitValue.Value}"))}]";
                if (immediate.Size == 7 && immediate.Encoding[0] == new BitRange(22, 7) && symbol.BitValues.Count == 4 && symbol.BitValueNames.Count == 1 && symbol.BitValueNames[0] == "immh")
                {
                    switch (kind)
                    {
                        case "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]":
                            immediate.ImmediateKind = ImmediateKind.SimdBitShiftType0;
                            break;
                        case "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = RESERVED]":
                            immediate.ImmediateKind = ImmediateKind.SimdBitShiftType1;
                            break;
                        case "[0001 = RESERVED,001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]":
                            immediate.ImmediateKind = ImmediateKind.SimdBitShiftType2;
                            break;
                        case "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = RESERVED]":
                            immediate.ImmediateKind = ImmediateKind.SimdBitShiftType3;
                            break;
                        case "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = UInt(immh:immb) - 64]":
                            immediate.ImmediateKind = ImmediateKind.SimdBitShiftType4;
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
                            immediate.ImmediateKind = ImmediateKind.Rotate90Or270;
                            break;
                        case "[00 = 0,01 = 90,10 = 180,11 = 270]":
                            immediate.ImmediateKind = ImmediateKind.Rotate0Or90Or180Or270;
                            break;
                        default:
                            throw new NotSupportedException($"Unsupported immediate kind `{kind}` in instruction `{instruction.Id}`");
                    }
                }
                else if (symbol.BitValueNames.Count == 1 && symbol.BitValueNames[0] == "cmode<0>" && immediate.Encoding.Count == 1)
                {
                    Debug.Assert(immediate.Encoding[0] == new BitRange(15,4));
                    immediate.ImmediateKind = ImmediateKind.EnumAmount8Or16;
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
                    immediate.ImmediateKind = ImmediateKind.SimdLeftShift8Or16Or32;
                }
                else if (instruction.Id == "EXT_asimdext_only")
                {
                    // special immediate #index Size: 5 in instruction id EXT_asimdext_only - [(30:1),(14:4)] - Selector: Q,imm4<3>
                    // 0:0 = UInt(imm4<2:0>)
                    // 0:1 = RESERVED
                    // 1:x = UInt(imm4)
                    immediate.Encoding.Clear();
                    immediate.Size = 0;
                    immediate.ImmediateKind = ImmediateKind.SimdExtIndex;
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
                        immediate.ImmediateKind = ImmediateKind.Imm64;
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

        MemoryOperandKind kind;
        var extendKind = MemoryOperandExtendKind.NoLsl;
        sbyte fixedValue = 0;

        // 1 [Xd]!
        // 1 [Xn|SP]
        // 1 [Xs]!
        if (items.Count == 1)
        {
            kind = MemoryOperandKind.BaseRegisterXn;
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
                kind = immediate.FixedValue != 0 ? MemoryOperandKind.BaseRegisterAndFixedImmediate : MemoryOperandKind.BaseRegisterXnOrSPAndImmediate;
                fixedValue = immediate.FixedValue;
            }
            else if (imm.Kind == OperandItemKind.Group)
            {
                var group = (GroupOperandItem)imm;
                Debug.Assert(group.Items.Count == 1);
                immediate = ProcessImmediate(instruction, (ImmediateOperandItem)group.Items[0]);
                kind = MemoryOperandKind.BaseRegisterAndImmediateOptional;
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
                kind = MemoryOperandKind.BaseRegisterAndIndexXmAndLslAmount;
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
                kind = MemoryOperandKind.BaseRegisterAndIndexWmOrXmAndExtendAndAmount;
                indexRegisterOrImmediate = firstReg;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Unsupported operand `{operand}` in {instruction.Id}");
            }

            // Examples:

            if (items.Count == 3)
            {
                var item2 = (GroupOperandItem)items[2];
                
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
                    var amount = ((GroupOperandItem)item2.Items[1]).Items[0];
                    extendKind = DetectExtendKind(instruction, extend, amount);
                }
            }
            else
            {
                // Addressing [Xn|SP,(Wm|Xm),extend{,amount}]
                // LDRSB_64b_ldst_regoff
                // LDRSB       Xt, [Xn|SP, (Wm|Xm), extend{, amount}]

                var extend = items[2];
                var amount = ((GroupOperandItem)items[3]).Items[0];
                extendKind = DetectExtendKind(instruction, extend, amount);
            }
        }
        else
        {
            throw new NotSupportedException($"Unsupported number of memory items {items.Count}");
        }

        var memoryOperandDescriptor = new MemoryOperandDescriptor()
        {
            Kind = OperandDescriptorKind.Memory,
            MemoryOperandKind = kind,
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

    static MemoryOperandExtendKind DetectExtendKind(Instruction instruction, OperandItem extend, OperandItem amount)
    {
        var extendSymbol = extend.TextElements[0].Symbol!;
        var amountSymbol = amount.TextElements[0].Symbol!;

        var extendBitRange = instruction.BitRangeMap[extendSymbol.BitInfos[0].Name];
        var amountBitRange = instruction.BitRangeMap[amountSymbol.BitInfos[0].Name];

        Debug.Assert(extendBitRange.HiBit == 15 && extendBitRange.Width == 3);
        Debug.Assert(amountBitRange.HiBit == 12 && amountBitRange.Width == 1);

        MemoryOperandExtendKind extendKind = MemoryOperandExtendKind.NoLsl;

        if (extendSymbol.BitValues.Count == 3)
        {
            extendKind = MemoryOperandExtendKind.NoLsl;
        }
        else
        {
            Debug.Assert(extendSymbol.BitValues.Count == 4);
            Debug.Assert(amountSymbol.BitValues.Count == 2);
            extendKind = amountSymbol.BitValues[1].Value switch
            {
                "#1" => MemoryOperandExtendKind.Shift1,
                "#2" => MemoryOperandExtendKind.Shift2,
                "#3" => MemoryOperandExtendKind.Shift3,
                "#4" => MemoryOperandExtendKind.Shift4,
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
}
