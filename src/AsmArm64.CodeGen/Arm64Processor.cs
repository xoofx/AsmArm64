// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Spectre.Console;

namespace AsmArm64.CodeGen;

// Feature
// Docvars ideas
// https://github.com/google/EXEgesis/blob/master/exegesis/arm/xml/docvars.cc

public partial class Arm64Processor
{
    private readonly string _baseSpecsFolder;
    private readonly string _basedOutputFolder;
    private readonly string _basedOutputTestFolder;

    private readonly List<Instruction> _instructions;
    private readonly Dictionary<string, string> _archVariantNameToArchitectureId = new();
    private readonly List<string> _features = new();
    private readonly List<ArchVariant> _featureExpressions = new();
    private readonly List<InstructionTrieNode> _allDecoders = new();
    private readonly TableGenEncoder _tableGenEncoder = new();

    public Arm64Processor(string baseSpecsFolder)
    {
        _baseSpecsFolder = baseSpecsFolder;
        _instructions = new List<Instruction>();

        var basePath = Path.GetDirectoryName(AppContext.BaseDirectory); // src\AsmArm64.CodeGen\bin\Debug\net8.0
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen\bin\Debug
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen\bin
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen
        basePath = Path.GetDirectoryName(basePath); // src
        _basedOutputFolder = Path.Combine(basePath!, "AsmArm64");
        if (!Directory.Exists(_baseSpecsFolder))
        {
            throw new ArgumentException($"Generated folder `{_baseSpecsFolder}` doesn't exist");
        }

        _basedOutputTestFolder = Path.Combine(basePath!, "AsmArm64.Tests");
        if (!Directory.Exists(_basedOutputTestFolder))
        {
            throw new ArgumentException($"Tests folder `{_basedOutputTestFolder}` doesn't exist");
        }
    }

