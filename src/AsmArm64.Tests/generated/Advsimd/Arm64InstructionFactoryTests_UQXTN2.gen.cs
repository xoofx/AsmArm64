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
public class Arm64InstructionFactoryTests_UQXTN2_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQXTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQXTN2_asimdmisc_n_0()
    {
        
        {
            var raw = UQXTN2(V0.T_16B, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V0.16B, V1.8H", asm);
        }
        
        {
            var raw = UQXTN2(V30.T_16B, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V30.16B, V1.8H", asm);
        }
        
        {
            var raw = UQXTN2(V0.T_16B, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V0.16B, V31.8H", asm);
        }
        
        {
            var raw = UQXTN2(V30.T_16B, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V30.16B, V31.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQXTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQXTN2_asimdmisc_n_1()
    {
        
        {
            var raw = UQXTN2(V0.T_8H, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V0.8H, V1.4S", asm);
        }
        
        {
            var raw = UQXTN2(V30.T_8H, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V30.8H, V1.4S", asm);
        }
        
        {
            var raw = UQXTN2(V0.T_8H, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V0.8H, V31.4S", asm);
        }
        
        {
            var raw = UQXTN2(V30.T_8H, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V30.8H, V31.4S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQXTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQXTN2_asimdmisc_n_2()
    {
        
        {
            var raw = UQXTN2(V0.T_4S, V1.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V0.4S, V1.2D", asm);
        }
        
        {
            var raw = UQXTN2(V30.T_4S, V1.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V30.4S, V1.2D", asm);
        }
        
        {
            var raw = UQXTN2(V0.T_4S, V31.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V0.4S, V31.2D", asm);
        }
        
        {
            var raw = UQXTN2(V30.T_4S, V31.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQXTN2_asimdmisc_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQXTN2, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQXTN2 V30.4S, V31.2D", asm);
        }
    }
}
