// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an 8-bit floating-point immediate value.
/// </summary>
public readonly record struct Arm64FloatImmediate : ISpanFormattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64FloatImmediate"/> struct with the specified encoded value.
    /// </summary>
    /// <param name="encodedValue">The encoded value.</param>
    internal Arm64FloatImmediate(byte encodedValue)
    {
        EncodedValue = encodedValue;
    }
    
    /// <summary>
    /// Gets the value 1.0f.
    /// </summary>
    public static Arm64FloatImmediate Value1 => new(0x70);

    /// <summary>
    /// Gets the value 2.0f.
    /// </summary>
    public static Arm64FloatImmediate Value2 => new(0x0);

    /// <summary>
    /// Gets the value 3.0f.
    /// </summary>
    public static Arm64FloatImmediate Value3 => new(0x8);

    /// <summary>
    /// Gets the value 0.5f.
    /// </summary>
    public static Arm64FloatImmediate ValueZeroDot5 => new(0x60);

    /// <summary>
    /// Gets the encoded value.
    /// </summary>
    public byte EncodedValue { get; }

    /// <summary>
    /// Gets the floating-point value represented by this instance.
    /// </summary>
    /// <returns>The floating-point value.</returns>
    public float Value() => DecodeAsFloat(EncodedValue);

    /// <summary>
    /// Decodes the specified 8-bit immediate value as a floating-point value.
    /// </summary>
    /// <param name="imm8">The 8-bit immediate value.</param>
    /// <returns>The decoded floating-point value.</returns>
    public static float DecodeAsFloat(byte imm8) => BitConverter.Int32BitsToSingle(DecodeAsInt(imm8));

    /// <summary>
    /// Tries to encode the specified floating-point value as an 8-bit immediate value.
    /// </summary>
    /// <param name="value">The floating-point value to encode.</param>
    /// <param name="imm8">When this method returns, contains the encoded 8-bit immediate value, if the encoding succeeded; otherwise, the default value.</param>
    /// <returns><c>true</c> if the value was successfully encoded; otherwise, <c>false</c>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryEncode(float value, out Arm64FloatImmediate imm8)
    {
        var iValue = BitConverter.SingleToInt32Bits(value);

        // Sign
        byte v = (byte)((iValue >> 24) & 0x80);

        // Frac
        if ((iValue & ((1 << (23 - 4)) - 1)) != 0)
        {
            imm8 = default;
            return false;
        }
        v |= (byte)((iValue >> (23 - 4)) & 0xF);

        // Exp
        var exp = (byte)(iValue >> 23);
        v |= (byte)((exp & 0x3) << 4);
        exp >>= 2;
        if (exp == 0b11111)
        {
            // ok
            v |= 0b1000000;
        }
        else if (exp != 0b100000)
        {
            imm8 = default;
            return false;
        }

        imm8 = Unsafe.BitCast<byte, Arm64FloatImmediate>(v);
        return true;
    }


    /// <summary>
    /// Encodes the specified floating-point value as an 8-bit immediate value.
    /// </summary>
    /// <param name="value">The floating-point value to encode.</param>
    /// <returns>The encoded 8-bit immediate value.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value cannot be encoded as an 8-bit float immediate.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Arm64FloatImmediate Encode(float value)
    {
        if (!TryEncode(value, out var imm8))
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "Cannot be encoded as an 8-bit float immediate");
        }

        return imm8;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64FloatImmediate(float value)
        => Encode(value);

    /// <inheritdoc/>
    public override string ToString() => ToString(null, null);

    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> dest = stackalloc char[16];
        TryFormat(dest, out var charsWritten, format.AsSpan(), formatProvider);
        return dest.Slice(0, charsWritten).ToString();
    }

    /// <inheritdoc/>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = null)
    {
        if (format.Length == 0) format = "0.00000000";
        return DecodeAsFloat(EncodedValue).TryFormat(destination, out charsWritten, format, provider);
    }

    /// <summary>
    /// Decodes the specified 8-bit immediate value as a 32-bit integer.
    /// </summary>
    /// <param name="imm8">The 8-bit immediate value.</param>
    /// <returns>The decoded 32-bit integer.</returns>
    internal static int DecodeAsInt(byte imm8)
    {
        // bits(N) <anchor link="impl-shared.VFPExpandImm.2" hover="function: bits(N) VFPExpandImm(bits(8) imm8, integer N)">VFPExpandImm</anchor>(bits(8) imm8, integer N)
        // assert N IN {16,32,64};
        // frac = imm8<3:0>:<a link="impl-shared.Zeros.1" file="shared_pseudocode.xml" hover="function: bits(N) Zeros(integer N)">Zeros</a>(F-4);
        // result = sign : exp : frac;
        // return result;</pstext>
        // endfunction

        const int N = 32;
        // constant integer E = (if N == 16 then 5 elsif N == 32 then 8 else 11);
        const int E = 8;
        // constant integer F = (N - E) - 1;
        const int F = (N - E) - 1;
        // sign = imm8<7>;
        // exp  = NOT(imm8<6>):<a link="impl-shared.Replicate.2" file="shared_pseudocode.xml" hover="function: bits(M*N) Replicate(bits(M) x, integer N)">Replicate</a>(imm8<6>,E-3):imm8<5:4>;
        byte bit6 = (byte)((imm8 >> 6) & 1);
        byte bit54 = (byte)((imm8 >> 4) & 3);
        // exp = ~(bit6 + 0b11111) << 2) | bit54
        // if bit6 == 0: exp = 0b1000_00xx;
        // if bit6 == 1: exp = 0b0111_11xx;
        // with xx: bit54
        byte exp = (byte)((byte)(~(bit6 + 0b11111) << 2) | bit54);
        int frac = (imm8 & 0xF) << (F - 4);
        int sign = (imm8 >> 7) & 1;
        return (sign << (N - 1)) | ((int)exp << F) | frac;
    }
}
