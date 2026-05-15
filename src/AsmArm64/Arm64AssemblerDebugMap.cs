// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace AsmArm64;

/// <summary>
/// Default in-memory assembler debug map.
/// </summary>
public sealed class Arm64AssemblerDebugMap : IArm64AssemblerDebugMap
{
    private readonly List<Arm64AssemblerDebugLineInfo> _entries = new();

    /// <inheritdoc />
    public IReadOnlyList<Arm64AssemblerDebugLineInfo> Entries => _entries;

    /// <inheritdoc />
    public void LogDebugInfo(Arm64AssemblerDebugLineInfo info) => _entries.Add(info);

    /// <inheritdoc />
    public void Clear() => _entries.Clear();

    /// <summary>
    /// Finds the most recent debug-map entry at the specified offset.
    /// </summary>
    /// <param name="offset">The byte offset to search for.</param>
    /// <returns>The matching entry, or <c>null</c> if no entry exists for the offset.</returns>
    public Arm64AssemblerDebugLineInfo? FindByOffset(uint offset)
    {
        for (var i = _entries.Count - 1; i >= 0; i--)
        {
            var entry = _entries[i];
            if (entry.Offset == offset) return entry;
        }

        return null;
    }

    /// <summary>
    /// Finds the most recent debug-map entry at the specified address.
    /// </summary>
    /// <param name="address">The address to search for.</param>
    /// <returns>The matching entry, or <c>null</c> if no entry exists for the address.</returns>
    public Arm64AssemblerDebugLineInfo? FindByAddress(ulong address)
    {
        for (var i = _entries.Count - 1; i >= 0; i--)
        {
            var entry = _entries[i];
            if (entry.Address == address) return entry;
        }

        return null;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var builder = new StringBuilder();
        foreach (var entry in _entries)
        {
            if (builder.Length != 0) builder.AppendLine();
            builder.Append($"0x{entry.Address:X16} (+0x{entry.Offset:X}): {entry.Kind}");
            if (entry.InstructionId != Arm64InstructionId.Invalid) builder.Append($" {entry.InstructionId}");
            if (!string.IsNullOrEmpty(entry.Name)) builder.Append($" {entry.Name}");
            if (!string.IsNullOrEmpty(entry.FilePath)) builder.Append($" at {entry.FilePath}:{entry.LineNumber}");
        }

        return builder.ToString();
    }
}
