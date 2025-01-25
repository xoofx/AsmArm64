// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64ImmediateValueEncodingKind : byte
{
    None,
    /// <summary>
    /// value / 2
    /// </summary>
    ValueDivideBy2,
    /// <summary>
    /// value / 4
    /// </summary>
    ValueDivideBy4,
    /// <summary>
    /// value / 8
    /// </summary>
    ValueDivideBy8,
    /// <summary>
    /// value / 16
    /// </summary>
    ValueDivideBy16,
    /// <summary>
    /// (value + 1) &gt;&gt; 6
    /// </summary>
    ValuePlus1ShiftLeft6,
    /// <summary>
    /// 1 bit sign, 3 bits exponent, 4 bits mantissa
    /// </summary>
    SignedFloatExp3Mantissa4,
    /// <summary>
    /// (32 - value) &amp; 0x1F
    /// </summary>
    _32_Minus_Value_Mod32,
    /// <summary>
    /// (64 - value) &amp; 0x3F
    /// </summary>
    _64_Minus_Value_Mod64,
    /// <summary>
    /// (32 - value)
    /// </summary>
    _32_Minus_Value,
    /// <summary>
    /// (64 - value)
    /// </summary>
    _64_Minus_Value,
    _128_Minus_Value,
    Value_Minus_64,
    /// <summary>
    /// lsb + width - 1
    /// </summary>
    LsbPlusWidthMinus1,
    /// <summary>
    /// value &amp; 0x3F
    /// </summary>
    ValueMod64Plus1,
    DecodeBitMask32,
    DecodeBitMask64,
}