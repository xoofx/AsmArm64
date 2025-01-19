// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

using EntryIndex = int;

/// <summary>
/// Encoded instruction table for ARM64.
/// </summary>
public readonly unsafe struct Arm64Instruction : ISpanFormattable
{
    internal readonly ulong Descriptor;
    internal readonly byte* OperandsPtr;
    internal readonly Arm64RawInstruction RawValue;

    private Arm64Instruction(ulong descriptor, byte* operandsPtr, Arm64RawInstruction rawValue)
    {
        // MemoryMarshal.Write(buffer, (ushort)IdIndex);
        // MemoryMarshal.Write(buffer.Slice(2), (ushort)MnemonicIndex);
        // buffer[4] = (byte)InstructionClassIndex;
        // buffer[5] = (byte)FeatureExpressionIdIndex;
        // buffer[6] = (byte)(UseOperandEncoding8Bytes ? 1 : 0);
        // buffer[7] = (byte)Operands.Count;
        Descriptor = descriptor;
        OperandsPtr = operandsPtr;
        RawValue = rawValue;
    }

    public Arm64InstructionId Id => (Arm64InstructionId)(ushort)Descriptor;

    public Arm64Mnemonic Mnemonic => (Arm64Mnemonic) (ushort) (Descriptor >> 16);

    public Arm64InstructionClass Class => (Arm64InstructionClass) (byte) (Descriptor >> 32);

    public Arm64FeatureExpressionId FeatureExpressionId => (Arm64FeatureExpressionId)(byte)(Descriptor >> 40);

    public int OperandCount => (byte)(Descriptor >> 56);

    internal bool IsOperandEncodingSize4Bytes => ((byte)(Descriptor >> 48) & 1) == 0;

    public Arm64Operand GetOperand(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)OperandCount);
        return IsOperandEncodingSize4Bytes ? new Arm64Operand(*((uint*)OperandsPtr + index), RawValue) : new Arm64Operand(*((ulong*)OperandsPtr + index), RawValue);
    }

    public override string ToString() => ToString(null, null);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[256];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => TryFormat(destination, out charsWritten, format, provider, null);

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel)
    {
        var mnemonic = this.Mnemonic.ToText(format.Length == 1 && format[0] == 'H');
        if (destination.Length < mnemonic.Length)
        {
            charsWritten = 0;
            return false;
        }
        mnemonic.AsSpan().CopyTo(destination);
        var written = mnemonic.Length;
        if (destination.Length <= written)
        {
            charsWritten = 0;
            return false;
        }

        for (int i = 0; i < OperandCount; i++)
        {
            int previousCharsWritten = written;

            if (i > 0)
            {
                if (destination.Length <= written)
                {
                    charsWritten = 0;
                    return false;
                }

                destination[written] = (char)',';
                written++;
            }

            if (destination.Length <= written)
            {
                charsWritten = 0;
                return false;
            }

            destination[written] = (char)' ';
            written++;
            var operand = GetOperand(i);
            if (!operand.TryFormat(destination.Slice(written), out var operandWritten, out var isDefaultValue, format, provider, tryResolveLabel))
            {
                charsWritten = 0;
                return false;
            }

            // If the argument is actually optional and is the default value, we don't write it
            // So we roll back the written chars. Because TryFormat is expensive as it decode the operand, we don't want to call it twice (decode for default and decode for format)
            if (operand.IsOptional && isDefaultValue)
            {
                written = previousCharsWritten;
            }
            else
            {
                written += operandWritten;
            }
        }

        charsWritten = written;
        return true;
    }


    public static Arm64Instruction Decode(Arm64RawInstruction instruction)
    {
        var id = DecodeId(instruction);
        var offset = Arm64InstructionDecoderTable.InstructionIdToBufferOffset[(int) id];
        var buffer = (byte*)Unsafe.AsPointer(ref Unsafe.Add(ref MemoryMarshal.GetReference(Arm64InstructionDecoderTable.Buffer), offset * 4));
        var descriptor = (ulong*) buffer;
        var operands = buffer + sizeof(ulong);
        return new Arm64Instruction(*descriptor, operands, instruction);
    }

    public static unsafe Arm64InstructionId DecodeId(Arm64RawInstruction instruction)
    {
        ref byte buffer = ref MemoryMarshal.GetReference(Arm64InstructionIdDecoderTable.Buffer);

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

    private readonly record struct KeyEntryIndex(uint Key, EntryIndex Index);
    
    enum TrieTableKind : byte
    {
        Hash = 0,
        SmallArray = 1,
        Terminal = 2
    }
}
