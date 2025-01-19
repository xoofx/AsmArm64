// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Formats.Tar;
using System.Text.RegularExpressions;
using AsmArm64.CodeGen;

namespace AsmArm64.Tests.CodeGen;

public partial class McInstructionTestsGen
{
    private readonly Dictionary<string, List<TestInstruction>> _mapFileNameToTestInstructions = new();
    private readonly string _basedOutputTestFolder;

    public McInstructionTestsGen()
    {
        var basePath = Path.GetDirectoryName(AppContext.BaseDirectory); // src\AsmArm64.CodeGen\bin\Debug\net8.0
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen\bin\Debug
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen\bin
        basePath = Path.GetDirectoryName(basePath); // src\AsmArm64.CodeGen
        basePath = Path.GetDirectoryName(basePath); // src
        _basedOutputTestFolder = Path.Combine(basePath!, "AsmArm64.Tests");
        if (!Directory.Exists(_basedOutputTestFolder))
        {
            throw new ArgumentException($"Tests folder `{_basedOutputTestFolder}` doesn't exist");
        }
    }

    public int TestCount { get; private set; }


    public void ProcessFilesFromTar(string archiveFilePath)
    {
        using var stream = File.OpenRead(archiveFilePath);
        using var tarReader = new TarReader(stream, true);
        while (true)
        {
            var entry = tarReader.GetNextEntry();
            if (entry == null) break;
            if (entry.Name.Contains("/test/MC/AArch64/") && entry.EntryType == TarEntryType.RegularFile)
            {
                ProcessFile(entry.Name, entry.DataStream!);
            }
        }
    }

    public void GenerateTests()
    {
        var generatedFolder = Path.Combine(_basedOutputTestFolder, "generated", "llvm-mc");
        if (!Directory.Exists(generatedFolder))
        {
            Directory.CreateDirectory(generatedFolder);
        }

        foreach (var pair in _mapFileNameToTestInstructions)
        {
            var fileName = Path.Combine(generatedFolder, $"{pair.Key}.gen.cs");
            var testInstructions = pair.Value;

            using var w = GetWriter(fileName, isTest: true);

            w.WriteLine("using System;");
            w.WriteLine("namespace AsmArm64.Tests;");
            w.WriteLine();
            w.WriteLine("partial class McInstructionTests");
            w.OpenBraceBlock();
            {
                w.WriteLine("[TestMethod]");
                foreach (var encoding in testInstructions)
                {
                    w.WriteLine("[DataRow(new byte[] { " + string.Join(", ", encoding.Encoding.Split(',').Select(x => x.Trim())) + " }, \"" + encoding.Asm + "\")]");
                }
                w.WriteLine($"public void {pair.Key}(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);");
            }
            w.CloseBraceBlock();
        }
    }

    private void ProcessFile(string fileName, Stream stream)
    {
        // CHECK: adr x0, #0          // encoding: [0x00,0x00,0x00,0x10]

        // CHECK-INST: abs     x0, x0
        // CHECK-ENCODING: [0x00,0x20,0xc0,0xda]

        var normalizedName = RegexFileName().Match(fileName).Groups["name"].Value;
        normalizedName = RegexNonWords().Replace(normalizedName, "_");

        using var reader = new StreamReader(stream);
        string previousLine = string.Empty;
        while (true)
        {
            var line = reader.ReadLine();
            if (line == null) break;

            if ((line.StartsWith("// CHECK: ", StringComparison.Ordinal) || line.StartsWith("; CHECK: ")) && line.Contains("encoding: [", StringComparison.Ordinal))
            {
                var testInstruction = ProcessCheck(line, previousLine);
                if (testInstruction != null)
                {
                    AddTestInstruction(normalizedName, testInstruction);
                    TestCount++;
                }
            }
            else if (line.StartsWith("// CHECK-INST: ", StringComparison.Ordinal))
            {
                // TODO
            }
            else if (line.StartsWith("// CHECK-ENCODING: ", StringComparison.Ordinal))
            {
                // TODO
            }

            previousLine = line;
        }
    }

