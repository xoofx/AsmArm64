// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// Represents a buffer of ARM64 instructions.
/// </summary>
public class Arm64InstructionBufferByMemory : Arm64InstructionBuffer
{
    private Memory<byte> _memory;

    /// <summary>
    /// Initializes a new instance of <see cref="Arm64InstructionBufferByMemory"/>.
    /// </summary>
    /// <param name="memory">A memory buffer to use for this instruction buffer.</param>
    public Arm64InstructionBufferByMemory(Memory<byte> memory)
    {
        _memory = memory;
    }

    /// <summary>
    /// Gets or sets the memory buffer used by this instruction buffer.
    /// </summary>
    public Memory<byte> Memory
    {
        get => _memory;
        set => _memory = value;
    }

    /// <inheritdoc />
    public override int Length => _memory.Length;

    /// <inheritdoc />
    public override Arm64RawInstruction ReadAt(uint offset) => GetInstructionAt(offset);

    /// <inheritdoc />
    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction) => GetInstructionAt(offset) = rawInstruction;

    private ref Arm64RawInstruction GetInstructionAt(uint offset)
    {
        return ref Unsafe.As<byte, Arm64RawInstruction>(ref MemoryMarshal.GetReference(_memory.Span.Slice((int)offset, 4)));
    }
}