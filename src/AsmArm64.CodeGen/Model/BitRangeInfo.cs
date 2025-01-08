// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using AsmArm64.CodeGen.Model.JsonHelpers;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

class BitRangeInfo
{
    public string? Name { get; init; }

    public int HiBit { get; init; }

    public int Width { get; init; }

    public string? OriginalCondition { get; set; }

    [JsonConverter(typeof(JsonBitRangeConditionToStringConverter))]
    public BitRangeCondition Condition { get; set; }

    [JsonConverter(typeof(JsonBitFieldSetToStringConverter))]
    public BitFieldSet BitFieldSet { get; set; } = new();

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"{Name} ({HiBit}:{Width}) {BitFieldSet}");

        if (OriginalCondition != null)
        {
            builder.Append($" [{OriginalCondition}]");
        }

        return builder.ToString();
    }

    public BitRangeInfo Clone()
    {
        var clone = new BitRangeInfo
        {
            Name = Name,
            HiBit = HiBit,
            Width = Width,
            OriginalCondition = OriginalCondition,
            Condition = Condition
        };
        clone.BitFieldSet.AddRange(BitFieldSet);
        return clone;
    }
}