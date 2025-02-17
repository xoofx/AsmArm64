// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly record struct Arm64BitMaskImmediate64 : ISpanFormattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64BitMaskImmediate64"/> struct.
    /// </summary>
    /// <param name="encodedValue">The encoded 8-bit value.</param>
    internal Arm64BitMaskImmediate64(byte encodedValue)
    {
        EncodedValue = encodedValue;
    }

    /// <summary>
    /// Gets the encoded 8-bit value.
    /// </summary>
    public byte EncodedValue { get; }

    /// <summary>
    /// Decodes the encoded value to a 64-bit mask.
    /// </summary>
    /// <returns>The decoded 64-bit mask.</returns>
    public ulong Value() => DecodeAsMask(EncodedValue);

    /// <summary>
    /// Decodes an 8-bit immediate value to a 64-bit mask.
    /// </summary>
    /// <param name="imm8">The 8-bit immediate value.</param>
    /// <returns>The decoded 64-bit mask.</returns>
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

    /// <summary>
    /// Tries to encode a 64-bit value as an 8-bit immediate bitmask.
    /// </summary>
    /// <param name="value">The 64-bit value to encode.</param>
    /// <param name="imm8">When this method returns, contains the encoded 8-bit immediate bitmask, if the encoding succeeded.</param>
    /// <returns><c>true</c> if the value was successfully encoded; otherwise, <c>false</c>.</returns>
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
    
    /// <summary>
    /// Encodes a 64-bit value as an 8-bit immediate bitmask.
    /// </summary>
    /// <param name="value">The 64-bit value to encode.</param>
    /// <returns>The encoded 8-bit immediate bitmask.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value cannot be encoded as an 8-bit immediate bitmask.</exception>
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

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() => ToString(null, null);

    /// <summary>
    /// Formats the value of the current instance using the specified format.
    /// </summary>
    /// <param name="format">The format to use.</param>
    /// <param name="formatProvider">The format provider to use.</param>
    /// <returns>The formatted string.</returns>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> dest = stackalloc char[16];
        TryFormat(dest, out var charsWritten, format.AsSpan(), formatProvider);
        return dest.Slice(0, charsWritten).ToString();
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    /// <param name="destination">The span of characters to write to.</param>
    /// <param name="charsWritten">When this method returns, contains the number of characters written.</param>
    /// <param name="format">The format to use.</param>
    /// <param name="provider">The format provider to use.</param>
    /// <returns><c>true</c> if the formatting was successful; otherwise, <c>false</c>.</returns>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = null)
        => format.Length == 0 || format[0] == 'X' ? destination.TryWrite(provider, $"0x{Value():16X}", out charsWritten) : Value().TryFormat(destination, out charsWritten, format, provider);
}