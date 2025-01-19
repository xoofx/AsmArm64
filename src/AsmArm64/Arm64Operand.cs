// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;

namespace AsmArm64;

public readonly struct Arm64Operand : IArm64Operand
{
    internal readonly ulong Descriptor;
    internal readonly Arm64RawInstruction RawValue;

    internal Arm64Operand(ulong descriptor, Arm64RawInstruction rawValue)
    {
        Descriptor = descriptor;
        RawValue = rawValue;
    }

    public Arm64OperandKind Kind => (Arm64OperandKind)(byte)(Descriptor & 0xF);

    public bool IsOptional => ((byte)Descriptor & 0x80) != 0;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[64];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(destination, out charsWritten, out _, format, provider);
    
    public bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        switch (Kind)
        {
            case Arm64OperandKind.Register:
                return ((Arm64RegisterOperand)this).TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);
            case Arm64OperandKind.Immediate:
                return ((Arm64ImmediateOperand)this).TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);
            case Arm64OperandKind.Shift:
                return ((Arm64ShiftOperand)this).TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);
            case Arm64OperandKind.Memory:
                return ((Arm64MemoryOperand)this).TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);
            case Arm64OperandKind.Extend:
                return ((Arm64ExtendOperand)this).TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);
            case Arm64OperandKind.RegisterGroup:
                return ((Arm64RegisterGroupOperand)this).TryFormat(destination, out charsWritten, out isDefaultValue, format, provider);

            case Arm64OperandKind.None:
            case Arm64OperandKind.Label:
            case Arm64OperandKind.Enum:
            case Arm64OperandKind.PStateField:
            case Arm64OperandKind.Const:
            default:
                throw new InvalidOperationException($"Unexpected kind {Kind}");
        }
    }


}