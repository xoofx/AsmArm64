// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a label id in ARM64 used by <see cref="Arm64Assembler"/>.
/// </summary>
public readonly record struct Arm64LabelId
{
    internal Arm64LabelId(int index)
    {
        Index = index;
    }

    /// <summary>
    /// Gets the index of this label registered to a particular <see cref="Arm64Assembler"/>.
    /// </summary>
    public int Index { get; }
}