// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines preset formatting styles for disassembly output.
/// </summary>
public enum Arm64DisassemblyStyle
{
    /// <summary>
    /// The default AsmArm64 readable style.
    /// </summary>
    Default,

    /// <summary>
    /// A GNU assembler inspired style.
    /// </summary>
    Gas,

    /// <summary>
    /// An LLVM inspired style.
    /// </summary>
    Llvm,
}
