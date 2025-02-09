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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_SHLL_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHLL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHLL_asimdmisc_s_0()
    {
        
        {
            var raw = SHLL(V0.T_8H, V1.T_8B, 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V0.8H, V1.8B, #8", asm);
        }
        
        {
            var raw = SHLL(V30.T_8H, V1.T_8B, 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V30.8H, V1.8B, #8", asm);
        }
        
        {
            var raw = SHLL(V0.T_8H, V31.T_8B, 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V0.8H, V31.8B, #8", asm);
        }
        
        {
            var raw = SHLL(V30.T_8H, V31.T_8B, 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V30.8H, V31.8B, #8", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHLL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHLL_asimdmisc_s_1()
    {
        
        {
            var raw = SHLL(V0.T_4S, V1.T_4H, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V0.4S, V1.4H, #16", asm);
        }
        
        {
            var raw = SHLL(V30.T_4S, V1.T_4H, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V30.4S, V1.4H, #16", asm);
        }
        
        {
            var raw = SHLL(V0.T_4S, V31.T_4H, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V0.4S, V31.4H, #16", asm);
        }
        
        {
            var raw = SHLL(V30.T_4S, V31.T_4H, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V30.4S, V31.4H, #16", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHLL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHLL_asimdmisc_s_2()
    {
        
        {
            var raw = SHLL(V0.T_2D, V1.T_2S, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V0.2D, V1.2S, #32", asm);
        }
        
        {
            var raw = SHLL(V30.T_2D, V1.T_2S, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V30.2D, V1.2S, #32", asm);
        }
        
        {
            var raw = SHLL(V0.T_2D, V31.T_2S, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V0.2D, V31.2S, #32", asm);
        }
        
        {
            var raw = SHLL(V30.T_2D, V31.T_2S, 32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SHLL_asimdmisc_s, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SHLL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SHLL V30.2D, V31.2S, #32", asm);
        }
    }
}
