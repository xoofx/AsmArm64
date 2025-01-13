// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64ConstEncodingKind : byte
{
    None,
    /// <summary>
    /// Used by instruction CHKFEAT_hf_hints -> CHKFEAT X16
    /// </summary>
    X16,
    /// <summary>
    /// Used by instruction: GCSB_hd_hints -> GCSB DSYNC
    /// </summary>
    DSYNC,
    /// <summary>
    /// Used by instruction: PSB_hc_hints -> PSB CSYNC and TSB_hc_hints -> TSB CSYNC
    /// </summary>
    CSYNC,
}