// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly record struct Arm64BaseMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    public Arm64BaseMemoryAccessor(Arm64RegisterXOrSP baseRegister) => _accessor = new(baseRegister, false);

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    public bool IsPreIncrement => _accessor.IsPreIncrement;

    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    public bool HasImmediate => _accessor.HasImmediate;

    public int Immediate => _accessor.Immediate;

    public bool HasIndexRegister => _accessor.HasIndexRegister;

    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    public bool HasExtend => _accessor.HasExtend;

    public Arm64MemoryExtend Extend => _accessor.Extend;

    public override string ToString() => _accessor.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
}

public readonly record struct Arm64BaseXMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    public Arm64BaseXMemoryAccessor(Arm64RegisterX baseRegister) => _accessor = new(baseRegister, false);

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    public bool IsPreIncrement => _accessor.IsPreIncrement;

    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    public bool HasImmediate => _accessor.HasImmediate;

    public int Immediate => _accessor.Immediate;

    public bool HasIndexRegister => _accessor.HasIndexRegister;

    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    public bool HasExtend => _accessor.HasExtend;

    public Arm64MemoryExtend Extend => _accessor.Extend;

    public override string ToString() => _accessor.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(_accessor.BaseRegister));

    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterX baseRegister) => _accessor = new(baseRegister, true);

        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        public bool IsPreIncrement => _accessor.IsPreIncrement;

        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        public bool HasImmediate => _accessor.HasImmediate;

        public int Immediate => _accessor.Immediate;

        public bool HasIndexRegister => _accessor.HasIndexRegister;

        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        public bool HasExtend => _accessor.HasExtend;

        public Arm64MemoryExtend Extend => _accessor.Extend;

        public override string ToString() => _accessor.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}

public readonly record struct Arm64ImmediateMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    public Arm64ImmediateMemoryAccessor(Arm64RegisterXOrSP baseRegister, int immediate) => _accessor = new(baseRegister, immediate, false);

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    public bool IsPreIncrement => _accessor.IsPreIncrement;

    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    public bool HasImmediate => _accessor.HasImmediate;

    public int Immediate => _accessor.Immediate;

    public bool HasIndexRegister => _accessor.HasIndexRegister;

    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    public bool HasExtend => _accessor.HasExtend;

    public Arm64MemoryExtend Extend => _accessor.Extend;

    public override string ToString() => _accessor.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(_accessor.BaseRegister), _accessor.Immediate);

    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterXOrSP baseRegister, int immediate) => _accessor = new(baseRegister, immediate, true);

        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        public bool IsPreIncrement => _accessor.IsPreIncrement;

        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        public bool HasImmediate => _accessor.HasImmediate;

        public int Immediate => _accessor.Immediate;

        public bool HasIndexRegister => _accessor.HasIndexRegister;

        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        public bool HasExtend => _accessor.HasExtend;

        public Arm64MemoryExtend Extend => _accessor.Extend;

        public override string ToString() => _accessor.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}

public readonly record struct Arm64RegisterXExtendMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    public Arm64RegisterXExtendMemoryAccessor(Arm64RegisterXOrSP baseRegister, Arm64RegisterX indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, false);

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    public bool IsPreIncrement => _accessor.IsPreIncrement;

    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    public bool HasImmediate => _accessor.HasImmediate;

    public int Immediate => _accessor.Immediate;

    public bool HasIndexRegister => _accessor.HasIndexRegister;

    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    public bool HasExtend => _accessor.HasExtend;

    public Arm64MemoryExtend Extend => _accessor.Extend;

    public override string ToString() => _accessor.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(_accessor.BaseRegister), Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(_accessor.IndexRegister), _accessor.Extend);

    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterXOrSP baseRegister, Arm64RegisterX indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, true);

        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        public bool IsPreIncrement => _accessor.IsPreIncrement;

        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        public bool HasImmediate => _accessor.HasImmediate;

        public int Immediate => _accessor.Immediate;

        public bool HasIndexRegister => _accessor.HasIndexRegister;

        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        public bool HasExtend => _accessor.HasExtend;

        public Arm64MemoryExtend Extend => _accessor.Extend;

        public override string ToString() => _accessor.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}

public readonly record struct Arm64RegisterWExtendMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    public Arm64RegisterWExtendMemoryAccessor(Arm64RegisterXOrSP baseRegister, Arm64RegisterW indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, false);

    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    public bool IsPreIncrement => _accessor.IsPreIncrement;

    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    public bool HasImmediate => _accessor.HasImmediate;

    public int Immediate => _accessor.Immediate;

    public bool HasIndexRegister => _accessor.HasIndexRegister;

    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    public bool HasExtend => _accessor.HasExtend;

    public Arm64MemoryExtend Extend => _accessor.Extend;

    public override string ToString() => _accessor.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(_accessor.BaseRegister), Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterW>(_accessor.IndexRegister), _accessor.Extend);

    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterXOrSP baseRegister, Arm64RegisterW indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, true);

        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        public bool IsPreIncrement => _accessor.IsPreIncrement;

        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        public bool HasImmediate => _accessor.HasImmediate;

        public int Immediate => _accessor.Immediate;

        public bool HasIndexRegister => _accessor.HasIndexRegister;

        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        public bool HasExtend => _accessor.HasExtend;

        public Arm64MemoryExtend Extend => _accessor.Extend;

        public override string ToString() => _accessor.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}
