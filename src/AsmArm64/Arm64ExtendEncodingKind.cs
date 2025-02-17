// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to specify the kind of encoding for an Arm64Extend instruction.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64ExtendEncodingKind : byte
{
    /// <summary>
    /// LSL is preferred if Rn is `11111`
    /// </summary>
    PreferLSLIfRnIs11111,

    /// <summary>
    /// LSL is preferred if Rd or Rn is `11111`
    /// </summary>
    PreferLSLIfRdOrRnIs11111,
}