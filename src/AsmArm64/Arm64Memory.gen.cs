// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents a memory accessor with only a base register `[XdOrSP]`.
/// </summary>
public readonly record struct Arm64BaseMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64BaseMemoryAccessor"/> struct.
    /// </summary>
    public Arm64BaseMemoryAccessor(Arm64RegisterXOrSP baseRegister) => _accessor = new(baseRegister, false);

    /// <inheritdoc />
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    /// <inheritdoc />
    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    /// <inheritdoc />
    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    /// <inheritdoc />
    public bool IsPreIncrement => _accessor.IsPreIncrement;

    /// <inheritdoc />
    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    /// <inheritdoc />
    public bool HasImmediate => _accessor.HasImmediate;

    /// <inheritdoc />
    public int Immediate => _accessor.Immediate;

    /// <inheritdoc />
    public bool HasIndexRegister => _accessor.HasIndexRegister;

    /// <inheritdoc />
    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    /// <inheritdoc />
    public bool HasExtend => _accessor.HasExtend;

    /// <inheritdoc />
    public Arm64MemoryExtend Extend => _accessor.Extend;

    /// <inheritdoc />
    public override string ToString() => _accessor.ToString();

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
}

/// <summary>
/// Represents a memory accessor with only a base register `[Xd]`. Supports PreIncrement via `[Xd]!`.
/// </summary>
public readonly record struct Arm64BaseXMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64BaseXMemoryAccessor"/> struct.
    /// </summary>
    public Arm64BaseXMemoryAccessor(Arm64RegisterX baseRegister) => _accessor = new(baseRegister, false);

    /// <inheritdoc />
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    /// <inheritdoc />
    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    /// <inheritdoc />
    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    /// <inheritdoc />
    public bool IsPreIncrement => _accessor.IsPreIncrement;

    /// <inheritdoc />
    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    /// <inheritdoc />
    public bool HasImmediate => _accessor.HasImmediate;

    /// <inheritdoc />
    public int Immediate => _accessor.Immediate;

    /// <inheritdoc />
    public bool HasIndexRegister => _accessor.HasIndexRegister;

    /// <inheritdoc />
    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    /// <inheritdoc />
    public bool HasExtend => _accessor.HasExtend;

    /// <inheritdoc />
    public Arm64MemoryExtend Extend => _accessor.Extend;

    /// <inheritdoc />
    public override string ToString() => _accessor.ToString();

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// Gets a memory accessor with a pre-increment.
    /// </summary>
    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(_accessor.BaseRegister));

    /// <summary>
    /// Represents a memory accessor with a pre-increment.
    /// </summary>
    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterX baseRegister) => _accessor = new(baseRegister, true);

        /// <inheritdoc />
        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        /// <inheritdoc />
        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        /// <inheritdoc />
        public bool IsPreIncrement => _accessor.IsPreIncrement;

        /// <inheritdoc />
        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        /// <inheritdoc />
        public bool HasImmediate => _accessor.HasImmediate;

        /// <inheritdoc />
        public int Immediate => _accessor.Immediate;

        /// <inheritdoc />
        public bool HasIndexRegister => _accessor.HasIndexRegister;

        /// <inheritdoc />
        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        /// <inheritdoc />
        public bool HasExtend => _accessor.HasExtend;

        /// <inheritdoc />
        public Arm64MemoryExtend Extend => _accessor.Extend;

        /// <inheritdoc />
        public override string ToString() => _accessor.ToString();

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}

