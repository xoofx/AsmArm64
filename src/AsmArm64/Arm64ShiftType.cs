// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the type of shift for an ARM64 instruction.
/// </summary>
public enum Arm64ShiftType : byte
{
    /// <summary>
    /// Logical shift left
    /// </summary>
    LSL,
    /// <summary>
    /// Logical shift right
    /// </summary>
    LSR,
    /// <summary>
    /// Arithmetic shift right
    /// </summary>
    ASR,
}