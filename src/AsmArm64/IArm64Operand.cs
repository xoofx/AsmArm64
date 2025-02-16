// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public interface IArm64Operand : ISpanFormattable
{
    Arm64OperandKind Kind { get; }

    Arm64OperandFlags Flags { get; }

    bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel = null);
}

public delegate bool Arm64TryFormatDelegate(long offset, Span<char> destination, out int charsWritten);