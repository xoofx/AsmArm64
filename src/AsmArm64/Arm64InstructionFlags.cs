// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Flags of an <see cref="Arm64Instruction"/>.
/// </summary>
[Flags]
public enum Arm64InstructionFlags : byte
{
    /// <summary>
    /// No flags.
    /// </summary>
    None = 0,
    /// <summary>
    /// The instruction has a label.
    /// </summary>
    HasLabel = 1,
    /// <summary>
    /// The instruction updates arithmetic CPU flags.
    /// </summary>
    HasSetFlags = 2,
}