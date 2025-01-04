// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EntryIndex = int;

namespace AsmArm64;

/// <summary>
/// Encoded instruction table for ARM64.
/// </summary>
public class Arm64Instruction
{
    public static unsafe Arm64InstructionId DecodeId(Arm64RawInstruction instruction)
    {
        ref byte buffer = ref MemoryMarshal.GetReference(Arm64InstructionDecoderTable.Buffer);

        int offset = 0;

        while (true)
        {
            nextHeader:
            ref var header = ref Unsafe.As<byte, EntryHeader>(ref Unsafe.Add(ref buffer, offset));

            var kind = header.TrieTableKind;
            var shift = header.Shift;
            var bitMask = header.BitMask;
            var hasElseBranch = header.HasElseBranch;
            var arrayLength = (uint)header.ArrayLength;

            offset += sizeof(EntryHeader);

            int elseBranchIndex = 0;
            if (hasElseBranch)
            {
                elseBranchIndex = Unsafe.As<byte, int>(ref Unsafe.Add(ref buffer, offset));
                offset += sizeof(int);
            }

            var key = instruction & bitMask;
            if (kind == TrieTableKind.SmallArray)
            {
                for(int i = 0; i < arrayLength; i++)
                {
                    ref var keyEntryIndex = ref Unsafe.As<byte, KeyEntryIndex>(ref Unsafe.Add(ref buffer, offset + i * sizeof(KeyEntryIndex)));
                    if (keyEntryIndex.Key == key)
                    {
                        offset = keyEntryIndex.Index;
                        if (offset < 0) goto return_offset;
                        if (offset > 0) goto nextHeader;
                        break;
                    }
                }
            }
            else
            {
                Debug.Assert(kind == TrieTableKind.Hash);
                var hashMultiplier = Unsafe.As<byte, ulong>(ref Unsafe.Add(ref buffer, offset));
                offset += sizeof(ulong);
                var index = (int)(((uint)(key >> shift) * hashMultiplier) % arrayLength);
                ref var keyEntryIndex = ref Unsafe.As<byte, KeyEntryIndex>(ref Unsafe.Add(ref buffer, offset + index * sizeof(KeyEntryIndex)));

                if (keyEntryIndex.Key == key)
                {
                    offset = keyEntryIndex.Index;
                    if (offset < 0) goto return_offset;
                    if (offset > 0) goto nextHeader;
                }
            }

            if (hasElseBranch)
            {
                offset = elseBranchIndex;

                if (offset < 0) goto return_offset;
                if (offset > 0) goto nextHeader;
            }

            break;
        }

        return Arm64InstructionId.Invalid;
    return_offset:
        return (Arm64InstructionId)(offset & ~0x8000_0000u);
    }

    private readonly struct EntryHeader
    {
        private readonly uint _mask;
        private readonly byte _shift;
        private readonly byte _kindAndHasElseBranch;
        private readonly ushort _arrayLength;

        public TrieTableKind TrieTableKind
        {
            get => (TrieTableKind)(_kindAndHasElseBranch & 0b_11);
        }

        public bool HasElseBranch
        {
            get => (_kindAndHasElseBranch & 0b_1000_0000) != 0;
        }

        public byte Shift
        {
            get => _shift;
        }

        public uint BitMask
        {
            get => _mask;
        }
        
        public ushort ArrayLength
        {
            get => _arrayLength;
        }

        //public EntryIndex ElseIndex; // Else index (null if no else)

        //public ulong HashMultiplier; // Hash multiplier

        // Hashtable or small array
        //public KeyEntryIndex[] Array; // ArrayLength

        // Array Direct Index
        //public EntryIndex[] Indices;  // ArrayLength
    }

    public readonly record struct KeyEntryIndex(uint Key, EntryIndex Index);
    
    enum TrieTableKind : byte
    {
        Hash = 0,
        SmallArray = 1,
        Terminal = 2
    }
}