// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

public unsafe class Arm64InstructionAccessorByUnsafeMemory : Arm64InstructionAccessor
{
    private readonly byte* _buffer;
    private readonly int _length;
    
    public Arm64InstructionAccessorByUnsafeMemory(byte* buffer, int length)
    {
        if (buffer is null) throw new ArgumentNullException(nameof(buffer));
        if (length < 0) throw new ArgumentOutOfRangeException(nameof(length));
        _buffer = buffer;
        _length = length;
    }

    public Span<byte> AsSpan => new(_buffer, _length);

    public override Arm64RawInstruction ReadAt(uint offset) => GetInstructionAt(offset);
    
    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction) => GetInstructionAt(offset) = rawInstruction;

    private ref Arm64RawInstruction GetInstructionAt(uint offset)
        => ref Unsafe.As<byte, Arm64RawInstruction>(ref MemoryMarshal.GetReference(AsSpan.Slice((int)offset, 4)));
}