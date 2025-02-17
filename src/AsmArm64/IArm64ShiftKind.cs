// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Defines the type of shift for an ARM64 instruction.
/// </summary>
public interface IArm64ShiftKind
{
    /// <summary>
    /// Gets the kind of shift.
    /// </summary>
    Arm64ShiftKind ShiftKind { get; }

    /// <summary>
    /// The LSL shift kind.
    /// </summary>
    public struct LSL : IArm64ShiftKind
    {
        /// <inheritdoc />
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.LSL;

        /// <inheritdoc />
        public override string ToString() => this.ShiftToText();

        /// <summary>
        /// Implicit conversion to <see cref="Arm64ShiftKind"/>.
        /// </summary>
        public static implicit operator Arm64ExtendKind(LSL shiftKind) => Arm64ExtendKind.LSL;

        /// <summary>
        /// Implicit conversion to this type.
        /// </summary>
        /// <param name="shiftKind"></param>
        public static implicit operator LSL(IArm64ExtendKind.LSL shiftKind) => new();
    }

    /// <summary>
    /// The LSR shift kind.
    /// </summary>
    public struct LSR : IArm64ShiftKind
    {
        /// <inheritdoc />
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.LSR;

        /// <inheritdoc />
        public override string ToString() => this.ShiftToText();
    }

    /// <summary>
    /// The ASR shift kind.
    /// </summary>
    public struct ASR : IArm64ShiftKind
    {
        /// <inheritdoc />
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.ASR;

        /// <inheritdoc />
        public override string ToString() => this.ShiftToText();
    }

    /// <summary>
    /// The ROR shift kind.
    /// </summary>
    public struct ROR : IArm64ShiftKind
    {
        /// <inheritdoc />
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.ROR;

        /// <inheritdoc />
        public override string ToString() => this.ShiftToText();
    }

    /// <summary>
    /// The MSL shift kind.
    /// </summary>
    public struct MSL : IArm64ShiftKind
    {
        /// <inheritdoc />
        public Arm64ShiftKind ShiftKind => Arm64ShiftKind.MSL;

        /// <inheritdoc />
        public override string ToString() => this.ShiftToText();
    }
}