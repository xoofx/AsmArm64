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
public class Arm64InstructionFactoryTests_SADDLP_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDLP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDLP_asimdmisc_p_0()
    {
        
        {
            var raw = SADDLP(V0.T_4H, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.4H, V1.8B", asm);
        }
        
        {
            var raw = SADDLP(V30.T_4H, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.4H, V1.8B", asm);
        }
        
        {
            var raw = SADDLP(V0.T_4H, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.4H, V31.8B", asm);
        }
        
        {
            var raw = SADDLP(V30.T_4H, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.4H, V31.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDLP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDLP_asimdmisc_p_1()
    {
        
        {
            var raw = SADDLP(V0.T_8H, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.8H, V1.16B", asm);
        }
        
        {
            var raw = SADDLP(V30.T_8H, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.8H, V1.16B", asm);
        }
        
        {
            var raw = SADDLP(V0.T_8H, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.8H, V31.16B", asm);
        }
        
        {
            var raw = SADDLP(V30.T_8H, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.8H, V31.16B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDLP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDLP_asimdmisc_p_2()
    {
        
        {
            var raw = SADDLP(V0.T_2S, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.2S, V1.4H", asm);
        }
        
        {
            var raw = SADDLP(V30.T_2S, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.2S, V1.4H", asm);
        }
        
        {
            var raw = SADDLP(V0.T_2S, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.2S, V31.4H", asm);
        }
        
        {
            var raw = SADDLP(V30.T_2S, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.2S, V31.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDLP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDLP_asimdmisc_p_3()
    {
        
        {
            var raw = SADDLP(V0.T_4S, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.4S, V1.8H", asm);
        }
        
        {
            var raw = SADDLP(V30.T_4S, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.4S, V1.8H", asm);
        }
        
        {
            var raw = SADDLP(V0.T_4S, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.4S, V31.8H", asm);
        }
        
        {
            var raw = SADDLP(V30.T_4S, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.4S, V31.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDLP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDLP_asimdmisc_p_4()
    {
        
        {
            var raw = SADDLP(V0.T_1D, V1.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.1D, V1.2S", asm);
        }
        
        {
            var raw = SADDLP(V30.T_1D, V1.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.1D, V1.2S", asm);
        }
        
        {
            var raw = SADDLP(V0.T_1D, V31.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.1D, V31.2S", asm);
        }
        
        {
            var raw = SADDLP(V30.T_1D, V31.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.1D, V31.2S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDLP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDLP_asimdmisc_p_5()
    {
        
        {
            var raw = SADDLP(V0.T_2D, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.2D, V1.4S", asm);
        }
        
        {
            var raw = SADDLP(V30.T_2D, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.2D, V1.4S", asm);
        }
        
        {
            var raw = SADDLP(V0.T_2D, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V0.2D, V31.4S", asm);
        }
        
        {
            var raw = SADDLP(V30.T_2D, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SADDLP_asimdmisc_p, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SADDLP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SADDLP V30.2D, V31.4S", asm);
        }
    }
}
