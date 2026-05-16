// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a block of ARM64 code or data to arrange in an assembler buffer.
/// </summary>
public sealed class Arm64Block
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Block"/> class.
    /// </summary>
    /// <param name="label">The label bound to the start of the block.</param>
    /// <param name="buffer">The block bytes.</param>
    /// <param name="alignment">The block alignment in bytes.</param>
    /// <param name="address">An optional fixed absolute address.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="label"/> or <paramref name="buffer"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="alignment"/> is zero.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="alignment"/> is not a power of two.</exception>
    public Arm64Block(Arm64Label label, byte[] buffer, uint alignment = 1, ulong? address = null)
    {
        ArgumentNullException.ThrowIfNull(label);
        ArgumentNullException.ThrowIfNull(buffer);
        if (alignment == 0) throw new ArgumentOutOfRangeException(nameof(alignment), "Alignment must be greater than zero.");
        if ((alignment & (alignment - 1)) != 0) throw new ArgumentException("Alignment must be a power of two.", nameof(alignment));
        Label = label;
        Buffer = buffer;
        Alignment = alignment;
        Address = address;
    }

    /// <summary>
    /// Gets the label bound to the start of the block.
    /// </summary>
    public Arm64Label Label { get; }

    /// <summary>
    /// Gets the block bytes.
    /// </summary>
    public byte[] Buffer { get; }

    /// <summary>
    /// Gets the required alignment in bytes.
    /// </summary>
    public uint Alignment { get; }

    /// <summary>
    /// Gets the fixed absolute address, or <c>null</c> for a floating block.
    /// </summary>
    public ulong? Address { get; }
}
