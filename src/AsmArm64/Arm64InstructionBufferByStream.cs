// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// Represents a buffer of ARM64 instructions with a Stream.
/// </summary>
public class Arm64InstructionBufferByStream : Arm64InstructionBuffer
{
    /// <summary>
    /// Initializes a new instance of <see cref="Arm64InstructionBufferByStream"/>.
    /// </summary>
    /// <param name="stream">The stream that contains the instructions.</param>
    public Arm64InstructionBufferByStream(Stream stream)
    {
        Stream = stream;
    }

    /// <summary>
    /// Gets or sets the stream that contains the instructions.
    /// </summary>
    public Stream Stream { get; set; }

    /// <inheritdoc />
    public override int Length => (int)Stream.Length;

    /// <inheritdoc />
    public override Arm64RawInstruction ReadAt(uint offset)
    {
        Stream.Seek(offset, SeekOrigin.Begin);
        Unsafe.SkipInit(out Arm64RawInstruction rawInstruction);
        if (Stream.Read(MemoryMarshal.CreateSpan(ref Unsafe.As<uint, byte>(ref rawInstruction), 4)) != 4)
        {
            throw new InvalidOperationException("Cannot read instruction");
        }
        return rawInstruction;
    }

    /// <inheritdoc />
    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction)
    {
        Stream.Seek(offset, SeekOrigin.Begin);
        Stream.Write(MemoryMarshal.CreateSpan(ref Unsafe.As<uint, byte>(ref rawInstruction), 4));
    }
}