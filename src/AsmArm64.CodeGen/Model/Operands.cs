// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

// Check https://github.com/CensoredUsername/dynasm-rs/blob/master/tools/aarch64_gen_opmap.py for ideas
// https://github.com/wdamron/arm/blob/main/INSTRUCTIONS.md
// https://github.com/wdamron/arm/blob/main/encoding.go

sealed class Operand
{
    public required OperandKind Kind { get; init; }

    public OperandDescriptor? Descriptor { get; set; }
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    /// <summary>
    /// If this parameter has a bang `!` at the end.
    /// </summary>
    public bool HasBang { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        if (Kind == OperandKind.Memory)
        {
            builder.Append('[');
        }

        for (int i = 0; i < Items.Count; i++)
        {
            var parameter = Items[i];
            var isOptional = parameter is OptionalGroupOperandItem { IsOptional: true };
            if (isOptional)
            {
                builder.Append('{');
            }
            if (i > 0)
            {
                builder.Append(", ");
            }

            var parameterToStr = parameter.ToString();
            if (isOptional)
            {
                // For an optional, we handle it here by placing the { before the comma
                builder.Append(parameterToStr.Substring(1));
            }
            else
            {
                builder.Append(parameterToStr);
            }
        }

        if (Kind == OperandKind.Memory)
        {
            builder.Append(']');
        }

        if (HasBang)
        {
            builder.Append('!');
        }

        return builder.ToString();
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
enum OperandKind
{
    Undefined,
    Register,
    ConstAndImmediate,
    Immediate,
    Const,
    Value,
    Enum,
    Memory,
    OptionalGroup,
    RegisterGroup,
    Select,
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(EnumOperandItem), typeDiscriminator: "enum")]
[JsonDerivedType(typeof(ConstOperandItem), typeDiscriminator: "const")]
[JsonDerivedType(typeof(ValueOperandItem), typeDiscriminator: "value")]
[JsonDerivedType(typeof(ConstAndImmediateOperandItem), typeDiscriminator: "const-and-imm")]
[JsonDerivedType(typeof(ImmediateOperandItem), typeDiscriminator: "imm")]
[JsonDerivedType(typeof(OptionalGroupOperandItem), typeDiscriminator: "optional-group")]
[JsonDerivedType(typeof(RegisterGroupOperandItem), typeDiscriminator: "reg-group")]
[JsonDerivedType(typeof(RegisterOperandItem), typeDiscriminator: "reg")]
[JsonDerivedType(typeof(SelectOperandItem), typeDiscriminator: "select")]
abstract class OperandItem(OperandItemKind kind)
{
    [JsonIgnore]
    public OperandItemKind Kind { get; } = kind;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandText> TextElements { get; } = new();

    public OperandItem? Indexer { get; set; }

    public string GetName() => string.Concat(TextElements.Select(x => x.Text));

    public sealed override string ToString()
    {
        var builder = new StringBuilder();
        ToStringPrefix(builder);
        ToStringTextElements(builder);
        ToStringParameters(builder);
        if (Indexer is not null)
        {
            builder.Append('[');
            builder.Append(Indexer);
            builder.Append(']');
        }

        return builder.ToString();
    }

    protected virtual void ToStringPrefix(StringBuilder builder)
    {
    }

    protected virtual void ToStringParameters(StringBuilder builder)
    {
    }

