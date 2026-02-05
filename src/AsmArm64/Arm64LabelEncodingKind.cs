// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to encode a label.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64LabelEncodingKind>))]
enum Arm64LabelEncodingKind : byte
{
    None,
    /// <summary>
    /// A signed offset.
    /// </summary>
    ByteOffset = 1,

    /// <summary>
    /// A signed offset multiplied by 4
    /// </summary>
    OffsetMul4 = 2,

    /// <summary>
    /// A negative offset multiplied by 4 encoded as an unsigned value
    /// </summary>
    NegativeEncodedAsUnsigned = 3,

    /// <summary>
    /// A signed offset multiplied by 4096 encoded as an unsigned value
    /// </summary>
    PageOffset = 4,
}