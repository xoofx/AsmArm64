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
[JsonDerivedType(typeof(ImmediateByteValuesOperandDescriptor), typeDiscriminator: "imm-values")]
[JsonDerivedType(typeof(ShiftOperandDescriptor), typeDiscriminator: "shift")]
[JsonDerivedType(typeof(ExtendOperandDescriptor), typeDiscriminator: "extend")]
[JsonDerivedType(typeof(EnumOperandDescriptor), typeDiscriminator: "enum")]
[JsonDerivedType(typeof(PStateFieldOperandDescriptor), typeDiscriminator: "pstate")]
[JsonDerivedType(typeof(ConstOperandDescriptor), typeDiscriminator: "const")]
abstract class OperandDescriptor(Arm64OperandKind kind)
{
    [JsonIgnore]
    public Arm64OperandKind Kind { get; } = kind;

    public bool IsOptional { get; set; }

    public string Name { get; set; } = string.Empty;

    public void Encode(Span<byte> buffer)
    {
        Debug.Assert((byte)Kind <= 0xF);
        buffer[0] = (byte)Kind;
        EncodeImpl(buffer);
    }

    protected internal abstract void EncodeImpl(Span<byte> buffer);
}

interface IIndexableOperandDescriptor
{
    int IndexerId { get; set; }
}

sealed class RegisterGroupOperandDescriptor() : OperandDescriptor(Arm64OperandKind.RegisterGroup), IIndexableOperandDescriptor
{
    public required int Count { get; set; }

    public int IndexerId { get; set; }

    public required RegisterOperandDescriptor Register { get; init; }

    public override string ToString() => $"Group {Name}, Count: {Count}, {Register}";
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)Count | (byte)IndexerId << 4);
        Register.EncodeImpl(buffer.Slice(2));
    }
}

sealed class ImmediateOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Immediate)
{
    public Arm64ImmediateEncodingKind ImmediateKind { get; set; }

    public sbyte FixedValue { get; set; }

    public int BitSize { get; set; }

    public bool IsSigned { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    public override string ToString() => $"Imm {Name}, Signed: {IsSigned}, Size {BitSize}, Encoding: {string.Join(", ", Encoding)}";

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)ImmediateKind;

        if (ImmediateKind == Arm64ImmediateEncodingKind.FixedFloatZero || ImmediateKind == Arm64ImmediateEncodingKind.PStateField)
        {
            return;
        }

        if (ImmediateKind == Arm64ImmediateEncodingKind.FixedInt)
        {
            buffer[2] = (byte)FixedValue;
            return;
        }

        buffer[2] = (byte)(BitSize | (IsSigned ? 0x80 : 0x00));
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
    public Arm64EnumEncodingKind EnumKind { get; set; }

    public int BitSize { get; set; }

    public BitRange EnumEncoding { get; set; }

    public bool AllowImmediate { get; set; }

    public override string ToString() => $"Enum {Name}, Kind: {EnumKind}, Size {BitSize}, Encoding: {EnumEncoding}, AllowImmediate: {AllowImmediate}";

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)EnumKind | ((byte)BitSize << 4));
        buffer[2] = (byte)EnumEncoding.LowBit;
        buffer[3] = (byte)EnumEncoding.Width;
    }
}

sealed class PStateFieldOperandDescriptor() : OperandDescriptor(Arm64OperandKind.PStateField)
{
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
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

sealed class ImmediateByteValuesOperandDescriptor() : OperandDescriptor(Arm64OperandKind.ImmediateByteValues)
{
    public int BitSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<int> Values { get; } = new();

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"ByteValues {Name}, Size {BitSize}, Encoding: {string.Join(", ", Encoding)}, Values: [{string.Join(", ", Values)}]");
        return builder.ToString();
    }

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)(BitSize | (Encoding.Count << 5));
        int index = 2;
        Debug.Assert(Encoding.Count <= 2);
        for (int i = 0; i < Encoding.Count; i++)
        {
            var bitRange = Encoding[i];
            buffer[index] = bitRange.ToSmallEncoding();
            index++;
        }
        buffer[index] = (byte)Values.Count;
        index++;
        for (int i = 0; i < Values.Count; i++)
        {
            buffer[index + i] = (byte)Values[i];
        }
    }
}

sealed class MemoryOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Memory)
{
    public Arm64MemoryEncodingKind MemoryEncodingKind { get; set; }

    public BitRange BaseRegister;

    public Arm64MemoryExtendEncodingKind ExtendKind { get; set; }

    public sbyte FixedValue { get; set; }

