// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines the interface for a register that is a vector register.
/// </summary>
public interface IArm64RegisterV : IArm64Register
{
    /// <summary>
    /// Gets the kind of vector register.
    /// </summary>
    Arm64RegisterVKind VKind { get; }
}