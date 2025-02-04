// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Specifies the kind of offset for ARM64 memory addressing.
/// </summary>
public enum Arm64MemoryOffsetKind : byte
{
    /// <summary>
    /// No offset.
    /// </summary>
    None = 0,
    /// <summary>
    /// Offset is an immediate value.
    /// </summary>
    Immediate = 1,
    /// <summary>
    /// Offset is a register with an extend operation.
    /// </summary>
    RegisterExtend = 2,
}