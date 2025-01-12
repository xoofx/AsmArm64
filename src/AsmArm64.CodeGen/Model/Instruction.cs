// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections;
using System.Collections.ObjectModel;
using AsmArm64.CodeGen.Model.JsonHelpers;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

class Instruction : IJsonOnDeserialized
{
    public string Id { get; set; } = string.Empty;

    public string Mnemonic { get; set; } = string.Empty;
    
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the syntax of the operands of this instruction.
    /// </summary>
    public string OperandsSyntax { get; set; } = string.Empty;

    /// <summary>
    /// Gets the full syntax of this instruction.
    /// </summary>
    [JsonIgnore]
    public string FullSyntax => $"{Mnemonic,-11} {OperandsSyntax}";

    public string Filename { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public string InstructionClass { get; set; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public Dictionary<string, string> DocVars { get; } = new();
    
    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint BitfieldMask { get; set; }

    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint BitfieldValue { get; set; }

    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint BitfieldValueForTest { get; set; }

    public bool IsBitFieldValueTestable { get; set; } = true;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<ArchVariant> ArchVariants { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRangeInfo> BitRanges { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<Operand> Operands { get; } = new();
    
    [JsonIgnore]
    public Dictionary<string, BitRangeInfo> BitRangeMap { get; } = new();

    public void Add(BitRangeInfo bitRangeInfo)
    {
        var existingField = BitRanges.FirstOrDefault(x => x.HiBit == bitRangeInfo.HiBit && x.Width == bitRangeInfo.Width);

        if (existingField != null)
        {
            Debug.Assert(existingField.BitFieldSet!.Count == bitRangeInfo.BitFieldSet.Count);

            for (var i = 0; i < bitRangeInfo.BitFieldSet.Count; i++)
            {
                if (bitRangeInfo.BitFieldSet![i] != BitKind.NotSet)
                {
                    existingField.BitFieldSet[i] = bitRangeInfo.BitFieldSet[i];
                }
            }
        }
        else
        {
            BitRanges.Add(bitRangeInfo.Clone());
        }
    }

    public void Build()
    {
        var name = Name.TrimEnd('_');
        var indexOfUnderscore = name.IndexOf('_');
        Id = indexOfUnderscore > 0 ? $"{name.Substring(0, indexOfUnderscore).ToUpperInvariant()}{name.Substring(indexOfUnderscore).ToLowerInvariant()}" : name.ToUpperInvariant();
        
        foreach (var bitfieldInfo in BitRanges)
        {
            var fieldSets = bitfieldInfo.BitFieldSet;

            if (bitfieldInfo.Condition == BitRangeCondition.AllNonZero)
            {
                BitfieldValueForTest |= 1U << bitfieldInfo.HiBit - (bitfieldInfo.Width - 1);
            }

            var mask = 0u;
            var value = 0u;
            for (var i = 0; i < fieldSets.Count; i++)
            {
                mask <<= 1;
                value <<= 1;
                var bitKind = fieldSets[i];
                if (bitKind == BitKind.NotSet)
                {
                    continue;
                }

                mask |= 1;
                if (bitKind == BitKind.One)
                {
                    value |= 1;
                }
            }

            BitfieldMask |= mask << bitfieldInfo.HiBit - (bitfieldInfo.Width - 1);
            BitfieldValue |= value << bitfieldInfo.HiBit - (bitfieldInfo.Width - 1);
        }

        BitfieldValueForTest |= BitfieldValue;

        UpdateBitRangeMap();

        UpdateSignature();
    }

    public void UpdateSignature()
    {
        var builder = new StringBuilder();
        for (var i = 0; i < Operands.Count; i++)
        {
            var item = Operands[i];
            var itemStr = item.ToString();

            // If next parameter is optional, we want to add the `{` before the `,`
            if (i > 0 && item.Kind == OperandKind.OptionalGroup)
            {
                builder.Append(" {");
                Debug.Assert(itemStr.StartsWith('{'));
                itemStr = itemStr.Substring(1);
            }

            if (i > 0)
            {
                builder.Append(", ");
            }

            builder.Append(itemStr);
        }

        OperandsSyntax = builder.ToString();
    }

    public void UpdateBitRangeMap()
    {
        BitRangeMap.Clear();
        foreach (var bitRange in BitRanges)
        {
            if (bitRange.Name is not null)
            {
                BitRangeMap[bitRange.Name] = bitRange;
            }
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"{Name,-32} {Mnemonic,-12} Mask: 0x{BitfieldMask:X8}, Bits: 0x{BitfieldValue:X8}");

        foreach (var bitField in BitRanges)
        {
            if ((BitfieldMask & 1 << bitField.HiBit) != 0)
            {
                continue;
            }

            builder.Append($", {bitField}");
        }

        builder.Append($", BitFieldTest: {IsBitFieldValueTestable}");

        builder.Append($" (Filename: {Filename})");

        return builder.ToString();
    }

    void IJsonOnDeserialized.OnDeserialized()
    {
        UpdateBitRangeMap();
    }
}
