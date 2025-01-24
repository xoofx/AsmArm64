// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

/// <summary>
/// This class is responsible for refining the operands of instructions parsed from the ARM XML files for precise encoding in an encoding table.
/// </summary>
internal sealed class InstructionProcessor
{
    private readonly InstructionSet _instructionSet;
    private readonly HashSet<string> _systemRegisterKinds;
    private readonly List<Instruction> _instructions;
    private readonly Dictionary<string, List<Instruction>> _memoryOperands = new();
    private readonly Dictionary<int, List<Instruction>> _operandCountToInstructions = new();

    internal readonly Dictionary<string, int> PrefetchOperationEnumValues = new();
    internal readonly Dictionary<string, int> RangePrefetchOperationEnumValues = new();

    private readonly EncodingSymbolExtractMap _vectorArrangements;
    private readonly EncodingSymbolExtractMap _dynamicRegisterSelectors;
    private readonly EncodingSymbolExtractMap _indexers;
    private readonly EncodingSymbolExtractMap _immediates;
    private readonly EncodingSymbolExtractMap _processStateFields;
    private readonly EncodingSymbolExtractMap _registerIndex;

    private bool _hasErrors;

    public InstructionProcessor(InstructionSet instructionSet, HashSet<string> systemRegisterKinds)
    {
        _instructionSet = instructionSet;
        _systemRegisterKinds = systemRegisterKinds;
        _instructions = instructionSet.Instructions;
        InstructionEncodingBuffer = new MemoryStream();

        _vectorArrangements = _instructionSet.GetOrCreateExtractMap(EncodingSymbolExtractMapKind.VectorArrangement);
        _dynamicRegisterSelectors = _instructionSet.GetOrCreateExtractMap(EncodingSymbolExtractMapKind.DynamicRegister);
        _indexers = _instructionSet.GetOrCreateExtractMap(EncodingSymbolExtractMapKind.Indexer);
        _immediates = _instructionSet.GetOrCreateExtractMap(EncodingSymbolExtractMapKind.Immediate);
        _processStateFields = _instructionSet.GetOrCreateExtractMap(EncodingSymbolExtractMapKind.ProcessStateField);
        _registerIndex = _instructionSet.GetOrCreateExtractMap(EncodingSymbolExtractMapKind.RegisterIndex);
    }

    public List<int> InstructionEncodingOffsets { get; } = new();

    public MemoryStream InstructionEncodingBuffer { get; }

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

