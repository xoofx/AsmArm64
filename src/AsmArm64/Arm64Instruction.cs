// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
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

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Instruction"/> struct.
    /// </summary>
    /// <param name="descriptor">The descriptor.</param>
    /// <param name="operandsPtr">The pointer to the operands.</param>
    /// <param name="rawValue">The raw instruction value.</param>
    private Arm64Instruction(ulong descriptor, byte* operandsPtr, Arm64RawInstruction rawValue)
    {
        // MemoryMarshal.Write(buffer, (ushort)IdIndex);
        // MemoryMarshal.Write(buffer.Slice(2), (ushort)MnemonicIndex);
        // buffer[4] = (byte)InstructionClassIndex;
        // buffer[5] = (byte)FeatureExpressionIdIndex;
        // buffer[6] = Arm64InstructionEncodingFlags
        // buffer[7] = (byte)Operands.Count;
        Descriptor = descriptor;
        OperandsPtr = operandsPtr;
        RawValue = rawValue;
    }

    /// <summary>
    /// Gets the instruction ID.
    /// </summary>
    public Arm64InstructionId Id => (Arm64InstructionId)(ushort)Descriptor;

    /// <summary>
    /// Gets the mnemonic of the instruction.
    /// </summary>
    public Arm64Mnemonic Mnemonic => (Arm64Mnemonic)(ushort)(Descriptor >> 16);

    /// <summary>
    /// Gets the class of the instruction.
    /// </summary>
    public Arm64InstructionClass Class => (Arm64InstructionClass)(byte)(Descriptor >> 32);

    /// <summary>
    /// Gets the flags of the instruction.
    /// </summary>
    public Arm64InstructionFlags Flags => (Arm64InstructionFlags)((byte)(Descriptor >> 48) & 0x7F); // Don't expose bit 7 (flags encoding as 8 bytes)

    /// <summary>
    /// Gets the feature expression ID of the instruction.
    /// </summary>
    public Arm64FeatureExpressionId FeatureExpressionId => (Arm64FeatureExpressionId)(byte)(Descriptor >> 40);

    /// <summary>
    /// Gets the number of operands.
    /// </summary>
    public int OperandCount => (byte)(Descriptor >> 56);

    /// <summary>
    /// Gets the operands of the instruction.
    /// </summary>
    public Arm64Operands Operands => new(this);

    /// <summary>
    /// Gets a value indicating whether the operand encoding size is 4 bytes.
    /// </summary>
    internal bool IsOperandEncodingSize4Bytes => ((byte)(Descriptor >> (48 + 7)) & 1) == 0;

    /// <summary>
    /// Gets the operand at the specified index.
    /// </summary>
    /// <param name="index">The index of the operand.</param>
    /// <returns>The operand at the specified index.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range.</exception>
    public Arm64Operand GetOperand(int index)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)OperandCount);
        return IsOperandEncodingSize4Bytes ? new Arm64Operand(*((uint*)OperandsPtr + index), RawValue) : new Arm64Operand(*((ulong*)OperandsPtr + index), RawValue);
    }

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <summary>
    /// Converts the instruction to a string representation.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The format provider.</param>
    /// <returns>The string representation of the instruction.</returns>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        Span<char> buffer = stackalloc char[256];
        var result = TryFormat(buffer, out var charsWritten, format.AsSpan(), formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    /// <summary>
    /// Tries to format the instruction into the provided span.
    /// </summary>
    /// <param name="destination">The destination span.</param>
    /// <param name="charsWritten">The number of characters written.</param>
    /// <param name="format">The format string.</param>
    /// <param name="provider">The format provider.</param>
    /// <returns><c>true</c> if the formatting was successful; otherwise, <c>false</c>.</returns>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        => TryFormat(destination, out charsWritten, format, provider, null);

    /// <summary>
    /// Tries to format the instruction into the provided span.
    /// </summary>
    /// <param name="destination">The destination span.</param>
    /// <param name="charsWritten">The number of characters written.</param>
    /// <param name="format">The format string.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="tryResolveLabel">The delegate to resolve labels.</param>
    /// <returns><c>true</c> if the formatting was successful; otherwise, <c>false</c>.</returns>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryResolveLabel)
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

        bool isSpecialCondition = Id == Arm64InstructionId.BC_only_condbranch || Id == Arm64InstructionId.B_only_condbranch;

        for (int i = 0; i < OperandCount; i++)
        {
            int previousCharsWritten = written;

            if (!isSpecialCondition && i > 0)
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

            destination[written] = isSpecialCondition && i == 0 ? (char)'.' : (char)' ';
            written++;
            var operand = GetOperand(i);
            if (!operand.TryFormat(this, destination.Slice(written), out var operandWritten, out var isDefaultValue, format, provider, tryResolveLabel))
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

    /// <summary>
    /// Decodes the specified raw instruction.
    /// </summary>
    /// <param name="rawInstruction">The raw instruction.</param>
    /// <returns>The decoded instruction.</returns>
    public static Arm64Instruction Decode(Arm64RawInstruction rawInstruction)
    {
        var id = DecodeId(rawInstruction);
        var offset = Arm64InstructionDecoderTable.InstructionIdToBufferOffset[(int)id];
        var buffer = (byte*)Unsafe.AsPointer(ref Unsafe.Add(ref MemoryMarshal.GetReference(Arm64InstructionDecoderTable.Buffer), offset * 4));
        var descriptor = (ulong*)buffer;
        var operands = buffer + sizeof(ulong);
        return new Arm64Instruction(*descriptor, operands, rawInstruction);
    }

    /// <summary>
    /// Gets the operand descriptor at the specified offset.
    /// </summary>
    /// <param name="offset">The offset.</param>
    /// <returns>The operand descriptor.</returns>
    internal static ulong GetOperandDescriptor(nint offset)
        => Unsafe.As<byte, ulong>(ref Unsafe.Add(ref MemoryMarshal.GetReference(Arm64InstructionDecoderTable.Buffer), offset));

    /// <summary>
    /// Decodes the instruction ID from the specified raw instruction.
    /// </summary>
    /// <param name="rawInstruction">The raw instruction.</param>
    /// <returns>The decoded instruction ID.</returns>
    public static unsafe Arm64InstructionId DecodeId(Arm64RawInstruction rawInstruction)
    {
        ref byte buffer = ref MemoryMarshal.GetReference(Arm64InstructionIdDecoderTable.Buffer);

        int offset = 0;

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

        var key = rawInstruction & bitMask;
        if (kind == TrieTableKind.SmallArray)
        {
            for (int i = 0; i < arrayLength; i++)
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
        else if (kind == TrieTableKind.Hash)
        {
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
        else if (kind == TrieTableKind.SmallArrayWithNotBitMask)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                ref var keyEntryIndex = ref Unsafe.As<byte, KeyEntryIndexWithNotBitMask>(ref Unsafe.Add(ref buffer, offset + i * sizeof(KeyEntryIndexWithNotBitMask)));
                if (keyEntryIndex.Key == key && (keyEntryIndex.NotBitMask == 0 || (rawInstruction & keyEntryIndex.NotBitMask) != keyEntryIndex.NotBitValue))
                {
                    offset = keyEntryIndex.Index;
                    if (offset < 0) goto return_offset;
                    if (offset > 0) goto nextHeader;
                    break;
                }
            }
        }

        if (hasElseBranch)
        {
            offset = elseBranchIndex;

            if (offset < 0) goto return_offset;
            if (offset > 0) goto nextHeader;
        }

        // Offset is 0, returning invalid
        return Arm64InstructionId.Invalid;

    return_offset:
        {
            uint id = unchecked((uint)offset) & ~0x8000_0000U;
            if ((id & 0x4000_0000U) != 0)
            {
                id &= ~0x4000_0000U;
                return (Arm64InstructionId)Arm64InstructionIdDynamicDecoder.ResolveBetterAlias((Arm64InstructionId)(id), rawInstruction);
            }

            return (Arm64InstructionId)(id);
        }
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

    private readonly record struct KeyEntryIndexWithNotBitMask(uint Key, EntryIndex Index, uint NotBitMask, uint NotBitValue);

    enum TrieTableKind : byte
    {
        Hash = 0,
        SmallArray = 1,
        Terminal = 2,
        SmallArrayWithNotBitMask = 3,
    }
}
