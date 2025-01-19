// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the type of shift for an ARM64 instruction.
/// </summary>
public enum Arm64ShiftKind : byte
{
    /// <summary>
    /// Logical shift left
    /// </summary>
    LSL,
    /// <summary>
    /// Logical shift right
    /// </summary>
    LSR,
    /// <summary>
    /// Arithmetic shift right
    /// </summary>
    ASR,
    /// <summary>
    /// Rotation right;
    /// </summary>
    ROR,
    /// <summary>
    /// MSL shift;
    /// </summary>
    MSL,
    /// <summary>
    /// Invalid shift encoding;
    /// </summary>
    Invalid,
}

/// <summary>
/// Defines the type for a fixed shift of an ARM64 instruction.
/// </summary>
public enum Arm64FixedShiftKind : byte
{
    /// <summary>
    /// Logical shift left of 0.
    /// </summary>
    LSL0,
    /// <summary>
    /// Logical shift left of 12.
    /// </summary>
    LSL12,
}

public interface IArm64ShiftKind
{
    Arm64ShiftKind ShiftKind { get; }
}

public struct LSLShiftKind : IArm64ShiftKind
{
    public Arm64ShiftKind ShiftKind => Arm64ShiftKind.LSL;

    public override string ToString() => this.ToText();
}

public struct LSRShiftKind : IArm64ShiftKind
{
    public Arm64ShiftKind ShiftKind => Arm64ShiftKind.LSR;

    public override string ToString() => this.ToText();
}

public struct ASRShiftKind : IArm64ShiftKind
{
    public Arm64ShiftKind ShiftKind => Arm64ShiftKind.ASR;

    public override string ToString() => this.ToText();
}

public struct RORShiftKind : IArm64ShiftKind
{
    public Arm64ShiftKind ShiftKind => Arm64ShiftKind.ROR;

    public override string ToString() => this.ToText();
}

public struct MSLShiftKind : IArm64ShiftKind
{
    public Arm64ShiftKind ShiftKind => Arm64ShiftKind.MSL;

    public override string ToString() => this.ToText();
}

/// <summary>
/// A shift type that supports only LSL, LSR, ASR.
/// </summary>
public readonly record struct Arm64ShiftKind3 : IArm64ShiftKind
{
    public Arm64ShiftKind3(Arm64ShiftKind shiftType)
    {
        if (shiftType == Arm64ShiftKind.ROR) throw new ArgumentException("Invalid shift type ROR not supported", nameof(shiftType));
        this.ShiftKind = shiftType;
    }

    /// <summary>
    /// Gets the shift type.
    /// </summary>
    public Arm64ShiftKind ShiftKind { get; }

    /// <inheritdoc />
    public override string ToString() => this.ToText();
    
    public static implicit operator Arm64ShiftKind3(LSLShiftKind shiftKind) => new(Arm64ShiftKind.LSL);

    public static implicit operator Arm64ShiftKind3(LSRShiftKind shiftKind) => new(Arm64ShiftKind.LSR);

    public static implicit operator Arm64ShiftKind3(ASRShiftKind shiftKind) => new(Arm64ShiftKind.ASR);

    public static implicit operator Arm64ShiftKind3(Arm64ShiftKind shiftKind) => new(shiftKind);

    public void Deconstruct(out Arm64ShiftKind shiftKind)
    {
        shiftKind = this.ShiftKind;
    }
}

/// <summary>
/// A shift type that supports all shift types.
/// </summary>
/// <param name="ShiftKind">The shift type.</param>
public readonly record struct Arm64ShiftKind4(Arm64ShiftKind ShiftKind) : IArm64ShiftKind
{
    public override string ToString() => this.ToText();

    public static implicit operator Arm64ShiftKind4(LSLShiftKind shiftKind) => new(Arm64ShiftKind.LSL);
    public static implicit operator Arm64ShiftKind4(LSRShiftKind shiftKind) => new(Arm64ShiftKind.LSR);
    public static implicit operator Arm64ShiftKind4(ASRShiftKind shiftKind) => new(Arm64ShiftKind.ASR);
    public static implicit operator Arm64ShiftKind4(RORShiftKind shiftKind) => new(Arm64ShiftKind.ROR);
    public static implicit operator Arm64ShiftKind4(Arm64ShiftKind shiftKind) => new(shiftKind);

    public void Deconstruct(out Arm64ShiftKind shiftKind)
    {
        shiftKind = this.ShiftKind;
    }
}

partial class Arm64Factory
{
    public static LSLShiftKind LSL => default;

    public static LSRShiftKind LSR => default;

    public static ASRShiftKind ASR => default;

    public static RORShiftKind ROR => default;

    public static MSLShiftKind MSL => default;

    public const Arm64FixedShiftKind LSL0 = Arm64FixedShiftKind.LSL0;

    public const Arm64FixedShiftKind LSL12 = Arm64FixedShiftKind.LSL12;
}
