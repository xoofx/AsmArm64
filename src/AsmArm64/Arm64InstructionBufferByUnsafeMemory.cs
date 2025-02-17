// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// Represents a buffer of ARM64 instructions with unsafe memory.
/// </summary>
public unsafe class Arm64InstructionBufferByUnsafeMemory : Arm64InstructionBuffer
{
    private byte* _buffer;
    private int _length;

    /// <summary>
    /// Initializes a new instance of <see cref="Arm64InstructionBufferByUnsafeMemory"/>.
    /// </summary>
    /// <param name="buffer">The pointer to tbe start of the buffer for the instructions.</param>
    /// <param name="length">The length in bytes of the buffer.</param>
    /// <exception cref="ArgumentNullException">If buffer is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">If length is negative.</exception>
    public Arm64InstructionBufferByUnsafeMemory(byte* buffer, int length)
        => SetBuffer(buffer, length);

    /// <summary>
    /// Gets the pointer to the start of the buffer for the instructions.
    /// </summary>
    public byte* Buffer => _buffer;

    /// <inheritdoc />
    public override int Length => _length;

    /// <summary>
    /// Sets the buffer for this instance.
    /// </summary>
    /// <param name="buffer">The pointer to tbe start of the buffer for the instructions.</param>
    /// <param name="length">The length in bytes of the buffer.</param>
    /// <exception cref="ArgumentNullException">If buffer is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">If length is negative.</exception>
    public void SetBuffer(byte* buffer, int length)
    {
        if (buffer is null) throw new ArgumentNullException(nameof(buffer));
        if (length < 0) throw new ArgumentOutOfRangeException(nameof(length));
        _buffer = buffer;
        _length = length;
    }

    /// <summary>
    /// Gets a span of the buffer.
    /// </summary>
    public Span<byte> AsSpan => new(_buffer, _length);

    /// <inheritdoc />
    public override Arm64RawInstruction ReadAt(uint offset) => GetInstructionAt(offset);

    /// <inheritdoc />
    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction) => GetInstructionAt(offset) = rawInstruction;

    private ref Arm64RawInstruction GetInstructionAt(uint offset)
        => ref Unsafe.As<byte, Arm64RawInstruction>(ref MemoryMarshal.GetReference(AsSpan.Slice((int)offset, 4)));
}