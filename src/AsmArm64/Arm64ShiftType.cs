// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the type of shift for an ARM64 instruction.
/// </summary>
public enum Arm64ShiftType : byte
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
}

/// <summary>
/// Defines the type for a fixed shift of an ARM64 instruction.
/// </summary>
public enum Arm64FixedShiftType : byte
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

public interface IArm64ShiftType
{
    Arm64ShiftType ShiftType { get; }
}

public struct LSLShiftType : IArm64ShiftType
{
    public Arm64ShiftType ShiftType => Arm64ShiftType.LSL;

    public override string ToString() => this.ToText();
}

public struct LSRShiftType : IArm64ShiftType
{
    public Arm64ShiftType ShiftType => Arm64ShiftType.LSR;

    public override string ToString() => this.ToText();
}

public struct ASRShiftType : IArm64ShiftType
{
    public Arm64ShiftType ShiftType => Arm64ShiftType.ASR;

    public override string ToString() => this.ToText();
}

public struct RORShiftType : IArm64ShiftType
{
    public Arm64ShiftType ShiftType => Arm64ShiftType.ROR;

    public override string ToString() => this.ToText();
}


/// <summary>
/// A shift type that supports only LSL, LSR, ASR.
/// </summary>
public readonly record struct Arm64ShiftType3 : IArm64ShiftType
{
    public Arm64ShiftType3(Arm64ShiftType shiftType)
    {
        if (shiftType == Arm64ShiftType.ROR) throw new ArgumentException("Invalid shift type ROR not supported", nameof(shiftType));
        this.ShiftType = shiftType;
    }

    /// <summary>
    /// Gets the shift type.
    /// </summary>
    public Arm64ShiftType ShiftType { get; }

    /// <inheritdoc />
    public override string ToString() => this.ToText();
    
    public static implicit operator Arm64ShiftType3(LSLShiftType shiftType) => new(Arm64ShiftType.LSL);

    public static implicit operator Arm64ShiftType3(LSRShiftType shiftType) => new(Arm64ShiftType.LSR);

    public static implicit operator Arm64ShiftType3(ASRShiftType shiftType) => new(Arm64ShiftType.ASR);

    public static implicit operator Arm64ShiftType3(Arm64ShiftType shiftType) => new(shiftType);

    public void Deconstruct(out Arm64ShiftType shiftType)
    {
        shiftType = this.ShiftType;
    }
}

/// <summary>
/// A shift type that supports all shift types.
/// </summary>
/// <param name="ShiftType">The shift type.</param>
public readonly record struct Arm64ShiftType4(Arm64ShiftType ShiftType) : IArm64ShiftType
{
    public override string ToString() => this.ToText();

    public static implicit operator Arm64ShiftType4(LSLShiftType shiftType) => new(Arm64ShiftType.LSL);
    public static implicit operator Arm64ShiftType4(LSRShiftType shiftType) => new(Arm64ShiftType.LSR);
    public static implicit operator Arm64ShiftType4(ASRShiftType shiftType) => new(Arm64ShiftType.ASR);
    public static implicit operator Arm64ShiftType4(RORShiftType shiftType) => new(Arm64ShiftType.ROR);
    public static implicit operator Arm64ShiftType4(Arm64ShiftType shiftType) => new(shiftType);

    public void Deconstruct(out Arm64ShiftType shiftType)
    {
        shiftType = this.ShiftType;
    }
}

partial class Arm64Factory
{
    public static LSLShiftType LSL => default;

    public static LSRShiftType LSR => default;

    public static ASRShiftType ASR => default;

    public static RORShiftType ROR => default;

    public const Arm64FixedShiftType LSL0 = Arm64FixedShiftType.LSL0;

    public const Arm64FixedShiftType LSL12 = Arm64FixedShiftType.LSL12;
}
