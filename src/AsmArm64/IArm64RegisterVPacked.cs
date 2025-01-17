// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines the interface for a typed arrangement of a vector register.
/// </summary>
public interface IArm64RegisterVPacked : IArm64RegisterVTyped
{
    /// <summary>
    /// Gets the number of valid elements in the vector register.
    /// </summary>
    int ElementCount { get; }
}