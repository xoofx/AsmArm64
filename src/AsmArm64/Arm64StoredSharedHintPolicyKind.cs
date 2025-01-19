// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the shared hint policy kinds used by the ARM64 STSHH (Store Shared Hint) instruction.
/// </summary>
public enum Arm64StoredSharedHintPolicyKind : byte
{
    /// <summary>
    /// No shared hint policy specified.
    /// </summary>
    None,

    /// <summary>
    /// KEEP policy. Indicates that the data should remain in the cache for future access.
    /// </summary>
    KEEP = 1,

    /// <summary>
    /// STRM (Stream) policy. Indicates that the data should be treated as streaming and not retained in the cache.
    /// </summary>
    STRM = 2,
}