    public void Run()
    {
        // Order instructions by their id
        //_instructions.Sort((a, b) => string.Compare(a.Id, b.Id, StringComparison.Ordinal));

        // Assign ids and collect mnemonics
        for (int i = 0; i < _instructions.Count; i++)
        {
            var instruction = _instructions[i];
            if (!_instructionSet.OrderedMnemonics.Contains(instruction.Mnemonic))
            {
                _instructionSet.OrderedMnemonics.Add(instruction.Mnemonic);
            }

            if (!_instructionSet.OrderedInstructionClass.Contains(instruction.InstructionClass))
            {
                _instructionSet.OrderedInstructionClass.Add(instruction.InstructionClass);
            }
        }

        // Assign mnemonics
        _instructionSet.OrderedMnemonics.Sort();
        _instructionSet.OrderedInstructionClass.Sort();
        foreach (var instruction in _instructions)
        {
            instruction.MnemonicIndex = _instructionSet.OrderedMnemonics.IndexOf(instruction.Mnemonic) + 1;
            instruction.InstructionClassIndex = (byte)(_instructionSet.OrderedInstructionClass.IndexOf(instruction.InstructionClass) + 1);
        }

        Span<byte> buffer = stackalloc byte[8];
        buffer.Clear();

        // First instruction (index) is null
        RecordInstructionBufferOffset();
        Write(buffer);

        foreach (var instruction in _instructions)
        {
            //if (instruction.IsSystem)
            //{
            //    if (_systemRegisterKinds.Contains(instruction.Mnemonic))
            //    {
            //        Console.WriteLine($"SYS {instruction.Id} - {instruction.FullSyntax}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"SYSTEM {instruction.Id} - {instruction.FullSyntax}");
            //    }
            //}
            
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
                                Debug.Assert(operand.Items.Count == 1);
                                operand.Descriptor = ProcessConstAndImmediate(instruction, (ConstAndImmediateOperandItem)operand.Items[0]);
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
                            operand.Descriptor = ProcessValue(instruction, selectedValue);
                            break;
                        case OperandKind.Enum:
                            Debug.Assert(operand.Items.Count == 1);
                            var enumOperand = (EnumOperandItem)operand.Items[0];
                            operand.Descriptor = ProcessEnum(instruction, enumOperand);
                            break;
                        case OperandKind.OptionalGroup:
                            Debug.Assert(operand.Items.Count == 1);
                            var optionalGroup = (OptionalGroupOperandItem)operand.Items[0];
                            operand.Descriptor = ProcessOptionalGroup(instruction, optionalGroup);
                            break;
                        case OperandKind.Const:
                            Debug.Assert(operand.Items.Count == 1);
                            var constOperand = (ConstOperandItem)operand.Items[0];
                            operand.Descriptor = ProcessConst(instruction, constOperand);
                            break;
                        default:
                            throw new InvalidOperationException($"Operand kind not supported {operand.Kind}");
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

        // Sort the indexers at the end and order them by their id to make them easier to read
        _instructionSet.AssignExtraMapIndices();

        //Console.WriteLine($"Vector Arrangements: {vectorArrangements.Count}");

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

        EncodeInstructions();
    }

    private void EncodeInstructions()
    {
        Span<byte> buffer = stackalloc byte[8];
        Span<byte> allOperands = new byte[8 * 16]; // 16 operands max (should be much lower, like 5)
        foreach (var instruction in _instructions)
        {
            allOperands.Clear();

            // Encode the operands locally
            for (var operandIndex = 0; operandIndex < instruction.Operands.Count; operandIndex++)
            {
                var operand = instruction.Operands[operandIndex];
                // Encode the operand
                operand.Descriptor!.Encode(allOperands.Slice(operandIndex * 8, 8));
            }

            // Detect if operands can be all encoded into uint
            var spanULong = MemoryMarshal.Cast<byte, ulong>(allOperands);
            instruction.UseOperandEncoding8Bytes = instruction.Operands.Count == 0;
            for (int i = 0; i < instruction.Operands.Count; i++)
            {
                var value = spanULong[i];
                if (value > uint.MaxValue)
                {
                    instruction.UseOperandEncoding8Bytes = true;
                    break;
                }
            }

            // Encode the instruction decoding
            RecordInstructionBufferOffset();
            buffer.Clear();
            instruction.Encode(buffer);
            Write(buffer);
            
            // Encode vector arrangement indices
            // Encode the operands
            var encodingSize = instruction.UseOperandEncoding8Bytes ? 8 : 4;
            for (int i = 0; i < instruction.Operands.Count; i++)
            {
                Write(allOperands.Slice(i * 8, encodingSize));
            }
        }
    }

    private void Write(ReadOnlySpan<byte> buffer)
    {
        Debug.Assert(buffer.Length == 8 || buffer.Length == 4);
        InstructionEncodingBuffer.Write(buffer);
    }

    private void RecordInstructionBufferOffset()
    {
        // Position of an instruction is always at least a multiple of 4
        Debug.Assert(InstructionEncodingBuffer.Position % 4 == 0);
        InstructionEncodingOffsets.Add((int)InstructionEncodingBuffer.Position);
    }

    private OperandDescriptor ProcessConst(Instruction instruction, ConstOperandItem constOperand)
    {
        var text = constOperand.TextElements[0].Text;
        if (text == "X16")
        {
            var registerDescriptor = new RegisterOperandDescriptor()
            {
                Name = text,
                RegisterKind = Arm64RegisterEncodingKind.X,
                RegisterIndexEncodingKind = Arm64RegisterIndexEncodingKind.Fixed,
                FixedRegisterIndex = 16,
            };
            return registerDescriptor;
        }
        
        var enumDescriptor = new EnumOperandDescriptor()
        {
            Name = text,
        };
        switch (text)
        {
            case "CSYNC":
                enumDescriptor.EnumKind = Arm64EnumKind.CodeSync;
                break;
            case "DSYNC":
                enumDescriptor.EnumKind = Arm64EnumKind.DataSync;
                break;
            case "RCTX":
                enumDescriptor.EnumKind = Arm64EnumKind.RestrictionByContext;
                break;
            default:
                throw new NotSupportedException($"Unsupported const enum {text}");
        }

        return enumDescriptor;
    }

    private OperandDescriptor? ProcessConstAndImmediate(Instruction instruction, ConstAndImmediateOperandItem operandItem)
    {
        var name0 = operandItem.TextElements[0].Text;

        if (name0 == "MSL")
        {
            Debug.Assert(operandItem.TextElements[1].Text == " #");

            var shiftOperandDescriptor = new ShiftOperandDescriptor()
            {
                Name = name0,
                ShiftKind = Arm64ShiftEncodingKind.Msl,
            };

            var symbol = operandItem.TextElements[2].Symbol;
            Debug.Assert(symbol is not null);

            Debug.Assert(symbol.BitRanges.Count == 1);
            shiftOperandDescriptor.AmountEncoding = symbol.BitRanges[0];
            Debug.Assert(symbol.Selector is not null && symbol.Selector.BitValues.Count == 2);
            // TODO
            //Debug.Assert(symbol.BitValues.Count == 2 && symbol.BitValues[0].Text == "8" && symbol.BitValues[1].Text == "16");

            return shiftOperandDescriptor;
        }

        throw new InvalidOperationException($"Unsupported const and immediate operand `{operandItem}`");
    }

    private static readonly HashSet<string> enums = new();

    private OperandDescriptor? ProcessEnum(Instruction instruction, EnumOperandItem enumOperand)
    {
        var elt0 = enumOperand.TextElements[0];
        var name0 = elt0.Text;
        var symbol0 = elt0.Symbol!;

        if (name0 == "cond" || name0 == "condlabel")
        {
            var enumOperandDescriptor = new EnumOperandDescriptor()
            {
                EnumKind = Arm64EnumKind.Conditional,
                Name = name0,
                BitSize = symbol0.BitSize,
            };

            Debug.Assert(symbol0.BitSize == 4);
            Debug.Assert(symbol0.BitRanges.Count == 1);
            enumOperandDescriptor.EnumEncoding = symbol0.BitRanges[0];

            return enumOperandDescriptor;
        }
        else if (name0 == "invcond")
        {
            var enumOperandDescriptor = new EnumOperandDescriptor()
            {
                EnumKind = Arm64EnumKind.InvertedConditional,
                Name = name0,
                BitSize = symbol0.BitSize,
            };

            Debug.Assert(symbol0.BitSize == 4);
            Debug.Assert(symbol0.BitRanges.Count == 1);
            enumOperandDescriptor.EnumEncoding = symbol0.BitRanges[0];

            return enumOperandDescriptor;
        }
        else if (instruction.Id == "DSB_bon_barriers")
        {
            var enumOperandDescriptor = new EnumOperandDescriptor
            {
                EnumKind = Arm64EnumKind.DataSynchronizationOption,
                Name = name0,
                BitSize = symbol0.BitSize,
            };
            Debug.Assert(symbol0.BitSize == 2);
            Debug.Assert(symbol0.BitRanges.Count == 1);
            enumOperandDescriptor.EnumEncoding = symbol0.BitRanges[0];

            return enumOperandDescriptor;
        }
        else if (instruction.Id == "STSHH_hi_hints")
        {
            var enumOperandDescriptor = new EnumOperandDescriptor
            {
                EnumKind = Arm64EnumKind.StoredSharedHintPolicy,
                Name = name0,
                BitSize = symbol0.BitSize,
            };
            Debug.Assert(symbol0.BitSize == 1);
            Debug.Assert(symbol0.BitRanges.Count == 1);
            enumOperandDescriptor.EnumEncoding = symbol0.BitRanges[0];

            return enumOperandDescriptor;
        }
        else if (instruction.Id == "MSR_si_pstate")
        {
            var enumOperandDescriptor = new EnumOperandDescriptor()
            {
                Name = name0,
                EnumKind = Arm64EnumKind.ProcessStateField,
            };
            enumOperandDescriptor.BitMapExtract = _processStateFields.GetOrCreateExtract<EncodingSymbolExtract>(symbol0);
            enumOperandDescriptor.BitMapExtract.Usages.Add((instruction, enumOperand));

            // Console.WriteLine($"{instruction.Id} {instruction.FullSyntax}");
            return enumOperandDescriptor;
        }
        else if (instruction.IsSystem)
        {
            var systemRegisterDesc = new SystemRegisterOperandDescriptor()
            {
                Name = name0,
            };
            
            Debug.Assert(instruction.Alias is not null);
            Debug.Assert(instruction.Alias.InstructionId == "SYS_cr_systeminstrs" || instruction.Alias.InstructionId == "SYSP_cr_syspairinstrs");

            var lookupResult = Arm64Processor.RegisteredSystemRegisterUsageKinds.TryGetValue(instruction.Mnemonic, out var kindIndex);
            Debug.Assert(lookupResult, "System register kind was not found");

            systemRegisterDesc.SystemRegisterKindIndex = (byte)kindIndex;
            systemRegisterDesc.Encoding = new BitRange(5, 16);

            // TODO: Add kind

            return systemRegisterDesc;
        }
        else
        {
            var enumOperandDescriptor = new EnumOperandDescriptor()
            {
                Name = name0,
                EnumKind = Arm64EnumKind.None,
            };

            Console.WriteLine($"Enum to support {enumOperand} - {instruction.Id}");
            return enumOperandDescriptor;
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

        if (items.All(x => x.Kind == OperandItemKind.Register))
        {
            Debug.Assert(items.Count == 1 || items.Count == 2);
            var descriptor1 = ProcessRegister(instruction, (RegisterOperandItem)items[0]);
            bool isPaired = false;

            if (items.Count == 2)
            {
                var descriptor2 = ProcessRegister(instruction, (RegisterOperandItem)items[1]);
                Debug.Assert(descriptor1.IsSimpleEncoding && descriptor2.IsSimpleEncoding && descriptor1.LowBitIndexEncoding == descriptor2.LowBitIndexEncoding);
                isPaired = true;
            }

            descriptor1.IsOptional = true;
            descriptor1.IsPaired = isPaired;

            return descriptor1;
        }
        else if (items.Count == 1)
        {
            if ((instruction.Id == "SMSTART_msr_si_pstate" || instruction.Id == "SMSTOP_msr_si_pstate") && name0 == "option")
            {
                var desc = new EnumOperandDescriptor()
                {
                    EnumKind = Arm64EnumKind.None,
                    Name = name0,
                    IsOptional = true,
                };

                Console.WriteLine($"TODO support {{option}} for {instruction.Id}");
                return desc;
            }
            if (name0 == "shift")
            {
                Debug.Assert(symbol0 is not null && symbol0.Selector is not null && symbol0.Selector.BitValues.Count == 2 && symbol0.Selector.BitValues[0].Text == "LSL #0" && symbol0.Selector.BitValues[1].Text == "LSL #12");

                var shiftOperandDescriptor = new ShiftOperandDescriptor()
                {
                    Name = name0,
                    ShiftKind = Arm64ShiftEncodingKind.Fixed,
                    IsOptional = true,
                };

                Debug.Assert(symbol0.BitSize == 1);
                Debug.Assert(symbol0.BitRanges.Count == 1);
                shiftOperandDescriptor.ShiftEncoding = symbol0.BitRanges[0];

                return shiftOperandDescriptor;
            }
            else if (name0 == "LSL")
            {
                var shiftOperandDescriptor = new ShiftOperandDescriptor()
                {
                    Name = name0,
                    ShiftKind = Arm64ShiftEncodingKind.Lsl,
                    IsOptional = true,
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

                        Debug.Assert(symbol.BitRanges.Count == 1);
                        shiftOperandDescriptor.AmountEncoding = symbol.BitRanges[0];

                        // Detect if Lsl is scaled by 8
                        if (symbol.Selector is not null)
                        {
                            var bitValues = symbol.Selector.BitValues;
                            for (int i = 0; i < bitValues.Count; i++)
                            {
                                var expectedBitValue = i * 8;
                                var bitValue = bitValues[i];
                                Debug.Assert(expectedBitValue == bitValue.IntegerValue);
                            }
                            shiftOperandDescriptor.ShiftKind = Arm64ShiftEncodingKind.LslScale8;
                        }
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
                Debug.Assert(symbol0 is not null);
                Debug.Assert(symbol0.BitRanges.Count == 1);

                var bti = new EnumOperandDescriptor()
                {
                    EnumKind = Arm64EnumKind.BranchTargetIdentification,
                    Name = name0,
                    IsOptional = true,
                    EnumEncoding = symbol0.BitRanges[0]
                };

                Debug.Assert(bti.EnumEncoding == new BitRange(6, 2));

                return bti;
            }
            else if (name0 == "imm")
            {
                var imm = ProcessImmediate(instruction, items[0]);
                imm.IsOptional = true;
                return imm;
            }
        }
        else if (items.Count == 2)
        {
            var item1 = items[1];

            if (name0 == "extend")
            {
                // extend, {amount}

                Debug.Assert(symbol0 is not null);
                Debug.Assert(symbol0.Selector is not null && symbol0.Selector.BitValues.Count == 8 && symbol0.Selector.BitValues[0].Text == "UXTB" && symbol0.Selector.BitValues[^1].Text == "SXTX");

                var extend = new ExtendOperandDescriptor()
                {
                    Name = name0,
                    IsOptional = true,
                };

                Debug.Assert(symbol0.BitRanges.Count == 1);
                extend.ExtendEncoding = symbol0.BitRanges[0];

                var amountSymbol = ((OptionalGroupOperandItem)item1).Items[0].TextElements[0].Symbol!;
                Debug.Assert(amountSymbol.BitRanges.Count == 1);
                extend.AmountEncoding = amountSymbol.BitRanges[0];
                //extend.Is64Bit
                int indexOfLSL = symbol0.Selector.BitValues.FindIndex(x => x.Text.Contains("LSL"));
                Debug.Assert(indexOfLSL >= 0);
                var extendText = symbol0.Selector.BitValues[indexOfLSL].Text;
                Debug.Assert(extendText == "LSL|UXTW" || extendText == "LSL|UXTX");
                extend.Is64Bit = extendText == "LSL|UXTX";
                return extend;
            }
            else if (name0 == "shift")
            {
                Debug.Assert(symbol0 is not null);
                var shiftOperandDescriptor = new ShiftOperandDescriptor()
                {
                    ShiftKind = Arm64ShiftEncodingKind.Shift3,
                    Name = name0,
                    IsOptional = true,
                };

                Debug.Assert(symbol0 is not null && symbol0.Selector is not null && symbol0.Selector.BitValues.Count >= 3 && symbol0.Selector.BitValues[0].Text == "LSL" && symbol0.Selector.BitValues[1].Text == "LSR" && symbol0.Selector.BitValues[2].Text == "ASR" && (symbol0.Selector.BitValues.Count == 3 || symbol0.Selector.BitValues[3].Text == "ROR"));

                shiftOperandDescriptor.ShiftKind = symbol0.Selector.BitValues.Count == 3 ? Arm64ShiftEncodingKind.Shift3 : Arm64ShiftEncodingKind.Shift4;

                Debug.Assert(symbol0.BitSize == 2);
                Debug.Assert(symbol0.BitRanges.Count == 1);
                shiftOperandDescriptor.ShiftEncoding = symbol0.BitRanges[0];

                var amountSymbol = item1.TextElements[0].Symbol;
                Debug.Assert(amountSymbol is not null);

                Debug.Assert(amountSymbol.BitRanges.Count == 1);
                shiftOperandDescriptor.AmountEncoding = amountSymbol.BitRanges[0];
                Debug.Assert(amountSymbol.Selector is null);

                return shiftOperandDescriptor;
            }
            else if (name0 == "option")
            {
                var isbOption = new ImmediateOperandDescriptor()
                {
                    ImmediateKind = Arm64ImmediateEncodingKind.IsbOption,
                    Name = name0,
                    IsOptional = true,
                };

                var optionSymbol = item1.TextElements[0].Symbol;
                Debug.Assert(optionSymbol is not null);
                Debug.Assert(optionSymbol.BitSize == 4);
                Debug.Assert(optionSymbol.BitRanges.Count == 1);
                isbOption.BitSize = optionSymbol.BitSize;
                isbOption.Encoding.Add(optionSymbol.BitRanges[0]);

                Console.WriteLine(optionSymbol.Selector);

                return isbOption;
            }
        }

        throw new InvalidOperationException($"Unsupported optional group `{optionalGroup}`");
    }

    /// <summary>
    /// List of identified labels kind for instruction. I was not able to find a better way to identify them from the XML file.
    /// </summary>
    private static readonly Dictionary<string, Arm64LabelEncodingKind> InstructionIdToLabelOffsetKind = new()
    {
        { "ADR_only_pcreladdr", Arm64LabelEncodingKind.StandardOffset },
        { "ADRP_only_pcreladdr", Arm64LabelEncodingKind.PageOffset },
        { "AUTIASPPC_only_dp_1src_imm", Arm64LabelEncodingKind.NegativeEncodedAsUnsigned },
        { "AUTIBSPPC_only_dp_1src_imm", Arm64LabelEncodingKind.NegativeEncodedAsUnsigned },
        { "B_only_branch_imm", Arm64LabelEncodingKind.StandardOffset },
        { "BL_only_branch_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBBEQ_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBGE_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBGT_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBHI_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBHS_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBNE_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBEQ_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBEQ_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBEQ_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBEQ_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBGE_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBGE_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBGT_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBGT_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBGT_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBGT_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHEQ_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHGE_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHGT_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHHI_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHHS_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHI_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBHI_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHI_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBHI_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHNE_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHS_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHS_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLO_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLO_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLT_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLT_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBNE_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBNE_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBNE_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBNE_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBNZ_32_compbranch", Arm64LabelEncodingKind.StandardOffset },
        { "CBNZ_64_compbranch", Arm64LabelEncodingKind.StandardOffset },
        { "CBZ_32_compbranch", Arm64LabelEncodingKind.StandardOffset },
        { "CBZ_64_compbranch", Arm64LabelEncodingKind.StandardOffset },
        { "LDR_32_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "LDR_64_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "LDR_d_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "LDR_q_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "LDR_s_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "LDRSW_64_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "PRFM_p_loadlit", Arm64LabelEncodingKind.StandardOffset },
        { "RETAASPPC_only_miscbranch", Arm64LabelEncodingKind.NegativeEncodedAsUnsigned },
        { "RETABSPPC_only_miscbranch", Arm64LabelEncodingKind.NegativeEncodedAsUnsigned },
        { "TBNZ_only_testbranch", Arm64LabelEncodingKind.StandardOffset },
        { "TBZ_only_testbranch", Arm64LabelEncodingKind.StandardOffset },
        { "CBBLE_cbbge_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBLO_cbbhi_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBLS_cbbhs_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBBLT_cbbgt_8_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBGE_cbgt_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBGE_cbgt_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBHLE_cbhge_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHLO_cbhhi_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHLS_cbhhs_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHLT_cbhgt_16_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBHS_cbhi_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBHS_cbhi_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLE_cblt_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLE_cblt_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLE_cbge_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLE_cbge_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLO_cbhi_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLO_cbhi_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLS_cblo_32_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLS_cblo_64_imm", Arm64LabelEncodingKind.StandardOffset },
        { "CBLS_cbhs_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLS_cbhs_64_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLT_cbgt_32_regs", Arm64LabelEncodingKind.StandardOffset },
        { "CBLT_cbgt_64_regs", Arm64LabelEncodingKind.StandardOffset },
    };

    private OperandDescriptor ProcessValue(Instruction instruction, ValueOperandItem selectedValue)
    {
        var name = selectedValue.TextElements[0].Text;
        var symbol = selectedValue.TextElements[0].Symbol;
        Debug.Assert(symbol is not null);

        var selector = symbol.Selector;
        if (name == "label")
        {
            Debug.Assert(selector is null);

            if (!InstructionIdToLabelOffsetKind.TryGetValue(instruction.Id, out var labelOffsetKind))
            {
                labelOffsetKind = Arm64LabelEncodingKind.StandardOffset;
                Console.WriteLine($"Unsupported label kind for instruction {instruction.Id}");
                _hasErrors = true;
            }

            var immediate = ProcessImmediate(instruction, selectedValue);

            var label = new LabelOperandDescriptor
            {
                LabelKind = labelOffsetKind,
                Name = name,
                BitSize = immediate.BitSize
            };

            label.Encoding.AddRange(immediate.Encoding);

            return label;
        }
        else if (selector is not null)
        {
            return ProcessImmediate(instruction, selectedValue);
        }
        else
        {
            Debug.Assert(false, $"Operand {selectedValue} is not supported in instruction {instruction.Id}. Symbol: {symbol}");
        }

        throw new InvalidOperationException($"Value {selectedValue} not supported");
    }

    private OperandDescriptor ProcessSelectOperand(Instruction instruction, SelectOperandItem selectOperand)
    {
        Debug.Assert(selectOperand.Items.Count == 2);
        var item0 = selectOperand.Items[0];
        var name = item0.TextElements[0];

        if (item0.TextElements[0].Text == "systemreg")
        {
            // Select MRRS_rs_systemmovepr - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MRS_rs_systemmove - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MSR_sr_systemmove - (systemreg|Sop0_op1_Cn_Cm_op2)
            // Select MSRR_sr_systemmovepr - (systemreg|Sop0_op1_Cn_Cm_op2)
            Debug.Assert(instruction.Id == "MRRS_rs_systemmovepr" || instruction.Id == "MRS_rs_systemmove" || instruction.Id == "MSR_sr_systemmove" || instruction.Id == "MSRR_sr_systemmovepr");

            var systemRegister = new SystemRegisterOperandDescriptor()
            {
                Name = name.Text,
            };

            var lookupResult = Arm64Processor.RegisteredSystemRegisterUsageKinds.TryGetValue(instruction.Mnemonic, out var kindIndex);
            Debug.Assert(lookupResult, $"Invalid instruction {instruction.Id} / {instruction.Mnemonic} not a system register");

            systemRegister.SystemRegisterKindIndex = (byte)kindIndex;
            var immediate = ProcessImmediate(instruction, selectOperand.Items[0]);
            Debug.Assert(immediate.Encoding.Count == 1);
            Debug.Assert(immediate.Encoding[0] == new BitRange(5, 15));
            systemRegister.Encoding = new BitRange(5, 16); // We want 16 bits, not just 15 bits

            return systemRegister;
        }
        else if (instruction.Id == "DMB_bo_barriers" || instruction.Id == "DSB_bo_barriers")
        {
            // Select DMB_bo_barriers - (option|#imm)
            // Select DSB_bo_barriers - (option|#imm)
            var enumDesc = new EnumOperandDescriptor()
            {
                EnumKind = Arm64EnumKind.BarrierOperationLimit,
                Name = name.Text,
                AllowImmediate = true,
            };

            enumDesc.BitSize = name.Symbol!.BitSize;
            Debug.Assert(name.Symbol!.BitRanges.Count == 1);
            enumDesc.EnumEncoding = name.Symbol!.BitRanges[0];
            
            return enumDesc;
        }
        else if (instruction.Id == "PRFM_p_ldst_pos" || instruction.Id == "PRFM_p_loadlit" || instruction.Id == "PRFM_p_ldst_regoff" || instruction.Id == "PRFUM_p_ldst_unscaled")
        {
            // Select PRFM_p_ldst_pos - (prfop|#imm5)
            // Select PRFM_p_loadlit - (prfop|#imm5)
            // Select PRFM_p_ldst_regoff - (prfop|#imm5)
            // Select PRFUM_p_ldst_unscaled - (prfop|#imm5)
            var enumDesc = new EnumOperandDescriptor()
            {
                EnumKind = Arm64EnumKind.PrefetchOperation,
                Name = name.Text,
                AllowImmediate = true,
            };

            enumDesc.BitSize = name.Symbol!.BitSize;
            Debug.Assert(name.Symbol!.BitRanges.Count == 1);
            enumDesc.EnumEncoding = name.Symbol!.BitRanges[0];

            CollectEnumValues(name.Symbol!, PrefetchOperationEnumValues);

            return enumDesc;
        }
        else if (instruction.Id == "RPRFM_r_ldst_regoff")
        {
            // Select RPRFM_r_ldst_regoff - (rprfop|#imm6)
            var enumDesc = new EnumOperandDescriptor()
            {
                EnumKind = Arm64EnumKind.RangePrefetchOperation,
                Name = name.Text,
                AllowImmediate = true,
            };

            enumDesc.BitSize = name.Symbol!.BitSize;

            CollectEnumValues(name.Symbol!, RangePrefetchOperationEnumValues);
            return enumDesc;
        }
        else
        {
            var imm = selectOperand.Items[1].TextElements[0];
            Console.WriteLine($"Unsupported Select instruction {instruction.Id} - {selectOperand} -> ({name.Text}|{imm.Text})");
            Console.WriteLine($"{name.Symbol}");
            throw new NotSupportedException($"Unsupported Select instruction {instruction.Id} - {selectOperand}");
        }
    }

    private static readonly Regex RegexMatchRegisterPlus = new Regex(@"[XW]\(?[st]\+(?<plus>\d)\)?");

    private RegisterOperandDescriptor ProcessRegister(Instruction instruction, RegisterOperandItem register)
    {
        var elt0 = register.TextElements[0];
        var name0 = elt0.Text;
        var isSP = name0.EndsWith("SP");
        Debug.Assert(!isSP || name0.Contains('|'));
        bool isPlusOneRegister = false;

        var matchPlus = RegexMatchRegisterPlus.Match(name0);
        if (matchPlus.Success)
        {
            Debug.Assert(matchPlus.Groups["plus"].Value == "1", "Support only for register encoding + 1 for now");
            isPlusOneRegister = true;
        }

        int indexOfIndexEncoding = 0;

        Arm64RegisterEncodingKind kind;

        EncodingSymbolExtract? dynamicDescriptor = null;

        for (int i = 0; i < register.TextElements.Count; i++)
        {
            var textElement = register.TextElements[i];
            if (textElement.Symbol is not null && textElement.Symbol.BitNames.Count == 1 && textElement.Symbol.BitNames[0].StartsWith("R"))
            {
                indexOfIndexEncoding = i;
                break;
            }
        }

        var c = char.ToUpperInvariant(name0[0]);
        switch (c)
        {
            case 'X':
                kind = isSP ? Arm64RegisterEncodingKind.XOrSP : Arm64RegisterEncodingKind.X;
                break;
            case 'W':
                kind = isSP ? Arm64RegisterEncodingKind.WOrWSP : Arm64RegisterEncodingKind.W;
                break;
            case 'B':
                kind = Arm64RegisterEncodingKind.B;
                break;
            case 'H':
                kind = Arm64RegisterEncodingKind.H;
                break;
            case 'S':
                kind = Arm64RegisterEncodingKind.S;
                break;
            case 'D':
                kind = Arm64RegisterEncodingKind.D;
                break;
            case 'C':
                kind = Arm64RegisterEncodingKind.C;
                break;
            case 'V':
                if (indexOfIndexEncoding != 0 && elt0.Symbol is not null && elt0.Symbol.Selector is not null)
                {
                    // This is not a vector but a scalar register
                    kind = Arm64RegisterEncodingKind.DynamicVScalar;
                    dynamicDescriptor = ParseDynamicRegister(instruction, register);
                }
                else
                {
                    kind = Arm64RegisterEncodingKind.V;
                }
                break;
            case 'Q':
                kind = Arm64RegisterEncodingKind.Q;
                break;
            //case 'Z':
            //    kind = RegisterKind.Z;
            //    break;
            default:
                if (c == 'R')
                {
                    // Case of a dynamic X or W register
                    Debug.Assert(elt0.Symbol is not null);
                    kind = Arm64RegisterEncodingKind.DynamicXOrW;
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
            RegisterKind = kind,
            DynamicRegisterXOrWSelector = dynamicDescriptor
        };

        if (dynamicDescriptor is not null)
        {
            
        }

        var registerNameBuilder = new StringBuilder();
        foreach (var textElement in register.TextElements)
        {
            registerNameBuilder.Append(textElement.Text);
        }
        descriptor.Name = registerNameBuilder.ToString();


        var symbol = register.TextElements[indexOfIndexEncoding].Symbol;
        if (symbol is not null && symbol.BitNames.Count > 0)
        {
            int size = symbol.BitSize;

            if (symbol.Selector is null)
            {
                Debug.Assert(symbol.BitRanges.Count == 1 && (size == 5 || size == 4));
                Debug.Assert(!isPlusOneRegister || size == 5);
                descriptor.LowBitIndexEncoding = symbol.BitRanges[0].LowBit;
                descriptor.RegisterIndexEncodingKind = size == 4
                    ? Arm64RegisterIndexEncodingKind.Std4
                    : isPlusOneRegister
                        ? Arm64RegisterIndexEncodingKind.Std5Plus1
                        : Arm64RegisterIndexEncodingKind.Std5;
            }
            else
            {
                Debug.Assert(!isPlusOneRegister);
                descriptor.RegisterIndexEncodingKind = Arm64RegisterIndexEncodingKind.BitMapExtract;
                descriptor.RegisterIndexExtract = _registerIndex.GetOrCreateExtract<EncodingSymbolExtract>(symbol);
                descriptor.RegisterIndexExtract.Usages.Add((instruction, register));
            }
        }
        else
        {
            Debug.Assert(false, $"No encoding found for {instruction.Id}");
        }

        descriptor.IndexerExtract = ProcessIndexer(instruction, register);

        if (kind == Arm64RegisterEncodingKind.V && register.TextElements.Count > 1)
        {
            descriptor.VectorArrangement = GetVectorArrangement(instruction, register);
        }

        //if (descriptor.IndexerExtract is not null)
        //{
        //    if (descriptor.VectorArrangementLocalIndex != 0)
        //    {
        //        var vectorExtract = instruction.VectorArrangements[descriptor.VectorArrangementLocalIndex - 1];
        //        Console.WriteLine($"Indexer {register} - {instruction.Id} {instruction.FullSyntax} -> ");

        //        var selector = vectorExtract.Selector;
        //        if (selector is not null)
        //        {
        //            var names = selector.BitValues.SelectMany(x => x.Text).ToHashSet();

        //            foreach (var name in names.Order())
        //            {
        //                Console.WriteLine($"  {name}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"  {vectorExtract.Kind}");
                    
        //        }
        //    }
        //}
        
        return descriptor;
    }

    private EncodingSymbolExtract ParseDynamicRegister(Instruction instruction, RegisterOperandItem register)
    {
        var symbol = register.TextElements[0].Symbol!;
        var selector = symbol.Selector;
        Debug.Assert(selector is not null);
        
        var map = _dynamicRegisterSelectors.GetOrCreateExtract<EncodingSymbolExtract>(symbol);
        map.Usages.Add((instruction, register));

        // Check values
        foreach (var bitValue in selector.BitValues)
        {
            var registerOperandKind = bitValue.Text switch
            {
                "B" => Arm64RegisterEncodingKind.B,
                "S" => Arm64RegisterEncodingKind.S,
                "H" => Arm64RegisterEncodingKind.H,
                "D" => Arm64RegisterEncodingKind.D,
                "W" => Arm64RegisterEncodingKind.W,
                "X" => Arm64RegisterEncodingKind.X,
                "RESERVED" => Arm64RegisterEncodingKind.None,
                _ => throw new NotSupportedException($"Unsupported dynamic register value `{bitValue.Text}` in instruction `{instruction.Id}`")
            };
        }

        return map;
    }

    private EncodingSymbolExtract? ProcessIndexer(Instruction instruction, OperandItem item)
    {
        var indexer = item.Indexer;
        if (indexer is null)
        {
            return null;
        }

        Debug.Assert(indexer.TextElements.Count == 1);
        var text = indexer.TextElements[0].Text;
        var symbol = indexer.TextElements[0].Symbol;
        EncodingIndexerExtract indexerExtract;
        if (symbol is not null)
        {
            indexerExtract = _indexers.GetOrCreateExtract<EncodingIndexerExtract>(symbol!);
        }
        else
        {
            var intValue = int.Parse(text);
            indexerExtract = _indexers.GetOrCreateExtract<EncodingIndexerExtract>(text);
            indexerExtract.FixedIndex = text;
            
        }
        indexerExtract.Usages.Add((instruction, item));
        return indexerExtract;
    }

    private EncodingVectorArrangementExtract GetVectorArrangement(Instruction instruction, RegisterOperandItem register)
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

        var kind = EncodingVectorArrangementExtract.ParseArrangementKind(text);

        EncodingVectorArrangementExtract vectorArrangement;

        if (kind == Arm64RegisterVectorArrangementEncodingKind.T)
        {
            Debug.Assert(symbol is not null);
            vectorArrangement = _vectorArrangements.GetOrCreateExtract<EncodingVectorArrangementExtract>(symbol);
        }
        else
        {
            vectorArrangement = _vectorArrangements.GetOrCreateExtract<EncodingVectorArrangementExtract>(kind.ToString());
        }
        vectorArrangement.Usages.Add((instruction, register));
        vectorArrangement.Kind = kind;

        // Always used index + 1 (0 is reserved for null / no vector arrangement)
        return vectorArrangement;
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

        //Debug.Assert(ids.Count == 1);
        if (group.Items.Count == 0 || group.Items.Count > 4)
        {
            throw new NotSupportedException(
                $"Unsupported number of register groups {group.Items.Count}. Must be <= 4 for instruction {instruction.Id}");
        }

        var registerGroup = new RegisterGroupOperandDescriptor()
        {
            Register = descriptors[0],
            Count = group.Items.Count,
            Name = descriptors[0].Name,
        };

        registerGroup.IndexerExtract = ProcessIndexer(instruction, group);

        //if (registerGroup.IndexerExtract is not null)
        //{
        //    Console.WriteLine($"GROUP {group} - {instruction.Id} {instruction.FullSyntax} -> ");

        //    var selector = registerGroup.IndexerExtract.Selector;
        //    if (selector is not null)
        //    {
        //        var names = selector.BitValues.SelectMany(x => x.Text).ToHashSet();

        //        foreach (var name in names.Order())
        //        {
        //            Console.WriteLine($"  {name}");
        //        }
        //    }
        //}

        return registerGroup;
    }

    private ImmediateOperandDescriptor ProcessImmediate(Instruction instruction, OperandItem item)
    {
        var immediate = new ImmediateOperandDescriptor()
        {
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
                immediate.HasFixedValue = true;
            }
            else
            {
                immediate.ImmediateKind = Arm64ImmediateEncodingKind.FixedInt;
                immediate.FixedValue = sbyte.Parse(fixedValueStr);
                immediate.HasFixedValue = true;
            }
        }
        else
        {
            Debug.Assert(item.TextElements.Count == 1);
            var symbol = item.TextElements[0].Symbol;
            Debug.Assert(symbol != null);
            immediate.BitSize = symbol.BitSize;
            immediate.Encoding.AddRange(symbol.BitRanges);
            immediate.ImmediateKind = Arm64ImmediateEncodingKind.Regular;
            immediate.IsSigned = symbol.IsSignedImmediate;

            // Try to find a special value encoding
            if (MappingTables.TryGetImmediateEncoding(instruction.Id, immediate.Name, out var valueEncoding))
            {
                immediate.ValueEncodingKind = valueEncoding;
            }

            if (symbol.Selector is not null || immediate.Encoding.Count >= 3)
            {
                immediate.ImmediateKind = Arm64ImmediateEncodingKind.BitMapExtract;
                immediate.Extract = _immediates.GetOrCreateExtract<EncodingSymbolExtract>(symbol);
                immediate.Extract.Usages.Add((instruction, item));
            }
            else
            {
                Debug.Assert(immediate.Encoding.Count > 0 && immediate.Encoding.Count <= 2);
                if (symbol.EncodedInText == "a:b:c:d:e:f:g:h")
                {
                    if (immediate.Name == "imm")
                    {
                        // 64-bit immediate 'aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh'
                        // immediate.Name == "imm"
                        immediate.ImmediateKind = Arm64ImmediateEncodingKind.Imm64;
                    }
                }
                else if (symbol.BitRanges.Count > 3)
                {
                    Console.WriteLine($"Watch out special immediate #{immediate.Name} Size: {immediate.BitSize} in instruction id {instruction.Id} - Symbol: {symbol}");
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
        bool signedImmediate = false;
        var immediateValueEncodingKind = Arm64ImmediateValueEncodingKind.None;

        // 1 [Xd]!
        // 1 [Xn|SP]
        // 1 [Xs]!
        if (items.Count == 1)
        {
            var isSp = items[0].TextElements[0].Text.Contains("|SP");
            kind = isSp ? Arm64MemoryEncodingKind.BaseRegister : Arm64MemoryEncodingKind.BaseRegisterXn;
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
                kind = immediate.ImmediateKind == Arm64ImmediateEncodingKind.FixedInt ? Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate : Arm64MemoryEncodingKind.BaseRegisterAndImmediate;
                fixedValue = immediate.FixedValue;
                var symbol = imm.TextElements[0].Symbol;
                immediateValueEncodingKind = immediate.ValueEncodingKind;
                signedImmediate = immediate.IsSigned;
            }
            else if (imm.Kind == OperandItemKind.OptionalGroup)
            {
                var group = (OptionalGroupOperandItem)imm;
                Debug.Assert(group.Items.Count == 1);
                immediate = ProcessImmediate(instruction, (ImmediateOperandItem)group.Items[0]);
                kind = immediate.ImmediateKind == Arm64ImmediateEncodingKind.FixedInt ? Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional : Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional;
                fixedValue = immediate.FixedValue;
                immediateValueEncodingKind = immediate.ValueEncodingKind;
                signedImmediate = immediate.IsSigned;
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
                Debug.Assert(firstReg.RegisterIndexEncodingKind != Arm64RegisterIndexEncodingKind.BitMapExtract);
                Debug.Assert(secondReg.RegisterIndexEncodingKind != Arm64RegisterIndexEncodingKind.BitMapExtract);
                Debug.Assert(firstReg.LowBitIndexEncoding == secondReg.LowBitIndexEncoding);
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
                    kind = Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional;
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
            MemoryEncodingKind = kind,
            Name = "mem", // TODO: name it better between src/dst
            FixedValue = fixedValue,
            IsPreIncrement = operand.HasBang,
            ExtendKind = extendKind,
            SignedImmediate = signedImmediate,
            ImmediateValueEncodingKind = immediateValueEncodingKind,
        };

        Debug.Assert(baseRegister.IsSimpleEncoding);
        memoryOperandDescriptor.BaseRegister = baseRegister.GetIndexEncoding();
        Debug.Assert(memoryOperandDescriptor.BaseRegister.Width == 5);

        if (indexRegisterOrImmediate is RegisterOperandDescriptor indexDesc)
        {
            Debug.Assert(indexDesc.IsSimpleEncoding);
            memoryOperandDescriptor.IndexRegisterOrImmediate.Add(indexDesc.GetIndexEncoding());
            Debug.Assert(indexDesc.RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Std5 | indexDesc.RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Std5Plus1);
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

        var extendBitRange = instruction.BitRangeMap[extendSymbol.BitNames[0]];
        var amountBitRange = instruction.BitRangeMap[amountSymbol.BitNames[0]];

        // The bits are always at the same location, so we don't need to encode them
        // But we just verify it here
        Debug.Assert(extendBitRange.HiBit == 15 && extendBitRange.Width == 3);
        Debug.Assert(amountBitRange.HiBit == 12 && amountBitRange.Width == 1);

        Arm64MemoryExtendEncodingKind extendKind = Arm64MemoryExtendEncodingKind.NoLsl;

        if (extendSymbol.Selector!.BitValues.Count == 3)
        {
            extendKind = Arm64MemoryExtendEncodingKind.NoLsl;
        }
        else
        {
            Debug.Assert(extendSymbol.Selector.BitValues.Count == 4);
            Debug.Assert(amountSymbol.Selector!.BitValues.Count == 2);
            Debug.Assert(amountSymbol.Selector.BitValues[0].Text == "#0"); // Always 0
            extendKind = amountSymbol.Selector.BitValues[1].Text switch
            {
                "#1" => Arm64MemoryExtendEncodingKind.Shift1,
                "#2" => Arm64MemoryExtendEncodingKind.Shift2,
                "#3" => Arm64MemoryExtendEncodingKind.Shift3,
                "#4" => Arm64MemoryExtendEncodingKind.Shift4,
                _ => throw new NotSupportedException($"Unsupported amount {amountSymbol.Selector.BitValues[1].Text}")
            };
        }

        return extendKind;
    }


    private void CollectEnumValues(EncodingSymbol symbol, Dictionary<string, int> enumToInt)
    {
        foreach (var bitValue in symbol.Selector!.BitValues)
        {
            if (bitValue.Kind == EncodingBitValueKind.Reserved) continue;

            var intValue = (int)bitValue.BitSelectorValue;

            if (!enumToInt.TryGetValue(bitValue.Text, out var previousValue))
            {
                enumToInt.Add(bitValue.Text, intValue);
            }
            else
            {
                Debug.Assert(previousValue == intValue);
            }
        }
    }
}