// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64ShiftOperand : IArm64Operand
{
    internal Arm64ShiftOperand(Arm64Operand operand)
    {
        // buffer[1] = (byte)ShiftKind;
        // buffer[2] = (byte)ShiftEncoding.ToSmallEncoding();
        // buffer[3] = (byte)AmountEncoding.ToSmallEncoding();
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;

        var amount = Arm64DecodingHelper.GetSmallBitRange((byte)(descriptor >> 24), rawValue);

        var shiftEncodingKind = (Arm64ShiftEncodingKind)((byte)(descriptor >> 8));
        ShiftKind = Arm64ShiftKind.LSL;
        switch (shiftEncodingKind)
        {
            case Arm64ShiftEncodingKind.Lsl0:
                amount = 0;
                break;
            case Arm64ShiftEncodingKind.Lsl:
                break;
            case Arm64ShiftEncodingKind.LslScale8:
                amount = (byte)(amount << 3);
                break;
            case Arm64ShiftEncodingKind.Fixed:
                amount = Arm64DecodingHelper.Get1SmallBitRange((byte)(descriptor >> 16), rawValue) == 0 ? (byte)0 : (byte)12;
                break;
            case Arm64ShiftEncodingKind.Msl:
                ShiftKind = Arm64ShiftKind.MSL;
                amount = (byte)((amount + 1) << 3);
                break;
            case Arm64ShiftEncodingKind.Shift3:
            case Arm64ShiftEncodingKind.Shift4:
                var shiftKind = (Arm64ShiftKind)Arm64DecodingHelper.GetSmallBitRange((byte)(descriptor >> 16), rawValue);
                if (shiftEncodingKind == Arm64ShiftEncodingKind.Shift3 && shiftKind == Arm64ShiftKind.ROR)
                {
                    shiftKind = Arm64ShiftKind.Invalid;
                }
                ShiftKind = shiftKind;
                break;
            default:
                ShiftKind = Arm64ShiftKind.Invalid;
                amount = 0;
                break;
        }
        Amount = amount;
    }

    public Arm64OperandKind Kind => Arm64OperandKind.Shift;

    public Arm64ShiftKind ShiftKind { get; }

    public byte Amount { get; }

    public bool IsDefault => Amount == 0 && ShiftKind == Arm64ShiftKind.LSL;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        // 8 ~= Shift max 3, amount maximum 2 digits, 1 space, 1 #
        Span<char> span = stackalloc char[8];
        var result = TryFormat(span, out var written, format, formatProvider);
        Debug.Assert(result);
        return span.Slice(0, written).ToString();
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(destination, out charsWritten, out _, format, provider);
    
    public bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel = null)
    {
        isDefaultValue = IsDefault;
        
        var shiftText = ShiftKind.ToText(format.Length >= 1 && format[0] == 'H');
        if (destination.Length < shiftText.Length)
        {
            charsWritten = 0;
            return false;
        }
        shiftText.AsSpan().CopyTo(destination);
        var written = shiftText.Length;

        if (destination.Length <= written + 1)
        {
            charsWritten = 0;
            return false;
        }
        destination[written] = (char)' ';
        destination[written + 1] = '#';
        written += 2;
        if (!Amount.TryFormat(destination.Slice(written), out var digitWritten, format, provider))
        {
            charsWritten = 0;
            return false;
        }
        written += digitWritten;
        
        charsWritten = written;
        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64ShiftOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Shift) ThrowInvalidCast(operand.Kind);
        return new Arm64ShiftOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64ShiftOperand)}");
}