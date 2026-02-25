// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections;
using System.Collections.ObjectModel;
using AsmArm64.CodeGen.Model.JsonHelpers;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

class Instruction : IJsonOnDeserialized
{
    public required string Id { get; set; } = string.Empty;

    public int Index { get; set; }

    public string Mnemonic { get; set; } = string.Empty;

    [JsonIgnore]
    public int MnemonicIndex { get; set; }

    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <c>true</c> if this instruction has been discarded by an alias that is preferred.
    /// </summary>
    public bool IsDiscardedByPreferredAlias { get; set; }

    /// <summary>
    /// <c>true</c> if this instruction is an alias with a dynamic condition.
    /// </summary>
    public bool IsAliasWithDynamicCondition { get; set; }
    
    /// <summary>
    /// <c>true</c> if this instruction is aliased by other instructions from <see cref="AliasesIn"/> and require a dynamic resolution.
    /// </summary>
    public bool HasAliasesInAndRequiringDynamicResolution { get; set; }

    /// <summary>
    /// <c>true</c> if this instruction is an alias that is preferred by a more selective bit mask.
    /// </summary>
    public bool IsAliasPreferredByMoreSelectiveBitMask { get; set; }

    /// <summary>
    /// When not null, this instruction instance is an alias for another instruction defined by <see cref="AliasInfo.InstructionId"/>. when the given <see cref="AliasInfo.Condition"/> is met.
    /// </summary>
    public AliasInfo? Alias { get; set; }
    
    /// <summary>
    /// Gets the list of instructions this instruction is aliased from.
    /// </summary>
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<AliasInfo> AliasesIn { get; } = new();
    
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

    internal bool IsSystem => InstructionClass.Equals("System", StringComparison.OrdinalIgnoreCase);

    [JsonIgnore]
    public byte InstructionClassIndex { get; set; } 

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public Dictionary<string, string> DocVars { get; } = new();
    
    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint BitfieldMask { get; set; }

    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint BitfieldValue { get; set; }

    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint NotBitfieldMask { get; set; }

    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint NotBitfieldValue { get; set; }


    [JsonConverter(typeof(JsonUIntToHexConverter))]
    public uint BitfieldValueForTest { get; set; }

    public bool IsBitFieldValueTestable { get; set; } = true;

    public FeatureExpression? FeatureRequirement { get; set; }

    public string? AsmTemplate { get; set; }

    [JsonIgnore]
    public int FeatureExpressionIdIndex { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRangeInfo> BitRanges { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<Operand> Operands { get; } = new();
    
    [JsonIgnore]
    public Dictionary<string, BitRangeInfo> BitRangeMap { get; } = new();

    public bool UseOperandEncoding8Bytes { get; set; }

    public int TableEncodingOffset { get; set; }

    public void Encode(Span<byte> buffer)
    {
        MemoryMarshal.Write(buffer, (ushort)Index);
        MemoryMarshal.Write(buffer.Slice(2), (ushort)MnemonicIndex);
        buffer[4] = (byte)InstructionClassIndex;
        buffer[5] = (byte)FeatureExpressionIdIndex;
        var flags = UseOperandEncoding8Bytes ? Arm64InstructionEncodingFlags.Encoding8Bytes : Arm64InstructionEncodingFlags.None;
        if (Operands.Any(x => x.Descriptor is LabelOperandDescriptor))
        {
            flags |= Arm64InstructionEncodingFlags.HasLabel;
        }

        if (DocVars.TryGetValue("cond-setting", out var str) && str.Equals("S", StringComparison.OrdinalIgnoreCase))
        {
            flags |= Arm64InstructionEncodingFlags.HasSetFlags;
        }
        buffer[6] = (byte)flags;
        buffer[7] = (byte)Operands.Count;
    }
    
    public void Add(BitRangeInfo bitRangeInfo)
    {
        var existingField = BitRanges.FirstOrDefault(x => x.HiBit == bitRangeInfo.HiBit && x.Width == bitRangeInfo.Width);

        if (existingField != null)
        {
            Debug.Assert(existingField.BitFieldSet!.Count == bitRangeInfo.BitFieldSet.Count);

            existingField.Condition = bitRangeInfo.Condition;
            existingField.OriginalCondition = bitRangeInfo.OriginalCondition;

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

    public static string NormalizeId(string nameToNormalize)
    {
        var name = nameToNormalize.TrimEnd('_');
        var indexOfUnderscore = name.IndexOf('_');
        var id = indexOfUnderscore > 0 ? $"{name.Substring(0, indexOfUnderscore).ToUpperInvariant()}{name.Substring(indexOfUnderscore).ToLowerInvariant()}" : name.ToUpperInvariant();
        return id;
    }
    
    public void Initialize()
    {
        foreach (var bitfieldInfo in BitRanges)
        {
            var fieldSets = bitfieldInfo.BitFieldSet;
            var lowBit = bitfieldInfo.HiBit - (bitfieldInfo.Width - 1);

            if (bitfieldInfo.Condition == BitRangeCondition.AllNonZero)
            {
                BitfieldValueForTest |= 1U << lowBit;
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

            BitfieldMask |= mask << lowBit;
            BitfieldValue |= value << lowBit;

            if (bitfieldInfo.Condition != BitRangeCondition.None)
            {
                mask = (1U << (bitfieldInfo.Width + 1)) - 1;
                switch (bitfieldInfo.Condition)
                {
                    case BitRangeCondition.AllNonZero:
                        NotBitfieldMask |= mask << lowBit;
                        break;
                    case BitRangeCondition.AllNonOne:
                        NotBitfieldMask |= mask << lowBit;
                        NotBitfieldValue |= mask << lowBit;
                        break;
                    case BitRangeCondition.AllNon111x:
                        NotBitfieldMask |= 0b1110U << lowBit;
                        NotBitfieldValue |= 0b1110U << bitfieldInfo.HiBit - (bitfieldInfo.Width - 1);
                        break;
                    case BitRangeCondition.AllNon11xxx:
                        NotBitfieldMask |= 0b11000U << lowBit;
                        NotBitfieldValue |= 0b11000U << lowBit;
                        break;
                    case BitRangeCondition.AllNon011:
                        NotBitfieldMask |= 0b111U << lowBit;
                        NotBitfieldValue |= 0b011U << lowBit;
                        break;
                    case BitRangeCondition.AllNon011111:
                        NotBitfieldMask |= 0b111111U << lowBit;
                        NotBitfieldValue |= 0b011111U << lowBit;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        BitfieldValueForTest |= BitfieldValue;

        UpdateBitRangeMap();
    }
    
    public void UpdateSignatureFromOperands()
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
        builder.Append($"{Id,-32} {Mnemonic,-12} Mask: 0x{BitfieldMask:X8}, Bits: 0x{BitfieldValue:X8}");

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

record AliasInfo(string InstructionId, string Condition)
{
    public required bool IsOut { get; init; }

    public bool IsAlways => Condition.Equals("Unconditionally", StringComparison.OrdinalIgnoreCase);

    public bool IsNever => Condition.Equals("Never", StringComparison.OrdinalIgnoreCase);

    public bool IsSpecial => !IsAlways && !IsNever;
}

