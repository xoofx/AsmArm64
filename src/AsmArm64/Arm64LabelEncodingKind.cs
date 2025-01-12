// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64LabelEncodingKind : byte
{
    None,
    /// <summary>
    /// A signed offset multiplied by 4
    /// </summary>
    StandardOffset,

    /// <summary>
    /// A negative offset multiplied by 4 encoded as an unsigned value
    /// </summary>
    NegativeEncodedAsUnsigned,

    /// <summary>
    /// A signed offset multiplied by 4096 encoded as an unsigned value
    /// </summary>
    PageOffset,
}