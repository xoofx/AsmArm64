// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

internal static class Arm64DecodingHelper
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetSmallBitRangeValue(byte bitRange, uint v)
    {
        var bitIndex = bitRange & 0b11111;
        var width = bitRange >> 5;
        return ((byte)((v >> bitIndex) & ((1 << width) - 1)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Get1BitRangeValue(byte bitRange, uint v)
    {
        var bitIndex = bitRange & 0b11111;
        return ((byte)((v >> bitIndex) & 1));
    }
}