// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using AsmArm64.CodeGen.Model;
using Microsoft.Win32;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{
    private readonly Dictionary<string, SystemRegister> _systemRegisters = new();
    private readonly HashSet<string> _systemRegisterUsageKinds = new HashSet<string>();
    private readonly HashSet<ushort> _systemRegisterValues = new();

    private readonly HashSet<string> _systemRegistersNotHandled = new();
    private readonly HashSet<string> _systemRegistersHandled = new();

    // Register with same values
    // DBGDTRRX_EL0 <- used by MRS
    // DBGDTRTX_EL0 <- used by MSR
    private const string DuplicatedSystemRegister0 = "DBGDTRRX_EL0";
    private const string DuplicatedSystemRegister1 = "DBGDTRTX_EL0";

    public static readonly Dictionary<string, int> RegisteredSystemRegisterUsageKinds = new()
    {
        ["APAS"] = 1,
        ["AT"] = 2,
        ["BRB"] = 3,
        ["CFP"] = 4,
        ["COSP"] = 5,
        ["CPP"] = 6,
        ["DC"] = 7,
        ["DVP"] = 8,
        ["GCSPOPCX"] = 9,
        ["GCSPOPM"] = 10,
        ["GCSPOPX"] = 11,
        ["GCSPUSHM"] = 12,
        ["GCSPUSHX"] = 13,
        ["GCSSS1"] = 14,
        ["GCSSS2"] = 15,
        ["IC"] = 16,
        ["MRRS"] = 17,
        ["MRS"] = 18,
        ["MSR"] = 19,
        ["MSRR"] = 20,
        ["TLBI"] = 21,
        ["TLBIP"] = 22,
        ["TRCIT"] = 23,
    };

    private static readonly string[] SystemRegisterKinds = RegisteredSystemRegisterUsageKinds.OrderBy(x => x.Value).Select(x => x.Key).ToArray();

    public static string GetSystemRegisterKind(int index)
    {
        Debug.Assert(index > 0 && index <= SystemRegisterKinds.Length);
        return SystemRegisterKinds[index - 1];
    }
    
    private void ProcessSystemRegisters()
    {
        foreach (var xmlFile in Directory.EnumerateFiles(_registerSpecsFolder, "*.xml"))
        {
            var doc = XDocument.Load(xmlFile, LoadOptions.PreserveWhitespace);
            foreach (var register in doc.Descendants("register"))
            {
                var regGenericName = register.Element("reg_short_name")!.Value;
                var executionState = register.Attribute("execution_state");
                if (executionState is null || executionState.Value != "AArch64")
                {
                    _systemRegistersNotHandled.Add(regGenericName);
                    //Console.WriteLine($"Xml file skipped {xmlFile} because no execution state");
                    continue;
                }
                
                var description = register.Element("reg_long_name")!.Value;

                var accessors = register.Descendants("access_mechanism").ToList();

                foreach (var accessor in accessors)
                {
                    // accessor example:
                    // <access_mechanism accessor="MRS ACTLR_EL2" type="SystemAccessor">

                    var accessorName = accessor.Attribute("accessor")!.Value;
                    var accessorNameList = accessorName.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    Debug.Assert(accessorNameList.Count == 1 || accessorNameList.Count == 2);
                    var regName = accessorNameList.Count == 2 ? accessorNameList[1] : accessorNameList[0];
                    string kind;
                    
                    if (accessorNameList.Count == 2)
                    {
                        kind = accessorNameList[0];
                        // MSRimmediate are handled differently (they have a different encoding than MSR registers)
                        if (kind.Equals("MSRimmediate", StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }
                        if (kind.Equals("MSRregister", StringComparison.OrdinalIgnoreCase))
                        {
                            kind = "MSR";
                        }

                        if (kind.Equals("MSRRregister", StringComparison.OrdinalIgnoreCase))
                        {
                            kind = "MSRR";
                        }
                    }
                    else
                    {
                        kind = regName;
                    }
                    
                    var encoding = accessor.Element("encoding");
                    if (encoding is null)
                    {
                        _systemRegistersNotHandled.Add(regGenericName);
                        continue;
                    }

                    // <acc_array var="m">
                    //     <acc_array_range>0-15</acc_array_range>
                    // </acc_array>
                    var acc_array = encoding.Element("acc_array");
                    string? varName = null;
                    int start = 0;
                    int end = 0;
                    if (acc_array is not null)
                    {
                        varName = acc_array.Attribute("var")!.Value;
                        var range = acc_array.Element("acc_array_range")!.Value;
                        var match = Regex.Match(range, @"(\d+)-(\d+)");
                        if (match.Success)
                        {
                            start = int.Parse(match.Groups[1].Value);
                            end = int.Parse(match.Groups[2].Value);
                        }
                        else
                        {
                            Console.WriteLine($"Weird range for {encoding}");
                            _systemRegistersNotHandled.Add(regGenericName);
                            continue;
                        }
                    }
                    
                    // enc example:
                    // <enc n="op0" v="0b11"/>
                    // <enc n="op1" v="0b100"/>
                    // <enc n="CRn" v="0b0001"/>
                    // <enc n="CRm" v="0b0000"/>
                    // <enc n="op2" v="0b001"/>
                    var encList = encoding.Elements("enc").ToList();

                    Debug.Assert(encList.Count == 5);

                    var names = encList.Select(x => x.Attribute("n")).ToList();
                    if (names[0]!.Value != "op0" || names[1]!.Value != "op1" || names[2]!.Value != "CRn" || names[3]!.Value != "CRm" || names[4]!.Value != "op2")
                    {
                        Debug.Assert(false, $"Weird list of operators for {encoding}");
                        _systemRegistersNotHandled.Add(regGenericName);
                        continue;
                    }

                    var bits = encList.Select(x => x.Attribute("v")!.Value.Replace("0b", "")).ToList();
                    bool requiresNameVariation = bits.Any(x => x.Contains('['));
                    var bitsAsText = $"{string.Join("_", bits)}";

                    if (requiresNameVariation && varName is null)
                    {
                        //Console.WriteLine($"SKIPPED {regName} -> {bitsAsText} <- Accessor: {accessorName}");
                        //Debug.Assert(false, $"Weird varName for {encoding}");
                        _systemRegistersNotHandled.Add(regGenericName);
                        continue;
                    }

                    Debug.Assert(!bitsAsText.Contains('x'));

                    _systemRegistersHandled.Add(regGenericName);

                    if (requiresNameVariation)
                    {

                        var builder = new StringBuilder();
                        for (int varIndex = start; varIndex <= end; varIndex++)
                        {
                            var m = varIndex;
                            var newBits = MatchVariableInBits.Replace(bitsAsText, evaluator =>
                            {
                                var name = evaluator.Groups["varName"].Value;
                                Debug.Assert(name == varName);
                                var bits = evaluator.Groups["bits"].Value;
                                int startBit;
                                int endBit;
                                if (bits.Contains(':'))
                                {
                                    var digits = bits.Split(':');
                                    endBit = int.Parse(digits[0]);
                                    startBit = int.Parse(digits[1]);
                                }
                                else
                                {
                                    startBit = endBit = int.Parse(bits);
                                }

                                builder.Clear();
                                for (int i = endBit; i >= startBit; i--)
                                {
                                    builder.Append((m & (1 << i)) != 0 ? '1' : '0');
                                }

                                return builder.ToString();
                            });

                            newBits = newBits.Replace(":", string.Empty);

                            var newRegName = ReplaceVariation(regName, m);
                            var newDescription = ReplaceVariation(description, m);
                            AddRegister(newRegName, newDescription, kind, newBits);
                        }
                    }
                    else
                    {
                        AddRegister(regName, description, kind, bitsAsText);
                    }

                }
            }
        }

        // Add registers to the instruction set data
        InstructionSet.SystemRegisters.AddRange(_systemRegisters.OrderBy(x => x.Key).Select(x => x.Value));

        //foreach (var register in InstructionSet.SystemRegisters)
        //{
        //    Console.WriteLine(register);
        //}

        // Kinds
        var maxKnownIndex = RegisteredSystemRegisterUsageKinds.Values.Max();
        
        int kindIndex = maxKnownIndex;
        bool hasErrors = false;
        foreach (var kind in _systemRegisterUsageKinds.OrderBy(x => x))
        {
            if (RegisteredSystemRegisterUsageKinds.ContainsKey(kind)) continue;

            if (!hasErrors)
            {
                Console.WriteLine("// Unknown kinds to add to Arm64Processor.SystemRegisters.cs / _registeredKinds");
            }
            kindIndex++;
            Console.WriteLine($"  [\"{kind}\"] = {kindIndex},");
            hasErrors = true;
        }


        // Print system registers that are not handled (without an encoding)
        //if (_systemRegistersNotHandled.Count > 0)
        //{
        //    Console.WriteLine("// System registers not handled");
        //    foreach (var trcRegister in _systemRegistersNotHandled.OrderBy(x => x))
        //    {
        //        if (!_systemRegistersHandled.Contains(trcRegister))
        //        {
        //            Console.WriteLine($"// {trcRegister}");
        //        }
        //    }
        //}

        Console.WriteLine($"Number of system registers: {InstructionSet.SystemRegisters.Count}");

        if (hasErrors)
        {
            Debug.Assert(false, "Unknown kinds found");
        }
    }

    private void GenerateSystemRegistersCode()
    {
        GenerateSystemRegisterT4();
        GenerateSystemRegisterKnownId();
        GenerateSystemRegisterKnownIdTable();
        GenerateSystemRegisterFactory();
    }
    
    private void GenerateSystemRegisterT4()
    {
        using var w = GetWriter("Arm64SystemRegisterKind.gen.tt", header: false);

        w.WriteLine("<#");
        w.Write("var kinds = new List<(string, int)>()");
        w.OpenBraceBlock();
        foreach (var kind in RegisteredSystemRegisterUsageKinds.OrderBy(x => x.Value))
        {

            w.WriteLine($"    (\"{kind.Key}\", {kind.Value}),");
        }
        w.CloseBraceBlockStatement();

        w.WriteLine("#>");
    }

    private void GenerateSystemRegisterKnownId()
    {
        using var w = GetWriter("Arm64SystemRegisterKnownId.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("All known system register accessible through an id/enum.");
        w.WriteLine("public enum Arm64SystemRegisterKnownId : ushort");
        w.OpenBraceBlock();
        w.WriteSummary("No specified system register.");
        w.WriteLine("None = 0,");
        for (var i = 0; i < InstructionSet.SystemRegisters.Count; i++)
        {
            var register = InstructionSet.SystemRegisters[i];
            w.WriteSummary(register.Description);
            w.WriteLine($"{register.Name} = {i + 1},"); // TODO: fix the numbers
        }

        w.CloseBraceBlock();
    }

    private void GenerateSystemRegisterKnownIdTable()
    {
        using var w = GetWriter("Arm64SystemRegisterTable.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteSummary("All known system register accessible through an id/enum.");
        w.WriteLine("static partial class Arm64SystemRegisterTable");
        w.OpenBraceBlock();
        {
            w.WriteLine("private static readonly string[] NamesOrderedById = ");
            w.WriteLine("[");
            w.Indent();
            w.WriteLine("\"???\",");
            foreach (var register in InstructionSet.SystemRegisters)
            {
                w.WriteLine($"\"{register.Name}\",");
            }
            w.UnIndent();
            w.WriteLine("];");

            w.WriteLine("private static readonly Arm64SystemRegisterKind[] KindsOrderedById = ");
            w.WriteLine("[");
            w.Indent();
            w.WriteLine("Arm64SystemRegisterKind.Unknown,");
            foreach (var register in InstructionSet.SystemRegisters)
            {
                w.WriteLine($"{string.Join(" | ", register.UsageKinds.Select(x => $"Arm64SystemRegisterKind.{x}"))}, // {register.Name}");
            }
            w.UnIndent();
            w.WriteLine("];");
            
            w.WriteLine("private static readonly ushort[] ValuesOrderedById = ");
            w.WriteLine("[");
            w.Indent();
            w.WriteLine("0,");
            foreach (var register in InstructionSet.SystemRegisters)
            {
                w.WriteLine($"0x{register.Value:X4}, // {register.Name}"); 
            }
            w.UnIndent();
            w.WriteLine("];");
            
            w.WriteLine("private static readonly Arm64SystemRegisterKnownId[] IdsOrderedByValue = ");
            w.WriteLine("[");
            w.Indent();
            w.WriteLine("Arm64SystemRegisterKnownId.None,");

            // We skip a duplicate register with the same value, we will resolve it at runtime
            var systemRegistersOrderedByValue = InstructionSet.SystemRegisters
                .Select((x, index) => (Register: x, Index: index))
                .OrderBy(x => x.Register.Value)
                .Where(x => x.Register.Name != DuplicatedSystemRegister1)
                .ToList();

            foreach (var pair in systemRegistersOrderedByValue)
            {
                w.WriteLine($"Arm64SystemRegisterKnownId.{pair.Register.Name},");
            }
            w.UnIndent();
            w.WriteLine("];");

            w.WriteLine("private static readonly ushort[] ValuesForBinarySearch = ");
            w.WriteLine("[");
            w.Indent();
            w.WriteLine("0,");
            foreach (var pair in systemRegistersOrderedByValue)
            {
                w.WriteLine($"0x{pair.Register.Value:X4}, // {pair.Register.Name}");
            }
            w.UnIndent();
            w.WriteLine("];");
        }
        w.CloseBraceBlock();
    }


    private void GenerateSystemRegisterFactory()
    {
        using var w = GetWriter("Arm64SystemRegisterFactory.gen.cs");

        w.WriteLine("namespace AsmArm64;");
        w.WriteLine();
        w.WriteLine("partial class Arm64Factory");
        w.OpenBraceBlock();
        for (var i = 0; i < InstructionSet.SystemRegisters.Count; i++)
        {
            var register = InstructionSet.SystemRegisters[i];
            w.WriteSummary(register.Description);
            var registerKind = $"{string.Join(" | ", register.UsageKinds.Select(x => $"Arm64SystemRegisterKind.{x}"))}";
            var prefix = SystemRegistersAlsoProcessStates.Contains(register.Name) ? "_" : "";
            w.WriteLine($"public static Arm64SystemRegister {prefix}{register.Name} => new(Arm64SystemRegisterKnownId.{register.Name}, 0x{register.Value:X4}, {registerKind});");
        }

        w.CloseBraceBlock();
    }

    private static HashSet<string> SystemRegistersAlsoProcessStates = new HashSet<string>()
    {
        "ALLINT",
        "DIT",
        "PAN",
        "PM",
        "UAO",
        "PAN",
        "SPSel",
        "SSBS",
        "TCO",
        "RCTX",
    };

    private static string ReplaceVariation(string text, int m)
    {
        var newText = MatchVariableInName.Replace(text, evaluator =>
        {
            var name = evaluator.Groups["varName"].Value;
            return m.ToString();
        });
        return newText;
    }
    
    private void AddRegister(string name, string description, string usageKind, string bits)
    {
        var rawBits = bits.Replace("_", string.Empty);
        ushort value = Convert.ToUInt16(rawBits, 2);
        
        if (!_systemRegisters.TryGetValue(name, out var register))
        {
            register = new SystemRegister()
            {
                Name = name,
                Description = description,
                Value = value,
            };
            _systemRegisters.Add(name, register);
            Debug.Assert(register.GetBits() == $"0b{bits}");

            if (!_systemRegisterValues.Add(value))
            {
                // DBGDTRRX_EL0 <- used by MRS
                // DBGDTRTX_EL0 <- used by MSR
                Debug.Assert(name == DuplicatedSystemRegister0|| name == DuplicatedSystemRegister1);
            }
        }

        if (!register.UsageKinds.Contains(usageKind))
        {
            register.UsageKinds.Add(usageKind);
            // Maintain the list sorted
            register.UsageKinds.Sort();
        }

        _systemRegisterUsageKinds.Add(usageKind);
    }

    private static readonly Regex MatchVariableInBits = new(@"(?<varName>[A-Za-z]\w*)\[(?<bits>[^\]]+)\]");

    private static readonly Regex MatchVariableInName = new(@"<(?<varName>[A-Za-z]\w*)>");
}