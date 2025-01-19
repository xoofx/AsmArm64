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
    None,

    /// <summary>
    /// Outer Shareable Load. Ensures the completion of load memory accesses in the outer shareable domain.
    /// </summary>
    OSHLD = 1,

    /// <summary>
    /// Outer Shareable Store. Ensures the completion of store memory accesses in the outer shareable domain.
    /// </summary>
    OSHST = 2,

    /// <summary>
    /// Outer Shareable. Ensures the completion of all memory accesses in the outer shareable domain.
    /// </summary>
    OSH = 3,

    /// <summary>
    /// Non-Shareable Load. Ensures the completion of load memory accesses in the non-shareable domain.
    /// </summary>
    NSHLD = 4,

    /// <summary>
    /// Non-Shareable Store. Ensures the completion of store memory accesses in the non-shareable domain.
    /// </summary>
    NSHST = 5,

    /// <summary>
    /// Non-Shareable. Ensures the completion of all memory accesses in the non-shareable domain.
    /// </summary>
    NSH = 6,

    /// <summary>
    /// Inner Shareable Load. Ensures the completion of load memory accesses in the inner shareable domain.
    /// </summary>
    ISHLD = 7,

    /// <summary>
    /// Inner Shareable Store. Ensures the completion of store memory accesses in the inner shareable domain.
    /// </summary>
    ISHST = 8,

    /// <summary>
    /// Inner Shareable. Ensures the completion of all memory accesses in the inner shareable domain.
    /// </summary>
    ISH = 9,

    /// <summary>
    /// Load. Ensures the completion of load memory accesses across all domains.
    /// </summary>
    LD = 10,

    /// <summary>
    /// Store. Ensures the completion of store memory accesses across all domains.
    /// </summary>
    ST = 11,

    /// <summary>
    /// Full system scope. Ensures the completion of all memory accesses across all domains.
    /// </summary>
    SY = 12,
}