    public bool IsPreIncrement { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> IndexRegisterOrImmediate { get; } = new();

    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)MemoryEncodingKind | ((byte)ExtendKind << 4));
        buffer[2] = (byte)BaseRegister.ToSmallEncoding();
        if (MemoryEncodingKind == Arm64MemoryEncodingKind.BaseRegisterAndFixedImmediate)
        {
            buffer[3] = (byte)FixedValue;
        }
        else
        {
            buffer[3] = (byte)(IndexRegisterOrImmediate.Count | (IsPreIncrement ? 0x80 : 0));
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

    public override string ToString() => $"Extend {ExtendEncoding}, {AmountEncoding}";
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)ExtendEncoding.ToSmallEncoding();
        buffer[2] = (byte)AmountEncoding.ToSmallEncoding();
    }
}

sealed class ConstOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Const)
{
    public Arm64ConstEncodingKind ConstKind { get; set; }

    public override string ToString() => $"Const {ConstKind}";
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)ConstKind;
    }
}

sealed class DynamicRegisterSelector
{
    public int Index { get; set; }

    public int SelectorSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> SelectorEncoding { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitValueToRegister> MapBitValueToRegister { get; } = new();

    [JsonIgnore]
    internal List<RegisterOperandDescriptor> RegisterDescriptors { get; } = new();

    [JsonIgnore]
    public string Id => ToString();

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"DynamicXorW[{SelectorSize}](");
        builder.Append(string.Join(", ", SelectorEncoding));
        builder.Append(") -> {");
        for (int i = 0; i < MapBitValueToRegister.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }
            builder.Append(MapBitValueToRegister[i]);
        }
        builder.Append("}");
        return builder.ToString();
    }
}

sealed class RegisterOperandDescriptor() : OperandDescriptor(Arm64OperandKind.Register), IIndexableOperandDescriptor
{
    private int _dynamicRegisterSelectorIndex;
    public Arm64RegisterEncodingKind RegisterKind { get; set; }

    public Arm64RegisterIndexEncodingKind RegisterIndexEncodingKind { get; set; }

    public int IndexerId { get; set; }

    /// <summary>
    /// Only valid for Regular5 and Regular4
    /// </summary>
    public int LowBitIndexEncoding { get; set; }

    public int DynamicRegisterSelectorIndex
    {
        get => DynamicRegisterXOrWSelector?.Index ?? _dynamicRegisterSelectorIndex;
        set => _dynamicRegisterSelectorIndex = value;
    }

    /// <summary>
    /// If > 0, this is an index (-1) to the <see cref="Instruction.VectorArrangements"/> / <see cref="Instruction.VectorArrangementIndices"/>
    /// </summary>
    public int VectorArrangementLocalIndex { get; set; }

    /// <summary>
    /// If the operand kind is <see cref="Arm64RegisterEncodingKind.DynamicXOrW"/>, then the kind of register is selected dynamically
    /// </summary>
    [JsonIgnore]
    public DynamicRegisterSelector? DynamicRegisterXOrWSelector { get; set; }

    [JsonIgnore]
    public bool IsSimpleEncoding => RegisterIndexEncodingKind != Arm64RegisterIndexEncodingKind.SpecialMRm;
    
