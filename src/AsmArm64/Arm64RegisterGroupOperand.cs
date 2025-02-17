// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 register group operand.
/// </summary>
public readonly struct Arm64RegisterGroupOperand : IArm64Operand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64RegisterGroupOperand"/> struct.
    /// </summary>
    /// <param name="operand">The operand.</param>
    internal Arm64RegisterGroupOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        Flags = operand.Flags;
        var rawValue = operand.RawValue;

        // Debug.Assert(Count >= 1 && Count <= 4);
        // buffer[1] = (byte)Count;
        // buffer[2] = (byte)IndexerIndex;
        // // Register.EncodeImpl starts to encode at offset 1, so we need to skip the first byte
        // Register.EncodeImpl(buffer.Slice(2));
        var count = (byte)(descriptor >> 8);
        var indexerIndex = (byte)(descriptor >> 16);

        var fakeRegisterOperand = new Arm64RegisterOperand(new(descriptor >> 16, rawValue));
        var register = fakeRegisterOperand.Value;

        if (indexerIndex != 0)
        {
            Arm64IndexerHelper.TryDecode(rawValue, indexerIndex, out var index);
            Value = Arm64RegisterGroupAny.CreateWithIndexer(register, count, index);
        }
        else
        {
            Value = Arm64RegisterGroupAny.Create(register, count);
        }
    }

    /// <summary>
    /// Gets the kind of the operand.
    /// </summary>
    public Arm64OperandKind Kind => Arm64OperandKind.RegisterGroup;

    /// <summary>
    /// Gets the flags of the operand.
    /// </summary>
    public Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Gets the value of the register group.
    /// </summary>
    public Arm64RegisterGroupAny Value { get; }

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.Value.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    /// <inheritdoc />
    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel)
    {
        isDefaultValue = false;
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }

    /// <summary>
    /// Explicitly converts an <see cref="Arm64Operand"/> to an <see cref="Arm64RegisterGroupOperand"/>.
    /// </summary>
    /// <param name="operand">The operand to convert.</param>
    /// <returns>The converted register group operand.</returns>
    /// <exception cref="InvalidCastException">Thrown when the operand kind is not a register group.</exception>
    public static explicit operator Arm64RegisterGroupOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.RegisterGroup) ThrowInvalidCast(operand.Kind);
        return new Arm64RegisterGroupOperand(operand);
    }

    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64RegisterGroupOperand)}");
}
