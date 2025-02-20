// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Formats.Tar;
using System.Globalization;
using System.IO.Compression;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using AsmArm64.CodeGen.Model;
using Spectre.Console;

namespace AsmArm64.CodeGen;

partial class Arm64Processor
{
    private readonly string _isaTarGzUrl;
    private readonly string _systemRegistersTarGzUrl;
    private readonly string _capstoneSourceTarGzUrl;
    private string _isaBaseSpecsFolder = string.Empty;
    private string _registerSpecsFolder = string.Empty;
    private string _capstoneArchiveFile = string.Empty;
    private readonly string _basedRootFolder;
    private readonly string _basedOutputFolder;
    private readonly string _basedOutputTestFolder;
    private readonly string _tmpFolder;

    public readonly InstructionSet InstructionSet = new();

    private readonly List<Instruction> _instructions;
    private readonly InstructionProcessor _instructionProcessor;

    private readonly Dictionary<string, string> _featureRequirementIdToArchitectureId = new();
    private readonly List<string> _features = new();
    private readonly List<FeatureExpression> _featureExpressions = new();
    private readonly List<InstructionTrieNode> _allNodes = new();
    private readonly Dictionary<string, int> _mapFeatureExpressionIdToIndex = new();

    private readonly TableGenEncoder _tableGenEncoder;
    private readonly Dictionary<uint, List<Instruction>> _instructionsWithSameBitValue;
    
    public Arm64Processor(string isaTarGzURL, string systemRegistersTarGzUrl, string capstoneSourceTarGzUrl)
    {
        _isaTarGzUrl = isaTarGzURL;
        _systemRegistersTarGzUrl = systemRegistersTarGzUrl;
        _capstoneSourceTarGzUrl = capstoneSourceTarGzUrl;
        _instructions = InstructionSet.Instructions;
        _instructionsWithSameBitValue = new();
        _instructionProcessor = new(InstructionSet, _systemRegisterUsageKinds);
        _tableGenEncoder = new(InstructionSet);

        var basePath = Path.GetDirectoryName(AppContext.BaseDirectory); // src\AsmArm64.CodeGen\bin\Debug\net8.0
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen\bin\Debug
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen\bin
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen
        basePath = Path.GetDirectoryName(basePath); // src
        _basedRootFolder = Path.GetDirectoryName(basePath)!;
        _basedOutputFolder = Path.Combine(basePath!, "AsmArm64");
        _basedOutputTestFolder = Path.Combine(basePath!, "AsmArm64.Tests");
        if (!Directory.Exists(_basedOutputTestFolder))
        {
            throw new ArgumentException($"Tests folder `{_basedOutputTestFolder}` doesn't exist");
        }

        _tmpFolder = Path.Combine(_basedRootFolder, "tmp");
        if (!Directory.Exists(_tmpFolder))
        {
            Directory.CreateDirectory(_tmpFolder);
        }
    }

    /// <summary>
    /// Map of instruction id to instructions
    /// </summary>
    internal Dictionary<string, Instruction> MapIdToInstruction { get; } = new();

    public async Task Run()
    {
        await DownloadFiles();

        await GenerateCapstoneTests();

        ProcessSystemRegisters();

        ProcessSysOp_For_DC_and_AT();

        LoadInstructions();

        //foreach (var paramName in _allParameterNames.Order())
        //{
        //    Console.WriteLine($"Parameter: {paramName}");
        //}

        ProcessInstructions();

        InstructionSet.WriteJson("instructions.json");

        GenerateCode();
        
        BuildTrie();

        GenerateDecoderTables();
    }

    private async Task GenerateCapstoneTests()
    {
        await AnsiConsole.Status().StartAsync($"Generating tests from Capstone {_capstoneArchiveFile}", ctx =>
        {
            var generator = new McInstructionTestsGen();
            generator.ProcessFilesFromTar(_capstoneArchiveFile);
            generator.GenerateTests();
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine($"Generated {generator.TestCount} tests from Capstone {_capstoneArchiveFile}");
            return Task.CompletedTask;
        });
    }

