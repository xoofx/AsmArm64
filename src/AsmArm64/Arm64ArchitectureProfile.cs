// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// A list of all ARM64 architecture profiles.
/// </summary>
public enum Arm64ArchitectureProfile : byte
{
    /// <summary>
    /// Undefined profile.
    /// </summary>
    Invalid,

    /// <summary>
    /// A profile.
    /// </summary>
    A,

    /// <summary>
    /// The R profile.
    /// </summary>
    R,

    /// <summary>
    /// The M profile.
    /// </summary>
    M,
}