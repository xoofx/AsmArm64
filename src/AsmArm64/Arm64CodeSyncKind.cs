// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the kinds of code synchronization for ARM64.
/// </summary>
public enum Arm64CodeSyncKind : byte
{
    /// <summary>
    /// Code synchronization.
    /// </summary>
    CSYNC = 0,
    /// <summary>
    /// Undefined code synchronization.
    /// </summary>
    Undefined = 0xFF,
}

/// <summary>
/// Represents the kinds of data synchronization for ARM64.
/// </summary>
public enum Arm64DataSyncKind : byte
{
    /// <summary>
    /// Data synchronization.
    /// </summary>
    DSYNC = 0,
    /// <summary>
    /// Undefined data synchronization.
    /// </summary>
    Undefined = 0xFF,
}

/// <summary>
/// Represents the kinds of restrictions by context for ARM64.
/// </summary>
public enum Arm64RestrictionByContextKind : byte
{
    /// <summary>
    /// Restriction by context.
    /// </summary>
    RCTX = 0,
    /// <summary>
    /// Undefined restriction by context.
    /// </summary>
    Undefined = 0xFF,
}

/// <summary>
/// Factory class for creating ARM64 synchronization and restriction kinds.
/// </summary>
partial class Arm64Factory
{
    /// <summary>
    /// Gets the code synchronization kind.
    /// </summary>
    public static Arm64CodeSyncKind CSYNC => Arm64CodeSyncKind.CSYNC;

    /// <summary>
    /// Gets the data synchronization kind.
    /// </summary>
    public static Arm64DataSyncKind DSYNC => Arm64DataSyncKind.DSYNC;

    /// <summary>
    /// Gets the restriction by context kind.
    /// </summary>
    public static Arm64RestrictionByContextKind RCTX => Arm64RestrictionByContextKind.RCTX;
}
