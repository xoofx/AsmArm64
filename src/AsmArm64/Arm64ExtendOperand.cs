// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64ExtendOperand : IArm64Operand
{
    internal Arm64ExtendOperand(Arm64Operand operand)
    {
        // buffer[1] = (byte)ExtendEncoding.ToSmallEncoding();
        // buffer[2] = (byte)AmountEncoding.ToSmallEncoding();
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;

        ExtendKind = (Arm64ExtendKind)(Arm64DecodingHelper.GetSmallBitRange((byte)(descriptor >> 8), rawValue) + 1); // Add 1 to skip None
        Amount = Arm64DecodingHelper.GetSmallBitRange((byte)(descriptor >> 16), rawValue);
    }

    public Arm64OperandKind Kind => Arm64OperandKind.Shift;

    public Arm64ExtendKind ExtendKind { get; }

    public byte Amount { get; }

    public bool IsDefault => Amount == 0 && ExtendKind == Arm64ExtendKind.LSL;

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
        
        var extendText = ExtendKind.ToText(format.Length >= 1 && format[0] == 'H');
        if (destination.Length < extendText.Length)
        {
            charsWritten = 0;
            return false;
        }
        extendText.AsSpan().CopyTo(destination);
        var written = extendText.Length;

        if (Amount != 0)
        {
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
        }

        charsWritten = written;
        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64ExtendOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Extend) ThrowInvalidCast(operand.Kind);
        return new Arm64ExtendOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64ExtendOperand)}");
}