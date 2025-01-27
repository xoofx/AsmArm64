// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;

namespace AsmArm64;


public interface IArm64MemoryAccessor
{
    Arm64MemoryBaseRegisterKind BaseRegisterKind { get; }

    Arm64MemoryOffsetKind OffsetKind { get; }
    
    Arm64RegisterAny BaseRegister { get; }

    bool HasOptionalOffset { get; }
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

public record struct Arm64MemoryXn
{
}

public record struct Arm64MemoryX
{
}

static partial class Arm64Factory
{
    public static Arm64MemoryAccessorFactory _ => new();
}

public struct Arm64MemoryAccessorFactory
{
    public Arm64BaseMemoryAccessor this[Arm64RegisterXOrSP baseRegister] => default;

    public Arm64BaseXnMemoryAccessor this[Arm64RegisterX baseRegister] => default;

    public Arm64ImmediateMemoryAccessor this[Arm64RegisterXOrSP baseRegister, int immediate] => new(baseRegister, immediate, false);
    
    public Arm64OptionalImmediateMemoryAccessor this[Arm64RegisterXOrSP baseRegister, int? immediate = null] => new(baseRegister, immediate, false);
    
    public Arm64RegisterExtendMemoryAccessor this[Arm64RegisterXOrSP baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend extend, bool isPreIncrement = false] => new(baseRegister, indexRegister, extend, isPreIncrement);
    
    public Arm64OptionalRegisterExtendMemoryAccessor this[Arm64RegisterXOrSP baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend? extend = null, bool isPreIncrement = false] => new(baseRegister, indexRegister, extend, isPreIncrement);
}

public record struct Arm64BaseMemoryAccessor : IArm64MemoryAccessor
{
    public Arm64BaseMemoryAccessor(Arm64RegisterAny baseRegister)
    {
        BaseRegister = baseRegister;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;

    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.None;

    public Arm64RegisterAny BaseRegister { get; }

    public bool HasOptionalOffset => false;
}

public record struct Arm64BaseXnMemoryAccessor : IArm64MemoryAccessor
{
    public Arm64BaseXnMemoryAccessor(Arm64RegisterAny baseRegister)
    {
        BaseRegister = baseRegister;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.RegisterXn;

    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.None;

    public Arm64RegisterAny BaseRegister { get; }
    
    public bool HasOptionalOffset => false;
}

public record struct Arm64ImmediateMemoryAccessor : IArm64MemoryAccessor
{
    public Arm64ImmediateMemoryAccessor(Arm64RegisterAny baseRegister, int immediate)
    {
        BaseRegister = baseRegister;
        Immediate = immediate;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;

    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.Immediate;

    public Arm64RegisterAny BaseRegister { get; }

    public bool HasOptionalOffset => false;

    public int Immediate { get; }

    public bool IsPreIncrement => false;

    public Arm64ImmediateMemoryAccessorPreIncrement Pre => default;
}

public record struct Arm64ImmediateMemoryAccessorPreIncrement : IArm64MemoryAccessor
{
    public Arm64ImmediateMemoryAccessorPreIncrement(Arm64RegisterAny baseRegister, int immediate)
    {
        BaseRegister = baseRegister;
        Immediate = immediate;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;

    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.Immediate;

    public Arm64RegisterAny BaseRegister { get; }

    public bool HasOptionalOffset => false;

    public int Immediate { get; }

    public  bool IsPreIncrement => true;
}

public record struct Arm64OptionalImmediateMemoryAccessor : IArm64MemoryAccessor
{
    public Arm64OptionalImmediateMemoryAccessor(Arm64RegisterAny baseRegister, int? immediate, bool isPreIncrement)
    {
        BaseRegister = baseRegister;
        Immediate = immediate ?? 0;
        HasOptionalOffset = immediate.HasValue;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;

    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.Immediate;

    public Arm64RegisterAny BaseRegister { get; }

    public bool HasOptionalOffset { get; }

    public int Immediate { get; }

    public bool IsPreIncrement => false;

    public Arm64OptionalImmediateMemoryAccessorPreIncrement Pre => default;
}


public record struct Arm64OptionalImmediateMemoryAccessorPreIncrement : IArm64MemoryAccessor
{
    public Arm64OptionalImmediateMemoryAccessorPreIncrement(Arm64RegisterAny baseRegister, int? immediate)
    {
        BaseRegister = baseRegister;
        Immediate = immediate ?? 0;
        HasOptionalOffset = immediate.HasValue;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;

    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.Immediate;

    public Arm64RegisterAny BaseRegister { get; }

    public bool HasOptionalOffset { get; }

    public int Immediate { get; }

    public bool IsPreIncrement => true;
}

public record struct Arm64RegisterExtendMemoryAccessor : IArm64MemoryAccessor
{
    public Arm64RegisterExtendMemoryAccessor(Arm64RegisterAny baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend extend)
    {
        BaseRegister = baseRegister;
        IndexRegister = indexRegister;
        Extend = extend;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;
    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.RegisterExtend;

    public Arm64RegisterAny BaseRegister { get; }

    public bool HasOptionalOffset => false;

    public Arm64RegisterAny IndexRegister { get; }

    public Arm64MemoryExtend Extend { get; }

    public bool IsPreIncrement => false;
}


public record struct Arm64RegisterExtendMemoryAccessorPreIncrement : IArm64MemoryAccessor
{
    public Arm64RegisterExtendMemoryAccessorPreIncrement(Arm64RegisterAny baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend extend)
    {
        BaseRegister = baseRegister;
        IndexRegister = indexRegister;
        Extend = extend;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;
    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.RegisterExtend;

    public Arm64RegisterAny BaseRegister { get; }

    public Arm64RegisterAny IndexRegister { get; }

    public Arm64MemoryExtend Extend { get; }
    public bool HasOptionalOffset => false;

    public bool IsPreIncrement => true;
}

public record struct Arm64OptionalRegisterExtendMemoryAccessor : IArm64MemoryAccessor
{
    public Arm64OptionalRegisterExtendMemoryAccessor(Arm64RegisterAny baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend? extend, bool isPreIncrement)
    {
        BaseRegister = baseRegister;
        IndexRegister = indexRegister;
        Extend = extend ?? default;
        IsPreIncrement = isPreIncrement;
        HasOptionalOffset = extend.HasValue;
    }
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;
    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.RegisterExtend;
    public Arm64RegisterAny BaseRegister { get; }
    public bool HasOptionalOffset { get; }
    public Arm64RegisterAny IndexRegister { get; }
    public Arm64MemoryExtend Extend { get; }
    public bool IsPreIncrement { get; }
}

public record struct Arm64OptionalRegisterExtendMemoryAccessorPreIncrement : IArm64MemoryAccessor
{
    public Arm64OptionalRegisterExtendMemoryAccessorPreIncrement(Arm64RegisterAny baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend? extend)
    {
        BaseRegister = baseRegister;
        IndexRegister = indexRegister;
        Extend = extend ?? default;
        HasOptionalOffset = extend.HasValue;
    }
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => Arm64MemoryBaseRegisterKind.Register;
    public Arm64MemoryOffsetKind OffsetKind => Arm64MemoryOffsetKind.RegisterExtend;
    public Arm64RegisterAny BaseRegister { get; }
    public bool HasOptionalOffset { get; }
    public Arm64RegisterAny IndexRegister { get; }
    public Arm64MemoryExtend Extend { get; }

