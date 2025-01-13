// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

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

    public Arm64OperandKind Kind => (Arm64OperandKind)(byte)Descriptor;

    ///// <inheritdoc />
    //public override string ToString() => ToString(null, null);

    ///// <inheritdoc />
    //public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    ///// <inheritdoc />
    //public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
    //    IFormatProvider? provider)
    //{
    //    if (format.Length != 1) format = "L";
    //    var text = this.ToText(format[0] == 'H');
    //    var result = text.AsSpan().TryCopyTo(destination);
    //    charsWritten = result ? text.Length : 0;
    //    return result;
    //}
}