// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Receives debug-map entries emitted by an <see cref="Arm64Assembler"/>.
/// </summary>
public interface IArm64AssemblerDebugMap
{
    /// <summary>
    /// Gets the entries recorded so far.
    /// </summary>
    IReadOnlyList<Arm64AssemblerDebugLineInfo> Entries { get; }

    /// <summary>
    /// Logs a debug-map entry.
    /// </summary>
    /// <param name="info">The entry to log.</param>
    void LogDebugInfo(Arm64AssemblerDebugLineInfo info);

    /// <summary>
    /// Clears all recorded debug-map entries.
    /// </summary>
    void Clear();
}
