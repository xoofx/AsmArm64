// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Encoding fits within 2 bits.
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
    /// Standard 4 bit encoding.
    /// </summary>
    Std4,
    /// <summary>
    /// Special size:M:Rm encoding
    /// size:(22:2),M:(20:1),Rm:(16:4)
    /// With Size:
    /// * BitFields = 00, Value = RESERVED
    /// * BitFields = 01, Value = UInt('0':Rm)
    /// * BitFields = 10, Value = UInt(M:Rm)
    /// * BitFields = 11, Value = RESERVED
    /// </summary>
    SpecialMRm,
}