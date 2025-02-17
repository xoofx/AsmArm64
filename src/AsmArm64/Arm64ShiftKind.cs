// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the type of shift for an ARM64 instruction.
/// </summary>
public enum Arm64ShiftKind : byte
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
    /// <summary>
    /// Rotation right;
    /// </summary>
    ROR,
    /// <summary>
    /// MSL shift;
    /// </summary>
    MSL,
    /// <summary>
    /// Invalid shift encoding;
    /// </summary>
    Invalid,
}

partial class Arm64Factory
{
    /// <summary>
    /// Logical shift left
    /// </summary>
    public static IArm64ShiftKind.LSL _LSL => default;

    /// <summary>
    /// Logical shift right
    /// </summary>
    public static IArm64ShiftKind.LSR _LSR => default;

    /// <summary>
    /// Arithmetic shift right
    /// </summary>
    public static IArm64ShiftKind.ASR _ASR => default;

    /// <summary>
    /// Rotation right;
    /// </summary>
    public static IArm64ShiftKind.ROR _ROR => default;

    /// <summary>
    /// MSL shift;
    /// </summary>
    public static IArm64ShiftKind.MSL _MSL => default;
}
