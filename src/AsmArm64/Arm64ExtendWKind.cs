// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the extend kind for with the register <see cref="Arm64RegisterW"/>.
/// </summary>
public readonly record struct Arm64ExtendWKind : IArm64ExtendKind
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64ExtendWKind"/> struct.
    /// </summary>
    /// <param name="extendKind">The kind of the extend operation.</param>
    private Arm64ExtendWKind(Arm64ExtendKind extendKind)
    {
        ExtendKind = extendKind;
    }

    /// <summary>
    /// Gets the kind of the extend operation.
    /// </summary>
    public Arm64ExtendKind ExtendKind { get; }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() => this.ExtendToText();

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.UXTB"/> to <see cref="Arm64ExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.UXTB extendKind) => new(Arm64ExtendKind.UXTB);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.SXTB"/> to <see cref="Arm64ExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.SXTB extendKind) => new(Arm64ExtendKind.SXTB);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.UXTH"/> to <see cref="Arm64ExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.UXTH extendKind) => new(Arm64ExtendKind.UXTH);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.SXTH"/> to <see cref="Arm64ExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.SXTH extendKind) => new(Arm64ExtendKind.SXTH);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.UXTW"/> to <see cref="Arm64ExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.UXTW extendKind) => new(Arm64ExtendKind.UXTW);

    /// <summary>
    /// Performs an implicit conversion from <see cref="IArm64ExtendKind.SXTW"/> to <see cref="Arm64ExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.SXTW extendKind) => new(Arm64ExtendKind.SXTW);
}