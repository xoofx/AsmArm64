// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents an interface for an ARM64 operand.
/// </summary>
public interface IArm64Operand : ISpanFormattable
{
    /// <summary>
    /// Gets the kind of the operand.
    /// </summary>
    Arm64OperandKind Kind { get; }

    /// <summary>
    /// Gets the flags of the operand.
    /// </summary>
    Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Tries to format the operand.
    /// </summary>
    bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel = null);
}

/// <summary>
/// Delegates used to format a label.
/// </summary>
/// <param name="offset">The offset of the label. This offset is relative to the instruction being decoded when using <see cref="Arm64Instruction.Decode"/> and relative to the beginning of the buffer being decoded when using <see cref="Arm64Disassembler"/>.</param>
/// <param name="destination">The char destination buffer.</param>
/// <param name="charsWritten">The number of character written.</param>
/// <returns><c>true</c> if the label has been formatted; <c>false</c> otherwise.</returns>
public delegate bool Arm64TryFormatDelegate(long offset, Span<char> destination, out int charsWritten);
