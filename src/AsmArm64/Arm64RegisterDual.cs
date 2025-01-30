// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents a 64-bit register or the stack pointer.
/// </summary>
public readonly record struct Arm64RegisterXOrSP : IArm64Register
{
    private readonly int _value;
    
    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterAny ToAny() => Unsafe.BitCast<Arm64RegisterXOrSP, Arm64RegisterAny>(this);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <summary>
    /// Implicit conversion from <see cref="Arm64RegisterX"/> to <see cref="Arm64RegisterXOrSP"/>.
    /// </summary>
    /// <param name="register">The register to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64RegisterXOrSP(Arm64RegisterX register) => Unsafe.BitCast<Arm64RegisterX, Arm64RegisterXOrSP>(register);

    /// <summary>
    /// Implicit conversion from <see cref="Arm64RegisterSP"/> to <see cref="Arm64RegisterXOrSP"/>.
    /// </summary>
    /// <param name="register">The register to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64RegisterXOrSP(Arm64RegisterSP register) => Unsafe.BitCast<Arm64RegisterSP, Arm64RegisterXOrSP>(register);
}

/// <summary>
/// Represents a 64-bit register or the stack pointer.
/// </summary>
public readonly record struct Arm64RegisterWOrWSP : IArm64Register
{
    private readonly int _value;
    
    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterAny ToAny() => Unsafe.BitCast<Arm64RegisterWOrWSP, Arm64RegisterAny>(this);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <summary>
    /// Implicit conversion from <see cref="Arm64RegisterW"/> to <see cref="Arm64RegisterWOrWSP"/>.
    /// </summary>
    /// <param name="register">The register to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64RegisterWOrWSP(Arm64RegisterW register) => Unsafe.BitCast<Arm64RegisterW, Arm64RegisterWOrWSP>(register);

    /// <summary>
    /// Implicit conversion from <see cref="Arm64RegisterWSP"/> to <see cref="Arm64RegisterWOrWSP"/>.
    /// </summary>
    /// <param name="register">The register to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64RegisterWOrWSP(Arm64RegisterWSP register) => Unsafe.BitCast<Arm64RegisterWSP, Arm64RegisterWOrWSP>(register);
}

/// <summary>
/// Represents a 64-bit register or the stack pointer.
/// </summary>
public readonly record struct Arm64RegisterXOrW : IArm64Register
{
    private readonly int _value;
    
    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterAny ToAny() => Unsafe.BitCast<Arm64RegisterXOrW, Arm64RegisterAny>(this);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => ToAny().ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => ToAny().TryFormat(destination, out charsWritten, format, provider);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <summary>
    /// Implicit conversion from <see cref="Arm64RegisterX"/> to <see cref="Arm64RegisterXOrW"/>.
    /// </summary>
    /// <param name="register">The register to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64RegisterXOrW(Arm64RegisterX register) => Unsafe.BitCast<Arm64RegisterX, Arm64RegisterXOrW>(register);

    /// <summary>
    /// Implicit conversion from <see cref="Arm64RegisterW"/> to <see cref="Arm64RegisterXOrW"/>.
    /// </summary>
    /// <param name="register">The register to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64RegisterXOrW(Arm64RegisterW register) => Unsafe.BitCast<Arm64RegisterW, Arm64RegisterXOrW>(register);
}
