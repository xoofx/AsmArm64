// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

class InstructionSet
{
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<Instruction> Instructions { get; } = new();

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        IncludeFields = true,
        WriteIndented = true,
    };

    public static InstructionSet ReadJson(string filename)
    {
        using var stream = File.OpenRead(filename);
        return JsonSerializer.Deserialize<InstructionSet>(stream, JsonOptions)!;
    }

    public void WriteJson(string filename)
    {
        using var stream = File.Create(filename);
        WriteJson(stream);
    }

    public void WriteJson(Stream stream)
    {
        JsonSerializer.Serialize(stream, this, JsonOptions);
    }
}