// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(RegisterOperandDescriptor), typeDiscriminator: "reg")]
[JsonDerivedType(typeof(RegisterGroupOperandDescriptor), typeDiscriminator: "greg")]
[JsonDerivedType(typeof(ImmediateOperandDescriptor), typeDiscriminator: "imm")]
[JsonDerivedType(typeof(MemoryOperandDescriptor), typeDiscriminator: "mem")]
[JsonDerivedType(typeof(LabelOperandDescriptor), typeDiscriminator: "label")]
[JsonDerivedType(typeof(ShiftOperandDescriptor), typeDiscriminator: "shift")]
[JsonDerivedType(typeof(ExtendOperandDescriptor), typeDiscriminator: "extend")]
[JsonDerivedType(typeof(EnumOperandDescriptor), typeDiscriminator: "enum")]
[JsonDerivedType(typeof(SystemRegisterOperandDescriptor), typeDiscriminator: "sysreg")]
abstract class OperandDescriptor(Arm64OperandKind kind)
{
    [JsonIgnore]
    public Arm64OperandKind Kind { get; } = kind;

    public bool IsOptional
    {
        get => (Flags & Arm64OperandFlags.Optional) != 0;
        set => Flags = value ? Flags | Arm64OperandFlags.Optional : Flags & ~Arm64OperandFlags.Optional;
    }

    public Arm64OperandFlags Flags { get; set; }


    public string Name { get; set; } = string.Empty;

    public int TableEncodingOffset { get; set; }

    public string Description { get; set; } = string.Empty;

    public void Encode(Span<byte> buffer)
    {
        Debug.Assert((byte)Kind <= 0xF);
        buffer[0] = (byte)((byte)Kind | ((byte)Flags << 4));
        EncodeImpl(buffer);
    }

    protected internal abstract void EncodeImpl(Span<byte> buffer);
}

sealed class RegisterGroupOperandDescriptor() : OperandDescriptor(Arm64OperandKind.RegisterGroup)
{
    private int _indexerIndex;
    public required int Count { get; set; }

    public int IndexerIndex
    {
        get => IndexerExtract?.Index ?? _indexerIndex;
        set => _indexerIndex = value;
    }

    [JsonIgnore]
    public EncodingSymbolExtract? IndexerExtract { get; set; }

    public required RegisterOperandDescriptor Register { get; init; }

    public override string ToString() => $"Group {Name}, Count: {Count}, {Register}";
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        Debug.Assert(Count >= 1 && Count <= 4);
        buffer[1] = (byte)Count;
        buffer[2] = (byte)IndexerIndex;
        // Register.EncodeImpl starts to encode at offset 1, so we need to skip the first byte
        Register.EncodeImpl(buffer.Slice(2));
    }
}

sealed class ImmediateOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Immediate)
{
    private int _extractIndex;
    public Arm64ImmediateEncodingKind ImmediateKind { get; set; }

    public Arm64ImmediateValueEncodingKind ValueEncodingKind { get; set; }

    public bool HasFixedValue { get; set; }

    public sbyte FixedValue { get; set; }

    public int BitSize { get; set; }

    public bool IsSigned { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    public int ExtractIndex
    {
        get => Extract?.Index ?? _extractIndex;
        set => _extractIndex = value;
    }

    [JsonIgnore]
    public EncodingSymbolExtract? Extract { get; set; }

    public override string ToString() => $"Imm {Name}, Signed: {IsSigned}, Size {BitSize}, Encoding: {string.Join(", ", Encoding)}";

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)ImmediateKind | (byte)(IsOptional? 0x80 : 0));

        if (ImmediateKind == Arm64ImmediateEncodingKind.FixedFloatZero)
        {
            return;
        }

        if (ImmediateKind == Arm64ImmediateEncodingKind.FixedInt)
        {
            buffer[2] = (byte)FixedValue;
            return;
        }

        buffer[2] = (byte)((byte)ValueEncodingKind | (byte)(IsSigned ? 0x80 : 0x00));

        if (ImmediateKind == Arm64ImmediateEncodingKind.BitMapExtract)
        {
            Debug.Assert(ExtractIndex != 0);
            buffer[3] = (byte)ExtractIndex;
            return;
        }

        buffer[3] = (byte)Encoding.Count;
        //4,5,6,7
        Debug.Assert(Encoding.Count <= 2);
        for (int i = 0; i < Encoding.Count; i++)
        {
            var bitRange = Encoding[i];
            buffer[4 + i * 2] = (byte)bitRange.LowBit;
            buffer[5 + i * 2] = (byte)bitRange.Width;
        }
    }
}

