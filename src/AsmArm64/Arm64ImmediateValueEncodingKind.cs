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
    /// <summary>
    /// 8-bit `abcdefgh` to `aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh`
    /// </summary>
    ValueImm64,
    /// <summary>
    /// Is a 4-bit unsigned immediate, in the range 0 to 15, encoded in the "CRm" field. Restricted to the range 0 to 1, encoded in "CRm&gt;0>", when &gt;pstatefield> is ALLINT, PM, SVCRSM, SVCRSMZA, or SVCRZA.
    /// </summary>
    ValueMsrImmediate,

    /// <summary>
    /// The lowest 2 bits encode a shift: * 16 for 32 bit and bitwise inverse
    /// </summary>
    InvertValueShiftWide32,

    /// <summary>
    /// The lowest 2 bits encode a shift: * 16 for 64 bit
    /// </summary>
    ValueShiftWide64,
}