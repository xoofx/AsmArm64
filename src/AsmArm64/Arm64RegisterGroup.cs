// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents a group of 1 ARM64 registers.
/// </summary>
public readonly record struct Arm64RegisterGroup1<TReg> : IArm64RegisterGroup where TReg : struct, IArm64RegisterV
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterGroup1{TReg}"/> struct.
    /// </summary>
    public Arm64RegisterGroup1(TReg baseRegister)
    {
        BaseRegister = baseRegister;
    }

    /// <summary>
    /// Gets the base register of this group
    /// </summary>
    public TReg BaseRegister { get; }

    /// <inheritdoc />
    public int Count => 1;

    /// <inheritdoc />
    public Arm64RegisterGroupAny ToAny() => new(BaseRegister.ToAny(), 1);

    /// <inheritdoc />
    public bool HasGroupIndex => false;

    /// <inheritdoc />
    public int GroupIndex => 0;

    public int Index => BaseRegister.Index;

    /// <summary>
    /// Gets the register at the specified index in the range [0, 1[.
    /// </summary>
    /// <param name="index">The index in the group in the range [0, 1[..</param>
    /// <returns>The group indexed.</returns>
    public Indexed this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan((uint)index, 1U, nameof(index));
            return new(BaseRegister, (uint)index);
        }
    }

    /// <inheritdoc />
    Arm64RegisterAny IArm64RegisterGroup.BaseRegister => BaseRegister.ToAny();

    /// <inheritdoc />
    public override string ToString()
        => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
        => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// An indexed register group with the specified base register.
    /// </summary>
    public readonly record struct Indexed : IArm64RegisterGroup
    {
        private readonly ulong _baseRegisterCountAndIndexer; // Store it in one ulong to avoid stack spilling when extracting base register / indices

        internal Indexed(TReg baseRegister, uint index)
        {
            Debug.Assert(Unsafe.SizeOf<TReg>() == sizeof(uint));
            this._baseRegisterCountAndIndexer = ((ulong)index << 40) | ((ulong)(0x8000_0000U | 1) << 32) | (ulong)Unsafe.BitCast<TReg, uint>(baseRegister);
        }

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((uint)_baseRegisterCountAndIndexer);

        /// <inheritdoc />
        public int Count => (byte)(1);

        /// <inheritdoc />
        public Arm64RegisterGroupAny ToAny() => Unsafe.BitCast<Indexed, Arm64RegisterGroupAny>(this);

        /// <inheritdoc />
        public bool HasGroupIndex => (long)(_baseRegisterCountAndIndexer) < 0;

        /// <inheritdoc />
        public int GroupIndex => (byte)(_baseRegisterCountAndIndexer >> (32 + 8));

        /// <inheritdoc />
        public override string ToString()
            => ToString(null, null);

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider)
            => ToAny().ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => ToAny().TryFormat(destination, out charsWritten, format, provider);
    }
}