sealed class EnumOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Enum)
{
    private int _extractIndex;

    public Arm64EnumKind EnumKind { get; set; }

    public int BitSize { get; set; }

    public BitRange EnumEncoding { get; set; }

    public bool AllowImmediate { get; set; }

    public int ExtractIndex
    {
        get => BitMapExtract?.Index ?? _extractIndex;
        set => _extractIndex = value;
    }

    [JsonIgnore]
    public EncodingSymbolExtract? BitMapExtract { get; set; }
    
    public override string ToString() => $"Enum {Name}, Kind: {EnumKind}, Size {BitSize}, Encoding: {EnumEncoding}, AllowImmediate: {AllowImmediate}";

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)EnumKind;
        if (EnumKind == Arm64EnumKind.ProcessStateField)
        {
            buffer[2] = (byte)ExtractIndex;
        }
        else if (EnumKind != Arm64EnumKind.RangePrefetchOperation)
        {
            buffer[2] = (byte)EnumEncoding.LowBit;
            buffer[3] = (byte)EnumEncoding.Width;
        }
    }
}

sealed class LabelOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Label)
{
    public Arm64LabelEncodingKind LabelKind { get; set; }

    public int BitSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    public override string ToString() => $"Label {Name}, Kind: {LabelKind}, Size {BitSize}, Encoding: {string.Join(", ", Encoding)}";
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)LabelKind;
        buffer[2] = (byte)BitSize;
        buffer[3] = (byte)Encoding.Count;
        //4,5,6,7
        Debug.Assert(Encoding.Count <= 2);
        for (int i = 0; i < Encoding.Count; i++)
        {
            var bitRange = Encoding[i];
            buffer[4 + i * 2] = (byte)bitRange.LowBit;
            buffer[5 + i * 2] = (byte)bitRange.Width;
        }
    }
}

sealed class MemoryOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Memory)
{
    public Arm64MemoryEncodingKind MemoryEncodingKind { get; set; }

    public BitRange BaseRegister;

    public Arm64MemoryExtendEncodingKind ExtendKind { get; set; }

    public Arm64ImmediateValueEncodingKind ImmediateValueEncodingKind { get; set; }

    public sbyte FixedValue { get; set; }

    public bool IsPreIncrement { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> IndexRegisterOrImmediate { get; } = new();

    public bool SignedImmediate { get; set; }

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)MemoryEncodingKind | ((byte)ExtendKind << 4));
        buffer[2] = (byte)BaseRegister.ToSmallEncoding();
        if (MemoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate || MemoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediateOptional)
        {
            buffer[3] = (byte)FixedValue;
            buffer[4] = (byte) (IsPreIncrement ? 0x80 : 0);
        }
        else
        {
            buffer[3] = (byte)((byte)ImmediateValueEncodingKind | (IsPreIncrement ? 0x80 : 0) | (SignedImmediate ? 0x40 : 0) | (IndexRegisterOrImmediate.Count == 2 ? 0x20 : 0));
            int index = 4;
            for (int i = 0; i < IndexRegisterOrImmediate.Count; i++)
            {
                var bitRange = IndexRegisterOrImmediate[i];
                buffer[index + i * 2] = (byte)bitRange.LowBit;
                buffer[index + 1 + i * 2] = (byte)bitRange.Width;
            }
        }
    }
}

sealed class ShiftOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Shift)
{
    public Arm64ShiftEncodingKind ShiftKind { get; set; }

    public BitRange ShiftEncoding { get; set; }

    public BitRange AmountEncoding { get; set; }

    public override string ToString() => $"Shift {ShiftKind}, {ShiftEncoding}, {AmountEncoding}";
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)ShiftKind;
        buffer[2] = (byte)ShiftEncoding.ToSmallEncoding();
        buffer[3] = (byte)AmountEncoding.ToSmallEncoding();
    }
}

sealed class ExtendOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Extend)
{
    public BitRange ExtendEncoding { get; set; }

    public BitRange AmountEncoding { get; set; }

    public bool Is64Bit { get; set; }

    public Arm64ExtendEncodingKind  EncodingKind { get; set; }
    
