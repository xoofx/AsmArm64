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
        //entry.LeftShift = (byte)trieNode.LeftShift;
        //entry.BitMaskCount = (byte)trieNode.BitMaskCount;
        entry.ArrayLength = (ushort)trieNode.DecoderArrayLength;

        var offsetElseBranch = _offset;
        if (entry.HasElseBranch)
        {
            Append(new EntryIndex());
        }

        // Prepare buffers
        var offset = _offset;
        switch (trieNode.TableKind)
        {
            case TrieTableKind.Hash:
                //entry.HashMultiplier = trie.HashMultiplier;
                Append(trieNode.HashMultiplier);
                offset = _offset;
                for (int i = 0; i < entry.ArrayLength; i++)
                {
                    Append(new KeyEntryIndex());
                }

                break;
            case TrieTableKind.SmallArray:
                for (int i = 0; i < entry.ArrayLength; i++)
                {
                    Append(new KeyEntryIndex());
                }

                break;
            case TrieTableKind.ArrayDirectIndex:
                for (int i = 0; i < entry.ArrayLength; i++)
                {
                    Append(new EntryIndex());
                }

                break;
        }

        var keys = trieNode.MaskToSubDecoder.Keys.Order().ToArray();

        // Fill entries in the table
        switch (trieNode.TableKind)
        {
            case TrieTableKind.Hash:
                foreach (var key in keys)
                {
                    var index = (int)(((uint)key * trieNode.HashMultiplier) % entry.ArrayLength);
                    Unsafe.Add(ref Unsafe.As<byte, KeyEntryIndex>(ref _buffer[offset]), index) = new KeyEntryIndex((uint)key, Encode(trieNode.MaskToSubDecoder[key]));
                }

                break;
            case TrieTableKind.SmallArray:
                Debug.Assert(keys.Length == entry.ArrayLength);
                for (int i = 0; i < keys.Length; i++)
                {
                    var key = keys[i];
                    Unsafe.Add(ref Unsafe.As<byte, KeyEntryIndex>(ref _buffer[offset]), i) = new KeyEntryIndex((uint)key, Encode(trieNode.MaskToSubDecoder[key]));
                }

                break;
            case TrieTableKind.ArrayDirectIndex:
                foreach (var key in keys)
                {
                    Unsafe.Add(ref Unsafe.As<byte, EntryIndex>(ref _buffer[offset]), key) = Encode(trieNode.MaskToSubDecoder[key]);
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
        private byte _shiftAndTrieTableKind;
        private byte _bitmaskCountAndHasElseBranch;
        private ushort _arrayLength;

        public TrieTableKind TrieTableKind
        {
            get => (TrieTableKind)(_shiftAndTrieTableKind & 0b_11);
            set { _shiftAndTrieTableKind = (byte)((_shiftAndTrieTableKind & 0b_1111_1100) | (byte)value); }
        }

        public byte LeftShift
        {
            get => (byte)(_shiftAndTrieTableKind >> 2);

            set
            {
                Debug.Assert(value <= 32);
                _shiftAndTrieTableKind = (byte)((_shiftAndTrieTableKind & 0b_11) | (value << 2));
            }
        }

        public bool HasElseBranch
        {
            get => (_bitmaskCountAndHasElseBranch & 1) != 0;

            set { _bitmaskCountAndHasElseBranch = (byte)((_bitmaskCountAndHasElseBranch & 0b_1111_1110) | (value ? 1 : 0)); }
        }

        public byte BitMaskCount
        {
            get => (byte)(_bitmaskCountAndHasElseBranch >> 1);
            set
            {
                Debug.Assert(value <= 32);
                _bitmaskCountAndHasElseBranch = (byte)((_bitmaskCountAndHasElseBranch & 1) | (value << 1));
            }
        }

        public ushort ArrayLength
        {
            get => _arrayLength;
            set => _arrayLength = value;
        }

        //public ulong HashMultiplier; // Hash multiplier
        //public EntryIndex ElseIndex; // Else index (null if no else)

        // Hashtable or small array
        //public KeyEntryIndex[] Array; // ArrayLength

        // Array Direct Index
        //public EntryIndex[] Indices;  // ArrayLength
    }

    // Value:
    // if 0x8000_0000 is set, Arm64InstructionId
    // if 0x0000_0000 is set, Offset to header
    public readonly record struct EntryIndex(uint Value);

    public readonly record struct KeyEntryIndex(uint Key, EntryIndex Index);
}