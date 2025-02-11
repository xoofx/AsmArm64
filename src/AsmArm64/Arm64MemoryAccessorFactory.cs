// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

static partial class Arm64Factory
{
    /// <summary>
    /// Gets a factory for creating ARM64 memory accessors.
    /// </summary>
    public static Arm64MemoryAccessorFactory _ => new();
}

/// <summary>
/// Represents a factory for creating ARM64 memory accessors.
/// </summary>
public struct Arm64MemoryAccessorFactory
{
    /// <summary>
    /// Gets an accessor for the specified base register.
    /// </summary>
    /// <param name="baseRegister">The base register.</param>
    /// <returns>An accessor for the specified base register.</returns>
    public Arm64BaseMemoryAccessor this[Arm64RegisterXOrSP baseRegister] => new(baseRegister);

    /// <summary>
    /// Gets an accessor for the specified base register.
    /// </summary>
    /// <param name="baseRegister">The base register.</param>
    /// <returns>An accessor for the specified base register.</returns>
    public Arm64BaseXMemoryAccessor this[Arm64RegisterX baseRegister] => new(baseRegister);

    /// <summary>
    /// Gets an accessor for the specified base register and immediate offset.
    /// </summary>
    /// <param name="baseRegister">The base register.</param>
    /// <param name="immediate">The immediate offset.</param>
    /// <returns>An accessor for the specified base register and immediate offset.</returns>
    public Arm64ImmediateMemoryAccessor this[Arm64RegisterXOrSP baseRegister, int immediate] => new(baseRegister, immediate);

    /// <summary>
    /// Gets an accessor for the specified base register, index register, and extend operation.
    /// </summary>
    /// <param name="baseRegister">The base register.</param>
    /// <param name="indexRegister">The index register.</param>
    /// <param name="extend">The extend operation.</param>
    /// <param name="amount">The amount to extend.</param>
    /// <returns>An accessor for the specified base register, index register, and extend operation.</returns>
    public Arm64RegisterXExtendMemoryAccessor this[Arm64RegisterXOrSP baseRegister, Arm64RegisterX indexRegister, Arm64ExtendXKind extend = default, byte? amount = null]
        => new(baseRegister, indexRegister,
            amount.HasValue
                ? amount.Value == 0
                    ? new(extend.ExtendKind, true)
                    : new(extend.ExtendKind, amount.Value)
                : new(extend.ExtendKind, false));

    /// <summary>
    /// Gets an accessor for the specified base register, index register, and extend operation.
    /// </summary>
    /// <param name="baseRegister">The base register.</param>
    /// <param name="indexRegister">The index register.</param>
    /// <param name="extend">The extend operation.</param>
    /// <param name="amount">The amount to extend.</param>
    /// <returns>An accessor for the specified base register, index register, and extend operation.</returns>
    public Arm64RegisterWExtendMemoryAccessor this[Arm64RegisterXOrSP baseRegister, Arm64RegisterW indexRegister, Arm64MemoryExtendWKind extend = default, byte? amount = null]
        => new(baseRegister, indexRegister,
            amount.HasValue
                ? amount.Value == 0
                    ? new(extend.ExtendKind, true)
                    : new(extend.ExtendKind, amount.Value)
                : new(extend.ExtendKind, false));
}