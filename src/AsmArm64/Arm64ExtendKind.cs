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

    public Arm64MemoryExtend(Arm64ExtendKind kind, byte amount)
    {
        if (amount > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be between 0 and 4");
        }
        _value = (ushort)(((ushort)kind << LowBitExtendKind) | ((ushort)amount));
    }

    public Arm64MemoryExtend(Arm64ExtendKind kind, bool hasExplicitZeroAmount)
    {
        _value = (ushort)(((ushort)kind << LowBitExtendKind) | ((ushort)(hasExplicitZeroAmount ? ((ushort)1 << LowBitHasExplicitZeroAmount) : 0)));
    }

    public bool HasExplicitZeroAmount => ((_value >> LowBitHasExplicitZeroAmount) & 1) != 0;
    
    /// <inheritdoc />
    public Arm64ExtendKind Kind => (Arm64ExtendKind)((_value >> LowBitExtendKind) & ExtendKindMask);

    /// <inheritdoc />
    public byte Amount => (byte)(_value & AmountMask);

    public bool IsDefault => Amount == 0 && (Kind == Arm64ExtendKind.LSL || Kind == Arm64ExtendKind.UXTX);

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[16];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

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
