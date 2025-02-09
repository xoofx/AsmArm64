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
public class Arm64InstructionFactoryTests_SWPLB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPLB"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPLB_32_memop_0()
    {
        
        {
            var raw = SWPLB(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB W0, W1, [X3]", asm);
        }
        
        {
            var raw = SWPLB(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB W15, W1, [X3]", asm);
        }
        
        {
            var raw = SWPLB(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB WZR, W1, [X3]", asm);
        }
        
        {
            var raw = SWPLB(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB W0, W16, [X3]", asm);
        }
        
        {
            var raw = SWPLB(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB W15, W16, [X3]", asm);
        }
        
        {
            var raw = SWPLB(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB WZR, W16, [X3]", asm);
        }
        
        {
            var raw = SWPLB(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB W0, WZR, [X3]", asm);
        }
        
        {
            var raw = SWPLB(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB W15, WZR, [X3]", asm);
        }
        
        {
            var raw = SWPLB(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPLB WZR, WZR, [X3]", asm);
        }
    }
}
