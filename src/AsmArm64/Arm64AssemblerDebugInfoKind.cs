// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Describes the kind of debug-map entry recorded by an <see cref="Arm64Assembler"/>.
/// </summary>
public enum Arm64AssemblerDebugInfoKind
{
    /// <summary>
    /// The entry marks the beginning of an assembly origin/session.
    /// </summary>
    OriginBegin,

    /// <summary>
    /// The entry maps an emitted instruction to a source file and line.
    /// </summary>
    LineInfo,

    /// <summary>
    /// The entry marks the end of an assembly session.
    /// </summary>
    End,
}
