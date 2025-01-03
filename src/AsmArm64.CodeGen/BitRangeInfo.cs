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

    public List<BitKind> FieldSets { get; } = new();

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"{Name,-8} {HiBit,-2} {Width,-2} ");

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
        return builder.ToString();
    }

    public BitRangeInfo Clone()
    {
        var clone = new BitRangeInfo
        {
            Name = Name,
            HiBit = HiBit,
            Width = Width
        };
        clone.FieldSets.AddRange(FieldSets);
        return clone;
    }
}