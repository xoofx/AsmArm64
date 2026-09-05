// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

internal static class Arm64FormattingHelper
{
    internal static bool IsHex(ReadOnlySpan<char> format)
        => format.Length == 1 && (format[0] == 'x' || format[0] == 'X');

    internal static ulong Magnitude(long value)
        => value < 0 ? unchecked(0UL - (ulong)value) : (ulong)value;

    internal static string GetNumericFormat(Arm64NumericFormat format, bool uppercase, long value)
        => format == Arm64NumericFormat.Hexadecimal || (format == Arm64NumericFormat.Auto && Magnitude(value) > 9)
            ? (uppercase ? "X" : "x") : "G";

    internal static string FormatLabelOffset(long value, string? format, IFormatProvider? provider)
        => IsHex(format.AsSpan())
            ? (value < 0 ? "#-0x" : "#0x") + Magnitude(value).ToString(format, provider)
            : "#" + value.ToString(provider);

    internal static bool TryFormatLabelOffset(long value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        var hex = IsHex(format);
        var prefix = hex ? (value < 0 ? "#-0x" : "#0x") : "#";
        charsWritten = 0;
        if (!prefix.AsSpan().TryCopyTo(destination)) return false;

        var digits = destination.Slice(prefix.Length);
        var success = hex
            ? Magnitude(value).TryFormat(digits, out var count, format, provider)
            : value.TryFormat(digits, out count, default, provider);
        if (!success) return false;
        charsWritten = prefix.Length + count;
        return true;
    }
}
