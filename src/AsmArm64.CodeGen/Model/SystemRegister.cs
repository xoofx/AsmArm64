// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

record SystemRegister
{
    public required string Name { get; init; }

    public required string Description { get; init; }

    public required ushort Value { get; init; }
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> UsageKinds { get; } = new();

    public string GetBits()
    {
        var builder = new StringBuilder();
        // 0bxx_xxx_xxxx_xxxx_xxx
        builder.Append("0b");
        for (int i = 15; i >= 0; i--)
        {
            if (i == 13 || i == 10 || i == 6 || i == 2)
            {
                builder.Append('_');
            }
            builder.Append((Value & 1 << i) != 0 ? '1' : '0');
        }

        return builder.ToString();
    }

    protected virtual bool PrintMembers(StringBuilder builder)
    {
        builder.Append("Name = ").Append(Name);
        builder.Append(", Description = ").Append(Description);
        builder.Append($", Value = 0x{Value:X4}");
        builder.Append(", Bits = ").Append(GetBits());
        builder.Append(", UsageKinds = ").Append(string.Join(", ", UsageKinds));
        return true;
    }
}