/// <summary>
/// Represents a memory accessor with a base register and an (otptional) immediate `[XdOrSP, #immediate]`. Supports PreIncrement via `[XdOrSP, #immediate]!`.
/// </summary>
public readonly record struct Arm64ImmediateMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ImmediateMemoryAccessor"/> struct.
    /// </summary>
    public Arm64ImmediateMemoryAccessor(Arm64RegisterXOrSP baseRegister, int immediate) => _accessor = new(baseRegister, immediate, false);

    /// <inheritdoc />
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    /// <inheritdoc />
    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    /// <inheritdoc />
    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    /// <inheritdoc />
    public bool IsPreIncrement => _accessor.IsPreIncrement;

    /// <inheritdoc />
    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    /// <inheritdoc />
    public bool HasImmediate => _accessor.HasImmediate;

    /// <inheritdoc />
    public int Immediate => _accessor.Immediate;

    /// <inheritdoc />
    public bool HasIndexRegister => _accessor.HasIndexRegister;

    /// <inheritdoc />
    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    /// <inheritdoc />
    public bool HasExtend => _accessor.HasExtend;

    /// <inheritdoc />
    public Arm64MemoryExtend Extend => _accessor.Extend;

    /// <inheritdoc />
    public override string ToString() => _accessor.ToString();

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// Gets a memory accessor with a pre-increment.
    /// </summary>
    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(_accessor.BaseRegister), _accessor.Immediate);

    /// <summary>
    /// Represents a memory accessor with a pre-increment.
    /// </summary>
    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterXOrSP baseRegister, int immediate) => _accessor = new(baseRegister, immediate, true);

        /// <inheritdoc />
        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        /// <inheritdoc />
        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        /// <inheritdoc />
        public bool IsPreIncrement => _accessor.IsPreIncrement;

        /// <inheritdoc />
        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        /// <inheritdoc />
        public bool HasImmediate => _accessor.HasImmediate;

        /// <inheritdoc />
        public int Immediate => _accessor.Immediate;

        /// <inheritdoc />
        public bool HasIndexRegister => _accessor.HasIndexRegister;

        /// <inheritdoc />
        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        /// <inheritdoc />
        public bool HasExtend => _accessor.HasExtend;

        /// <inheritdoc />
        public Arm64MemoryExtend Extend => _accessor.Extend;

        /// <inheritdoc />
        public override string ToString() => _accessor.ToString();

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}

/// <summary>
/// Represents a memory accessor with a base register, an index register <see cref="Arm64RegisterX"/> and an (optional) extend `[XdOrSP, Xn {, EXTEND #amount}]`. Supports PreIncrement via `[XdOrSP, Xn {, EXTEND #amount}]!`.
/// </summary>
public readonly record struct Arm64RegisterXExtendMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterXExtendMemoryAccessor"/> struct.
    /// </summary>
    public Arm64RegisterXExtendMemoryAccessor(Arm64RegisterXOrSP baseRegister, Arm64RegisterX indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, false);

    /// <inheritdoc />
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    /// <inheritdoc />
    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    /// <inheritdoc />
    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    /// <inheritdoc />
    public bool IsPreIncrement => _accessor.IsPreIncrement;

    /// <inheritdoc />
    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    /// <inheritdoc />
    public bool HasImmediate => _accessor.HasImmediate;

    /// <inheritdoc />
    public int Immediate => _accessor.Immediate;

    /// <inheritdoc />
    public bool HasIndexRegister => _accessor.HasIndexRegister;

    /// <inheritdoc />
    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    /// <inheritdoc />
    public bool HasExtend => _accessor.HasExtend;

    /// <inheritdoc />
    public Arm64MemoryExtend Extend => _accessor.Extend;

    /// <inheritdoc />
    public override string ToString() => _accessor.ToString();

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// Gets a memory accessor with a pre-increment.
    /// </summary>
    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(_accessor.BaseRegister), Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(_accessor.IndexRegister), _accessor.Extend);

    /// <summary>
    /// Represents a memory accessor with a pre-increment.
    /// </summary>
    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterXOrSP baseRegister, Arm64RegisterX indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, true);

        /// <inheritdoc />
        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        /// <inheritdoc />
        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        /// <inheritdoc />
        public bool IsPreIncrement => _accessor.IsPreIncrement;

        /// <inheritdoc />
        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        /// <inheritdoc />
        public bool HasImmediate => _accessor.HasImmediate;

        /// <inheritdoc />
        public int Immediate => _accessor.Immediate;

        /// <inheritdoc />
        public bool HasIndexRegister => _accessor.HasIndexRegister;

        /// <inheritdoc />
        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        /// <inheritdoc />
        public bool HasExtend => _accessor.HasExtend;

        /// <inheritdoc />
        public Arm64MemoryExtend Extend => _accessor.Extend;

        /// <inheritdoc />
        public override string ToString() => _accessor.ToString();

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}