    public EncodingSymbolExtract? ExtendExtract { get; set; }

    public override string ToString() => $"Extend {ExtendEncoding}, {AmountEncoding}, Is64Bit: {Is64Bit}";

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)ExtendEncoding.ToSmallEncoding();
        buffer[2] = (byte)AmountEncoding.ToSmallEncoding();
        buffer[3] = (byte)((byte)EncodingKind | (byte)(Is64Bit ? 0x80 : 0));
    }
}

sealed class SystemRegisterOperandDescriptor() : OperandDescriptor(Arm64OperandKind.SystemRegister)
{
    public byte SystemRegisterKindIndex { get; set; }

    public BitRange Encoding { get; set; }

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        // We don't need to encode the position, as it is always BitRange(5, 16)
        buffer[1] = SystemRegisterKindIndex;
    }
}

sealed class RegisterOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Register)
{
    private int _dynamicRegisterSelectorIndex;
    private int _indexerIndex;
    private int _registerIndexExtractIndex;
    private int _vectorArrangementIndex;
    public Arm64RegisterEncodingKind RegisterKind { get; set; }

    public Arm64RegisterIndexEncodingKind RegisterIndexEncodingKind { get; set; }

    public BitRangeCondition Condition { get; set; }

    public int IndexerIndex
    {
        get => IndexerExtract?.Index ?? _indexerIndex;
        set => _indexerIndex = value;
    }

    /// <summary>
    /// Only valid for Regular5 and Regular4
    /// </summary>
    public int LowBitIndexEncoding { get; set; }

    /// <summary>
    /// Only valid for Fixed encoding.
    /// </summary>
    public int FixedRegisterIndex { get; set; }

    public int DynamicRegisterSelectorIndex
    {
        get => DynamicRegisterXOrWSelector?.Index ?? _dynamicRegisterSelectorIndex;
        set => _dynamicRegisterSelectorIndex = value;
    }

    public int RegisterIndexExtractIndex
    {
        get => RegisterIndexExtract?.Index ?? _registerIndexExtractIndex;
        set => _registerIndexExtractIndex = value;
    }

    public int VectorArrangementIndex
    {
        get => VectorArrangement?.Index ?? _vectorArrangementIndex;
        set => _vectorArrangementIndex = value;
    }

    [JsonIgnore]
    public EncodingSymbolExtract? IndexerExtract { get; set; }

    [JsonIgnore]
    public EncodingVectorArrangementExtract? VectorArrangement { get; set; }

    /// <summary>
    /// If the operand kind is <see cref="Arm64RegisterEncodingKind.DynamicXOrW"/>, then the kind of register is selected dynamically
    /// </summary>
    [JsonIgnore]
    public EncodingSymbolExtract? DynamicRegisterXOrWSelector { get; set; }

    [JsonIgnore]
    public bool IsSimpleEncoding => RegisterIndexEncodingKind != Arm64RegisterIndexEncodingKind.BitMapExtract;

    [JsonIgnore]
    public EncodingSymbolExtract? RegisterIndexExtract { get; set; }

    public bool IsPaired { get; set; }

    public BitRange GetIndexEncoding()
    {
        if (!IsSimpleEncoding) throw new InvalidOperationException("Cannot get index encoding for non-simple encoding");
        return RegisterIndexEncodingKind switch
        {
            Arm64RegisterIndexEncodingKind.Std4 => new BitRange(LowBitIndexEncoding, 4),
            Arm64RegisterIndexEncodingKind.Std5 => new BitRange(LowBitIndexEncoding, 5),
            Arm64RegisterIndexEncodingKind.Std5Plus1 => new BitRange(LowBitIndexEncoding, 5),
            _ => throw new InvalidOperationException("Cannot get index encoding for non-simple encoding")
        };
    }
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)RegisterKind | ((byte)RegisterIndexEncodingKind << 4));
        buffer[2] = (byte)((byte)IndexerIndex | (byte)(IsOptional ? 0x80  : 0) | (byte)(IsPaired ? 0x40 : 0));
        if (RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.BitMapExtract)
        {
            Debug.Assert(RegisterIndexExtractIndex != 0);
            buffer[3] = (byte)RegisterIndexExtractIndex;
        }
        else if (RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Fixed)
        {
            buffer[3] = (byte)FixedRegisterIndex;
        }
        else
        {
            buffer[3] = (byte)LowBitIndexEncoding;
        }
        
        if (RegisterKind == Arm64RegisterEncodingKind.V)
        {
            buffer[4] = (byte)VectorArrangementIndex;
            Debug.Assert(DynamicRegisterSelectorIndex == 0);
        }
        else if (RegisterKind == Arm64RegisterEncodingKind.DynamicXOrW || RegisterKind == Arm64RegisterEncodingKind.DynamicVScalar)
        {
            buffer[4] = (byte)DynamicRegisterSelectorIndex;
            Debug.Assert(VectorArrangementIndex == 0);
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(RegisterKind);

        builder.Append('/');
        builder.Append(RegisterIndexEncodingKind);

        if (DynamicRegisterXOrWSelector is not null)
        {
            builder.Append($" {DynamicRegisterXOrWSelector}");
        }

        if (RegisterKind == Arm64RegisterEncodingKind.V && VectorArrangementIndex != 0)
        {
            builder.Append($".{VectorArrangementIndex}");
        }

        if (RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Std4)
        {
            builder.Append($"({LowBitIndexEncoding}:4)");
        }
        else if (RegisterIndexEncodingKind == Arm64RegisterIndexEncodingKind.Std5)
        {
            builder.Append($"({LowBitIndexEncoding}:5)");
        }

        return builder.ToString();
    }

}