    private void AddTestInstruction(string name, TestInstruction testInstruction)
    {
        if (!_mapFileNameToTestInstructions.TryGetValue(name, out var list))
        {
            list = new();
            _mapFileNameToTestInstructions.Add(name, list);
        }
        list.Add(testInstruction);
    }


    private TestInstruction? ProcessCheck(string line, string previousLine)
    {
        // After "// CHECK: "
        var regex = RegexAsmEncoding();
        var match = regex.Match(line);
        if (!match.Success)
        {
            return null;
        }

        var asm = match.Groups["asm"].Value;
        if (string.IsNullOrWhiteSpace(asm))
        {
            asm = previousLine;
        }
        var encoding = match.Groups["encoding"].Value;

        var values = encoding.Split(',');
        bool isSupportedHexadecimal = values.All(x => x.StartsWith("0x"));

        if (!isSupportedHexadecimal)
        {
            return null;
        }

        asm = asm.Replace("//", string.Empty);
        asm = asm.Replace(";", string.Empty);
        asm = asm.Trim();
        asm = RegexSpaces().Replace(asm, " ");
        asm = asm.Replace("{ ", "{");
        asm = asm.Replace(" }", "}");

        var matchV = RegexVectorInstruction().Match(asm);
        if (matchV.Success)
        {
            var mnemonic = matchV.Groups["instruction"].Value;
            var vCount = matchV.Groups["vcount"].Value;
            var vType = matchV.Groups["vtype"].Value;
            var operands = matchV.Groups["operands"].Value;

            var regexVector = RegexVector();
            var newOperands = regexVector.Replace(operands, m =>
            {
                var indexAfterVector = m.Index + m.Length;
                if (indexAfterVector < operands.Length)
                {
                    var nc = operands[indexAfterVector];
                    if (nc == '[') // If there is a vector with an index, we put only the vType but not the vCount
                    {
                        return $"{m.Value}.{vType}";
                    }
                    else
                    {
                        return $"{m.Value}.{vCount}{vType}";
                    }
                }
                else
                {
                    return $"{m.Value}.{vCount}{vType}";
                }
            });

            var newAsm = $"{mnemonic} {newOperands}"; // Separate line to allow debugging before assigning it back to asm
            asm = newAsm;
        }

        if (asm.Contains("{{"))
        {
            // We don't support it yet
            return null;
        }

        //Console.WriteLine($"  {asm} => {string.Join(",", values)}");

        return new(asm, encoding);
    }

    private CodeWriter GetWriter(string filePath, bool isTest = false)
    {
        var sw = new StreamWriter(filePath);
        var w = new CodeWriter(sw);

        w.WriteLine(
            """
            // Copyright (c) Alexandre Mutel. All rights reserved.
            // Licensed under the BSD-Clause 2 license.
            // See license.txt file in the project root for full license information.
            // ------------------------------------------------------------------------------
            // This code was generated by AsmArm64.CodeGen.
            //     Changes to this file may cause incorrect behavior and will be lost if
            //     the code is regenerated.
            // ------------------------------------------------------------------------------
            // ReSharper disable All
            // ------------------------------------------------------------------------------

            """
        );

        return w;
    }

    [GeneratedRegex(@"CHECK:(?<asm>.*)encoding:\s*\[(?<encoding>[^\]]+)\]?")]
    private static partial Regex RegexAsmEncoding();

    [GeneratedRegex(@"\s+")]
    private static partial Regex RegexSpaces();
    
    [GeneratedRegex(@"^(?<instruction>\w+)\.(?<vcount>\d+)(?<vtype>\w)\s+(?<operands>.+)")]
    private static partial Regex RegexVectorInstruction();


    [GeneratedRegex(@"\b(?<vector>v\d+)\b")]
    private static partial Regex RegexVector();

    [GeneratedRegex(@"/test/MC/AArch64/(?<name>.*)")]
    private static partial Regex RegexFileName();


    [GeneratedRegex(@"\W+")]
    private static partial Regex RegexNonWords();
    
    private record TestInstruction(string Asm, string Encoding);


}