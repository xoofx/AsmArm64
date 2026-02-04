// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// The kind of ARM64 operand.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64OperandKind>))]
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
    /// SystemRegister
    /// </summary>
    SystemRegister = 3,
    /// <summary>
    /// A memory operand
    /// </summary>
    Memory = 4,
    /// <summary>
    /// An immediate
    /// </summary>
    Immediate = 5,
    /// <summary>
    /// Label.
    /// </summary>
    Label = 6,
    /// <summary>
    /// Shift.
    /// </summary>
    Shift = 7,
    /// <summary>
    /// Shift.
    /// </summary>
    Extend = 8,
    /// <summary>
    /// An enum value
    /// </summary>
    Enum = 9,
}