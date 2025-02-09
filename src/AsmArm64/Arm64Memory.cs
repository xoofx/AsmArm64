// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents a generic memory accessor for ARM64.
/// </summary>
public readonly record struct Arm64MemoryAccessorAny : IArm64MemoryAccessor
{
    private readonly ulong _value;

    private const uint Mask2Bits = 0x3;
    internal const int LowBitImmediateOrExtendKind = 30;
    internal const int LowBitBaseRegisterKind = 28;
    internal const int LowBitPreIncrement = 27;
    internal const int LowBitHasOptionalOffset = 26;
    internal const int LowBitExtend = 12;
    internal const uint BaseRegisterMask = (1 << LowBitExtend) - 1;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64MemoryAccessorAny"/> struct with a base register.
    /// </summary>
    /// <param name="baseRegister">The base register.</param>
    /// <param name="isPreIncrement">Indicates if the base register should be pre-incremented.</param>
    public Arm64MemoryAccessorAny(Arm64RegisterX baseRegister, bool isPreIncrement = false)
    {
        Debug.Assert(Unsafe.SizeOf<Arm64MemoryAccessorAny>() == sizeof(ulong));
        var value = (ulong)Unsafe.BitCast<Arm64RegisterX, uint>(baseRegister);
        value |= (ulong)Arm64MemoryBaseRegisterKind.RegisterX << LowBitBaseRegisterKind;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64MemoryAccessorAny"/> struct with a base register that can be X or SP.
    /// </summary>
    /// <param name="baseRegister">The base register, which can be X or SP.</param>
    /// <param name="isPreIncrement">Indicates if the base register should be pre-incremented.</param>
    public Arm64MemoryAccessorAny(Arm64RegisterXOrSP baseRegister, bool isPreIncrement = false)
    {
        Debug.Assert(Unsafe.SizeOf<Arm64MemoryAccessorAny>() == sizeof(ulong));
        var value = (ulong)Unsafe.BitCast<Arm64RegisterXOrSP, uint>(baseRegister);
        value |= (ulong)Arm64MemoryBaseRegisterKind.RegisterXOrSP << LowBitBaseRegisterKind;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64MemoryAccessorAny"/> struct with a base register, an immediate offset, and optional flags.
    /// </summary>
    /// <param name="baseRegister">The base register, which can be X or SP.</param>
    /// <param name="immediate">The immediate offset.</param>
    /// <param name="isPreIncrement">Indicates if the base register should be pre-incremented.</param>
    /// <param name="hasOptionalOffset">Indicates if there is an optional offset.</param>
    public Arm64MemoryAccessorAny(Arm64RegisterXOrSP baseRegister, int immediate, bool isPreIncrement = false, bool hasOptionalOffset = false)
    {
        Debug.Assert(Unsafe.SizeOf<Arm64MemoryAccessorAny>() == sizeof(ulong));
        var value = (ulong)Unsafe.BitCast<Arm64RegisterXOrSP, uint>(baseRegister) | ((ulong)(uint)immediate << 32);
        value |= (ulong)Arm64MemoryOffsetKind.Immediate << LowBitImmediateOrExtendKind;
        value |= (ulong)Arm64MemoryBaseRegisterKind.RegisterXOrSP << LowBitBaseRegisterKind;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        value |= hasOptionalOffset ? 1UL << LowBitHasOptionalOffset : 0;
        _value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64MemoryAccessorAny"/> struct with a base register, an index register, an extend type, and optional flags.
    /// </summary>
    /// <param name="baseRegister">The base register, which can be X or SP.</param>
    /// <param name="indexRegister">The index register, which can be X or W.</param>
    /// <param name="extend">The extend type.</param>
    /// <param name="isPreIncrement">Indicates if the base register should be pre-incremented.</param>
    /// <param name="hasOptionalOffset">Indicates if there is an optional offset.</param>
    public Arm64MemoryAccessorAny(Arm64RegisterXOrSP baseRegister, Arm64RegisterXOrW indexRegister, Arm64MemoryExtend extend, bool isPreIncrement = false, bool hasOptionalOffset = false)
    {
        Debug.Assert(Unsafe.SizeOf<Arm64MemoryAccessorAny>() == sizeof(ulong));
        var value = (ulong)Unsafe.BitCast<Arm64RegisterXOrSP, uint>(baseRegister) | ((ulong)Unsafe.BitCast<Arm64RegisterXOrW, uint>(indexRegister) << 32);
        value |= (ulong)Arm64MemoryOffsetKind.RegisterExtend << LowBitImmediateOrExtendKind;
        value |= (ulong)Arm64MemoryBaseRegisterKind.RegisterXOrSP << LowBitBaseRegisterKind;
        value |= isPreIncrement ? 1UL << LowBitPreIncrement : 0;
        value |= hasOptionalOffset ? 1UL << LowBitHasOptionalOffset : 0;
        value |= (ulong)Unsafe.BitCast<Arm64MemoryExtend, ushort>(extend) << LowBitExtend;
        _value = value;
    }

    /// <inheritdoc />
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => (Arm64MemoryBaseRegisterKind)(((uint)_value >> LowBitBaseRegisterKind) & Mask2Bits);

    /// <inheritdoc />
    public Arm64MemoryOffsetKind OffsetKind => (Arm64MemoryOffsetKind)(((uint)_value >> LowBitImmediateOrExtendKind) & Mask2Bits);

    /// <inheritdoc />
    public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((ushort)_value & BaseRegisterMask);

    /// <inheritdoc />
    public bool HasImmediate => OffsetKind == Arm64MemoryOffsetKind.Immediate;

    /// <inheritdoc />
    public int Immediate => HasImmediate ? (int)(_value >> 32) : 0;

    /// <inheritdoc />
    public bool HasIndexRegister => OffsetKind == Arm64MemoryOffsetKind.RegisterExtend;

    /// <inheritdoc />
    public Arm64RegisterAny IndexRegister => HasIndexRegister ? Unsafe.BitCast<uint, Arm64RegisterAny>((ushort)(_value >> 32)) : default;

    /// <inheritdoc />
    public bool HasExtend => OffsetKind == Arm64MemoryOffsetKind.RegisterExtend;

    /// <inheritdoc />
    public Arm64MemoryExtend Extend => HasExtend ? Unsafe.BitCast<ushort, Arm64MemoryExtend>((ushort)((_value >> LowBitExtend) & Arm64MemoryExtend.Mask)) : default;

    /// <inheritdoc />
    public bool IsPreIncrement => ((_value >> LowBitPreIncrement) & 1) != 0;

    /// <inheritdoc />
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
        => TryFormat(destination, out charsWritten, out _, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider)
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

                    if (!Immediate.TryFormat(destination.Slice(written), out var immediateWritten, "G", provider))
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