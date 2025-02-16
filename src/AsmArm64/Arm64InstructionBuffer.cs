// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public abstract class Arm64InstructionBuffer
{
    /// <summary>
    /// Gets the length of this buffer in bytes.
    /// </summary>
    public abstract int Length { get; }

    public abstract Arm64RawInstruction ReadAt(uint offset);

    public abstract void WriteAt(uint offset, Arm64RawInstruction rawInstruction);
}