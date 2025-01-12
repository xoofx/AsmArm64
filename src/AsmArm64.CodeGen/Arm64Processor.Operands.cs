// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

// Check https://github.com/CensoredUsername/dynasm-rs/blob/master/tools/aarch64_gen_opmap.py for ideas
// https://github.com/wdamron/arm/blob/main/INSTRUCTIONS.md
// https://github.com/wdamron/arm/blob/main/encoding.go

partial class Arm64Processor
{
    private HashSet<string> _allParameterNames = new();

    private static readonly Regex MatchMnemonic = new(@"^(\w+\.?)(\{)?");
    private static readonly Regex MatchSpace = new(@"\s+");
    private static readonly Regex MatchIdentifier = new(@"\w+");
    private static readonly Regex MatchEnum = new(@"^[a-zA-Z][a-zA-Z0-9_\|]*(\s+#\d+)?$");

    private List<Operand> ParseOperands(XElement encodingElt, EncodingSymbolsInfo? rawEncodingInfo)
    {
        var asmTemplate = encodingElt.Element("asmtemplate")!;

        var items = new List<RawAsmTemplateItem>();

        foreach (var elt in asmTemplate.Elements())
        {
            if (elt.Name == "text")
            {
                var text = elt.Value.Trim();
                items.Add(new RawAsmTemplateItem(RawAsmTemplateItemKind.Text, text));
            }
            else if (elt.Name == "a")
            {
                var link = elt.Attribute("link")!.Value.Trim();
                var text = elt.Value.Trim();
                items.Add(new RawAsmTemplateItemLink(RawAsmTemplateItemKind.Link, text, link, rawEncodingInfo!.Symbols[link]));
            }
            else
            {
                throw new InvalidOperationException($"Unsupported element <{elt.Name}> in asmtemplate - {elt}");
            }
        }

        var instructionId = rawEncodingInfo?.Name;
        var mnemonic = items[0].Text;
        var match = MatchMnemonic.Match(mnemonic);
        Debug.Assert(match.Success);
        bool hasMultipleMnemonics = match.Groups[2].Success;
        // Discard the mnemonic (and the potential '{')
        items[0] = new RawAsmTemplateItem(RawAsmTemplateItemKind.Text, mnemonic.Substring(match.Index + match.Length));

        string? multiOption = null;
        int multiOptionCount = 0;

        if (hasMultipleMnemonics)
        {
            items.RemoveAt(0);
            var link = (RawAsmTemplateItemLink)items[0];
            multiOption = link.Link;
            multiOptionCount = int.Parse(link.Text);
            items.RemoveAt(0);
            Debug.Assert(items[0].Text.StartsWith("}"));
            items[0] = new(RawAsmTemplateItemKind.Text, MatchSpace.Replace(items[0].Text.Substring(1).Trim(), string.Empty));
            if (items[0].Text.Length == 0)
            {
                items.RemoveAt(0);
            }
        }
        else
        {
            var newText = MatchSpace.Replace(items[0].Text, string.Empty);
            if (string.IsNullOrEmpty(newText))
            {
                items.RemoveAt(0);
            }
            else
            {
                items[0] = new(RawAsmTemplateItemKind.Text, newText);
            }
        }

        // Remove any spaces from the text to ease the parsing after
        items.ForEach(x => x.Text = MatchSpace.Replace(x.Text, ""));

        var states = new Stack<ParsingState>();
        states.Push(new ParsingState() { CurrentStateKind = ParsingStateKind.Global });
        var operands = new List<Operand>();

        bool hasOptionalParameterAfterNextCommaOrImmediate = false;

        for (int i = 0; i < items.Count; i++)
        {
            var item = items[i];
            var text = item.Text;

            int index = 0;

            while (index < text.Length)
            {
                var c = text[index];

                if (c == ',')
                {
                    AddPendingParameter();

                    if (hasOptionalParameterAfterNextCommaOrImmediate)
                    {
                        states.Push(new ParsingState() { CurrentStateKind = ParsingStateKind.Optional });
                        hasOptionalParameterAfterNextCommaOrImmediate = false;
                    }

                    index++;
                }
                else if (c == '<')
                {
                    var link = (RawAsmTemplateItemLink)item;

                    // TODO: detect ENUM and others
                    //bool isRegister = link.EncodedIn.BitInfos.Any(x => x.BitName.StartsWith("R", StringComparison.Ordinal));
                    index++;
                    var enfOfParamName = text.IndexOf('>', index);
                    var paramName = text.Substring(index, enfOfParamName - index);
                    index = enfOfParamName + 1;
                    states.Peek().TextElements.Add(new(paramName, link.EncodedIn));
                }
                else if (c == '.')
                {
                    states.Peek().TextElements.Add(new(".", null));
                    index++;
                }
                else if (c == '{')
                {
                    if (index + 1 < text.Length && (text[index + 1] == ',' || text[index + 1] == '#'))
                    {
                        // Will be added after the `,` or when we have an immediate `#` but not before
                        hasOptionalParameterAfterNextCommaOrImmediate = true;
                    }
                    else
                    {
                        AddPendingParameter();
                        states.Push(new ParsingState() { CurrentStateKind = ParsingStateKind.Braces });
                    }

                    // Optional argument
                    index++;
                }
                else if (c == '(')
                {
                    states.Push(new ParsingState() { CurrentStateKind = ParsingStateKind.Parenthesis });
                    index++;
                }
                else if (c == '|')
                {
                    AddPendingParameter();
                    index++;
                }
                else if (c == ')')
                {
                    AddPendingParameter(true);
                    index++;
                }
                else if (c == '}')
                {
                    AddPendingParameter(true);

                    // Optional argument
                    index++;
                }
                else if (c == '#')
                {
                    if (states.Peek().TextElements.Any(x => x.Symbol is not null))
                    {
                        AddPendingParameter();
                    }
                    
                    if (hasOptionalParameterAfterNextCommaOrImmediate)
                    {
                        states.Push(new ParsingState() { CurrentStateKind = ParsingStateKind.Optional });
                        hasOptionalParameterAfterNextCommaOrImmediate = false;
                    }

                    bool hasTextBefore = states.Peek().TextElements.Count > 0;
                    states.Peek().TextElements.Add(new(hasTextBefore ? " #" : "#", null));
                    index++;
                }
                else if (c == '[')
                {
                    bool previousIsGroup = index - 1 >= 0 && text[index - 1] == '}';
                    bool hasPendingParameters = states.Peek().TextElements.Count > 0 || states.Peek().PendingParameters.Count > 0;
                    if (hasPendingParameters)
                    {
                        AddPendingParameter();
                    }
                    states.Push(new ParsingState() { CurrentStateKind = previousIsGroup || hasPendingParameters ? ParsingStateKind.BracketForIndexer : ParsingStateKind.BracketForMemory });
                    index++;
                }
                else if (c == ']')
                {
                    AddPendingParameter(true);
                    index++;
                }
                else if (c == '!')
                {
                    AddPendingParameter();
                    Debug.Assert(states.Count == 1);
                    Debug.Assert(states.Peek().PendingParameters.Count == 0);
                    Debug.Assert(states.Peek().TextElements.Count == 0);

                    var lastOperand = operands[^1];
                    lastOperand.HasBang = true;
                    
                    index++;
                }
                else if (c == '-')
                {
                    //Debug.Assert(false);
                    // Used by negative #immediate and in SVE for register ranges
                    // TODO: Used by SVE, don't know how to handle these yet
                    states.Peek().TextElements.Add(new("-", null));
                    index++;
                }
                else if (c == '/')
                {
                    //Debug.Assert(false);
                    // Modifier used by SVE (e.g. P0/M)
                    // TODO: Used by SVE, don't know how to handle these yet
                    states.Peek().TextElements.Add(new("/", null));
                    index++;
                }
                else if (c == '_')
                {
                    // TODO: Used by SVE, don't know how to handle these yet
                    states.Peek().TextElements.Add(new("_", null));
                    index++;
                }
                else if (c == ':')
                {
                    // TODO: Used by SVE, don't know how to handle these yet
                    states.Peek().TextElements.Add(new("_", null));
                    index++;
                }
                else if (char.IsLetterOrDigit(c))
                {
                    var matchId = MatchIdentifier.Match(text, index);
                    if (matchId.Success)
                    {
                        states.Peek().TextElements.Add(new(matchId.Value, null));
                        index += matchId.Length;
                    }
                    else
                    {
                        states.Peek().TextElements.Add(new(c.ToString(), null));
                        index++;
                    }
                }
                else
                {
                    Debug.Assert(false, $"Unhandled character `{c}` found");
                    index++;
                }
            }
        }

        // Pop all states until we reach the top level state
        while (states.Count > 1)
        {
            AddPendingParameter(true);
        }

        // Adds the last operand or modifier
        AddPendingParameter();

        return operands;

        void AddPendingParameter(bool popState = false)
        {
            var state = popState ? states.Pop() : states.Peek();

            var textElements = state.TextElements;
            if (textElements.Count > 0)
            {
                OperandItem operandItem;

                var elt0 = textElements[0];

                // Collect bitNames for all text elements
                // e.g. The name R might not appear in the first element but in the second one
                var bitNames = new List<string>();
                foreach (var elt in textElements)
                {
                    if (elt.Symbol is not null)
                    {
                        bitNames.AddRange(elt.Symbol.BitInfos.Select(x => x.Name));
                    }
                }

                if (elt0.Text == "#")
                {
                    operandItem = new ImmediateOperandItem();
                    textElements.RemoveAt(0);
                }
                else if (textElements.Any(x => x.Text == " #"))
                {
                    operandItem = new ConstAndImmediateOperandItem();
                }
                else if (bitNames.Any(x => x.StartsWith("R", StringComparison.Ordinal)))
                {
                    operandItem = new RegisterOperandItem();
                }
                else if (bitNames.Count == 1 && bitNames[0].StartsWith("CR", StringComparison.Ordinal))
                {
                    operandItem = new RegisterOperandItem();
                }
                else
                {
                    bool isEnum = elt0.Symbol is not null && elt0.Symbol.BitValues.Count > 0 && elt0.Symbol.BitValues.All(x => MatchEnum.IsMatch(x.Value));
                    // TODO: Detect Enum kind (e.g. LSL #<amount>)
                    operandItem = isEnum
                        ? new EnumOperandItem()
                        : elt0.Symbol is null
                            ? new ConstOperandItem()
                            : new ValueOperandItem();
                }
                
                operandItem.TextElements.AddRange(textElements);
                textElements.Clear();

                state.PendingParameters.Add(operandItem);
            }

            // A group seen at the end of a list of operand items is optional
            if (state.PendingParameters.Count > 1 && state.PendingParameters[^1] is GroupOperandItemBase pendingGroup)
            {
                pendingGroup.IsOptional = true;
            }

            switch (state.CurrentStateKind)
            {
                case ParsingStateKind.BracketForIndexer:
                {
                    var register = operands[^1].Items[^1];
                    Debug.Assert(register.Indexer is null);
                    Debug.Assert(state.PendingParameters.Count == 1);
                    register.Indexer = state.PendingParameters[^1];
                    state.PendingParameters.Clear();
                    break;
                }
                case ParsingStateKind.BracketForMemory:
                    if (popState)
                    {
                        var operand = new Operand() { Kind = OperandKind.Memory };
                        operand.Items.AddRange(state.PendingParameters);
                        state.PendingParameters.Clear();
                        operands.Add(operand);
                        // We can early exit here as we are at the top level
                        return;
                    }
                    break;
                case ParsingStateKind.Braces:
                case ParsingStateKind.Optional:
                    if (popState)
                    {
                        // Don't create a group without parameters (can happen for {,#0} where #0 is discarded by the parser above)
                        var allRegisters = state.PendingParameters.All(x => x.Kind == OperandItemKind.Register);

                        GroupOperandItemBase group = allRegisters
                            ? new RegisterGroupOperandItem() { IsOptional = state.CurrentStateKind == ParsingStateKind.Optional }
                            : new OptionalGroupOperandItem() { IsOptional = state.CurrentStateKind == ParsingStateKind.Optional };
                        
                        group.Items.AddRange(state.PendingParameters);
                        state.PendingParameters.Clear();
                        state.PendingParameters.Add(group);
                    }
                    break;
                case ParsingStateKind.Parenthesis:
                    if (popState)
                    {
                        var parameter = new SelectOperandItem();
                        parameter.Items.AddRange(state.PendingParameters);
                        state.PendingParameters.Clear();
                        state.PendingParameters.Add(parameter);
                    }
                    break;
            }

            if (popState)
            {
                var parentPendingParameters = states.Peek().PendingParameters;
                parentPendingParameters.AddRange(state.PendingParameters);
                state.PendingParameters.Clear();
            }
            

            if (states.Count == 1 && states.Peek().PendingParameters.Count > 0)
            {
                var rootPendingParameters = states.Peek().PendingParameters;
                var kind = rootPendingParameters[0].Kind;

                OperandKind operandKind = kind switch
                {
                    OperandItemKind.ConstAndImmediate => OperandKind.ConstAndImmediate,
                    OperandItemKind.Immediate => OperandKind.Immediate,
                    OperandItemKind.Register => OperandKind.Register,
                    OperandItemKind.Const => OperandKind.Const,
                    OperandItemKind.Value => OperandKind.Value,
                    OperandItemKind.Enum => OperandKind.Enum,
                    OperandItemKind.OptionalGroup => OperandKind.OptionalGroup,
                    OperandItemKind.RegisterGroup => OperandKind.RegisterGroup,
                    OperandItemKind.Select => OperandKind.Select,
                    _ => throw new ArgumentOutOfRangeException()
                };

                // Add the operand
                var operand = new Operand() { Kind = operandKind };
                operand.Items.AddRange(rootPendingParameters);
                operands.Add(operand);

                rootPendingParameters.Clear();
            }
        }
    }
    
