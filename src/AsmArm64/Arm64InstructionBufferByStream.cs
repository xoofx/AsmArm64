// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

public class Arm64InstructionBufferByStream : Arm64InstructionBuffer
{
    private readonly Stream _stream;
    public Arm64InstructionBufferByStream(Stream stream)
    {
        _stream = stream;
    }
    public override Arm64RawInstruction ReadAt(uint offset)
    {
        _stream.Seek(offset, SeekOrigin.Begin);
        Unsafe.SkipInit(out Arm64RawInstruction rawInstruction);
        if (_stream.Read(MemoryMarshal.CreateSpan(ref Unsafe.As<uint, byte>(ref rawInstruction), 4)) != 4)
        {
            throw new InvalidOperationException("Cannot read instruction");
        }
        return rawInstruction;
    }

    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction)
    {
        _stream.Seek(offset, SeekOrigin.Begin);
        _stream.Write(MemoryMarshal.CreateSpan(ref Unsafe.As<uint, byte>(ref rawInstruction), 4));
    }
}