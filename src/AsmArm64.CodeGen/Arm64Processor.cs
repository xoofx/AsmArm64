// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using AsmArm64.CodeGen.Model;
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

    private readonly InstructionSet _instructionSet = new();
    private readonly List<Instruction> _instructions;
    private readonly InstructionProcessor _instructionProcessor;

    private readonly Dictionary<string, string> _featureRequirementIdToArchitectureId = new();
    private readonly List<string> _features = new();
    private readonly List<FeatureExpression> _featureExpressions = new();
    private readonly List<InstructionTrieNode> _allNodes = new();
    private readonly Dictionary<string, int> _mapFeatureExpressionIdToIndex = new();

    private readonly TableGenEncoder _tableGenEncoder = new();
    private readonly Dictionary<uint, List<Instruction>> _instructionsWithSameBitValue;

    public Arm64Processor(string baseSpecsFolder)
    {
        _baseSpecsFolder = baseSpecsFolder;
        _instructions = _instructionSet.Instructions;
        _instructionsWithSameBitValue = new();
        _instructionProcessor = new(_instructionSet);

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
        LoadInstructions();

        //foreach (var paramName in _allParameterNames.Order())
        //{
        //    Console.WriteLine($"Parameter: {paramName}");
        //}

        ProcessInstructions();

        _instructionSet.WriteJson("instructions.json");

        //var isa2 = InstructionSet.ReadJson("instructions.json");
        //isa2.WriteJson("instructions2.json");

        //return;

        BuildTrie();
        
        GenerateCode();
    }


    private void ProcessInstructions()
    {
        _instructionProcessor.DumpAllOperands();

        ExtractArchitecture();

        _instructionProcessor.Run();
    }

    private void LoadInstructions()
    {
        bool hasErrors = false;
        foreach (var index in new string[]
                 {
                     "index.xml",
                     "fpsimdindex.xml",
                     //"sveindex.xml",
                     //"mortlachindex.xml"
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
                    hasErrors = true;
                }
            }
        }

        if (hasErrors)
        {
            throw new InvalidOperationException("Errors processing files");
        }

        MarkInstructionsNotTestableByBitFieldValue();
    }
    
    private void BuildTrie()
    {
        var rootTrie = new InstructionTrieNode();
        _allNodes.Add(rootTrie);
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
                rootTrie.RecursiveBuild(ctx, trieTask, _instructions, _allNodes);
                
                var task = ctx.AddTask("[green]Building hash table[/]",  maxValue: _allNodes.Count);
                for (var i = 0; i < _allNodes.Count; i++)
                {
                    var instructionDecoder = _allNodes[i];
                    instructionDecoder.PrepareForHash(ctx, task);
                    ctx.Refresh();
                }
            }
        );

        _tableGenEncoder.Encode(rootTrie);

        using var writer = new StreamWriter("decoder.txt");
        rootTrie.Print(writer, _instructions);

        PrintStatistics();
    }

    private void PrintStatistics()
    {
        AnsiConsole.MarkupLine($"[green]Instructions[/]: {_instructions.Count}");
        AnsiConsole.MarkupLine($"[green]Generated InstructionIdDecoder Table[/]: {_tableGenEncoder.Buffer.Length} bytes");
        AnsiConsole.MarkupLine($"[green]Generated InstructionIdDecoder Table Size / Instruction[/]: {((double)_tableGenEncoder.Buffer.Length/_instructions.Count):0.00} bytes");
        AnsiConsole.MarkupLine($"[green]Generated InstructionDecoder Table[/]: {_instructionProcessor.InstructionEncodingBuffer.Length} bytes");
        AnsiConsole.MarkupLine($"[green]Generated InstructionDecoder Offsets Table[/]: {_instructionProcessor.InstructionEncodingOffsets.Count * 2} bytes");

        var totalMemory = _tableGenEncoder.Buffer.Length + _instructionProcessor.InstructionEncodingBuffer.Length + _instructionProcessor.InstructionEncodingOffsets.Count * 2;
        double totalMemoryPerInstruction = (double)totalMemory / (_instructions.Count + 1);
        AnsiConsole.MarkupLine($"[green]Average Instruction Decoder Size / Instruction [/]: {totalMemoryPerInstruction:0.00} bytes");
        
        int numberOfHash = 0;
        int minimumSizeHash = int.MaxValue;
        int maximumSizeHash = 0;
        int numberOfSmallArray = 0;
        int minimumSizeSmallArray = int.MaxValue;
        int maximumSizeSmallArray = 0;
        foreach (var node in _allNodes)
        {
            if (node.TableKind == TrieTableKind.Hash)
            {
                numberOfHash++;
                minimumSizeHash = Math.Min(minimumSizeHash, (int)node.EncoderArrayLength);
                maximumSizeHash = Math.Max(maximumSizeHash, (int)node.EncoderArrayLength);
            }
            else if (node.TableKind == TrieTableKind.SmallArray)
            {
                numberOfSmallArray++;
                minimumSizeSmallArray = Math.Min(minimumSizeSmallArray, (int)node.EncoderArrayLength);
                maximumSizeSmallArray = Math.Max(maximumSizeSmallArray, (int)node.EncoderArrayLength);
            }
        }

        AnsiConsole.MarkupLine($"[green]Number of Hash Tables[/]: {numberOfHash}");
        AnsiConsole.MarkupLine($"[green]Minimum size Hash Tables[/]: {minimumSizeHash}");
        AnsiConsole.MarkupLine($"[green]Maximum size Hash Tables[/]: {maximumSizeHash}");
        AnsiConsole.MarkupLine($"[green]Number of SmallArray Tables[/]: {numberOfSmallArray}");
        AnsiConsole.MarkupLine($"[green]Minimum size SmallArray Tables[/]: {minimumSizeSmallArray}");
        AnsiConsole.MarkupLine($"[green]Maximum size SmallArray Tables[/]: {maximumSizeSmallArray}");
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

        var mapEncodingIdToInfo = ParseEncodingInfo(xdoc);
        
        var bitFields = new List<BitRangeInfo>();
        var encodingBitFields = new List<BitRangeInfo>();
        foreach (var iclass in iclasses)
        {
            var regDiagrams = iclass.Descendants("regdiagram").First();
            var parentDocVars = GetDocVars(iclass);
            var archVariants = GetFeatureExpressions(iclass);

            string? baseInstrClass = null;
            parentDocVars.TryGetValue("instr-class", out baseInstrClass);


            bitFields.Clear();
            ProcessBitFields(regDiagrams, bitFields);
            
            var encodings = iclass.Descendants("encoding").ToList();
            
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
                Debug.Assert(archVariants.Count <= 1);
                if (archVariants.Count == 1)
                {
                    instruction.FeatureRequirement = archVariants[0];
                }
                
                // Add doc vars
                foreach (var docVar in parentDocVars)
                {
                    instruction.DocVars[docVar.Key] = docVar.Value;
                }
                foreach (var docVar in docVars)
                {
                    instruction.DocVars[docVar.Key] = docVar.Value;
                }

                mapEncodingIdToInfo.TryGetValue(encodingName, out var encodingInfo);

                var operands = ParseOperands(encoding, encodingInfo);
                instruction.Operands.AddRange(operands);
                
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

    private void MarkInstructionsNotTestableByBitFieldValue()
    {
        for (var i = 0; i < _instructions.Count; i++)
        {
            var instruction = _instructions[i];

            if (!_instructionsWithSameBitValue.TryGetValue(instruction.BitfieldValue, out var list))
            {
                list = new List<Instruction>();
                _instructionsWithSameBitValue.Add(instruction.BitfieldValue, list);
            }

            list.Add(instruction);
        }

        foreach (var bitPair in _instructionsWithSameBitValue)
        {
            var instructions = bitPair.Value;
            if (instructions.Count > 1)
            {
                instructions.Sort((a, b) => BitOperations.PopCount(b.BitfieldMask).CompareTo(BitOperations.PopCount(a.BitfieldMask)));

                //// Uncomment to see the list. Could be added to decoder.txt
                ////
                //Console.WriteLine($"Instruction with equivalent BitFieldValue: 0x{bitPair.Key:X8}");
                //foreach (var instruction in instructions)
                //{
                //    Console.WriteLine($"  {instruction}");
                //}

                // For example for the following instructions:
                //
                // Instruction with equivalent BitFieldValue: 0xD500401F
                // CFINV_M_pstate                   CFINV        Mask: 0xFFFFFFFF Bits: 0xD500401F (Filename: cfinv.xml)
                // MSR_SI_pstate                    MSR          Mask: 0xFFF8F01F Bits: 0xD500401F op1 (18: 3) CRm (11: 4) op2 (7: 3) (Filename: msr_imm.xml)
                for (int i = 1; i < instructions.Count; i++)
                {
                    instructions[i].IsBitFieldValueTestable = false;
                }
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

    private static List<FeatureExpression> GetFeatureExpressions(XElement element)
    {
        var archVariantElement = element.Element("arch_variants");
        var list = new List<FeatureExpression>();
        if (archVariantElement is not null)
        {
            var archVariants = archVariantElement.Descendants("arch_variant");
            foreach (var archVariant in archVariants)
            {
                var feature = archVariant.Attribute("feature")?.Value;
                var name = archVariant.Attribute("name")?.Value;
                if (feature != null && name != null)
                {
                    list.Add(new FeatureExpression(GetFeatureExpressionId(feature), feature, name));
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
        var fieldSetsList = info.BitFieldSet;

        var columns = elt.Descendants("c");
        foreach (var column in columns)
        {
            var value = column.Value;
            if (value == "(0)") value = "0";
            else if (value == "(1)") value = "1";
            else if (value.StartsWith("!="))
            {
                info.OriginalCondition = value;

                var allZero = $"!= {new string('0', width)}";
                var allOne = $"!= {new string('1', width)}";

                if (allZero == value)
                {
                    info.Condition = BitRangeCondition.AllNonZero;
                }
                else if (allOne == value)
                {
                    info.Condition = BitRangeCondition.AllNonOne;
                }
                else if ("!= 111x" == value)
                {
                    info.Condition = BitRangeCondition.AllNon111x;
                }
                else if ("!= 11xxx" == value)
                {
                    info.Condition = BitRangeCondition.AllNon11xxx;
                }
                else
                {
                    Console.WriteLine($"Unsupported condition {value} - Please modify the codegen code");
                    info.Condition = BitRangeCondition.Unknown;
                }
                
                value = "";
            }

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


        return info;
    }

    private void ExtractArchitecture()
    {
        var distinctArchVariant = new Dictionary<string, List<FeatureExpression>>();
        foreach (var instruction in _instructions)
        {
            var archVariant = instruction.FeatureRequirement;
            if (archVariant != null)
            {
                if (!distinctArchVariant.TryGetValue(archVariant.Id, out var list))
                {
                    list = new List<FeatureExpression>();
                    distinctArchVariant.Add(archVariant.Id, list);
                }

                if (!_featureExpressions.Contains(archVariant))
                {
                    _featureExpressions.Add(archVariant);
                }

                if (!list.Contains(archVariant))
                {
                    list.Add(archVariant);

                    string? archName = GetNormalizedArchName(archVariant.Name);

                    if (archName != null && !_featureRequirementIdToArchitectureId.ContainsKey(archVariant.Name))
                    {
                        _featureRequirementIdToArchitectureId.Add(archVariant.Name, archName);
                    }
                }
            }
        }

        var matchFeature = new Regex("FEAT_(\\w+)");

        // Print distinct arch variants
        foreach (var archVariant in _featureExpressions)
        {
            var localFeatures = new HashSet<string>();

            foreach (Match match in matchFeature.Matches(archVariant.Expression))
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
        _featureExpressions.Sort((a, b) => string.CompareOrdinal(a.Id, b.Id));

        var featureExpressionIds = _featureExpressions.Select(x => x.Id).ToList();
        
        for (var i = 0; i < featureExpressionIds.Count; i++)
        {
            _mapFeatureExpressionIdToIndex.Add(featureExpressionIds[i], i + 1);
        }

        foreach (var instruction in _instructions)
        {
            var featureRequirement = instruction.FeatureRequirement;
            if (featureRequirement != null)
            {
                instruction.FeatureExpressionIdIndex = _mapFeatureExpressionIdToIndex[featureRequirement.Id];
            }
        }
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