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
public class Arm64InstructionFactoryTests_BFDOT_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdelem_e_0()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdelem_e_1()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdsame2_d_2()
    {
        
        {
            var raw = BFDOT(V0.T_2S, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.2S, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_2S, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.2S, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = BFDOT(V0.T_2S, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.2S, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_2S, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.2S, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = BFDOT(V0.T_2S, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.2S, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_2S, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.2S, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = BFDOT(V0.T_2S, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.2S, V31.4H, V0.4H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_2S, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.2S, V31.4H, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdsame2_d_3()
    {
        
        {
            var raw = BFDOT(V0.T_4S, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.4S, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_4S, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.4S, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = BFDOT(V0.T_4S, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.4S, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_4S, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.4S, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = BFDOT(V0.T_4S, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.4S, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_4S, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.4S, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = BFDOT(V0.T_4S, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V0.4S, V31.8H, V0.8H", asm);
        }
        
        {
            var raw = BFDOT(V30.T_4S, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BFDOT_asimdsame2_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BFDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BFDOT V30.4S, V31.8H, V0.8H", asm);
        }
    }
}
