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
public class Arm64InstructionFactoryTests_LDSMINB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMINB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMINB_32_memop_0()
    {
        
        {
            var raw = LDSMINB(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMINB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMINB W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMINB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMINB W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMINB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMINB WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMINB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMINB W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMINB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMINB W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDSMINB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDSMINB WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STSMINB_ldsminb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STSMINB W0, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STSMINB_ldsminb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STSMINB W15, [X3]", asm);
        }
        
        {
            var raw = LDSMINB(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STSMINB_ldsminb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STSMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STSMINB WZR, [X3]", asm);
        }
    }
}
