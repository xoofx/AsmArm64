// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using AsmArm64.CodeGen.Model;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model.JsonHelpers;

internal class JsonBitFieldSetToStringConverter : JsonConverter<BitFieldSet>
{
    public override BitFieldSet Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var bitFieldSet = new BitFieldSet();
        var value = reader.GetString();
        if (value != null)
        {
            foreach (var c in value)
            {
                bitFieldSet.Add(c switch
                {
                    '0' => BitKind.Zero,
                    '1' => BitKind.One,
                    'x' => BitKind.NotSet,
                    _ => throw new JsonException()
                });
            }
        }
        return bitFieldSet;

    }
    public override void Write(Utf8JsonWriter writer, BitFieldSet value, JsonSerializerOptions options)
    {
        var builder = new StringBuilder(); // TODO: Use a pool

        foreach (var bitKind in value)
        {
            builder.Append(bitKind switch
            {
                BitKind.Zero => '0',
                BitKind.One => '1',
                BitKind.NotSet => 'x',
                _ => throw new ArgumentOutOfRangeException()
            });
        }

        writer.WriteStringValue(builder.ToString());
    }
}