// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;

namespace AsmArm64.CodeGen;

class Instruction
{
    public string Filename { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string NormalizedName { get; set; } = string.Empty;

    public string Mnemonic { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public string InstructionClass { get; set; } = string.Empty;

    public uint BitfieldMask { get; set; }

    public uint BitfieldValue { get; set; }
    
    public uint BitfieldValueForTest { get; set; }

    public bool IsBitFieldValueTestable { get; set; } = true;

    public List<ArchVariant> ArchVariants { get; } = new();

    public List<BitRangeInfo> BitFields { get; } = new();
    
    public void Add(BitRangeInfo bitRangeInfo)
    {
        var existingField = BitFields.FirstOrDefault(x => x.HiBit == bitRangeInfo.HiBit && x.Width == bitRangeInfo.Width);

        if (existingField != null)
        {
            Debug.Assert(existingField.FieldSets!.Count == bitRangeInfo.FieldSets.Count);

            for (var i = 0; i < bitRangeInfo.FieldSets.Count; i++)
            {
                if (bitRangeInfo.FieldSets![i] != BitKind.NotSet)
                {
                    existingField.FieldSets[i] = bitRangeInfo.FieldSets[i];
                }
            }
        }
        else
        {
            BitFields.Add(bitRangeInfo.Clone());
        }
    }

    public void Build()
    {
        var name = Name.TrimEnd('_');
        var indexOfUnderscore = name.IndexOf('_');
        NormalizedName = indexOfUnderscore > 0 ? $"{name.Substring(0, indexOfUnderscore).ToUpperInvariant()}{name.Substring(indexOfUnderscore).ToLowerInvariant()}" : name.ToUpperInvariant();
        
        foreach (var bitfieldInfo in BitFields)
        {
            var fieldSets = bitfieldInfo.FieldSets;

            if (bitfieldInfo.Condition == BitRangeCondition.AllNonZero)
            {
                BitfieldValueForTest |= (1U << (bitfieldInfo.HiBit - (bitfieldInfo.Width - 1)));
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

            BitfieldMask |= mask << (bitfieldInfo.HiBit - (bitfieldInfo.Width - 1));
            BitfieldValue |= value << (bitfieldInfo.HiBit - (bitfieldInfo.Width - 1));
        }

        BitfieldValueForTest |= BitfieldValue;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"{Name,-32} {Mnemonic,-12} Mask: 0x{BitfieldMask:X8}, Bits: 0x{BitfieldValue:X8}");

        foreach (var bitField in BitFields)
        {
            if ((BitfieldMask & (1 << bitField.HiBit)) != 0)
            {
                continue;
            }

            builder.Append($", {bitField}");
        }

        builder.Append($", BitFieldTest: {IsBitFieldValueTestable}");

        builder.Append($" (Filename: {Filename})");

        return builder.ToString();
    }
}