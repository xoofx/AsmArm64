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
public class Arm64InstructionFactoryTests_CBHHI_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHHI"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHHI_16_regs_0()
    {
        
        {
            var raw = CBHHI(W0, W1, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI W0, W1, #32", asm);
        }
        
        {
            var raw = CBHHI(W15, W1, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI W15, W1, #32", asm);
        }
        
        {
            var raw = CBHHI(WZR, W1, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI WZR, W1, #32", asm);
        }
        
        {
            var raw = CBHHI(W0, W16, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI W0, W16, #32", asm);
        }
        
        {
            var raw = CBHHI(W15, W16, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI W15, W16, #32", asm);
        }
        
        {
            var raw = CBHHI(WZR, W16, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI WZR, W16, #32", asm);
        }
        
        {
            var raw = CBHHI(W0, WZR, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI W0, WZR, #32", asm);
        }
        
        {
            var raw = CBHHI(W15, WZR, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI W15, WZR, #32", asm);
        }
        
        {
            var raw = CBHHI(WZR, WZR, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CBHHI_16_regs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CBHHI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CBHHI WZR, WZR, #32", asm);
        }
    }
}
