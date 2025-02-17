// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a 32-bit inverted shifted immediate value.
/// </summary>
public readonly record struct Arm64InvertedShiftedImmediate32 : ISpanFormattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64InvertedShiftedImmediate32"/> struct.
    /// </summary>
    /// <param name="value">The immediate value.</param>
    /// <param name="shift">The shift value, which must be either 0 or 16.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the value is 0xFFFF or the shift is not 0 or 16.
    /// </exception>
    public Arm64InvertedShiftedImmediate32(ushort value, int shift)
    {
        if (value == 0xFFFF) throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid shifted immediate value. The value `0xFFFF` is not supported for 32 bit.");
        if (shift != 0 && shift != 16) throw new ArgumentOutOfRangeException(nameof(shift), shift, "Invalid shifted immediate value. Should be a shift-able to 0 or 16.");

        EncodedValue = (value << 2) | (shift >> 4);
    }

    /// <summary>
    /// Gets the encoded value.
    /// </summary>
    public int EncodedValue { get; }

    /// <summary>
    /// Gets the immediate value.
    /// </summary>
    public int Immediate => EncodedValue >> 2;

    /// <summary>
    /// Gets the shift left value.
    /// </summary>
    public int ShiftLeft => (EncodedValue & 3) << 4;

    /// <summary>
    /// Gets the inverted shifted immediate value.
    /// </summary>
    /// <returns>The inverted shifted immediate value.</returns>
    public int Value() => ~(Immediate << ShiftLeft);

    /// <inheritdoc/>
    public override string ToString() => ToString(null, null);

    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
        => Value().ToString(format, formatProvider);

    /// <inheritdoc/>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => Value().TryFormat(destination, out charsWritten, format, provider);
}