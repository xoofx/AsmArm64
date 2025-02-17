// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the extend kind for memory addressing with a <see cref="Arm64RegisterW"/>.
/// </summary>
public readonly record struct Arm64MemoryExtendWKind : IArm64ExtendKind
{
    private Arm64MemoryExtendWKind(Arm64ExtendKind extendKind)
    {
        ExtendKind = extendKind;
    }

    /// <summary>
    /// Gets the kind of the extend operation.
    /// </summary>
    public Arm64ExtendKind ExtendKind { get; }

    /// <inheritdoc />
    public override string ToString() => this.ExtendToText();

    /// <summary>
    /// Implicitly converts an <see cref="IArm64ExtendKind.UXTW"/> to an <see cref="Arm64MemoryExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64MemoryExtendWKind(IArm64ExtendKind.UXTW extendKind) => new(Arm64ExtendKind.UXTW);

    /// <summary>
    /// Implicitly converts an <see cref="IArm64ExtendKind.SXTW"/> to an <see cref="Arm64MemoryExtendWKind"/>.
    /// </summary>
    public static implicit operator Arm64MemoryExtendWKind(IArm64ExtendKind.SXTW extendKind) => new(Arm64ExtendKind.SXTW);
}