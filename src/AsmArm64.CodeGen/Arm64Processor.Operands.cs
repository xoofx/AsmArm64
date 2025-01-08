// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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

    private List<RawOperand> ParseOperands(XElement encodingElt, RawEncodingInfo? rawEncodingInfo)
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
        var operands = new List<RawOperand>();

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
                    if (index + 1 < text.Length && text[index + 1] == '0' && states.Peek().CurrentStateKind == ParsingStateKind.Optional)
                    {
                        // We can discard this operand/parameter entirely as it is only used for informational purpose to indicate no base offsets
                        index += 2;
                    }
                    else
                    {
                        if (hasOptionalParameterAfterNextCommaOrImmediate)
                        {
                            states.Push(new ParsingState() { CurrentStateKind = ParsingStateKind.Optional });
                            hasOptionalParameterAfterNextCommaOrImmediate = false;
                        }

                        states.Peek().TextElements.Add(new("#", null));
                        index++;
                    }
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
                    // TODO: Need to use this information
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

        // Adds the last operand or modifier
        while (states.Count > 1)
        {
            AddPendingParameter(true);
        }

        return operands;

        void AddPendingParameter(bool popState = false)
        {
            var state = popState ? states.Pop() : states.Peek();

            var textElements = state.TextElements;
            if (textElements.Count > 0)
            {
                RawParameter parameter;

                var elt0 = textElements[0];
                if (elt0.Text == "#")
                {
                    parameter = new RawImmediateParameter();
                    textElements.RemoveAt(0);
                }
                else if (elt0.Symbol is not null && elt0.Symbol.BitInfos.Any(x => x.BitName.StartsWith("R", StringComparison.Ordinal)))
                {
                    // Some registers can have elt0.Symbol.BitValues.Count != 0 TODO: Check how to handle these
                    parameter = new RawRegister();
                }
                else
                {
                    bool isEnum = elt0.Symbol is not null && elt0.Symbol.BitValues.Count > 0 && elt0.Symbol.BitValues.All(x => MatchEnum.IsMatch(x.Value));
                    // TODO: Detect Enum kind (e.g. LSL #<amount>)
                    parameter = isEnum ? new RawEnumParameter() : new RawValueParameter();
                }
                
                parameter.TextElements.AddRange(textElements);
                textElements.Clear();

                state.PendingParameters.Add(parameter);
            }

            switch (state.CurrentStateKind)
            {
                case ParsingStateKind.BracketForIndexer:
                {
                    var register = operands[^1].Parameters[^1];
                    register.Indices.AddRange(state.PendingParameters);
                    state.PendingParameters.Clear();
                    break;
                }
                case ParsingStateKind.BracketForMemory:
                    if (popState)
                    {
                        var operand = new RawOperand(RawOperandKind.Memory);
                        operand.Parameters.AddRange(state.PendingParameters);
                        state.PendingParameters.Clear();
                        operands.Add(operand);
                        // We can early exit here as we are at the top level
                        return;
                    }
                    break;
                case ParsingStateKind.Braces:
                    if (popState)
                    {
                        var group = new RawGroupParameter();
                        group.Items.AddRange(state.PendingParameters);
                        state.PendingParameters.Clear();
                        state.PendingParameters.Add(group);
                    }
                    break;
                case ParsingStateKind.Optional:
                    foreach (var pendingParameter in state.PendingParameters)
                    {
                        pendingParameter.IsOptional = true;
                    }
                    break;
                case ParsingStateKind.Parenthesis:
                    if (popState)
                    {
                        var parameter = new RawChoiceParameter();
                        parameter.Items.AddRange(state.PendingParameters);
                        state.PendingParameters.Clear();
                        state.PendingParameters.Add(parameter);
                    }
                    break;
            }

            if (popState)
            {
                // Propagate parameters to the parent state
                states.Peek().PendingParameters.AddRange(state.PendingParameters);
                state.PendingParameters.Clear();
            }

            if (states.Count == 1 && states.Peek().PendingParameters.Count > 0)
            {
                var pendingParameters = states.Peek().PendingParameters;
                var kind = pendingParameters[0].Kind;

                RawOperandKind operandKind = kind switch
                {
                    RawParameterKind.Immediate => RawOperandKind.Immediate,
                    RawParameterKind.Register => RawOperandKind.Register,
                    RawParameterKind.Value => RawOperandKind.Value,
                    RawParameterKind.Enum => RawOperandKind.Enum,
                    RawParameterKind.Group => RawOperandKind.Group,
                    RawParameterKind.Choice => RawOperandKind.Choice,
                    _ => throw new ArgumentOutOfRangeException()
                };

                // Add the operand
                var operand = new RawOperand(operandKind);
                operand.Parameters.AddRange(pendingParameters);
                operands.Add(operand);

                pendingParameters.Clear();
            }
        }
    }

    private class ParsingState
    {
        public required ParsingStateKind CurrentStateKind { get; init; }

        public List<RawText> TextElements { get; } = new();

        public List<RawParameter> PendingParameters { get; } = new();
        

        public override string ToString() => $"{CurrentStateKind} Parameters: ({string.Join(",", PendingParameters)})";
    }


    private sealed class RawText
    {
        public RawText(string text, RawEncodingSymbol? symbol)
        {
            Text = text;
            Symbol = symbol;
        }
        
        public string Text { get; }

        public RawEncodingSymbol? Symbol { get; }

        public override string ToString() => Symbol is not null ? $"{Text} ({Symbol})" : Text;
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

    private abstract class RawOperandNode
    {
        /// <summary>
        /// Is this object optional.
        /// </summary>
        public bool IsOptional { get; set; }
    }


    private sealed class RawOperand(RawOperandKind kind) : RawOperandNode
    {
        public RawOperandKind Kind { get; } = kind;

        public List<RawParameter> Parameters { get; } = new();

        public override string ToString()
        {
            var builder = new StringBuilder();

            switch (Kind)
            {
                case RawOperandKind.Immediate:
                    builder.Append('#');
                    break;
                case RawOperandKind.Memory:
                    builder.Append('[');
                    break;
            }

            builder.Append(string.Join(Kind == RawOperandKind.Choice ? "|" : ",", Parameters));

            switch (Kind)
            {
                case RawOperandKind.Memory:
                    builder.Append(']');
                    break;
            }

            return builder.ToString();
        }
    }

    private abstract class RawParameter(RawParameterKind kind) : RawOperandNode
    {
        public RawParameterKind Kind { get; } = kind;

        public List<RawText> TextElements { get; } = new();

        public List<RawParameter> Indices { get; } = new();

        public sealed override string ToString()
        {
            var builder = new StringBuilder();
            ToStringTextElements(builder);
            ToStringParameters(builder);
            if (Indices.Count > 0)
            {
                builder.Append('[');
                builder.Append(string.Join(",", Indices));
                builder.Append(']');
            }

            return builder.ToString();
        }

        protected virtual void ToStringParameters(StringBuilder builder)
        {
        }

        protected void ToStringTextElements(StringBuilder builder)
        {
            foreach (var textElement in TextElements)
            {
                builder.Append(textElement.Text);
            }
        }
    }

    private sealed class RawEnumParameter() : RawParameter(RawParameterKind.Enum);

    private sealed class RawValueParameter() : RawParameter(RawParameterKind.Value);

    private sealed class RawImmediateParameter() : RawParameter(RawParameterKind.Immediate);

    private sealed class RawGroupParameter() : RawParameter(RawParameterKind.Group)
    {
        public List<RawParameter> Items { get; } = new();

        protected override void ToStringParameters(StringBuilder builder)
        {
            builder.Append('{');
            builder.Append(string.Join(",", Items));
            builder.Append('}');
        }
    }

    private sealed class RawRegister() : RawParameter(RawParameterKind.Register);

    /// <summary>
    /// Arguments Starting with ( and with | and ) are grouped arguments.
    /// </summary>
    private sealed class RawChoiceParameter() : RawParameter(RawParameterKind.Choice)
    {
        public List<RawParameter> Items { get; } = new();

        protected override void ToStringParameters(StringBuilder builder)
        {
            builder.Append('(');
            builder.Append(string.Join(" | ", Items));
            builder.Append(')');
        }
    }

    private enum RawParameterKind
    {
        Register,
        Immediate,
        Value,
        Enum,
        Group,
        Choice,
    }


    private enum RawOperandKind
    {
        Undefined,
        Register,
        Immediate,
        Value,
        Enum,
        Memory,
        Group,
        Choice,
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

    private record RawAsmTemplateItemLink(RawAsmTemplateItemKind Kind, string text, string Link, RawEncodingSymbol EncodedIn) : RawAsmTemplateItem(Kind, text)
    {
        public override string ToString() => $"Text = `{Text}`, Link = {Link}, EncodedIn = {EncodedIn}";
    }

    private enum RawAsmTemplateItemKind
    {
        Text,
        Link,
    }

    private Dictionary<string, RawEncodingInfo> ParseEncodingInfo(XDocument doc)
    {
        var explanations = doc.Descendants("explanation").ToList();

        var mapEncodingIdToInfo = new Dictionary<string, RawEncodingInfo>();

        foreach (var explanation in explanations)
        {
            var symbolElement = (XElement)explanation.Elements("symbol").First();
            var accountElement = explanation.Elements("account").FirstOrDefault() ?? explanation.Elements("definition").First();

            var link = symbolElement.Attribute("link")!.Value;
            var name = symbolElement.Value.Trim();
            var encodingSymbol = new RawEncodingSymbol
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
                var bitInfo = new RawEncodingBitInfo(bitName);
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

                var tbody = tableElement.Descendants("tbody").First();
                var rows = tbody.Elements("row").ToList();

                foreach (var row in rows)
                {
                    var bitValue = new RawEncodingBitValue();
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
                    encodingInfo = new RawEncodingInfo()
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

    [DebuggerDisplay("Name = {Name}, Symbols = {Symbols.Count}")]
    class RawEncodingInfo
    {
        public required string Name { get; init; } = string.Empty;

        public Dictionary<string, RawEncodingSymbol> Symbols { get; } = new();
    }

    [DebuggerDisplay("Link = {Link}, BitInfos = {BitInfosDebuggerDisplay}, BitValues = {BitValues.Count}")]
    class RawEncodingSymbol
    {
        public required string Link { get; init; } = string.Empty;

        public required string Name { get; init; } = string.Empty;

        public List<RawEncodingBitInfo> BitInfos { get; } = new();

        public List<RawEncodingBitValue> BitValues { get; } = new();

        private string BitInfosDebuggerDisplay => string.Join(":", BitInfos);

        public override string ToString()
        {
            return BitValues.Count > 0 ? $"{BitInfosDebuggerDisplay} ([{string.Join("], [", BitValues)}])" : BitInfosDebuggerDisplay;
        }
    }
    
    private record RawEncodingBitInfo(string BitName)
    {
        public List<int> BitIndices { get; } = new();

        public override string ToString()
        {
            if (BitIndices.Count == 0)
            {
                return BitName;
            }

            var builder = new StringBuilder();
            builder.Append(BitName);
            builder.Append('<');
            for (int i = 0; i < BitIndices.Count; i++)
            {
                if (i > 0)
                {
                    builder.Append(',');
                }
                builder.Append(BitIndices[i]);
            }
            builder.Append('>');
            return builder.ToString();
        }
    }

    private record RawEncodingBitValue
    {
        public string Value { get; set; } = string.Empty;
        public List<string> BitFields { get; } = new();

        public override string ToString() => $"BitFields = {string.Join(":", BitFields)}, Value = {Value}";
    }
}

