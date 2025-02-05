// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly record struct Arm64BitMaskImmediate64 : ISpanFormattable
{
    internal Arm64BitMaskImmediate64(byte encodedValue)
    {
        EncodedValue = encodedValue;
    }
    
    public byte EncodedValue { get; }

    public ulong Value() => DecodeAsMask(EncodedValue);

    public static ulong DecodeAsMask(byte imm8)
    {
        // 8-bit `abcdefgh` to `aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh`
        ulong result = 0;
        for (int i = 0; i < 8; i++)
        {
            // Extract the `i-th` bit from `value`.
            int bit = (imm8 >> i) & 1;

            // Repeat the bit 8 times to form a byte.
            ulong repeatedBit = bit == 1 ? 0xFFUL : 0x00UL;

            // Place the repeated byte in the correct position.
            result |= (repeatedBit << (i * 8));
        }

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryEncode(ulong value, out Arm64BitMaskImmediate64 imm8)
    {
        byte v = 0;
        int i = 0;
        while (value != 0)
        {
            var b = (byte)(value & 0xFF);
            if (b != 0 && b != 0xFF)
            {
                imm8 = default;
                return false;
            }

            v |= (byte)((byte)(b & 0x1) << i);
            i++;
            value >>= 8;
        }

        imm8 = new Arm64BitMaskImmediate64(v);
        return true;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Arm64BitMaskImmediate64 Encode(ulong value)
    {
        if (!TryEncode(value, out var imm8))
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "Cannot be encoded as an 8-bit immediate bitmask.");
        }

        return imm8;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64BitMaskImmediate64(ulong value)
        => Encode(value);

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> dest = stackalloc char[16];
        TryFormat(dest, out var charsWritten, format.AsSpan(), formatProvider);
        return dest.Slice(0, charsWritten).ToString();
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = null)
        => format.Length == 0 || format[0] == 'X' ? destination.TryWrite(provider, $"0x{Value():16X}", out charsWritten) : Value().TryFormat(destination, out charsWritten, format, provider);
}