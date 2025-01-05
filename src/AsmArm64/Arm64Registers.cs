// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the kind of register.
/// </summary>
public enum Arm64RegisterKind : byte
{
    /// <summary>
    /// Invalid register kind.
    /// </summary>
    Invalid = 0,
    /// <summary>
    /// 64-bit general-purpose register.
    /// </summary>
    X,
    /// <summary>
    /// 32-bit general-purpose register.
    /// </summary>
    W,
    /// <summary>
    /// Stack pointer register.
    /// </summary>
    SP,
    /// <summary>
    /// Vector register.
    /// </summary>
    V,
    /// <summary>
    /// Vector Typed register (Vn.8B, Vn.16B, Vn.4H, Vn.8H, Vn.2S, Vn.4S, Vn.2D).
    /// </summary>
    VTyped,
    /// <summary>
    /// Vector Scalar element (e.g. H0 / S0 / D0).
    /// </summary>
    VScalar,
}

/// <summary>
/// Defines the kind of vector typed register (e.g. Vn.8B).
/// </summary>
public enum Arm64RegisterVKind : byte
{
    /// <summary>
    /// The full vector register.
    /// </summary>
    Full = 0,
    /// <summary>
    /// 8-bit vector register.
    /// </summary>
    B,
    /// <summary>
    /// Half-precision 16-bit floating-point register.
    /// </summary>
    H,
    /// <summary>
    /// Single-precision 32-bit floating-point register.
    /// </summary>
    S,
    /// <summary>
    /// Double-precision 64-bit floating-point register.
    /// </summary>
    D,
}

/// <summary>
/// Represents an ARM64 X 64-bit general-purpose register.
/// </summary>
public readonly record struct Arm64RegisterX : IArm64Register
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterX(int index) => _value = (uint)Arm64RegisterKind.X << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the X0 register.
    /// </summary>
    public static Arm64RegisterX X0 => new(0);

    /// <summary>
    /// Gets the X1 register.
    /// </summary>
    public static Arm64RegisterX X1 => new(1);

    /// <summary>
    /// Gets the X2 register.
    /// </summary>
    public static Arm64RegisterX X2 => new(2);

    /// <summary>
    /// Gets the X3 register.
    /// </summary>
    public static Arm64RegisterX X3 => new(3);

    /// <summary>
    /// Gets the X4 register.
    /// </summary>
    public static Arm64RegisterX X4 => new(4);

    /// <summary>
    /// Gets the X5 register.
    /// </summary>
    public static Arm64RegisterX X5 => new(5);

    /// <summary>
    /// Gets the X6 register.
    /// </summary>
    public static Arm64RegisterX X6 => new(6);

    /// <summary>
    /// Gets the X7 register.
    /// </summary>
    public static Arm64RegisterX X7 => new(7);

    /// <summary>
    /// Gets the X8 register.
    /// </summary>
    public static Arm64RegisterX X8 => new(8);

    /// <summary>
    /// Gets the X9 register.
    /// </summary>
    public static Arm64RegisterX X9 => new(9);

    /// <summary>
    /// Gets the X10 register.
    /// </summary>
    public static Arm64RegisterX X10 => new(10);

    /// <summary>
    /// Gets the X11 register.
    /// </summary>
    public static Arm64RegisterX X11 => new(11);

    /// <summary>
    /// Gets the X12 register.
    /// </summary>
    public static Arm64RegisterX X12 => new(12);

    /// <summary>
    /// Gets the X13 register.
    /// </summary>
    public static Arm64RegisterX X13 => new(13);

    /// <summary>
    /// Gets the X14 register.
    /// </summary>
    public static Arm64RegisterX X14 => new(14);

    /// <summary>
    /// Gets the X15 register.
    /// </summary>
    public static Arm64RegisterX X15 => new(15);

    /// <summary>
    /// Gets the X16 register.
    /// </summary>
    public static Arm64RegisterX X16 => new(16);

    /// <summary>
    /// Gets the X17 register.
    /// </summary>
    public static Arm64RegisterX X17 => new(17);

    /// <summary>
    /// Gets the X18 register.
    /// </summary>
    public static Arm64RegisterX X18 => new(18);

    /// <summary>
    /// Gets the X19 register.
    /// </summary>
    public static Arm64RegisterX X19 => new(19);

    /// <summary>
    /// Gets the X20 register.
    /// </summary>
    public static Arm64RegisterX X20 => new(20);

    /// <summary>
    /// Gets the X21 register.
    /// </summary>
    public static Arm64RegisterX X21 => new(21);

    /// <summary>
    /// Gets the X22 register.
    /// </summary>
    public static Arm64RegisterX X22 => new(22);

    /// <summary>
    /// Gets the X23 register.
    /// </summary>
    public static Arm64RegisterX X23 => new(23);

    /// <summary>
    /// Gets the X24 register.
    /// </summary>
    public static Arm64RegisterX X24 => new(24);

    /// <summary>
    /// Gets the X25 register.
    /// </summary>
    public static Arm64RegisterX X25 => new(25);

    /// <summary>
    /// Gets the X26 register.
    /// </summary>
    public static Arm64RegisterX X26 => new(26);

    /// <summary>
    /// Gets the X27 register.
    /// </summary>
    public static Arm64RegisterX X27 => new(27);

    /// <summary>
    /// Gets the X28 register.
    /// </summary>
    public static Arm64RegisterX X28 => new(28);

    /// <summary>
    /// Gets the X29 register.
    /// </summary>
    public static Arm64RegisterX X29 => new(29);

    /// <summary>
    /// Gets the X30 register.
    /// </summary>
    public static Arm64RegisterX X30 => new(30);

    /// <summary>
    /// Gets the XZR register.
    /// </summary>
    public static Arm64RegisterX XZR => new(31);
}

/// <summary>
/// Represents an ARM64 W 32-bit general-purpose register.
/// </summary>
public readonly record struct Arm64RegisterW : IArm64Register
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterW(int index) => _value = (uint)Arm64RegisterKind.W << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the W0 register.
    /// </summary>
    public static Arm64RegisterW W0 => new(0);

    /// <summary>
    /// Gets the W1 register.
    /// </summary>
    public static Arm64RegisterW W1 => new(1);

    /// <summary>
    /// Gets the W2 register.
    /// </summary>
    public static Arm64RegisterW W2 => new(2);

    /// <summary>
    /// Gets the W3 register.
    /// </summary>
    public static Arm64RegisterW W3 => new(3);

    /// <summary>
    /// Gets the W4 register.
    /// </summary>
    public static Arm64RegisterW W4 => new(4);

    /// <summary>
    /// Gets the W5 register.
    /// </summary>
    public static Arm64RegisterW W5 => new(5);

    /// <summary>
    /// Gets the W6 register.
    /// </summary>
    public static Arm64RegisterW W6 => new(6);

    /// <summary>
    /// Gets the W7 register.
    /// </summary>
    public static Arm64RegisterW W7 => new(7);

    /// <summary>
    /// Gets the W8 register.
    /// </summary>
    public static Arm64RegisterW W8 => new(8);

    /// <summary>
    /// Gets the W9 register.
    /// </summary>
    public static Arm64RegisterW W9 => new(9);

    /// <summary>
    /// Gets the W10 register.
    /// </summary>
    public static Arm64RegisterW W10 => new(10);

    /// <summary>
    /// Gets the W11 register.
    /// </summary>
    public static Arm64RegisterW W11 => new(11);

    /// <summary>
    /// Gets the W12 register.
    /// </summary>
    public static Arm64RegisterW W12 => new(12);

    /// <summary>
    /// Gets the W13 register.
    /// </summary>
    public static Arm64RegisterW W13 => new(13);

    /// <summary>
    /// Gets the W14 register.
    /// </summary>
    public static Arm64RegisterW W14 => new(14);

    /// <summary>
    /// Gets the W15 register.
    /// </summary>
    public static Arm64RegisterW W15 => new(15);

    /// <summary>
    /// Gets the W16 register.
    /// </summary>
    public static Arm64RegisterW W16 => new(16);

    /// <summary>
    /// Gets the W17 register.
    /// </summary>
    public static Arm64RegisterW W17 => new(17);

    /// <summary>
    /// Gets the W18 register.
    /// </summary>
    public static Arm64RegisterW W18 => new(18);

    /// <summary>
    /// Gets the W19 register.
    /// </summary>
    public static Arm64RegisterW W19 => new(19);

    /// <summary>
    /// Gets the W20 register.
    /// </summary>
    public static Arm64RegisterW W20 => new(20);

    /// <summary>
    /// Gets the W21 register.
    /// </summary>
    public static Arm64RegisterW W21 => new(21);

    /// <summary>
    /// Gets the W22 register.
    /// </summary>
    public static Arm64RegisterW W22 => new(22);

    /// <summary>
    /// Gets the W23 register.
    /// </summary>
    public static Arm64RegisterW W23 => new(23);

    /// <summary>
    /// Gets the W24 register.
    /// </summary>
    public static Arm64RegisterW W24 => new(24);

    /// <summary>
    /// Gets the W25 register.
    /// </summary>
    public static Arm64RegisterW W25 => new(25);

    /// <summary>
    /// Gets the W26 register.
    /// </summary>
    public static Arm64RegisterW W26 => new(26);

    /// <summary>
    /// Gets the W27 register.
    /// </summary>
    public static Arm64RegisterW W27 => new(27);

    /// <summary>
    /// Gets the W28 register.
    /// </summary>
    public static Arm64RegisterW W28 => new(28);

    /// <summary>
    /// Gets the W29 register.
    /// </summary>
    public static Arm64RegisterW W29 => new(29);

    /// <summary>
    /// Gets the W30 register.
    /// </summary>
    public static Arm64RegisterW W30 => new(30);

    /// <summary>
    /// Gets the WZR register.
    /// </summary>
    public static Arm64RegisterW WZR => new(31);
}

/// <summary>
/// Represents an ARM64 SP Stack pointer register.
/// </summary>
public readonly record struct Arm64RegisterSP : IArm64Register
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterSP(int index) => _value = (uint)Arm64RegisterKind.SP << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the SP register.
    /// </summary>
    public static Arm64RegisterSP SP => new(31);
}

