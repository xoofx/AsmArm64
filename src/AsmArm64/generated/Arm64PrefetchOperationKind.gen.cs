// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
// ------------------------------------------------------------------------------
// This code was generated by AsmArm64.CodeGen.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// ------------------------------------------------------------------------------
// ReSharper disable All
// ------------------------------------------------------------------------------
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace AsmArm64;

/// <summary>
/// The kind of prefetch operation for the PRFM instruction.
/// </summary>
public enum Arm64PrefetchOperationKind : byte
{
    /// <summary>
    /// Not a valid value.
    /// </summary>
    /// <summary>
    /// Prefetch Data Level 1, keep in cache.
    /// </summary>
    PLDL1KEEP = 0,
    /// <summary>
    /// Prefetch Data Level 1, stream (do not retain in cache).
    /// </summary>
    PLDL1STRM = 1,
    /// <summary>
    /// Prefetch Data Level 2, keep in cache.
    /// </summary>
    PLDL2KEEP = 2,
    /// <summary>
    /// Prefetch Data Level 2, stream (do not retain in cache).
    /// </summary>
    PLDL2STRM = 3,
    /// <summary>
    /// Prefetch Data Level 3, keep in cache.
    /// </summary>
    PLDL3KEEP = 4,
    /// <summary>
    /// Prefetch Data Level 3, stream (do not retain in cache).
    /// </summary>
    PLDL3STRM = 5,
    /// <summary>
    /// Prefetch Data SLC (System Level Cache), keep in cache.
    /// </summary>
    PLDSLCKEEP = 6,
    /// <summary>
    /// Prefetch Data SLC (System Level Cache), stream (do not retain in cache).
    /// </summary>
    PLDSLCSTRM = 7,
    /// <summary>
    /// Prefetch Instruction Level 1, keep in cache.
    /// </summary>
    PLIL1KEEP = 8,
    /// <summary>
    /// Prefetch Instruction Level 1, stream (do not retain in cache).
    /// </summary>
    PLIL1STRM = 9,
    /// <summary>
    /// Prefetch Instruction Level 2, keep in cache.
    /// </summary>
    PLIL2KEEP = 10,
    /// <summary>
    /// Prefetch Instruction Level 2, stream (do not retain in cache).
    /// </summary>
    PLIL2STRM = 11,
    /// <summary>
    /// Prefetch Instruction Level 3, keep in cache.
    /// </summary>
    PLIL3KEEP = 12,
    /// <summary>
    /// Prefetch Instruction Level 3, stream (do not retain in cache).
    /// </summary>
    PLIL3STRM = 13,
    /// <summary>
    /// Prefetch Instruction SLC (System Level Cache), keep in cache.
    /// </summary>
    PLISLCKEEP = 14,
    /// <summary>
    /// Prefetch Instruction SLC (System Level Cache), stream (do not retain in cache).
    /// </summary>
    PLISLCSTRM = 15,
    /// <summary>
    /// Prefetch Store Level 1, keep in cache.
    /// </summary>
    PSTL1KEEP = 16,
    /// <summary>
    /// Prefetch Store Level 1, stream (do not retain in cache).
    /// </summary>
    PSTL1STRM = 17,
    /// <summary>
    /// Prefetch Store Level 2, keep in cache.
    /// </summary>
    PSTL2KEEP = 18,
    /// <summary>
    /// Prefetch Store Level 2, stream (do not retain in cache).
    /// </summary>
    PSTL2STRM = 19,
    /// <summary>
    /// Prefetch Store Level 3, keep in cache.
    /// </summary>
    PSTL3KEEP = 20,
    /// <summary>
    /// Prefetch Store Level 3, stream (do not retain in cache).
    /// </summary>
    PSTL3STRM = 21,
    /// <summary>
    /// Prefetch Store SLC (System Level Cache), keep in cache.
    /// </summary>
    PSTSLCKEEP = 22,
    /// <summary>
    /// Prefetch Store SLC (System Level Cache), stream (do not retain in cache).
    /// </summary>
    PSTSLCSTRM = 23,
    /// <summary>
    /// Immediate Read.
    /// </summary>
    IR = 24,
    Undefined = 0xFF,
}

