// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming

using System.Runtime.CompilerServices;

namespace AsmArm64;

public partial class Arm64Assembler
{
    private readonly List<Arm64Label> _labels;
    private readonly List<UnboundInstructionLabel> _instructionsWithLabelToPatch;
    private readonly Arm64InstructionBuffer _buffer;

    public Arm64Assembler(Arm64InstructionBuffer buffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        _labels = new();
        _instructionsWithLabelToPatch = new();
        BaseAddress = 0x1_0000UL;
        _buffer = buffer;
    }

    public Arm64InstructionBuffer Buffer => _buffer;

    public uint CurrentOffset { get; private protected set; }

    public ulong BaseAddress { get; set; }

    public ulong CurrentAddress => BaseAddress + CurrentOffset;

    public void Reset()
    {
        _labels.Clear();
        _instructionsWithLabelToPatch.Clear();
        CurrentOffset = 0;
    }

    public void Assemble()
    {
        foreach (var unboundLabel in _instructionsWithLabelToPatch)
        {
            var labelReference = GetLabel(unboundLabel.LabelId);
            if (!labelReference.IsBound) throw new InvalidOperationException($"Label {unboundLabel.LabelId} is not bound");
            var offset = (int)(labelReference.Address - (BaseAddress + unboundLabel.InstructionOffset));
            var rawInstruction = _buffer.ReadAt(unboundLabel.InstructionOffset);
            rawInstruction |= Arm64LabelOperand.Encode(unboundLabel.LabelOperandDescriptor, offset);
            _buffer.WriteAt(unboundLabel.InstructionOffset, rawInstruction);
        }

        _instructionsWithLabelToPatch.Clear();
    }
    
    public Arm64LabelId CreateLabelId(string? name = null, ulong address = ulong.MaxValue)
    {
        var index = _labels.Count + 1;
        _labels.Add(new(address, name));
        return new Arm64LabelId(index);
    }

    public void BindLabel(Arm64LabelId labelId)
    {
        if (labelId.Index == 0) throw new ArgumentException("Cannot bind the first label", nameof(labelId));

        var index = labelId.Index - 1;
        var labelReference = _labels[index];
        var currentAddress = CurrentAddress;
        if (labelReference.Address == ulong.MaxValue)
        {
            _labels[index] = new(currentAddress, labelReference.Name);
        }
        else
        {
            throw new InvalidOperationException($"Label {labelReference.Name} is already bound to address {labelReference.Address}");
        }
    }
    public Arm64Label GetLabel(Arm64LabelId labelId) => labelId.Index == 0 ? default : _labels[labelId.Index - 1];

    private int RecordLabelOffset(Arm64LabelId labelId, nint operandDescriptorEncodingOffset)
    {
        var labelReference = GetLabel(labelId);
        if (labelReference.IsEmpty) throw new ArgumentException("Label is not defined", nameof(labelId));
        if (!labelReference.IsBound)
        {
            _instructionsWithLabelToPatch.Add(new(CurrentOffset, labelId, Arm64Instruction.GetOperandDescriptor(operandDescriptorEncodingOffset)));
            return 0;
        }
        return (int)(labelReference.Address - CurrentAddress);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void AddInstruction(Arm64RawInstruction rawInstruction)
    {
        _buffer.WriteAt(CurrentOffset, rawInstruction);
        CurrentOffset += 4;
    }
    
    private record struct UnboundInstructionLabel(uint InstructionOffset, Arm64LabelId LabelId, ulong LabelOperandDescriptor);
}