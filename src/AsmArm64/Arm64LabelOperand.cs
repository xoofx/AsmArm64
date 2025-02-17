// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents a ARM64 label operand.
/// </summary>
public readonly struct Arm64LabelOperand : IArm64Operand
{
    internal Arm64LabelOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        Flags = operand.Flags;
        var rawValue = operand.RawValue;

        // buffer[1] = (byte)LabelKind;
        // buffer[2] = (byte)BitSize;
        // buffer[3] = (byte)Encoding.Count;
        // //4,5,6,7
        // Debug.Assert(Encoding.Count <= 2);
        // for (int i = 0; i < Encoding.Count; i++)
        // {
        //     var bitRange = Encoding[i];
        //     buffer[4 + i * 2] = (byte)bitRange.LowBit;
        //     buffer[5 + i * 2] = (byte)bitRange.Width;
        // }
        var labelKind = (Arm64LabelEncodingKind)(descriptor >> 8);
        var bitSize = (byte)(descriptor >> 16);
        var encodingCount = (byte)(descriptor >> 24);

        Debug.Assert(encodingCount == 1 || encodingCount == 2);

        byte isSigned = labelKind != Arm64LabelEncodingKind.NegativeEncodedAsUnsigned ? (byte)1U : (byte)0U;

        long offset = encodingCount == 1
            ? Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), isSigned)
            : Arm64DecodingHelper.GetBitRange2(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), (byte)(descriptor >> 48), (byte)(descriptor >> 56), isSigned);

        Offset = labelKind == Arm64LabelEncodingKind.PageOffset ? offset << 12 : labelKind == Arm64LabelEncodingKind.ByteOffset ? offset : offset << 2;

        if (labelKind == Arm64LabelEncodingKind.NegativeEncodedAsUnsigned)
        {
            Offset = -Offset;
        }
    }

    internal static uint Encode(ulong descriptor, int offset)
    {
        var labelKind = (Arm64LabelEncodingKind)(descriptor >> 8);
        var encodingCount = (byte)(descriptor >> 24);
        switch (labelKind)
        {
            case Arm64LabelEncodingKind.OffsetMul4:
                offset >>= 2;
                break;
            case Arm64LabelEncodingKind.NegativeEncodedAsUnsigned:
                offset = -(offset >> 2);
                break;
            case Arm64LabelEncodingKind.PageOffset:
                offset >>= 12;
                break;
        }

        if (encodingCount == 1)
        {
            var bitOffset = (byte)(descriptor >> 32);
            var bitSize = (byte)(descriptor >> 40);
            var bitMask = (1 << bitSize) - 1;
            offset &= bitMask;
            return (uint)offset << (int)bitOffset;
        }
        else
        {
            Debug.Assert(encodingCount == 2);
            var bitOffset2 = (byte)(descriptor >> 48);
            var bitSize2 = (byte)(descriptor >> 56);
            var bitMask2 = (1 << bitSize2) - 1;
            var value = (uint)(offset & bitMask2) << bitOffset2;
            offset >>= bitSize2;
            var bitOffset1 = (byte)(descriptor >> 32);
            var bitSize1 = (byte)(descriptor >> 40);
            var bitMask1 = (1 << bitSize1) - 1;
            return value | (uint)(offset & bitMask1) << bitOffset1;
        }
    }

    /// <summary>
    /// Gets the kind of this operand.
    /// </summary>
    public Arm64OperandKind Kind => Arm64OperandKind.Label;

    /// <summary>
    /// Gets the flags of this operand.
    /// </summary>
    public Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Gets the relative offset of this operand.
    /// </summary>
    public long Offset { get; }

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
        isDefaultValue = false;

        if (tryFormatLabel is not null && tryFormatLabel(Offset, destination, out charsWritten))
        {
            return true;
        }

        if (destination.Length <= 1)
        {
            charsWritten = 0;
            return false;
        }
        destination[0] = '#';
        if (!Offset.TryFormat(destination.Slice(1), out var digitWritten, default, provider))
        {
            charsWritten = 0;
            return false;
        }
        charsWritten = digitWritten + 1;
        return true;
    }

    /// <summary>
    /// Explicit conversion from <see cref="Arm64Operand"/> to <see cref="Arm64LabelOperand"/>.
    /// </summary>
    /// <param name="operand">The operand to convert from.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64LabelOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Label) ThrowInvalidCast(operand.Kind);
        return new Arm64LabelOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64LabelOperand)}");
} 