// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using AsmArm64.CodeGen.Model;

namespace AsmArm64.CodeGen;

// Check https://github.com/CensoredUsername/dynasm-rs/blob/master/tools/aarch64_gen_opmap.py for ideas
// https://github.com/wdamron/arm/blob/main/INSTRUCTIONS.md
// https://github.com/wdamron/arm/blob/main/encoding.go
// https://developer.arm.com/Architectures/A-Profile%20Architecture
partial class Arm64Processor
{
    private readonly HashSet<string> _allParameterNames = new();
    private static readonly Regex MatchMnemonic = new(@"^(\w+\.?)(\{)?");
    private static readonly Regex MatchSpace = new(@"\s+");
    private static readonly Regex MatchIdentifier = new(@"\w+");
    private static readonly Regex MatchEnum = new(@"^[a-zA-Z][a-zA-Z0-9_\|]*(\s+#\d+)?$");

    private void DetectMultiInstruction(XElement encodingElt, EncodingSymbolsInfo? rawEncodingInfo, out string? multiInstructionSymbol, out string[]? multiInstructionPostFixes)
    {
        // TODO: This code is slightly duplicated with ParseOperands
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

        multiInstructionSymbol = null;
        multiInstructionPostFixes = null;

        if (hasMultipleMnemonics)
        {
            items.RemoveAt(0);
            var link = (RawAsmTemplateItemLink)items[0];
            multiInstructionSymbol = link.Link;
            multiInstructionPostFixes = new string[2];
            multiInstructionPostFixes[0] = "";
            multiInstructionPostFixes[1] = link.Text;
        }
        else if (mnemonic == "BFMLAL")
        {
            Debug.Assert(items[1].Text == "<bt>");
            var link = (RawAsmTemplateItemLink)items[1];
            multiInstructionSymbol = link.Link;
            multiInstructionPostFixes = new string[2];
            multiInstructionPostFixes[0] = "B";
            multiInstructionPostFixes[1] = "T";
        }
    }
    
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

        if (hasMultipleMnemonics)
        {
            items.RemoveAt(0);
            items.RemoveAt(0);
            Debug.Assert(items[0].Text.StartsWith("}"));
            items[0] = new(RawAsmTemplateItemKind.Text, MatchSpace.Replace(items[0].Text.Substring(1).Trim(), string.Empty));
        }
        else if (mnemonic == "BFMLAL")
        {
            Debug.Assert(items[1].Text == "<bt>");
            items.RemoveAt(0); // Remove mnemonic
            items.RemoveAt(0); // Remove <bt>
        }

        var newText = MatchSpace.Replace(items[0].Text, string.Empty);
        if (string.IsNullOrEmpty(newText))
        {
            items.RemoveAt(0);
        }
        else
        {
            items[0] = new(RawAsmTemplateItemKind.Text, newText);
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
                        bitNames.AddRange(elt.Symbol.BitNames);
                    }
                }

                bool isEnum = elt0.Symbol is not null && elt0.Symbol.Selector is not null && elt0.Symbol.Selector.BitValues.All(x => x.Kind == EncodingBitValueKind.Text || x.Kind == EncodingBitValueKind.Reserved);
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
                else if (bitNames.Count == 1 && bitNames[0].StartsWith("CR", StringComparison.Ordinal) && !isEnum)
                {
                    operandItem = new RegisterOperandItem();
                }
                else
                {
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
                        // We expect a register group to be the first operand, otherwise it is an optional register
                        var isRegisterGroup = state.PendingParameters.All(x => x.Kind == OperandItemKind.Register && x.TextElements[0].Text.StartsWith("V"));

                        GroupOperandItemBase group = isRegisterGroup
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
    
    private Dictionary<string, EncodingSymbolsInfo> ParseEncodingInfo(string filenameContext, XDocument doc)
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
            encodingSymbol.EncodedInText = accountElement.Attribute("encodedin")!.Value;

            var enclist = explanation.Attribute("enclist")!.Value.Split(",").Select(x => x.Trim()).ToList();

            var tableElement = accountElement.Element("table");
            if (tableElement is not null)
            {
                Debug.Assert(tableElement.Attribute("class")?.Value == "valuetable");

                var selector = new EncodingSymbolSelector();
                encodingSymbol.Selector = selector;
                
                // Collect the fields used to match
                var thead = tableElement.Descendants("thead").First();
                foreach (var entry in thead.Descendants("entry"))
                {
                    var cls = entry.Attribute("class")!.Value;
                    if (cls == "bitfield")
                    {
                        selector.BitNames.Add(entry.Value);
                    }
                }

                // Collect the match values
                var tbody = tableElement.Descendants("tbody").First();
                var rows = tbody.Elements("row").ToList();

                var bitFieldsBuilder = new StringBuilder();
                foreach (var row in rows)
                {
                    var bitValue = new EncodingBitValue();
                    bitFieldsBuilder.Clear();
                    foreach (var entry in row.Elements("entry"))
                    {
                        var cls = entry.Attribute("class")?.Value;
                        if (cls == "bitfield")
                        {
                            bitFieldsBuilder.Append(entry.Value);
                        }
                        else if (cls == "symbol")
                        {
                            bitValue.Text = entry.Value;
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
                    bitValue.BitSelectorAsText = bitFieldsBuilder.ToString();

                    selector.BitValues.Add(bitValue);
                }
            }



            if (accountElement.Name == "account")
            {
                var introElt = accountElement.Element("intro");
                if (introElt is not null)
                {
                    //// immediate.*encoded in the.*field as ... /\d+.
                    //var match = MatchEncodingDividedBy.Match(introElt.Value);
                    //if (match.Success)
                    //{
                    //    var divideBy = int.Parse(match.Groups["divide_by"].Value);
                    //    encodingSymbol.ValueEncoding = divideBy switch
                    //    {
                    //        2 => Arm64ImmediateValueEncodingKind.ValueDivideBy2,
                    //        4 => Arm64ImmediateValueEncodingKind.ValueDivideBy4,
                    //        8 => Arm64ImmediateValueEncodingKind.ValueDivideBy8,
                    //        16 => Arm64ImmediateValueEncodingKind.ValueDivideBy16,
                    //        _ => throw new ArgumentOutOfRangeException($"Unexpected immediate encoding {divideBy}")
                    //    };
                    //}
                    //else if (introElt.Value.EndsWith("in the range 1 to 64-<lsb>.") || introElt.Value.EndsWith("in the range 1 to 32-<lsb>."))
                    //{
                    //    encodingSymbol.ValueEncoding = Arm64ImmediateValueEncodingKind.ValuePlus1ShiftLeft6;
                    //}
                    //else if (introElt.Value.Contains("signed floating-point constant with 3-bit exponent and normalized 4 bits of precision"))
                    //{
                    //    encodingSymbol.ValueEncoding = Arm64ImmediateValueEncodingKind.SignedFloatExp3Mantissa4;
                    //}

                    //if (introElt.Value.Contains("encoded as"))
                    //{
                    //    Console.WriteLine($"{filenameContext} {string.Join(",", enclist)}");
                    //    Console.WriteLine($" -> {introElt.Value.Substring(introElt.Value.IndexOf("encoded as", StringComparison.Ordinal)).Trim()}");
                    //}
                    
                    if (introElt.Value.Contains(" signed immediate"))
                    {
                        encodingSymbol.IsSignedImmediate = true;
                    }
                    //Console.WriteLine($"{filenameContext} -> {introElt.Value}");
                }
            }

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

    private static readonly Regex MatchEncodingDividedBy = new(@"immediate.*encoded in the.*field as.*/(?<divide_by>\d+)\.");


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
