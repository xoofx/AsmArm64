// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum Arm64RegisterVectorArrangementEncodingKind : byte
{
    None,

    /// <summary>
    /// Dynamic
    /// </summary>
    T,
    B,
    H,
    S,
    D,

    T_16B,
    T_8B,
    T_4B,
    T_2B,

    T_2H,
    T_4H,
    T_8H,

    T_2S,
    T_4S,

    T_1D,
    T_2D,

    T_1Q,

    Reserved,
}