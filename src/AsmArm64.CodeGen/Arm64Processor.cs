// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AsmArm64.CodeGen;

// Feature
// Docvars ideas
// https://github.com/google/EXEgesis/blob/master/exegesis/arm/xml/docvars.cc

public partial class Arm64Processor
{
    private readonly string _baseSpecsFolder;
    private readonly string _basedOutputFolder;

    private readonly List<Instruction> _instructions;
    private readonly Dictionary<string, string> _archVariantNameToArchitectureId = new();
    private readonly List<string> _features = new();
    private readonly List<ArchVariant> _featureExpressions = new();

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
            throw new ArgumentException($"Specs folder `{_baseSpecsFolder}` doesn't exist");
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

        BuildTree();

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


        GenerateCode();
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
    
    private void BuildTree()
    {
        // Sort instructions by normalized name
        _instructions.Sort((left, right) => string.Compare(left.NormalizedName, right.NormalizedName, CultureInfo.InvariantCulture, CompareOptions.Ordinal));
        var decoder = new InstructionDecoder(0);
        for(int i = 0; i < _instructions.Count; i++)
        {
            decoder.InstructionIndices.Add(i);
        }
        decoder.Build(_instructions);

        //Console.WriteLine("--------------------------------");
        //Console.WriteLine("Level 0-2");
        //Console.WriteLine("--------------------------------");
        //decoder.Print(_instructions, 0, 3);

        //Console.WriteLine("--------------------------------");
        //Console.WriteLine("All Levels");
        //Console.WriteLine("--------------------------------");

        using var writer = new StreamWriter("decoder.txt");
        decoder.Print(writer, _instructions);
    }

