// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the extend kind for with the register <see cref="Arm64RegisterX"/>.
/// </summary>
public readonly record struct Arm64ExtendXKind : IArm64ExtendKind
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ExtendXKind"/> struct.
    /// </summary>
    /// <param name="extendKind">The kind of the extend.</param>
    private Arm64ExtendXKind(Arm64ExtendKind extendKind)
    {
        ExtendKind = extendKind;
    }

    /// <summary>
    /// Gets the kind of the extend.
    /// </summary>
    public Arm64ExtendKind ExtendKind { get; }

    /// <inheritdoc />
    public override string ToString() => this.ExtendToText();

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.UXTB"/> to <see cref="Arm64ExtendXKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendXKind(IArm64ShiftKind.LSL shiftKindAsExtendKind) => new(Arm64ExtendKind.LSL);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.UXTX"/> to <see cref="Arm64ExtendXKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendXKind(IArm64ExtendKind.LSL extendKind) => new(Arm64ExtendKind.LSL);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.UXTB"/> to <see cref="Arm64ExtendXKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendXKind(IArm64ExtendKind.UXTX extendKind) => new(Arm64ExtendKind.UXTX);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.SXTB"/> to <see cref="Arm64ExtendXKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendXKind(IArm64ExtendKind.SXTX extendKind) => new(Arm64ExtendKind.SXTX);
}
