// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

internal static class Arm64ImmediateValueHelper
{
    public static int DecodeValue(Arm64ImmediateValueEncodingKind valueEncodingKind, int value)
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
            case Arm64ImmediateValueEncodingKind.MinusValuePlus32Mod32:
                return ((32 - value) & 0x1F);
            case Arm64ImmediateValueEncodingKind.MinusValuePlus64Mod64:
                return ((64 - value) & 0x3F);
            case Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4:
                return VFPExpandImm32(value);
            case Arm64ImmediateValueEncodingKind.LsbPlusWidthMinus1:
                return (value >> 6) - (value & 0x3F) + 1;
            default:
                throw new ArgumentOutOfRangeException(nameof(valueEncodingKind), valueEncodingKind, null);
        }
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