/// <summary>
/// Represents an ARM64 V Vector register.
/// </summary>
public readonly record struct Arm64RegisterV : IArm64RegisterV
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64RegisterV(int index) => _value = (uint)Arm64RegisterKind.V << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => Arm64RegisterVKind.Full;

    /// <summary>
    /// Gets the 8 x B V register.
    /// </summary>
    public Arm64RegisterV8B T8B => new(Index);

    /// <summary>
    /// Gets the 16 x B V register.
    /// </summary>
    public Arm64RegisterV16B T16B => new(Index);

    /// <summary>
    /// Gets the 4 x H V register.
    /// </summary>
    public Arm64RegisterV4H T4H => new(Index);

    /// <summary>
    /// Gets the 8 x H V register.
    /// </summary>
    public Arm64RegisterV8H T8H => new(Index);

    /// <summary>
    /// Gets the 2 x S V register.
    /// </summary>
    public Arm64RegisterV2S T2S => new(Index);

    /// <summary>
    /// Gets the 4 x S V register.
    /// </summary>
    public Arm64RegisterV4S T4S => new(Index);

    /// <summary>
    /// Gets the 2 x D V register.
    /// </summary>
    public Arm64RegisterV2D T2D => new(Index);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the V0 register.
    /// </summary>
    public static Arm64RegisterV V0 => new(0);

    /// <summary>
    /// Gets the V1 register.
    /// </summary>
    public static Arm64RegisterV V1 => new(1);

    /// <summary>
    /// Gets the V2 register.
    /// </summary>
    public static Arm64RegisterV V2 => new(2);

    /// <summary>
    /// Gets the V3 register.
    /// </summary>
    public static Arm64RegisterV V3 => new(3);

    /// <summary>
    /// Gets the V4 register.
    /// </summary>
    public static Arm64RegisterV V4 => new(4);

    /// <summary>
    /// Gets the V5 register.
    /// </summary>
    public static Arm64RegisterV V5 => new(5);

    /// <summary>
    /// Gets the V6 register.
    /// </summary>
    public static Arm64RegisterV V6 => new(6);

    /// <summary>
    /// Gets the V7 register.
    /// </summary>
    public static Arm64RegisterV V7 => new(7);

    /// <summary>
    /// Gets the V8 register.
    /// </summary>
    public static Arm64RegisterV V8 => new(8);

    /// <summary>
    /// Gets the V9 register.
    /// </summary>
    public static Arm64RegisterV V9 => new(9);

    /// <summary>
    /// Gets the V10 register.
    /// </summary>
    public static Arm64RegisterV V10 => new(10);

    /// <summary>
    /// Gets the V11 register.
    /// </summary>
    public static Arm64RegisterV V11 => new(11);

    /// <summary>
    /// Gets the V12 register.
    /// </summary>
    public static Arm64RegisterV V12 => new(12);

    /// <summary>
    /// Gets the V13 register.
    /// </summary>
    public static Arm64RegisterV V13 => new(13);

    /// <summary>
    /// Gets the V14 register.
    /// </summary>
    public static Arm64RegisterV V14 => new(14);

    /// <summary>
    /// Gets the V15 register.
    /// </summary>
    public static Arm64RegisterV V15 => new(15);

    /// <summary>
    /// Gets the V16 register.
    /// </summary>
    public static Arm64RegisterV V16 => new(16);

    /// <summary>
    /// Gets the V17 register.
    /// </summary>
    public static Arm64RegisterV V17 => new(17);

    /// <summary>
    /// Gets the V18 register.
    /// </summary>
    public static Arm64RegisterV V18 => new(18);

    /// <summary>
    /// Gets the V19 register.
    /// </summary>
    public static Arm64RegisterV V19 => new(19);

    /// <summary>
    /// Gets the V20 register.
    /// </summary>
    public static Arm64RegisterV V20 => new(20);

    /// <summary>
    /// Gets the V21 register.
    /// </summary>
    public static Arm64RegisterV V21 => new(21);

    /// <summary>
    /// Gets the V22 register.
    /// </summary>
    public static Arm64RegisterV V22 => new(22);

    /// <summary>
    /// Gets the V23 register.
    /// </summary>
    public static Arm64RegisterV V23 => new(23);

    /// <summary>
    /// Gets the V24 register.
    /// </summary>
    public static Arm64RegisterV V24 => new(24);

    /// <summary>
    /// Gets the V25 register.
    /// </summary>
    public static Arm64RegisterV V25 => new(25);

    /// <summary>
    /// Gets the V26 register.
    /// </summary>
    public static Arm64RegisterV V26 => new(26);

    /// <summary>
    /// Gets the V27 register.
    /// </summary>
    public static Arm64RegisterV V27 => new(27);

    /// <summary>
    /// Gets the V28 register.
    /// </summary>
    public static Arm64RegisterV V28 => new(28);

    /// <summary>
    /// Gets the V29 register.
    /// </summary>
    public static Arm64RegisterV V29 => new(29);

    /// <summary>
    /// Gets the V30 register.
    /// </summary>
    public static Arm64RegisterV V30 => new(30);

    /// <summary>
    /// Gets the V31 register.
    /// </summary>
    public static Arm64RegisterV V31 => new(31);
}

/// <summary>
/// Represents an ARM64 an arranged 8 x B, 8-bit vector register
/// </summary>
public readonly record struct Arm64RegisterV8B : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV8B(int index) => _value = 8U << 24 | (uint)Arm64RegisterVKind.B << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

/// <summary>
/// Represents an ARM64 an arranged 16 x B, 8-bit vector register
/// </summary>
public readonly record struct Arm64RegisterV16B : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV16B(int index) => _value = 16U << 24 | (uint)Arm64RegisterVKind.B << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

/// <summary>
/// Represents an ARM64 a Half-precision 16-bit floating-point register (H arrangement).
/// </summary>
public readonly record struct Arm64RegisterVScalarH : IArm64RegisterVScalar
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterVScalarH(int index) => _value = (uint)Arm64RegisterVKind.H << 16 | (uint)Arm64RegisterKind.VScalar << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the H0 register.
    /// </summary>
    public static Arm64RegisterVScalarH H0 => new(0);

    /// <summary>
    /// Gets the H1 register.
    /// </summary>
    public static Arm64RegisterVScalarH H1 => new(1);

    /// <summary>
    /// Gets the H2 register.
    /// </summary>
    public static Arm64RegisterVScalarH H2 => new(2);

    /// <summary>
    /// Gets the H3 register.
    /// </summary>
    public static Arm64RegisterVScalarH H3 => new(3);

    /// <summary>
    /// Gets the H4 register.
    /// </summary>
    public static Arm64RegisterVScalarH H4 => new(4);

    /// <summary>
    /// Gets the H5 register.
    /// </summary>
    public static Arm64RegisterVScalarH H5 => new(5);

    /// <summary>
    /// Gets the H6 register.
    /// </summary>
    public static Arm64RegisterVScalarH H6 => new(6);

    /// <summary>
    /// Gets the H7 register.
    /// </summary>
    public static Arm64RegisterVScalarH H7 => new(7);

    /// <summary>
    /// Gets the H8 register.
    /// </summary>
    public static Arm64RegisterVScalarH H8 => new(8);

    /// <summary>
    /// Gets the H9 register.
    /// </summary>
    public static Arm64RegisterVScalarH H9 => new(9);

    /// <summary>
    /// Gets the H10 register.
    /// </summary>
    public static Arm64RegisterVScalarH H10 => new(10);

    /// <summary>
    /// Gets the H11 register.
    /// </summary>
    public static Arm64RegisterVScalarH H11 => new(11);

    /// <summary>
    /// Gets the H12 register.
    /// </summary>
    public static Arm64RegisterVScalarH H12 => new(12);

    /// <summary>
    /// Gets the H13 register.
    /// </summary>
    public static Arm64RegisterVScalarH H13 => new(13);

    /// <summary>
    /// Gets the H14 register.
    /// </summary>
    public static Arm64RegisterVScalarH H14 => new(14);

    /// <summary>
    /// Gets the H15 register.
    /// </summary>
    public static Arm64RegisterVScalarH H15 => new(15);

    /// <summary>
    /// Gets the H16 register.
    /// </summary>
    public static Arm64RegisterVScalarH H16 => new(16);

    /// <summary>
    /// Gets the H17 register.
    /// </summary>
    public static Arm64RegisterVScalarH H17 => new(17);

    /// <summary>
    /// Gets the H18 register.
    /// </summary>
    public static Arm64RegisterVScalarH H18 => new(18);

    /// <summary>
    /// Gets the H19 register.
    /// </summary>
    public static Arm64RegisterVScalarH H19 => new(19);

    /// <summary>
    /// Gets the H20 register.
    /// </summary>
    public static Arm64RegisterVScalarH H20 => new(20);

    /// <summary>
    /// Gets the H21 register.
    /// </summary>
    public static Arm64RegisterVScalarH H21 => new(21);

    /// <summary>
    /// Gets the H22 register.
    /// </summary>
    public static Arm64RegisterVScalarH H22 => new(22);

    /// <summary>
    /// Gets the H23 register.
    /// </summary>
    public static Arm64RegisterVScalarH H23 => new(23);

    /// <summary>
    /// Gets the H24 register.
    /// </summary>
    public static Arm64RegisterVScalarH H24 => new(24);

    /// <summary>
    /// Gets the H25 register.
    /// </summary>
    public static Arm64RegisterVScalarH H25 => new(25);

    /// <summary>
    /// Gets the H26 register.
    /// </summary>
    public static Arm64RegisterVScalarH H26 => new(26);

    /// <summary>
    /// Gets the H27 register.
    /// </summary>
    public static Arm64RegisterVScalarH H27 => new(27);

    /// <summary>
    /// Gets the H28 register.
    /// </summary>
    public static Arm64RegisterVScalarH H28 => new(28);

    /// <summary>
    /// Gets the H29 register.
    /// </summary>
    public static Arm64RegisterVScalarH H29 => new(29);

    /// <summary>
    /// Gets the H30 register.
    /// </summary>
    public static Arm64RegisterVScalarH H30 => new(30);

    /// <summary>
    /// Gets the H31 register.
    /// </summary>
    public static Arm64RegisterVScalarH H31 => new(31);
}

