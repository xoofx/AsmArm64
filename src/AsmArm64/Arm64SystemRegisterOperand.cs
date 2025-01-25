// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64SystemRegisterOperand : IArm64Operand
{
    internal Arm64SystemRegisterOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;

        // We don't need to encode the position, as it is always BitRange(5, 16)
        // buffer[1] = SystemRegisterKindIndex;

        var rawKindIndex = (byte)(descriptor >> 8);
        Arm64SystemRegisterKind systemRegisterKind = rawKindIndex > 0 ? (Arm64SystemRegisterKind)(1 << (rawKindIndex - 1)) : Arm64SystemRegisterKind.Unknown;
        RegisterKind = systemRegisterKind;
        
        var registerValue = (ushort)(rawValue >> 5);
        var register = new Arm64SystemRegister(registerValue);
        if (register.Id == Arm64SystemRegisterKnownId.DBGDTRRX_EL0 && (systemRegisterKind & Arm64SystemRegisterKind.MSR) != 0)
        {
            register = new Arm64SystemRegister(Arm64SystemRegisterKnownId.DBGDTRTX_EL0, register.Value, Arm64SystemRegisterKind.MSR);
        }

        // Create an any register that we can cast later.
        Value = register;
    }

    public Arm64OperandKind Kind => Arm64OperandKind.SystemRegister;

    public Arm64SystemRegisterKind RegisterKind { get; }

    public Arm64SystemRegister Value { get; }

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.Value.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel)
    {
        isDefaultValue = false;
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }

    public static explicit operator Arm64SystemRegisterOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.SystemRegister) ThrowInvalidCast(operand.Kind);
        return new Arm64SystemRegisterOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64SystemRegisterOperand)}");
}