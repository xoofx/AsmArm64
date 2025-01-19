// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Can be encoded in 4 bits.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Arm64OperandKind : byte
{
    /// <summary>
    /// Operand is not defined.
    /// </summary>
    None,
    /// <summary>
    /// Register
    /// </summary>
    Register = 1,
    /// <summary>
    /// Register group {X0,X1...}
    /// </summary>
    RegisterGroup = 2,
    /// <summary>
    /// A memory operand
    /// </summary>
    Memory = 3,
    /// <summary>
    /// An immediate
    /// </summary>
    Immediate = 4,
    /// <summary>
    /// Label.
    /// </summary>
    Label = 5,
    /// <summary>
    /// Shift.
    /// </summary>
    Shift = 6,
    /// <summary>
    /// Shift.
    /// </summary>
    Extend = 7,
    /// <summary>
    /// An enum value
    /// </summary>
    Enum = 8,
    /// <summary>
    /// A PState field value used by MSR (immediate) instruction.
    /// </summary>
    PStateField = 9,
    /// <summary>
    /// A const value but not actually a real operand.
    /// </summary>
    Const = 10,
}