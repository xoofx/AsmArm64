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