/// <summary>
/// Represents an ARM64 an arranged 4 x H, Half-precision 16-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV4H : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV4H(int index) => _value = 4U << 24 | (uint)Arm64RegisterVKind.H << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

/// <summary>
/// Represents an ARM64 an arranged 8 x H, Half-precision 16-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV8H : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV8H(int index) => _value = 8U << 24 | (uint)Arm64RegisterVKind.H << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

/// <summary>
/// Represents an ARM64 a Single-precision 32-bit floating-point register (S arrangement).
/// </summary>
public readonly record struct Arm64RegisterVScalarS : IArm64RegisterVScalar
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterVScalarS(int index) => _value = (uint)Arm64RegisterVKind.S << 16 | (uint)Arm64RegisterKind.VScalar << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the S0 register.
    /// </summary>
    public static Arm64RegisterVScalarS S0 => new(0);

    /// <summary>
    /// Gets the S1 register.
    /// </summary>
    public static Arm64RegisterVScalarS S1 => new(1);

    /// <summary>
    /// Gets the S2 register.
    /// </summary>
    public static Arm64RegisterVScalarS S2 => new(2);

    /// <summary>
    /// Gets the S3 register.
    /// </summary>
    public static Arm64RegisterVScalarS S3 => new(3);

    /// <summary>
    /// Gets the S4 register.
    /// </summary>
    public static Arm64RegisterVScalarS S4 => new(4);

    /// <summary>
    /// Gets the S5 register.
    /// </summary>
    public static Arm64RegisterVScalarS S5 => new(5);

    /// <summary>
    /// Gets the S6 register.
    /// </summary>
    public static Arm64RegisterVScalarS S6 => new(6);

    /// <summary>
    /// Gets the S7 register.
    /// </summary>
    public static Arm64RegisterVScalarS S7 => new(7);

    /// <summary>
    /// Gets the S8 register.
    /// </summary>
    public static Arm64RegisterVScalarS S8 => new(8);

    /// <summary>
    /// Gets the S9 register.
    /// </summary>
    public static Arm64RegisterVScalarS S9 => new(9);

    /// <summary>
    /// Gets the S10 register.
    /// </summary>
    public static Arm64RegisterVScalarS S10 => new(10);

    /// <summary>
    /// Gets the S11 register.
    /// </summary>
    public static Arm64RegisterVScalarS S11 => new(11);

    /// <summary>
    /// Gets the S12 register.
    /// </summary>
    public static Arm64RegisterVScalarS S12 => new(12);

    /// <summary>
    /// Gets the S13 register.
    /// </summary>
    public static Arm64RegisterVScalarS S13 => new(13);

    /// <summary>
    /// Gets the S14 register.
    /// </summary>
    public static Arm64RegisterVScalarS S14 => new(14);

    /// <summary>
    /// Gets the S15 register.
    /// </summary>
    public static Arm64RegisterVScalarS S15 => new(15);

    /// <summary>
    /// Gets the S16 register.
    /// </summary>
    public static Arm64RegisterVScalarS S16 => new(16);

    /// <summary>
    /// Gets the S17 register.
    /// </summary>
    public static Arm64RegisterVScalarS S17 => new(17);

    /// <summary>
    /// Gets the S18 register.
    /// </summary>
    public static Arm64RegisterVScalarS S18 => new(18);

    /// <summary>
    /// Gets the S19 register.
    /// </summary>
    public static Arm64RegisterVScalarS S19 => new(19);

    /// <summary>
    /// Gets the S20 register.
    /// </summary>
    public static Arm64RegisterVScalarS S20 => new(20);

    /// <summary>
    /// Gets the S21 register.
    /// </summary>
    public static Arm64RegisterVScalarS S21 => new(21);

    /// <summary>
    /// Gets the S22 register.
    /// </summary>
    public static Arm64RegisterVScalarS S22 => new(22);

    /// <summary>
    /// Gets the S23 register.
    /// </summary>
    public static Arm64RegisterVScalarS S23 => new(23);

    /// <summary>
    /// Gets the S24 register.
    /// </summary>
    public static Arm64RegisterVScalarS S24 => new(24);

    /// <summary>
    /// Gets the S25 register.
    /// </summary>
    public static Arm64RegisterVScalarS S25 => new(25);

    /// <summary>
    /// Gets the S26 register.
    /// </summary>
    public static Arm64RegisterVScalarS S26 => new(26);

    /// <summary>
    /// Gets the S27 register.
    /// </summary>
    public static Arm64RegisterVScalarS S27 => new(27);

    /// <summary>
    /// Gets the S28 register.
    /// </summary>
    public static Arm64RegisterVScalarS S28 => new(28);

    /// <summary>
    /// Gets the S29 register.
    /// </summary>
    public static Arm64RegisterVScalarS S29 => new(29);

    /// <summary>
    /// Gets the S30 register.
    /// </summary>
    public static Arm64RegisterVScalarS S30 => new(30);

    /// <summary>
    /// Gets the S31 register.
    /// </summary>
    public static Arm64RegisterVScalarS S31 => new(31);
}

/// <summary>
/// Represents an ARM64 an arranged 2 x S, Single-precision 32-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV2S : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV2S(int index) => _value = 2U << 24 | (uint)Arm64RegisterVKind.S << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

/// <summary>
/// Represents an ARM64 an arranged 4 x S, Single-precision 32-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV4S : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV4S(int index) => _value = 4U << 24 | (uint)Arm64RegisterVKind.S << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

/// <summary>
/// Represents an ARM64 a Double-precision 64-bit floating-point register (D arrangement).
/// </summary>
public readonly record struct Arm64RegisterVScalarD : IArm64RegisterVScalar
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterVScalarD(int index) => _value = (uint)Arm64RegisterVKind.D << 16 | (uint)Arm64RegisterKind.VScalar << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }

    /// <summary>
    /// Gets the D0 register.
    /// </summary>
    public static Arm64RegisterVScalarD D0 => new(0);

    /// <summary>
    /// Gets the D1 register.
    /// </summary>
    public static Arm64RegisterVScalarD D1 => new(1);

    /// <summary>
    /// Gets the D2 register.
    /// </summary>
    public static Arm64RegisterVScalarD D2 => new(2);

    /// <summary>
    /// Gets the D3 register.
    /// </summary>
    public static Arm64RegisterVScalarD D3 => new(3);

    /// <summary>
    /// Gets the D4 register.
    /// </summary>
    public static Arm64RegisterVScalarD D4 => new(4);

    /// <summary>
    /// Gets the D5 register.
    /// </summary>
    public static Arm64RegisterVScalarD D5 => new(5);

    /// <summary>
    /// Gets the D6 register.
    /// </summary>
    public static Arm64RegisterVScalarD D6 => new(6);

    /// <summary>
    /// Gets the D7 register.
    /// </summary>
    public static Arm64RegisterVScalarD D7 => new(7);

    /// <summary>
    /// Gets the D8 register.
    /// </summary>
    public static Arm64RegisterVScalarD D8 => new(8);

    /// <summary>
    /// Gets the D9 register.
    /// </summary>
    public static Arm64RegisterVScalarD D9 => new(9);

    /// <summary>
    /// Gets the D10 register.
    /// </summary>
    public static Arm64RegisterVScalarD D10 => new(10);

    /// <summary>
    /// Gets the D11 register.
    /// </summary>
    public static Arm64RegisterVScalarD D11 => new(11);

    /// <summary>
    /// Gets the D12 register.
    /// </summary>
    public static Arm64RegisterVScalarD D12 => new(12);

    /// <summary>
    /// Gets the D13 register.
    /// </summary>
    public static Arm64RegisterVScalarD D13 => new(13);

    /// <summary>
    /// Gets the D14 register.
    /// </summary>
    public static Arm64RegisterVScalarD D14 => new(14);

    /// <summary>
    /// Gets the D15 register.
    /// </summary>
    public static Arm64RegisterVScalarD D15 => new(15);

    /// <summary>
    /// Gets the D16 register.
    /// </summary>
    public static Arm64RegisterVScalarD D16 => new(16);

    /// <summary>
    /// Gets the D17 register.
    /// </summary>
    public static Arm64RegisterVScalarD D17 => new(17);

    /// <summary>
    /// Gets the D18 register.
    /// </summary>
    public static Arm64RegisterVScalarD D18 => new(18);

    /// <summary>
    /// Gets the D19 register.
    /// </summary>
    public static Arm64RegisterVScalarD D19 => new(19);

    /// <summary>
    /// Gets the D20 register.
    /// </summary>
    public static Arm64RegisterVScalarD D20 => new(20);

    /// <summary>
    /// Gets the D21 register.
    /// </summary>
    public static Arm64RegisterVScalarD D21 => new(21);

    /// <summary>
    /// Gets the D22 register.
    /// </summary>
    public static Arm64RegisterVScalarD D22 => new(22);

    /// <summary>
    /// Gets the D23 register.
    /// </summary>
    public static Arm64RegisterVScalarD D23 => new(23);

    /// <summary>
    /// Gets the D24 register.
    /// </summary>
    public static Arm64RegisterVScalarD D24 => new(24);

    /// <summary>
    /// Gets the D25 register.
    /// </summary>
    public static Arm64RegisterVScalarD D25 => new(25);

    /// <summary>
    /// Gets the D26 register.
    /// </summary>
    public static Arm64RegisterVScalarD D26 => new(26);

    /// <summary>
    /// Gets the D27 register.
    /// </summary>
    public static Arm64RegisterVScalarD D27 => new(27);

    /// <summary>
    /// Gets the D28 register.
    /// </summary>
    public static Arm64RegisterVScalarD D28 => new(28);

    /// <summary>
    /// Gets the D29 register.
    /// </summary>
    public static Arm64RegisterVScalarD D29 => new(29);

    /// <summary>
    /// Gets the D30 register.
    /// </summary>
    public static Arm64RegisterVScalarD D30 => new(30);

    /// <summary>
    /// Gets the D31 register.
    /// </summary>
    public static Arm64RegisterVScalarD D31 => new(31);
}

