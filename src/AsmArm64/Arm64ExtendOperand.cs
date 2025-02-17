// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 extend operand.
/// </summary>
public readonly struct Arm64ExtendOperand : IArm64Operand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ExtendOperand"/> struct.
    /// </summary>
    /// <param name="operand">The operand to extend.</param>
    internal Arm64ExtendOperand(Arm64Operand operand)
    {
        // buffer[1] = (byte)ExtendEncoding.ToSmallEncoding();
        // buffer[2] = (byte)AmountEncoding.ToSmallEncoding();
        // buffer[3] = (byte)((byte)EncodingKind | (byte)(Is64Bit ? 0x80 : 0));
        var descriptor = operand.Descriptor;
        Flags = operand.Flags;
        var rawValue = operand.RawValue;

        var b3 = (byte)(descriptor >> 24);
        bool is64Bit = (b3 & 0x80) != 0;
        var encodingKind = (Arm64ExtendEncodingKind)(b3 & 0x7F);

        var option = Arm64DecodingHelper.GetSmallBitRange((byte)(descriptor >> 8), rawValue);
        var isRn31 = ((rawValue >> 5) & 0b11111) == 0b11111;
        var isPotentialLSL = ((is64Bit && option == 0b011) || (!is64Bit && option == 0b010));

        //Debug.Assert(encodingKind == Arm64ExtendEncodingKind.PreferLSLIfRdOrRnIs11111);

        if (encodingKind == Arm64ExtendEncodingKind.PreferLSLIfRnIs11111)
        {
            if (isPotentialLSL && isRn31)
            {
                ExtendKind = Arm64ExtendKind.LSL;
            }
            else
            {
                ExtendKind = (Arm64ExtendKind)(option + 1);
            }
        }
        else
        {
            var isRd31 = (rawValue & 0b11111) == 0b11111;
            if (isPotentialLSL && (isRn31 || isRd31))
            {
                ExtendKind = Arm64ExtendKind.LSL;
            }
            else
            {
                ExtendKind = (Arm64ExtendKind)(option + 1);
            }
        }

        Amount = Arm64DecodingHelper.GetSmallBitRange((byte)(descriptor >> 16), rawValue);
    }

    /// <summary>
    /// Gets the kind of the operand.
    /// </summary>
    public Arm64OperandKind Kind => Arm64OperandKind.Shift;

    /// <summary>
    /// Gets a value indicating whether the operand is optional.
    /// </summary>
    public bool IsOptional => (Flags & Arm64OperandFlags.Optional) != 0;

    /// <summary>
    /// Gets the flags associated with the operand.
    /// </summary>
    public Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Gets the kind of the extend operation.
    /// </summary>
    public Arm64ExtendKind ExtendKind { get; }

    /// <summary>
    /// Gets the amount of the extend operation.
    /// </summary>
    public byte Amount { get; }

    /// <summary>
    /// Gets a value indicating whether the operand is the default value.
    /// </summary>
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
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    /// <summary>
    /// Tries to format the operand as a string.
    /// </summary>
    /// <param name="instruction">The instruction associated with the operand.</param>
    /// <param name="destination">The destination span to write the formatted string.</param>
    /// <param name="charsWritten">The number of characters written to the destination span.</param>
    /// <param name="isDefaultValue">Indicates whether the operand is the default value.</param>
    /// <param name="format">The format string.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="tryFormatLabel">The delegate to try formatting the label.</param>
    /// <returns>True if the formatting was successful; otherwise, false.</returns>
    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel)
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
            if (!Amount.TryFormat(destination.Slice(written), out var digitWritten, "G", provider))
            {
                charsWritten = 0;
                return false;
            }
            written += digitWritten;
        }

        charsWritten = written;
        return true;
    }

    /// <summary>
    /// Explicitly converts an <see cref="Arm64Operand"/> to an <see cref="Arm64ExtendOperand"/>.
    /// </summary>
    /// <param name="operand">The operand to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64ExtendOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Extend) ThrowInvalidCast(operand.Kind);
        return new Arm64ExtendOperand(operand);
    }

    /// <summary>
    /// Throws an <see cref="InvalidCastException"/> if the operand kind is invalid.
    /// </summary>
    /// <param name="kind">The kind of the operand.</param>
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64ExtendOperand)}");
}
