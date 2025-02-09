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
public class Arm64InstructionFactoryTests_SUDOT_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SUDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SUDOT_asimdelem_d_0()
    {
        
        {
            var raw = SUDOT(V0.T_2S, V1.T_8B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.2S, V1.8B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_2S, V1.T_8B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.2S, V1.8B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V0.T_2S, V31.T_8B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.2S, V31.8B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_2S, V31.T_8B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.2S, V31.8B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V0.T_2S, V1.T_8B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.2S, V1.8B, V0.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_2S, V1.T_8B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.2S, V1.8B, V0.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V0.T_2S, V31.T_8B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.2S, V31.8B, V0.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_2S, V31.T_8B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.2S, V31.8B, V0.4B[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SUDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SUDOT_asimdelem_d_1()
    {
        
        {
            var raw = SUDOT(V0.T_4S, V1.T_16B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.4S, V1.16B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_4S, V1.T_16B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.4S, V1.16B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V0.T_4S, V31.T_16B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.4S, V31.16B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_4S, V31.T_16B, V2.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.4S, V31.16B, V2.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V0.T_4S, V1.T_16B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.4S, V1.16B, V0.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_4S, V1.T_16B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.4S, V1.16B, V0.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V0.T_4S, V31.T_16B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V0.4S, V31.16B, V0.4B[1]", asm);
        }
        
        {
            var raw = SUDOT(V30.T_4S, V31.T_16B, V0.T_4B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUDOT_asimdelem_d, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUDOT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUDOT V30.4S, V31.16B, V0.4B[1]", asm);
        }
    }
}