/// <summary>
/// Represents an ARM64 an arranged 2 x D, Double-precision 64-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV2D : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV2D(int index) => _value = 2U << 24 | (uint)Arm64RegisterVKind.D << 16 | (uint)Arm64RegisterKind.VTyped << 8 | (uint)index;

    /// <inheritdoc />
    public Arm64RegisterKind Kind => (Arm64RegisterKind)(_value >> 8);

    /// <inheritdoc />
    public int Index => (byte)_value;

    /// <inheritdoc />
    public Arm64RegisterVKind VKind => (Arm64RegisterVKind)(_value >> 16);

    /// <inheritdoc />
    public int ElementCount => (int)(_value >> 24);

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider) => this.ToText((format ??= "L") == "H");

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        if (format.Length != 1) format = "L";
        var text = this.ToText(format[0] == 'H');
        var result = text.AsSpan().TryCopyTo(destination);
        charsWritten = result ? text.Length : 0;
        return result;
    }
}

partial class Arm64Factory
{
    /// <summary>
    /// Gets the XZR register.
    /// </summary>
    public static Arm64RegisterX XZR => Arm64RegisterX.XZR;

        /// <summary>
    /// Gets the WZR register.
    /// </summary>
    public static Arm64RegisterW WZR => Arm64RegisterW.WZR;
    /// <summary>
    /// Gets the X0 register.
    /// </summary>
    public static Arm64RegisterX X0 => Arm64RegisterX.X0;
    /// <summary>
    /// Gets the X1 register.
    /// </summary>
    public static Arm64RegisterX X1 => Arm64RegisterX.X1;
    /// <summary>
    /// Gets the X2 register.
    /// </summary>
    public static Arm64RegisterX X2 => Arm64RegisterX.X2;
    /// <summary>
    /// Gets the X3 register.
    /// </summary>
    public static Arm64RegisterX X3 => Arm64RegisterX.X3;
    /// <summary>
    /// Gets the X4 register.
    /// </summary>
    public static Arm64RegisterX X4 => Arm64RegisterX.X4;
    /// <summary>
    /// Gets the X5 register.
    /// </summary>
    public static Arm64RegisterX X5 => Arm64RegisterX.X5;
    /// <summary>
    /// Gets the X6 register.
    /// </summary>
    public static Arm64RegisterX X6 => Arm64RegisterX.X6;
    /// <summary>
    /// Gets the X7 register.
    /// </summary>
    public static Arm64RegisterX X7 => Arm64RegisterX.X7;
    /// <summary>
    /// Gets the X8 register.
    /// </summary>
    public static Arm64RegisterX X8 => Arm64RegisterX.X8;
    /// <summary>
    /// Gets the X9 register.
    /// </summary>
    public static Arm64RegisterX X9 => Arm64RegisterX.X9;
    /// <summary>
    /// Gets the X10 register.
    /// </summary>
    public static Arm64RegisterX X10 => Arm64RegisterX.X10;
    /// <summary>
    /// Gets the X11 register.
    /// </summary>
    public static Arm64RegisterX X11 => Arm64RegisterX.X11;
    /// <summary>
    /// Gets the X12 register.
    /// </summary>
    public static Arm64RegisterX X12 => Arm64RegisterX.X12;
    /// <summary>
    /// Gets the X13 register.
    /// </summary>
    public static Arm64RegisterX X13 => Arm64RegisterX.X13;
    /// <summary>
    /// Gets the X14 register.
    /// </summary>
    public static Arm64RegisterX X14 => Arm64RegisterX.X14;
    /// <summary>
    /// Gets the X15 register.
    /// </summary>
    public static Arm64RegisterX X15 => Arm64RegisterX.X15;
    /// <summary>
    /// Gets the X16 register.
    /// </summary>
    public static Arm64RegisterX X16 => Arm64RegisterX.X16;
    /// <summary>
    /// Gets the X17 register.
    /// </summary>
    public static Arm64RegisterX X17 => Arm64RegisterX.X17;
    /// <summary>
    /// Gets the X18 register.
    /// </summary>
    public static Arm64RegisterX X18 => Arm64RegisterX.X18;
    /// <summary>
    /// Gets the X19 register.
    /// </summary>
    public static Arm64RegisterX X19 => Arm64RegisterX.X19;
    /// <summary>
    /// Gets the X20 register.
    /// </summary>
    public static Arm64RegisterX X20 => Arm64RegisterX.X20;
    /// <summary>
    /// Gets the X21 register.
    /// </summary>
    public static Arm64RegisterX X21 => Arm64RegisterX.X21;
    /// <summary>
    /// Gets the X22 register.
    /// </summary>
    public static Arm64RegisterX X22 => Arm64RegisterX.X22;
    /// <summary>
    /// Gets the X23 register.
    /// </summary>
    public static Arm64RegisterX X23 => Arm64RegisterX.X23;
    /// <summary>
    /// Gets the X24 register.
    /// </summary>
    public static Arm64RegisterX X24 => Arm64RegisterX.X24;
    /// <summary>
    /// Gets the X25 register.
    /// </summary>
    public static Arm64RegisterX X25 => Arm64RegisterX.X25;
    /// <summary>
    /// Gets the X26 register.
    /// </summary>
    public static Arm64RegisterX X26 => Arm64RegisterX.X26;
    /// <summary>
    /// Gets the X27 register.
    /// </summary>
    public static Arm64RegisterX X27 => Arm64RegisterX.X27;
    /// <summary>
    /// Gets the X28 register.
    /// </summary>
    public static Arm64RegisterX X28 => Arm64RegisterX.X28;
    /// <summary>
    /// Gets the X29 register.
    /// </summary>
    public static Arm64RegisterX X29 => Arm64RegisterX.X29;
    /// <summary>
    /// Gets the X30 register.
    /// </summary>
    public static Arm64RegisterX X30 => Arm64RegisterX.X30;
    /// <summary>
    /// Gets the W0 register.
    /// </summary>
    public static Arm64RegisterW W0 => Arm64RegisterW.W0;
    /// <summary>
    /// Gets the W1 register.
    /// </summary>
    public static Arm64RegisterW W1 => Arm64RegisterW.W1;
    /// <summary>
    /// Gets the W2 register.
    /// </summary>
    public static Arm64RegisterW W2 => Arm64RegisterW.W2;
    /// <summary>
    /// Gets the W3 register.
    /// </summary>
    public static Arm64RegisterW W3 => Arm64RegisterW.W3;
    /// <summary>
    /// Gets the W4 register.
    /// </summary>
    public static Arm64RegisterW W4 => Arm64RegisterW.W4;
    /// <summary>
    /// Gets the W5 register.
    /// </summary>
    public static Arm64RegisterW W5 => Arm64RegisterW.W5;
    /// <summary>
    /// Gets the W6 register.
    /// </summary>
    public static Arm64RegisterW W6 => Arm64RegisterW.W6;
    /// <summary>
    /// Gets the W7 register.
    /// </summary>
    public static Arm64RegisterW W7 => Arm64RegisterW.W7;
    /// <summary>
    /// Gets the W8 register.
    /// </summary>
    public static Arm64RegisterW W8 => Arm64RegisterW.W8;
    /// <summary>
    /// Gets the W9 register.
    /// </summary>
    public static Arm64RegisterW W9 => Arm64RegisterW.W9;
    /// <summary>
    /// Gets the W10 register.
    /// </summary>
    public static Arm64RegisterW W10 => Arm64RegisterW.W10;
    /// <summary>
    /// Gets the W11 register.
    /// </summary>
    public static Arm64RegisterW W11 => Arm64RegisterW.W11;
    /// <summary>
    /// Gets the W12 register.
    /// </summary>
    public static Arm64RegisterW W12 => Arm64RegisterW.W12;
    /// <summary>
    /// Gets the W13 register.
    /// </summary>
    public static Arm64RegisterW W13 => Arm64RegisterW.W13;
    /// <summary>
    /// Gets the W14 register.
    /// </summary>
    public static Arm64RegisterW W14 => Arm64RegisterW.W14;
    /// <summary>
    /// Gets the W15 register.
    /// </summary>
    public static Arm64RegisterW W15 => Arm64RegisterW.W15;
    /// <summary>
    /// Gets the W16 register.
    /// </summary>
    public static Arm64RegisterW W16 => Arm64RegisterW.W16;
    /// <summary>
    /// Gets the W17 register.
    /// </summary>
    public static Arm64RegisterW W17 => Arm64RegisterW.W17;
    /// <summary>
    /// Gets the W18 register.
    /// </summary>
    public static Arm64RegisterW W18 => Arm64RegisterW.W18;
    /// <summary>
    /// Gets the W19 register.
    /// </summary>
    public static Arm64RegisterW W19 => Arm64RegisterW.W19;
    /// <summary>
    /// Gets the W20 register.
    /// </summary>
    public static Arm64RegisterW W20 => Arm64RegisterW.W20;
    /// <summary>
    /// Gets the W21 register.
    /// </summary>
    public static Arm64RegisterW W21 => Arm64RegisterW.W21;
    /// <summary>
    /// Gets the W22 register.
    /// </summary>
    public static Arm64RegisterW W22 => Arm64RegisterW.W22;
    /// <summary>
    /// Gets the W23 register.
    /// </summary>
    public static Arm64RegisterW W23 => Arm64RegisterW.W23;
    /// <summary>
    /// Gets the W24 register.
    /// </summary>
    public static Arm64RegisterW W24 => Arm64RegisterW.W24;
    /// <summary>
    /// Gets the W25 register.
    /// </summary>
    public static Arm64RegisterW W25 => Arm64RegisterW.W25;
    /// <summary>
    /// Gets the W26 register.
    /// </summary>
    public static Arm64RegisterW W26 => Arm64RegisterW.W26;
    /// <summary>
    /// Gets the W27 register.
    /// </summary>
    public static Arm64RegisterW W27 => Arm64RegisterW.W27;
    /// <summary>
    /// Gets the W28 register.
    /// </summary>
    public static Arm64RegisterW W28 => Arm64RegisterW.W28;
    /// <summary>
    /// Gets the W29 register.
    /// </summary>
    public static Arm64RegisterW W29 => Arm64RegisterW.W29;
    /// <summary>
    /// Gets the W30 register.
    /// </summary>
    public static Arm64RegisterW W30 => Arm64RegisterW.W30;
    /// <summary>
    /// Gets the SP register.
    /// </summary>
    public static Arm64RegisterSP SP =>  Arm64RegisterSP.SP;
    /// <summary>
    /// Gets the V0 register.
    /// </summary>
    public static Arm64RegisterV V0 => Arm64RegisterV.V0;
    /// <summary>
    /// Gets the V1 register.
    /// </summary>
    public static Arm64RegisterV V1 => Arm64RegisterV.V1;
    /// <summary>
    /// Gets the V2 register.
    /// </summary>
    public static Arm64RegisterV V2 => Arm64RegisterV.V2;
    /// <summary>
    /// Gets the V3 register.
    /// </summary>
    public static Arm64RegisterV V3 => Arm64RegisterV.V3;
    /// <summary>
    /// Gets the V4 register.
    /// </summary>
    public static Arm64RegisterV V4 => Arm64RegisterV.V4;
    /// <summary>
    /// Gets the V5 register.
    /// </summary>
    public static Arm64RegisterV V5 => Arm64RegisterV.V5;
    /// <summary>
    /// Gets the V6 register.
    /// </summary>
    public static Arm64RegisterV V6 => Arm64RegisterV.V6;
    /// <summary>
    /// Gets the V7 register.
    /// </summary>
    public static Arm64RegisterV V7 => Arm64RegisterV.V7;
    /// <summary>
    /// Gets the V8 register.
    /// </summary>
    public static Arm64RegisterV V8 => Arm64RegisterV.V8;
    /// <summary>
    /// Gets the V9 register.
    /// </summary>
    public static Arm64RegisterV V9 => Arm64RegisterV.V9;
    /// <summary>
    /// Gets the V10 register.
    /// </summary>
    public static Arm64RegisterV V10 => Arm64RegisterV.V10;
    /// <summary>
    /// Gets the V11 register.
    /// </summary>
    public static Arm64RegisterV V11 => Arm64RegisterV.V11;
    /// <summary>
    /// Gets the V12 register.
    /// </summary>
    public static Arm64RegisterV V12 => Arm64RegisterV.V12;
    /// <summary>
    /// Gets the V13 register.
    /// </summary>
    public static Arm64RegisterV V13 => Arm64RegisterV.V13;
    /// <summary>
    /// Gets the V14 register.
    /// </summary>
    public static Arm64RegisterV V14 => Arm64RegisterV.V14;
    /// <summary>
    /// Gets the V15 register.
    /// </summary>
    public static Arm64RegisterV V15 => Arm64RegisterV.V15;
    /// <summary>
    /// Gets the V16 register.
    /// </summary>
    public static Arm64RegisterV V16 => Arm64RegisterV.V16;
    /// <summary>
    /// Gets the V17 register.
    /// </summary>
    public static Arm64RegisterV V17 => Arm64RegisterV.V17;
    /// <summary>
    /// Gets the V18 register.
    /// </summary>
    public static Arm64RegisterV V18 => Arm64RegisterV.V18;
    /// <summary>
    /// Gets the V19 register.
    /// </summary>
    public static Arm64RegisterV V19 => Arm64RegisterV.V19;
    /// <summary>
    /// Gets the V20 register.
    /// </summary>
    public static Arm64RegisterV V20 => Arm64RegisterV.V20;
    /// <summary>
    /// Gets the V21 register.
    /// </summary>
    public static Arm64RegisterV V21 => Arm64RegisterV.V21;
    /// <summary>
    /// Gets the V22 register.
    /// </summary>
    public static Arm64RegisterV V22 => Arm64RegisterV.V22;
    /// <summary>
    /// Gets the V23 register.
    /// </summary>
    public static Arm64RegisterV V23 => Arm64RegisterV.V23;
    /// <summary>
    /// Gets the V24 register.
    /// </summary>
    public static Arm64RegisterV V24 => Arm64RegisterV.V24;
    /// <summary>
    /// Gets the V25 register.
    /// </summary>
    public static Arm64RegisterV V25 => Arm64RegisterV.V25;
    /// <summary>
    /// Gets the V26 register.
    /// </summary>
    public static Arm64RegisterV V26 => Arm64RegisterV.V26;
    /// <summary>
    /// Gets the V27 register.
    /// </summary>
    public static Arm64RegisterV V27 => Arm64RegisterV.V27;
    /// <summary>
    /// Gets the V28 register.
    /// </summary>
    public static Arm64RegisterV V28 => Arm64RegisterV.V28;
    /// <summary>
    /// Gets the V29 register.
    /// </summary>
    public static Arm64RegisterV V29 => Arm64RegisterV.V29;
    /// <summary>
    /// Gets the V30 register.
    /// </summary>
    public static Arm64RegisterV V30 => Arm64RegisterV.V30;
    /// <summary>
    /// Gets the V31 register.
    /// </summary>
    public static Arm64RegisterV V31 => Arm64RegisterV.V31;

