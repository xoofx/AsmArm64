// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

[TestClass]
public class Class1Test
{
    [TestMethod]
    public void TestSimple()
    {
        int validInstructions = 0;
        for (ulong instruction = 0; instruction <= uint.MaxValue; instruction++)
        {
            //Console.WriteLine($"Processing instruction {instruction}");
            //Console.Out.Flush();
            var test = Arm64InstructionDecoderTable.Resolve((uint)instruction);
            if (test != Arm64InstructionId.Invalid)
            {
                validInstructions++;
            }
            //if (instruction % 1000000 == 0)
            //{
            //    Console.WriteLine($"Count: {instruction}");
            //    if (instruction > 10_000_000)
            //    {
            //        break;
            //    }
            //}
        }

        Console.WriteLine($"Valid instructions: {validInstructions}");
    }
}
