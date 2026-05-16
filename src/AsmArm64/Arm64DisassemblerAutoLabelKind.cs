// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines which PC-relative disassembler targets are converted to generated local labels.
/// </summary>
[Flags]
public enum Arm64DisassemblerAutoLabelKind
{
    /// <summary>
    /// Do not generate local labels for any target.
    /// </summary>
    None = 0,

    /// <summary>
    /// Generate a label before the first instruction when <see cref="Arm64DisassemblerOptions.PrintLabelBeforeFirstInstruction"/> is enabled.
    /// </summary>
    FirstInstruction = 1 << 0,

    /// <summary>
    /// Generate labels for unconditional branch targets.
    /// </summary>
    Branches = 1 << 1,

    /// <summary>
    /// Generate labels for call targets.
    /// </summary>
    Calls = 1 << 2,

    /// <summary>
    /// Generate labels for conditional branch targets.
    /// </summary>
    ConditionalBranches = 1 << 3,

    /// <summary>
    /// Generate labels for compare-and-branch and test-and-branch targets.
    /// </summary>
    TestCompareBranches = 1 << 4,

    /// <summary>
    /// Generate labels for load-literal targets.
    /// </summary>
    LiteralLoads = 1 << 5,

    /// <summary>
    /// Generate labels for <c>ADR</c> targets.
    /// </summary>
    Adr = 1 << 6,

    /// <summary>
    /// Generate labels for <c>ADRP</c> targets.
    /// </summary>
    Adrp = 1 << 7,

    /// <summary>
    /// Generate labels for all supported branch-like targets.
    /// </summary>
    AllBranches = Branches | Calls | ConditionalBranches | TestCompareBranches,

    /// <summary>
    /// Generate labels for all PC-relative operands.
    /// </summary>
    AllPcRelative = AllBranches | LiteralLoads | Adr | Adrp,

    /// <summary>
    /// Generate all local labels supported by the disassembler.
    /// </summary>
    All = FirstInstruction | AllPcRelative,
}
