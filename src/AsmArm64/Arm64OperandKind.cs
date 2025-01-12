// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Arm64OperandKind : byte
{
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
    /// An immediate
    /// </summary>
    Immediate,
    /// <summary>
    /// A memory operand
    /// </summary>
    Memory,
    /// <summary>
    /// Immediate byte values.
    /// </summary>
    ImmediateByteValues,
    /// <summary>
    /// Shift.
    /// </summary>
    Shift,
    /// <summary>
    /// Shift.
    /// </summary>
    Extend,
}