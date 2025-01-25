// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Formats.Tar;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
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
        using var fileStream = File.OpenRead(archiveFilePath);
        using var gzStream = new GZipStream(fileStream, CompressionMode.Decompress);
        using var tarReader = new TarReader(gzStream, true);
        while (true)
        {
            var entry = tarReader.GetNextEntry();
            if (entry == null) break;
            if (entry.Name.Contains("/tests/MC/AArch64/") && entry.EntryType == TarEntryType.RegularFile && Path.GetExtension(entry.Name) == ".yaml")
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

    private static readonly string[] SkipTest =
    [
        "arm64_target_specific_sysreg_s",
        "ete_sysregs_s",
        "trace_regs_s"
    ];

    private void ProcessFile(string fileName, Stream stream)
    {
        var normalizedName = RegexFileName().Match(fileName).Groups["name"].Value;
        normalizedName = RegexNonWords().Replace(normalizedName, "_");
        if (normalizedName.EndsWith("_yaml"))
        {
            normalizedName = normalizedName.Substring(0, normalizedName.Length - "_yaml".Length);
        }

        // Don't process SME/SVE for now
        if (normalizedName.Contains("SME", StringComparison.Ordinal) || normalizedName.Contains("SVE", StringComparison.Ordinal))
        {
            return;
        }

        // The encoding of these system registers are not in the XML files, so skip them for now

        if (SkipTest.Any(x => normalizedName.Equals(x, StringComparison.OrdinalIgnoreCase)))
        {
            return;
        }
        
        SharpYaml.Serialization.Serializer serializer = new();
        var testCases = (List<object>)((Dictionary<object, object>)serializer.Deserialize(stream)!)["test_cases"];
        foreach (var testCase in testCases.OfType<Dictionary<object, object>>())
        {
            var input = (Dictionary<object, object>)(testCase["input"]);
            var bytes = ((List<object>)input["bytes"]).Select(x => (int)x).ToArray();
            var options = (List<object>)(input["options"]);

            var expected = (Dictionary<object, object>)(testCase["expected"]);
            var insns = (List<object>)expected["insns"];
            Debug.Assert(insns.Count == 1);
            var insn = (Dictionary<object, object>)insns[0];
            var asm = (string)insn["asm_text"];
            // options.Contains("specrestrict") ||
            if (options.Contains("v8r"))
            {
                continue;
            }

            asm = ReplaceWithBetterAsm(asm);

            AddTestInstruction(normalizedName, new(asm, string.Join(", ", bytes.Select(v => $"0x{v:x2}"))));
            TestCount++;
        }
    }

    /// <summary>
    /// Replaces some ASM text with better ones as per the XML specs.
    /// </summary>
    private string ReplaceWithBetterAsm(string asm)
    {
        if (asm.StartsWith("retaasppc x"))
        {
            asm = asm.Replace("retaasppc", "retaasppcr");
        }
        else if (asm.StartsWith("retabsppc x"))
        {
            asm = asm.Replace("retabsppc", "retabsppcr");
        }
        else if (asm.StartsWith("autiasppc x"))
        {
            asm = asm.Replace("autiasppc", "autiasppcr");
        }
        else if (asm.StartsWith("autibsppc x"))
        {
            asm = asm.Replace("autibsppc", "autibsppcr");
        }
        else if (asm.StartsWith("sshll ") && asm.EndsWith("#0"))
        {
            asm = asm.Replace("sshll", "sxtl");
            asm = asm.Replace(", #0", "");
        }
        else if (asm.StartsWith("sshll2 ") && asm.EndsWith("#0"))
        {
            asm = asm.Replace("sshll2", "sxtl2");
            asm = asm.Replace(", #0", "");
        }
        else if (asm.StartsWith("ushll ") && asm.EndsWith("#0"))
        {
            asm = asm.Replace("ushll", "uxtl");
            asm = asm.Replace(", #0", "");
        }
        else if (asm.StartsWith("ushll2 ") && asm.EndsWith("#0"))
        {
            asm = asm.Replace("ushll2", "uxtl2");
            asm = asm.Replace(", #0", "");
        }
        else if (asm.StartsWith("subps xzr, "))
        {
            asm = asm.Replace("subps xzr, ", "cmpp "); // preferred encoding
        }
        else if (asm == "msr S3_3_C13_C2_6, x0")
        {
            asm = "msr AMCG1IDR_EL0, x0"; // We have a proper encoding of this register
        }
        else if (asm == "tcancel #0x1234")
        {
            asm = "tcancel #4660"; // We don't encode in hex for the display
        }
        else if ((asm.StartsWith("dcps") || asm.StartsWith("smc")) && asm.Contains("#0x"))
        {
            asm = asm.Replace("#0x", "#"); // We don't encode in hex for the display
        }
        else if (asm == "ldrab x0, [x1, #0]!")
        {
            asm = "ldrab x0, [x1]!"; // The immediate is optional and we support it correctly
        }
        else if (asm == "ldraa x0, [x1, #0]!")
        {
            asm = "ldraa x0, [x1]!"; // The immediate is optional and we support it correctly
        }
        else if (asm == "gcsstr x26, x27")
        {
            asm = "gcsstr x26, [x27]"; // Not sure why, but we have the proper encoding, capstone looks not correct
        }
        else if (asm == "gcssttr x26, x27")
        {
            asm = "gcssttr x26, [x27]"; // Not sure why, but we have the proper encoding, capstone looks not correct
        }
        else if (asm == "gcsstr x26, sp")
        {
            asm = "gcsstr x26, [sp]"; // Not sure why, but we have the proper encoding, capstone looks not correct
        }
        else if (asm == "gcssttr x26, sp")
        {
            asm = "gcssttr x26, [sp]"; // Not sure why, but we have the proper encoding, capstone looks not correct
        }
        else if (asm == "add w4, w5, #0")
        {
            asm = "mov w4, w5"; // We have a better encoding
        }
        else if (asm.Contains("-6148914691236517206"))
        {
            asm = asm.Replace("-6148914691236517206", "0xaaaaaaaaaaaaaaaa"); // We encode in hex
        }

        return asm;
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

    [GeneratedRegex(@"/tests/MC/AArch64/(?<name>.*)")]
    private static partial Regex RegexFileName();


    [GeneratedRegex(@"\W+")]
    private static partial Regex RegexNonWords();

    private record TestInstruction(string Asm, string Encoding);
}