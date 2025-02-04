// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Interface for accessing ARM64 memory.
/// </summary>
public interface IArm64MemoryAccessor : ISpanFormattable
{
    /// <summary>
    /// Gets the base register kind.
    /// </summary>
    Arm64MemoryBaseRegisterKind BaseRegisterKind { get; }

    /// <summary>
    /// Gets the offset kind.
    /// </summary>
    Arm64MemoryOffsetKind OffsetKind { get; }

    /// <summary>
    /// Gets the base register.
    /// </summary>
    Arm64RegisterAny BaseRegister { get; }

    /// <summary>
    /// Gets a value indicating whether the memory access is pre-increment.
    /// </summary>
    bool IsPreIncrement { get; }

    /// <summary>
    /// Gets a value indicating whether the memory access has an optional offset.
    /// </summary>
    bool HasOptionalOffset { get; }

    /// <summary>
    /// Gets a value indicating whether the memory access has an immediate value.
    /// </summary>
    bool HasImmediate { get; }

    /// <summary>
    /// Gets the immediate value.
    /// </summary>
    int Immediate { get; }

    /// <summary>
    /// Gets a value indicating whether the memory access has an index register.
    /// </summary>
    bool HasIndexRegister { get; }

    /// <summary>
    /// Gets the index register.
    /// </summary>
    Arm64RegisterAny IndexRegister { get; }

    /// <summary>
    /// Gets a value indicating whether the memory access has an extend.
    /// </summary>
    bool HasExtend { get; }

    /// <summary>
    /// Gets the memory extend.
    /// </summary>
    Arm64MemoryExtend Extend { get; }
}