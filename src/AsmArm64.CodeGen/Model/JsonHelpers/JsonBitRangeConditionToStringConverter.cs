// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using AsmArm64.CodeGen.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model.JsonHelpers;

internal class JsonBitRangeConditionToStringConverter : JsonConverter<BitRangeCondition>
{
    public override BitRangeCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            null => BitRangeCondition.None,
            "?" => BitRangeCondition.Unknown,
            "0+" => BitRangeCondition.AllNonZero,
            "1+" => BitRangeCondition.AllNonOne,
            "=!111x" => BitRangeCondition.AllNon111x,
            "=!11xxx" => BitRangeCondition.AllNon11xxx,
            _ => throw new JsonException()
        };
    }
    public override void Write(Utf8JsonWriter writer, BitRangeCondition value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            BitRangeCondition.None => null,
            BitRangeCondition.Unknown => "?",
            BitRangeCondition.AllNonZero => "0+",
            BitRangeCondition.AllNonOne => "1+",
            BitRangeCondition.AllNon111x => "=!111x",
            BitRangeCondition.AllNon11xxx => "=!11xxx",
            _ => throw new ArgumentOutOfRangeException()
        });
    }
}