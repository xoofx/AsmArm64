// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly record struct Arm64RegisterGroupAny : IArm64RegisterGroup
{
    private readonly ulong _baseRegisterCountAndIndexer; // Store it in one ulong to avoid stack spilling when extracting base register / indices

    internal Arm64RegisterGroupAny(Arm64RegisterAny baseRegister, uint countAndIndexer)
    {
        Debug.Assert(Unsafe.SizeOf<Arm64RegisterAny>() == sizeof(uint));
        this._baseRegisterCountAndIndexer =  (ulong)countAndIndexer << 32 | (ulong)Unsafe.BitCast<Arm64RegisterAny, uint>(baseRegister);
    }

    internal Arm64RegisterGroupAny(Arm64RegisterAny baseRegister, uint count, uint index)
    {
        Debug.Assert(Unsafe.SizeOf<Arm64RegisterAny>() == sizeof(uint));
        this._baseRegisterCountAndIndexer =  ((ulong)(index | 0x8000_0000U)  << 40) | ((ulong)count << 32) | (ulong)Unsafe.BitCast<Arm64RegisterAny, uint>(baseRegister);
    }

    public static Arm64RegisterGroupAny Create(Arm64RegisterAny baseRegister, int count)
    {
        if (count == 0 && !baseRegister.IsEmpty)
        {
            throw new ArgumentException("Count must be greater than 0 when BaseRegister is not empty");
        }

        if (count < 0 || count > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Count must be between 0 and 4");
        }

        return new(baseRegister, (uint)count);
    }

    public static Arm64RegisterGroupAny CreateWithIndexer(Arm64RegisterAny baseRegister, int count, int index)
    {
        if (count == 0 && !baseRegister.IsEmpty)
        {
            throw new ArgumentException("Count must be greater than 0 when BaseRegister is not empty");
        }

        if (count < 0 || count > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Count must be between 0 and 4");
        }

        ArgumentOutOfRangeException.ThrowIfNegative(index);

        return new(baseRegister, 0x8000_0000U | ((uint)index << 8) | (uint)count);
    }
    
    public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((uint)_baseRegisterCountAndIndexer);

    public int Count => (byte)(_baseRegisterCountAndIndexer >> 32);

    public Arm64RegisterGroupAny ToAny() => this;

    public bool HasElementIndex => (long)(_baseRegisterCountAndIndexer) < 0;

    public int ElementIndex => (byte)(_baseRegisterCountAndIndexer >> (32 + 8));
    
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[32];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";

        if (Count == 0)
        {
            if (!"{???}".AsSpan().TryCopyTo(destination))
            {
                charsWritten = 0;
                return false;
            }
            charsWritten = "{???}".Length;
            return true;
        }

        if (destination.Length <= 1)
        {
            charsWritten = 0;
            return false;
        }

        destination[0] = '{';
        destination[1] = ' ';
        var written = 2;
        var register = BaseRegister;
        for (int i = 0; i < Count; i++)
        {
            if (i > 0)
            {
                if (destination.Length <= written + 1)
                {
                    charsWritten = 0;
                    return false;
                }
                destination[written] = ',';
                destination[written + 1] = ' ';
                written += 2;
            }

            if (!register.TryFormat(destination.Slice(written), out var writtenRegister, format, provider))
            {
                charsWritten = 0;
                return false;
            }
            written += writtenRegister;
            register = register.Next();
        }

        if (destination.Length <= written + 1)
        {
            charsWritten = 0;
            return false;
        }
        destination[written] = ' ';
        destination[written + 1] = '}';
        written += 2;

        if (HasElementIndex)
        {
            if (destination.Length <= written)
            {
                charsWritten = 0;
                return false;
            }
            destination[written] = '[';
            written++;
            if (!ElementIndex.TryFormat(destination.Slice(written), out var writtenIndex, default, provider))
            {
                charsWritten = 0;
                return false;
            }
            written += writtenIndex;
            if (destination.Length <= written)
            {
                charsWritten = 0;
                return false;
            }
            destination[written] = ']';
            written++;
        }
        
        charsWritten = written;
        return true;
    }
}