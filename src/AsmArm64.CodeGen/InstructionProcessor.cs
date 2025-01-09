// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;
using AsmArm64.CodeGen.Model;
using Microsoft.Win32;

namespace AsmArm64.CodeGen;

internal sealed class InstructionProcessor
{
    private readonly InstructionSet _instructionSet;
    private readonly List<Instruction> _instructions;
    private readonly Dictionary<string, (VectorArrangementValues Values, HashSet<string> Variations, int Count)> _vectorArrangementItemsUsage = new();


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
        }

        foreach (var operandSignature in operandSignatures.OrderBy(x => (int)x.Key))
        {
            Console.WriteLine($"Operand kind: {operandSignature.Key}");
            foreach (var signature in operandSignature.Value.Order())
            {
                Console.WriteLine($"  {signature}");
            }
        }
        
        Console.WriteLine($"Max operand count: {maxOperandCount}");
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
            foreach (var operand in instruction.Operands)
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
                    case OperandKind.Memory:
                    {
                        //Console.WriteLine($"  ----- {operand}");
                        //foreach (var operandItem in operand.Items)
                        //{
                        //    if (operandItem.Kind == OperandItemKind.Register)
                        //    {
                        //        var register = (RegisterOperandItem)operandItem;
                        //        ProcessRegister(instruction, register);
                        //        Console.WriteLine($"  {operandItem.ToString()} -> {descriptor}");
                        //    }
                        //    else if (operandItem.Kind == OperandItemKind.Select)
                        //    {
                        //        Console.WriteLine($"  {operandItem.ToString()} - (SELECT)");

                        //        foreach (var innerOperandItem in ((SelectOperandItem)operandItem).Items)
                        //        {
                        //            if (innerOperandItem.Kind == OperandItemKind.Register)
                        //            {
                        //                var register = (RegisterOperandItem)innerOperandItem;
                        //                ProcessRegister(instruction, register);
                        //                Console.WriteLine($"      {innerOperandItem.ToString()} -> {descriptor}");
                        //            }
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine($"  {operandItem.ToString()}");
                        //    }

                        //}

                        break;
                    }
                }
            }
        }

        foreach (var vectorArrangementItems in _vectorArrangementItemsUsage.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            var values = vectorArrangementItems.Value.Values;
            values.Index = _instructionSet.VectorArrangementValues.Count;

            Console.WriteLine($"[{values.Index}] VectorArrangement {vectorArrangementItems.Key} - {values}");
            foreach (var variation in vectorArrangementItems.Value.Variations.Order())
            {
                Console.WriteLine($"  {variation}");
            }
            _instructionSet.VectorArrangementValues.Add(values);
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
                    Console.WriteLine(errorMessage);
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

        Console.WriteLine($"{instruction.Id} {item} => Indexer {symbol}");
        
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

        return size;
    }
}