    private async Task DownloadFiles()
    {
        _isaBaseSpecsFolder = await DownloadAndExtractTarGz(_isaTarGzUrl, true);
        _registerSpecsFolder = await DownloadAndExtractTarGz(_systemRegistersTarGzUrl, true);
        _capstoneArchiveFile = await DownloadAndExtractTarGz(_capstoneSourceTarGzUrl, false);
    }

    private async Task<string> DownloadAndExtractTarGz(string url, bool extract, string? localFileName = null)
    {
        localFileName ??= Path.GetFileName(url);
        var downloadFile = Path.Combine(_tmpFolder, localFileName);
        if (!File.Exists(downloadFile))
        {
            await AnsiConsole.Status().StartAsync($"Downloading {url} to {downloadFile}", async ctx =>
            {
                using var client = new HttpClient();
                using var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                await using var fileStream = File.Create(downloadFile);
                await response.Content.CopyToAsync(fileStream);
            });
        }

        if (!extract)
        {
            return downloadFile;
        }

        var extractFolder = Path.GetFileNameWithoutExtension(localFileName);
        if (extractFolder.EndsWith("tar"))
        {
            extractFolder = Path.GetFileNameWithoutExtension(extractFolder);
        }
        extractFolder = Path.Combine(_tmpFolder, extractFolder);

        if (!Directory.Exists(extractFolder))
        {
            await AnsiConsole.Status().StartAsync($"Extracting {downloadFile} to {extractFolder}", async ctx =>
            {
                var fileStream = File.OpenRead(downloadFile);
                await using var gzStream = new GZipStream(fileStream, CompressionMode.Decompress, false);
                await TarFile.ExtractToDirectoryAsync(gzStream, _tmpFolder, true);
            });
        }

        return extractFolder;
    }
    
    private void ProcessInstructions()
    {
        AnsiConsole.WriteLine($"Processing {_instructions.Count} Instructions");
        _instructionProcessor.DumpAllOperands();

        ExtractArchitecture();

        _instructionProcessor.Run();
    }

