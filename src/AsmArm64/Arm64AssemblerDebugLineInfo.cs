// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents one assembler debug-map entry.
/// </summary>
/// <param name="Kind">The kind of debug information.</param>
/// <param name="Offset">The byte offset in the assembled output.</param>
/// <param name="Address">The absolute address in the assembled output.</param>
/// <param name="FilePath">The source file path, if known.</param>
/// <param name="LineNumber">The source line number, if known.</param>
/// <param name="Name">An optional marker, origin, section, or function name.</param>
/// <param name="InstructionId">The instruction id associated with the entry, if any.</param>
public readonly record struct Arm64AssemblerDebugLineInfo(
    Arm64AssemblerDebugInfoKind Kind,
    uint Offset,
    ulong Address,
    string? FilePath,
    int LineNumber,
    string? Name = null,
    Arm64InstructionId InstructionId = Arm64InstructionId.Invalid);
