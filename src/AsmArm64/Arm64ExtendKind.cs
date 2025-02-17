// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 memory extend operation.
/// </summary>
public readonly record struct Arm64MemoryExtend : IArm64MemoryExtend 
{
    // 10 bits only are used (this is to fit within the Arm64Memory)
    // 4 bits for the amount
    // 5 bits for the kind
    // 1 bit for the HasExplicitZeroAmount
    private readonly ushort _value;

    private const int LowBitExtendKind = 5;
    private const int AmountMask = (1 << LowBitExtendKind) - 1;
    private const int ExtendKindSize = 4;
    private const int ExtendKindMask = (1 << ExtendKindSize) - 1;
    private const int LowBitHasExplicitZeroAmount = LowBitExtendKind + ExtendKindSize + 1;

    internal const ushort Mask = (1 << (LowBitHasExplicitZeroAmount + 1)) - 1;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64MemoryExtend"/> struct.
    /// </summary>
    /// <param name="kind">The kind of the extend operation.</param>
    /// <param name="amount">The amount of the extend operation.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the amount is greater than 4.</exception>
    public Arm64MemoryExtend(Arm64ExtendKind kind, byte amount)
    {
        if (amount > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be between 0 and 4");
        }
        _value = (ushort)(((ushort)kind << LowBitExtendKind) | ((ushort)amount));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64MemoryExtend"/> struct.
    /// </summary>
    /// <param name="kind">The kind of the extend operation.</param>
    /// <param name="hasExplicitZeroAmount">Indicates whether the extend operation has an explicit zero amount.</param>
    public Arm64MemoryExtend(Arm64ExtendKind kind, bool hasExplicitZeroAmount)
    {
        _value = (ushort)(((ushort)kind << LowBitExtendKind) | ((ushort)(hasExplicitZeroAmount ? ((ushort)1 << LowBitHasExplicitZeroAmount) : 0)));
    }

    /// <summary>
    /// Gets a value indicating whether the extend operation has an explicit zero amount.
    /// </summary>
    public bool HasExplicitZeroAmount => ((_value >> LowBitHasExplicitZeroAmount) & 1) != 0;
    
    /// <inheritdoc />
    public Arm64ExtendKind Kind => (Arm64ExtendKind)((_value >> LowBitExtendKind) & ExtendKindMask);

    /// <inheritdoc />
    public byte Amount => (byte)(_value & AmountMask);

    /// <summary>
    /// Gets a value indicating whether this instance is the default extend operation.
    /// </summary>
    public bool IsDefault => Amount == 0 && (Kind == Arm64ExtendKind.LSL || Kind == Arm64ExtendKind.UXTX);

    /// <summary>
    /// Returns a string representation of the extend operation.
    /// </summary>
    /// <returns>A string representation of the extend operation.</returns>
    public override string ToString() => ToString(null, null);

    /// <summary>
    /// Returns a string representation of the extend operation using the specified format and format provider.
    /// </summary>
    /// <param name="format">The format to use.</param>
    /// <param name="formatProvider">The format provider to use.</param>
    /// <returns>A string representation of the extend operation.</returns>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[16];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    /// <summary>
    /// Tries to format the value of the current instance into the provided span of characters.
    /// </summary>
    /// <param name="destination">The span of characters to write to.</param>
    /// <param name="charsWritten">When this method returns, contains the number of characters written to the destination span.</param>
    /// <param name="format">The format to use.</param>
    /// <param name="provider">The format provider to use.</param>
    /// <returns><c>true</c> if the formatting was successful; otherwise, <c>false</c>.</returns>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        var text = Kind.ToText(format.Length == 1 && format[0] == 'H');
        if (destination.Length < text.Length)
        {
            charsWritten = 0;
            return false;
        }
        text.AsSpan().CopyTo(destination);
        var written = text.Length;
        if (destination.Length <= written)
        {
            charsWritten = 0;
            return false;
        }

        if (Amount != 0 || Kind == Arm64ExtendKind.LSL || HasExplicitZeroAmount)
        {
            if (destination.Length <= written + 1)
            {
                charsWritten = 0;
                return false;
            }

            destination[written] = ' ';
            destination[written + 1] = '#';
            written += 2;
            if (!Amount.TryFormat(destination.Slice(written), out var digitWritten, "G", provider))
            {
                charsWritten = 0;
                return false;
            }

            written += digitWritten;
        }

        charsWritten = written;
        return true;
    }
}
