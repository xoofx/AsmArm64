// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the barrier operation limit kinds used by the ARM64 DMB (Data Memory Barrier) instruction.
/// </summary>
public enum Arm64BarrierOperationLimitKind : byte
{
    /// <summary>
    /// No barrier operation specified.
    /// </summary>
    Undefined,

    /// <summary>
    /// Outer Shareable Load. Ensures the completion of load memory accesses in the outer shareable domain.
    /// </summary>
    OSHLD = 0b0001,

    /// <summary>
    /// Outer Shareable Store. Ensures the completion of store memory accesses in the outer shareable domain.
    /// </summary>
    OSHST = 0b0010,

    /// <summary>
    /// Outer Shareable. Ensures the completion of all memory accesses in the outer shareable domain.
    /// </summary>
    OSH = 0b0011,

    /// <summary>
    /// Non-Shareable Load. Ensures the completion of load memory accesses in the non-shareable domain.
    /// </summary>
    NSHLD = 0b0101,

    /// <summary>
    /// Non-Shareable Store. Ensures the completion of store memory accesses in the non-shareable domain.
    /// </summary>
    NSHST = 0b0110,

    /// <summary>
    /// Non-Shareable. Ensures the completion of all memory accesses in the non-shareable domain.
    /// </summary>
    NSH = 0b0111,

    /// <summary>
    /// Inner Shareable Load. Ensures the completion of load memory accesses in the inner shareable domain.
    /// </summary>
    ISHLD = 0b1001,

    /// <summary>
    /// Inner Shareable Store. Ensures the completion of store memory accesses in the inner shareable domain.
    /// </summary>
    ISHST = 0b1010,

    /// <summary>
    /// Inner Shareable. Ensures the completion of all memory accesses in the inner shareable domain.
    /// </summary>
    ISH = 0b1011,

    /// <summary>
    /// Load. Ensures the completion of load memory accesses across all domains.
    /// </summary>
    LD = 0b1101,

    /// <summary>
    /// Store. Ensures the completion of store memory accesses across all domains.
    /// </summary>
    ST = 0b1110,

    /// <summary>
    /// Full system scope. Ensures the completion of all memory accesses across all domains.
    /// </summary>
    SY = 0b1111,
}

partial class Arm64Factory
{
    public static Arm64BarrierOperationLimitKind OSHLD => Arm64BarrierOperationLimitKind.OSHLD;
    public static Arm64BarrierOperationLimitKind OSHST => Arm64BarrierOperationLimitKind.OSHST;
    public static Arm64BarrierOperationLimitKind NSHLD => Arm64BarrierOperationLimitKind.NSHLD;
    public static Arm64BarrierOperationLimitKind NSHST => Arm64BarrierOperationLimitKind.NSHST;
    public static Arm64BarrierOperationLimitKind ISHLD => Arm64BarrierOperationLimitKind.ISHLD;
    public static Arm64BarrierOperationLimitKind ISHST => Arm64BarrierOperationLimitKind.ISHST;
    public static Arm64BarrierOperationLimitKind LD => Arm64BarrierOperationLimitKind.LD;
    public static Arm64BarrierOperationLimitKind ST => Arm64BarrierOperationLimitKind.ST;
}