readonly record struct BitRange(int LowBit, int Width)
{
    /// <summary>
    /// If a bitrange is small encoding, it can be encoded in a single byte (5 bits for LowBit, 3 bits for Width)
    /// </summary>
    [JsonIgnore]
    public bool IsSmallEncoding => Width < 8; // Could be slightly improved if Width is encoded with always + 1

    public byte ToSmallEncoding()
    {
        Debug.Assert(IsSmallEncoding);
        return (byte)(LowBit | (Width << 5));
    }

    public bool Contains(BitRange other) => LowBit <= other.LowBit && LowBit + Width - 1 >= other.LowBit + other.Width - 1;

    public BitRange EncodeRelativeTo(List<BitRange> bitRanges)
    {
        var lowBit = LowBit;
        var width = Width;
        bool rangeFound = false;
        for (var i = 0; i < bitRanges.Count; i++)
        {
            var bitRange = bitRanges[i];
            if (this.LowBit >= bitRange.LowBit && this.LowBit <= bitRange.LowBit + bitRange.Width - 1)
            {
                lowBit -= bitRange.LowBit;

                // Shift the width with the lower width
                for (int j = i + 1; j < bitRanges.Count; j++)
                {
                    lowBit += bitRanges[j].Width;
                }

                rangeFound = true;
                break;
            }
        }

        if (!rangeFound)
        {
            throw new InvalidOperationException($"Cannot encode {this} relative to {string.Join(", ", bitRanges)}");
        }

        return new BitRange(lowBit, width);
    }

    public override string ToString() => $"({LowBit}:{Width})";
}

record BitValueToRegister : BitValueBase
{
    public BitValueToRegister(string bitValuesAsText, Arm64RegisterEncodingKind registerKind)  : base(bitValuesAsText)
    {
        this.RegisterKind = registerKind;
    }

    public Arm64RegisterEncodingKind RegisterKind { get; init; }

    public override string ToString() => $"{BitValuesAsText} -> {RegisterKind}";

}

abstract record BitValueBase
{
    protected BitValueBase(string bitValuesAsText)
    {
        this.BitValuesAsText = bitValuesAsText;

        if (bitValuesAsText.Contains('x'))
        {
            uint maskValue = 0;
            uint value = 0;
            foreach (var c in bitValuesAsText)
            {
                Debug.Assert(c == '0' || c == '1' || c == 'x');
                maskValue <<= 1;
                maskValue |= (c == 'x') ? 0U : 1;
                value <<= 1;
                value |= (c == '1') ? 1U : 0;
            }
            MaskValue = maskValue;
            BitValue = value;
        }
        else
        {
            uint value = 0;
            foreach (var c in bitValuesAsText)
            {
                Debug.Assert(c == '0' || c == '1');
                value <<= 1;
                value |= (c == '1') ? 1U : 0;
            }
            BitValue = value;
        }

        BitCount = bitValuesAsText.Length;
    }

    public string BitValuesAsText { get; init; }

    [JsonIgnore]
    public int BitCount { get; set; }

    public uint MaskValue { get; set; }

    public uint BitValue { get; set; }
}
