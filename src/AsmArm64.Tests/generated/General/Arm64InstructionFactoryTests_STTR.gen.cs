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
public class Arm64InstructionFactoryTests_STTR_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTR_32_ldst_unpriv_0()
    {
        
        {
            var raw = STTR(W0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STTR_32_ldst_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STTR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STTR W0, [X2, #5]", asm);
        }
        
        {
            var raw = STTR(W15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STTR_32_ldst_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STTR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STTR W15, [X2, #5]", asm);
        }
        
        {
            var raw = STTR(WZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STTR_32_ldst_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STTR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STTR WZR, [X2, #5]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTR_64_ldst_unpriv_1()
    {
        
        {
            var raw = STTR(X0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STTR_64_ldst_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STTR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STTR X0, [X2, #5]", asm);
        }
        
        {
            var raw = STTR(X15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STTR_64_ldst_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STTR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STTR X15, [X2, #5]", asm);
        }
        
        {
            var raw = STTR(XZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STTR_64_ldst_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STTR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STTR XZR, [X2, #5]", asm);
        }
    }
}
