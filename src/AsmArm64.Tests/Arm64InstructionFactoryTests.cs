// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

public class Arm64InstructionFactoryTests
{
    protected static void TestInst(uint rawInstruction, Action<Arm64Assembler>? funcAsm, Arm64InstructionId expectedId, Arm64Mnemonic expectedMnemonic, string expected)
    {
        var instruction = Arm64Instruction.Decode(rawInstruction);
        var asm = instruction.ToString("H", null);
        Assert.AreEqual(expectedId, instruction.Id, $"Instruction Id not matching. Expected Asm: {expected}. Received Asm: {asm}");
        Assert.AreEqual(expectedMnemonic, instruction.Mnemonic);
        Assert.AreEqual(expected, asm);

        if (funcAsm is not null)
        {
            var instrList = new Arm64InstructionAccessorByList();
            var assembler = new Arm64Assembler(instrList);
            funcAsm(assembler);
            assembler.Assemble();
            Assert.AreEqual(1, instrList.Instructions.Count);
            Assert.AreEqual(rawInstruction, instrList.Instructions[0]);
        }
    }
}