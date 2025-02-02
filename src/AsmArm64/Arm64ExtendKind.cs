// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;

namespace AsmArm64;

public enum Arm64ExtendKind : byte
{
    None,
    UXTB,
    UXTH,
    UXTW,
    UXTX,
    SXTB,
    SXTH,
    SXTW,
    SXTX,
    LSL,
}

public enum Arm64ExtendXKind : byte
{
    None,
    UXTX,
    SXTX,
    LSL,
}
public enum Arm64ExtendWKind : byte
{
    None,
    UXTB,
    UXTH,
    UXTW,
    SXTB,
    SXTH,
    SXTW,
}

public interface IArm64Extend
{
    Arm64ExtendKind Kind { get; }

    byte Amount { get; }
}


partial class Arm64Extensions
{
    private static readonly string[] ExtendTextLower =
    [
        "????",
        "uxtb",
        "uxth",
        "uxtw",
        "uxtx",
        "sxtb",
        "sxth",
        "sxtw",
        "sxtx",
        "lsl"
    ];

    private static readonly string[] ExtendTextUpper =
    [
        "????",
        "UXTB",
        "UXTH",
        "UXTW",
        "UXTX",
        "SXTB",
        "SXTH",
        "SXTW",
        "SXTX",
        "LSL"
    ];
    
    public static string ToText(this Arm64ExtendKind kind, bool upper) => upper ? ExtendTextUpper[(int)kind] : ExtendTextLower[(int)kind];
}


public readonly record struct Arm64MemoryExtendX(Arm64ExtendXKind Kind, byte Amount)
{
    // TODO
}

public readonly record struct Arm64MemoryExtendW(Arm64ExtendWKind Kind, byte Amount)
{
    // TODO
}


public readonly record struct Arm64MemoryExtend(Arm64ExtendKind Kind, byte Amount) : IArm64Extend , ISpanFormattable
{
    private readonly bool _isAmountVisible;

    public Arm64MemoryExtend(Arm64ExtendKind Kind, bool zeroAmountVisible) : this(Kind, 0)
    {
        _isAmountVisible = zeroAmountVisible;
    }

    public bool IsZeroAmountVisible => _isAmountVisible;

    public bool IsDefault => Amount == 0 && (Kind == Arm64ExtendKind.LSL || Kind == Arm64ExtendKind.UXTX);

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[16];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        var text = Kind.ToText(format.Length >= 1 && format[0] == 'H');
        if (destination.Length < text.Length)
        {
            charsWritten = 0;
            return false;
        }
        text.AsSpan().CopyTo(destination);
        var written = text.Length;
        if (destination.Length <= written)
        {
            charsWritten = 0;
            return false;
        }

        if (Amount != 0 || Kind == Arm64ExtendKind.LSL || _isAmountVisible)
        {
            if (destination.Length <= written + 1)
            {
                charsWritten = 0;
                return false;
            }

            destination[written] = ' ';
            destination[written + 1] = '#';
            written += 2;
            if (!Amount.TryFormat(destination.Slice(written), out var digitWritten, format, provider))
            {
                charsWritten = 0;
                return false;
            }

            written += digitWritten;
        }

        charsWritten = written;
        return true;
    }
}
