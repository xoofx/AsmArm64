// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Numerics;

internal static class BitOperations
{
    private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn => // 32
       [
           00, 01, 28, 02, 29, 14, 24, 03,
            30, 22, 20, 15, 25, 17, 04, 08,
            31, 27, 13, 23, 21, 19, 16, 07,
            26, 12, 18, 06, 11, 05, 10, 09
       ];

    private static ReadOnlySpan<byte> Log2DeBruijn => new byte[32]
       {
            00, 09, 01, 10, 13, 21, 02, 29,
            11, 14, 16, 18, 22, 25, 03, 30,
            08, 12, 20, 28, 15, 17, 24, 07,
            19, 27, 23, 06, 26, 05, 04, 31
       };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int TrailingZeroCount(int value)
        => TrailingZeroCount((uint)value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int TrailingZeroCount(uint value)
    {
        // Unguarded fallback contract is 0->0, BSF contract is 0->undefined
        if (value == 0)
        {
            return 32;
        }

        // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
        return Unsafe.AddByteOffset(
            // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_0111_1100_1011_0101_0011_0001u
            ref MemoryMarshal.GetReference(TrailingZeroCountDeBruijn),
            // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
            (IntPtr)(int)(((value & (uint)-(int)value) * 0x077CB531u) >> 27)); // Multi-cast mitigates redundant conv.u8
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int TrailingZeroCount(ulong value)
    {
        uint lo = (uint)value;

        if (lo == 0)
        {
            return 32 + TrailingZeroCount((uint)(value >> 32));
        }

        return TrailingZeroCount(lo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int LeadingZeroCount(uint value)
    {
        // Unguarded fallback contract is 0->31, BSR contract is 0->undefined
        if (value == 0)
        {
            return 32;
        }

        return 31 ^ Log2SoftwareFallback(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int LeadingZeroCount(ulong value)
    {
        uint hi = (uint)(value >> 32);

        if (hi == 0)
        {
            return 32 + LeadingZeroCount((uint)value);
        }

        return LeadingZeroCount(hi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong RotateRight(ulong value, int offset)
        => (value >> offset) | (value << (64 - offset));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPow2(int value) => (value & (value - 1)) == 0 && value > 0;

    private static int Log2SoftwareFallback(uint value)
    {
        // No AggressiveInlining due to large method size
        // Has conventional contract 0->0 (Log(0) is undefined)

        // Fill trailing zeros with ones, eg 00010010 becomes 00011111
        value |= value >> 01;
        value |= value >> 02;
        value |= value >> 04;
        value |= value >> 08;
        value |= value >> 16;

        // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
        return Unsafe.AddByteOffset(
            // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_1100_0100_1010_1100_1101_1101u
            ref MemoryMarshal.GetReference(Log2DeBruijn),
            // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
            (IntPtr)(int)((value * 0x07C4ACDDu) >> 27));
    }
}
#endif