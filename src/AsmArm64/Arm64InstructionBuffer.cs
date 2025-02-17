// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a buffer of ARM64 instructions.
/// </summary>
public abstract class Arm64InstructionBuffer
{
    /// <summary>
    /// Gets the length of this buffer in bytes.
    /// </summary>
    public abstract int Length { get; }

    /// <summary>
    /// Reads an ARM64 instruction at the specified offset.
    /// </summary>
    /// <param name="offset">The offset to read an instruction from.</param>
    /// <returns>The ARM64 instruction to read at the specified offset.</returns>
    public abstract Arm64RawInstruction ReadAt(uint offset);

    /// <summary>
    /// Writes an ARM64 instruction at the specified offset.
    /// </summary>
    /// <param name="offset">The offset to read an instruction from.</param>
    /// <param name="rawInstruction">The ARM64 instruction to write at the specified offset.</param>
    public abstract void WriteAt(uint offset, Arm64RawInstruction rawInstruction);
}