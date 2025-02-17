// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Internal class to help decoding ARM64 instructions.
/// </summary>
internal static class Arm64DecodingHelper
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetSmallBitRange(byte bitRange, uint v)
    {
        var bitIndex = bitRange & 0b11111;
        var width = bitRange >> 5;
        return ((byte)((v >> bitIndex) & ((1 << width) - 1)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Get1SmallBitRange(byte bitRange, uint v)
    {
        var bitIndex = bitRange & 0b11111;
        return ((byte)((v >> bitIndex) & 1));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetBitRange1(Arm64RawInstruction rawValue, byte bitIndex, byte size, byte isSigned)
    {
        // 1. Extract the bits
        uint mask = (1U << size) - 1U; // size is lower than 31 so no need to handle overflow
        uint value = (rawValue >> bitIndex) & mask;

        // 2. Branchless sign-extension
        //    signBit = 1 if (size-1)-th bit is 1, else 0
        uint signBit = (value >> (size - 1)) & 1u;
        //    doExtend = 1 if (signBit=1) AND (isSigned=true), else 0
        uint doExtend = isSigned & signBit;
        //    extensionMask = 0xFFFF_FFFF << size (if doExtend=1), else 0
        //    => in 32-bit: (0u - doExtend) is 0xFFFF_FFFF if doExtend=1, else 0
        //       and ~mask is all bits above 'size' set to 1
        uint extensionMask = (0u - doExtend) & ~mask;

        // 3. Apply extension
        value |= extensionMask;

        // 4. Interpret as a signed integer
        return (int)value;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetBitRange2(
        Arm64RawInstruction rawValue,
        byte bitIndex1,
        byte size1,
        byte bitIndex2,
        byte size2,
        byte isSigned)
    {
        // 1. Assemble the raw bits into 'value'.
        //    value = [bitIndex1..(bitIndex1+size1)] << size2
        //          | [bitIndex2..(bitIndex2+size2)]
        uint value = (rawValue >> bitIndex1) & ((1U << size1) - 1);
        value = (value << size2) | ((rawValue >> bitIndex2) & ((1U << size2) - 1));

        // 2. Branchless sign extension:
        //    We want to extend if (isSigned == true) AND (value's top bit == 1).
        //    We'll compute an all-1-bits mask in that case, or zero otherwise.
        //
        //    signBit: 1 if high bit is set, else 0
        //    doExtend: 1 if we should sign-extend, else 0
        //    extensionMask: 0xFFFF_FFFF << bitSize if signExtend is needed, else 0
        //
        //    (0u - doExtend) is 0xFFFF_FFFF if doExtend == 1, else 0 if doExtend == 0.
        //    The final 'value |= extensionMask' sets all higher bits if extensionMask != 0.

        int bitSize = size1 + size2;
        uint signBit = (value >> (bitSize - 1)) & 1u;                    // 1 if MSB of 'bitSize' portion is set
        uint doExtend = (uint)(isSigned & signBit);            // 1 if both isSigned and signBit are set
        uint extensionMask = (0u - doExtend) & ~((1u << bitSize) - 1);   // 0xFFFF_FFFF << bitSize or 0
        value |= extensionMask;                                          // Apply sign-extension if needed

        // 3. Return as a signed integer.
        return (int)value;
    }
}