    /// <summary>
    /// Gets the H0 register.
    /// </summary>
    public static Arm64RegisterVScalarH H0 => Arm64RegisterVScalarH.H0;
    /// <summary>
    /// Gets the H1 register.
    /// </summary>
    public static Arm64RegisterVScalarH H1 => Arm64RegisterVScalarH.H1;
    /// <summary>
    /// Gets the H2 register.
    /// </summary>
    public static Arm64RegisterVScalarH H2 => Arm64RegisterVScalarH.H2;
    /// <summary>
    /// Gets the H3 register.
    /// </summary>
    public static Arm64RegisterVScalarH H3 => Arm64RegisterVScalarH.H3;
    /// <summary>
    /// Gets the H4 register.
    /// </summary>
    public static Arm64RegisterVScalarH H4 => Arm64RegisterVScalarH.H4;
    /// <summary>
    /// Gets the H5 register.
    /// </summary>
    public static Arm64RegisterVScalarH H5 => Arm64RegisterVScalarH.H5;
    /// <summary>
    /// Gets the H6 register.
    /// </summary>
    public static Arm64RegisterVScalarH H6 => Arm64RegisterVScalarH.H6;
    /// <summary>
    /// Gets the H7 register.
    /// </summary>
    public static Arm64RegisterVScalarH H7 => Arm64RegisterVScalarH.H7;
    /// <summary>
    /// Gets the H8 register.
    /// </summary>
    public static Arm64RegisterVScalarH H8 => Arm64RegisterVScalarH.H8;
    /// <summary>
    /// Gets the H9 register.
    /// </summary>
    public static Arm64RegisterVScalarH H9 => Arm64RegisterVScalarH.H9;
    /// <summary>
    /// Gets the H10 register.
    /// </summary>
    public static Arm64RegisterVScalarH H10 => Arm64RegisterVScalarH.H10;
    /// <summary>
    /// Gets the H11 register.
    /// </summary>
    public static Arm64RegisterVScalarH H11 => Arm64RegisterVScalarH.H11;
    /// <summary>
    /// Gets the H12 register.
    /// </summary>
    public static Arm64RegisterVScalarH H12 => Arm64RegisterVScalarH.H12;
    /// <summary>
    /// Gets the H13 register.
    /// </summary>
    public static Arm64RegisterVScalarH H13 => Arm64RegisterVScalarH.H13;
    /// <summary>
    /// Gets the H14 register.
    /// </summary>
    public static Arm64RegisterVScalarH H14 => Arm64RegisterVScalarH.H14;
    /// <summary>
    /// Gets the H15 register.
    /// </summary>
    public static Arm64RegisterVScalarH H15 => Arm64RegisterVScalarH.H15;
    /// <summary>
    /// Gets the H16 register.
    /// </summary>
    public static Arm64RegisterVScalarH H16 => Arm64RegisterVScalarH.H16;
    /// <summary>
    /// Gets the H17 register.
    /// </summary>
    public static Arm64RegisterVScalarH H17 => Arm64RegisterVScalarH.H17;
    /// <summary>
    /// Gets the H18 register.
    /// </summary>
    public static Arm64RegisterVScalarH H18 => Arm64RegisterVScalarH.H18;
    /// <summary>
    /// Gets the H19 register.
    /// </summary>
    public static Arm64RegisterVScalarH H19 => Arm64RegisterVScalarH.H19;
    /// <summary>
    /// Gets the H20 register.
    /// </summary>
    public static Arm64RegisterVScalarH H20 => Arm64RegisterVScalarH.H20;
    /// <summary>
    /// Gets the H21 register.
    /// </summary>
    public static Arm64RegisterVScalarH H21 => Arm64RegisterVScalarH.H21;
    /// <summary>
    /// Gets the H22 register.
    /// </summary>
    public static Arm64RegisterVScalarH H22 => Arm64RegisterVScalarH.H22;
    /// <summary>
    /// Gets the H23 register.
    /// </summary>
    public static Arm64RegisterVScalarH H23 => Arm64RegisterVScalarH.H23;
    /// <summary>
    /// Gets the H24 register.
    /// </summary>
    public static Arm64RegisterVScalarH H24 => Arm64RegisterVScalarH.H24;
    /// <summary>
    /// Gets the H25 register.
    /// </summary>
    public static Arm64RegisterVScalarH H25 => Arm64RegisterVScalarH.H25;
    /// <summary>
    /// Gets the H26 register.
    /// </summary>
    public static Arm64RegisterVScalarH H26 => Arm64RegisterVScalarH.H26;
    /// <summary>
    /// Gets the H27 register.
    /// </summary>
    public static Arm64RegisterVScalarH H27 => Arm64RegisterVScalarH.H27;
    /// <summary>
    /// Gets the H28 register.
    /// </summary>
    public static Arm64RegisterVScalarH H28 => Arm64RegisterVScalarH.H28;
    /// <summary>
    /// Gets the H29 register.
    /// </summary>
    public static Arm64RegisterVScalarH H29 => Arm64RegisterVScalarH.H29;
    /// <summary>
    /// Gets the H30 register.
    /// </summary>
    public static Arm64RegisterVScalarH H30 => Arm64RegisterVScalarH.H30;
    /// <summary>
    /// Gets the H31 register.
    /// </summary>
    public static Arm64RegisterVScalarH H31 => Arm64RegisterVScalarH.H31;
    /// <summary>
    /// Gets the S0 register.
    /// </summary>
    public static Arm64RegisterVScalarS S0 => Arm64RegisterVScalarS.S0;
    /// <summary>
    /// Gets the S1 register.
    /// </summary>
    public static Arm64RegisterVScalarS S1 => Arm64RegisterVScalarS.S1;
    /// <summary>
    /// Gets the S2 register.
    /// </summary>
    public static Arm64RegisterVScalarS S2 => Arm64RegisterVScalarS.S2;
    /// <summary>
    /// Gets the S3 register.
    /// </summary>
    public static Arm64RegisterVScalarS S3 => Arm64RegisterVScalarS.S3;
    /// <summary>
    /// Gets the S4 register.
    /// </summary>
    public static Arm64RegisterVScalarS S4 => Arm64RegisterVScalarS.S4;
    /// <summary>
    /// Gets the S5 register.
    /// </summary>
    public static Arm64RegisterVScalarS S5 => Arm64RegisterVScalarS.S5;
    /// <summary>
    /// Gets the S6 register.
    /// </summary>
    public static Arm64RegisterVScalarS S6 => Arm64RegisterVScalarS.S6;
    /// <summary>
    /// Gets the S7 register.
    /// </summary>
    public static Arm64RegisterVScalarS S7 => Arm64RegisterVScalarS.S7;
    /// <summary>
    /// Gets the S8 register.
    /// </summary>
    public static Arm64RegisterVScalarS S8 => Arm64RegisterVScalarS.S8;
    /// <summary>
    /// Gets the S9 register.
    /// </summary>
    public static Arm64RegisterVScalarS S9 => Arm64RegisterVScalarS.S9;
    /// <summary>
    /// Gets the S10 register.
    /// </summary>
    public static Arm64RegisterVScalarS S10 => Arm64RegisterVScalarS.S10;
    /// <summary>
    /// Gets the S11 register.
    /// </summary>
    public static Arm64RegisterVScalarS S11 => Arm64RegisterVScalarS.S11;
    /// <summary>
    /// Gets the S12 register.
    /// </summary>
    public static Arm64RegisterVScalarS S12 => Arm64RegisterVScalarS.S12;
    /// <summary>
    /// Gets the S13 register.
    /// </summary>
    public static Arm64RegisterVScalarS S13 => Arm64RegisterVScalarS.S13;
    /// <summary>
    /// Gets the S14 register.
    /// </summary>
    public static Arm64RegisterVScalarS S14 => Arm64RegisterVScalarS.S14;
    /// <summary>
    /// Gets the S15 register.
    /// </summary>
    public static Arm64RegisterVScalarS S15 => Arm64RegisterVScalarS.S15;
    /// <summary>
    /// Gets the S16 register.
    /// </summary>
    public static Arm64RegisterVScalarS S16 => Arm64RegisterVScalarS.S16;
    /// <summary>
    /// Gets the S17 register.
    /// </summary>
    public static Arm64RegisterVScalarS S17 => Arm64RegisterVScalarS.S17;
    /// <summary>
    /// Gets the S18 register.
    /// </summary>
    public static Arm64RegisterVScalarS S18 => Arm64RegisterVScalarS.S18;
    /// <summary>
    /// Gets the S19 register.
    /// </summary>
    public static Arm64RegisterVScalarS S19 => Arm64RegisterVScalarS.S19;
    /// <summary>
    /// Gets the S20 register.
    /// </summary>
    public static Arm64RegisterVScalarS S20 => Arm64RegisterVScalarS.S20;
    /// <summary>
    /// Gets the S21 register.
    /// </summary>
    public static Arm64RegisterVScalarS S21 => Arm64RegisterVScalarS.S21;
    /// <summary>
    /// Gets the S22 register.
    /// </summary>
    public static Arm64RegisterVScalarS S22 => Arm64RegisterVScalarS.S22;
    /// <summary>
    /// Gets the S23 register.
    /// </summary>
    public static Arm64RegisterVScalarS S23 => Arm64RegisterVScalarS.S23;
    /// <summary>
    /// Gets the S24 register.
    /// </summary>
    public static Arm64RegisterVScalarS S24 => Arm64RegisterVScalarS.S24;
    /// <summary>
    /// Gets the S25 register.
    /// </summary>
    public static Arm64RegisterVScalarS S25 => Arm64RegisterVScalarS.S25;
    /// <summary>
    /// Gets the S26 register.
    /// </summary>
    public static Arm64RegisterVScalarS S26 => Arm64RegisterVScalarS.S26;
    /// <summary>
    /// Gets the S27 register.
    /// </summary>
    public static Arm64RegisterVScalarS S27 => Arm64RegisterVScalarS.S27;
    /// <summary>
    /// Gets the S28 register.
    /// </summary>
    public static Arm64RegisterVScalarS S28 => Arm64RegisterVScalarS.S28;
    /// <summary>
    /// Gets the S29 register.
    /// </summary>
    public static Arm64RegisterVScalarS S29 => Arm64RegisterVScalarS.S29;
    /// <summary>
    /// Gets the S30 register.
    /// </summary>
    public static Arm64RegisterVScalarS S30 => Arm64RegisterVScalarS.S30;
    /// <summary>
    /// Gets the S31 register.
    /// </summary>
    public static Arm64RegisterVScalarS S31 => Arm64RegisterVScalarS.S31;
    /// <summary>
    /// Gets the D0 register.
    /// </summary>
    public static Arm64RegisterVScalarD D0 => Arm64RegisterVScalarD.D0;
    /// <summary>
    /// Gets the D1 register.
    /// </summary>
    public static Arm64RegisterVScalarD D1 => Arm64RegisterVScalarD.D1;
    /// <summary>
    /// Gets the D2 register.
    /// </summary>
    public static Arm64RegisterVScalarD D2 => Arm64RegisterVScalarD.D2;
    /// <summary>
    /// Gets the D3 register.
    /// </summary>
    public static Arm64RegisterVScalarD D3 => Arm64RegisterVScalarD.D3;
    /// <summary>
    /// Gets the D4 register.
    /// </summary>
    public static Arm64RegisterVScalarD D4 => Arm64RegisterVScalarD.D4;
    /// <summary>
    /// Gets the D5 register.
    /// </summary>
    public static Arm64RegisterVScalarD D5 => Arm64RegisterVScalarD.D5;
    /// <summary>
    /// Gets the D6 register.
    /// </summary>
    public static Arm64RegisterVScalarD D6 => Arm64RegisterVScalarD.D6;
    /// <summary>
    /// Gets the D7 register.
    /// </summary>
    public static Arm64RegisterVScalarD D7 => Arm64RegisterVScalarD.D7;
    /// <summary>
    /// Gets the D8 register.
    /// </summary>
    public static Arm64RegisterVScalarD D8 => Arm64RegisterVScalarD.D8;
    /// <summary>
    /// Gets the D9 register.
    /// </summary>
    public static Arm64RegisterVScalarD D9 => Arm64RegisterVScalarD.D9;
    /// <summary>
    /// Gets the D10 register.
    /// </summary>
    public static Arm64RegisterVScalarD D10 => Arm64RegisterVScalarD.D10;
    /// <summary>
    /// Gets the D11 register.
    /// </summary>
    public static Arm64RegisterVScalarD D11 => Arm64RegisterVScalarD.D11;
    /// <summary>
    /// Gets the D12 register.
    /// </summary>
    public static Arm64RegisterVScalarD D12 => Arm64RegisterVScalarD.D12;
    /// <summary>
    /// Gets the D13 register.
    /// </summary>
    public static Arm64RegisterVScalarD D13 => Arm64RegisterVScalarD.D13;
    /// <summary>
    /// Gets the D14 register.
    /// </summary>
    public static Arm64RegisterVScalarD D14 => Arm64RegisterVScalarD.D14;
    /// <summary>
    /// Gets the D15 register.
    /// </summary>
    public static Arm64RegisterVScalarD D15 => Arm64RegisterVScalarD.D15;
    /// <summary>
    /// Gets the D16 register.
    /// </summary>
    public static Arm64RegisterVScalarD D16 => Arm64RegisterVScalarD.D16;
    /// <summary>
    /// Gets the D17 register.
    /// </summary>
    public static Arm64RegisterVScalarD D17 => Arm64RegisterVScalarD.D17;
    /// <summary>
    /// Gets the D18 register.
    /// </summary>
    public static Arm64RegisterVScalarD D18 => Arm64RegisterVScalarD.D18;
    /// <summary>
    /// Gets the D19 register.
    /// </summary>
    public static Arm64RegisterVScalarD D19 => Arm64RegisterVScalarD.D19;
    /// <summary>
    /// Gets the D20 register.
    /// </summary>
    public static Arm64RegisterVScalarD D20 => Arm64RegisterVScalarD.D20;
    /// <summary>
    /// Gets the D21 register.
    /// </summary>
    public static Arm64RegisterVScalarD D21 => Arm64RegisterVScalarD.D21;
    /// <summary>
    /// Gets the D22 register.
    /// </summary>
    public static Arm64RegisterVScalarD D22 => Arm64RegisterVScalarD.D22;
    /// <summary>
    /// Gets the D23 register.
    /// </summary>
    public static Arm64RegisterVScalarD D23 => Arm64RegisterVScalarD.D23;
    /// <summary>
    /// Gets the D24 register.
    /// </summary>
    public static Arm64RegisterVScalarD D24 => Arm64RegisterVScalarD.D24;
    /// <summary>
    /// Gets the D25 register.
    /// </summary>
    public static Arm64RegisterVScalarD D25 => Arm64RegisterVScalarD.D25;
    /// <summary>
    /// Gets the D26 register.
    /// </summary>
    public static Arm64RegisterVScalarD D26 => Arm64RegisterVScalarD.D26;
    /// <summary>
    /// Gets the D27 register.
    /// </summary>
    public static Arm64RegisterVScalarD D27 => Arm64RegisterVScalarD.D27;
    /// <summary>
    /// Gets the D28 register.
    /// </summary>
    public static Arm64RegisterVScalarD D28 => Arm64RegisterVScalarD.D28;
    /// <summary>
    /// Gets the D29 register.
    /// </summary>
    public static Arm64RegisterVScalarD D29 => Arm64RegisterVScalarD.D29;
    /// <summary>
    /// Gets the D30 register.
    /// </summary>
    public static Arm64RegisterVScalarD D30 => Arm64RegisterVScalarD.D30;
    /// <summary>
    /// Gets the D31 register.
    /// </summary>
    public static Arm64RegisterVScalarD D31 => Arm64RegisterVScalarD.D31;
}