/// <summary>
/// Represents a group of 2 ARM64 registers.
/// </summary>
public readonly record struct Arm64RegisterGroup2<TReg> : IArm64RegisterGroup where TReg : struct, IArm64RegisterV
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterGroup2{TReg}"/> struct.
    /// </summary>
    public Arm64RegisterGroup2(TReg baseRegister)
    {
        BaseRegister = baseRegister;
    }

    /// <summary>
    /// Gets the base register of this group
    /// </summary>
    public TReg BaseRegister { get; }

    /// <inheritdoc />
    public int Count => 2;

    /// <inheritdoc />
    public Arm64RegisterGroupAny ToAny() => new(BaseRegister.ToAny(), 2);

    /// <inheritdoc />
    public bool HasGroupIndex => false;

    /// <inheritdoc />
    public int GroupIndex => 0;

    public int Index => BaseRegister.Index;

    /// <summary>
    /// Gets the register at the specified index in the range [0, 2[.
    /// </summary>
    /// <param name="index">The index in the group in the range [0, 2[..</param>
    /// <returns>The group indexed.</returns>
    public Indexed this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan((uint)index, 2U, nameof(index));
            return new(BaseRegister, (uint)index);
        }
    }

    /// <inheritdoc />
    Arm64RegisterAny IArm64RegisterGroup.BaseRegister => BaseRegister.ToAny();

    /// <inheritdoc />
    public override string ToString()
        => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
        => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// An indexed register group with the specified base register.
    /// </summary>
    public readonly record struct Indexed : IArm64RegisterGroup
    {
        private readonly ulong _baseRegisterCountAndIndexer; // Store it in one ulong to avoid stack spilling when extracting base register / indices

        internal Indexed(TReg baseRegister, uint index)
        {
            Debug.Assert(Unsafe.SizeOf<TReg>() == sizeof(uint));
            this._baseRegisterCountAndIndexer = ((ulong)index << 40) | ((ulong)(0x8000_0000U | 2) << 32) | (ulong)Unsafe.BitCast<TReg, uint>(baseRegister);
        }

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((uint)_baseRegisterCountAndIndexer);

        /// <inheritdoc />
        public int Count => (byte)(2);

        /// <inheritdoc />
        public Arm64RegisterGroupAny ToAny() => Unsafe.BitCast<Indexed, Arm64RegisterGroupAny>(this);

        /// <inheritdoc />
        public bool HasGroupIndex => (long)(_baseRegisterCountAndIndexer) < 0;

        /// <inheritdoc />
        public int GroupIndex => (byte)(_baseRegisterCountAndIndexer >> (32 + 8));

        /// <inheritdoc />
        public override string ToString()
            => ToString(null, null);

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider)
            => ToAny().ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => ToAny().TryFormat(destination, out charsWritten, format, provider);
    }
}

/// <summary>
/// Represents a group of 3 ARM64 registers.
/// </summary>
public readonly record struct Arm64RegisterGroup3<TReg> : IArm64RegisterGroup where TReg : struct, IArm64RegisterV
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterGroup3{TReg}"/> struct.
    /// </summary>
    public Arm64RegisterGroup3(TReg baseRegister)
    {
        BaseRegister = baseRegister;
    }

    /// <summary>
    /// Gets the base register of this group
    /// </summary>
    public TReg BaseRegister { get; }

    /// <inheritdoc />
    public int Count => 3;

    /// <inheritdoc />
    public Arm64RegisterGroupAny ToAny() => new(BaseRegister.ToAny(), 3);

    /// <inheritdoc />
    public bool HasGroupIndex => false;

    /// <inheritdoc />
    public int GroupIndex => 0;

    public int Index => BaseRegister.Index;

    /// <summary>
    /// Gets the register at the specified index in the range [0, 3[.
    /// </summary>
    /// <param name="index">The index in the group in the range [0, 3[..</param>
    /// <returns>The group indexed.</returns>
    public Indexed this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan((uint)index, 3U, nameof(index));
            return new(BaseRegister, (uint)index);
        }
    }

    /// <inheritdoc />
    Arm64RegisterAny IArm64RegisterGroup.BaseRegister => BaseRegister.ToAny();

    /// <inheritdoc />
    public override string ToString()
        => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
        => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// An indexed register group with the specified base register.
    /// </summary>
    public readonly record struct Indexed : IArm64RegisterGroup
    {
        private readonly ulong _baseRegisterCountAndIndexer; // Store it in one ulong to avoid stack spilling when extracting base register / indices

        internal Indexed(TReg baseRegister, uint index)
        {
            Debug.Assert(Unsafe.SizeOf<TReg>() == sizeof(uint));
            this._baseRegisterCountAndIndexer = ((ulong)index << 40) | ((ulong)(0x8000_0000U | 3) << 32) | (ulong)Unsafe.BitCast<TReg, uint>(baseRegister);
        }

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((uint)_baseRegisterCountAndIndexer);

        /// <inheritdoc />
        public int Count => (byte)(3);

        /// <inheritdoc />
        public Arm64RegisterGroupAny ToAny() => Unsafe.BitCast<Indexed, Arm64RegisterGroupAny>(this);

        /// <inheritdoc />
        public bool HasGroupIndex => (long)(_baseRegisterCountAndIndexer) < 0;

        /// <inheritdoc />
        public int GroupIndex => (byte)(_baseRegisterCountAndIndexer >> (32 + 8));

        /// <inheritdoc />
        public override string ToString()
            => ToString(null, null);

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider)
            => ToAny().ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => ToAny().TryFormat(destination, out charsWritten, format, provider);
    }
}

