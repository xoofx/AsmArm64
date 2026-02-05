// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to encode the kind of shift for ARM64.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64ShiftEncodingKind>))]
enum Arm64ShiftEncodingKind : byte
{
    None,
    /// <summary>
    /// The shift is encoded with LSL, LSR, ASR.
    /// </summary>
    Shift3,

    /// <summary>
    /// The shift is encoded with LSL, LSR, ASR, ROR.
    /// </summary>
    Shift4,

    /// <summary>
    /// A shift amount if fixed and is zero.
    /// </summary>
    Lsl0,

    /// <summary>
    /// The shift amount must be zero or 12.
    /// </summary>
    Lsl0Or12,

    /// <summary>
    /// Only amount is encoded
    /// </summary>
    Lsl,

    /// <summary>
    /// Only amount is encoded. The amount is encoded in 1 or 2 bit and scaled by 8, giving [0, 8], or [0, 8, 16, 24]
    /// </summary>
    LslScale8,

    /// <summary>
    /// Only amount is encoded. The amount is encoded in 1 bit ((bit + 1) * 8) giving [8, 16]
    /// </summary>
    Msl,

    /// <summary>
    /// Only amount is encoded. The amount is encoded in 1 or 2 bit and scaled by 16, giving [0, 16], or [0, 16, 32, 48]
    /// </summary>
    LslScale16,
}