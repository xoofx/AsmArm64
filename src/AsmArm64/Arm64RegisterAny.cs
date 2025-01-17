// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 register.
/// </summary>
public readonly record struct Arm64RegisterAny : IArm64RegisterVPacked, IArm64RegisterVIndexed
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterAny(uint index) => _value = index;

    public static Arm64RegisterAny Create(Arm64RegisterKind kind, int index, Arm64RegisterVKind vKind, int elementCount, int elementIndex) => new(((uint)elementIndex << 28) | ((uint)(elementCount >> 1) << 24) | ((uint)vKind << 16) | ((uint)vKind << 8) | (uint)index);
    
    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind) (_value >> 8);

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int Index => (byte) _value;

    /// <inheritdoc />
    public int ElementCount => (byte)(((_value >> 24) & 0xF) << 1);

    /// <inheritdoc />
    public int ElementIndex => (byte)(_value >> 28);

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
            Arm64RegisterKind.C => throw new NotImplementedException(),
            Arm64RegisterKind.VPacked => throw new NotImplementedException(),
            Arm64RegisterKind.VPackedIndexed => throw new NotImplementedException(),
            Arm64RegisterKind.VTypedIndexed => throw new NotImplementedException(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