    public bool IsPreIncrement => true;
}

public record struct Arm64MemoryAccessorAny : IArm64MemoryAccessor
{
    public Arm64MemoryAccessorAny(Arm64RegisterAny baseRegister)
    {
        BaseRegisterKind = Arm64MemoryBaseRegisterKind.Register;
        OffsetKind = Arm64MemoryOffsetKind.None;
        BaseRegister = baseRegister;
    }

    public Arm64MemoryAccessorAny(Arm64RegisterAny baseRegister, int immediate, bool hasOptionalOffset, bool isPreIncrement)
    {
        BaseRegisterKind = Arm64MemoryBaseRegisterKind.Register;
        OffsetKind = Arm64MemoryOffsetKind.Immediate;
        BaseRegister = baseRegister;
        Immediate = immediate;
        HasOptionalOffset = hasOptionalOffset;
        IsPreIncrement = isPreIncrement;
    }

    public Arm64MemoryAccessorAny(Arm64RegisterAny baseRegister, Arm64RegisterAny indexRegister, Arm64MemoryExtend extend, bool hasOptionalOffset, bool isPreIncrement)
    {
        BaseRegisterKind = Arm64MemoryBaseRegisterKind.Register;
        OffsetKind = Arm64MemoryOffsetKind.RegisterExtend;
        BaseRegister = baseRegister;
        IndexRegister = indexRegister;
        Extend = extend;
        HasOptionalOffset = hasOptionalOffset;
        IsPreIncrement = isPreIncrement;
    }

    public Arm64MemoryBaseRegisterKind BaseRegisterKind { get; }

    public Arm64MemoryOffsetKind OffsetKind { get; }

    public Arm64RegisterAny BaseRegister { get; }

    public int Immediate { get; }

    public Arm64RegisterAny IndexRegister { get; }

    public Arm64MemoryExtend Extend { get; }

    public bool IsPreIncrement { get; }

    public bool HasOptionalOffset { get; }
    
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