// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines how the disassembler handles trailing bytes that do not form a complete ARM64 instruction.
/// </summary>
public enum Arm64InvalidDataMode
{
    /// <summary>
    /// Throw an <see cref="ArgumentException"/> when trailing bytes are present.
    /// </summary>
    Throw,

    /// <summary>
    /// Disassemble complete instructions and emit remaining bytes as a <c>.byte</c> directive.
    /// </summary>
    EmitBytes,

    /// <summary>
    /// Disassemble complete instructions and ignore remaining bytes.
    /// </summary>
    Ignore,
}
