// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to encode the kind of memory extend for ARM64.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64MemoryExtendEncodingKind>))]
enum Arm64MemoryExtendEncodingKind : byte
{
    /// <summary>
    /// No extend.
    /// </summary>
    None = 0,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = LSL
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 0 (bit 0 - The amount 0 is absent, bit 1: The amount 0 is present)
    /// </summary>
    Shift0 = 1,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = LSL
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 1 (when bit set)
    /// </summary>
    Shift1 = 2,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = LSL
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 2 (when bit set)
    /// </summary>
    Shift2 = 3,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = LSL
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 3 (when bit set)
    /// </summary>
    Shift3 = 4,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = LSL
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 4 (when bit set)
    /// </summary>
    Shift4 = 5,
}