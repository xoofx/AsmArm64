// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Can be encoded in 5 bits
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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
    FixedInt = 9,
    /// <summary>
    /// A fixed value that is a float
    /// </summary>
    FixedFloatZero = 10,
    /// <summary>
    /// 64-bit immediate 'aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh'
    /// </summary>
    Imm64 = 14,
    /// <summary>
    /// A system register used my MRS and MSR.
    /// </summary>
    SystemRegister = 15,
    /// <summary>
    /// Option for ISB instruction
    /// </summary>
    IsbOption = 18,
}