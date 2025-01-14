// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 register.
/// </summary>
public readonly record struct Arm64RegisterAny : IArm64Register
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterAny(uint index) => _value = index;

    public static Arm64RegisterAny Create(Arm64RegisterKind kind, int index) => new((uint) kind << 8 | (uint) index);

    public static Arm64RegisterAny Create(Arm64RegisterKind kind, Arm64RegisterVKind vKind, int elementCount, int index) => new( (uint)elementCount << 24 | (uint)vKind << 16 | (uint)kind << 8 | (uint)index);
    
    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind) (_value >> 8);

    /// <inheritdoc />
    public int Index => (byte) _value;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

partial class Arm64Extensions
{
    public static string ToText(this Arm64RegisterAny register, bool upper = false)
    {
        return register.Kind switch
        {
            Arm64RegisterKind.Invalid => "??",
            Arm64RegisterKind.X => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(register).ToText(upper),
            Arm64RegisterKind.W => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterW>(register).ToText(upper),
            Arm64RegisterKind.SP => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterSP>(register).ToText(upper),
            Arm64RegisterKind.V => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV>(register).ToText(upper),
            Arm64RegisterKind.VTyped => throw new NotImplementedException(),
            Arm64RegisterKind.VScalar => throw new NotImplementedException(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
