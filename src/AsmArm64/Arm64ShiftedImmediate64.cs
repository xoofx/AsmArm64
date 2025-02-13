// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Numerics;

namespace AsmArm64;

public readonly record struct Arm64ShiftedImmediate32 : ISpanFormattable
{
    public Arm64ShiftedImmediate32(ushort value, int shift)
    {
        if (shift != 0 && shift != 16) throw new ArgumentOutOfRangeException(nameof(shift), shift, "Invalid shifted immediate value. Should be a shift-able to 0, 16.");
        EncodedValue = (value << 2) | (shift >> 4);
    }

    public int EncodedValue { get; }

    public int Immediate => EncodedValue >> 2;

    public int ShiftLeft => (EncodedValue & 3) << 4;

    public int Value() => (int)Immediate << ShiftLeft;

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => Value().ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => Value().TryFormat(destination, out charsWritten, format, provider);
}

public readonly record struct Arm64ShiftedImmediate64 : ISpanFormattable
{
    public Arm64ShiftedImmediate64(ushort value, int shift)
    {
        if (shift != 0 && shift != 16 && shift != 32 && shift != 48) throw new ArgumentOutOfRangeException(nameof(shift), shift, "Invalid shifted immediate value. Should be a shift-able to 0, 16, 32 or 48.");

        EncodedValue = (value << 2) | (shift >> 4);
    }

    public int EncodedValue { get; }

    public int Immediate => EncodedValue >> 2;

    public int ShiftLeft => (EncodedValue & 3) << 4;

    public long Value() => (long)Immediate << ShiftLeft;

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
        => Value().ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => Value().TryFormat(destination, out charsWritten, format, provider);
}

partial class Arm64Factory
{
    public static Arm64ShiftedImmediate32 Shift32(ushort value, int shift) => new(value, shift);

    public static Arm64ShiftedImmediate64 Shift64(ushort value, int shift) => new(value, shift);

    public static Arm64InvertedShiftedImmediate32 InvertShift32(ushort value, int shift) => new(value, shift);

    public static Arm64InvertedShiftedImmediate64 InvertShift64(ushort value, int shift) => new(value, shift);
}