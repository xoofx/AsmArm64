// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64.CodeGen;

class TableGenEncoder
{
    private byte[] _buffer;
    private uint _offset;

    public TableGenEncoder()
    {
        _buffer = new byte[256 * 1024];
    }

    public ReadOnlySpan<byte> Buffer => _buffer.AsSpan(0, (int)_offset);
    
    public EntryIndex Encode(InstructionTrieNode trieNode)
    {
        if (trieNode.IsTerminal)
        {
            return GetTerminalEntryIndex(trieNode);
        }

        var entryPosition = _offset;

        ref var entry = ref Append(new EntryHeader());
        entry.TrieTableKind = trieNode.TableKind;
        entry.HasElseBranch = trieNode.ElseBranch is not null;
        entry.BitMask = trieNode.BitMask;
        entry.Shift = (byte)trieNode.RightShift;
        entry.ArrayLength = (ushort)trieNode.EncoderArrayLength;

        var offsetElseBranch = _offset;
        if (entry.HasElseBranch)
        {
            Append(new EntryIndex());
        }

        if (trieNode.TableKind == TrieTableKind.Hash)
        {
            Append(trieNode.HashMultiplier);
        }

        var offset = _offset;
        for (int i = 0; i < entry.ArrayLength; i++)
        {
            Append(new KeyEntryIndex());
        }

        var keys = trieNode.MaskToSubEncoder.Keys.Order().ToArray();

        // Fill entries in the table
        switch (trieNode.TableKind)
        {
            case TrieTableKind.Hash:
                foreach (var key in keys)
                {
                    var index = (int)(((uint)(key >> trieNode.RightShift) * trieNode.HashMultiplier) % entry.ArrayLength);
                    Unsafe.Add(ref Unsafe.As<byte, KeyEntryIndex>(ref _buffer[offset]), index) = new KeyEntryIndex((uint)key, Encode(trieNode.MaskToSubEncoder[key]));
                }

                break;
            case TrieTableKind.SmallArray:
                Debug.Assert(keys.Length == entry.ArrayLength);
                for (int i = 0; i < keys.Length; i++)
                {
                    var key = keys[i];
                    Unsafe.Add(ref Unsafe.As<byte, KeyEntryIndex>(ref _buffer[offset]), i) = new KeyEntryIndex((uint)key, Encode(trieNode.MaskToSubEncoder[key]));
                }

                break;
        }

        if (entry.HasElseBranch)
        {
            Unsafe.As<byte, EntryIndex>(ref _buffer[offsetElseBranch]) = Encode(trieNode.ElseBranch!);
        }

        return new EntryIndex(entryPosition);
    }

    private ref T Append<T>(T data) where T : unmanaged
    {
        if (_offset + Unsafe.SizeOf<T>() > _buffer.Length)
        {
            Array.Resize(ref _buffer, _buffer.Length * 2);
        }

        ref T pData = ref Unsafe.As<byte, T>(ref _buffer[_offset]);
        Unsafe.WriteUnaligned(ref _buffer[_offset], data);
        _offset += (uint)Unsafe.SizeOf<T>();
        return ref pData;
    }

    private EntryIndex GetTerminalEntryIndex(InstructionTrieNode trieNode)
    {
        Debug.Assert(trieNode.IsTerminal);
        var index = (uint)(trieNode.InstructionIndices[0] + 1);
        return new EntryIndex(index | 0x8000_0000U);
    }

    public struct EntryHeader
    {
        private uint _mask;
        private byte _shift;
        private byte _kindAndHasElseBranch;
        private ushort _arrayLength;

        public TrieTableKind TrieTableKind
        {
            get => (TrieTableKind)(_kindAndHasElseBranch & 0b_11);
            set { _kindAndHasElseBranch = (byte)((_kindAndHasElseBranch & 0b_1111_1100) | (byte)value); }
        }

        public bool HasElseBranch
        {
            get => (_kindAndHasElseBranch & 0b_1000_0000) != 0;
            set { _kindAndHasElseBranch = (byte)((_kindAndHasElseBranch & 0b_0111_1111) | (value ? 0b_1000_0000 : 0)); }
        }

        public byte Shift
        {
            get => _shift;
            set => _shift = value;
        }
        
        public uint BitMask
        {
            get => _mask;
            set => _mask = value;
        }
        

        public ushort ArrayLength
        {
            get => _arrayLength;
            set => _arrayLength = value;
        }

        //public EntryIndex ElseIndex; // Else index (null if no else)

        // Hashtable or small array
        //public ulong HashMultiplier; // Hash multiplier
        //public KeyEntryIndex[] Array; // ArrayLength
    }

    // Value:
    // if 0x8000_0000 is set, Arm64InstructionId
    // if 0x0000_0000 is set, Offset to header
    public readonly record struct EntryIndex(uint Value);

    public readonly record struct KeyEntryIndex(uint Key, EntryIndex Index);
}