// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64ImmediateOperand : IArm64Operand
{
    internal Arm64ImmediateOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;

        // buffer[1] = (byte)ImmediateKind;
        var immediateKind = (Arm64ImmediateEncodingKind)(descriptor >> 8);

        switch (immediateKind)
        {
            case Arm64ImmediateEncodingKind.FixedFloatZero:
                // if (ImmediateKind == Arm64ImmediateEncodingKind.FixedFloatZero)
                // {
                //     return;
                // }
                Value = 0;
                break;
            case Arm64ImmediateEncodingKind.FixedInt:
                // if (ImmediateKind == Arm64ImmediateEncodingKind.FixedInt)
                // {
                //     buffer[2] = (byte)FixedValue;
                //     return;
                // }
                Value = (int)(byte)(descriptor >> 16);
                break;
            case Arm64ImmediateEncodingKind.BitMapExtract:
                // if (ImmediateKind == Arm64ImmediateEncodingKind.BitMapExtract)
                // {
                //     Debug.Assert(ExtractIndex != 0);
                //     buffer[2] = (byte)ExtractIndex;
                //     return;
                // }
                Arm64ImmediateHelper.TryDecode(rawValue, (byte)(descriptor >> 16), out var value);
                Value = value;
                break;
            case Arm64ImmediateEncodingKind.Regular:
            case Arm64ImmediateEncodingKind.SystemRegister:
            case Arm64ImmediateEncodingKind.IsbOption:
            case Arm64ImmediateEncodingKind.Imm64:
                // buffer[2] = (byte)(IsSigned ? 0x01 : 0x00);
                // buffer[3] = (byte)Encoding.Count;
                // //4,5,6,7
                // Debug.Assert(Encoding.Count <= 2);
                // for (int i = 0; i < Encoding.Count; i++)
                // {
                //     var bitRange = Encoding[i];
                //     buffer[4 + i * 2] = (byte)bitRange.LowBit;
                //     buffer[5 + i * 2] = (byte)bitRange.Width;
                // }
                var isSigned = (byte)(descriptor >> 16);
                var encodingCount = (byte)(descriptor >> 24);

                Debug.Assert(encodingCount <= 2);
                Value = encodingCount == 1
                    ? Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), isSigned)
                    : Arm64DecodingHelper.GetBitRange2(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), (byte)(descriptor >> 48), (byte)(descriptor >> 56), isSigned);
                break;
            default:
                Value = 0;
                break;
        }
    }

    public Arm64OperandKind Kind => Arm64OperandKind.Immediate;
    
    public int Value { get; }
    
    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> span = stackalloc char[16];
        var result = TryFormat(span, out var charsWritten, format, formatProvider);
        Debug.Assert(result);
        return new string(span.Slice(0, charsWritten));
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider) =>
        TryFormat(destination, out charsWritten, out _, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel = null)
    {
        isDefaultValue = false;

        if (destination.Length <= 1)
        {
            charsWritten = 0;
            return false;
        }

        if (format.Length == 0)
        {
            format = "x";
        }

        var length = 1;
        destination[0] = '#';
        if (format.Length == 1 && (format[0] == 'x' || format[0] == 'X' || format[0] == 'H' || format[0] == 'L'))
        {
            if (destination.Length <= 3)
            {
                charsWritten = 0;
                return false;
            }
            destination[1] = '0';
            destination[2] = 'x';
            length = 3;
        }

        var result = Value.TryFormat(destination.Slice(length), out var numberWritten, format, provider);
        charsWritten = result ? length + numberWritten : 0;
        return result;
    }

    public static explicit operator Arm64ImmediateOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Immediate) ThrowInvalidCast(operand.Kind);
        return new Arm64ImmediateOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64ImmediateOperand)}");
}