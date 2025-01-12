// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64ShiftEncodingKind : byte
{
    /// <summary>
    /// The shift amount is fixed.
    /// </summary>
    Fixed,

    /// <summary>
    /// The shift is encoded with LSL, LSR, ASR.
    /// </summary>
    Shift3,

    /// <summary>
    /// The shift is encoded with LSL, LSR, ASR, ROR.
    /// </summary>
    Shift4,

    /// <summary>
    /// A zero shift.
    /// </summary>
    Lsl0,

    /// <summary>
    /// Only amount is encoded
    /// </summary>
    Lsl
}