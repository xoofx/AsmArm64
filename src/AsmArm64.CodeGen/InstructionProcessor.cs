// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

internal sealed class InstructionProcessor
{
    private readonly List<Instruction> _instructions;

    public InstructionProcessor(List<Instruction> instructions)
    {
        _instructions = instructions;
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
            foreach (var operand in instruction.Operands)
            {
                if (operand.Kind == OperandKind.Register)
                {
                    var register = (RegisterOperandItem)operand.Items[0];

                    var name0 = register.TextElements[0].Text;
                    var isSP = name0.EndsWith("SP");
                    Debug.Assert(!isSP || name0.Contains('|') );

                    var c = char.ToUpperInvariant(name0[0]);
                    switch (c)
                    {
                        case 'X':
                            register.Descriptor.IndexKind = isSP ? RegisterIndexKind.XOrSP : RegisterIndexKind.X;
                            break;
                        case 'W':
                            register.Descriptor.IndexKind = isSP ? RegisterIndexKind.WOrWSP : RegisterIndexKind.W;
                            break;
                        case 'B':
                            register.Descriptor.IndexKind = RegisterIndexKind.B;
                            break;
                        case 'H':
                            register.Descriptor.IndexKind = RegisterIndexKind.H;
                            break;
                        case 'S':
                            register.Descriptor.IndexKind = RegisterIndexKind.S;
                            break;
                        case 'D':
                            register.Descriptor.IndexKind = RegisterIndexKind.D;
                            break;
                        case 'V':
                            register.Descriptor.IndexKind = RegisterIndexKind.V;
                            break;
                        case 'Q':
                            register.Descriptor.IndexKind = RegisterIndexKind.Q;
                            break;
                        //case 'Z':
                        //    register.Descriptor.Kind = RegisterKind.Z;
                        //    break;
                        default:
                            throw new NotSupportedException($"Unsupported 1st register letter `{c}` in register name `{name0}` in instruction `{instruction.Id}`");
                    }

                    var symbol = register.TextElements[0].Symbol;
                    if (symbol is not null && symbol.BitInfos.Count > 0)
                    {
                        
                        int size = 0;
                        foreach (var encodingBitInfo in symbol.BitInfos)
                        {
                            var bitRangeInfo = instruction.BitRangeMap[encodingBitInfo.Name];

                            if (register.Descriptor.Encoding.Count > 0)
                            {
                                var previousEncoding = register.Descriptor.Encoding[^1];
                                if (previousEncoding.HiBit - previousEncoding.Width == bitRangeInfo.HiBit)
                                {
                                    // Merge with previous encoding
                                    register.Descriptor.Encoding[^1] = new(previousEncoding.HiBit, previousEncoding.Width + bitRangeInfo.Width);
                                    size += bitRangeInfo.Width;
                                    continue;
                                }
                            }

                            register.Descriptor.Encoding.Add(new(bitRangeInfo.HiBit, bitRangeInfo.Width));
                            size += bitRangeInfo.Width;
                        }

                        if (symbol.BitValues.Count == 0 && (register.Descriptor.Encoding.Count == 1 && (size == 5 || size == 4)))
                        {
                            register.Descriptor.IndexEncodingKind = size == 4
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
                            var encodingSignature = $"{{{string.Join("|", symbol.BitValues)}}} - {string.Join(",", register.Descriptor.Encoding)}";
                            var expectedSignature = "{BitFields = 00, Value = RESERVED|BitFields = 01, Value = UInt('0':Rm)|BitFields = 10, Value = UInt(M:Rm)|BitFields = 11, Value = RESERVED} - (23:2),(20:5)";
                            if (encodingSignature != expectedSignature)
                            {
                                var errorMessage = new StringBuilder();
                                errorMessage.AppendLine($"Unsupported register encoding `{name0}` Size: {size}, Count: {symbol.BitInfos.Count} for instruction `{instruction.Id}` - {string.Join(",", register.Descriptor.Encoding)}");
                                symbol.BitValues.ForEach(x => Console.WriteLine($"  {x}"));
                                throw new NotSupportedException(errorMessage.ToString());
                            }
                            else
                            {
                                register.Descriptor.IndexEncodingKind = RegisterIndexEncodingKind.SpecialMRm;
                                // We don't need to store the bit, as we know it is a special encoding
                                register.Descriptor.Encoding.Clear();
                            }
                        }
                    }

                    if (register.Descriptor.IndexKind == RegisterIndexKind.V)
                    {
                        // Detect arrangement





                    }
                }
            }

        }
    }
}
