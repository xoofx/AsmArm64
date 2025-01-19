// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Can be encoded in 3 bits
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Arm64EnumKind : byte
{
    /// <summary>
    /// No enum encoding
    /// </summary>
    None,
    /// <summary>
    /// The Arm64Conditional enum encoding.
    /// </summary>
    Conditional = 1,
    /// <summary>
    /// Branch Target Identification.
    /// </summary>
    BranchTargetIdentification = 2,
    /// <summary>
    /// The data synchronization option defined by DSB instruction.
    /// </summary>
    DataSynchronizationOption = 3,
    /// <summary>
    /// The policy defined by the STSHH instruction (Store Shared Hint). (KEEP or STRM)
    /// </summary>
    StoredSharedHintPolicy = 4,
    /// <summary>
    /// The PSTATE field used by MSR (immediate) instruction.
    /// </summary>
    ProcessStateField = 5,
    /// <summary>
    /// A barrier operation limit used by DMB_bo_barriers and DSB_bo_barriers instructions.
    /// </summary>
    BarrierOperationLimit = 6,
    /// <summary>
    /// The prefetch operation used by PRFM instruction.
    /// </summary>
    PrefetchOperation = 7,
    /// <summary>
    /// The range prefetch operation used by RPRFM instruction.
    /// </summary>
    RangePrefetchOperation = 8,
    /// <summary>
    /// Used by instruction: GCSB_hd_hints -> GCSB DSYNC
    /// </summary>
    DataSync,
    /// <summary>
    /// Used by instruction: PSB_hc_hints -> PSB CSYNC and TSB_hc_hints -> TSB CSYNC
    /// </summary>
    CodeSync,
}