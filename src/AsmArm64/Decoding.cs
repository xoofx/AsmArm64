// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public struct Entry
{
    // Header
    public byte Shift;  // 0b_00xx_xxxx Hash, 0b_01xx_xxxx Small Array, 0b_10xx_xxxx Array Direct Index
    public byte BitMaskCount;
    public ushort ArrayLength;
    public EntryIndex ElseIndex; // Else index (null if no else)

    // Hashtable or small array
    public KeyEntryIndex[] Array; // ArrayLength

    // Array Direct Index
    public EntryIndex[] Indices;  // ArrayLength

    // Value:
    // if 0x8000_0000 is set, Arm64InstructionId
    // if 0x0000_0000 is set, Offset to header
    public readonly record struct EntryIndex(uint Value);

    public readonly record struct KeyEntryIndex(uint Key, EntryIndex Index);
}