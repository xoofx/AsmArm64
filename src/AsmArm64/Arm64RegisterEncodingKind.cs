// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum Arm64RegisterEncodingKind : byte
{
    None,
    /// <summary>
    /// 64-bit register
    /// </summary>
    X,
    /// <summary>
    /// 64-bit register or SP (stack pointer)
    /// </summary>
    XOrSP,
    /// <summary>
    /// 32-bit register
    /// </summary>
    W,
    /// <summary>
    /// 32-bit register or WSP (stack pointer)
    /// </summary>
    WOrWSP,
    /// <summary>
    /// Either X or W depending on some encoding
    /// </summary>
    DynamicXOrW,
    /// <summary>
    /// Either B, H, S depending on some encoding
    /// </summary>
    DynamicVScalar,
    /// <summary>
    /// 8-bit register from vector registers
    /// </summary>
    B,
    /// <summary>
    /// 16-bit floating point register from vector registers
    /// </summary>
    H,
    /// <summary>
    /// 32-bit floating point register from vector registers
    /// </summary>
    S,
    /// <summary>
    /// 64-bit floating point register from vector registers
    /// </summary>
    D,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    V,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    Q,
    /// <summary>
    /// SVE register
    /// </summary>
    Z,
    /// <summary>
    /// Control register
    /// </summary>
    C,
}