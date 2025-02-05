// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a label, a relative offset from the current instruction.
/// </summary>
/// <param name="Value">A relative offset to the current instruction</param>
public record struct Arm64LabelOffset(int Value) : ISpanFormattable
{
    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        FormattableString formattable = $"{nameof(Value)}: {Value}";
        return formattable.ToString(formatProvider);
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => destination.TryWrite(provider, $"#{Value}", out charsWritten);

    /// <inheritdoc />
    public readonly override string ToString() => $"#{Value}";

    /// <summary>
    /// Converts an offset to a label.
    /// </summary>
    /// <param name="offset">An offset</param>
    public static implicit operator Arm64LabelOffset(int offset) => new(offset);
}