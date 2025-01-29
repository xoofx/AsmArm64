// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the data synchronization kinds used by the ARM64 DSB (Data Synchronization Barrier) instruction.
/// </summary>
public enum Arm64DataSynchronizationKind : byte
{
    /// <summary>
    /// Outer Shareable. Ensures the completion of memory accesses in the outer shareable domain.
    /// </summary>
    OSH = 0,

    /// <summary>
    /// Non-Shareable. Ensures the completion of memory accesses in the non-shareable domain.
    /// </summary>
    NSH = 1,

    /// <summary>
    /// Inner Shareable. Ensures the completion of memory accesses in the inner shareable domain.
    /// </summary>
    ISH = 2,

    /// <summary>
    /// Full system scope. Ensures the completion of memory accesses across all domains.
    /// </summary>
    SY = 3,

    /// <summary>
    /// The data synchronization kind is undefined.
    /// </summary>
    Undefined = 0xFF
}