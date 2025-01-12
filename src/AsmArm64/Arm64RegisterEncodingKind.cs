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
    RegX,
    /// <summary>
    /// 64-bit register or SP (stack pointer)
    /// </summary>
    RegXOrSP,
    /// <summary>
    /// 32-bit register
    /// </summary>
    RegW,
    /// <summary>
    /// 32-bit register or WSP (stack pointer)
    /// </summary>
    RegWOrWSP,
    /// <summary>
    /// Either X or W depending on some encoding
    /// </summary>
    DynamicRegXOrW,
    /// <summary>
    /// Either B, H, S depending on some encoding
    /// </summary>
    DynamicRegVScalar,
    /// <summary>
    /// 8-bit register from vector registers
    /// </summary>
    RegB,
    /// <summary>
    /// 16-bit floating point register from vector registers
    /// </summary>
    RegH,
    /// <summary>
    /// 32-bit floating point register from vector registers
    /// </summary>
    RegS,
    /// <summary>
    /// 64-bit floating point register from vector registers
    /// </summary>
    RegD,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    RegV,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    RegQ,
    /// <summary>
    /// SVE register
    /// </summary>
    RegZ,
    /// <summary>
    /// Control register
    /// </summary>
    RegC,
}