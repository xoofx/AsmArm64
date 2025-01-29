// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly struct Arm64RegisterXOrSP
{
    public int Index { get; }
}

public readonly struct Arm64RegisterXOrW : IArm64Register
{
    private readonly int _value;
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    public int Index => (byte)_value;

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        FormattableString formattable = $"{nameof(Kind)}: {Kind}, {nameof(Index)}: {Index}";
        return formattable.ToString(formatProvider);
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        return destination.TryWrite(provider, $"{nameof(Kind)}: {Kind}, {nameof(Index)}: {Index}", out charsWritten);
    }

    public override string ToString()
    {
        return $"{nameof(Kind)}: {Kind}, {nameof(Index)}: {Index}";
    }
}

public readonly struct Arm64RegisterWOrWSP
{
    public int Index { get; }
}