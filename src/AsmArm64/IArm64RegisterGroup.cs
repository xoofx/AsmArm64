// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public interface IArm64RegisterGroup : ISpanFormattable
{
    /// <summary>
    /// Gets the base register of this group
    /// </summary>
    Arm64RegisterAny BaseRegister { get; }
    
    /// <summary>
    /// Gets the number of registers in this group (from 1 to 4)
    /// </summary>
    int Count { get; }
    
    /// <summary>
    /// Converts this register to an any register group.
    /// </summary>
    /// <returns>An any register group.</returns>
    Arm64RegisterGroupAny ToAny();

    /// <summary>
    /// Gets whether this group has an indexer. (e.g. {v0.S, v1.S, v2.S}[1])
    /// </summary>
    public bool HasGroupIndex { get; }

    /// <summary>
    /// Gets the group indexer if <see cref="HasGroupIndex"/> is true.
    /// </summary>
    public int GroupIndex { get; }
}