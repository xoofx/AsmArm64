// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a label in ARM64.
/// </summary>
/// <param name="Address">The address of this label.</param>
/// <param name="Name">The optional name associated with this label.</param>
public readonly record struct Arm64Label(ulong Address, string? Name)
{
    /// <summary>
    /// Gets a value indicating whether the label is bound.
    /// </summary>
    public bool IsBound => Address != 0 && Address != ulong.MaxValue;

    /// <summary>
    /// Gets a value indicating whether the label is empty.
    /// </summary>
    public bool IsEmpty => Address == 0 && Name is null;

    /// <inheritdoc />
    public override string ToString() => Name ?? $"0x{Address:X16}";
}