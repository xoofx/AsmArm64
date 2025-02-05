// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents an interface for ARM64 memory with an extend operation.
/// </summary>
public interface IArm64MemoryExtend : ISpanFormattable
{
    /// <summary>
    /// Gets the kind of the extend operation.
    /// </summary>
    Arm64ExtendKind Kind { get; }

    /// <summary>
    /// Gets the amount of the extend operation.
    /// </summary>
    byte Amount { get; }
}
