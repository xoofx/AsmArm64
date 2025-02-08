// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

enum EncodingSymbolExtractMapKind
{
    None,
    VectorArrangement,
    DynamicRegister,
    Indexer,
    Immediate,
    ProcessStateField,
    RegisterIndex,
    Extend,
}

class EncodingSymbolExtractMap
{
    private readonly Dictionary<string, EncodingSymbolExtract> _extracts = new();
    private readonly Dictionary<string, EncodingSymbolSelector> _selectors = new();

    public EncodingSymbolExtractMapKind Kind { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingSymbolExtract> ExtractList { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingSymbolSelector> SelectorList { get; } = new();

    public void AssignIndices()
    {
        var selectorList = _selectors.OrderBy(x => x.Key).Select(x => x.Value).ToList();
        for (int i = 0; i < selectorList.Count; i++)
        {
            var selector = selectorList[i];
            selector.Index = i + 1;
            foreach (var action in selector.OnIndexAssigned)
            {
                action(selector.Index);
            }
        }
        SelectorList.Clear();
        SelectorList.AddRange(selectorList);

        var extractList = _extracts.OrderBy(x => x.Key).Select(x => x.Value).ToList();
        for (int i = 0; i < extractList.Count; i++)
        {
            var extract = extractList[i];
            extract.Index = i + 1;
            foreach (var action in extract.OnIndexAssigned)
            {
                action(extract.Index);
            }
        }
        ExtractList.Clear();
        ExtractList.AddRange(extractList);
    }

    public TExtract GetOrCreateExtract<TExtract>(string extractId) where TExtract : EncodingSymbolExtract, new()
    {
        if (!_extracts.TryGetValue(extractId, out var existingExtract))
        {
            existingExtract = new TExtract();
            _extracts.Add(extractId, existingExtract);
            ExtractList.Add(existingExtract);
        }

        return (TExtract)existingExtract;
    }

    public TExtract GetOrCreateExtract<TExtract>(EncodingSymbol symbol) where TExtract: EncodingSymbolExtract, new()
    {
        EncodingSymbolSelector? existingSelector = null;
        var builder = new StringBuilder();
        string? selectorId = null;
        if (symbol.Selector is not null)
        {
            Debug.Assert(symbol.Selector is not null);

            symbol.Selector.AppendUniqueId(builder);
            selectorId = builder.ToString();
            builder.Clear();

            if (!_selectors.TryGetValue(selectorId, out existingSelector))
            {
                existingSelector = symbol.Selector;
                _selectors.Add(selectorId, existingSelector);
                SelectorList.Add(existingSelector);

                // Indices must fit within a byte
                Debug.Assert(SelectorList.Count < byte.MaxValue, $"Exceeding number of extracts to fit within a byte! for `{typeof(TExtract).FullName}`");
            }
        }

        var encodingSymbolExtract = new TExtract()
        {
            BitSize = symbol.BitSize,
            Selector = existingSelector,
        };
        encodingSymbolExtract.BitRanges.AddRange(symbol.BitRanges);

        builder.Clear();
        encodingSymbolExtract.AppendUniqueId(builder);

        var extractId = $"{builder}{selectorId ?? string.Empty}";

        if (!_extracts.TryGetValue(extractId, out var existingExtract))
        {
            existingExtract = encodingSymbolExtract;
            _extracts.Add(extractId, existingExtract);
            ExtractList.Add(existingExtract);

            // Indices must fit within a byte
            Debug.Assert(ExtractList.Count < byte.MaxValue, $"Exceeding number of extracts to fit within a byte! for `{typeof(TExtract).FullName}`");

            if (existingSelector is not null)
            {
                existingSelector.OnIndexAssigned.Add(index => encodingSymbolExtract.SelectorIndex = index);
            }
        }

        return (TExtract)existingExtract;
    }
}