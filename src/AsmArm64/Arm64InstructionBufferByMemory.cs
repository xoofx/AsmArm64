// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

public class Arm64InstructionBufferByMemory : Arm64InstructionBuffer
{
    private Memory<byte> _memory;
    public Arm64InstructionBufferByMemory(Memory<byte> memory)
    {
        _memory = memory;
    }

    public Memory<byte> Memory
    {
        get => _memory;
        set => _memory = value;
    }
    
    public override int Length => _memory.Length;

    public override Arm64RawInstruction ReadAt(uint offset) => GetInstructionAt(offset);

    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction) => GetInstructionAt(offset) = rawInstruction;

    private ref Arm64RawInstruction GetInstructionAt(uint offset)
    {
        return ref Unsafe.As<byte, Arm64RawInstruction>(ref MemoryMarshal.GetReference(_memory.Span.Slice((int)offset, 4)));
    }
}