    public BitRange GetIndexEncoding()
    {
        if (!IsSimpleEncoding) throw new InvalidOperationException("Cannot get index encoding for non-simple encoding");
        return RegisterIndexEncodingKind switch
        {
            Arm64RegisterIndexEncodingKind.Std4 => new BitRange(LowBitIndexEncoding, 4),
            Arm64RegisterIndexEncodingKind.Std5 => new BitRange(LowBitIndexEncoding, 5),
            _ => throw new InvalidOperationException("Cannot get index encoding for non-simple encoding")
        };
    }
    protected internal override void EncodeImpl(Span<byte> buffer)
    {
        buffer[1] = (byte)((byte)RegisterKind | ((byte)RegisterIndexEncodingKind << 4));
        buffer[2] = (byte)IndexerId;
        buffer[3] = (byte)LowBitIndexEncoding;
        if (RegisterKind == Arm64RegisterEncodingKind.V)
        {
            buffer[4] = (byte)VectorArrangementLocalIndex;
        }
        else if (RegisterKind == Arm64RegisterEncodingKind.DynamicXOrW || RegisterKind == Arm64RegisterEncodingKind.DynamicVScalar)
        {
            buffer[4] = (byte)DynamicRegisterSelectorIndex;
            Debug.Assert(VectorArrangementLocalIndex == 0);
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

        if (RegisterKind == Arm64RegisterEncodingKind.V && VectorArrangementLocalIndex != 0)
        {
            builder.Append($".{VectorArrangementLocalIndex}");
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
    /// If a bit range is small encoding, it can be encoded in a single byte (5 bits for LowBit, 3 bits for Width)
    /// </summary>
    [JsonIgnore]
    public bool IsSmallEncoding => Width < 8; // Could be slightly improved if Width is encoded with always + 1

    public byte ToSmallEncoding()
    {
        Debug.Assert(IsSmallEncoding);
        return (byte)(LowBit | (Width << 5));
    }

    public override string ToString() => $"({LowBit}:{Width})";
}

readonly record struct BitValueToRegister(string BitValues, Arm64RegisterEncodingKind RegisterKind)
{
    public override string ToString() => $"{BitValues} -> {RegisterKind}";
}

readonly record struct VectorArrangementValue(Arm64RegisterVectorArrangementEncodingKind Kind, string BitValues)
{
    public override string ToString() => $"{Kind} = {BitValues}";
}

record VectorArrangement
{
    private int _vectorArrangementValuesIndex;

    /// <summary>
    /// Index in the global list of <see cref="InstructionSet.VectorArrangements"/>
    /// </summary>
    public int Index { get; set; }

    public Arm64RegisterVectorArrangementEncodingKind ArrangementKind { get; set; }

    public int BitSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    /// <summary>
    /// Gets or sets the index of the vector arrangement values in the <see cref="InstructionSet.VectorArrangementValues"/>
    /// </summary>
    public int VectorArrangementValuesIndex
    {
        get => Values?.Index ?? _vectorArrangementValuesIndex;
        set => _vectorArrangementValuesIndex = value;
    }

    [JsonIgnore]
    public VectorArrangementValues? Values { get; set; }

    [JsonIgnore]
    public string Id
    {
        get
        {
            var builder = new StringBuilder();
            builder.Append($"{ArrangementKind}-{BitSize}-{string.Join(":", Encoding)}");
            if (Values != null)
            {
                builder.Append($"-{Values.Id}");
            }

            return builder.ToString();
        }
    }

    // Maximum 4 bytes encoded
    public void Encode(Span<byte> buffer)
    {
        buffer[0] = (byte)((byte)ArrangementKind | (byte)BitSize << 4);
        buffer[1] = (byte)Encoding.Count;
        int index = 2;
        Debug.Assert(Encoding.Count <= 2);
        for (int i = 0; i < Encoding.Count; i++)
        {
            var bitRange = Encoding[i];
            buffer[index] = bitRange.ToSmallEncoding();
            index++;
        }
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(ArrangementKind);
        hash.Add(BitSize);
        foreach (var bitRange in Encoding)
        {
            hash.Add(bitRange);
        }

        var values = Values;
        if (values is not null)
        {
            foreach (var item in values.Items)
            {
                hash.Add(item);
            }
        }
        return hash.ToHashCode();
    }

    public virtual bool Equals(VectorArrangement? other)
    {
        if (other == null)
        {
            return false;
        }
        if (ArrangementKind != other.ArrangementKind)
        {
            return false;
        }
        if (BitSize != other.BitSize)
        {
            return false;
        }
        if (Encoding.Count != other.Encoding.Count)
        {
            return false;
        }

        for (int i = 0; i < Encoding.Count; i++)
        {
            if (Encoding[i] != other.Encoding[i])
            {
                return false;
            }
        }

        if (Values is null && other.Values is null)
        {
            return true;
        }

        if (Values is null || other.Values is null)
        {
            return false;
        }

        return Values.Equals(other.Values);
    }

    public override string ToString()
    {
        if (Encoding.Count == 0 && Values is null)
        {
            return ArrangementKind.ToString();
        }
        var builder = new StringBuilder();
        builder.Append(ArrangementKind);

        builder.Append($"(Size: {BitSize}, Encoding: ");

        builder.Append("[");
        for (var i = 0; i < Encoding.Count; i++)
        {
            var bitRange = Encoding[i];
            if (i > 0) builder.Append(",");
            builder.Append(bitRange);
        }
        builder.Append("], Values: ");

        builder.Append("{");
        for (var i = 0; i < Values!.Items.Count; i++)
        {
            var item = Values.Items[i];
            if (i > 0) builder.Append(",");
            builder.Append(item);
        }
        builder.Append("}");

        return builder.ToString();
    }
}

sealed class VectorArrangementValues
{
    [JsonIgnore]
    public string Id => ToString();

    public int Index { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<VectorArrangementValue> Items { get; } = new();

    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var item in Items)
        {
            hash.Add(item);
        }
        return hash.ToHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not VectorArrangementValues other)
        {
            return false;
        }
        if (Items.Count != other.Items.Count)
        {
            return false;
        }
        for (int i = 0; i < Items.Count; i++)
        {
            if (this.Items[i] != other.Items[i])
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("{");
        for (int i = 0; i < Items.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }
            builder.Append(this.Items[i]);
        }
        builder.Append("}");
        return builder.ToString();
    }
}
