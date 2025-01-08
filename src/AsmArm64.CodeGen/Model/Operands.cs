// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AsmArm64.CodeGen;

// Check https://github.com/CensoredUsername/dynasm-rs/blob/master/tools/aarch64_gen_opmap.py for ideas
// https://github.com/wdamron/arm/blob/main/INSTRUCTIONS.md
// https://github.com/wdamron/arm/blob/main/encoding.go

sealed class Operand
{
    public required OperandKind Kind { get; init; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    /// <summary>
    /// If this parameter has a bang `!` at the end.
    /// </summary>
    public bool HasBang { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        switch (Kind)
        {
            case OperandKind.Memory:
                builder.Append('[');
                break;
        }

        for (int i = 0; i < Items.Count; i++)
        {
            var parameter = Items[i];
            var isOptional = parameter is GroupOperandItem { IsOptional: true };
            if (isOptional)
            {
                builder.Append('{');
            }
            if (i > 0)
            {
                builder.Append(',');
            }
            builder.Append(parameter);
            if (isOptional)
            {
                builder.Append('}');
            }
        }

        switch (Kind)
        {
            case OperandKind.Memory:
                builder.Append(']');
                break;
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
    Immediate,
    Value,
    Enum,
    Memory,
    Group,
    RegisterGroup,
    Choice,
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(EnumOperandItem), typeDiscriminator: "enum")]
[JsonDerivedType(typeof(ValueOperandItem), typeDiscriminator: "value")]
[JsonDerivedType(typeof(ImmediateOperandItem), typeDiscriminator: "imm")]
[JsonDerivedType(typeof(GroupOperandItem), typeDiscriminator: "group")]
[JsonDerivedType(typeof(RegisterGroupOperandItem), typeDiscriminator: "reg-group")]
[JsonDerivedType(typeof(RegisterOperandItem), typeDiscriminator: "reg")]
[JsonDerivedType(typeof(SelectOperandItem), typeDiscriminator: "select")]
abstract class OperandItem(OperandItemKind kind)
{
    [JsonIgnore]
    public OperandItemKind Kind { get; } = kind;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandText> TextElements { get; } = new();

    public OperandItem? Indexer;

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
    Immediate,
    Value,
    Enum,
    Group,
    RegisterGroup,
    Select,
}

sealed class EnumOperandItem() : OperandItem(OperandItemKind.Enum);

sealed class ValueOperandItem() : OperandItem(OperandItemKind.Value);

sealed class ImmediateOperandItem() : OperandItem(OperandItemKind.Immediate)
{
    protected override void ToStringPrefix(StringBuilder builder) => builder.Append('#');
}

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
        if (!IsOptional)
        {
            builder.Append('{');
        }
        builder.Append(string.Join(",", Items));
        if (!IsOptional)
        {
            builder.Append('}');
        }
    }
}


sealed class GroupOperandItem() : GroupOperandItemBase(OperandItemKind.Group);

sealed class RegisterGroupOperandItem() : GroupOperandItemBase(OperandItemKind.RegisterGroup);


[method: JsonConstructor]
sealed class OperandText(string text, EncodingSymbol? symbol)
{
    public string Text { get; } = text;

    public EncodingSymbol? Symbol { get; } = symbol;

    public override string ToString() => Symbol is not null ? $"{Text} ({Symbol})" : Text;
}

sealed class RegisterOperandItem() : OperandItem(OperandItemKind.Register)
{
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public RegisterDescriptor Descriptor { get; } = new();
}

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
        builder.Append(string.Join(" | ", Items));
        builder.Append(')');
    }
}

[DebuggerDisplay("Name = {Name}, Symbols = {Symbols.Count}")]
class EncodingInfo
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
    public List<EncodingBitValue> BitValues { get; } = new();

    private string BitInfosDebuggerDisplay => string.Join(":", BitInfos);

    public override string ToString()
    {
        return BitValues.Count > 0 ? $"{BitInfosDebuggerDisplay} ([{string.Join("], [", BitValues)}])" : BitInfosDebuggerDisplay;
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

    public override string ToString() => $"BitFields = {string.Join(":", BitFields)}, Value = {Value}";
}

sealed class RegisterDescriptor
{
    public RegisterIndexKind IndexKind { get; set; }

    public RegisterIndexEncodingKind IndexEncodingKind { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<VectorArrangement> VectorArrangements { get; } = new();

    [JsonIgnore]
    public bool HasFixedVectorArrangements
    {
        get
        {
            return VectorArrangements.Count == 1 && !VectorArrangements[0].HasEncoding;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(IndexKind);

        builder.Append('/');
        builder.Append(IndexEncodingKind);

        if (IndexKind == RegisterIndexKind.V && VectorArrangements.Count > 0)
        {
            builder.Append(".<");
            for (var i = 0; i < VectorArrangements.Count; i++)
            {
                var arrangement = VectorArrangements[i];
                if (i > 0)
                {
                    builder.Append(',');
                }
                builder.Append(arrangement.ArrangementKind);
            }
            builder.Append('>');
        }

        return builder.ToString();
    }
}

readonly record struct BitRange(int HiBit, int Width)
{
    public override string ToString() => $"({HiBit}:{Width})";
}

record struct VectorArrangement(VectorArrangementKind ArrangementKind, bool HasEncoding, int EncodingIndex)
{
    public override string ToString()
    {
        if (HasEncoding)
        {
            return ArrangementKind.ToString();
        }
        var builder = new StringBuilder();
        builder.Append(ArrangementKind);
        if (!HasEncoding)
        {
            builder.Append('!');
        }
        return builder.ToString();
    }
}


[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum RegisterIndexKind
{
    None,
    /// <summary>
    /// 64-bit register
    /// </summary>
    X,
    /// <summary>
    /// 64-bit register or SP (stack pointer)
    /// </summary>
    XOrSP,
    /// <summary>
    /// 32-bit register
    /// </summary>
    W,
    /// <summary>
    /// 32-bit register or WSP (stack pointer)
    /// </summary>
    WOrWSP,
    /// <summary>
    /// 8-bit register from vector registers
    /// </summary>
    B,
    /// <summary>
    /// 16-bit floating point register from vector registers
    /// </summary>
    H,
    /// <summary>
    /// 32-bit floating point register from vector registers
    /// </summary>
    S,
    /// <summary>
    /// 64-bit floating point register from vector registers
    /// </summary>
    D,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    V,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    Q,
    /// <summary>
    /// SVE register
    /// </summary>
    Z,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum RegisterIndexEncodingKind : byte
{
    /// <summary>
    /// No encoding. The register is fixed.
    /// </summary>
    None,
    /// <summary>
    /// 5 bit
    /// </summary>
    Regular5,
    /// <summary>
    /// 4 bit
    /// </summary>
    Regular4,
    /// <summary>
    /// Special size:M:Rm encoding
    /// size:(23:2),M:(20:1),Rm:(19:4)
    /// With Size:
    /// * BitFields = 00, Value = RESERVED
    /// * BitFields = 01, Value = UInt('0':Rm)
    /// * BitFields = 10, Value = UInt(M:Rm)
    /// * BitFields = 11, Value = RESERVED
    /// </summary>
    SpecialMRm,
}



[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum VectorArrangementKind
{
    None,
    S,
    D,

    T_16B,
    T_8B,
    T_4B,
    T_2B,

    T_2H,
    T_8H,

    T_2S,
    T_4S,

    T_2D,
}


