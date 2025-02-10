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
public class Arm64InstructionFactoryTests_LDRB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRB_32b_ldst_regoff_0()
    {
        
        {
            var raw = LDRB(W0, _[X2, X3, _LSL, 0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32bl_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W0, [X2, X3, LSL #0]", asm);
        }
        
        {
            var raw = LDRB(W15, _[X2, X3, _LSL, 0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32bl_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W15, [X2, X3, LSL #0]", asm);
        }
        
        {
            var raw = LDRB(WZR, _[X2, X3, _LSL, 0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32bl_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB WZR, [X2, X3, LSL #0]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRB_32b_ldst_regoff_1()
    {
        Assert.Inconclusive("Not handled LDRB_32b_ldst_regoff - LDRB        Wt, [Xn|SP, (Wm|Xm), extend{, amount}]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRB_32_ldst_immpost_2()
    {
        
        {
            var raw = LDRB(W0, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W0, [X2], #5", asm);
        }
        
        {
            var raw = LDRB(W15, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W15, [X2], #5", asm);
        }
        
        {
            var raw = LDRB(WZR, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB WZR, [X2], #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRB_32_ldst_immpre_3()
    {
        
        {
            var raw = LDRB(W0, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W0, [X2, #5]!", asm);
        }
        
        {
            var raw = LDRB(W15, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W15, [X2, #5]!", asm);
        }
        
        {
            var raw = LDRB(WZR, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB WZR, [X2, #5]!", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRB_32_ldst_pos_4()
    {
        
        {
            var raw = LDRB(W0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W0, [X2, #5]", asm);
        }
        
        {
            var raw = LDRB(W15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB W15, [X2, #5]", asm);
        }
        
        {
            var raw = LDRB(WZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDRB_32_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDRB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDRB WZR, [X2, #5]", asm);
        }
    }
}
