// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

internal static class Arm64ImmediateValueHelper
{
    public static long DecodeMsrImmediateValue(uint rawValue, int value)
    {
        // Encoded to 1 bit when pstateField is ALLINT, PM, SVCRSM, SVCRSMZA, or SVCRZA.
        // CRm:op1:op2
        // CRm: (b: 8, w: 4)
        // op1: (b: 16, w: 3)
        // op2: (b: 5, w: 3)
        Arm64ProcessStateFieldHelper.TryDecode(rawValue, 1, out var processStateField);

        switch (processStateField)
        {
            case Arm64ProcessStateField.ALLINT:
            case Arm64ProcessStateField.PM:
            case Arm64ProcessStateField.SVCRSM:
            case Arm64ProcessStateField.SVCRSMZA:
            case Arm64ProcessStateField.SVCRZA:
                return value & 1;
            default:
                return value;
        }
    }

    public static long DecodeValue(Arm64ImmediateValueEncodingKind valueEncodingKind, int value)
    {
        switch (valueEncodingKind)
        {
            case Arm64ImmediateValueEncodingKind.None:
                return value;
            case Arm64ImmediateValueEncodingKind.ValueMulBy2:
                return value * 2;
            case Arm64ImmediateValueEncodingKind.ValueMulBy4:
                return value * 4;
            case Arm64ImmediateValueEncodingKind.ValueMulBy8:
                return value * 8;
            case Arm64ImmediateValueEncodingKind.ValueMulBy16:
                return value * 16;
            case Arm64ImmediateValueEncodingKind.ValueImmsMinusImmrPlus1:
                // encoded in imms:immr (reversed from the order in the instruction)
                return ((value >> 6) & 0b111_1111) - (value & 0b111_111) + 1;
            case Arm64ImmediateValueEncodingKind.ValueImmsPlus1:
                // encoded in imms:immr (reversed from the order in the instruction)
                return ((value >> 6) & 0b111_1111) + 1;
            case Arm64ImmediateValueEncodingKind._32_Minus_Value_Mod32:
                return ((32 - value) & 0x1F);
            case Arm64ImmediateValueEncodingKind._64_Minus_Value_Mod64:
                return ((64 - value) & 0x3F);
            case Arm64ImmediateValueEncodingKind._32_Minus_Value:
                return 32 - value;
            case Arm64ImmediateValueEncodingKind._64_Minus_Value:
                return 64 - value;
            case Arm64ImmediateValueEncodingKind.Value_Minus_64:
                return value - 64;
            case Arm64ImmediateValueEncodingKind._128_Minus_Value:
                return 128 - value;
            case Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4:
                return VFPExpandImm32(value);
            case Arm64ImmediateValueEncodingKind.ValueMod64Plus1:
                return (value & 0x3F) + 1;
            case Arm64ImmediateValueEncodingKind.DecodeBitMask32:
                return Arm64LogicalImmediateHelper.DecodeLogicalImmediate32((uint)value);
            case Arm64ImmediateValueEncodingKind.DecodeBitMask64:
                return (long)Arm64LogicalImmediateHelper.DecodeLogicalImmediate64((uint)value);
            case Arm64ImmediateValueEncodingKind.ValueImm64:
                return DecodeImmediate64(value);
            case Arm64ImmediateValueEncodingKind.InvertValueShiftWide32:
                return ~(uint)((int)value >> 2) << ((value & 0x3) << 4);
            case Arm64ImmediateValueEncodingKind.ValueShiftWide64:
                return ((long)value >> 2) << ((value & 0x3) << 4);
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

    private static long DecodeImmediate64(int value)
    {
        // 8-bit `abcdefgh` to `aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh`
        long result = 0;
        for (int i = 0; i < 8; i++)
        {
            // Extract the `i-th` bit from `value`.
            int bit = (value >> i) & 1;

            // Repeat the bit 8 times to form a byte.
            long repeatedBit = bit == 1 ? 0xFF : 0x00;

            // Place the repeated byte in the correct position.
            result |= (repeatedBit << (i * 8));
        }

        return result;
    }
}