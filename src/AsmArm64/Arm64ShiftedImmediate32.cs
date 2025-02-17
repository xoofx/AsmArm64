// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a 32-bit shifted immediate value.
/// </summary>
public readonly record struct Arm64ShiftedImmediate32 : ISpanFormattable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ShiftedImmediate32"/> struct.
    /// </summary>
    /// <param name="value">The immediate value.</param>
    /// <param name="shift">The shift amount, which must be either 0 or 16.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the shift value is not 0 or 16.</exception>
    public Arm64ShiftedImmediate32(ushort value, int shift)
    {
        if (shift != 0 && shift != 16) throw new ArgumentOutOfRangeException(nameof(shift), shift, "Invalid shifted immediate value. Should be a shift-able to 0, 16.");
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
    public int Value() => (int)Immediate << ShiftLeft;

    /// <inheritdoc/>
    public override string ToString() => ToString(null, null);

    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
        => Value().ToString(format, formatProvider);

    /// <inheritdoc/>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => Value().TryFormat(destination, out charsWritten, format, provider);
}