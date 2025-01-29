// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;

namespace AsmArm64;

public interface IArm64RegisterGroup : ISpanFormattable
{
    /// <summary>
    /// Gets the base register of this group
    /// </summary>
    Arm64RegisterAny BaseRegister { get; }
    
    /// <summary>
    /// Gets the number of registers in this group (from 1 to 4)
    /// </summary>
    int Count { get; }
}

public readonly record struct Arm64RegisterGroup1<TReg> where TReg : struct, IArm64RegisterV
{
    public int Index { get; } // TODO
}

public readonly record struct Arm64RegisterGroup2<TReg> where TReg : struct, IArm64RegisterV
{
    public int Index { get; } // TODO
}

public readonly record struct Arm64RegisterGroup3<TReg> where TReg : struct, IArm64RegisterV
{
    public int Index { get; } // TODO
}

public readonly record struct Arm64RegisterGroup4<TReg> where TReg : struct, IArm64RegisterV
{
    public int Index { get; } // TODO
}

public readonly record struct Arm64RegisterGroupAny : IArm64RegisterGroup
{
    private readonly Arm64RegisterAny _baseRegister;
    private readonly uint _countAndIndexer;

    internal Arm64RegisterGroupAny(Arm64RegisterAny baseRegister, uint countAndIndexer)
    {
        this._baseRegister = baseRegister;
        this._countAndIndexer = countAndIndexer;
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
    
    public Arm64RegisterAny BaseRegister => _baseRegister;

    public int Count => (byte)_countAndIndexer;

    public bool HasIndexer => (int)_countAndIndexer < 0;

    public int Index => (byte)(_countAndIndexer >> 8);
    
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

        if (HasIndexer)
        {
            if (destination.Length <= written)
            {
                charsWritten = 0;
                return false;
            }
            destination[written] = '[';
            written++;
            if (!Index.TryFormat(destination.Slice(written), out var writtenIndex, default, provider))
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
