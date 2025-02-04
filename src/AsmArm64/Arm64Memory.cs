// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public interface IArm64MemoryAccessor : ISpanFormattable
{
    Arm64MemoryBaseRegisterKind BaseRegisterKind { get; }

    Arm64MemoryOffsetKind OffsetKind { get; }

    Arm64RegisterAny BaseRegister { get; }

    bool IsPreIncrement { get; }

    bool HasOptionalOffset { get; }

    bool HasImmediate { get; }

    int Immediate { get; }

    bool HasIndexRegister { get; }

    Arm64RegisterAny IndexRegister { get; }

    bool HasExtend { get; }

    Arm64MemoryExtend Extend { get; }
}

public enum Arm64MemoryBaseRegisterKind
{
    None,
    Register,
    RegisterXn,
}

public enum Arm64MemoryOffsetKind
{
    None,
    Immediate,
    RegisterExtend,
}

static partial class Arm64Factory
{
    public static Arm64MemoryAccessorFactory _ => new();
}

public struct Arm64MemoryAccessorFactory
{
    public Arm64BaseMemoryAccessor this[Arm64RegisterXOrSP baseRegister] => new(baseRegister);

    public Arm64BaseXMemoryAccessor this[Arm64RegisterX baseRegister] => new(baseRegister);

    public Arm64ImmediateMemoryAccessor this[Arm64RegisterXOrSP baseRegister, int immediate] => new(baseRegister, immediate);

    public Arm64RegisterXExtendMemoryAccessor this[Arm64RegisterXOrSP baseRegister, Arm64RegisterX indexRegister, Arm64ExtendXKind extend = default, byte? amount = null ]
        => new(baseRegister, indexRegister, amount.HasValue ? new(extend.ExtendKind, amount.Value) : new(extend.ExtendKind, false));

    public Arm64RegisterWExtendMemoryAccessor this[Arm64RegisterXOrSP baseRegister, Arm64RegisterW indexRegister, Arm64ExtendWKind extend = default, byte? amount = null]
        => new(baseRegister, indexRegister, amount.HasValue ? new(extend.ExtendKind, amount.Value) : new(extend.ExtendKind, false));
}

public readonly record struct Arm64MemoryAccessorAny : IArm64MemoryAccessor
{
    private readonly ulong _value;

    private const uint Mask2Bits = 0x3;
    internal const uint ExtendValue = 0x2;
    internal const uint ImmediateValue = 0x1;
    internal const int LowBitImmediateOrExtendKind = 28;
    internal const uint BaseRegisterOnly = 0x2;
    internal const uint BaseRegisterXOnly = 0x1;
    internal const int LowBitKindBaseRegister = 28;
    internal const int LowBitPreIncrement = 27;
    internal const int LowBitHasOptionalOffset = 26;
    internal const int LowBitExtend = 12;

    public Arm64MemoryAccessorAny(Arm64RegisterX baseRegister, bool isPreIncrement)
    {
        var value = (ulong)Unsafe.BitCast<Arm64RegisterX, uint>(baseRegister);
        value |= (ulong)BaseRegisterXOnly << LowBitKindBaseRegister;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        _value = value;
    }

    public Arm64MemoryAccessorAny(Arm64RegisterXOrSP baseRegister, bool isPreIncrement)
    {
        var value = (ulong)Unsafe.BitCast<Arm64RegisterXOrSP, uint>(baseRegister);
        value |= (ulong)BaseRegisterOnly << LowBitKindBaseRegister;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        _value = value;
    }

    public Arm64MemoryAccessorAny(Arm64RegisterXOrSP baseRegister, int immediate, bool isPreIncrement, bool hasOptionalOffset = false)
    {
        var value = (ulong)Unsafe.BitCast<Arm64RegisterXOrSP, uint>(baseRegister) | ((ulong)(uint)immediate << 32);
        value |= (ulong)ImmediateValue << LowBitImmediateOrExtendKind;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        value |= hasOptionalOffset ? 1UL << LowBitHasOptionalOffset : 0;
        _value = value;
    }

    public Arm64MemoryAccessorAny(Arm64RegisterXOrSP baseRegister, Arm64RegisterXOrW indexRegister, Arm64MemoryExtend extend, bool isPreIncrement, bool hasOptionalOffset = false)
    {
        var value = (ulong)Unsafe.BitCast<Arm64RegisterXOrSP, uint>(baseRegister) | ((ulong)Unsafe.BitCast<Arm64RegisterXOrW, uint>(indexRegister) << 32);
        value |= (ulong)ExtendValue << LowBitImmediateOrExtendKind;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        value |= hasOptionalOffset ? 1UL << LowBitHasOptionalOffset : 0;
        value |= (ulong)Unsafe.BitCast<Arm64MemoryExtend, ushort>(extend) << LowBitExtend;
        _value = value;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => (((uint)_value >> LowBitKindBaseRegister) & Mask2Bits) switch
    {
        BaseRegisterOnly => Arm64MemoryBaseRegisterKind.Register,
        BaseRegisterXOnly => Arm64MemoryBaseRegisterKind.RegisterXn,
        _ => Arm64MemoryBaseRegisterKind.None
    };

    public Arm64MemoryOffsetKind OffsetKind => (((uint)_value >> LowBitImmediateOrExtendKind) & Mask2Bits) switch
    {
        ImmediateValue => Arm64MemoryOffsetKind.Immediate,
        ExtendValue => Arm64MemoryOffsetKind.RegisterExtend,
        _ => Arm64MemoryOffsetKind.None
    };

    public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((ushort)_value);

    public bool HasImmediate => ((_value >> LowBitImmediateOrExtendKind) & Mask2Bits) == ImmediateValue;

    public int Immediate => HasImmediate ? (int)(_value >> 32) : 0;

    public bool HasIndexRegister => ((_value >> LowBitImmediateOrExtendKind) & Mask2Bits) == ExtendValue;

    public Arm64RegisterAny IndexRegister => HasIndexRegister ? Unsafe.BitCast<uint, Arm64RegisterAny>((ushort)(_value >> 32)) : default;

    public bool HasExtend => ((_value >> LowBitImmediateOrExtendKind) & Mask2Bits) == ExtendValue;

    public Arm64MemoryExtend Extend => HasExtend ? Unsafe.BitCast<ushort, Arm64MemoryExtend>((ushort)((_value >> LowBitExtend) & Arm64MemoryExtend.Mask)) : default;

    public bool IsPreIncrement => ((_value >> LowBitPreIncrement) & 1) != 0;

    public bool HasOptionalOffset => ((_value >> LowBitHasOptionalOffset) & 1) != 0;
    
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

        if (OffsetKind != Arm64MemoryOffsetKind.None)
        {
            if (OffsetKind == Arm64MemoryOffsetKind.Immediate)
            {
                if (!HasOptionalOffset || this.Immediate != 0)
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

                if (Extend.Kind != Arm64ExtendKind.None && (!HasOptionalOffset || !Extend.IsDefault))
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
}