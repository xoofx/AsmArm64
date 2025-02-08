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
public class Arm64InstructionFactoryTests_FMIN_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_asimdsamefp16_only_0()
    {
        
        {
            var raw = FMIN(V0.T_4H, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4H, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = FMIN(V30.T_4H, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4H, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = FMIN(V0.T_4H, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4H, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = FMIN(V30.T_4H, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4H, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = FMIN(V0.T_4H, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4H, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = FMIN(V30.T_4H, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4H, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = FMIN(V0.T_4H, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4H, V31.4H, V0.4H", asm);
        }
        
        {
            var raw = FMIN(V30.T_4H, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4H, V31.4H, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_asimdsamefp16_only_1()
    {
        
        {
            var raw = FMIN(V0.T_8H, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.8H, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = FMIN(V30.T_8H, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.8H, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = FMIN(V0.T_8H, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.8H, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = FMIN(V30.T_8H, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.8H, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = FMIN(V0.T_8H, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.8H, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = FMIN(V30.T_8H, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.8H, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = FMIN(V0.T_8H, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.8H, V31.8H, V0.8H", asm);
        }
        
        {
            var raw = FMIN(V30.T_8H, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.8H, V31.8H, V0.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_asimdsame_only_2()
    {
        
        {
            var raw = FMIN(V0.T_2S, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2S, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = FMIN(V30.T_2S, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2S, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = FMIN(V0.T_2S, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2S, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = FMIN(V30.T_2S, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2S, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = FMIN(V0.T_2S, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2S, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = FMIN(V30.T_2S, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2S, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = FMIN(V0.T_2S, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2S, V31.2S, V0.2S", asm);
        }
        
        {
            var raw = FMIN(V30.T_2S, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2S, V31.2S, V0.2S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_asimdsame_only_3()
    {
        
        {
            var raw = FMIN(V0.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = FMIN(V30.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = FMIN(V0.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = FMIN(V30.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = FMIN(V0.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = FMIN(V30.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = FMIN(V0.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.4S, V31.4S, V0.4S", asm);
        }
        
        {
            var raw = FMIN(V30.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.4S, V31.4S, V0.4S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_asimdsame_only_4()
    {
        
        {
            var raw = FMIN(V0.T_2D, V1.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2D, V1.2D, V2.2D", asm);
        }
        
        {
            var raw = FMIN(V30.T_2D, V1.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2D, V1.2D, V2.2D", asm);
        }
        
        {
            var raw = FMIN(V0.T_2D, V31.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2D, V31.2D, V2.2D", asm);
        }
        
        {
            var raw = FMIN(V30.T_2D, V31.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2D, V31.2D, V2.2D", asm);
        }
        
        {
            var raw = FMIN(V0.T_2D, V1.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2D, V1.2D, V0.2D", asm);
        }
        
        {
            var raw = FMIN(V30.T_2D, V1.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2D, V1.2D, V0.2D", asm);
        }
        
        {
            var raw = FMIN(V0.T_2D, V31.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V0.2D, V31.2D, V0.2D", asm);
        }
        
        {
            var raw = FMIN(V30.T_2D, V31.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMIN_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMIN V30.2D, V31.2D, V0.2D", asm);
        }
    }
}
