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
        int registerIndex;
        switch (encodingIndex)
        {
            case Arm64RegisterIndexEncodingKind.Std5:
                registerIndex = (int)(value & 0b11111);
                break;
            case Arm64RegisterIndexEncodingKind.Std4:
                registerIndex = (int)(value & 0b1111);
                break;
            case Arm64RegisterIndexEncodingKind.SpecialMRm:
            {
                // Special size:M:Rm encoding
                // size:(22:2),M:(20:1),Rm:(16:4)
                // With Size:
                // * BitFields = 00, Value = RESERVED
                // * BitFields = 01, Value = UInt('0':Rm)
                // * BitFields = 10, Value = UInt(M:Rm)
                // * BitFields = 11, Value = RESERVED
                var size = (rawValue >> 22) & 0b11;
                switch (size)
                {
                    case 1:
                        registerIndex = (int)((rawValue >> 16) & 0b1111);
                        break;
                    case 2:
                        registerIndex = (int)((rawValue >> 16) & 0b11111);
                        break;
                    default:
                        encodingKind = Arm64RegisterEncodingKind.None;
                        registerIndex = 0;
                        break;
                }
            }
                break;
            default:
                encodingKind = Arm64RegisterEncodingKind.None;
                registerIndex = 0;
                break;
        }

        Arm64RegisterKind registerKind;
        Arm64RegisterVKind vKind = Arm64RegisterVKind.Default;
        int elementCount = 0;
        encodedDynamic:
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
                // buffer[4] = (byte)VectorArrangementLocalIndex;
                var vectorArrangementIndex = (byte)(descriptor >> 32);
                if (vectorArrangementIndex != 0)
                {
                    if (!Arm64VectorArrangementHelper.TryDecode(rawValue, vectorArrangementIndex, out vKind, out elementCount))
                    {
                        registerKind = Arm64RegisterKind.Invalid;
                    }
                    else
                    {
                        registerKind = elementCount == 0 ? Arm64RegisterKind.VTypedScalar : Arm64RegisterKind.VTyped;
                    }
                }
                break;
            case Arm64RegisterEncodingKind.DynamicXOrW:
            case Arm64RegisterEncodingKind.DynamicVScalar:
            {
                var dynamicSelectorIndex = (byte)(descriptor >> 32);
                Arm64DynamicRegisterHelper.TryDecode(rawValue, dynamicSelectorIndex, out encodingKind);
                goto encodedDynamic;
            }
            case Arm64RegisterEncodingKind.C:
                registerKind = Arm64RegisterKind.C;
                break;
            case Arm64RegisterEncodingKind.Z: // TODO: SVE / SVE2
            default:
                registerKind = Arm64RegisterKind.Invalid;
                break;
        }

        Value = Arm64RegisterAny.Create(registerKind, vKind, elementCount, registerIndex);
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