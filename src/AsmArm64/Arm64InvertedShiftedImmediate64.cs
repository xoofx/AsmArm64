// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly record struct Arm64InvertedShiftedImmediate64 : ISpanFormattable
{
    public Arm64InvertedShiftedImmediate64(ushort value, int shift)
    {
        if (shift != 0 && shift != 16 && shift != 32 && shift != 48) throw new ArgumentOutOfRangeException(nameof(shift), shift, "Invalid shifted immediate value. Should be a shift-able to 0 or 16/32/48.");

        EncodedValue = (value << 2) | (shift >> 4);
    }

    public int EncodedValue { get; }

    public int Immediate => EncodedValue >> 2;

    public int ShiftLeft => (EncodedValue & 3) << 4;

    public long Value() => ~(Immediate << ShiftLeft);

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => Value().ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => Value().TryFormat(destination, out charsWritten, format, provider);
}