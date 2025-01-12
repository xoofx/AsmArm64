// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64MemoryExtendEncodingKind : byte
{
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 0 (bit 0, bit 1 is not possible)
    /// </summary>
    NoLsl = 0,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 1 (when bit set)
    /// </summary>
    Shift1 = 1,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 2 (when bit set)
    /// </summary>
    Shift2 = 2,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 3 (when bit set)
    /// </summary>
    Shift3 = 3,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 4 (when bit set)
    /// </summary>
    Shift4 = 4,
}