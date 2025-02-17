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
    /// KEEP policy. Indicates that the data should remain in the cache for future access.
    /// </summary>
    KEEP = 0,

    /// <summary>
    /// STRM (Stream) policy. Indicates that the data should be treated as streaming and not retained in the cache.
    /// </summary>
    STRM = 1,

    /// <summary>
    /// The shared hint policy kind is undefined.
    /// </summary>
    Undefined = 0xFF
}

partial class Arm64Factory
{
    /// <summary>
    /// KEEP policy. Indicates that the data should remain in the cache for future access.
    /// </summary>
    public static Arm64StoredSharedHintPolicyKind KEEP => Arm64StoredSharedHintPolicyKind.KEEP;
    /// <summary>
    /// STRM (Stream) policy. Indicates that the data should be treated as streaming and not retained in the cache.
    /// </summary>
    public static Arm64StoredSharedHintPolicyKind STRM => Arm64StoredSharedHintPolicyKind.STRM;
}