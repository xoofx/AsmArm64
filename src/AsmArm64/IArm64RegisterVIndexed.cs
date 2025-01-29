// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines the interface for a vector register with an index (V0.S[1], V1.D[0]...etc.)
/// </summary>
public interface IArm64RegisterVIndexed : IArm64RegisterV
{
    /// <summary>
    /// Gets the index of the element in the vector register.
    /// </summary>
    int ElementIndex { get; }
}