/// <summary>
/// Represents a group of 4 ARM64 registers.
/// </summary>
public readonly record struct Arm64RegisterGroup4<TReg> : IArm64RegisterGroup where TReg : struct, IArm64RegisterV
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterGroup4{TReg}"/> struct.
    /// </summary>
    public Arm64RegisterGroup4(TReg baseRegister)
    {
        BaseRegister = baseRegister;
    }

    /// <summary>
    /// Gets the base register of this group
    /// </summary>
    public TReg BaseRegister { get; }

    /// <inheritdoc />
    public int Count => 4;

    /// <inheritdoc />
    public Arm64RegisterGroupAny ToAny() => new(BaseRegister.ToAny(), 4);

    /// <inheritdoc />
    public bool HasGroupIndex => false;

    /// <inheritdoc />
    public int GroupIndex => 0;

    public int Index => BaseRegister.Index;

    /// <summary>
    /// Gets the register at the specified index in the range [0, 4[.
    /// </summary>
    /// <param name="index">The index in the group in the range [0, 4[..</param>
    /// <returns>The group indexed.</returns>
    public Indexed this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan((uint)index, 4U, nameof(index));
            return new(BaseRegister, (uint)index);
        }
    }

    /// <inheritdoc />
    Arm64RegisterAny IArm64RegisterGroup.BaseRegister => BaseRegister.ToAny();

    /// <inheritdoc />
    public override string ToString()
        => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
        => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <summary>
    /// An indexed register group with the specified base register.
    /// </summary>
    public readonly record struct Indexed : IArm64RegisterGroup
    {
        private readonly ulong _baseRegisterCountAndIndexer; // Store it in one ulong to avoid stack spilling when extracting base register / indices

        internal Indexed(TReg baseRegister, uint index)
        {
            Debug.Assert(Unsafe.SizeOf<TReg>() == sizeof(uint));
            this._baseRegisterCountAndIndexer = ((ulong)index << 40) | ((ulong)(0x8000_0000U | 4) << 32) | (ulong)Unsafe.BitCast<TReg, uint>(baseRegister);
        }

        /// <inheritdoc />
        public Arm64RegisterAny BaseRegister => Unsafe.BitCast<uint, Arm64RegisterAny>((uint)_baseRegisterCountAndIndexer);

        /// <inheritdoc />
        public int Count => (byte)(4);

        /// <inheritdoc />
        public Arm64RegisterGroupAny ToAny() => Unsafe.BitCast<Indexed, Arm64RegisterGroupAny>(this);

        /// <inheritdoc />
        public bool HasGroupIndex => (long)(_baseRegisterCountAndIndexer) < 0;

        /// <inheritdoc />
        public int GroupIndex => (byte)(_baseRegisterCountAndIndexer >> (32 + 8));

        /// <inheritdoc />
        public override string ToString()
            => ToString(null, null);

        /// <inheritdoc />
        public string ToString(string? format, IFormatProvider? formatProvider)
            => ToAny().ToString(format, formatProvider);

        /// <inheritdoc />
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
            => ToAny().TryFormat(destination, out charsWritten, format, provider);
    }
}
