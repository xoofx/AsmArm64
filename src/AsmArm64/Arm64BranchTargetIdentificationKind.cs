// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the branch target identification kinds used by the ARM64 BTI (Branch Target Identification) instruction.
/// </summary>
public enum Arm64BranchTargetIdentificationKind : byte
{
    /// <summary>
    /// No BTI tag present at the target address.
    /// </summary>
    Absent = 0,

    /// <summary>
    /// BTI with the "C" tag. Indicates a target address for indirect calls.
    /// </summary>
    C = 1,

    /// <summary>
    /// BTI with the "J" tag. Indicates a target address for indirect jumps.
    /// </summary>
    J = 2,

    /// <summary>
    /// BTI with the "JC" tag. Indicates a target address for both indirect jumps and calls.
    /// </summary>
    JC = 3,

    /// <summary>
    /// The branch target identification kind is undefined.
    /// </summary>
    Undefined = 0xFF
}