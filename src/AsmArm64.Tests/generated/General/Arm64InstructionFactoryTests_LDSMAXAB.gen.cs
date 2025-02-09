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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_LDSMAXAB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMAXAB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMAXAB_32_memop_0()
    {
        
        {
            var raw = LDSMAXAB(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB W0, WZR, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB W15, WZR, [X3]", asm);
        }
        
        {
            var raw = LDSMAXAB(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMAXAB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMAXAB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMAXAB WZR, WZR, [X3]", asm);
        }
    }
}