    private Dictionary<string, EncodingSymbolsInfo> ParseEncodingInfo(XDocument doc)
    {
        var explanations = doc.Descendants("explanation").ToList();

        var mapEncodingIdToInfo = new Dictionary<string, EncodingSymbolsInfo>();

        foreach (var explanation in explanations)
        {
            var symbolElement = (XElement)explanation.Elements("symbol").First();
            var accountElement = explanation.Elements("account").FirstOrDefault() ?? explanation.Elements("definition").First();

            var link = symbolElement.Attribute("link")!.Value;
            var name = symbolElement.Value.Trim();
            var encodingSymbol = new EncodingSymbol
            {
                Link = link,
                Name = name,
            };
            _allParameterNames.Add(name);
            // 
            var encodedIn = accountElement.Attribute("encodedin")!.Value;

            int index = 0;
            while (index < encodedIn.Length)
            {
                var match = MatchIdentifier.Match(encodedIn, index, encodedIn.Length - index);
                if (!match.Success)
                {
                    break;
                }
                var bitName = match.Value;
                index += match.Length;
                var bitInfo = new EncodingBitInfo() { Name = bitName };
                if (index < encodedIn.Length)
                {
                    var c = encodedIn[index];
                    if (c == ':')
                    {
                        index++;
                    }
                    else if (c == '<')
                    {
                        var indexOfEndGroup = encodedIn.IndexOf('>', index);
                        var bits = encodedIn.Substring(index + 1, indexOfEndGroup - index - 1);
                        bitInfo.BitIndices.AddRange(bits.Split(':').Select(int.Parse));
                        index = indexOfEndGroup + 1;
                        if (index < encodedIn.Length && encodedIn[index] == ':')
                        {
                            index++;
                        }
                    }
                    else
                    {
                        Debug.Assert(false); // ???
                    }
                }

                encodingSymbol.BitInfos.Add(bitInfo);
            }

            var tableElement = accountElement.Element("table");
            if (tableElement is not null)
            {
                Debug.Assert(tableElement.Attribute("class")?.Value == "valuetable");

                // Collect the fields used to match
                var thead = tableElement.Descendants("thead").First();
                foreach (var entry in thead.Descendants("entry"))
                {
                    var cls = entry.Attribute("class")!.Value;
                    if (cls == "bitfield")
                    {
                        encodingSymbol.BitValueNames.Add(entry.Value);
                    }
                }

                // Collect the match values
                var tbody = tableElement.Descendants("tbody").First();
                var rows = tbody.Elements("row").ToList();

                foreach (var row in rows)
                {
                    var bitValue = new EncodingBitValue();
                    foreach (var entry in row.Elements("entry"))
                    {
                        var cls = entry.Attribute("class")?.Value;
                        if (cls == "bitfield")
                        {
                            bitValue.BitFields.Add(entry.Value);
                        }
                        else if (cls == "symbol")
                        {
                            bitValue.Value = entry.Value;
                        }
                        else if (cls == "feature" || cls == "description")
                        {
                            // Ignore for now
                        }
                        else
                        {
                            Debug.Assert(false);
                        }
                    }
                    encodingSymbol.BitValues.Add(bitValue);
                }
            }

            var enclist = explanation.Attribute("enclist")!.Value.Split(",").Select(x => x.Trim()).ToList();
            foreach (var enc in enclist)
            {
                if (!mapEncodingIdToInfo.TryGetValue(enc, out var encodingInfo))
                {
                    encodingInfo = new EncodingSymbolsInfo()
                    {
                        Name = enc
                    };
                    mapEncodingIdToInfo[enc] = encodingInfo;
                }
                encodingInfo.Symbols.Add(link, encodingSymbol);
            }
        }

        return mapEncodingIdToInfo;
    }


