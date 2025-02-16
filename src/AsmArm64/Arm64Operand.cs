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

    public bool IsOptional => (Flags & Arm64OperandFlags.Optional) != 0;

    public Arm64OperandFlags Flags => (Arm64OperandFlags)((byte)Descriptor >> 4);

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
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);
    
    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel)
    {
        switch (Kind)
        {
            case Arm64OperandKind.Register:
                return ((Arm64RegisterOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.SystemRegister:
                return ((Arm64SystemRegisterOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.Immediate:
                return ((Arm64ImmediateOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.Shift:
                return ((Arm64ShiftOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.Memory:
                return ((Arm64MemoryOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.Extend:
                return ((Arm64ExtendOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.RegisterGroup:
                return ((Arm64RegisterGroupOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.Label:
                return ((Arm64LabelOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            case Arm64OperandKind.Enum:
                return ((Arm64EnumOperand)this).TryFormat(instruction, destination, out charsWritten, out isDefaultValue, format, provider, tryFormatLabel);
            default:
                throw new InvalidOperationException($"Unexpected kind {Kind}");
        }
    }
}