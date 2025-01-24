// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{

    private static readonly Regex RegexWhen = new(@"when\s+'(?<encoding>[01\s]+)'\s+return\s+Sys_(?<sys_category>\w+)\s*;", RegexOptions.Compiled);

    private readonly Dictionary<string, SysDynamicDispatchEntry> _sysCategories = new();

    private void ProcessSysOp_For_DC_and_AT()
    {
        // <ps name="aarch64/functions/sysop/SysOp" mylink="aarch64.functions.sysop.SysOp" enclabels="" sections="1" secttype="Library">
        var xdoc = XDocument.Load(Path.Combine(_isaBaseSpecsFolder, "shared_pseudocode.xml"), LoadOptions.PreserveWhitespace);

        var elt = xdoc.Descendants("ps").First(x => x.Attribute("name")?.Value == "aarch64/functions/sysop/SysOp");

        var codeText = elt.Element("pstext")!.Value;

        var lineReader = new StringReader(codeText);

        while (lineReader.ReadLine() is { } line)
        {
            // when '000 0111 1000 000' return <a link="Sys_AT"

            var match = RegexWhen.Match(line);
            if (match.Success)
            {
                var encoding = match.Groups["encoding"].Value;
                var sysCategory = match.Groups["sys_category"].Value;

                if (!_sysCategories.TryGetValue(sysCategory, out var entry))
                {
                    entry = new SysDynamicDispatchEntry { Category = sysCategory };
                    _sysCategories.Add(sysCategory, entry);
                    InstructionSet.SysDynamicDispatchEntries.Add(entry);
                }

                encoding = MatchSpace.Replace(encoding, string.Empty);
                Debug.Assert(encoding.Length == 14); // 14 bits
                entry.Encodings.Add(encoding);
            }
        }
    }
}


public class SysDynamicDispatchEntry
{
    public string Category { get; init; } = string.Empty;

    // populate json
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> Encodings { get; } = new();
}


