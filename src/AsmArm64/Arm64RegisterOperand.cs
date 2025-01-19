// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64RegisterOperand : IArm64Operand
{
    internal Arm64RegisterOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        var rawValue = operand.RawValue;
        // buffer[1] = (byte)((byte)RegisterKind | ((byte)RegisterIndexEncodingKind << 4));
        var encodingKind = (Arm64RegisterEncodingKind)((byte)(descriptor >> 8) & 0xF);
        var encodingIndex = (Arm64RegisterIndexEncodingKind)((byte)(descriptor >> 12) & 0xF); ;
        // buffer[2] = (byte)IndexerIndex;
        var elementIndexerId = (byte)(descriptor >> 16);
        // if (RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.BitMapExtract)
        // {
        //     Debug.Assert(RegisterIndexExtractIndex != 0);
        //     buffer[3] = (byte)RegisterIndexExtractIndex;
        // }
        // else if (RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Fixed)
        // {
        //     buffer[3] = (byte)FixedRegisterIndex;
        // }
        // else
        // {
        //     buffer[3] = (byte)LowBitIndexEncoding;
        // }
        int registerIndex;
        switch (encodingIndex)
        {
            case Arm64RegisterIndexEncodingKind.Std5:
            {
                var bitIndex = (byte)(descriptor >> 24);
                var value = rawValue >> bitIndex;
                registerIndex = (int)(value & 0b11111);
                break;
            }
            case Arm64RegisterIndexEncodingKind.Std4:
            {
                var bitIndex = (byte)(descriptor >> 24);
                var value = rawValue >> bitIndex;
                registerIndex = (int)(value & 0b1111);
                break;
            }
            case Arm64RegisterIndexEncodingKind.BitMapExtract:
            {
                Arm64RegisterIndexHelper.TryDecode(rawValue, (byte)(descriptor >> 24), out registerIndex);
                break;
            }
            case Arm64RegisterIndexEncodingKind.Fixed:
                registerIndex = (byte)(descriptor >> 24);
                break;
            default:
                encodingKind = Arm64RegisterEncodingKind.None;
                registerIndex = 0;
                break;
        }

        // Register kind
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
                // if (RegisterKind == Arm64RegisterEncodingKind.V)
                // {
                //     buffer[4] = (byte)VectorArrangementIndex;
                //     Debug.Assert(DynamicRegisterSelectorIndex == 0);
                // }
                var vectorArrangementIndex = (byte)(descriptor >> 32);
                if (vectorArrangementIndex != 0)
                {
                    if (!Arm64VectorArrangementHelper.TryDecode(rawValue, vectorArrangementIndex, out vKind, out elementCount))
                    {
                        registerKind = Arm64RegisterKind.Invalid;
                    }
                    else
                    {
                        registerKind = elementCount == 0 ? Arm64RegisterKind.VTyped : Arm64RegisterKind.VPacked;
                    }
                }
                break;
            case Arm64RegisterEncodingKind.DynamicXOrW:
            case Arm64RegisterEncodingKind.DynamicVScalar:
            {
                // else if (RegisterKind == Arm64RegisterEncodingKind.DynamicXOrW || RegisterKind == Arm64RegisterEncodingKind.DynamicVScalar)
                // {
                //     buffer[4] = (byte)DynamicRegisterSelectorIndex;
                //     Debug.Assert(VectorArrangementIndex == 0);
                // }
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

        // We can decode the indexer
        Arm64IndexerHelper.TryDecode(rawValue, elementIndexerId, out var elementIndex);

        // Create an any register that we can cast later.
        Value = Arm64RegisterAny.Create(registerKind, registerIndex, vKind, elementCount, elementIndex);
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
        => TryFormat(destination, out charsWritten, out _, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel = null)
    {
        isDefaultValue = false;
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