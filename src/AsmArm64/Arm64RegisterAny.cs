// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 register in a generic way.
/// </summary>
public readonly record struct Arm64RegisterAny : IArm64RegisterVPacked, IArm64RegisterVIndexed
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterAny(uint index) => _value = index;

    public static Arm64RegisterAny Create(Arm64RegisterKind kind, int index, Arm64RegisterVKind vKind, int elementCount, int elementIndex) => new(((uint)(byte)elementIndex << 28) | ((uint)((byte)elementCount >> 1) << 24) | ((uint)(byte)vKind << 16) | ((uint)(byte)kind << 8) | (byte)index);
    
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

    /// <summary>
    /// Gets whether this register is empty.
    /// </summary>
    public bool IsEmpty => _value == 0;

    public Arm64RegisterAny Next()
    {
        var index = (Index + 1) & 0b11111;
        var value = _value & 0xFFFF_FF00 | (uint)index;
        return new(value);
    }

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
            Arm64RegisterKind.C => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterC>(register).ToText(upper),
            Arm64RegisterKind.X => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterX>(register).ToText(upper),
            Arm64RegisterKind.W => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterW>(register).ToText(upper),
            Arm64RegisterKind.SP => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterSP>(register).ToText(upper),
            Arm64RegisterKind.V => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV>(register).ToText(upper),
            Arm64RegisterKind.VTyped => register.VKind switch
            {
                Arm64RegisterVKind.B => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_B>(register).ToText(upper),
                Arm64RegisterVKind.H => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_H>(register).ToText(upper),
                Arm64RegisterVKind.S => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_S>(register).ToText(upper),
                Arm64RegisterVKind.D => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_D>(register).ToText(upper),
                _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid VKind {register.VKind}")
            },
            Arm64RegisterKind.VScalar => register.VKind switch
            {
                Arm64RegisterVKind.H => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterH>(register).ToText(upper),
                Arm64RegisterVKind.S => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterS>(register).ToText(upper),
                Arm64RegisterVKind.D => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterD>(register).ToText(upper),
                Arm64RegisterVKind.Q => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterQ>(register).ToText(upper),
                _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid VKind {register.VKind}")
            },
            Arm64RegisterKind.VPacked => register.VKind switch
            {
                Arm64RegisterVKind.B => register.ElementCount switch
                {
                    2 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_2B>(register).ToText(upper),
                    4 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_4B>(register).ToText(upper),
                    8 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_8B>(register).ToText(upper),
                    16 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_16B>(register).ToText(upper),
                    _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid ElementCount {register.ElementCount}")
                },
                Arm64RegisterVKind.H => register.ElementCount switch
                {
                    2 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_2H>(register).ToText(upper),
                    4 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_4H>(register).ToText(upper),
                    8 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_8H>(register).ToText(upper),
                    _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid ElementCount {register.ElementCount}")
                },
                Arm64RegisterVKind.S => register.ElementCount switch
                {
                    2 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_2S>(register).ToText(upper),
                    4 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_4S>(register).ToText(upper),
                    _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid ElementCount {register.ElementCount}")
                },
                Arm64RegisterVKind.D => register.ElementCount switch
                {
                    2 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_2D>(register).ToText(upper),
                    _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid ElementCount {register.ElementCount}")
                },
                _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid VKind {register.VKind}")
            },
            Arm64RegisterKind.VPackedIndexed => register.VKind switch
            {
                Arm64RegisterVKind.B => register.ElementCount switch
                {
                    2 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_2B.Indexed>(register).ToString(upper ? "H" : "L", null),
                    4 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_4B.Indexed>(register).ToString(upper ? "H" : "L", null),
                    _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid ElementCount {register.ElementCount}")
                },
                Arm64RegisterVKind.H => register.ElementCount switch
                {
                    2 => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_2H.Indexed>(register).ToString(upper ? "H" : "L", null),
                    _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid ElementCount {register.ElementCount}")
                },
                _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid VKind {register.VKind}")
            },
            Arm64RegisterKind.VTypedIndexed => register.VKind switch
            {
                Arm64RegisterVKind.B => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_B.Indexed>(register).ToString(upper ? "H" : "L", null),
                Arm64RegisterVKind.H => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_H.Indexed>(register).ToString(upper ? "H" : "L", null),
                Arm64RegisterVKind.S => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_S.Indexed>(register).ToString(upper ? "H" : "L", null),
                Arm64RegisterVKind.D => Unsafe.BitCast<Arm64RegisterAny, Arm64RegisterV_D.Indexed>(register).ToString(upper ? "H" : "L", null),
                _ => throw new ArgumentOutOfRangeException(nameof(register), $"Invalid VKind {register.VKind}")
            },
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