    private class ParsingState
    {
        public required ParsingStateKind CurrentStateKind { get; init; }

        public List<OperandText> TextElements { get; } = new();

        public List<OperandItem> PendingParameters { get; } = new();

        public override string ToString() => $"{CurrentStateKind} Parameters: ({string.Join(",", PendingParameters)})";
    }

    private enum ParsingStateKind
    {
        /// <summary>
        /// Top level state.
        /// </summary>
        Global,
        /// <summary>
        /// [...]
        /// </summary>
        BracketForMemory,
        /// <summary>
        /// [...]
        /// </summary>
        BracketForIndexer,
        /// <summary>
        /// {...} or {...,...} - Used by SVE
        /// </summary>
        Braces,
        /// <summary>
        /// {,...} or {#...} TODO: Check other cases
        /// </summary>
        Optional,
        /// <summary>
        /// (...|...)
        /// </summary>
        Parenthesis,
    }

    private record RawAsmTemplateItem
    {
        public RawAsmTemplateItem(RawAsmTemplateItemKind kind, string text)
        {
            Kind = kind;
            Text = text;
        }

        public RawAsmTemplateItemKind Kind { get; }

        public string Text { get; set; }

        public override string ToString() => $"Text = `{Text}`";
    }

    private record RawAsmTemplateItemLink(RawAsmTemplateItemKind Kind, string text, string Link, EncodingSymbol EncodedIn) : RawAsmTemplateItem(Kind, text)
    {
        public override string ToString() => $"Text = `{Text}`, Link = {Link}, EncodedIn = {EncodedIn}";
    }

    private enum RawAsmTemplateItemKind
    {
        Text,
        Link,
    }
}
