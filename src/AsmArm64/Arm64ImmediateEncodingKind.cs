// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// The encoding kind for an immediate value.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64ImmediateEncodingKind>))]
enum Arm64ImmediateEncodingKind : byte
{
    None,
    /// <summary>
    /// A regular immediate
    /// </summary>
    Regular = 1,
    /// <summary>
    /// The bitvalues are extracted and mapped to a real value.
    /// </summary>
    BitMapExtract = 2,
    /// <summary>
    /// A fixed value
    /// </summary>
    FixedInt = 3,
    /// <summary>
    /// A fixed value that is a float
    /// </summary>
    FixedFloatZero = 4,
    /// <summary>
    /// Option for ISB instruction
    /// </summary>
    IsbOption = 5,
}