partial class Arm64Extensions
{
    /// <summary>
    /// Converts the X register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterX register, bool upperCase = false) => upperCase ? RegisterXUpperNames[ValidateRegisterIndex(register.Index)] : RegisterXLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterXLowerNames = [
        "x0",
        "x1",
        "x2",
        "x3",
        "x4",
        "x5",
        "x6",
        "x7",
        "x8",
        "x9",
        "x10",
        "x11",
        "x12",
        "x13",
        "x14",
        "x15",
        "x16",
        "x17",
        "x18",
        "x19",
        "x20",
        "x21",
        "x22",
        "x23",
        "x24",
        "x25",
        "x26",
        "x27",
        "x28",
        "x29",
        "x30",
        "xzr",
    ];

    private static readonly string[] RegisterXUpperNames = [
        "X0",
        "X1",
        "X2",
        "X3",
        "X4",
        "X5",
        "X6",
        "X7",
        "X8",
        "X9",
        "X10",
        "X11",
        "X12",
        "X13",
        "X14",
        "X15",
        "X16",
        "X17",
        "X18",
        "X19",
        "X20",
        "X21",
        "X22",
        "X23",
        "X24",
        "X25",
        "X26",
        "X27",
        "X28",
        "X29",
        "X30",
        "XZR",
    ];
    /// <summary>
    /// Converts the W register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterW register, bool upperCase = false) => upperCase ? RegisterWUpperNames[ValidateRegisterIndex(register.Index)] : RegisterWLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterWLowerNames = [
        "w0",
        "w1",
        "w2",
        "w3",
        "w4",
        "w5",
        "w6",
        "w7",
        "w8",
        "w9",
        "w10",
        "w11",
        "w12",
        "w13",
        "w14",
        "w15",
        "w16",
        "w17",
        "w18",
        "w19",
        "w20",
        "w21",
        "w22",
        "w23",
        "w24",
        "w25",
        "w26",
        "w27",
        "w28",
        "w29",
        "w30",
        "wzr",
    ];

    private static readonly string[] RegisterWUpperNames = [
        "W0",
        "W1",
        "W2",
        "W3",
        "W4",
        "W5",
        "W6",
        "W7",
        "W8",
        "W9",
        "W10",
        "W11",
        "W12",
        "W13",
        "W14",
        "W15",
        "W16",
        "W17",
        "W18",
        "W19",
        "W20",
        "W21",
        "W22",
        "W23",
        "W24",
        "W25",
        "W26",
        "W27",
        "W28",
        "W29",
        "W30",
        "WZR",
    ];
    /// <summary>
    /// Converts the SP register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterSP register, bool upperCase = false) => upperCase ? RegisterSPUpperNames[ValidateRegisterIndex(register.Index)] : RegisterSPLowerNames[ValidateRegisterIndex(register.Index)];
    private static readonly string[] RegisterSPLowerNames = [
        "??", // 0
        "??", // 1
        "??", // 2
        "??", // 3
        "??", // 4
        "??", // 5
        "??", // 6
        "??", // 7
        "??", // 8
        "??", // 9
        "??", // 10
        "??", // 11
        "??", // 12
        "??", // 13
        "??", // 14
        "??", // 15
        "??", // 16
        "??", // 17
        "??", // 18
        "??", // 19
        "??", // 20
        "??", // 21
        "??", // 22
        "??", // 23
        "??", // 24
        "??", // 25
        "??", // 26
        "??", // 27
        "??", // 28
        "??", // 29
        "??", // 30
        "sp", // 31
    ];

    private static readonly string[] RegisterSPUpperNames = [
        "??", // 0
        "??", // 1
        "??", // 2
        "??", // 3
        "??", // 4
        "??", // 5
        "??", // 6
        "??", // 7
        "??", // 8
        "??", // 9
        "??", // 10
        "??", // 11
        "??", // 12
        "??", // 13
        "??", // 14
        "??", // 15
        "??", // 16
        "??", // 17
        "??", // 18
        "??", // 19
        "??", // 20
        "??", // 21
        "??", // 22
        "??", // 23
        "??", // 24
        "??", // 25
        "??", // 26
        "??", // 27
        "??", // 28
        "??", // 29
        "??", // 30
        "SP", // 31
    ];
    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV register, bool upperCase = false) => upperCase ? RegisterVUpperNames[ValidateRegisterIndex(register.Index)] : RegisterVLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterVLowerNames = [
        "v0",
        "v1",
        "v2",
        "v3",
        "v4",
        "v5",
        "v6",
        "v7",
        "v8",
        "v9",
        "v10",
        "v11",
        "v12",
        "v13",
        "v14",
        "v15",
        "v16",
        "v17",
        "v18",
        "v19",
        "v20",
        "v21",
        "v22",
        "v23",
        "v24",
        "v25",
        "v26",
        "v27",
        "v28",
        "v29",
        "v30",
        "v31",
    ];

    private static readonly string[] RegisterVUpperNames = [
        "V0",
        "V1",
        "V2",
        "V3",
        "V4",
        "V5",
        "V6",
        "V7",
        "V8",
        "V9",
        "V10",
        "V11",
        "V12",
        "V13",
        "V14",
        "V15",
        "V16",
        "V17",
        "V18",
        "V19",
        "V20",
        "V21",
        "V22",
        "V23",
        "V24",
        "V25",
        "V26",
        "V27",
        "V28",
        "V29",
        "V30",
        "V31",
    ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV8B register, bool upperCase = false) => upperCase ? RegisterV8BUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV8BLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV8BLowerNames = [
        "v0.8b",
        "v1.8b",
        "v2.8b",
        "v3.8b",
        "v4.8b",
        "v5.8b",
        "v6.8b",
        "v7.8b",
        "v8.8b",
        "v9.8b",
        "v10.8b",
        "v11.8b",
        "v12.8b",
        "v13.8b",
        "v14.8b",
        "v15.8b",
        "v16.8b",
        "v17.8b",
        "v18.8b",
        "v19.8b",
        "v20.8b",
        "v21.8b",
        "v22.8b",
        "v23.8b",
        "v24.8b",
        "v25.8b",
        "v26.8b",
        "v27.8b",
        "v28.8b",
        "v29.8b",
        "v30.8b",
        "v31.8b",
        ];

    private static readonly string[] RegisterV8BUpperNames = [
        "V0.8B",
        "V1.8B",
        "V2.8B",
        "V3.8B",
        "V4.8B",
        "V5.8B",
        "V6.8B",
        "V7.8B",
        "V8.8B",
        "V9.8B",
        "V10.8B",
        "V11.8B",
        "V12.8B",
        "V13.8B",
        "V14.8B",
        "V15.8B",
        "V16.8B",
        "V17.8B",
        "V18.8B",
        "V19.8B",
        "V20.8B",
        "V21.8B",
        "V22.8B",
        "V23.8B",
        "V24.8B",
        "V25.8B",
        "V26.8B",
        "V27.8B",
        "V28.8B",
        "V29.8B",
        "V30.8B",
        "V31.8B",
        ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV16B register, bool upperCase = false) => upperCase ? RegisterV16BUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV16BLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV16BLowerNames = [
        "v0.16b",
        "v1.16b",
        "v2.16b",
        "v3.16b",
        "v4.16b",
        "v5.16b",
        "v6.16b",
        "v7.16b",
        "v8.16b",
        "v9.16b",
        "v10.16b",
        "v11.16b",
        "v12.16b",
        "v13.16b",
        "v14.16b",
        "v15.16b",
        "v16.16b",
        "v17.16b",
        "v18.16b",
        "v19.16b",
        "v20.16b",
        "v21.16b",
        "v22.16b",
        "v23.16b",
        "v24.16b",
        "v25.16b",
        "v26.16b",
        "v27.16b",
        "v28.16b",
        "v29.16b",
        "v30.16b",
        "v31.16b",
        ];

    private static readonly string[] RegisterV16BUpperNames = [
        "V0.16B",
        "V1.16B",
        "V2.16B",
        "V3.16B",
        "V4.16B",
        "V5.16B",
        "V6.16B",
        "V7.16B",
        "V8.16B",
        "V9.16B",
        "V10.16B",
        "V11.16B",
        "V12.16B",
        "V13.16B",
        "V14.16B",
        "V15.16B",
        "V16.16B",
        "V17.16B",
        "V18.16B",
        "V19.16B",
        "V20.16B",
        "V21.16B",
        "V22.16B",
        "V23.16B",
        "V24.16B",
        "V25.16B",
        "V26.16B",
        "V27.16B",
        "V28.16B",
        "V29.16B",
        "V30.16B",
        "V31.16B",
        ];
    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterVScalarH register, bool upperCase = false) => upperCase ? RegisterVScalarHUpperNames[ValidateRegisterIndex(register.Index)] : RegisterVScalarHLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterVScalarHLowerNames = [
        "h0",
        "h1",
        "h2",
        "h3",
        "h4",
        "h5",
        "h6",
        "h7",
        "h8",
        "h9",
        "h10",
        "h11",
        "h12",
        "h13",
        "h14",
        "h15",
        "h16",
        "h17",
        "h18",
        "h19",
        "h20",
        "h21",
        "h22",
        "h23",
        "h24",
        "h25",
        "h26",
        "h27",
        "h28",
        "h29",
        "h30",
        "h31",
        ];

    private static readonly string[] RegisterVScalarHUpperNames = [
        "H0",
        "H1",
        "H2",
        "H3",
        "H4",
        "H5",
        "H6",
        "H7",
        "H8",
        "H9",
        "H10",
        "H11",
        "H12",
        "H13",
        "H14",
        "H15",
        "H16",
        "H17",
        "H18",
        "H19",
        "H20",
        "H21",
        "H22",
        "H23",
        "H24",
        "H25",
        "H26",
        "H27",
        "H28",
        "H29",
        "H30",
        "H31",
        ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV4H register, bool upperCase = false) => upperCase ? RegisterV4HUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV4HLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV4HLowerNames = [
        "v0.4h",
        "v1.4h",
        "v2.4h",
        "v3.4h",
        "v4.4h",
        "v5.4h",
        "v6.4h",
        "v7.4h",
        "v8.4h",
        "v9.4h",
        "v10.4h",
        "v11.4h",
        "v12.4h",
        "v13.4h",
        "v14.4h",
        "v15.4h",
        "v16.4h",
        "v17.4h",
        "v18.4h",
        "v19.4h",
        "v20.4h",
        "v21.4h",
        "v22.4h",
        "v23.4h",
        "v24.4h",
        "v25.4h",
        "v26.4h",
        "v27.4h",
        "v28.4h",
        "v29.4h",
        "v30.4h",
        "v31.4h",
        ];

    private static readonly string[] RegisterV4HUpperNames = [
        "V0.4H",
        "V1.4H",
        "V2.4H",
        "V3.4H",
        "V4.4H",
        "V5.4H",
        "V6.4H",
        "V7.4H",
        "V8.4H",
        "V9.4H",
        "V10.4H",
        "V11.4H",
        "V12.4H",
        "V13.4H",
        "V14.4H",
        "V15.4H",
        "V16.4H",
        "V17.4H",
        "V18.4H",
        "V19.4H",
        "V20.4H",
        "V21.4H",
        "V22.4H",
        "V23.4H",
        "V24.4H",
        "V25.4H",
        "V26.4H",
        "V27.4H",
        "V28.4H",
        "V29.4H",
        "V30.4H",
        "V31.4H",
        ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV8H register, bool upperCase = false) => upperCase ? RegisterV8HUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV8HLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV8HLowerNames = [
        "v0.8h",
        "v1.8h",
        "v2.8h",
        "v3.8h",
        "v4.8h",
        "v5.8h",
        "v6.8h",
        "v7.8h",
        "v8.8h",
        "v9.8h",
        "v10.8h",
        "v11.8h",
        "v12.8h",
        "v13.8h",
        "v14.8h",
        "v15.8h",
        "v16.8h",
        "v17.8h",
        "v18.8h",
        "v19.8h",
        "v20.8h",
        "v21.8h",
        "v22.8h",
        "v23.8h",
        "v24.8h",
        "v25.8h",
        "v26.8h",
        "v27.8h",
        "v28.8h",
        "v29.8h",
        "v30.8h",
        "v31.8h",
        ];

    private static readonly string[] RegisterV8HUpperNames = [
        "V0.8H",
        "V1.8H",
        "V2.8H",
        "V3.8H",
        "V4.8H",
        "V5.8H",
        "V6.8H",
        "V7.8H",
        "V8.8H",
        "V9.8H",
        "V10.8H",
        "V11.8H",
        "V12.8H",
        "V13.8H",
        "V14.8H",
        "V15.8H",
        "V16.8H",
        "V17.8H",
        "V18.8H",
        "V19.8H",
        "V20.8H",
        "V21.8H",
        "V22.8H",
        "V23.8H",
        "V24.8H",
        "V25.8H",
        "V26.8H",
        "V27.8H",
        "V28.8H",
        "V29.8H",
        "V30.8H",
        "V31.8H",
        ];
    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterVScalarS register, bool upperCase = false) => upperCase ? RegisterVScalarSUpperNames[ValidateRegisterIndex(register.Index)] : RegisterVScalarSLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterVScalarSLowerNames = [
        "s0",
        "s1",
        "s2",
        "s3",
        "s4",
        "s5",
        "s6",
        "s7",
        "s8",
        "s9",
        "s10",
        "s11",
        "s12",
        "s13",
        "s14",
        "s15",
        "s16",
        "s17",
        "s18",
        "s19",
        "s20",
        "s21",
        "s22",
        "s23",
        "s24",
        "s25",
        "s26",
        "s27",
        "s28",
        "s29",
        "s30",
        "s31",
        ];

    private static readonly string[] RegisterVScalarSUpperNames = [
        "S0",
        "S1",
        "S2",
        "S3",
        "S4",
        "S5",
        "S6",
        "S7",
        "S8",
        "S9",
        "S10",
        "S11",
        "S12",
        "S13",
        "S14",
        "S15",
        "S16",
        "S17",
        "S18",
        "S19",
        "S20",
        "S21",
        "S22",
        "S23",
        "S24",
        "S25",
        "S26",
        "S27",
        "S28",
        "S29",
        "S30",
        "S31",
        ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV2S register, bool upperCase = false) => upperCase ? RegisterV2SUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV2SLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV2SLowerNames = [
        "v0.2s",
        "v1.2s",
        "v2.2s",
        "v3.2s",
        "v4.2s",
        "v5.2s",
        "v6.2s",
        "v7.2s",
        "v8.2s",
        "v9.2s",
        "v10.2s",
        "v11.2s",
        "v12.2s",
        "v13.2s",
        "v14.2s",
        "v15.2s",
        "v16.2s",
        "v17.2s",
        "v18.2s",
        "v19.2s",
        "v20.2s",
        "v21.2s",
        "v22.2s",
        "v23.2s",
        "v24.2s",
        "v25.2s",
        "v26.2s",
        "v27.2s",
        "v28.2s",
        "v29.2s",
        "v30.2s",
        "v31.2s",
        ];

    private static readonly string[] RegisterV2SUpperNames = [
        "V0.2S",
        "V1.2S",
        "V2.2S",
        "V3.2S",
        "V4.2S",
        "V5.2S",
        "V6.2S",
        "V7.2S",
        "V8.2S",
        "V9.2S",
        "V10.2S",
        "V11.2S",
        "V12.2S",
        "V13.2S",
        "V14.2S",
        "V15.2S",
        "V16.2S",
        "V17.2S",
        "V18.2S",
        "V19.2S",
        "V20.2S",
        "V21.2S",
        "V22.2S",
        "V23.2S",
        "V24.2S",
        "V25.2S",
        "V26.2S",
        "V27.2S",
        "V28.2S",
        "V29.2S",
        "V30.2S",
        "V31.2S",
        ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV4S register, bool upperCase = false) => upperCase ? RegisterV4SUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV4SLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV4SLowerNames = [
        "v0.4s",
        "v1.4s",
        "v2.4s",
        "v3.4s",
        "v4.4s",
        "v5.4s",
        "v6.4s",
        "v7.4s",
        "v8.4s",
        "v9.4s",
        "v10.4s",
        "v11.4s",
        "v12.4s",
        "v13.4s",
        "v14.4s",
        "v15.4s",
        "v16.4s",
        "v17.4s",
        "v18.4s",
        "v19.4s",
        "v20.4s",
        "v21.4s",
        "v22.4s",
        "v23.4s",
        "v24.4s",
        "v25.4s",
        "v26.4s",
        "v27.4s",
        "v28.4s",
        "v29.4s",
        "v30.4s",
        "v31.4s",
        ];

    private static readonly string[] RegisterV4SUpperNames = [
        "V0.4S",
        "V1.4S",
        "V2.4S",
        "V3.4S",
        "V4.4S",
        "V5.4S",
        "V6.4S",
        "V7.4S",
        "V8.4S",
        "V9.4S",
        "V10.4S",
        "V11.4S",
        "V12.4S",
        "V13.4S",
        "V14.4S",
        "V15.4S",
        "V16.4S",
        "V17.4S",
        "V18.4S",
        "V19.4S",
        "V20.4S",
        "V21.4S",
        "V22.4S",
        "V23.4S",
        "V24.4S",
        "V25.4S",
        "V26.4S",
        "V27.4S",
        "V28.4S",
        "V29.4S",
        "V30.4S",
        "V31.4S",
        ];
    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterVScalarD register, bool upperCase = false) => upperCase ? RegisterVScalarDUpperNames[ValidateRegisterIndex(register.Index)] : RegisterVScalarDLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterVScalarDLowerNames = [
        "d0",
        "d1",
        "d2",
        "d3",
        "d4",
        "d5",
        "d6",
        "d7",
        "d8",
        "d9",
        "d10",
        "d11",
        "d12",
        "d13",
        "d14",
        "d15",
        "d16",
        "d17",
        "d18",
        "d19",
        "d20",
        "d21",
        "d22",
        "d23",
        "d24",
        "d25",
        "d26",
        "d27",
        "d28",
        "d29",
        "d30",
        "d31",
        ];

    private static readonly string[] RegisterVScalarDUpperNames = [
        "D0",
        "D1",
        "D2",
        "D3",
        "D4",
        "D5",
        "D6",
        "D7",
        "D8",
        "D9",
        "D10",
        "D11",
        "D12",
        "D13",
        "D14",
        "D15",
        "D16",
        "D17",
        "D18",
        "D19",
        "D20",
        "D21",
        "D22",
        "D23",
        "D24",
        "D25",
        "D26",
        "D27",
        "D28",
        "D29",
        "D30",
        "D31",
        ];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV2D register, bool upperCase = false) => upperCase ? RegisterV2DUpperNames[ValidateRegisterIndex(register.Index)] : RegisterV2DLowerNames[ValidateRegisterIndex(register.Index)];

    private static readonly string[] RegisterV2DLowerNames = [
        "v0.2d",
        "v1.2d",
        "v2.2d",
        "v3.2d",
        "v4.2d",
        "v5.2d",
        "v6.2d",
        "v7.2d",
        "v8.2d",
        "v9.2d",
        "v10.2d",
        "v11.2d",
        "v12.2d",
        "v13.2d",
        "v14.2d",
        "v15.2d",
        "v16.2d",
        "v17.2d",
        "v18.2d",
        "v19.2d",
        "v20.2d",
        "v21.2d",
        "v22.2d",
        "v23.2d",
        "v24.2d",
        "v25.2d",
        "v26.2d",
        "v27.2d",
        "v28.2d",
        "v29.2d",
        "v30.2d",
        "v31.2d",
        ];

    private static readonly string[] RegisterV2DUpperNames = [
        "V0.2D",
        "V1.2D",
        "V2.2D",
        "V3.2D",
        "V4.2D",
        "V5.2D",
        "V6.2D",
        "V7.2D",
        "V8.2D",
        "V9.2D",
        "V10.2D",
        "V11.2D",
        "V12.2D",
        "V13.2D",
        "V14.2D",
        "V15.2D",
        "V16.2D",
        "V17.2D",
        "V18.2D",
        "V19.2D",
        "V20.2D",
        "V21.2D",
        "V22.2D",
        "V23.2D",
        "V24.2D",
        "V25.2D",
        "V26.2D",
        "V27.2D",
        "V28.2D",
        "V29.2D",
        "V30.2D",
        "V31.2D",
        ];
}