    protected void ToStringTextElements(StringBuilder builder)
    {
        foreach (var textElement in TextElements)
        {
            builder.Append(textElement.Text);
        }
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
enum OperandItemKind
{
    Register,
    ConstAndImmediate,
    Immediate,
    Const,
    Value,
    Enum,
    OptionalGroup,
    RegisterGroup,
    Select,
}

sealed class EnumOperandItem() : OperandItem(OperandItemKind.Enum);

sealed class ValueOperandItem() : OperandItem(OperandItemKind.Value);

sealed class ConstOperandItem() : OperandItem(OperandItemKind.Const);

sealed class ImmediateOperandItem() : OperandItem(OperandItemKind.Immediate)
{
    protected override void ToStringPrefix(StringBuilder builder) => builder.Append('#');
}

sealed class ConstAndImmediateOperandItem() : OperandItem(OperandItemKind.ConstAndImmediate);


abstract class GroupOperandItemBase(OperandItemKind kind) : OperandItem(kind)
{
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    /// <summary>
    /// Is this object optional.
    /// </summary>
    public bool IsOptional { get; set; }

    protected override void ToStringParameters(StringBuilder builder)
    {
        builder.Append('{');
        builder.Append(string.Join(", ", Items));
        builder.Append('}');
    }
}


sealed class OptionalGroupOperandItem() : GroupOperandItemBase(OperandItemKind.OptionalGroup);

sealed class RegisterGroupOperandItem() : GroupOperandItemBase(OperandItemKind.RegisterGroup);


[method: JsonConstructor]
sealed class OperandText(string text, EncodingSymbol? symbol)
{
    public string Text { get; } = text;

    public EncodingSymbol? Symbol { get; } = symbol;

    public override string ToString() => Symbol is not null ? $"{Text} ({Symbol})" : Text;
}

sealed class RegisterOperandItem() : OperandItem(OperandItemKind.Register);

/// <summary>
/// Arguments Starting with ( and with | and ) are grouped arguments.
/// </summary>
sealed class SelectOperandItem() : OperandItem(OperandItemKind.Select)
{
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    protected override void ToStringParameters(StringBuilder builder)
    {
        builder.Append('(');
        builder.Append(string.Join("|", Items));
        builder.Append(')');
    }
}

[DebuggerDisplay("Name = {Name}, Symbols = {Symbols.Count}")]
class EncodingSymbolsInfo
{
    public required string Name { get; init; } = string.Empty;

    public Dictionary<string, EncodingSymbol> Symbols { get; } = new();
}

[DebuggerDisplay("Link = {Link}, BitInfos = {BitInfosDebuggerDisplay}, BitValues = {BitValues.Count}")]
class EncodingSymbol
{
    public required string Link { get; init; } = string.Empty;

    public required string Name { get; init; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingBitInfo> BitInfos { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> BitValueNames { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingBitValue> BitValues { get; } = new();

    private string BitInfosDebuggerDisplay => string.Join(":", BitInfos);

    public override string ToString()
    {
        return BitValues.Count > 0 ? $"{BitInfosDebuggerDisplay} Match: ({string.Join(":", BitValueNames)} -> ([{string.Join("], [", BitValues)}])" : BitInfosDebuggerDisplay;
    }
}

record EncodingBitInfo
{
    public required string Name { get; init; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<int> BitIndices { get; } = new();

    public override string ToString()
    {
        if (BitIndices.Count == 0)
        {
            return Name;
        }

        var builder = new StringBuilder();
        builder.Append(Name);
        builder.Append('<');
        for (int i = 0; i < BitIndices.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(',');
            }
            builder.Append(BitIndices[i]);
        }
        builder.Append('>');
        return builder.ToString();
    }
}

record EncodingBitValue
{
    public string Value { get; set; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> BitFields { get; } = new();

    public int GetBitFieldsAsInt()
    {
        var value = 0;
        foreach (var x in BitFields)
        {
            foreach(var bitField in x)
            {
                if (bitField == 'x') throw new InvalidOperationException("Cannot convert to int with x");
                Debug.Assert(bitField == '1' || bitField == '0');
                value <<= 1;
                value |= bitField == '1' ? 1 : 0;
            }
        }
        return value;
    }

    public override string ToString() => $"BitFields = {string.Join(":", BitFields)}, Value = {Value}";
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$kind")]
[JsonDerivedType(typeof(RegisterOperandDescriptor), typeDiscriminator: "reg")]
[JsonDerivedType(typeof(RegisterGroupOperandDescriptor), typeDiscriminator: "greg")]
[JsonDerivedType(typeof(ImmediateOperandDescriptor), typeDiscriminator: "imm")]
[JsonDerivedType(typeof(MemoryOperandDescriptor), typeDiscriminator: "mem")]
[JsonDerivedType(typeof(LabelOperandDescriptor), typeDiscriminator: "label")]
[JsonDerivedType(typeof(ImmediateByteValuesOperandDescriptor), typeDiscriminator: "imm-values")]
[JsonDerivedType(typeof(ShiftOperandDescriptor), typeDiscriminator: "shift")]
abstract class OperandDescriptor
{
    public required Arm64OperandKind Kind { get; init; }

    public string Name { get; set; } = string.Empty;
}

sealed class RegisterGroupOperandDescriptor : OperandDescriptor
{
    public required int Count { get; set; }

    public required RegisterOperandDescriptor Register { get; init; }

    public override string ToString() => $"Group {Name}, Count: {Count}, {Register}";
}

sealed class ImmediateOperandDescriptor : OperandDescriptor
{
    public Arm64ImmediateEncodingKind ImmediateKind { get; set; }

    public int BitSize { get; set; }

    public bool IsSigned { get; set; }

    public sbyte FixedValue { get; set; }
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();
    
    public override string ToString()
    {
        var builder = new StringBuilder();
        if (BitSize == 0 && Encoding.Count == 0)
        {
            builder.Append($"Imm {Name}, Signed: {IsSigned}, Value: {FixedValue}");
        }
        else
        {
            builder.Append($"Imm {Name}, Signed: {IsSigned}, Size {BitSize}, Encoding: {string.Join(", ", Encoding)}");
        }

        return builder.ToString();
    }
}

sealed class LabelOperandDescriptor : OperandDescriptor
{
    public Arm64LabelEncodingKind LabelKind { get; set; }

    public int BitSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    public override string ToString() => $"Label {Name}, Kind: {LabelKind}, Size {BitSize}, Encoding: {string.Join(", ", Encoding)}";
}

sealed class ImmediateByteValuesOperandDescriptor : OperandDescriptor
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
}


sealed class MemoryOperandDescriptor : OperandDescriptor
{
    public Arm64MemoryEncodingKind MemoryEncodingKind { get; set; }

    public BitRange BaseRegister;

    public Arm64MemoryExtendEncodingKind ExtendKind { get; set; }

    public sbyte FixedValue { get; set; }

    public bool IsPreIncrement { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> IndexRegisterOrImmediate { get; } = new();
}

sealed class ShiftOperandDescriptor : OperandDescriptor
{
    public Arm64ShiftEncodingKind ShiftKind { get; set; }
    
    public BitRange ShiftEncoding { get; set; }

    public int AmountSize { get; set; }

    public BitRange AmountEncoding { get; set; }
}

sealed class DynamicRegisterSelector
{
    public int SelectorSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> SelectorEncoding { get; } = new();
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitValueToRegister> MapBitValueToRegister { get; } = new();

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

sealed class RegisterOperandDescriptor : OperandDescriptor
{
    public Arm64RegisterEncodingKind RegisterKind { get; set; }

    public Arm64RegisterIndexEncodingKind RegisterIndexEncodingKind { get; set; }

    /// <summary>
    /// If the operand kind is <see cref="Arm64RegisterEncodingKind.DynamicRegXOrW"/>, then the kind of register is selected dynamically
    /// </summary>
    public DynamicRegisterSelector? DynamicRegisterXOrWSelector { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> IndexEncoding { get; } = new();

    public VectorArrangement? VectorArrangement { get; set; }
    
    //[JsonIgnore]
    //public bool HasFixedVectorArrangements
    //{
    //    get
    //    {
    //        return RegisterVectorArrangements.Count == 1 && !RegisterVectorArrangements[0].HasEncoding;
    //    }
    //}

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

        if (RegisterKind == Arm64RegisterEncodingKind.RegV && VectorArrangement != null)
        {
            builder.Append($".{VectorArrangement}");
        }

        if (IndexEncoding.Count > 0)
        {
            builder.Append('[');
            for (int i = 0; i < IndexEncoding.Count; i++)
            {
                if (i > 0)
                {
                    builder.Append(',');
                }
                builder.Append(IndexEncoding[i]);
            }
            builder.Append(']');
        }
        
        return builder.ToString();
    }
}

readonly record struct BitRange(int LowBit, int Width)
{
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
    public Arm64RegisterVectorArrangementEncodingKind ArrangementKind { get; set; }

    public int BitSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    [JsonPropertyName("vaidx")]
    public int VectorArrangementValuesIndex
    {
        get => Values?.Index ?? _vectorArrangementValuesIndex;
        set => _vectorArrangementValuesIndex = value;
    }

    [JsonIgnore]
    public VectorArrangementValues? Values { get; set; }
    
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(ArrangementKind);
        hash.Add(BitSize);
        foreach (var bitRange in Encoding)
        {
            hash.Add(bitRange);
        }

        if (Values is not null)
        {
            foreach (var item in Values)
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

        if (Values.Count != other.Values.Count)
        {
            return false;
        }
        
        for (int i = 0; i < Values.Count; i++)
        {
            if (Values[i] != other.Values[i])
            {
                return false;
            }
        }
        return true;
    }

    [JsonIgnore]
    public string Id => this.ToString();

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
        for (var i = 0; i < Values!.Count; i++)
        {
            var item = Values[i];
            if (i > 0) builder.Append(",");
            builder.Append(item);
        }
        builder.Append("}");
        
        return builder.ToString();
    }
}

sealed class VectorArrangementValues : List<VectorArrangementValue>
{
    [JsonIgnore]
    public string Id => ToString();

    [JsonIgnore]
    public int Index { get; set; }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var item in this)
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
        if (Count != other.Count)
        {
            return false;
        }
        for (int i = 0; i < Count; i++)
        {
            if (this[i] != other[i])
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
        for (int i = 0; i < Count; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }
            builder.Append(this[i]);
        }
        builder.Append("}");
        return builder.ToString();
    }
}