    private static string BinaryMask(uint value)
    {
        var builder = new StringBuilder();
        for (var i = 0; i < 32; i++)
        {
            builder.Append((value & (1 << (31 - i))) != 0 ? '0' : '1');
        }
        return builder.ToString();
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
        
        var bitFields = new List<BitfieldInfo>();
        var encodingBitFields = new List<BitfieldInfo>();
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
    
    private void ProcessBitFields(XElement elt, List<BitfieldInfo> bitFields)
    {
        var boxes = elt.Descendants("box");
        foreach (var box in boxes)
        {
            var bitFieldInfo = ConvertToBitFieldInfo(box);
            bitFields.Add(bitFieldInfo);
        }
    }

    private static BitfieldInfo ConvertToBitFieldInfo(XElement elt)
    {
        var name = elt.Attribute("name")?.Value;
        var hiBit = int.Parse(elt.Attribute("hibit")!.Value!);
        var width = int.Parse(elt.Attribute("width")?.Value ?? "1");

        var info = new BitfieldInfo
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

    private class Instruction
    {
        public string Filename { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string NormalizedName { get; set; } = string.Empty;

        public string Mnemonic { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string InstructionClass { get; set; } = string.Empty;

        public uint BitfieldMask { get; set; }

        public uint BitfieldValue { get; set; }

        public List<ArchVariant> ArchVariants { get; } = new();

        public List<BitfieldInfo> BitFields { get; } = new();


        public void Add(BitfieldInfo bitfieldInfo)
        {
            var existingField = BitFields.FirstOrDefault(x => x.HiBit == bitfieldInfo.HiBit && x.Width == bitfieldInfo.Width);

            if (existingField != null)
            {
                Debug.Assert(existingField.FieldSets!.Count == bitfieldInfo.FieldSets.Count);
                
                for (var i = 0; i < bitfieldInfo.FieldSets.Count; i++)
                {
                    if (bitfieldInfo.FieldSets![i] != BitKind.NotSet)
                    {
                        existingField.FieldSets[i] = bitfieldInfo.FieldSets[i];
                    }
                }
            }
            else
            {
                BitFields.Add(bitfieldInfo.Clone());
            }
        }

        public void Build()
        {
            var name = Name.TrimEnd('_');
            var indexOfUnderscore = name.IndexOf('_');
            NormalizedName = indexOfUnderscore > 0 ? $"{name.Substring(0, indexOfUnderscore).ToUpperInvariant()}{name.Substring(indexOfUnderscore).ToLowerInvariant()}" : name.ToUpperInvariant();

            //for (var i = 0; i < BitFields.Count; i++)
            //{
            //    var bitField = BitFields[i];
            //    if (bitField.Width <= 2 && (bitField.Name == "sz" || bitField.Name == "S" || bitField.Name == "size"))
            //    {
            //        for (int j = 0; j < bitField.Width; j++)
            //        {
            //            if (bitField.FieldSets[j] == BitKind.NotSet)
            //            {
            //                bitField.FieldSets[j] = BitKind.Any;
            //            }
            //        }
            //    }
            //    else if (bitField.Name is not null && bitField.Name.StartsWith("imm") && bitField.FieldSets.All(x => x == BitKind.NotSet) && bitField.Width <= 5)
            //    {
            //        //Console.WriteLine($"Check bit field {bitField} for instruction {Name}");
            //    }
            //}

            foreach (var bitfieldInfo in BitFields)
            {
                var fieldSets = bitfieldInfo.FieldSets;

                var mask = 0u;
                var value = 0u;
                for (var i = 0; i < fieldSets.Count; i++)
                {
                    mask <<= 1;
                    value <<= 1;
                    var bitKind = fieldSets[i];
                    if (bitKind == BitKind.NotSet)
                    {
                        continue;
                    }

                    mask |= 1;
                    if (bitKind == BitKind.One)
                    {
                        value |= 1;
                    }
                }

                BitfieldMask |= mask << (bitfieldInfo.HiBit - (bitfieldInfo.Width - 1));
                BitfieldValue |= value << (bitfieldInfo.HiBit - (bitfieldInfo.Width - 1));
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"{Name,-32} {Mnemonic,-12} Mask: 0x{BitfieldMask:X8} Bits: 0x{BitfieldValue:X8}");

            foreach (var bitField in BitFields)
            {
                if ((BitfieldMask & (1 << bitField.HiBit)) != 0)
                {
                    continue;
                }

                builder.Append($" {bitField.Name} ({bitField.HiBit}: {bitField.Width})");
            }

            builder.Append($" (Filename: {Filename})");

            return builder.ToString();
        }
    }


    private class BitfieldInfo
    {
        public string? Name { get; init; }

        public int HiBit { get; init; }

        public int Width { get; init; }

        public List<BitKind> FieldSets { get; } = new();

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"{Name,-8} {HiBit,-2} {Width,-2} ");

            foreach (var fieldSet in FieldSets)
            {
                builder.Append(fieldSet switch
                {
                    BitKind.Zero => "0",
                    BitKind.One => "1",
                    BitKind.NotSet => "x",
                    _ => throw new ArgumentOutOfRangeException()
                });
            }
            return builder.ToString();
        }

        public BitfieldInfo Clone()
        {
            var clone = new BitfieldInfo
            {
                Name = Name,
                HiBit = HiBit,
                Width = Width
            };
            clone.FieldSets.AddRange(FieldSets);
            return clone;
        }
    }

    private class InstructionDecoder
    {
        public InstructionDecoder(int shift)
        {
            Shift = shift;
            MaskToSubDecoder = new();
            InstructionIndices = new();
        }

        public int? Key;
        
        public int Shift;

        public int BitMaskCount;

        public readonly Dictionary<int, InstructionDecoder> MaskToSubDecoder;

        public InstructionDecoder? ElseBranch;

        public readonly List<int> InstructionIndices;

        public bool IsElseBranch;

        public bool IsTerminal => MaskToSubDecoder.Count == 0;

        public void Build(List<Instruction> instructions, int level = 0)
        {
            if (InstructionIndices.Count == 1) return;

            int minimumShift = int.MaxValue;
            int countCountLeading1 = 0;
            
            foreach (var instructionIndex in InstructionIndices)
            {
                var instruction = instructions[instructionIndex];
                var instructionMask = instruction.BitfieldMask << Shift;
                var countLeading0 = BitOperations.LeadingZeroCount(instructionMask);
                var countLeading1 = BitOperations.LeadingZeroCount(~instructionMask);

                if (countLeading1 > 0)
                {
                    countCountLeading1++;
                }

                if (countLeading0 < minimumShift)
                {
                    minimumShift = countLeading0;
                }
            }

            if (countCountLeading1 == 0)
            {
                Debug.Assert(minimumShift > 0);
                Shift += minimumShift;
            }
            
            (HashSet<uint>? CountPerMask, int Count)[] instCountPerFront1 = new (HashSet<uint>?, int)[33];
            foreach (var instructionIndex in InstructionIndices)
            {
                var instruction = instructions[instructionIndex];
                var instructionMask = instruction.BitfieldMask << Shift;

                var countLeading1 = BitOperations.LeadingZeroCount(~instructionMask);
                //count1 = Math.Min(count1, 8);
                for (int i = 1; i <= countLeading1; i++)
                {
                    var instructionValue = (instruction.BitfieldValue << Shift) >> (32 - i);
                    var pair = instCountPerFront1[i];
                    if (pair.CountPerMask == null)
                    {
                        pair.CountPerMask = new HashSet<uint>();
                        instCountPerFront1[i] = (pair.CountPerMask, 0);
                    }
                    pair.CountPerMask.Add(instructionValue);
                    instCountPerFront1[i] = (pair.CountPerMask, pair.Count + 1);
                }
            }

            int maximumPerMaskCount = 0;
            int bestCountLeading1 = 0;
            for (var i = 32; i >= 1; i--)
            {
                var hashSet = instCountPerFront1[i];
                if (hashSet.CountPerMask is not null && hashSet.CountPerMask.Count > maximumPerMaskCount) // >= to prefer to have more bits
                {
                    maximumPerMaskCount = hashSet.CountPerMask.Count;
                    bestCountLeading1 = i;
                }
            }

            BitMaskCount = bestCountLeading1;
            
            if (bestCountLeading1 == 0)
            {
                return;
            }

            //Console.WriteLine($"{new string(' ', level * 2)} Decoder Shift = {Shift}, BitMaskCount = {BitMaskCount}, Other: {IsOtherDecoder}");

            //Console.WriteLine($"{new string(' ', level * 2)} Decoder Shift = {Shift}, DecoderMask = {buildMask}");

            //for (var i = 0; i < 32; i++)
            //{
            //    var hashSet = instCountPerFront1[i];
            //    if (hashSet.CountPerMask is not null && hashSet.Count > 0)
            //    {
            //        Console.WriteLine($"{new string(' ', level * 2)} [{i}] CountPerMask = {hashSet.CountPerMask.Count}, Total = {hashSet.Count}");
            //    }
            //}

            foreach (var instructionIndex in InstructionIndices)
            {
                var instruction = instructions[instructionIndex];
                var subMask = instruction.BitfieldMask << Shift;

                var countLeading1 = BitOperations.LeadingZeroCount(~subMask);
                if (countLeading1 >= bestCountLeading1)
                {
                    var localSubIndex = (int)((instruction.BitfieldValue << Shift) >> (32 - bestCountLeading1));

                    if (!MaskToSubDecoder.TryGetValue(localSubIndex, out var subDecoder))
                    {
                        subDecoder ??= new InstructionDecoder(Shift + bestCountLeading1)
                        {
                            Key = localSubIndex
                        };
                        MaskToSubDecoder.Add(localSubIndex, subDecoder);
                    }

                    if (!subDecoder.InstructionIndices.Contains(instructionIndex))
                    {
                        subDecoder.InstructionIndices.Add(instructionIndex);
                    }
                }
                else
                {
                    ElseBranch ??= new InstructionDecoder(Shift) { IsElseBranch = true };
                    if (!ElseBranch.InstructionIndices.Contains(instructionIndex))
                    {
                        ElseBranch.InstructionIndices.Add(instructionIndex);
                    }
                }
            }

            if (ElseBranch is not null)
            {
                ElseBranch.Build(instructions, level + 1);
            }

            foreach (var subDecoder in MaskToSubDecoder.Values)
            {
                subDecoder.Build(instructions, level + 1);
            }

            if (IsTerminal && InstructionIndices.Count != 1)
            {
                Console.WriteLine($"Error with decoder. Invalid number of final instructions expecting only 1: {this}");
            }
        }

        public void Print(TextWriter writer, List<Instruction> instructions, int level = 0)
        {
            var builder = new StringBuilder();
            builder.Append($"{new string(' ', level * 2)}[{level}] Shift: {Shift}, BitMaskCount: {BitMaskCount}, Instructions: {InstructionIndices.Count}");

            if (MaskToSubDecoder.Count > 0)
            {
                builder.Append($", Sub-Key Count: {MaskToSubDecoder.Count}");
            }
            
            if (Key.HasValue)
            {
                builder.Append($", Key: {Key.Value}");
            }

            if (IsElseBranch)
            {
                builder.Append($", ElseBranch: true");
            }

            if (MaskToSubDecoder.Count == 0)
            {
                if (InstructionIndices.Count > 1)
                {
                    builder.AppendLine($", Invalid-Multi: true");
                }
                else
                {
                    builder.AppendLine();

                }

                foreach (var instructionIndex in InstructionIndices)
                {
                    builder.AppendLine($"{new string(' ', level * 2)}  Instr: {instructions[instructionIndex]}");
                }
            }
            else
            {
                builder.AppendLine();
            }

            writer.Write(builder.ToString());

            var values = MaskToSubDecoder.Values.ToHashSet().ToList();
            values.Sort((a, b) => (a.Key ?? 0).CompareTo(b.Key ?? 0));

            foreach (var decoder in values)
            {
                decoder.Print(writer, instructions, level + 1);
            }

            if (ElseBranch is not null)
            {
                ElseBranch.Print(writer, instructions, level);
            }

        }
    }

    private record ArchVariant(string FeatureExpressionId, string FeatureExpression, string Name);

    private enum BitKind : byte
    {
        NotSet,
        Zero,
        One,
    }
}