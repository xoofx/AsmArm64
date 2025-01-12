// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Arm64EnumEncodingKind
{
    /// <summary>
    /// No enum encoding
    /// </summary>
    None,
    /// <summary>
    /// The Arm64Conditional enum encoding.
    /// </summary>
    Conditional,
    /// <summary>
    /// Branch Target Identification.
    /// </summary>
    Bti,
    /// <summary>
    /// The data synchronization option defined by DSB instruction.
    /// </summary>
    DataSynchronizationOption,
    /// <summary>
    /// The policy defined by the STSHH instruction (Store Shared Hint). (KEEP or STRM)
    /// </summary>
    StoredSharedHintPolicy,
    /// <summary>
    /// The PSTATE field used by MSR (immediate) instruction.
    /// </summary>
    PStateField,
    /// <summary>
    /// A barrier operation limit used by DMB_bo_barriers and DSB_bo_barriers instructions.
    /// </summary>
    BarrierOperationLimit,
    /// <summary>
    /// 
    /// </summary>
    PrefetchOperation,

}