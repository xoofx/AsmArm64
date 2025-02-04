// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64MemoryOperand : IArm64Operand
{
    private readonly Arm64MemoryAccessorAny _accessor;

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
        var memoryEncodingKind = (Arm64MemoryEncodingKind)((byte)(descriptor >> 8) & 0xF);
        var extendEncodingKind = (Arm64MemoryExtendEncodingKind)((byte)(descriptor >> 12) & 0xF);

        var baseRegisterEncodingIndex = (byte)(descriptor >> 16);
        int baseRegisterIndex = Arm64DecodingHelper.GetSmallBitRange(baseRegisterEncodingIndex, rawValue);

        var baseRegister = baseRegisterIndex == 31 && memoryEncodingKind != Arm64MemoryEncodingKind.BaseRegisterXn
            ? Arm64RegisterAny.Create(Arm64RegisterKind.SP, baseRegisterIndex, Arm64RegisterVKind.Default, 0, 0)
            : Arm64RegisterAny.Create(Arm64RegisterKind.X, baseRegisterIndex, Arm64RegisterVKind.Default, 0, 0);

        if (memoryEncodingKind == Arm64MemoryEncodingKind.BaseRegister)
        {
            _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(baseRegister));
        }
        else if (memoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterXn)
        {
            _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(baseRegister));
        }
        else if (memoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate || memoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional)
        {
            var immediate = (int)(sbyte)(descriptor >> 24);
            var isPreIncrement = (((byte)(descriptor >> 32)) & 0x80) != 0;
            var hasOptionalImmediate = memoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional;
            _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(baseRegister), immediate, isPreIncrement, hasOptionalImmediate);
        }
        else
        {
            var v = (byte)(descriptor >> 24);
            var indexRegisterOrImmediateCount = (v & 0x20) != 0 ? 2 : 1;
            var isPreIncrement = (v & 0x80) != 0;
            byte isSigned = (byte)((v >> 6) & 1);
            var immediateValueEncodingKind = (Arm64ImmediateValueEncodingKind)(v & 0x1F);
            bool hasOptionalExtend = false;

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

            switch (memoryEncodingKind)
            {
                case Arm64MemoryEncodingKind.BaseRegisterAndImmediateOptional:
                    _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(baseRegister), value, isPreIncrement, true);
                    break;

                case Arm64MemoryEncodingKind.BaseRegisterAndImmediate:
                    _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(baseRegister), value, isPreIncrement, false);
                    break;

                case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtendOptional:
                case Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount:
                    hasOptionalExtend = true;
                    goto case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend;

                case Arm64MemoryEncodingKind.BaseRegisterAndIndexWmOrXmAndExtend:
                    //Debug.Assert(extendBitRange.HiBit == 15 && extendBitRange.Width == 3);
                    //Debug.Assert(amountBitRange.HiBit == 12 && amountBitRange.Width == 1);
                    var option = (rawValue >> 13) & 0b111;
                    var amount = (byte)((rawValue >> 12) & 1);

                    var registerKind = (option & 1) == 0 && memoryEncodingKind != Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount
                        ? Arm64RegisterKind.W
                        : Arm64RegisterKind.X;

                    bool isZeroAmount;

                    Arm64ExtendKind extendKind;
                    if (memoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndIndexXmAndLslAmount)
                    {
                        isZeroAmount = true;
                        extendKind = Arm64ExtendKind.LSL;
                    }
                    else
                    {
                        isZeroAmount = extendEncodingKind == Arm64MemoryExtendEncodingKind.Shift0;
                        extendKind = option switch
                        {
                            0b010 => Arm64ExtendKind.UXTW,
                            0b011 => Arm64ExtendKind.LSL,
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
                            hasOptionalExtend = false;
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
                        }
                    }


                    var indexRegister = Arm64RegisterAny.Create(registerKind, value, Arm64RegisterVKind.Default, 0, 0);
                    var extend = isZeroAmount ? new Arm64MemoryExtend(extendKind, isZeroAmountVisible) : new Arm64MemoryExtend(extendKind, amount);

                    if (registerKind == Arm64RegisterKind.X)
                    {
                        _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(baseRegister), Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(indexRegister), extend, isPreIncrement, hasOptionalExtend);
                    }
                    else
                    {
                        Debug.Assert(registerKind == Arm64RegisterKind.W);
                        _accessor = new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(baseRegister), Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterW>(indexRegister), extend, isPreIncrement, hasOptionalExtend);
                    }

                    break;
                default:
                    Debug.Assert(false, "This should not happen");
                    break;
            }
        }
    }

    public Arm64OperandKind Kind => Arm64OperandKind.Memory;

    public Arm64MemoryAccessorAny Accessor => _accessor;

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
        => _accessor.TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);

    public static explicit operator Arm64MemoryOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Memory) ThrowInvalidCast(operand.Kind);
        return new Arm64MemoryOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64MemoryOperand)}");
}