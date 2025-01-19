// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests.CodeGen;

internal class Program
{
    static void Main(string[] args)
    {
        var generator = new McInstructionTestsGen();

        generator.ProcessFilesFromTar(@"C:\code\AsmArm64\tmp\llvm-19.1.7.src.tar");
        generator.GenerateTests();
        Console.WriteLine($"Test Count = {generator.TestCount}");
    }
}