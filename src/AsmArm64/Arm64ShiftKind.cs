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

public interface IArm64ShiftKind
{
    Arm64ShiftKind ShiftKind { get; }

    public struct LSL : IArm64ShiftKind
    {
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.LSL;

        public override string ToString() => this.ShiftToText();

        public static implicit operator Arm64ExtendKind(LSL shiftKind) => Arm64ExtendKind.LSL;

        public static implicit operator LSL(IArm64ExtendKind.LSL shiftKind) => new();
    }

    public struct LSR : IArm64ShiftKind
    {
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.LSR;

        public override string ToString() => this.ShiftToText();
    }

    public struct ASR : IArm64ShiftKind
    {
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.ASR;

        public override string ToString() => this.ShiftToText();
    }

    public struct ROR : IArm64ShiftKind
    {
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.ROR;

        public override string ToString() => this.ShiftToText();
    }

    public struct MSL : IArm64ShiftKind
    {
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.MSL;

        public override string ToString() => this.ShiftToText();
    }
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
    public override string ToString() => this.ShiftToText();
    
    public static implicit operator Arm64ShiftKind3(IArm64ShiftKind.LSL shiftKind) => new(Arm64ShiftKind.LSL);

    public static implicit operator Arm64ShiftKind3(IArm64ShiftKind.LSR shiftKind) => new(Arm64ShiftKind.LSR);

    public static implicit operator Arm64ShiftKind3(IArm64ShiftKind.ASR shiftKind) => new(Arm64ShiftKind.ASR);

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
    public override string ToString() => this.ShiftToText();

    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.LSL shiftKind) => new(Arm64ShiftKind.LSL);
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.LSR shiftKind) => new(Arm64ShiftKind.LSR);
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.ASR shiftKind) => new(Arm64ShiftKind.ASR);
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.ROR shiftKind) => new(Arm64ShiftKind.ROR);
    public static implicit operator Arm64ShiftKind4(Arm64ShiftKind shiftKind) => new(shiftKind);

    public void Deconstruct(out Arm64ShiftKind shiftKind)
    {
        shiftKind = this.ShiftKind;
    }
}

partial class Arm64Factory
{
    public static IArm64ShiftKind.LSL _LSL => default;

    public static IArm64ShiftKind.LSR _LSR => default;

    public static IArm64ShiftKind.ASR _ASR => default;

    public static IArm64ShiftKind.ROR _ROR => default;

    public static IArm64ShiftKind.MSL _MSL => default;
}
