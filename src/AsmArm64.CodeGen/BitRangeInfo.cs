// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;

namespace AsmArm64.CodeGen;

class BitRangeInfo
{
    public string? Name { get; init; }

    public int HiBit { get; init; }

    public int Width { get; init; }

    public string? OriginalCondition { get; set; }

    public BitRangeCondition Condition { get; set; }

    public List<BitKind> FieldSets { get; } = new();

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"{Name} ({HiBit}:{Width}) ");

        foreach (var fieldSet in FieldSets)
        {
            builder.Append(fieldSet switch
            {
                BitKind.Zero => "0",
                BitKind.One => "1",
                BitKind.NotSet => "x",
                _ => throw new ArgumentOutOfRangeException()
            });
        }

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
        clone.FieldSets.AddRange(FieldSets);
        return clone;
    }
}

enum BitRangeCondition
{
    None,
    Unknown,
    AllNonZero,
    AllNonOne,
    AllNon111x,
    AllNon11xxx
}