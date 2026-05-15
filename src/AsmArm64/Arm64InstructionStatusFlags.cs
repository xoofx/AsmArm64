// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Architectural ARM64 condition/status flags.
/// </summary>
[Flags]
public enum Arm64StatusFlags : byte
{
    /// <summary>
    /// No status flags.
    /// </summary>
    None = 0,

    /// <summary>
    /// Negative condition flag.
    /// </summary>
    N = 1 << 0,

    /// <summary>
    /// Zero condition flag.
    /// </summary>
    Z = 1 << 1,

    /// <summary>
    /// Carry condition flag.
    /// </summary>
    C = 1 << 2,

    /// <summary>
    /// Overflow condition flag.
    /// </summary>
    V = 1 << 3,

    /// <summary>
    /// All condition flags.
    /// </summary>
    NZCV = N | Z | C | V,
}

/// <summary>
/// Describes status flags read and written by an ARM64 instruction.
/// </summary>
/// <param name="Read">The status flags whose current values can affect instruction behavior.</param>
/// <param name="Written">The status flags updated by the instruction.</param>
public readonly record struct Arm64StatusFlagAccess(Arm64StatusFlags Read, Arm64StatusFlags Written)
{
    /// <summary>
    /// Gets a value indicating whether any status flag is read.
    /// </summary>
    public bool ReadsAny => Read != Arm64StatusFlags.None;

    /// <summary>
    /// Gets a value indicating whether any status flag is written.
    /// </summary>
    public bool WritesAny => Written != Arm64StatusFlags.None;

    /// <summary>
    /// Gets a value indicating whether any of the specified status flags is read.
    /// </summary>
    /// <param name="flags">The flags to test.</param>
    /// <returns><c>true</c> if any of <paramref name="flags"/> is read.</returns>
    public bool Reads(Arm64StatusFlags flags) => (Read & flags) != 0;

    /// <summary>
    /// Gets a value indicating whether any of the specified status flags is written.
    /// </summary>
    /// <param name="flags">The flags to test.</param>
    /// <returns><c>true</c> if any of <paramref name="flags"/> is written.</returns>
    public bool Writes(Arm64StatusFlags flags) => (Written & flags) != 0;
}

/// <summary>
/// Provides metadata about ARM64 instructions.
/// </summary>
public static class Arm64InstructionMetadata
{
    /// <summary>
    /// Gets the status flag access metadata for an instruction id.
    /// </summary>
    /// <param name="id">The instruction id.</param>
    /// <returns>The status flags read and written by the instruction.</returns>
    public static Arm64StatusFlagAccess GetStatusFlagAccess(Arm64InstructionId id)
    {
        var index = (uint)id;
        if (index >= Arm64InstructionStatusFlagsTable.Data.Length)
        {
            return default;
        }

        var value = Arm64InstructionStatusFlagsTable.Data[(int)index];
        return new((Arm64StatusFlags)(value & 0xF), (Arm64StatusFlags)(value >> 4));
    }
}

/// <summary>
/// Extension methods for <see cref="Arm64InstructionId"/>.
/// </summary>
public static class Arm64InstructionIdExtensions
{
    /// <summary>
    /// Gets the status flags read by the instruction id.
    /// </summary>
    /// <param name="id">The instruction id.</param>
    /// <returns>The status flags read by the instruction id.</returns>
    public static Arm64StatusFlags GetReadStatusFlags(this Arm64InstructionId id)
        => Arm64InstructionMetadata.GetStatusFlagAccess(id).Read;

    /// <summary>
    /// Gets the status flags written by the instruction id.
    /// </summary>
    /// <param name="id">The instruction id.</param>
    /// <returns>The status flags written by the instruction id.</returns>
    public static Arm64StatusFlags GetWrittenStatusFlags(this Arm64InstructionId id)
        => Arm64InstructionMetadata.GetStatusFlagAccess(id).Written;

    /// <summary>
    /// Gets the status flag access metadata for the instruction id.
    /// </summary>
    /// <param name="id">The instruction id.</param>
    /// <returns>The status flags read and written by the instruction id.</returns>
    public static Arm64StatusFlagAccess GetStatusFlagAccess(this Arm64InstructionId id)
        => Arm64InstructionMetadata.GetStatusFlagAccess(id);
}
