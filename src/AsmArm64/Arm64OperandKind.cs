// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

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
    Register,
    /// <summary>
    /// Register group {X0,X1...}
    /// </summary>
    RegisterGroup,
    /// <summary>
    /// A memory operand
    /// </summary>
    Memory,
    /// <summary>
    /// An immediate
    /// </summary>
    Immediate,
    /// <summary>
    /// Immediate byte values.
    /// </summary>
    ImmediateByteValues,
    /// <summary>
    /// Label.
    /// </summary>
    Label,
    /// <summary>
    /// Shift.
    /// </summary>
    Shift,
    /// <summary>
    /// Shift.
    /// </summary>
    Extend,
    /// <summary>
    /// An enum value
    /// </summary>
    Enum,
    /// <summary>
    /// A PState field value used by MSR (immediate) instruction.
    /// </summary>
    PStateField
}