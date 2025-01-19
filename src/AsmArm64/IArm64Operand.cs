// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public interface IArm64Operand : ISpanFormattable
{
    Arm64OperandKind Kind { get; }
    
    bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel);
}

public delegate bool TryResolveLabelDelegate(int offset, out string? label);