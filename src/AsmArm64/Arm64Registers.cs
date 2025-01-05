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
    /// Vector Scalar Element register (e.g. B0 / V0.B[0]).
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
    internal Arm64RegisterV8B(int index) => _value = 8U << 24 | (uint)Arm64RegisterVKind.B << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
    }
}

/// <summary>
/// Represents an ARM64 an arranged 16 x B, 8-bit vector register
/// </summary>
public readonly record struct Arm64RegisterV16B : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV16B(int index) => _value = 16U << 24 | (uint)Arm64RegisterVKind.B << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
    internal Arm64RegisterV4H(int index) => _value = 4U << 24 | (uint)Arm64RegisterVKind.H << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
    }
}

/// <summary>
/// Represents an ARM64 an arranged 8 x H, Half-precision 16-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV8H : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV8H(int index) => _value = 8U << 24 | (uint)Arm64RegisterVKind.H << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
    internal Arm64RegisterV2S(int index) => _value = 2U << 24 | (uint)Arm64RegisterVKind.S << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
    }
}

/// <summary>
/// Represents an ARM64 an arranged 4 x S, Single-precision 32-bit floating-point register
/// </summary>
public readonly record struct Arm64RegisterV4S : IArm64RegisterVTyped
{
    private readonly uint _value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64RegisterV4S(int index) => _value = 4U << 24 | (uint)Arm64RegisterVKind.S << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
    internal Arm64RegisterV2D(int index) => _value = 2U << 24 | (uint)Arm64RegisterVKind.D << 16 | (uint)Arm64RegisterKind.V << 8 | (uint)index;

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
        throw new NotImplementedException();
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
}

partial class Arm64Extensions
{
    /// <summary>
    /// Converts the X register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterX register, bool upperCase = false) => upperCase ? RegisterXUpperNames[register.Index] : RegisterXLowerNames[register.Index];

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
    public static string ToText(this Arm64RegisterW register, bool upperCase = false) => upperCase ? RegisterWUpperNames[register.Index] : RegisterWLowerNames[register.Index];

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
    public static string ToText(this Arm64RegisterSP register, bool upperCase = false) => upperCase ? RegisterSPUpperNames[register.Index] : RegisterSPLowerNames[register.Index];

    private static readonly string[] RegisterSPLowerNames = ["sp"];

    private static readonly string[] RegisterSPUpperNames = ["SP"];

    /// <summary>
    /// Converts the V register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterV register, bool upperCase = false) => upperCase ? RegisterVUpperNames[register.Index] : RegisterVLowerNames[register.Index];

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
}
