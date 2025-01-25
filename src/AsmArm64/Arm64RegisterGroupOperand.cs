// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64RegisterGroupOperand : IArm64Operand
{
    internal Arm64RegisterGroupOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
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

    public Arm64OperandKind Kind => Arm64OperandKind.RegisterGroup;

    public Arm64RegisterGroupAny Value { get; }

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.Value.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(default, destination, out charsWritten,  out _, format, provider, null);

    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel)
    {
        isDefaultValue = false;
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }

    public static explicit operator Arm64RegisterGroupOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.RegisterGroup) ThrowInvalidCast(operand.Kind);
        return new Arm64RegisterGroupOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64RegisterGroupOperand)}");
}
