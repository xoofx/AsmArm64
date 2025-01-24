// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace AsmArm64;

internal static class Arm64ImmediateValueHelper
{
    public static long DecodeValue(Arm64ImmediateValueEncodingKind valueEncodingKind, int value)
    {
        switch (valueEncodingKind)
        {
            case Arm64ImmediateValueEncodingKind.None:
                return value;
            case Arm64ImmediateValueEncodingKind.ValueDivideBy2:
                return value * 2;
            case Arm64ImmediateValueEncodingKind.ValueDivideBy4:
                return value * 4;
            case Arm64ImmediateValueEncodingKind.ValueDivideBy8:
                return value * 8;
            case Arm64ImmediateValueEncodingKind.ValueDivideBy16:
                return value * 16;
            case Arm64ImmediateValueEncodingKind.ValuePlus1ShiftLeft6:
                var v1 = value >> 6;
                return v1 + 1;
            case Arm64ImmediateValueEncodingKind._32_Minus_Value_Mod32:
                return ((32 - value) & 0x1F);
            case Arm64ImmediateValueEncodingKind._64_Minus_Value_Mod64:
                return ((64 - value) & 0x3F);
            case Arm64ImmediateValueEncodingKind._32_Minus_Value:
                return 32 - value;
            case Arm64ImmediateValueEncodingKind._64_Minus_Value:
                return 64 - value;
            case Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4:
                return VFPExpandImm32(value);
            case Arm64ImmediateValueEncodingKind.LsbPlusWidthMinus1:
                return (value >> 6) - (value & 0x3F) + 1;
            case Arm64ImmediateValueEncodingKind.ValueMod64Plus1:
                return (value & 0x3F) + 1;
            case Arm64ImmediateValueEncodingKind.DecodeBitMask32:
                return DecodeImmediateBitMask32(value);
            case Arm64ImmediateValueEncodingKind.DecodeBitMask64:
                return DecodeImmediateBitMask64(value);
            default:
                throw new ArgumentOutOfRangeException(nameof(valueEncodingKind), valueEncodingKind, null);
        }
    }

    ///// <summary>
    ///// Decode AArch64 bitfield and logical immediate masks which use a similar encoding structure
    ///// </summary>
    ///// <param name="value"></param>
    ///// <param name="immediate"></param>
    //public static (int wmask, int tmask) DecodeBitMask32(int value, bool immediate)
    //{
    //    int immN = (value >> 12) & 1;
    //    int immr = (value >> 6) & 0b111111;
    //    int imms = value & 0b111111;

    //    // const int M = 32

    //    // Compute log2 of element size
    //    // 2^len must be in range [2, M]
    //    // constant integer len = HighestSetBit(immN:NOT(imms));
    //    int len = 31 - BitOperations.LeadingZeroCount((uint)((immN << 6) | (imms) ^ 0b111_111));
    //    // if len < 1 then UNDEFINED;
    //    if (len < 1)
    //    {
    //        throw new InvalidOperationException();
    //    }

    //    // assert M >= (1 << len);
    //    Debug.Assert(32 >= (1 << len));

    //    // Determine s, r and s - r parameters
    //    int levels = (1 << len) - 1;
    //    // // For logical immediates an all-ones value of s is reserved
    //    // // since it would generate a useless all-ones result (many times)
    //    // if immediate && (imms AND levels) == levels then
    //    if (immediate && (imms & levels) == levels)
    //    {
    //        throw new InvalidOperationException();
    //    }
    //    // constant integer s = UInt(imms AND levels);
    //    int s = imms & levels;
    //    // constant integer r = UInt(immr AND levels);
    //    int r = immr & levels;
    //    // constant integer diff = s - r; // 6-bit subtract with borrow
    //    int diff = s - r; // 6-bit subtract with borrow
    //    // constant integer esize = 1 << len;
    //    int esize = 1 << len;
    //    // constant integer d = UInt(diff<len-1:0>);
    //    int d = diff & ((1 << (len - 1)) - 1);
    //    // welem = ZeroExtend(Ones(s + 1), esize);
    //    int welem = (1 << (s + 1)) - 1;
    //    // telem = ZeroExtend(Ones(d + 1), esize);
    //    int telem = (1 << (d + 1)) - 1;
    //    // wmask = Replicate(ROR(welem, r), M DIV esize);
    //    int wmask = Replicate(BitOperations.RotateRight((uint)welem, r), esize);
    //    // tmask = Replicate(telem, M DIV esize);
    //    int tmask = Replicate((uint)telem, 32 / esize);
    //    // return (wmask, tmask);
    //    return (wmask, tmask);
    //}

    public static int DecodeImmediateBitMask32(int value)
    {
        int immN = (value >> 12) & 1;
        int immr = (value >> 6) & 0b111111;
        int imms = value & 0b111111;

        // Compute log2 of element size
        // 2^len must be in range [2, M]
        int len = 31 - BitOperations.LeadingZeroCount((uint)((immN << 6) | ((imms) ^ 0b111_111)));
        if (len < 1)
        {
            throw new InvalidOperationException();
        }

        Debug.Assert(32 >= (1 << len));

        // Determine s, r and s - r parameters
        int levels = (1 << len) - 1;
        if ((imms & levels) == levels)
        {
            throw new InvalidOperationException();
        }
        int s = imms & levels;
        int r = immr & levels;
        int size = 1 << len;
        uint welem = (1U << (s + 1)) - 1;
        for (int i = 0; i < r; i++)
        {
            welem = RORBySize(welem, size);
        }

        uint wmask = Replicate(welem, size);
        return (int)wmask;
    }
    
    public static long DecodeImmediateBitMask64(int value)
    {
        int immN = (value >> 12) & 1;
        int immr = (value >> 6) & 0b111111;
        int imms = value & 0b111111;

        // Compute log2 of element size
        // 2^len must be in range [2, M]
        int len = 31 - BitOperations.LeadingZeroCount((uint)((immN << 6) | ((imms) ^ 0b111_111)));
        if (len < 1)
        {
            throw new InvalidOperationException();
        }

        Debug.Assert(64 >= (1 << len));

        // Determine s, r and s - r parameters
        int size = 1 << len;
        int levels = size - 1;
        if ((imms & levels) == levels)
        {
            throw new InvalidOperationException();
        }
        int s = imms & levels;
        int r = immr & levels;
        ulong welem = (1UL << (s + 1)) - 1;
        for(int i = 0; i < r; i++)
        {
            welem = RORBySize(welem, size);
        }
        
        ulong wmask = Replicate(welem, size);
        return (long)wmask;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint RORBySize(uint elt, int size) => ((elt & 1) << (size - 1)) | (elt >> 1);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong RORBySize(ulong elt, int size) => ((elt & 1) << (size - 1)) | (elt >> 1);
    
    private static uint Replicate(uint val, int shiftSize)
    {
        while (shiftSize < 32)
        {
            val |= val << shiftSize;
            shiftSize *= 2;
        }
        return val;
    }

    static ulong Replicate(ulong val, int shiftSize)
    {
        while (shiftSize < 64)
        {
            val |= val << shiftSize;
            shiftSize *= 2;
        }
        return val;
    }

    private static int VFPExpandImm32(int imm8)
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
        return (sign << (N-1)) | exp << F | frac;
    }
}