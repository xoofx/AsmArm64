// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// A buffer of <see cref="Arm64RawInstruction"/> using a <see cref="List{T}"/>.
/// </summary>
public class Arm64InstructionBufferByList : Arm64InstructionBuffer
{
    private readonly List<Arm64RawInstruction> _instructions;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64InstructionBufferByList"/> class.
    /// </summary>
    public Arm64InstructionBufferByList()
    {
        _instructions = new();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64InstructionBufferByList"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The capacity of the list buffer.</param>
    public Arm64InstructionBufferByList(int capacity)
    {
        _instructions = new(capacity);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64InstructionBufferByList"/> class with the specified instructions.
    /// </summary>
    /// <param name="instructions"></param>
    public Arm64InstructionBufferByList(List<Arm64RawInstruction> instructions)
    {
        _instructions = instructions;
    }

    /// <summary>
    /// Gets the list of instructions.
    /// </summary>
    public List<Arm64RawInstruction> Instructions => _instructions;

    /// <inheritdoc />
    public override int Length => _instructions.Count * 4;

    /// <inheritdoc />
    public override Arm64RawInstruction ReadAt(uint offset) => _instructions[(int)offset >> 2];

    /// <inheritdoc />
    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction)
    {
        var index = (int)offset >> 2; // expect offset to be aligned to 4 bytes (could be changed to support any alignment via a cast to Span<byte>)
        var instructions = _instructions;
        if (index >= instructions.Count)
        {
            CollectionsMarshal.SetCount(instructions, index + 1);
        }

        instructions[index] = rawInstruction;
    }
}