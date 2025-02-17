// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// A shift type that supports all shift types.
/// </summary>
/// <param name="ShiftKind">The shift type.</param>
public readonly record struct Arm64ShiftKind4(Arm64ShiftKind ShiftKind) : IArm64ShiftKind
{
    /// <inheritdoc />
    public override string ToString() => this.ShiftToText();

    /// <summary>
    /// Converts an <see cref="IArm64ShiftKind.LSL"/> to an <see cref="Arm64ShiftKind4"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.LSL shiftKind) => new(Arm64ShiftKind.LSL);
    /// <summary>
    /// Converts an <see cref="IArm64ShiftKind.LSR"/> to an <see cref="Arm64ShiftKind4"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.LSR shiftKind) => new(Arm64ShiftKind.LSR);
    /// <summary>
    /// Converts an <see cref="IArm64ShiftKind.ASR"/> to an <see cref="Arm64ShiftKind4"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.ASR shiftKind) => new(Arm64ShiftKind.ASR);
    /// <summary>
    /// Converts an <see cref="IArm64ShiftKind.ROR"/> to an <see cref="Arm64ShiftKind4"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind4(IArm64ShiftKind.ROR shiftKind) => new(Arm64ShiftKind.ROR);
    /// <summary>
    /// Converts an <see cref="IArm64ShiftKind.MSL"/> to an <see cref="Arm64ShiftKind4"/>.
    /// </summary>
    public static implicit operator Arm64ShiftKind4(Arm64ShiftKind shiftKind) => new(shiftKind);
}