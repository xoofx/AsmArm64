// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to encode the kind of register for ARM64.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64RegisterEncodingKind>))]
internal enum Arm64RegisterEncodingKind : byte
{
    None,
    /// <summary>
    /// 64-bit register
    /// </summary>
    X = 1,
    /// <summary>
    /// 64-bit register or SP (stack pointer)
    /// </summary>
    XOrSP = 2,
    /// <summary>
    /// 32-bit register
    /// </summary>
    W = 3,
    /// <summary>
    /// 32-bit register or WSP (stack pointer)
    /// </summary>
    WOrWSP = 4,
    /// <summary>
    /// Either X or W depending on some encoding
    /// </summary>
    DynamicXOrW = 5,
    /// <summary>
    /// Either B, H, S depending on some encoding
    /// </summary>
    DynamicVScalar = 6,
    /// <summary>
    /// 8-bit register from vector registers
    /// </summary>
    B = 7,
    /// <summary>
    /// 16-bit floating point register from vector registers
    /// </summary>
    H = 8,
    /// <summary>
    /// 32-bit floating point register from vector registers
    /// </summary>
    S = 9,
    /// <summary>
    /// 64-bit floating point register from vector registers
    /// </summary>
    D = 10,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    V = 11,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    Q = 12,
    /// <summary>
    /// SVE register
    /// </summary>
    Z = 13,
    /// <summary>
    /// Control register
    /// </summary>
    C = 14,
}