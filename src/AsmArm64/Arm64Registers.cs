// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the kind of register.
/// </summary>
public enum Arm64RegisterKind
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
    /// Zero 64-bit register.
    /// </summary>
    XZ,
    /// <summary>
    /// 32-bit general-purpose register.
    /// </summary>
    W,
    /// <summary>
    /// Zero 32-bit register.
    /// </summary>
    WZ,
    /// <summary>
    /// Stack pointer register.
    /// </summary>
    SP,
    /// <summary>
    /// Vector register.
    /// </summary>
    V,
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
/// Represents an ARM64 X register.
/// </summary>
public readonly record struct Arm64RegisterX : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterX(int index) => _value = (uint)((uint)Arm64RegisterKind.X << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.X;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

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
}

/// <summary>
/// Represents an ARM64 XZ register.
/// </summary>
public readonly record struct Arm64RegisterXZ : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterXZ(int index) => _value = (uint)((uint)Arm64RegisterKind.XZ << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.XZ;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

    /// <summary>
    /// Gets the XZ register.
    /// </summary>
    public static Arm64RegisterXZ XZR => new(0);
}

/// <summary>
/// Represents an ARM64 W register.
/// </summary>
public readonly record struct Arm64RegisterW : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterW(int index) => _value = (uint)((uint)Arm64RegisterKind.W << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.W;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

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
}

/// <summary>
/// Represents an ARM64 WZ register.
/// </summary>
public readonly record struct Arm64RegisterWZ : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterWZ(int index) => _value = (uint)((uint)Arm64RegisterKind.WZ << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.WZ;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

    /// <summary>
    /// Gets the WZ register.
    /// </summary>
    public static Arm64RegisterWZ WZR => new(0);
}

/// <summary>
/// Represents an ARM64 SP register.
/// </summary>
public readonly record struct Arm64RegisterSP : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterSP(int index) => _value = (uint)((uint)Arm64RegisterKind.SP << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.SP;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

    /// <summary>
    /// Gets the SP register.
    /// </summary>
    public static Arm64RegisterSP SP => new(0);
}

