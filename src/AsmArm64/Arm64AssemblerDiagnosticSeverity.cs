// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Describes the severity of an assembler diagnostic.
/// </summary>
public enum Arm64AssemblerDiagnosticSeverity
{
    /// <summary>
    /// An informational diagnostic.
    /// </summary>
    Info,

    /// <summary>
    /// A warning diagnostic.
    /// </summary>
    Warning,

    /// <summary>
    /// An error diagnostic.
    /// </summary>
    Error,
}
