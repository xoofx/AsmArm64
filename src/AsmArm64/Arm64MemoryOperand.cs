// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64MemoryOperand : IArm64Operand
{
    private readonly bool _hasOptionalImmediate;
    private readonly bool _hasOptionalExtend;

    internal Arm64MemoryOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;

        // buffer[1] = (byte)((byte)MemoryEncodingKind | ((byte)ExtendKind << 4));
        // buffer[2] = (byte)BaseRegister.ToSmallEncoding();
        // if (MemoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate)
        // {
        //     buffer[3] = (byte)FixedValue;
        //     buffer[4] = (byte) (IsPreIncrement ? 0x80 : 0);
        // }
        // else
        // {
        //     buffer[3] = (byte)((byte)ImmediateValueEncodingKind | (IsPreIncrement ? 0x80 : 0) | (SignedImmediate ? 0x40 : 0) | (IndexRegisterOrImmediate.Count == 2 ? 0x20 : 0));
        //     int index = 4;
        //     for (int i = 0; i < IndexRegisterOrImmediate.Count; i++)
        //     {
        //         var bitRange = IndexRegisterOrImmediate[i];
        //         buffer[index + i * 2] = (byte)bitRange.LowBit;
        //         buffer[index + 1 + i * 2] = (byte)bitRange.Width;
        //     }
        // }
        var memoryKind = (Arm64MemoryEncodingKind)((byte)(descriptor >> 8) & 0xF);
        var extendEncodingKind = (Arm64MemoryExtendEncodingKind)((byte)(descriptor >> 12) & 0xF);

        var baseRegisterEncodingIndex = (byte)(descriptor >> 16);
        int baseRegisterIndex = Arm64DecodingHelper.GetSmallBitRange(baseRegisterEncodingIndex, rawValue);

        BaseRegister = baseRegisterIndex == 31 && memoryKind != Arm64MemoryEncodingKind.BaseRegisterXn
            ? Arm64RegisterAny.Create(Arm64RegisterKind.SP, baseRegisterIndex, Arm64RegisterVKind.Default, 0, 0)
            : Arm64RegisterAny.Create(Arm64RegisterKind.X, baseRegisterIndex, Arm64RegisterVKind.Default, 0, 0);
        
        if (memoryKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate || memoryKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional)
        {
            MemoryKind = Arm64MemoryKind.BaseRegisterWithImmediate;
            Immediate = (int)(sbyte)(descriptor >> 24);
            IsPreIncrement = (((byte)(descriptor >> 32)) & 0x80) != 0;
            _hasOptionalImmediate = memoryKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional;
        }
        else
        {
            var v = (byte)(descriptor >> 24);
            var indexRegisterOrImmediateCount = (v & 0x20) != 0 ? 2 : 1;
            IsPreIncrement = (v & 0x80) != 0;
            byte isSigned = (byte)((v >> 6) & 1);
            var immediateValueEncodingKind = (Arm64ImmediateValueEncodingKind)(v & 0x1F);

            int value = 0;
            if (indexRegisterOrImmediateCount == 1)
            {
                value = Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), isSigned);
            }
            else
            {
                value = Arm64DecodingHelper.GetBitRange2(rawValue, (byte)(descriptor >> 32), (byte)(descriptor >> 40), (byte)(descriptor >> 48), (byte)(descriptor >> 56), isSigned);
            }

            if (immediateValueEncodingKind != Arm64ImmediateValueEncodingKind.None)
            {
                value = (int)Arm64ImmediateValueHelper.DecodeValue(immediateValueEncodingKind, (int)value);
            }

            switch (memoryKind)
            {
                case Arm64MemoryEncodingKind.BaseRegisterXn:
                    MemoryKind = Arm64MemoryKind.BaseRegisterXn;
                    break;

                case Arm64MemoryEncodingKind.BaseRegister:
                    MemoryKind = Arm64MemoryKind.BaseRegister;
                    break;

                case Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional:
                    _hasOptionalImmediate = true;
                    goto case Arm64MemoryEncodingKind.BaseRegisterAndImmediate;

                case Arm64MemoryEncodingKind.BaseRegisterAndImmediate:
                    MemoryKind = Arm64MemoryKind.BaseRegisterWithImmediate;
                    Immediate = value;
                    break;

                case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional:
                case Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount:
                    _hasOptionalExtend = true;
                    goto case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend;

                case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend:
                    MemoryKind = Arm64MemoryKind.BaseRegisterWithIndexAndExtend;

                    //Debug.Assert(extendBitRange.HiBit == 15 && extendBitRange.Width == 3);
                    //Debug.Assert(amountBitRange.HiBit == 12 && amountBitRange.Width == 1);
                    var option = (rawValue >> 13) & 0b111;
                    var amount = (byte)((rawValue >> 12) & 1);

                    var registerKind = (option & 1) == 0 && memoryKind != Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount
                        ? Arm64RegisterKind.W
                        : Arm64RegisterKind.X;

                    bool isZeroAmount;

                    Arm64ExtendKind extendKind;
                    if (memoryKind == Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount)
                    {
                        isZeroAmount = true;
                        extendKind = Arm64ExtendKind.LSL;
                    }
                    else
                    {
                        isZeroAmount = extendEncodingKind == Arm64MemoryExtendEncodingKind.NoLsl;
                        extendKind = option switch
                        {
                            0b010 => Arm64ExtendKind.UXTW,
                            0b011 => Arm64ExtendKind.UXTX,
                            0b110 => Arm64ExtendKind.SXTW,
                            0b111 => Arm64ExtendKind.SXTX,
                            _ => Arm64ExtendKind.None,
                        };
                    }

                    bool isZeroAmountVisible = false;
                    if (isZeroAmount)
                    {
                        isZeroAmountVisible = extendKind == Arm64ExtendKind.LSL || amount != 0;
                        if (extendKind == Arm64ExtendKind.LSL && amount != 0)
                        {
                            _hasOptionalExtend = false;
                        }
                    }
                    else
                    {
                        if (amount != 0)
                        {
                            switch (extendEncodingKind)
                            {
                                case Arm64MemoryExtendEncodingKind.Shift1:
                                    amount = 1;
                                    break;
                                case Arm64MemoryExtendEncodingKind.Shift2:
                                    amount = 2;
                                    break;
                                case Arm64MemoryExtendEncodingKind.Shift3:
                                    amount = 3;
                                    break;
                                case Arm64MemoryExtendEncodingKind.Shift4:
                                    amount = 4;
                                    break;
                                default:
                                    Debug.Assert(false, "This should not happen");
                                    amount = 0;
                                    break;
                            }

                            if (amount != 0 && extendKind == Arm64ExtendKind.UXTX)
                            {
                                extendKind = Arm64ExtendKind.LSL;
                            }
                        }
                    }

                    IndexRegister = Arm64RegisterAny.Create(registerKind, value, Arm64RegisterVKind.Default, 0, 0);

                    Extend = isZeroAmount ? new Arm64MemoryExtend(extendKind, isZeroAmountVisible) : new Arm64MemoryExtend(extendKind, amount);

                    break;
            }
        }

    }

    public Arm64OperandKind Kind => Arm64OperandKind.Memory;

    public Arm64MemoryKind MemoryKind { get; }

    public Arm64RegisterAny BaseRegister { get; }

    public Arm64RegisterAny IndexRegister { get; }

    public bool IsPreIncrement { get; }

    public int Immediate { get; }

    public Arm64MemoryExtend Extend { get; }

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> span = stackalloc char[32];
        var result = TryFormat(span, out var charsWritten, format, formatProvider);
        Debug.Assert(result);
        return new string(span.Slice(0, charsWritten));
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel)
    {
        isDefaultValue = false;
        // At minimum we need [x0] ~= 4 characters
        if (destination.Length <= 4)
        {
            charsWritten = 0;
            return false;
        }
        destination[0] = '[';
        if (!BaseRegister.TryFormat(destination.Slice(1), out var baseWritten, format, provider))
        {
            charsWritten = 0;
            return false;
        }
        var written = baseWritten + 1;

        if (MemoryKind >= Arm64MemoryKind.BaseRegisterWithImmediate)
        {
            if (MemoryKind == Arm64MemoryKind.BaseRegisterWithImmediate)
            {
                if (!_hasOptionalImmediate || this.Immediate != 0)
                {
                    if (destination.Length <= written + 2)
                    {
                        charsWritten = 0;
                        return false;
                    }
                    destination[written] = ',';
                    destination[written + 1] = ' ';
                    destination[written + 2] = '#';
                    written += 3;

                    if (!Immediate.TryFormat(destination.Slice(written), out var immediateWritten, format, provider))
                    {
                        charsWritten = 0;
                        return false;
                    }

                    written += immediateWritten;
                }
            }
            else
            {
                if (destination.Length <= written + 1)
                {
                    charsWritten = 0;
                    return false;
                }
                destination[written] = ',';
                destination[written + 1] = ' ';
                written += 2;

                if (!IndexRegister.TryFormat(destination.Slice(written), out var indexWritten, format, provider))
                {
                    charsWritten = 0;
                    return false;
                }
                written += indexWritten;

                if (Extend.Kind != Arm64ExtendKind.None && (!_hasOptionalExtend || !Extend.IsDefault))
                {
                    if (destination.Length <= written + 1)
                    {
                        charsWritten = 0;
                        return false;
                    }
                    destination[written] = ',';
                    destination[written + 1] = ' ';
                    written += 2;

                    if (!Extend.TryFormat(destination.Slice(written), out var extendWritten, format, provider))
                    {
                        charsWritten = 0;
                        return false;
                    }
                    written += extendWritten;
                }
            }
        }

        if (destination.Length <= written)
        {
            charsWritten = 0;
            return false;
        }
        destination[written] = ']';
        written++;

        if (IsPreIncrement)
        {
            if (destination.Length <= written)
            {
                charsWritten = 0;
                return false;
            }
            destination[written] = '!';
            written++;
        }

        charsWritten = written;
        return true;
    }

    public static explicit operator Arm64MemoryOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Memory) ThrowInvalidCast(operand.Kind);
        return new Arm64MemoryOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64MemoryOperand)}");
}