/// <summary>
/// Represents an ARM64 V register.
/// </summary>
public readonly record struct Arm64RegisterV : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterV(int index) => _value = (uint)((uint)Arm64RegisterKind.V << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.V;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

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
/// Represents an ARM64 H register.
/// </summary>
public readonly record struct Arm64RegisterH : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterH(int index) => _value = (uint)((uint)Arm64RegisterKind.H << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.H;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

    /// <summary>
    /// Gets the H0 register.
    /// </summary>
    public static Arm64RegisterH H0 => new(0);

    /// <summary>
    /// Gets the H1 register.
    /// </summary>
    public static Arm64RegisterH H1 => new(1);

    /// <summary>
    /// Gets the H2 register.
    /// </summary>
    public static Arm64RegisterH H2 => new(2);

    /// <summary>
    /// Gets the H3 register.
    /// </summary>
    public static Arm64RegisterH H3 => new(3);

    /// <summary>
    /// Gets the H4 register.
    /// </summary>
    public static Arm64RegisterH H4 => new(4);

    /// <summary>
    /// Gets the H5 register.
    /// </summary>
    public static Arm64RegisterH H5 => new(5);

    /// <summary>
    /// Gets the H6 register.
    /// </summary>
    public static Arm64RegisterH H6 => new(6);

    /// <summary>
    /// Gets the H7 register.
    /// </summary>
    public static Arm64RegisterH H7 => new(7);

    /// <summary>
    /// Gets the H8 register.
    /// </summary>
    public static Arm64RegisterH H8 => new(8);

    /// <summary>
    /// Gets the H9 register.
    /// </summary>
    public static Arm64RegisterH H9 => new(9);

    /// <summary>
    /// Gets the H10 register.
    /// </summary>
    public static Arm64RegisterH H10 => new(10);

    /// <summary>
    /// Gets the H11 register.
    /// </summary>
    public static Arm64RegisterH H11 => new(11);

    /// <summary>
    /// Gets the H12 register.
    /// </summary>
    public static Arm64RegisterH H12 => new(12);

    /// <summary>
    /// Gets the H13 register.
    /// </summary>
    public static Arm64RegisterH H13 => new(13);

    /// <summary>
    /// Gets the H14 register.
    /// </summary>
    public static Arm64RegisterH H14 => new(14);

    /// <summary>
    /// Gets the H15 register.
    /// </summary>
    public static Arm64RegisterH H15 => new(15);

    /// <summary>
    /// Gets the H16 register.
    /// </summary>
    public static Arm64RegisterH H16 => new(16);

    /// <summary>
    /// Gets the H17 register.
    /// </summary>
    public static Arm64RegisterH H17 => new(17);

    /// <summary>
    /// Gets the H18 register.
    /// </summary>
    public static Arm64RegisterH H18 => new(18);

    /// <summary>
    /// Gets the H19 register.
    /// </summary>
    public static Arm64RegisterH H19 => new(19);

    /// <summary>
    /// Gets the H20 register.
    /// </summary>
    public static Arm64RegisterH H20 => new(20);

    /// <summary>
    /// Gets the H21 register.
    /// </summary>
    public static Arm64RegisterH H21 => new(21);

    /// <summary>
    /// Gets the H22 register.
    /// </summary>
    public static Arm64RegisterH H22 => new(22);

    /// <summary>
    /// Gets the H23 register.
    /// </summary>
    public static Arm64RegisterH H23 => new(23);

    /// <summary>
    /// Gets the H24 register.
    /// </summary>
    public static Arm64RegisterH H24 => new(24);

    /// <summary>
    /// Gets the H25 register.
    /// </summary>
    public static Arm64RegisterH H25 => new(25);

    /// <summary>
    /// Gets the H26 register.
    /// </summary>
    public static Arm64RegisterH H26 => new(26);

    /// <summary>
    /// Gets the H27 register.
    /// </summary>
    public static Arm64RegisterH H27 => new(27);

    /// <summary>
    /// Gets the H28 register.
    /// </summary>
    public static Arm64RegisterH H28 => new(28);

    /// <summary>
    /// Gets the H29 register.
    /// </summary>
    public static Arm64RegisterH H29 => new(29);

    /// <summary>
    /// Gets the H30 register.
    /// </summary>
    public static Arm64RegisterH H30 => new(30);

    /// <summary>
    /// Gets the H31 register.
    /// </summary>
    public static Arm64RegisterH H31 => new(31);
}

/// <summary>
/// Represents an ARM64 S register.
/// </summary>
public readonly record struct Arm64RegisterS : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterS(int index) => _value = (uint)((uint)Arm64RegisterKind.S << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.S;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

    /// <summary>
    /// Gets the S0 register.
    /// </summary>
    public static Arm64RegisterS S0 => new(0);

    /// <summary>
    /// Gets the S1 register.
    /// </summary>
    public static Arm64RegisterS S1 => new(1);

    /// <summary>
    /// Gets the S2 register.
    /// </summary>
    public static Arm64RegisterS S2 => new(2);

    /// <summary>
    /// Gets the S3 register.
    /// </summary>
    public static Arm64RegisterS S3 => new(3);

    /// <summary>
    /// Gets the S4 register.
    /// </summary>
    public static Arm64RegisterS S4 => new(4);

    /// <summary>
    /// Gets the S5 register.
    /// </summary>
    public static Arm64RegisterS S5 => new(5);

    /// <summary>
    /// Gets the S6 register.
    /// </summary>
    public static Arm64RegisterS S6 => new(6);

    /// <summary>
    /// Gets the S7 register.
    /// </summary>
    public static Arm64RegisterS S7 => new(7);

    /// <summary>
    /// Gets the S8 register.
    /// </summary>
    public static Arm64RegisterS S8 => new(8);

    /// <summary>
    /// Gets the S9 register.
    /// </summary>
    public static Arm64RegisterS S9 => new(9);

    /// <summary>
    /// Gets the S10 register.
    /// </summary>
    public static Arm64RegisterS S10 => new(10);

    /// <summary>
    /// Gets the S11 register.
    /// </summary>
    public static Arm64RegisterS S11 => new(11);

    /// <summary>
    /// Gets the S12 register.
    /// </summary>
    public static Arm64RegisterS S12 => new(12);

    /// <summary>
    /// Gets the S13 register.
    /// </summary>
    public static Arm64RegisterS S13 => new(13);

    /// <summary>
    /// Gets the S14 register.
    /// </summary>
    public static Arm64RegisterS S14 => new(14);

    /// <summary>
    /// Gets the S15 register.
    /// </summary>
    public static Arm64RegisterS S15 => new(15);

    /// <summary>
    /// Gets the S16 register.
    /// </summary>
    public static Arm64RegisterS S16 => new(16);

    /// <summary>
    /// Gets the S17 register.
    /// </summary>
    public static Arm64RegisterS S17 => new(17);

    /// <summary>
    /// Gets the S18 register.
    /// </summary>
    public static Arm64RegisterS S18 => new(18);

    /// <summary>
    /// Gets the S19 register.
    /// </summary>
    public static Arm64RegisterS S19 => new(19);

    /// <summary>
    /// Gets the S20 register.
    /// </summary>
    public static Arm64RegisterS S20 => new(20);

    /// <summary>
    /// Gets the S21 register.
    /// </summary>
    public static Arm64RegisterS S21 => new(21);

    /// <summary>
    /// Gets the S22 register.
    /// </summary>
    public static Arm64RegisterS S22 => new(22);

    /// <summary>
    /// Gets the S23 register.
    /// </summary>
    public static Arm64RegisterS S23 => new(23);

    /// <summary>
    /// Gets the S24 register.
    /// </summary>
    public static Arm64RegisterS S24 => new(24);

    /// <summary>
    /// Gets the S25 register.
    /// </summary>
    public static Arm64RegisterS S25 => new(25);

    /// <summary>
    /// Gets the S26 register.
    /// </summary>
    public static Arm64RegisterS S26 => new(26);

    /// <summary>
    /// Gets the S27 register.
    /// </summary>
    public static Arm64RegisterS S27 => new(27);

    /// <summary>
    /// Gets the S28 register.
    /// </summary>
    public static Arm64RegisterS S28 => new(28);

    /// <summary>
    /// Gets the S29 register.
    /// </summary>
    public static Arm64RegisterS S29 => new(29);

    /// <summary>
    /// Gets the S30 register.
    /// </summary>
    public static Arm64RegisterS S30 => new(30);

    /// <summary>
    /// Gets the S31 register.
    /// </summary>
    public static Arm64RegisterS S31 => new(31);
}

/// <summary>
/// Represents an ARM64 D register.
/// </summary>
public readonly record struct Arm64RegisterD : IArm64Register
{
    private readonly uint _value;
    private Arm64RegisterD(int index) => _value = (uint)((uint)Arm64RegisterKind.D << 16 | (uint)index);

    /// <inheritdoc />
    public Arm64RegisterKind Kind => Arm64RegisterKind.D;

    /// <inheritdoc />
    public int Index => (int)(_value & 0b11111);

    /// <inheritdoc />
    public override string ToString() => this.ToText();

    /// <summary>
    /// Gets the D0 register.
    /// </summary>
    public static Arm64RegisterD D0 => new(0);

    /// <summary>
    /// Gets the D1 register.
    /// </summary>
    public static Arm64RegisterD D1 => new(1);

    /// <summary>
    /// Gets the D2 register.
    /// </summary>
    public static Arm64RegisterD D2 => new(2);

    /// <summary>
    /// Gets the D3 register.
    /// </summary>
    public static Arm64RegisterD D3 => new(3);

    /// <summary>
    /// Gets the D4 register.
    /// </summary>
    public static Arm64RegisterD D4 => new(4);

    /// <summary>
    /// Gets the D5 register.
    /// </summary>
    public static Arm64RegisterD D5 => new(5);

    /// <summary>
    /// Gets the D6 register.
    /// </summary>
    public static Arm64RegisterD D6 => new(6);

    /// <summary>
    /// Gets the D7 register.
    /// </summary>
    public static Arm64RegisterD D7 => new(7);

    /// <summary>
    /// Gets the D8 register.
    /// </summary>
    public static Arm64RegisterD D8 => new(8);

    /// <summary>
    /// Gets the D9 register.
    /// </summary>
    public static Arm64RegisterD D9 => new(9);

    /// <summary>
    /// Gets the D10 register.
    /// </summary>
    public static Arm64RegisterD D10 => new(10);

    /// <summary>
    /// Gets the D11 register.
    /// </summary>
    public static Arm64RegisterD D11 => new(11);

    /// <summary>
    /// Gets the D12 register.
    /// </summary>
    public static Arm64RegisterD D12 => new(12);

    /// <summary>
    /// Gets the D13 register.
    /// </summary>
    public static Arm64RegisterD D13 => new(13);

    /// <summary>
    /// Gets the D14 register.
    /// </summary>
    public static Arm64RegisterD D14 => new(14);

    /// <summary>
    /// Gets the D15 register.
    /// </summary>
    public static Arm64RegisterD D15 => new(15);

    /// <summary>
    /// Gets the D16 register.
    /// </summary>
    public static Arm64RegisterD D16 => new(16);

    /// <summary>
    /// Gets the D17 register.
    /// </summary>
    public static Arm64RegisterD D17 => new(17);

    /// <summary>
    /// Gets the D18 register.
    /// </summary>
    public static Arm64RegisterD D18 => new(18);

    /// <summary>
    /// Gets the D19 register.
    /// </summary>
    public static Arm64RegisterD D19 => new(19);

    /// <summary>
    /// Gets the D20 register.
    /// </summary>
    public static Arm64RegisterD D20 => new(20);

    /// <summary>
    /// Gets the D21 register.
    /// </summary>
    public static Arm64RegisterD D21 => new(21);

    /// <summary>
    /// Gets the D22 register.
    /// </summary>
    public static Arm64RegisterD D22 => new(22);

    /// <summary>
    /// Gets the D23 register.
    /// </summary>
    public static Arm64RegisterD D23 => new(23);

    /// <summary>
    /// Gets the D24 register.
    /// </summary>
    public static Arm64RegisterD D24 => new(24);

    /// <summary>
    /// Gets the D25 register.
    /// </summary>
    public static Arm64RegisterD D25 => new(25);

    /// <summary>
    /// Gets the D26 register.
    /// </summary>
    public static Arm64RegisterD D26 => new(26);

    /// <summary>
    /// Gets the D27 register.
    /// </summary>
    public static Arm64RegisterD D27 => new(27);

    /// <summary>
    /// Gets the D28 register.
    /// </summary>
    public static Arm64RegisterD D28 => new(28);

    /// <summary>
    /// Gets the D29 register.
    /// </summary>
    public static Arm64RegisterD D29 => new(29);

    /// <summary>
    /// Gets the D30 register.
    /// </summary>
    public static Arm64RegisterD D30 => new(30);

    /// <summary>
    /// Gets the D31 register.
    /// </summary>
    public static Arm64RegisterD D31 => new(31);
}

partial class Arm64Factory
{
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
    /// Gets the XZ register.
    /// </summary>
    public static Arm64RegisterXZ XZR => Arm64RegisterXZ.XZR;
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
    /// Gets the WZ register.
    /// </summary>
    public static Arm64RegisterWZ WZR => Arm64RegisterWZ.WZR;
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
    public static Arm64RegisterH H0 => Arm64RegisterH.H0;
    /// <summary>
    /// Gets the H1 register.
    /// </summary>
    public static Arm64RegisterH H1 => Arm64RegisterH.H1;
    /// <summary>
    /// Gets the H2 register.
    /// </summary>
    public static Arm64RegisterH H2 => Arm64RegisterH.H2;
    /// <summary>
    /// Gets the H3 register.
    /// </summary>
    public static Arm64RegisterH H3 => Arm64RegisterH.H3;
    /// <summary>
    /// Gets the H4 register.
    /// </summary>
    public static Arm64RegisterH H4 => Arm64RegisterH.H4;
    /// <summary>
    /// Gets the H5 register.
    /// </summary>
    public static Arm64RegisterH H5 => Arm64RegisterH.H5;
    /// <summary>
    /// Gets the H6 register.
    /// </summary>
    public static Arm64RegisterH H6 => Arm64RegisterH.H6;
    /// <summary>
    /// Gets the H7 register.
    /// </summary>
    public static Arm64RegisterH H7 => Arm64RegisterH.H7;
    /// <summary>
    /// Gets the H8 register.
    /// </summary>
    public static Arm64RegisterH H8 => Arm64RegisterH.H8;
    /// <summary>
    /// Gets the H9 register.
    /// </summary>
    public static Arm64RegisterH H9 => Arm64RegisterH.H9;
    /// <summary>
    /// Gets the H10 register.
    /// </summary>
    public static Arm64RegisterH H10 => Arm64RegisterH.H10;
    /// <summary>
    /// Gets the H11 register.
    /// </summary>
    public static Arm64RegisterH H11 => Arm64RegisterH.H11;
    /// <summary>
    /// Gets the H12 register.
    /// </summary>
    public static Arm64RegisterH H12 => Arm64RegisterH.H12;
    /// <summary>
    /// Gets the H13 register.
    /// </summary>
    public static Arm64RegisterH H13 => Arm64RegisterH.H13;
    /// <summary>
    /// Gets the H14 register.
    /// </summary>
    public static Arm64RegisterH H14 => Arm64RegisterH.H14;
    /// <summary>
    /// Gets the H15 register.
    /// </summary>
    public static Arm64RegisterH H15 => Arm64RegisterH.H15;
    /// <summary>
    /// Gets the H16 register.
    /// </summary>
    public static Arm64RegisterH H16 => Arm64RegisterH.H16;
    /// <summary>
    /// Gets the H17 register.
    /// </summary>
    public static Arm64RegisterH H17 => Arm64RegisterH.H17;
    /// <summary>
    /// Gets the H18 register.
    /// </summary>
    public static Arm64RegisterH H18 => Arm64RegisterH.H18;
    /// <summary>
    /// Gets the H19 register.
    /// </summary>
    public static Arm64RegisterH H19 => Arm64RegisterH.H19;
    /// <summary>
    /// Gets the H20 register.
    /// </summary>
    public static Arm64RegisterH H20 => Arm64RegisterH.H20;
    /// <summary>
    /// Gets the H21 register.
    /// </summary>
    public static Arm64RegisterH H21 => Arm64RegisterH.H21;
    /// <summary>
    /// Gets the H22 register.
    /// </summary>
    public static Arm64RegisterH H22 => Arm64RegisterH.H22;
    /// <summary>
    /// Gets the H23 register.
    /// </summary>
    public static Arm64RegisterH H23 => Arm64RegisterH.H23;
    /// <summary>
    /// Gets the H24 register.
    /// </summary>
    public static Arm64RegisterH H24 => Arm64RegisterH.H24;
    /// <summary>
    /// Gets the H25 register.
    /// </summary>
    public static Arm64RegisterH H25 => Arm64RegisterH.H25;
    /// <summary>
    /// Gets the H26 register.
    /// </summary>
    public static Arm64RegisterH H26 => Arm64RegisterH.H26;
    /// <summary>
    /// Gets the H27 register.
    /// </summary>
    public static Arm64RegisterH H27 => Arm64RegisterH.H27;
    /// <summary>
    /// Gets the H28 register.
    /// </summary>
    public static Arm64RegisterH H28 => Arm64RegisterH.H28;
    /// <summary>
    /// Gets the H29 register.
    /// </summary>
    public static Arm64RegisterH H29 => Arm64RegisterH.H29;
    /// <summary>
    /// Gets the H30 register.
    /// </summary>
    public static Arm64RegisterH H30 => Arm64RegisterH.H30;
    /// <summary>
    /// Gets the H31 register.
    /// </summary>
    public static Arm64RegisterH H31 => Arm64RegisterH.H31;
    /// <summary>
    /// Gets the S0 register.
    /// </summary>
    public static Arm64RegisterS S0 => Arm64RegisterS.S0;
    /// <summary>
    /// Gets the S1 register.
    /// </summary>
    public static Arm64RegisterS S1 => Arm64RegisterS.S1;
    /// <summary>
    /// Gets the S2 register.
    /// </summary>
    public static Arm64RegisterS S2 => Arm64RegisterS.S2;
    /// <summary>
    /// Gets the S3 register.
    /// </summary>
    public static Arm64RegisterS S3 => Arm64RegisterS.S3;
    /// <summary>
    /// Gets the S4 register.
    /// </summary>
    public static Arm64RegisterS S4 => Arm64RegisterS.S4;
    /// <summary>
    /// Gets the S5 register.
    /// </summary>
    public static Arm64RegisterS S5 => Arm64RegisterS.S5;
    /// <summary>
    /// Gets the S6 register.
    /// </summary>
    public static Arm64RegisterS S6 => Arm64RegisterS.S6;
    /// <summary>
    /// Gets the S7 register.
    /// </summary>
    public static Arm64RegisterS S7 => Arm64RegisterS.S7;
    /// <summary>
    /// Gets the S8 register.
    /// </summary>
    public static Arm64RegisterS S8 => Arm64RegisterS.S8;
    /// <summary>
    /// Gets the S9 register.
    /// </summary>
    public static Arm64RegisterS S9 => Arm64RegisterS.S9;
    /// <summary>
    /// Gets the S10 register.
    /// </summary>
    public static Arm64RegisterS S10 => Arm64RegisterS.S10;
    /// <summary>
    /// Gets the S11 register.
    /// </summary>
    public static Arm64RegisterS S11 => Arm64RegisterS.S11;
    /// <summary>
    /// Gets the S12 register.
    /// </summary>
    public static Arm64RegisterS S12 => Arm64RegisterS.S12;
    /// <summary>
    /// Gets the S13 register.
    /// </summary>
    public static Arm64RegisterS S13 => Arm64RegisterS.S13;
    /// <summary>
    /// Gets the S14 register.
    /// </summary>
    public static Arm64RegisterS S14 => Arm64RegisterS.S14;
    /// <summary>
    /// Gets the S15 register.
    /// </summary>
    public static Arm64RegisterS S15 => Arm64RegisterS.S15;
    /// <summary>
    /// Gets the S16 register.
    /// </summary>
    public static Arm64RegisterS S16 => Arm64RegisterS.S16;
    /// <summary>
    /// Gets the S17 register.
    /// </summary>
    public static Arm64RegisterS S17 => Arm64RegisterS.S17;
    /// <summary>
    /// Gets the S18 register.
    /// </summary>
    public static Arm64RegisterS S18 => Arm64RegisterS.S18;
    /// <summary>
    /// Gets the S19 register.
    /// </summary>
    public static Arm64RegisterS S19 => Arm64RegisterS.S19;
    /// <summary>
    /// Gets the S20 register.
    /// </summary>
    public static Arm64RegisterS S20 => Arm64RegisterS.S20;
    /// <summary>
    /// Gets the S21 register.
    /// </summary>
    public static Arm64RegisterS S21 => Arm64RegisterS.S21;
    /// <summary>
    /// Gets the S22 register.
    /// </summary>
    public static Arm64RegisterS S22 => Arm64RegisterS.S22;
    /// <summary>
    /// Gets the S23 register.
    /// </summary>
    public static Arm64RegisterS S23 => Arm64RegisterS.S23;
    /// <summary>
    /// Gets the S24 register.
    /// </summary>
    public static Arm64RegisterS S24 => Arm64RegisterS.S24;
    /// <summary>
    /// Gets the S25 register.
    /// </summary>
    public static Arm64RegisterS S25 => Arm64RegisterS.S25;
    /// <summary>
    /// Gets the S26 register.
    /// </summary>
    public static Arm64RegisterS S26 => Arm64RegisterS.S26;
    /// <summary>
    /// Gets the S27 register.
    /// </summary>
    public static Arm64RegisterS S27 => Arm64RegisterS.S27;
    /// <summary>
    /// Gets the S28 register.
    /// </summary>
    public static Arm64RegisterS S28 => Arm64RegisterS.S28;
    /// <summary>
    /// Gets the S29 register.
    /// </summary>
    public static Arm64RegisterS S29 => Arm64RegisterS.S29;
    /// <summary>
    /// Gets the S30 register.
    /// </summary>
    public static Arm64RegisterS S30 => Arm64RegisterS.S30;
    /// <summary>
    /// Gets the S31 register.
    /// </summary>
    public static Arm64RegisterS S31 => Arm64RegisterS.S31;
    /// <summary>
    /// Gets the D0 register.
    /// </summary>
    public static Arm64RegisterD D0 => Arm64RegisterD.D0;
    /// <summary>
    /// Gets the D1 register.
    /// </summary>
    public static Arm64RegisterD D1 => Arm64RegisterD.D1;
    /// <summary>
    /// Gets the D2 register.
    /// </summary>
    public static Arm64RegisterD D2 => Arm64RegisterD.D2;
    /// <summary>
    /// Gets the D3 register.
    /// </summary>
    public static Arm64RegisterD D3 => Arm64RegisterD.D3;
    /// <summary>
    /// Gets the D4 register.
    /// </summary>
    public static Arm64RegisterD D4 => Arm64RegisterD.D4;
    /// <summary>
    /// Gets the D5 register.
    /// </summary>
    public static Arm64RegisterD D5 => Arm64RegisterD.D5;
    /// <summary>
    /// Gets the D6 register.
    /// </summary>
    public static Arm64RegisterD D6 => Arm64RegisterD.D6;
    /// <summary>
    /// Gets the D7 register.
    /// </summary>
    public static Arm64RegisterD D7 => Arm64RegisterD.D7;
    /// <summary>
    /// Gets the D8 register.
    /// </summary>
    public static Arm64RegisterD D8 => Arm64RegisterD.D8;
    /// <summary>
    /// Gets the D9 register.
    /// </summary>
    public static Arm64RegisterD D9 => Arm64RegisterD.D9;
    /// <summary>
    /// Gets the D10 register.
    /// </summary>
    public static Arm64RegisterD D10 => Arm64RegisterD.D10;
    /// <summary>
    /// Gets the D11 register.
    /// </summary>
    public static Arm64RegisterD D11 => Arm64RegisterD.D11;
    /// <summary>
    /// Gets the D12 register.
    /// </summary>
    public static Arm64RegisterD D12 => Arm64RegisterD.D12;
    /// <summary>
    /// Gets the D13 register.
    /// </summary>
    public static Arm64RegisterD D13 => Arm64RegisterD.D13;
    /// <summary>
    /// Gets the D14 register.
    /// </summary>
    public static Arm64RegisterD D14 => Arm64RegisterD.D14;
    /// <summary>
    /// Gets the D15 register.
    /// </summary>
    public static Arm64RegisterD D15 => Arm64RegisterD.D15;
    /// <summary>
    /// Gets the D16 register.
    /// </summary>
    public static Arm64RegisterD D16 => Arm64RegisterD.D16;
    /// <summary>
    /// Gets the D17 register.
    /// </summary>
    public static Arm64RegisterD D17 => Arm64RegisterD.D17;
    /// <summary>
    /// Gets the D18 register.
    /// </summary>
    public static Arm64RegisterD D18 => Arm64RegisterD.D18;
    /// <summary>
    /// Gets the D19 register.
    /// </summary>
    public static Arm64RegisterD D19 => Arm64RegisterD.D19;
    /// <summary>
    /// Gets the D20 register.
    /// </summary>
    public static Arm64RegisterD D20 => Arm64RegisterD.D20;
    /// <summary>
    /// Gets the D21 register.
    /// </summary>
    public static Arm64RegisterD D21 => Arm64RegisterD.D21;
    /// <summary>
    /// Gets the D22 register.
    /// </summary>
    public static Arm64RegisterD D22 => Arm64RegisterD.D22;
    /// <summary>
    /// Gets the D23 register.
    /// </summary>
    public static Arm64RegisterD D23 => Arm64RegisterD.D23;
    /// <summary>
    /// Gets the D24 register.
    /// </summary>
    public static Arm64RegisterD D24 => Arm64RegisterD.D24;
    /// <summary>
    /// Gets the D25 register.
    /// </summary>
    public static Arm64RegisterD D25 => Arm64RegisterD.D25;
    /// <summary>
    /// Gets the D26 register.
    /// </summary>
    public static Arm64RegisterD D26 => Arm64RegisterD.D26;
    /// <summary>
    /// Gets the D27 register.
    /// </summary>
    public static Arm64RegisterD D27 => Arm64RegisterD.D27;
    /// <summary>
    /// Gets the D28 register.
    /// </summary>
    public static Arm64RegisterD D28 => Arm64RegisterD.D28;
    /// <summary>
    /// Gets the D29 register.
    /// </summary>
    public static Arm64RegisterD D29 => Arm64RegisterD.D29;
    /// <summary>
    /// Gets the D30 register.
    /// </summary>
    public static Arm64RegisterD D30 => Arm64RegisterD.D30;
    /// <summary>
    /// Gets the D31 register.
    /// </summary>
    public static Arm64RegisterD D31 => Arm64RegisterD.D31;
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
    ];
    /// <summary>
    /// Converts the XZ register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterXZ register, bool upperCase = false) => upperCase ? RegisterXZUpperNames[register.Index] : RegisterXZLowerNames[register.Index];

    private static readonly string[] RegisterXZLowerNames = ["xzr"];

    private static readonly string[] RegisterXZUpperNames = ["XZR"];



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
    ];
    /// <summary>
    /// Converts the WZ register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterWZ register, bool upperCase = false) => upperCase ? RegisterWZUpperNames[register.Index] : RegisterWZLowerNames[register.Index];

    private static readonly string[] RegisterWZLowerNames = ["wzr"];

    private static readonly string[] RegisterWZUpperNames = ["WZR"];

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
    /// <summary>
    /// Converts the H register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterH register, bool upperCase = false) => upperCase ? RegisterHUpperNames[register.Index] : RegisterHLowerNames[register.Index];

    private static readonly string[] RegisterHLowerNames = [
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
    private static readonly string[] RegisterHUpperNames = [
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
    /// Converts the S register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterS register, bool upperCase = false) => upperCase ? RegisterSUpperNames[register.Index] : RegisterSLowerNames[register.Index];

    private static readonly string[] RegisterSLowerNames = [
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
    private static readonly string[] RegisterSUpperNames = [
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
    /// Converts the D register to a string.
    /// </summary>
    public static string ToText(this Arm64RegisterD register, bool upperCase = false) => upperCase ? RegisterDUpperNames[register.Index] : RegisterDLowerNames[register.Index];

    private static readonly string[] RegisterDLowerNames = [
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
    private static readonly string[] RegisterDUpperNames = [
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
}
