// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Internal helper for decoding immediate values.
/// </summary>
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
                return Arm64FloatImmediate.DecodeAsInt((byte)value);
            case Arm64ImmediateValueEncodingKind.ValueMod64Plus1:
                return (value & 0x3F) + 1;
            case Arm64ImmediateValueEncodingKind.DecodeBitMask32:
                return Arm64LogicalImmediateHelper.DecodeLogicalImmediate32((uint)value);
            case Arm64ImmediateValueEncodingKind.DecodeBitMask64:
                return (long)Arm64LogicalImmediateHelper.DecodeLogicalImmediate64((uint)value);
            case Arm64ImmediateValueEncodingKind.ValueImm64:
                return (long)Arm64BitMaskImmediate64.DecodeAsMask((byte)value);
            case Arm64ImmediateValueEncodingKind.InvertValueShiftWide32:
                return ~(uint)((value >> 2) << ((value & 0x3) << 4));
            case Arm64ImmediateValueEncodingKind.InvertValueShiftWide64:
                return ~(((long)value >> 2) << ((value & 0x3) << 4));
            case Arm64ImmediateValueEncodingKind.ValueShiftWide64:
                return ((long)value >> 2) << ((value & 0x3) << 4);
            case Arm64ImmediateValueEncodingKind.ValueShiftWide32:
                return ((int)value >> 2) << ((value & 0x3) << 4);
            default:
                throw new ArgumentOutOfRangeException(nameof(valueEncodingKind), valueEncodingKind, null);
        }
    }
}