    private void LoadInstructions()
    {
        AnsiConsole.WriteLine("Loading Instructions");
        bool hasErrors = false;
        foreach (var index in new string[]
                 {
                     "index.xml",
                     "fpsimdindex.xml",
                     //"sveindex.xml",
                     //"mortlachindex.xml"
                 })
        {
            var xdoc = XDocument.Load(Path.Combine(_isaBaseSpecsFolder, index), LoadOptions.PreserveWhitespace);

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

        // Fill out the map once we are done processing all instructions
        foreach (var instruction in _instructions)
        {
            MapIdToInstruction.Add(instruction.Id, instruction);

        }
        
        // Discard instructions that have an alias that should be always preferred
        for (var i = 0; i < _instructions.Count; i++)
        {
            var instruction = _instructions[i];
            instruction.Index = i + 1;

            if (instruction.Alias != null)
            {
                var target = MapIdToInstruction[instruction.Alias.InstructionId];
                target.AliasesIn.Add(new AliasInfo(instruction.Id, instruction.Alias.Condition) {IsOut = false});
            }
        }
        
        foreach (var instruction in _instructions)
        {
            if (instruction.AliasesIn.Count > 0)
            {
                //Console.WriteLine($"Instruction {instruction.Id} - {instruction.FullSyntax} is aliased by:");

                foreach (var alias in instruction.AliasesIn)
                {
                    var targetInstruction = MapIdToInstruction[alias.InstructionId];
                    if (targetInstruction.BitfieldMask == instruction.BitfieldMask)
                    {
                        // Instruction that are aliased and have the same fields are problematic.
                        // We need to detect if:
                        // - the instruction needs to be discarded (there is a preferred instructions that we should always use)
                        // - the instruction is aliased with a dynamic condition
                        
                        if (alias.IsAlways)
                        {
                            //Console.WriteLine($"  --- The instruction {instruction.Id}` is discarded in favor of {alias.InstructionId} when {alias.Condition}");
                            Debug.Assert(!instruction.IsAliasWithDynamicCondition);
                            instruction.IsDiscardedByPreferredAlias = true;
                        }
                        else if (alias.IsNever)
                        {
                            //Console.WriteLine($"  --- The alias {alias.InstructionId} is discarded - Same Mask");
                            Debug.Assert(!targetInstruction.IsAliasWithDynamicCondition);
                            targetInstruction.IsDiscardedByPreferredAlias = true;
                        }
                        else
                        {
                            //Console.WriteLine($"  ??? The alias {alias.InstructionId} is kept - {alias.Condition}");
                            Debug.Assert(!targetInstruction.IsDiscardedByPreferredAlias);
                            targetInstruction.IsAliasWithDynamicCondition = true;
                        }
                    }
                    else
                    {
                        targetInstruction.IsAliasPreferredByMoreSelectiveBitMask = true;
                        Debug.Assert(
                            BitOperations.PopCount(targetInstruction.BitfieldMask) >
                            BitOperations.PopCount(instruction.BitfieldMask),
                            $"Alias {targetInstruction.Id} is more selective with its BitfieldMask than {instruction.Id}");

                    }
                }
            }
        }

        DetectConflictingAliases();

        foreach (var instruction in _instructions)
        {
            if (instruction.AliasesIn.Count == 0) continue;

            foreach (var alias in instruction.AliasesIn)
            {
                var targetInstruction = MapIdToInstruction[alias.InstructionId];
                if (targetInstruction.IsAliasWithDynamicCondition)
                {
                    Debug.Assert(!instruction.IsDiscardedByPreferredAlias); // An instruction cannot be discarded
                    Debug.Assert(!instruction.IsAliasWithDynamicCondition);
                    instruction.HasAliasesInAndRequiringDynamicResolution = true;
                    break;
                }
            }
        }

        //foreach (var instruction in _instructions)
        //{
        //    if (instruction.IsDiscardedByPreferredAlias)
        //    {
        //        Console.WriteLine($"DISCARD {instruction.Id}");
        //    }
        //    else if (instruction.IsAliasWithDynamicCondition)
        //    {
        //        Console.WriteLine($"ALIAS-COND {instruction.Id}");
        //    }
        //}

        MarkInstructionsNotTestableByBitFieldValue();
    }


    private void DetectConflictingAliases()
    {
        var mapSameBitMask = new Dictionary<(uint, uint), List<Instruction>>();

        // Collect instructions with the same bit mask/bit value
        foreach (var instruction in _instructions)
        {
            if (instruction.IsDiscardedByPreferredAlias || instruction.IsAliasWithDynamicCondition)
            {
                continue;
            }

            var key = (instruction.BitfieldMask, instruction.BitfieldValue);
            if (!mapSameBitMask.TryGetValue(key, out var list))
            {
                list = new List<Instruction>();
                mapSameBitMask.Add(key, list);
            }

            list.Add(instruction);
        }

        // Delete all instructions that have a single representation
        foreach (var keyPair in mapSameBitMask.ToList())
        {
            if (keyPair.Value.Count == 1)
            {
                mapSameBitMask.Remove(keyPair.Key);
            }
        }

        // Check the remaining conflicting instructions and check that they refer to the same alias.
        // In that case, we can mark them as requiring a dynamic condition during instruction decoding.
        var aliases = new HashSet<string>();
        foreach (var keyPair in mapSameBitMask)
        {
            aliases.Clear();
            var conflictingInstructions = keyPair.Value;
            foreach (var instruction in conflictingInstructions)
            {
                Debug.Assert(instruction.Alias is not null,
                    $"Unexpected state the instruction {instruction.Id} with others ({string.Join(",", conflictingInstructions.Select(x => x.Id != instruction.Id))}) is required to have an alias");
                aliases.Add(instruction.Alias.InstructionId);

                // Mark the instruction conflicting requiring a dynamic condition so that it won't be included in the trie builder later.
                instruction.IsAliasWithDynamicCondition = true;
            }

            Debug.Assert(aliases.Count == 1, $"The instructions cannot have different aliases target\n  {string.Join("\n  ", conflictingInstructions.Select(x => $"{x.Id} => {x.Alias!.InstructionId}"))}");
        }
    }
    
    private void BuildTrie()
    {
        AnsiConsole.WriteLine("Building Instruction Decoding Table");
        var rootTrie = new InstructionTrieNode();
        _allNodes.Add(rootTrie);
        for (int i = 0; i < _instructions.Count; i++)
        {
            var instruction = _instructions[i];
            if (instruction.IsDiscardedByPreferredAlias || instruction.IsAliasWithDynamicCondition)
            {
                continue;
            }
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
        AnsiConsole.MarkupLine($"[green]Generated InstructionDecoder Offsets Table[/]: {_instructions.Count * 2} bytes");

        var totalMemory = _tableGenEncoder.Buffer.Length + _instructionProcessor.InstructionEncodingBuffer.Length + _instructions.Count * 2;
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
        var xdoc = XDocument.Load(Path.Combine(_isaBaseSpecsFolder, fileName), LoadOptions.PreserveWhitespace);
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

        var mapEncodingIdToInfo = ParseEncodingInfo(fileName, xdoc);
        
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

                Debug.Assert(encodingName != null);
                Debug.Assert(mnemonic != null);

                instrClass ??= baseInstrClass ?? "Other";
                instrClass = $"{char.ToUpperInvariant(instrClass[0])}{instrClass.Substring(1)}";

                bool process2ndInstructionVariation = false;
                string? multiInstructionSymbol = null;

                add_instruction_variation:

                var instruction = new Instruction
                {
                    Filename = fileName,
                    Id = Instruction.NormalizeId(encodingName),
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

                var equivalentToElt = encoding.Element("equivalent_to");
                if (equivalentToElt is not null)
                {
                    var aliasCond = equivalentToElt.Element("aliascond")!.Value!;
                    var asmTemplate = equivalentToElt.Element("asmtemplate")!;

                    var asmText = asmTemplate.Value;
                    //if (asmText.Contains(" MOD ") || asmText.Contains("-<") || asmText.Contains(">-") || asmText.Contains("+<") || asmText.Contains(">+"))
                    //{
                    //    Console.WriteLine($"WARNING {instruction.Id} => {asmText}");
                    //}

                    var href = asmTemplate.Element("a")!.Attribute("href")!.Value!;
                    var targetId = Instruction.NormalizeId(href.Substring(href.IndexOf('#') + 1));

                    instruction.Alias = new(targetId, aliasCond) { IsOut = true };
                    Debug.Assert(alias is not null);
                    instruction.Mnemonic = alias!;
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

                mapEncodingIdToInfo.TryGetValue(encodingName, out var encodingInfo);
                DetectMultiInstruction(encoding, encodingInfo, out multiInstructionSymbol, out var multiInstructionPostFixes);

                uint checkMask = 0;
                uint checkValue = 0;
                string? bitEncodingNameVariation = null;

                // If we have a variation, encode the variation as a bit field
                if (multiInstructionSymbol is not null)
                {
                    Debug.Assert(encodingInfo is not null);
                    var variationSymbol = encodingInfo!.Symbols[multiInstructionSymbol];
                    bitEncodingNameVariation = variationSymbol.EncodedInText;
                    var bitRange = instruction.BitRanges.First(x => x.Name == bitEncodingNameVariation);
                    var bitFieldSet = bitRange.BitFieldSet;
                    Debug.Assert(bitFieldSet.Count == 1);
                    Debug.Assert(bitFieldSet[0] == BitKind.NotSet);
                    // Replace the bit field with a 0 or 1 depending on the variation
                    bitFieldSet[0] = process2ndInstructionVariation ? BitKind.One : BitKind.Zero;
                    checkMask = 1U << (bitRange.HiBit - bitRange.Width + 1);
                    checkValue = process2ndInstructionVariation ? checkMask : 0;

                    Debug.Assert(multiInstructionPostFixes is not null);
                    PatchInstructionWithPostFix(instruction, multiInstructionPostFixes[process2ndInstructionVariation ? 1 : 0]);
                }
                
                instruction.Initialize();

                if (encodingInfo is not null)
                {
                    foreach (var symbol in encodingInfo.Symbols.Values)
                    {
                        symbol.Initialize(instruction.BitRangeMap);
                    }
                }

                if (multiInstructionSymbol is not null)
                {
                    var encodingInfoForVariation = encodingInfo!.Clone();
                    bool isSelectorChanged = false;
                    foreach (var symbol in encodingInfoForVariation.Symbols.Values)
                    {
                        var selector = symbol.Selector;
                        if (symbol.Link != multiInstructionSymbol && selector is not null && selector.BitNames.Contains(bitEncodingNameVariation!))
                        {
                            for (var i = selector.BitValues.Count - 1; i >= 0; i--)
                            {
                                var bitValue = selector.BitValues[i];
                                // We remove in the selector values that don't match the current variation
                                if ((bitValue.BitSelectorMask & checkMask) != 0 && (bitValue.BitSelectorValue & checkMask) != checkValue)
                                {
                                    selector.BitValues.RemoveAt(i);
                                    isSelectorChanged = true;
                                }
                            }
                        }
                    }

                    if (isSelectorChanged)
                    {
                        encodingInfo = encodingInfoForVariation;
                    }
                }

                var operands = ParseOperands(encoding, encodingInfo);
                instruction.Operands.AddRange(operands);
                instruction.UpdateSignatureFromOperands();
                _instructions.Add(instruction);

                if (!process2ndInstructionVariation && multiInstructionSymbol is not null)
                {
                    process2ndInstructionVariation = true;
                    goto add_instruction_variation;
                }
            }
        }
    }

    private void PatchInstructionWithPostFix(Instruction instruction, string postFix)
    {
        // Add a post fix (2) to the instruction id / mnemonic if we have a variation
        if (!string.IsNullOrEmpty(postFix))
        {
            var indexOfUnderscore = instruction.Id.IndexOf('_');
            instruction.Id = $"{instruction.Id.Substring(0, indexOfUnderscore)}{postFix}{instruction.Id.Substring(indexOfUnderscore)}";
            instruction.Mnemonic += postFix;
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
                //    Console.WriteLine($"  {instruction} - Discarded: {instruction.IsDiscardedByPreferredAlias}, Dynamic Resolution: {instruction.HasAliasesInAndRequiringDynamicResolution}");
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

        var nonBits = new List<byte>();

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
                        fieldSetsList.Add(BitKind.NotSet);
                        break;
                    case 'Z':
                        nonBits.Add(0);
                        fieldSetsList.Add(BitKind.NotSet);
                        break;
                    case 'N':
                        nonBits.Add(1);
                        fieldSetsList.Add(BitKind.NotSet);
                        break;
                    default:
                        throw new InvalidOperationException($"Invalid bit value {value}");
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

        if (nonBits.Count > 0)
        {
            info.OriginalCondition = $"!= {string.Concat(nonBits)}";
            if (nonBits.All(x => x == 1))
            {
                info.Condition = BitRangeCondition.AllNonOne;
            }
            else if (nonBits.Count == 3)
            {
                Debug.Assert(nonBits[0] == 0);
                Debug.Assert(nonBits[1] == 1);
                Debug.Assert(nonBits[2] == 1);
                info.Condition = BitRangeCondition.AllNon011;

            }
            else if (nonBits.Count == 6)
            {
                Debug.Assert(nonBits[0] == 0);
                Debug.Assert(nonBits[1] == 1);
                Debug.Assert(nonBits[2] == 1);
                Debug.Assert(nonBits[3] == 1);
                Debug.Assert(nonBits[4] == 1);
                Debug.Assert(nonBits[5] == 1);
                info.Condition = BitRangeCondition.AllNon011111;
            }
            else
            {
                throw new InvalidOperationException($"Invalid non-bits value {string.Join(", ", nonBits)}");
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