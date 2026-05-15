// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 assembler.
/// </summary>
public partial class Arm64Assembler : IDisposable
{
    private readonly List<Arm64Label> _labels;
    private readonly List<UnboundInstructionLabel> _instructionsWithLabelToPatch;
    private readonly Arm64InstructionBuffer _buffer;
    private readonly Arm64AssemblerBuffer? _ownedBuffer;
    private List<Action>? _resolveEndCallbacks;
    private bool _isDisposed;
    private bool _isFinalized;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Assembler"/> class with an owned byte buffer.
    /// </summary>
    /// <param name="baseAddress">The base address of the assembled code.</param>
    public Arm64Assembler(ulong baseAddress = 0x1_0000UL) : this(new Arm64AssemblerBuffer(), ownsBuffer: true)
    {
        BaseAddress = baseAddress;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Assembler"/> class.
    /// </summary>
    /// <param name="buffer">The instruction buffer.</param>
    public Arm64Assembler(Arm64InstructionBuffer buffer)
        : this(buffer, ownsBuffer: false)
    {
    }

    private Arm64Assembler(Arm64InstructionBuffer buffer, bool ownsBuffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        _labels = new();
        _instructionsWithLabelToPatch = new();
        BaseAddress = 0x1_0000UL;
        _buffer = buffer;
        _ownedBuffer = ownsBuffer ? (Arm64AssemblerBuffer)buffer : null;
    }

    /// <summary>
    /// Gets the assembled bytes when this assembler owns a byte buffer.
    /// </summary>
    /// <remarks>The returned span is invalidated by subsequent writes, resizes, reset, or disposal.</remarks>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    public ReadOnlySpan<byte> Buffer => GetByteBuffer().AsSpan();

    /// <summary>
    /// Gets the underlying instruction buffer.
    /// </summary>
    public Arm64InstructionBuffer InstructionBuffer => _buffer;

    /// <summary>
    /// Gets the number of bytes emitted by this assembler.
    /// </summary>
    public uint SizeInBytes => CurrentOffset;

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
    public Arm64Assembler Reset()
    {
        ThrowIfDisposed();
        _labels.Clear();
        _instructionsWithLabelToPatch.Clear();
        _resolveEndCallbacks?.Clear();
        _ownedBuffer?.Clear();
        CurrentOffset = 0;
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Begins a new assembly session at the specified address.
    /// </summary>
    /// <param name="address">The base address.</param>
    /// <param name="name">An optional name for the new assembly session. Reserved for diagnostics.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler Begin(ulong address = 0x1_0000UL, string? name = null)
    {
        _ = name;
        Reset();
        BaseAddress = address;
        return this;
    }

    /// <summary>
    /// Sets the current origin without clearing already emitted bytes.
    /// </summary>
    /// <param name="address">The new current address.</param>
    /// <param name="name">An optional name for the origin. Reserved for diagnostics.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="address"/> is before the current offset.</exception>
    public Arm64Assembler Org(ulong address, string? name = null)
    {
        _ = name;
        ThrowIfDisposed();
        if (address < CurrentOffset)
        {
            throw new ArgumentOutOfRangeException(nameof(address), "The origin address cannot be less than the current offset.");
        }

        BaseAddress = address - CurrentOffset;
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Assembles the instructions and patches the labels.
    /// </summary>
    public Arm64Assembler Assemble() => End();

    /// <summary>
    /// Ends assembly, patches labels, and invokes resolve-end callbacks.
    /// </summary>
    /// <returns>This assembler.</returns>
    public Arm64Assembler End()
    {
        ThrowIfDisposed();
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
        _isFinalized = true;

        if (_resolveEndCallbacks is not null)
        {
            foreach (var callback in _resolveEndCallbacks)
            {
                callback();
            }

            _resolveEndCallbacks.Clear();
        }

        return this;
    }

    /// <summary>
    /// Registers a callback invoked after the next successful <see cref="End"/> call.
    /// </summary>
    /// <param name="callback">The callback to invoke.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="callback"/> is <c>null</c>.</exception>
    public Arm64Assembler OnResolveEnd(Action callback)
    {
        ArgumentNullException.ThrowIfNull(callback);
        ThrowIfDisposed();
        (_resolveEndCallbacks ??= new()).Add(callback);
        return this;
    }

    /// <summary>
    /// Gets a value indicating whether <see cref="End"/> completed successfully after the last mutation.
    /// </summary>
    public bool IsFinalized => _isFinalized;

    /// <summary>
    /// Gets a value indicating whether this assembler has pending label patches.
    /// </summary>
    public bool HasPendingPatches => _instructionsWithLabelToPatch.Count != 0;

    /// <summary>
    /// Creates a new label identifier.
    /// </summary>
    /// <param name="name">The name of the label.</param>
    /// <param name="address">The address of the label.</param>
    /// <returns>The created label identifier.</returns>
    public Arm64LabelId CreateLabelId(string? name = null, ulong address = ulong.MaxValue)
    {
        ThrowIfDisposed();
        var index = _labels.Count + 1;
        _labels.Add(new(address, name));
        _isFinalized = false;
        return new Arm64LabelId(index);
    }

    /// <summary>
    /// Binds a label to the current address.
    /// </summary>
    /// <param name="labelId">The label identifier.</param>
    public void BindLabel(Arm64LabelId labelId)
    {
        ThrowIfDisposed();
        if (labelId.Index == 0) throw new ArgumentException("Cannot bind the first label", nameof(labelId));

        var index = labelId.Index - 1;
        var labelReference = _labels[index];
        var currentAddress = CurrentAddress;
        if (labelReference.Address == ulong.MaxValue)
        {
            _labels[index] = new(currentAddress, labelReference.Name);
            _isFinalized = false;
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

    /// <summary>
    /// Appends bytes to the owned assembler buffer.
    /// </summary>
    /// <param name="input">The bytes to append.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    public Arm64Assembler Append(ReadOnlySpan<byte> input)
    {
        ThrowIfDisposed();
        GetByteBuffer().WriteAt(CurrentOffset, input);
        CurrentOffset = checked((uint)(CurrentOffset + input.Length));
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Appends one byte to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendByte(byte value)
    {
        Span<byte> buffer = stackalloc byte[1];
        buffer[0] = value;
        return Append(buffer);
    }

    /// <summary>
    /// Appends a little-endian unsigned 16-bit value to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendUInt16(ushort value)
    {
        Span<byte> buffer = stackalloc byte[sizeof(ushort)];
        BinaryPrimitives.WriteUInt16LittleEndian(buffer, value);
        return Append(buffer);
    }

    /// <summary>
    /// Appends a little-endian unsigned 32-bit value to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendUInt32(uint value)
    {
        Span<byte> buffer = stackalloc byte[sizeof(uint)];
        BinaryPrimitives.WriteUInt32LittleEndian(buffer, value);
        return Append(buffer);
    }

    /// <summary>
    /// Appends a little-endian unsigned 64-bit value to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendUInt64(ulong value)
    {
        Span<byte> buffer = stackalloc byte[sizeof(ulong)];
        BinaryPrimitives.WriteUInt64LittleEndian(buffer, value);
        return Append(buffer);
    }

    /// <summary>
    /// Appends one ARM64 instruction.
    /// </summary>
    /// <param name="instruction">The instruction to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendInstruction(Arm64RawInstruction instruction)
    {
        AddInstruction(instruction);
        return this;
    }

    /// <summary>
    /// Appends repeated bytes to the owned assembler buffer.
    /// </summary>
    /// <param name="length">The number of bytes to append.</param>
    /// <param name="fill">The fill byte.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is negative.</exception>
    public Arm64Assembler AppendBytes(int length, byte fill = 0)
    {
        if (length < 0) throw new ArgumentOutOfRangeException(nameof(length), "Length must be zero or positive.");
        if (length == 0) return this;

        var byteBuffer = GetByteBuffer();
        var data = new byte[length];
        if (fill != 0)
        {
            data.AsSpan().Fill(fill);
        }

        byteBuffer.WriteAt(CurrentOffset, data);
        CurrentOffset = checked((uint)(CurrentOffset + length));
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Aligns the current offset to the specified power-of-two alignment.
    /// </summary>
    /// <param name="alignment">The alignment in bytes. Must be a power of two.</param>
    /// <param name="fill">The fill byte.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="alignment"/> is zero.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="alignment"/> is not a power of two.</exception>
    public Arm64Assembler Align(uint alignment, byte fill = 0)
    {
        if (alignment == 0) throw new ArgumentOutOfRangeException(nameof(alignment), "Alignment must be greater than zero.");
        if ((alignment & (alignment - 1)) != 0) throw new ArgumentException("Alignment must be a power of two.", nameof(alignment));

        var remainder = CurrentOffset & (alignment - 1);
        if (remainder == 0) return this;

        return AppendBytes(checked((int)(alignment - remainder)), fill);
    }

    /// <summary>
    /// Appends one or more NOP instructions.
    /// </summary>
    /// <param name="count">The number of NOP instructions to append.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is negative.</exception>
    public Arm64Assembler Nop(int count = 1)
    {
        if (count < 0) throw new ArgumentOutOfRangeException(nameof(count), "Count must be zero or positive.");

        for (var i = 0; i < count; i++)
        {
            AddInstruction(Arm64InstructionFactory.NOP());
        }

        return this;
    }

    /// <summary>
    /// Copies the assembled bytes to a new array.
    /// </summary>
    /// <returns>A new array containing the assembled bytes.</returns>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    public byte[] ToArray() => GetByteBuffer().ToArray();

    private int RecordLabelOffset(Arm64LabelId labelId, nint operandDescriptorEncodingOffset)
    {
        ThrowIfDisposed();
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
    private Arm64Assembler AddInstruction(Arm64RawInstruction rawInstruction)
    {
        ThrowIfDisposed();
        _buffer.WriteAt(CurrentOffset, rawInstruction);
        CurrentOffset += 4;
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Releases resources owned by this assembler.
    /// </summary>
    public void Dispose()
    {
        if (_isDisposed) return;

        _ownedBuffer?.Dispose();
        _resolveEndCallbacks?.Clear();
        _isDisposed = true;
    }

    private Arm64AssemblerBuffer GetByteBuffer()
    {
        ThrowIfDisposed();
        if (_buffer is Arm64AssemblerBuffer byteBuffer) return byteBuffer;
        throw new NotSupportedException("Byte-buffer APIs are available only when the assembler owns an Arm64AssemblerBuffer.");
    }

    private void ThrowIfDisposed()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, this);
    }

    private record struct UnboundInstructionLabel(uint InstructionOffset, Arm64LabelId LabelId, ulong LabelOperandDescriptor);
}
