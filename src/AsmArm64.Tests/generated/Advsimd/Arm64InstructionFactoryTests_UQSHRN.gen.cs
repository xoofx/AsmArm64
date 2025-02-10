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
public class Arm64InstructionFactoryTests_UQSHRN_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asisdshf_n_0()
    {
        
        {
            var raw = UQSHRN(B1, H2, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN B1, H2, #5", asm);
        }
        
        {
            var raw = UQSHRN(B31, H2, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN B31, H2, #5", asm);
        }
        
        {
            var raw = UQSHRN(B1, H0, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN B1, H0, #5", asm);
        }
        
        {
            var raw = UQSHRN(B31, H0, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN B31, H0, #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asisdshf_n_1()
    {
        
        {
            var raw = UQSHRN(H1, S2, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN H1, S2, #5", asm);
        }
        
        {
            var raw = UQSHRN(H31, S2, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN H31, S2, #5", asm);
        }
        
        {
            var raw = UQSHRN(H1, S0, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN H1, S0, #5", asm);
        }
        
        {
            var raw = UQSHRN(H31, S0, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN H31, S0, #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asisdshf_n_2()
    {
        
        {
            var raw = UQSHRN(S1, D2, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN S1, D2, #5", asm);
        }
        
        {
            var raw = UQSHRN(S31, D2, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN S31, D2, #5", asm);
        }
        
        {
            var raw = UQSHRN(S1, D0, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN S1, D0, #5", asm);
        }
        
        {
            var raw = UQSHRN(S31, D0, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asisdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN S31, D0, #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asimdshf_n_3()
    {
        
        {
            var raw = UQSHRN(V0.T_8B, V1.T_8H, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V0.8B, V1.8H, #5", asm);
        }
        
        {
            var raw = UQSHRN(V30.T_8B, V1.T_8H, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V30.8B, V1.8H, #5", asm);
        }
        
        {
            var raw = UQSHRN(V0.T_8B, V31.T_8H, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V0.8B, V31.8H, #5", asm);
        }
        
        {
            var raw = UQSHRN(V30.T_8B, V31.T_8H, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V30.8B, V31.8H, #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asimdshf_n_4()
    {
        
        {
            var raw = UQSHRN(V0.T_4H, V1.T_4S, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V0.4H, V1.4S, #5", asm);
        }
        
        {
            var raw = UQSHRN(V30.T_4H, V1.T_4S, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V30.4H, V1.4S, #5", asm);
        }
        
        {
            var raw = UQSHRN(V0.T_4H, V31.T_4S, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V0.4H, V31.4S, #5", asm);
        }
        
        {
            var raw = UQSHRN(V30.T_4H, V31.T_4S, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V30.4H, V31.4S, #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asimdshf_n_5()
    {
        
        {
            var raw = UQSHRN(V0.T_2S, V1.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V0.2S, V1.2D, #5", asm);
        }
        
        {
            var raw = UQSHRN(V30.T_2S, V1.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V30.2S, V1.2D, #5", asm);
        }
        
        {
            var raw = UQSHRN(V0.T_2S, V31.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V0.2S, V31.2D, #5", asm);
        }
        
        {
            var raw = UQSHRN(V30.T_2S, V31.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.UQSHRN_asimdshf_n, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.UQSHRN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("UQSHRN V30.2S, V31.2D, #5", asm);
        }
    }
}
