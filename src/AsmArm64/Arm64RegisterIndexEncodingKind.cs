// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to encode the kind of register index for ARM64.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum Arm64RegisterIndexEncodingKind : byte
{
    /// <summary>
    /// No encoding. The register is fixed.
    /// </summary>
    None,
    /// <summary>
    /// Standard 5 bit encoding.
    /// </summary>
    Std5,
    /// <summary>
    /// Standard 5 bit encoding + 1.
    /// </summary>
    Std5Plus1,
    /// <summary>
    /// Standard 4 bit encoding.
    /// </summary>
    Std4,
    /// <summary>
    /// Special encoding
    /// </summary>
    BitMapExtract,
    /// <summary>
    /// Fixed register.
    /// </summary>
    Fixed,
}