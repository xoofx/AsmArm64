// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents a 64-bit logical immediate value for AArch64.
/// </summary>
public readonly record struct Arm64LogicalImmediate64 : ISpanFormattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64LogicalImmediate64"/> struct.
    /// </summary>
    /// <param name="encodedValue">The encoded value.</param>
    internal Arm64LogicalImmediate64(int encodedValue)
    {
        EncodedValue = encodedValue;
    }

    /// <summary>
    /// Gets the encoded value.
    /// </summary>
    public int EncodedValue { get; }

    /// <summary>
    /// Gets the N field of the encoded value.
    /// </summary>
    public int N => (EncodedValue >> 12) & 1;

    /// <summary>
    /// Gets the ImmR field of the encoded value.
    /// </summary>
    public int ImmR => (EncodedValue >> 6) & 0x3f;

    /// <summary>
    /// Gets the ImmS field of the encoded value.
    /// </summary>
    public int ImmS => EncodedValue & 0x3f;

    /// <summary>
    /// Decodes the logical immediate value.
    /// </summary>
    /// <returns>The decoded logical immediate value.</returns>
    public ulong Value() => Arm64LogicalImmediateHelper.DecodeLogicalImmediate64((uint)EncodedValue);

    /// <summary>
    /// Encodes the specified value as an <see cref="Arm64LogicalImmediate64"/>.
    /// </summary>
    /// <param name="value">The value to encode.</param>
    /// <returns>The encoded <see cref="Arm64LogicalImmediate64"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Arm64LogicalImmediate64 Encode(ulong value)
        => Unsafe.BitCast<int, Arm64LogicalImmediate64>(Arm64LogicalImmediateHelper.EncodeLogicalImmediate64(value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Arm64LogicalImmediate64(ulong value)
        => Unsafe.BitCast<int, Arm64LogicalImmediate64>(Arm64LogicalImmediateHelper.EncodeLogicalImmediate64(value));

    /// <inheritdoc/>
    public override string ToString() => ToString(null, null);

    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> dest = stackalloc char[32];
        TryFormat(dest, out var charsWritten, format.AsSpan(), formatProvider);
        return dest.Slice(0, charsWritten).ToString();
    }

    /// <inheritdoc/>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = null)
        => format.Length == 0 || format[0] == 'X' ? destination.TryWrite(provider, $"0x{EncodedValue:16X}", out charsWritten) : EncodedValue.TryFormat(destination, out charsWritten, format, provider);
}