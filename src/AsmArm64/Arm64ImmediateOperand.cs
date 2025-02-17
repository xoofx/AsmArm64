// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 immediate operand.
/// </summary>
public readonly struct Arm64ImmediateOperand : IArm64Operand
{
    private readonly bool _displayAsHex;
    private readonly bool _is32;
    private readonly bool _isOptional;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ImmediateOperand"/> struct.
    /// </summary>
    /// <param name="operand">The operand to initialize from.</param>
    internal Arm64ImmediateOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        Flags = operand.Flags;
        var rawValue = operand.RawValue;

        _is32 = true;

        // buffer[1] = (byte)((byte)ImmediateKind | (byte)(IsOptional ? 0x80 : 0));
        var b1 = (byte)(descriptor >> 8);
        var immediateKind = (Arm64ImmediateEncodingKind)(b1 & 0x7F);
        _isOptional = (b1 & 0x80) != 0;
        var valueEncodingKind = Arm64ImmediateValueEncodingKind.None;
        switch (immediateKind)
        {
            case Arm64ImmediateEncodingKind.FixedFloatZero:
                // if (ImmediateKind == Arm64ImmediateEncodingKind.FixedFloatZero)
                // {
                //     return;
                // }
                IsFloat = true;
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
                {
                    // buffer[2] = (byte)((byte)ValueEncodingKind | (byte)(IsSigned ? 0x80 : 0x00));
                    // if (ImmediateKind == Arm64ImmediateEncodingKind.BitMapExtract)
                    // {
                    //     Debug.Assert(ExtractIndex != 0);
                    //     buffer[3] = (byte)ExtractIndex;
                    //     return;
                    // }
                    var b2 = (byte)(descriptor >> 16);
                    valueEncodingKind = (Arm64ImmediateValueEncodingKind)(b2 & 0x7F);
                    var isSigned = (byte)(b2 >> 7);
                    Arm64ImmediateHelper.TryDecode(rawValue, (byte)(descriptor >> 24), out var value);
                    Value = value;
                    break;
                }
            case Arm64ImmediateEncodingKind.Regular:
            case Arm64ImmediateEncodingKind.IsbOption:
                {
                    // buffer[2] = (byte)((byte)ValueEncodingKind | (byte)(IsSigned ? 0x80 : 0x00));
                    // if (ImmediateKind == Arm64ImmediateEncodingKind.BitMapExtract)
                    // {
                    //     Debug.Assert(ExtractIndex != 0);
                    //     buffer[3] = (byte)ExtractIndex;
                    //     return;
                    // }
                    // buffer[3] = (byte)Encoding.Count;
                    // //4,5,6,7
                    // Debug.Assert(Encoding.Count <= 2);
                    // for (int i = 0; i < Encoding.Count; i++)
                    // {
                    //     var bitRange = Encoding[i];
                    //     buffer[4 + i * 2] = (byte)bitRange.LowBit;
                    //     buffer[5 + i * 2] = (byte)bitRange.Width;
                    // }
                    var b2 = (byte)(descriptor >> 16);
                    valueEncodingKind = (Arm64ImmediateValueEncodingKind)(b2 & 0x7F);
                    var isSigned = (byte)(b2 >> 7);
                    var encodingCount = (byte)(descriptor >> 24);

                    Debug.Assert(encodingCount <= 2);
                    Value = encodingCount == 1
                        ? Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), isSigned)
                        : Arm64DecodingHelper.GetBitRange2(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), (byte)(descriptor >> 48), (byte)(descriptor >> 56), isSigned);
                    break;
                }
            default:
                Value = 0;
                break;
        }

        if (valueEncodingKind != Arm64ImmediateValueEncodingKind.None)
        {
            if (valueEncodingKind == Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4)
            {
                IsFloat = true;
            }

            if (valueEncodingKind == Arm64ImmediateValueEncodingKind.ValueMsrImmediate)
            {
                Value = Arm64ImmediateValueHelper.DecodeMsrImmediateValue(rawValue, (int)Value);
            }
            else
            {
                Value = Arm64ImmediateValueHelper.DecodeValue(valueEncodingKind, (int)Value);
                _displayAsHex = valueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask32 || valueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask64 || valueEncodingKind == Arm64ImmediateValueEncodingKind.ValueImm64;
                if (valueEncodingKind == Arm64ImmediateValueEncodingKind.DecodeBitMask64 || valueEncodingKind == Arm64ImmediateValueEncodingKind.ValueImm64 || valueEncodingKind == Arm64ImmediateValueEncodingKind.ValueShiftWide64)
                {
                    _is32 = false;
                }
            }
        }
    }

    /// <summary>
    /// Gets the kind of the operand.
    /// </summary>
    public Arm64OperandKind Kind => Arm64OperandKind.Immediate;

    /// <summary>
    /// Gets a value indicating whether this operand is optional.
    /// </summary>
    public bool IsOptional => (Flags & Arm64OperandFlags.Optional) != 0;

    /// <summary>
    /// Gets the flags of the operand.
    /// </summary>
    public Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Gets the value of the operand.
    /// </summary>
    public long Value { get; }

    /// <summary>
    /// Gets the value of the operand as an integer.
    /// </summary>
    public int ValueAsInt => (int)Value;

    /// <summary>
    /// Gets a value indicating whether this operand is a float.
    /// </summary>
    public bool IsFloat { get; }

    /// <summary>
    /// Gets the value of the operand as a float.
    /// </summary>
    public float ValueAsFloat => BitConverter.Int32BitsToSingle(ValueAsInt);

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
        TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    /// <summary>
    /// Tries to format the operand.
    /// </summary>
    /// <param name="instruction">The instruction.</param>
    /// <param name="destination">The destination span.</param>
    /// <param name="charsWritten">The number of characters written.</param>
    /// <param name="isDefaultValue">Indicates whether the value is the default value.</param>
    /// <param name="format">The format.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="tryFormatLabel">The try format label delegate.</param>
    /// <returns>True if the formatting was successful; otherwise, false.</returns>
    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel)
    {
        var defaultValue = (instruction.Id == Arm64InstructionId.ISB_bi_barriers || instruction.Id == Arm64InstructionId.CLREX_bn_barriers) ? 15 : 0;
        isDefaultValue = (_isOptional && Value == defaultValue);

        if (destination.Length <= 1)
        {
            charsWritten = 0;
            return false;
        }

        var length = 1;
        destination[0] = '#';

        if (IsFloat)
        {
            var result = ValueAsFloat.TryFormat(destination.Slice(length), out var numberWritten, Value == 0 ? "0.0" : "0.00000000", provider);
            charsWritten = result ? length + numberWritten : 0;
            return result;
        }
        else
        {
            if (_displayAsHex)
            {
                format = "x";
            }

            if (format.Length == 1)
            {
                if (format[0] == 'x' || format[0] == 'X')
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
                else if (format[0] == 'H' || format[0] == 'L')
                {
                    format = "0";
                }
            }

            if (_is32)
            {
                var result = ValueAsInt.TryFormat(destination.Slice(length), out var numberWritten, format, provider);
                charsWritten = result ? length + numberWritten : 0;
                return result;
            }
            else
            {
                var result = Value.TryFormat(destination.Slice(length), out var numberWritten, format, provider);
                charsWritten = result ? length + numberWritten : 0;
                return result;
            }
        }
    }

    /// <summary>
    /// Explicitly converts an <see cref="Arm64Operand"/> to an <see cref="Arm64ImmediateOperand"/>.
    /// </summary>
    /// <param name="operand">The operand to convert.</param>
    /// <returns>The converted immediate operand.</returns>
    /// <exception cref="InvalidCastException">Thrown when the operand kind is not immediate.</exception>
    public static explicit operator Arm64ImmediateOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Immediate) ThrowInvalidCast(operand.Kind);
        return new Arm64ImmediateOperand(operand);
    }

    /// <summary>
    /// Throws an <see cref="InvalidCastException"/> when the operand kind is invalid.
    /// </summary>
    /// <param name="kind">The operand kind.</param>
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64ImmediateOperand)}");
}
