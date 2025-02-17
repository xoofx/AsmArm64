// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// A shift type that supports only LSL, LSR, ASR.
/// </summary>
public readonly record struct Arm64ShiftKind3 : IArm64ShiftKind
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ShiftKind3"/> struct.
    /// </summary>
    /// <param name="shiftType">The shift type.</param>
    /// <exception cref="ArgumentException">Thrown when the shift type is ROR.</exception>
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

    /// <summary>
    /// Converts a LSL shift kind to an <see cref="Arm64ShiftKind3"/>.
    /// </summary>

    public static implicit operator Arm64ShiftKind3(IArm64ShiftKind.LSL shiftKind) => new(Arm64ShiftKind.LSL);

    /// <summary>
    /// Converts a LSR shift kind to an <see cref="Arm64ShiftKind3"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind3(IArm64ShiftKind.LSR shiftKind) => new(Arm64ShiftKind.LSR);

    /// <summary>
    /// Converts a ASR shift kind to an <see cref="Arm64ShiftKind3"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind3(IArm64ShiftKind.ASR shiftKind) => new(Arm64ShiftKind.ASR);

    /// <summary>
    /// Converts a shift kind to an <see cref="Arm64ShiftKind3"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind3(Arm64ShiftKind shiftKind) => new(shiftKind);
}