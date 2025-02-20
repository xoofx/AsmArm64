// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 shift operand.
/// </summary>
public readonly struct Arm64ShiftOperand : IArm64Operand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ShiftOperand"/> struct.
    /// </summary>
    /// <param name="operand">The ARM64 operand.</param>
    internal Arm64ShiftOperand(Arm64Operand operand)
    {
        // buffer[1] = (byte)ShiftKind;
        // buffer[2] = (byte)ShiftEncoding.ToSmallEncoding();
        // buffer[3] = (byte)AmountEncoding.ToSmallEncoding();
        var descriptor = operand.Descriptor;
        Flags = operand.Flags;
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
            case Arm64ShiftEncodingKind.LslScale16:
                amount = (byte)(amount << 4);
                break;
            case Arm64ShiftEncodingKind.Lsl0Or12:
                amount = Arm64DecodingHelper.Get1SmallBitRange((byte)(descriptor >> 24), rawValue) == 0 ? (byte)0 : (byte)12;
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

    /// <inheritdoc />
    public Arm64OperandKind Kind => Arm64OperandKind.Shift;

    /// <inheritdoc />
    public Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Gets the kind of shift.
    /// </summary>
    public Arm64ShiftKind ShiftKind { get; }

    /// <summary>
    /// Gets the amount of shift.
    /// </summary>
    public byte Amount { get; }

    /// <summary>
    /// Gets a value indicating whether this operand is the default shift operand.
    /// </summary>
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
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    /// <inheritdoc />
    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel)
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
        if (!Amount.TryFormat(destination.Slice(written), out var digitWritten, "G", provider))
        {
            charsWritten = 0;
            return false;
        }
        written += digitWritten;

        charsWritten = written;
        return true;
    }

    /// <summary>
    /// Explicitly converts an <see cref="Arm64Operand"/> to an <see cref="Arm64ShiftOperand"/>.
    /// </summary>
    /// <param name="operand">The operand to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64ShiftOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Shift) ThrowInvalidCast(operand.Kind);
        return new Arm64ShiftOperand(operand);
    }

    /// <summary>
    /// Throws an <see cref="InvalidCastException"/> when an invalid cast is attempted.
    /// </summary>
    /// <param name="kind">The kind of the operand.</param>
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64ShiftOperand)}");
}
