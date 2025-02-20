// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

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


    public EncodingSymbolsInfo Clone()
    {
        var clone = new EncodingSymbolsInfo
        {
            Name = Name
        };
        foreach (var pair in Symbols)
        {
            clone.Symbols.Add(pair.Key, pair.Value.Clone());
        }
        return clone;
    }



}

[DebuggerDisplay("Link = {Link}, EncodedIn = {EncodedInText}, BitRanges = {BitRanges.Count}")]
class EncodingSymbol
{
    public required string Link { get; init; } = string.Empty;

    public required string Name { get; init; } = string.Empty;

    /// <summary>
    /// Gets or sets the encoding of this symbol.
    /// </summary>
    public string EncodedInText { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsSignedImmediate { get; set; }

    public int BitSize { get; set; }

    public BitRangeCondition Condition { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> BitNames { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public BitRangeList BitRanges { get; } = new();

    /// <summary>
    /// Gets or sets the selector.
    /// </summary>
    public EncodingSymbolSelector? Selector { get; set; }

    public EncodingSymbol Clone()
    {
        var clone = new EncodingSymbol
        {
            Link = Link,
            Name = Name,
            EncodedInText = EncodedInText,
            Condition = Condition,
            IsSignedImmediate = IsSignedImmediate,
            BitSize = BitSize
        };
        clone.BitNames.AddRange(BitNames);
        clone.BitRanges.AddRange(BitRanges);
        if (Selector is not null)
        {
            clone.Selector = Selector.Clone();
        }
        return clone;
    }

    public void Initialize(Dictionary<string, BitRangeInfo> map)
    {
        // Already initialized
        if (BitNames.Count > 0) return;

        var bitItems = new List<BitValueItem>();
        BitValueItem.ParseList(EncodedInText, map, bitItems, BitNames);

        // Copy the condition in simple cases (e.g. registers cannot be 31)
        if (BitNames.Count == 1 && map.TryGetValue(BitNames[0], out var simpleCondition))
        {
            Condition = simpleCondition.Condition;
        }

        var bitSize = 0;
        foreach (var bitItem in bitItems)
        {
            Debug.Assert(bitItem.Kind == BitValueItemKind.BitRange);
            BitRanges.Add(bitItem.Range);
            bitSize += bitItem.Range.Width;
        }
        BitRanges.Compact();
        BitSize = bitSize;

        if (Selector is not null)
        {
            Selector.Initialize(map);

            // Encode the selector relative to the encoding of the symbol
            Selector.RelativeBitRanges.Clear();
            Selector.RelativeBitRanges.AddRange(Selector.BitRanges);
            Selector.RelativeBitRanges.EncodeRelativeTo(BitRanges);
            Selector.RelativeBitRanges.Compact();

            foreach (var bitValue in Selector.BitValues)
            {
                // Remove any leading 0 as we will mask them out anyway when decoding
                for (var i = 0; i < bitValue.BitItems.Count; i++)
                {
                    var bitItem = bitValue.BitItems[i];
                    if (bitItem.Kind == BitValueItemKind.Bit0)
                    {
                        bitValue.BitItems.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }

                bool allBitRange = true;
                for (var i = 0; i < bitValue.BitItems.Count; i++)
                {
                    var bitItem = bitValue.BitItems[i];
                    if (bitItem.Kind == BitValueItemKind.BitRange)
                    {
                        var relativeItem = new BitValueItem(bitItem.Kind, bitItem.Range.EncodeRelativeTo(BitRanges));
                        bitValue.RelativeBitItems.Add(relativeItem);
                    }
                    else
                    {
                        Debug.Assert(bitValue.RelativeBitItems.Count == 0);
                        allBitRange = false;
                    }
                }

                if (allBitRange)
                {
                    // Compact the bit items
                    for (var i = bitValue.RelativeBitItems.Count - 1; i >= 1; i--)
                    {
                        var current = bitValue.RelativeBitItems[i];
                        var previous = bitValue.RelativeBitItems[i - 1];
                        if (current.Range.LowBit + current.Range.Width == previous.Range.LowBit)
                        {
                            bitValue.RelativeBitItems[i - 1] = new(BitValueItemKind.BitRange, new(current.Range.LowBit, previous.Range.Width + current.Range.Width));
                            bitValue.RelativeBitItems.RemoveAt(i);
                        }
                    }
                }
            }

            // Remove reserved values (that we don't need to decode)
            for (var i = Selector.BitValues.Count - 1; i >= 0; i--)
            {
                var bitValue = Selector.BitValues[i];
                if (bitValue.Kind == EncodingBitValueKind.Reserved)
                {
                    Selector.BitValues.RemoveAt(i);
                }
            }
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"Symbol Name: {Name}, Link: {Link}, EncodedIn: {EncodedInText}, BitRanges: [{string.Join(", ", BitRanges)}]");
        if (Selector is not null)
        {
            builder.AppendLine();
            Selector.ToString(builder, true);
        }
        return builder.ToString();
    }
}

/// <summary>
/// A selector associate a set of bits from an encoding to a value
/// </summary>
class EncodingSymbolSelector
{
    public int Index { get; set; }

    public int BitSize { get; set; }

    public EncodingSymbolSelectorKind Kind { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> BitNames { get; } = new();

    /// <summary>
    /// Gets the bit ranges encoding of relative to the <see cref="EncodingSymbolExtract"/>
    /// </summary>
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public BitRangeList RelativeBitRanges { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public BitRangeList BitRanges { get; } = new();

    /// <summary>
    /// Gets the mask of the bits covered by <see cref="RelativeBitRanges"/> of this selector.
    /// </summary>
    public uint BitEncodingMask { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingBitValue> BitValues { get; } = new();
    
    /// <summary>
    /// A list of action when the index of this class is assigned
    /// </summary>
    [JsonIgnore]
    public List<Action<int>> OnIndexAssigned { get; } = new();

    public EncodingSymbolSelector Clone()
    {
        var clone = new EncodingSymbolSelector
        {
            Index = Index,
            BitSize = BitSize,
            Kind = Kind
        };
        clone.BitNames.AddRange(BitNames);
        clone.RelativeBitRanges.AddRange(RelativeBitRanges);
        clone.BitRanges.AddRange(BitRanges);
        clone.BitEncodingMask = BitEncodingMask;
        foreach (var bitValue in BitValues)
        {
            clone.BitValues.Add(bitValue.Clone());
        }
        return clone;
    }

    public string GetId()
    {
        var builder = new StringBuilder();
        AppendUniqueId(builder);
        return builder.ToString();
    }

    public void AppendUniqueId(StringBuilder builder)
    {
        builder.Append(BitSize);
        builder.Append(' ');
        builder.Append($"[{string.Join(",", BitRanges)}] ");
        builder.Append('[');
        for (var i = 0; i < BitValues.Count; i++)
        {
            var bitValue = BitValues[i];
            if (i > 0) builder.Append(',');
            bitValue.AppendUniqueId(builder);
        }
        builder.Append(']');
    }
    
    public void Initialize(Dictionary<string, BitRangeInfo> map)
    {
        // Either we have nothing to initialize or we have been already initialized
        if (BitNames.Count == 0 || BitRanges.Count > 0)
        {
            return;
        }

        var bitItems = new List<BitValueItem>();
        var bitSize = 0;
        foreach (var name in BitNames)
        {
            bitItems.Clear();
            BitValueItem.ParseList(name, map, bitItems);

            foreach (var bitValueItem in bitItems)
            {
                Debug.Assert(bitValueItem.Kind == BitValueItemKind.BitRange);

                var bitRange = bitValueItem.Range;

                if (BitRanges.Count > 0 && BitRanges[^1].LowBit == bitRange.LowBit)
                {
                    BitRanges[^1] = new BitRange(bitRange.LowBit, BitRanges[^1].Width + bitRange.Width);
                }
                else
                {
                    BitRanges.Add(new BitRange(bitRange.LowBit, bitRange.Width));
                }
                bitSize += bitRange.Width;
            }
        }

        BitSize = bitSize;

        // Calculate the mask
        BitEncodingMask = 0;
        foreach (var bitRange in BitRanges)
        {
            BitEncodingMask |= ((1U << bitRange.Width) - 1) << bitRange.LowBit;
        }
        
        foreach (var bitValue in BitValues)
        {
            bitValue.Initialize(map, BitRanges);
        }

        // Update the kind
        Kind = BitValues.Any(x => x.Kind != EncodingBitValueKind.Reserved && x.LocalBitSelectorMask != 0) ? EncodingSymbolSelectorKind.Masked : EncodingSymbolSelectorKind.Regular;
    }

    public void ToString(StringBuilder builder, bool indent = false)
    {
        builder.AppendLine($"{(indent?"  " : string.Empty)}Selector BitNames: [{string.Join(", ", BitNames)}], BitRanges: [{string.Join(", ", BitRanges)}]");
        for (var i = 0; i < BitValues.Count; i++)
        {
            var bitValue = BitValues[i];
            builder.AppendLine($"{(indent ? "  " : string.Empty)}  [{i}] {bitValue}");
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        ToString(builder, false);
        return builder.ToString();
    }
}

class EncodingBitValue
{
    public EncodingBitValueKind Kind { get; set; }

    public string Text { get; set; } = string.Empty;

    public int IntegerValue { get; set; }

    public int FloatValue { get; set; }

    public int LocalBitSelectorSize { get; set; }

    public string LocalBitSelectorAsText { get; set; } = string.Empty;

    public uint LocalBitSelectorMask { get; set; }

    public uint LocalBitSelectorValue { get; set; }

    public uint BitSelectorMask { get; set; }

    public uint BitSelectorValue { get; set; }

    /// <summary>
    /// Used when <see cref="Kind"/> is <see cref="EncodingBitValueKind.BitExtract"/>
    /// </summary>
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitValueItem> BitItems { get; } = new();

    /// <summary>
    /// Used when <see cref="Kind"/> is <see cref="EncodingBitValueKind.BitExtract"/> relative to the <see cref="EncodingSymbolSelector.BitRanges"/>
    /// </summary>
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitValueItem> RelativeBitItems { get; } = new();

    /// <summary>
    /// When <see cref="Kind"/> is <see cref="EncodingBitValueKind.BitExtract"/>, this is the addend to apply to the extracted bits.
    /// </summary>
    public int Addend { get; set; }

    public bool HasNegativeExtract { get; set; }

    public EncodingBitValue Clone()
    {
        var clone = new EncodingBitValue
        {
            Kind = Kind,
            Text = Text,
            IntegerValue = IntegerValue,
            FloatValue = FloatValue,
            LocalBitSelectorSize = LocalBitSelectorSize,
            LocalBitSelectorAsText = LocalBitSelectorAsText,
            LocalBitSelectorMask = LocalBitSelectorMask,
            LocalBitSelectorValue = LocalBitSelectorValue,
            BitSelectorMask = BitSelectorMask,
            BitSelectorValue = BitSelectorValue,
            Addend = Addend,
            HasNegativeExtract = HasNegativeExtract
        };
        clone.BitItems.AddRange(BitItems);
        clone.RelativeBitItems.AddRange(RelativeBitItems);
        return clone;
    }

    public void AppendUniqueId(StringBuilder builder)
    {
        // We assume that the other fields are decoded from this
        builder.Append($"({Kind} {LocalBitSelectorAsText} -> `{Text}`)");
    }

    public void Initialize(Dictionary<string, BitRangeInfo> bitRangeMap, BitRangeList bitRangeList)
    {
        Debug.Assert(BitItems.Count == 0);

        if (LocalBitSelectorAsText.Contains('x'))
        {
            uint maskValue = 0;
            uint value = 0;
            foreach (var c in LocalBitSelectorAsText)
            {
                Debug.Assert(c == '0' || c == '1' || c == 'x');
                maskValue <<= 1;
                maskValue |= (c == 'x') ? 0U : 1;
                value <<= 1;
                value |= (c == '1') ? 1U : 0;
            }
            LocalBitSelectorMask = maskValue;
            LocalBitSelectorValue = value;
        }
        else
        {
            uint value = 0;
            foreach (var c in LocalBitSelectorAsText)
            {
                Debug.Assert(c == '0' || c == '1');
                value <<= 1;
                value |= (c == '1') ? 1U : 0;
            }
            LocalBitSelectorValue = value;
        }

        LocalBitSelectorSize = LocalBitSelectorAsText.Length;

        // Calculate the full mask/selector value based on the actual position in a uint with the bitRangeList
        int bitPosition = 0;
        var localBitSelectorMask = LocalBitSelectorMask == 0 ? ((1U << LocalBitSelectorSize) - 1) : LocalBitSelectorMask;
        for (int i = bitRangeList.Count - 1; i >= 0; i--)
        {
            var bitRange = bitRangeList[i];
            BitSelectorValue |= ((LocalBitSelectorValue >> bitPosition) & ((1U << bitRange.Width) - 1)) << bitRange.LowBit;
            BitSelectorMask |= ((localBitSelectorMask >> bitPosition) & ((1U << bitRange.Width) - 1)) << bitRange.LowBit;
            bitPosition += bitRange.Width;
        }

        if (Text == "RESERVED")
        {
            Kind = EncodingBitValueKind.Reserved;
        }
        else if (MatchInteger.IsMatch(Text))
        {
            Kind = EncodingBitValueKind.Integer;
            IntegerValue = int.Parse(Text);
        }
        else if (MatchFloat.IsMatch(Text))
        {
            Kind = EncodingBitValueKind.Float;
            FloatValue = int.Parse(Text);
        }
        else if (Text.Contains("UInt(")) // Dynamic encoding
        {
            Kind = EncodingBitValueKind.BitExtract;
            // UInt(imm5<1:0>)
            // UInt(imm5<4>)
            // UInt('0':Rm)
            // UInt(M:Rm)
            // UInt(H:L:M)
            // UInt(immh:immb) - 8
            // 32 - UInt(immh:immb)

            var text = Text.Replace(" ", string.Empty, StringComparison.Ordinal);

            bool negative = false;
            int addend = 0;

            var span = text.AsSpan();
            // Simple handling of cases
            while (!span.IsEmpty)
            {
                var matches = MatchPositiveInteger.EnumerateMatches(span);
                if (matches.MoveNext())
                {
                    Debug.Assert(addend == 0);
                    var match = matches.Current;
                    addend = int.Parse(span.Slice(match.Index, match.Length));
                    if (negative)
                    {
                        negative = false;
                    }
                    span = span.Slice(match.Index + match.Length);
                }
                else if (span[0] == '-')
                {
                    // addend
                    negative = true;
                    span = span.Slice(1);
                }
                else
                {
                    Debug.Assert(BitItems.Count == 0); // We support only one extract pattern for now
                    if (negative)
                    {
                        HasNegativeExtract = true;
                        negative = false;
                    }

                    var check = span.StartsWith("UInt(");
                    Debug.Assert(check, $"Error cannot match symbol value {Text}");
                    span = span.Slice("UInt(".Length);
                    var endIndex = span.IndexOf(')');
                    Debug.Assert(endIndex >= 0);
                    var bits = span.Slice(0, endIndex).ToString();
                    BitValueItem.ParseList(bits, bitRangeMap, BitItems);

                    span = span.Slice(endIndex + 1);
                }
            }
            Addend = addend;

        }
        else if (Text.StartsWith('#'))
        {
            var immText = Text.Substring(1);
            if (MatchInteger.IsMatch(immText))
            {
                Kind = EncodingBitValueKind.Integer;
                IntegerValue = int.Parse(immText);
            }
            else
            {
                Debug.Assert(MatchFloat.IsMatch(immText));
                Kind = EncodingBitValueKind.Float;
                FloatValue = int.Parse(immText);
            }
        }
        else
        {
            Kind = EncodingBitValueKind.Text;
        }
    }

    private static readonly Regex MatchPositiveInteger = new("^[0-9]+");

    private static readonly Regex MatchInteger = new("^-?[0-9]+$");

    private static readonly Regex MatchFloat = new("^-?[0-9]+\\.[0-9]+$");

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(Kind);
        if (LocalBitSelectorMask != 0)
        {
            builder.Append($" Mask(0x{LocalBitSelectorMask:X})");
        }
        builder.Append($" Select(0x{LocalBitSelectorValue:X}) -> ");

        switch (Kind)
        {
            case EncodingBitValueKind.Text:
                builder.Append(Text);
                break;
            case EncodingBitValueKind.Integer:
                builder.Append(IntegerValue);
                break;
            case EncodingBitValueKind.Float:
                builder.Append(FloatValue);
                break;
            case EncodingBitValueKind.BitExtract:
                builder.Append($"[{string.Join(", ", BitItems)}]");
                break;

            default:
                Debug.Assert(false);
                break;
        }

        return builder.ToString();
    }
}

readonly record struct BitValueItem(BitValueItemKind Kind, BitRange Range)
{
    public static void ParseList(string text, Dictionary<string, BitRangeInfo> mapBitNameToBitRangeInfo, List<BitValueItem> bitItems, List<string>? names = null)
    {
        int index = 0;
        var span = text.AsSpan();
        while (index < text.Length)
        {
            if (span.Slice(index).StartsWith("'0'"))
            {
                bitItems.Add(new(BitValueItemKind.Bit0, default));
                index += 3;
                names?.Add("'0'");
            }
            else if (text[index] == ':')
            {
                index++;
            }
            else
            {
                var subText = text.Substring(index);
                var matchPart = MatchName.Match(subText);
                Debug.Assert(matchPart.Success, $"Error cannot match symbol part value {span.Slice(index).ToString()}");
                names?.Add(matchPart.Value);
                
                var partName = matchPart.Groups["name"].Value;
                var matchBitIndices = matchPart.Groups["bitIndices"];

                var bitRangeInfo = mapBitNameToBitRangeInfo[partName];
                var bitRange = new BitRange(bitRangeInfo.HiBit - bitRangeInfo.Width + 1, bitRangeInfo.Width);

                if (matchBitIndices.Success)
                {
                    var indices = matchBitIndices.Value.Split(':').Select(x => int.Parse(x)).ToArray();

                    Debug.Assert(indices.Length == 1 || indices.Length == 2);

                    BitRange range;

                    if (indices.Length == 1)
                    {
                        var bitIndex = indices[0];
                        range = new BitRange(bitRange.LowBit + bitIndex, 1);
                    }
                    else
                    {
                        var bitIndex = indices[1];
                        var bitWidth = indices[0] - bitIndex + 1;
                        range = new BitRange(bitRange.LowBit + bitIndex, bitWidth);
                    }

                    if (bitItems.Count > 0 && bitItems[^1].Kind == BitValueItemKind.BitRange && bitItems[^1].Range.LowBit == range.LowBit + range.Width)
                    {
                        // Merge with previous range
                        bitItems[^1] = new(BitValueItemKind.BitRange, new BitRange(range.LowBit, bitItems[^1].Range.Width + range.Width));
                    }
                    else
                    {
                        bitItems.Add(new(BitValueItemKind.BitRange, range));
                    }
                }
                else
                {
                    if (bitItems.Count > 0 && bitItems[^1].Kind == BitValueItemKind.BitRange && bitItems[^1].Range.LowBit == bitRange.LowBit + bitRange.Width)
                    {
                        // Merge with previous range
                        bitItems[^1] = new(BitValueItemKind.BitRange, new BitRange(bitRange.LowBit, bitItems[^1].Range.Width + bitRange.Width));
                    }
                    else
                    {
                        bitItems.Add(new(BitValueItemKind.BitRange, bitRange));
                    }
                }

                index += matchPart.Length;
            }
        }
    }

    public override string ToString() => Kind == BitValueItemKind.BitRange ? $"({Kind} - {Range})" : Kind.ToString();

    private static readonly Regex MatchName = new("^(?<name>[A-Za-z][A-Za-z0-9_]*)(<(?<bitIndices>[^>]+)>)?");
}

enum BitValueItemKind
{
    Bit0 = 0,
    BitRange = 2,
}

enum EncodingBitValueKind
{
    /// <summary>
    /// The value is a text (possibly enum)
    /// </summary>
    Text,
    /// <summary>
    /// The value is extracted from the encoding of the instruction.
    /// </summary>
    BitExtract,
    /// <summary>
    /// The value is an integer.
    /// </summary>
    Integer,
    /// <summary>
    /// The value is a float.
    /// </summary>
    Float,
    /// <summary>
    /// The value is RESERVED
    /// </summary>
    Reserved
}

sealed class BitRangeList : List<BitRange>
{
    public void EncodeRelativeTo(BitRangeList otherList)
    {
        for (var i = 0; i < Count; i++)
        {
            var bitRange = this[i];
            this[i] = bitRange.EncodeRelativeTo(otherList);
        }
    }

    /// <summary>
    /// Compacts the list by merging adjacent ranges.
    /// </summary>
    public void Compact()
    {
        for(int i = Count - 1; i >= 1; i--)
        {
            var current = this[i];
            var previous = this[i - 1];
            if (current.LowBit + current.Width == previous.LowBit)
            {
                this[i - 1] = new(current.LowBit, previous.Width + current.Width);
                RemoveAt(i);
            }
        }
    }
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$kindExtract")]
[JsonDerivedType(typeof(EncodingSymbolExtract), typeDiscriminator: "symbol")]
[JsonDerivedType(typeof(EncodingVectorArrangementExtract), typeDiscriminator: "vector-arrangement")]
[JsonDerivedType(typeof(EncodingIndexerExtract), typeDiscriminator: "indexer")]
record EncodingSymbolExtract
{
    private int _selectorIndex;
    public int Index { get; set; }

    /// <summary>
    /// A list of action when the index of this symbol is assigned
    /// </summary>
    [JsonIgnore]
    public List<Action<int>> OnIndexAssigned { get; } = new();

    public int BitSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> BitRanges { get; } = new();

    public int SelectorIndex
    {
        get => Selector?.Index ?? _selectorIndex;
        set => _selectorIndex = value;
    }

    [JsonIgnore]
    public EncodingSymbolSelector? Selector { get; set; }

    /// <summary>
    /// Track usage of this symbol extract (for tracing it back in the codegen).
    /// </summary>
    [JsonIgnore]
    public List<(Instruction Instruction, OperandItem OperandItem)> Usages { get; } = new();

    public void AppendUniqueId(StringBuilder builder)
    {
        builder.Append(BitSize);
        builder.Append(' ');
        builder.Append($"[{string.Join(",", BitRanges)}] ");
    }
}

record EncodingVectorArrangementExtract : EncodingSymbolExtract
{
    public Arm64RegisterVectorArrangementEncodingKind Kind { get; set; }
    
    public static Arm64RegisterVectorArrangementEncodingKind ParseArrangementKind(string text)
    {
        switch (text)
        {
            case "16B":
                return Arm64RegisterVectorArrangementEncodingKind.T_16B;
            case "8B":
                return Arm64RegisterVectorArrangementEncodingKind.T_8B;
            case "4B":
                return Arm64RegisterVectorArrangementEncodingKind.T_4B;
            case "2B":
                return Arm64RegisterVectorArrangementEncodingKind.T_2B;
            case "2H":
                return Arm64RegisterVectorArrangementEncodingKind.T_2H;
            case "4H":
                return Arm64RegisterVectorArrangementEncodingKind.T_4H;
            case "8H":
                return Arm64RegisterVectorArrangementEncodingKind.T_8H;
            case "2S":
                return Arm64RegisterVectorArrangementEncodingKind.T_2S;
            case "4S":
                return Arm64RegisterVectorArrangementEncodingKind.T_4S;
            case "2D":
                return Arm64RegisterVectorArrangementEncodingKind.T_2D;
            case "1D":
                return Arm64RegisterVectorArrangementEncodingKind.T_1D;
            case "1Q":
                return Arm64RegisterVectorArrangementEncodingKind.T_1Q;
            case "T":
                return Arm64RegisterVectorArrangementEncodingKind.T;
            case "D":
                return Arm64RegisterVectorArrangementEncodingKind.D;
            case "H":
                return Arm64RegisterVectorArrangementEncodingKind.H;
            case "B":
                return Arm64RegisterVectorArrangementEncodingKind.B;
            case "S":
                return Arm64RegisterVectorArrangementEncodingKind.S;
            case "RESERVED":
                return Arm64RegisterVectorArrangementEncodingKind.Reserved;
            default:
                if (text.StartsWith("T"))
                {
                    return Arm64RegisterVectorArrangementEncodingKind.T;
                }
                else
                {
                    throw new NotSupportedException($"Unsupported arrangement `{text}`");
                }
        }
    }
}

record EncodingIndexerExtract : EncodingSymbolExtract
{
    public string? FixedIndex { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
enum EncodingSymbolSelectorKind
{
    None,
    /// <summary>
    /// No mask used by the encoding selector.
    /// </summary>
    Regular,
    /// <summary>
    /// Mask used by the encoding selector.
    /// </summary>
    Masked
}