/// <summary>
/// Represents a memory accessor with a base register, an index register <see cref="Arm64RegisterW"/> and an (optional) extend `[XdOrSP, Xn {, EXTEND #amount}]`. Supports PreIncrement via `[XdOrSP, Xn {, EXTEND #amount}]!`.
/// </summary>
public readonly record struct Arm64RegisterWExtendMemoryAccessor : IArm64MemoryAccessor
{
    private readonly Arm64MemoryAccessorAny _accessor;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterWExtendMemoryAccessor"/> struct.
    /// </summary>
    public Arm64RegisterWExtendMemoryAccessor(Arm64RegisterXOrSP baseRegister, Arm64RegisterW indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, false);

    /// <inheritdoc />
    public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

    /// <inheritdoc />
    public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

    /// <inheritdoc />
    public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

    /// <inheritdoc />
    public bool IsPreIncrement => _accessor.IsPreIncrement;

    /// <inheritdoc />
    public bool HasOptionalOffset => _accessor.HasOptionalOffset;

    /// <inheritdoc />
    public bool HasImmediate => _accessor.HasImmediate;

    /// <inheritdoc />
    public int Immediate => _accessor.Immediate;

    /// <inheritdoc />
    public bool HasIndexRegister => _accessor.HasIndexRegister;

    /// <inheritdoc />
    public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

    /// <inheritdoc />
    public bool HasExtend => _accessor.HasExtend;

    /// <inheritdoc />
    public Arm64MemoryExtend Extend => _accessor.Extend;

    /// <inheritdoc />
    public override string ToString() => _accessor.ToString();

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// Gets a memory accessor with a pre-increment.
    /// </summary>
    public PreIncrement Pre => new(Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterXOrSP>(_accessor.BaseRegister), Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterW>(_accessor.IndexRegister), _accessor.Extend);

    /// <summary>
    /// Represents a memory accessor with a pre-increment.
    /// </summary>
    public readonly record struct PreIncrement : IArm64MemoryAccessor
    {
        private readonly Arm64MemoryAccessorAny _accessor;

        public PreIncrement(Arm64RegisterXOrSP baseRegister, Arm64RegisterW indexRegister, Arm64MemoryExtend extend) => _accessor = new(baseRegister, indexRegister, extend, true);

        /// <inheritdoc />
        public Arm64MemoryBaseRegisterKind BaseRegisterKind => _accessor.BaseRegisterKind;

        /// <inheritdoc />
        public Arm64MemoryOffsetKind OffsetKind => _accessor.OffsetKind;

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => _accessor.BaseRegister;

        /// <inheritdoc />
        public bool IsPreIncrement => _accessor.IsPreIncrement;

        /// <inheritdoc />
        public bool HasOptionalOffset => _accessor.HasOptionalOffset;

        /// <inheritdoc />
        public bool HasImmediate => _accessor.HasImmediate;

        /// <inheritdoc />
        public int Immediate => _accessor.Immediate;

        /// <inheritdoc />
        public bool HasIndexRegister => _accessor.HasIndexRegister;

        /// <inheritdoc />
        public Arm64RegisterAny IndexRegister => _accessor.IndexRegister;

        /// <inheritdoc />
        public bool HasExtend => _accessor.HasExtend;

        /// <inheritdoc />
        public Arm64MemoryExtend Extend => _accessor.Extend;

        /// <inheritdoc />
        public override string ToString() => _accessor.ToString();

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider) => _accessor.ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => _accessor.TryFormat(destination, out charsWritten, format, provider);
    }
}
