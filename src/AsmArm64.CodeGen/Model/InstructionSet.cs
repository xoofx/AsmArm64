// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.Unicode;

namespace AsmArm64.CodeGen.Model;

class InstructionSet
{

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<SysDynamicDispatchEntry> SysDynamicDispatchEntries { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<SystemRegister> SystemRegisters { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingSymbolExtractMap> ExtractMaps { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<Instruction> Instructions { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    internal List<string> OrderedMnemonics { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    internal List<string> OrderedInstructionClass { get; } = new();
    
    
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers = { DefaultValueModifier } // Workaround to not serialize empty list
        },
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // To allow <, >...etc in strings
        PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        IncludeFields = true,
        WriteIndented = true,
    };

    public EncodingSymbolExtractMap GetOrCreateExtractMap(EncodingSymbolExtractMapKind kind)
    {
        var extractMap = ExtractMaps.FirstOrDefault(x => x.Kind == kind);
        if (extractMap == null)
        {
            extractMap = new EncodingSymbolExtractMap { Kind = kind };
            ExtractMaps.Add(extractMap);
        }

        return extractMap;
    }

    public void AssignExtraMapIndices()
    {
        foreach (var extractMap in ExtractMaps)
        {
            extractMap.AssignIndices();
        }
    }
    
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

    // Workaround to not serialize empty list
    // https://stackoverflow.com/questions/59720612/c-sharp-net-core-3-1-system-text-json-ignore-empty-collection-in-serialization
    private static void DefaultValueModifier(JsonTypeInfo typeInfo)
    {
        foreach (var property in typeInfo.Properties)
        {
            if (typeof(ICollection).IsAssignableFrom(property.PropertyType))
            {
                property.ShouldSerialize = (_, val) => val is ICollection collection && collection.Count > 0;
            }
        }
    }
}