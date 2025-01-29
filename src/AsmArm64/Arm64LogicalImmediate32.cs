// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly record struct Arm64LogicalImmediate32 : ISpanFormattable
{
    internal Arm64LogicalImmediate32(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public int N => (Value >> 12) & 1;

    public int ImmR => (Value >> 6) & 0x3f;

    public int ImmS => Value & 0x3f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Arm64LogicalImmediate32 Encode(uint value)
        => Unsafe.BitCast<int, Arm64LogicalImmediate32>(Arm64LogicalImmediateHelper.EncodeLogicalImmediate32(value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64LogicalImmediate32(uint value)
        => Unsafe.BitCast<int, Arm64LogicalImmediate32>(Arm64LogicalImmediateHelper.EncodeLogicalImmediate32(value));

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> dest = stackalloc char[16];
        TryFormat(dest, out var charsWritten, format.AsSpan(), formatProvider);
        return dest.Slice(0, charsWritten).ToString();
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = null)
        => format.Length == 0 || format[0] == 'X' ? destination.TryWrite(provider, $"0x{Value:16X}", out charsWritten) : Value.TryFormat(destination, out charsWritten, format, provider);
}