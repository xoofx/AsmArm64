// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64RegisterOperand : IArm64Operand, ISpanFormattable
{
    internal Arm64RegisterOperand(Arm64Operand operand)
    {
        // buffer[1] = (byte)((byte)RegisterKind | ((byte)RegisterIndexEncodingKind << 4));
        // buffer[2] = (byte)IndexerId;
        // buffer[3] = (byte)LowBitIndexEncoding;
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;
        var encodingKind = (Arm64RegisterEncodingKind)((byte)(descriptor >> 8) & 0xF);
        var indexerId = (byte)(descriptor >> 16);
        var bitIndex = (byte)(descriptor >> 24);

        var value = rawValue >> bitIndex;
        var encodingIndex = (Arm64RegisterIndexEncodingKind)((byte)(descriptor >> 12) & 0xF); ;
        int registerIndex = (int)(
            encodingIndex == Arm64RegisterIndexEncodingKind.Std5
                ? value & 0b11111
                : encodingIndex == Arm64RegisterIndexEncodingKind.Std4
                    ? value & 0b1111
                    : throw new NotImplementedException());

        Arm64RegisterKind registerKind;
        Arm64RegisterVKind vKind = Arm64RegisterVKind.Default;
        switch (encodingKind)
        {
            case Arm64RegisterEncodingKind.X:
                registerKind = Arm64RegisterKind.X;
                break;
            case Arm64RegisterEncodingKind.XOrSP:
                registerKind = registerIndex == 31 ? Arm64RegisterKind.SP : Arm64RegisterKind.X;
                break;
            case Arm64RegisterEncodingKind.W:
            case Arm64RegisterEncodingKind.WOrWSP:
                registerKind = registerIndex == 31 ? Arm64RegisterKind.SP : Arm64RegisterKind.W;
                break;
            case Arm64RegisterEncodingKind.B:
                registerKind = Arm64RegisterKind.VScalar;
                vKind = Arm64RegisterVKind.B;
                break;
            case Arm64RegisterEncodingKind.H:
                registerKind = Arm64RegisterKind.VScalar;
                vKind = Arm64RegisterVKind.H;
                break;
            case Arm64RegisterEncodingKind.S:
                registerKind = Arm64RegisterKind.VScalar;
                vKind = Arm64RegisterVKind.S;
                break;
            case Arm64RegisterEncodingKind.D:
                registerKind = Arm64RegisterKind.VScalar;
                vKind = Arm64RegisterVKind.D;
                break;
            case Arm64RegisterEncodingKind.Q:
                registerKind = Arm64RegisterKind.VScalar;
                vKind = Arm64RegisterVKind.Q;
                break;
            case Arm64RegisterEncodingKind.V:
                registerKind = Arm64RegisterKind.V;
                var vectorArrangementIndex = (byte)(descriptor >> 32);
                break;
            case Arm64RegisterEncodingKind.DynamicXOrW:
            {
                registerKind = Arm64RegisterKind.X; // TODO
                var dynamicSelectorIndex = (byte)(descriptor >> 32);
                break;
            }
            case Arm64RegisterEncodingKind.DynamicVScalar:
            {
                registerKind = Arm64RegisterKind.V; // TODO
                var dynamicSelectorIndex = (byte)(descriptor >> 32);
                break;
            }
            case Arm64RegisterEncodingKind.Z:
            case Arm64RegisterEncodingKind.C:
                registerKind = Arm64RegisterKind.C;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        Value = Arm64RegisterAny.Create(registerKind, vKind, registerIndex);
    }

    public Arm64OperandKind Kind => Arm64OperandKind.Register;
    
    public Arm64RegisterAny Value { get; }

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.Value.ToString(format, formatProvider);

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
    {
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }

    public static explicit operator Arm64RegisterOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Register) ThrowInvalidCast(operand.Kind);
        return new Arm64RegisterOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64RegisterOperand)}");
}