partial class Arm64Factory
{
    /// <summary>
    /// Prefetch Data Level 1, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLDL1KEEP => Arm64PrefetchOperationKind.PLDL1KEEP;
    /// <summary>
    /// Prefetch Data Level 1, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLDL1STRM => Arm64PrefetchOperationKind.PLDL1STRM;
    /// <summary>
    /// Prefetch Data Level 2, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLDL2KEEP => Arm64PrefetchOperationKind.PLDL2KEEP;
    /// <summary>
    /// Prefetch Data Level 2, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLDL2STRM => Arm64PrefetchOperationKind.PLDL2STRM;
    /// <summary>
    /// Prefetch Data Level 3, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLDL3KEEP => Arm64PrefetchOperationKind.PLDL3KEEP;
    /// <summary>
    /// Prefetch Data Level 3, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLDL3STRM => Arm64PrefetchOperationKind.PLDL3STRM;
    /// <summary>
    /// Prefetch Data SLC (System Level Cache), keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLDSLCKEEP => Arm64PrefetchOperationKind.PLDSLCKEEP;
    /// <summary>
    /// Prefetch Data SLC (System Level Cache), stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLDSLCSTRM => Arm64PrefetchOperationKind.PLDSLCSTRM;
    /// <summary>
    /// Prefetch Instruction Level 1, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLIL1KEEP => Arm64PrefetchOperationKind.PLIL1KEEP;
    /// <summary>
    /// Prefetch Instruction Level 1, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLIL1STRM => Arm64PrefetchOperationKind.PLIL1STRM;
    /// <summary>
    /// Prefetch Instruction Level 2, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLIL2KEEP => Arm64PrefetchOperationKind.PLIL2KEEP;
    /// <summary>
    /// Prefetch Instruction Level 2, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLIL2STRM => Arm64PrefetchOperationKind.PLIL2STRM;
    /// <summary>
    /// Prefetch Instruction Level 3, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLIL3KEEP => Arm64PrefetchOperationKind.PLIL3KEEP;
    /// <summary>
    /// Prefetch Instruction Level 3, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLIL3STRM => Arm64PrefetchOperationKind.PLIL3STRM;
    /// <summary>
    /// Prefetch Instruction SLC (System Level Cache), keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PLISLCKEEP => Arm64PrefetchOperationKind.PLISLCKEEP;
    /// <summary>
    /// Prefetch Instruction SLC (System Level Cache), stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PLISLCSTRM => Arm64PrefetchOperationKind.PLISLCSTRM;
    /// <summary>
    /// Prefetch Store Level 1, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PSTL1KEEP => Arm64PrefetchOperationKind.PSTL1KEEP;
    /// <summary>
    /// Prefetch Store Level 1, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PSTL1STRM => Arm64PrefetchOperationKind.PSTL1STRM;
    /// <summary>
    /// Prefetch Store Level 2, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PSTL2KEEP => Arm64PrefetchOperationKind.PSTL2KEEP;
    /// <summary>
    /// Prefetch Store Level 2, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PSTL2STRM => Arm64PrefetchOperationKind.PSTL2STRM;
    /// <summary>
    /// Prefetch Store Level 3, keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PSTL3KEEP => Arm64PrefetchOperationKind.PSTL3KEEP;
    /// <summary>
    /// Prefetch Store Level 3, stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PSTL3STRM => Arm64PrefetchOperationKind.PSTL3STRM;
    /// <summary>
    /// Prefetch Store SLC (System Level Cache), keep in cache.
    /// </summary>
    public static Arm64PrefetchOperationKind PSTSLCKEEP => Arm64PrefetchOperationKind.PSTSLCKEEP;
    /// <summary>
    /// Prefetch Store SLC (System Level Cache), stream (do not retain in cache).
    /// </summary>
    public static Arm64PrefetchOperationKind PSTSLCSTRM => Arm64PrefetchOperationKind.PSTSLCSTRM;
    /// <summary>
    /// Immediate Read.
    /// </summary>
    public static Arm64PrefetchOperationKind IR => Arm64PrefetchOperationKind.IR;
}
