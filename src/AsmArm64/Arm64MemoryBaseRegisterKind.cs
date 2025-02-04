// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Specifies the kind of base register for ARM64 memory addressing.
/// </summary>
public enum Arm64MemoryBaseRegisterKind : byte
{
    /// <summary>
    /// No base register.
    /// </summary>
    None = 0,
    /// <summary>
    /// Base register is either an X register or the stack pointer (SP).
    /// </summary>
    RegisterXOrSP = 1,
    /// <summary>
    /// Base register is an X register.
    /// </summary>
    RegisterX = 2,
}