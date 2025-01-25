// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public interface IArm64Operand : ISpanFormattable
{
    Arm64OperandKind Kind { get; }
    
    bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel = null);
}

public delegate bool TryResolveLabelDelegate(long offset, out string? label);