    public void Run()
    {
        foreach (var index in new string[]
                 {
                     "index.xml",
                     "fpsimdindex.xml",
                     "sveindex.xml",
                     "mortlachindex.xml"
                 })
        {
            var xdoc = XDocument.Load(Path.Combine(_baseSpecsFolder, index));

            var ids = xdoc.Descendants("iform")
                .Attributes("iformfile")
                .Select(attr => attr.Value);

            foreach (var id in ids)
            {
                try
                {
                    ProcessInstructionFile(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing file {id}: {ex}");
                }
            }
        }

        //foreach (var instruction in _instructions.OrderBy(x => BinaryMask(x.BitfieldMask)))
        //{
        //    //if ((instruction.BitfieldMask >> 24) == 0xFF)
        //    //{
        //    //    continue;
        //    //}

        //    Console.WriteLine(instruction);
        //}

        //Console.WriteLine($"Instruction Count: {_instructions.Count}");

        BuildTrie();

        int maximumMemoLength = 0;
        int maximumNameLength = 0;
        foreach (var instruction in _instructions)
        {
            maximumMemoLength = Math.Max(maximumMemoLength, instruction.Mnemonic.Length);
            maximumNameLength = Math.Max(maximumNameLength, instruction.Name.Length);
        }

        //Console.WriteLine($"maximumMemoLength: {maximumMemoLength}");
        //Console.WriteLine($"maximumNameLength: {maximumNameLength}");

        ExtractArchitecture();


        //GenerateCode();
    }
    
    private void BuildTrie()
    {
        // Sort instructions by normalized name
        _instructions.Sort((left, right) => string.Compare(left.NormalizedName, right.NormalizedName, CultureInfo.InvariantCulture, CompareOptions.Ordinal));

        Dictionary<uint, List<Instruction>> instructionWithSameBitValues = new();

        for (var i = 0; i < _instructions.Count; i++)
        {
            var instruction = _instructions[i];
            //Console.WriteLine($"[{i}] {instruction}");

            if (!instructionWithSameBitValues.TryGetValue(instruction.BitfieldValue, out var list))
            {
                list = new List<Instruction>();
                instructionWithSameBitValues.Add(instruction.BitfieldValue, list);
            }

            list.Add(instruction);
        }

        //foreach (var bitPair in instructionWithSameBitValues)
        //{
        //    var instructions = bitPair.Value;
        //    if (instructions.Count > 1)
        //    {
        //        Console.WriteLine($"Instructions with same bit values: {bitPair.Key:X8}");
        //        foreach (var instruction in instructions)
        //        {
        //            Console.WriteLine($"  {instruction}");
        //            //_instructions.Remove(instruction);
        //        }
        //    }
        //}

        //return;

        var rootTrie = new InstructionTrieNode();
        _allDecoders.Add(rootTrie);
        for (int i = 0; i < _instructions.Count; i++)
        {
            rootTrie.InstructionIndices.Add(i);
        }

        var progress = AnsiConsole.Progress().Columns(new ProgressColumn[]
        {
            new SpinnerColumn(Spinner.Known.Dots), // Spinner
            new TaskDescriptionColumn(), // Task description
            new ProgressBarColumn(), // Progress bar
            new PercentageColumn(), // Percentage
            new ElapsedTimeColumn()
        });
        
        progress.Start(ctx =>
            {
                var trieTask = ctx.AddTask("[yellow]Building trie[/]", maxValue: _instructions.Count);
                rootTrie.RecursiveBuild(ctx, trieTask, _instructions, _allDecoders);
                
                var task = ctx.AddTask("[green]Building hash table[/]",  maxValue: _allDecoders.Count);
                for (var i = 0; i < _allDecoders.Count; i++)
                {
                    var instructionDecoder = _allDecoders[i];
                    instructionDecoder.PrepareForHash(ctx, task);
                    ctx.Refresh();
                }
            }
        );

        return;

        //for (var i = 0; i < _allDecoders.Count; i++)
        //{
        //    var decoder = _allDecoders[i];
        //    if (decoder.IsTerminal) continue;
        //    if (decoder.TableKind == TrieTableKind.Hash)
        //    {
        //        Console.WriteLine($"[{i}] Decoder {decoder.TableKind} ArrayLength: {decoder.DecoderArrayLength} HashMultiplier: 0x{decoder.HashMultiplier:X16}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"[{i}] Decoder {decoder.TableKind} ArrayLength: {decoder.DecoderArrayLength}");
        //    }
        //}

        _tableGenEncoder.Encode(rootTrie);
        AnsiConsole.WriteLine($"Generated Table {_tableGenEncoder.Buffer.Length} bytes");

        //Console.WriteLine("--------------------------------");
        //Console.WriteLine("Level 0-2");
        //Console.WriteLine("--------------------------------");
        //decoder.Print(_instructions, 0, 3);

        //Console.WriteLine("--------------------------------");
        //Console.WriteLine("All Levels");
        //Console.WriteLine("--------------------------------");

        using var writer = new StreamWriter("decoder.txt");
        rootTrie.Print(writer, _instructions);
    }

    private void ProcessInstructionFile(string fileName)
    {
        var xdoc = XDocument.Load(Path.Combine(_baseSpecsFolder, fileName));
        var iclasses = xdoc.Descendants("iclass").ToList();

        //if (iclasses.Count > 1)
        //{
        //    Console.WriteLine($">>> Not expected {iclasses.Count} from file {fileName}");
        //}

        var desc = xdoc.Descendants("desc").FirstOrDefault();
        string summary = string.Empty;
        if (desc != null)
        {
            summary = desc.Descendants("brief").First().Descendants("para").First().Value;
        }
        
        var bitFields = new List<BitRangeInfo>();
        var encodingBitFields = new List<BitRangeInfo>();
        foreach (var iclass in iclasses)
        {
            var regDiagrams = iclass.Descendants("regdiagram").First();
            var parentDocVars = GetDocVars(iclass);
            var archVariants = GetArchVariants(iclass);

            string? baseInstrClass = null;
            parentDocVars.TryGetValue("instr-class", out baseInstrClass);


            bitFields.Clear();
            ProcessBitFields(regDiagrams, bitFields);
            
            var encodings = iclass.Descendants("encoding");
            
            foreach (var encoding in encodings)
            {
                var encodingName = encoding.Attribute("name")?.Value!;
                var docVars = GetDocVars(encoding);
                
                string mnemonic = docVars["mnemonic"];
                int? dataType = null;
                string? alias = null;
                string? instrClass = null;

                if (docVars.TryGetValue("dataType", out var dataTypeText))
                {
                    dataType = int.Parse(dataTypeText);
                }
                docVars.TryGetValue("alias_mnemonic", out alias);
                docVars.TryGetValue("instr-class", out instrClass);

                if (alias != null)
                {
                    //if (alias != null)
                    //{
                    //    Console.WriteLine($"Alias: {mnemonic} -> {alias}");
                    //}
                    continue;
                }

                Debug.Assert(encodingName != null);
                Debug.Assert(mnemonic != null);

                instrClass ??= baseInstrClass ?? "Other";
                instrClass = $"{char.ToUpperInvariant(instrClass[0])}{instrClass.Substring(1)}";

                var instruction = new Instruction
                {
                    Filename = fileName,
                    Name = encodingName,
                    Mnemonic = mnemonic,
                    Summary = summary,
                    InstructionClass = instrClass,
                };
                instruction.ArchVariants.AddRange(archVariants);

                //if (encodingName == "B_only_branch_imm" || encodingName == "BL_only_branch_imm")
                //{
                //    instruction.BitfieldMask |= 3 << 24;
                //    instruction.BitfieldAny |= 3 << 24;
                //}

                encodingBitFields.Clear();
                ProcessBitFields(encoding, encodingBitFields);

                foreach (var bitField in bitFields)
                {
                    instruction.Add(bitField);
                }

                foreach (var bitField in encodingBitFields)
                {
                    instruction.Add(bitField);
                }

                instruction.Build();
                _instructions.Add(instruction);
            }
        }
    }

    private static Dictionary<string, string> GetDocVars(XElement element)
    {
        var docVars = element.Element("docvars")!.Descendants("docvar");
        var dict = new Dictionary<string, string>();
        foreach (var docVar in docVars)
        {
            var key = docVar.Attribute("key")?.Value;
            var value = docVar.Attribute("value")?.Value;
            if (key != null && value != null)
            {
                dict[key] = value;
            }
        }
        return dict;
    }

    private static List<ArchVariant> GetArchVariants(XElement element)
    {
        var archVariantElement = element.Element("arch_variants");
        var list = new List<ArchVariant>();
        if (archVariantElement is not null)
        {
            var archVariants = archVariantElement.Descendants("arch_variant");
            foreach (var archVariant in archVariants)
            {
                var feature = archVariant.Attribute("feature")?.Value;
                var name = archVariant.Attribute("name")?.Value;
                if (feature != null && name != null)
                {
                    list.Add(new ArchVariant(GetFeatureExpressionId(feature), feature, name));
                }
            }
        }

        return list;
    }
    
    private void ProcessBitFields(XElement elt, List<BitRangeInfo> bitFields)
    {
        var boxes = elt.Descendants("box");
        foreach (var box in boxes)
        {
            var bitFieldInfo = ConvertToBitFieldInfo(box);
            bitFields.Add(bitFieldInfo);
        }
    }

    private static BitRangeInfo ConvertToBitFieldInfo(XElement elt)
    {
        var name = elt.Attribute("name")?.Value;
        var hiBit = int.Parse(elt.Attribute("hibit")!.Value!);
        var width = int.Parse(elt.Attribute("width")?.Value ?? "1");

        var info = new BitRangeInfo
        {
            Name = name,
            HiBit = hiBit,
            Width = width,
        };
        var fieldSetsList = info.FieldSets;

        //if (name == "sz" && width == 2 && hiBit == 31)
        //{
        //    fieldSetsList.Add(BitKind.Zero);
        //    fieldSetsList.Add(BitKind.Zero);
        //}
        //else
        //if (name == "Q" && width == 1)
        //{
        //    fieldSetsList.Add(BitKind.Any);
        //}
        //else if (name == "b5" && width == 1 && hiBit == 31)
        //{
        //    fieldSetsList.Add(BitKind.Any);
        //}
        //else if (name == "immlo")
        //{
        //    for (int i = 0; i < width; i++)
        //    {
        //        fieldSetsList.Add(BitKind.Any);
        //    }
        //}
        //else
        {
            var columns = elt.Descendants("c");
            foreach (var column in columns)
            {
                var colSpan = column.Attribute("colspan");
                if (colSpan != null)
                {
                    var colNumber = int.Parse(colSpan.Value);
                    for (var i = 0; i < colNumber; i++)
                    {
                        fieldSetsList.Add(BitKind.NotSet);
                    }

                    continue;
                }

                var value = column.Value;
                if (value == "(0)") value = "0";
                else if (value == "(1)") value = "1";
                else if (value.StartsWith("!=")) value = ""; // TODO: ignore constraints for now

                if (value.Length == 1)
                {
                    switch (value[0])
                    {
                        case '0':
                            fieldSetsList.Add(BitKind.Zero);
                            break;
                        case '1':
                            fieldSetsList.Add(BitKind.One);
                            break;
                        case 'x':
                        case 'Z':
                        case 'N':
                            fieldSetsList.Add(BitKind.NotSet);
                            break;
                        default:
                            throw new InvalidOperationException($"Invalid bit value {value}");
                            break;
                    }
                }
                else if (value.Length == 0)
                {
                    fieldSetsList.Add(BitKind.NotSet);
                }
                else
                {
                    throw new InvalidOperationException($"Invalid bit value `{value}`");
                }
            }
        }

        return info;
    }
    
    private void ExtractArchitecture()
    {
        var distinctArchVariant = new Dictionary<string, List<ArchVariant>>();
        foreach (var instruction in _instructions)
        {
            foreach (var archVariant in instruction.ArchVariants)
            {
                if (!distinctArchVariant.TryGetValue(archVariant.FeatureExpressionId, out var list))
                {
                    list = new List<ArchVariant>();
                    distinctArchVariant.Add(archVariant.FeatureExpressionId, list);
                }

                if (!_featureExpressions.Contains(archVariant))
                {
                    _featureExpressions.Add(archVariant);
                }

                if (!list.Contains(archVariant))
                {
                    list.Add(archVariant);

                    string? archName = GetNormalizedArchName(archVariant.Name);

                    if (archName != null && !_archVariantNameToArchitectureId.ContainsKey(archVariant.Name))
                    {
                        _archVariantNameToArchitectureId.Add(archVariant.Name, archName);
                    }
                }
            }
        }

        var matchFeature = new Regex("FEAT_(\\w+)");

        // Print distinct arch variants
        foreach (var archVariant in _featureExpressions)
        {
            var localFeatures = new HashSet<string>();

            foreach (Match match in matchFeature.Matches(archVariant.FeatureExpression))
            {
                var feature = match.Groups[1].Value;
                if (!_features.Contains(feature))
                {
                    _features.Add(feature);
                }

                localFeatures.Add(feature);
            }

            //foreach (var name in pair.Value)
            //{
            //    Console.Write($",  {name}");
            //}

            //Console.WriteLine();
        }

        _features.Sort(string.CompareOrdinal);
        _featureExpressions.Sort((a, b) => string.CompareOrdinal(a.FeatureExpressionId, b.FeatureExpressionId));
    }

    private static string GetFeatureExpressionId(string feature)
    {
        feature = feature.Replace("(", "_Lp_").Replace(")", "_Rp_").Replace("||", "_Or_").Replace("&&", "_And_");
        feature = feature.Replace("FEAT_", string.Empty);
        feature = Regex.Replace(feature, @"\s+", string.Empty);
        feature = feature.Trim('_');
        feature = Regex.Replace(feature, "_+", "_");
        return feature;
    }

    private string? GetNormalizedArchName(string name)
    {
        string? archName = null;
        if (name.StartsWith("ARMv"))
        {
            archName = name.Replace('.', '_');
            archName += "_A";
        }
        else if (name.StartsWith("PROFILE_A"))
        {
            archName += "ARMv8_0_A";
        }
        else if (name.StartsWith("PROFILE_R"))
        {
            archName += "ARMv8_0_R";
        }

        return archName;
    }
}