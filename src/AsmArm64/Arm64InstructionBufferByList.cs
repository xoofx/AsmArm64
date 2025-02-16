// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.InteropServices;

namespace AsmArm64;

public class Arm64InstructionBufferByList : Arm64InstructionBuffer
{
    private readonly List<Arm64RawInstruction> _instructions;

    public Arm64InstructionBufferByList()
    {
        _instructions = new();
    }
    public Arm64InstructionBufferByList(int capacity)
    {
        _instructions = new(capacity);
    }
    public Arm64InstructionBufferByList(List<Arm64RawInstruction> instructions)
    {
        _instructions = instructions;
    }

    public List<Arm64RawInstruction> Instructions => _instructions;

    public override Arm64RawInstruction ReadAt(uint offset) => _instructions[(int)offset >> 2];

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