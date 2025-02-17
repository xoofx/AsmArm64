// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a 64-bit shifted immediate value.
/// </summary>
public readonly record struct Arm64ShiftedImmediate64 : ISpanFormattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ShiftedImmediate64"/> struct.
    /// </summary>
    /// <param name="value">The immediate value.</param>
    /// <param name="shift">The shift amount. Must be 0, 16, 32, or 48.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the shift value is not 0, 16, 32, or 48.</exception>
    public Arm64ShiftedImmediate64(ushort value, int shift)
    {
        if (shift != 0 && shift != 16 && shift != 32 && shift != 48) throw new ArgumentOutOfRangeException(nameof(shift), shift, "Invalid shifted immediate value. Should be a shift-able to 0, 16, 32 or 48.");

        EncodedValue = (value << 2) | (shift >> 4);
    }

    /// <summary>
    /// Gets the encoded value of the shifted immediate.
    /// </summary>
    public int EncodedValue { get; }

    /// <summary>
    /// Gets the immediate value by decoding the encoded value.
    /// </summary>
    public int Immediate => EncodedValue >> 2;

    /// <summary>
    /// Gets the shift left amount by decoding the encoded value.
    /// </summary>
    public int ShiftLeft => (EncodedValue & 3) << 4;

    /// <summary>
    /// Gets the final value after applying the shift.
    /// </summary>
    /// <returns>The shifted immediate value.</returns>
    public long Value() => (long)Immediate << ShiftLeft;

    /// <inheritdoc/>
    public override string ToString() => ToString(null, null);

    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
        => Value().ToString(format, formatProvider);

    /// <inheritdoc/>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => Value().TryFormat(destination, out charsWritten, format, provider);
}

partial class Arm64Factory
{
    /// <summary>
    /// Creates a 32-bit shifted immediate value.
    /// </summary>
    /// <param name="value">The value to shift.</param>
    /// <param name="shift">The shift amount.</param>
    public static Arm64ShiftedImmediate32 Shift32(ushort value, int shift) => new(value, shift);

    /// <summary>
    /// Creates a 64-bit shifted immediate value.
    /// </summary>
    /// <param name="value">The value to shift.</param>
    /// <param name="shift">The shift amount.</param>
    public static Arm64ShiftedImmediate64 Shift64(ushort value, int shift) => new(value, shift);

    /// <summary>
    /// Creates a 32-bit inverted shifted immediate value.
    /// </summary>
    /// <param name="value">The value to shift.</param>
    /// <param name="shift">The shift amount.</param>
    public static Arm64InvertedShiftedImmediate32 InvertShift32(ushort value, int shift) => new(value, shift);

    /// <summary>
    /// Creates a 64-bit inverted shifted immediate value.
    /// </summary>
    /// <param name="value">The value to shift.</param>
    /// <param name="shift">The shift amount.</param>
    public static Arm64InvertedShiftedImmediate64 InvertShift64(ushort value, int shift) => new(value, shift);
}