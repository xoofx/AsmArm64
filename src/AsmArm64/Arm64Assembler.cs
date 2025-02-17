// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 assembler.
/// </summary>
public partial class Arm64Assembler
{
    private readonly List<Arm64Label> _labels;
    private readonly List<UnboundInstructionLabel> _instructionsWithLabelToPatch;
    private readonly Arm64InstructionBuffer _buffer;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Assembler"/> class.
    /// </summary>
    /// <param name="buffer">The instruction buffer.</param>
    public Arm64Assembler(Arm64InstructionBuffer buffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        _labels = new();
        _instructionsWithLabelToPatch = new();
        BaseAddress = 0x1_0000UL;
        _buffer = buffer;
    }

    /// <summary>
    /// Gets the instruction buffer.
    /// </summary>
    public Arm64InstructionBuffer Buffer => _buffer;

    /// <summary>
    /// Gets the current offset.
    /// </summary>
    public uint CurrentOffset { get; private protected set; }

    /// <summary>
    /// Gets or sets the base address.
    /// </summary>
    public ulong BaseAddress { get; set; }

    /// <summary>
    /// Gets the current address.
    /// </summary>
    public ulong CurrentAddress => BaseAddress + CurrentOffset;

    /// <summary>
    /// Resets the assembler state.
    /// </summary>
    public void Reset()
    {
        _labels.Clear();
        _instructionsWithLabelToPatch.Clear();
        CurrentOffset = 0;
    }

    /// <summary>
    /// Assembles the instructions and patches the labels.
    /// </summary>
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

    /// <summary>
    /// Creates a new label identifier.
    /// </summary>
    /// <param name="name">The name of the label.</param>
    /// <param name="address">The address of the label.</param>
    /// <returns>The created label identifier.</returns>
    public Arm64LabelId CreateLabelId(string? name = null, ulong address = ulong.MaxValue)
    {
        var index = _labels.Count + 1;
        _labels.Add(new(address, name));
        return new Arm64LabelId(index);
    }

    /// <summary>
    /// Binds a label to the current address.
    /// </summary>
    /// <param name="labelId">The label identifier.</param>
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

    /// <summary>
    /// Gets the label associated with the specified label identifier.
    /// </summary>
    /// <param name="labelId">The label identifier.</param>
    /// <returns>The label.</returns>
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
