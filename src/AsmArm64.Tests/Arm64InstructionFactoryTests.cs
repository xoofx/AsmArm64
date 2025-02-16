// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Runtime.Intrinsics.Arm;

namespace AsmArm64.Tests;

public class Arm64InstructionFactoryTests
{
    protected static void TestInst(uint rawInstruction, Arm64InstructionId expectedId, Arm64Mnemonic expectedMnemonic, string expected)
    {
        var instruction = Arm64Instruction.Decode(rawInstruction);
        var asm = instruction.ToString("H", null);
        Assert.AreEqual(expectedId, instruction.Id, $"Instruction Id not matching. Expected Asm: {expected}. Received Asm: {asm}");
        Assert.AreEqual(expectedMnemonic, instruction.Mnemonic);
        Assert.AreEqual(expected, asm);
    }
}