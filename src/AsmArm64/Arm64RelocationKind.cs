// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines the kind of relocation emitted by the assembler.
/// </summary>
public enum Arm64RelocationKind
{
    /// <summary>
    /// A PC-relative label operand relocation.
    /// </summary>
    PcRelative,
}
