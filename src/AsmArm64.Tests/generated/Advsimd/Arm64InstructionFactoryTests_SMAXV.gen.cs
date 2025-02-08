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
public class Arm64InstructionFactoryTests_SMAXV_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMAXV_asimdall_only_0()
    {
        
        {
            var raw = SMAXV(B1, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B1, V1.8B", asm);
        }
        
        {
            var raw = SMAXV(B31, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B31, V1.8B", asm);
        }
        
        {
            var raw = SMAXV(B1, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B1, V31.8B", asm);
        }
        
        {
            var raw = SMAXV(B31, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B31, V31.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMAXV_asimdall_only_1()
    {
        
        {
            var raw = SMAXV(B1, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B1, V1.16B", asm);
        }
        
        {
            var raw = SMAXV(B31, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B31, V1.16B", asm);
        }
        
        {
            var raw = SMAXV(B1, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B1, V31.16B", asm);
        }
        
        {
            var raw = SMAXV(B31, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV B31, V31.16B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMAXV_asimdall_only_2()
    {
        
        {
            var raw = SMAXV(H1, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H1, V1.4H", asm);
        }
        
        {
            var raw = SMAXV(H31, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H31, V1.4H", asm);
        }
        
        {
            var raw = SMAXV(H1, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H1, V31.4H", asm);
        }
        
        {
            var raw = SMAXV(H31, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H31, V31.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMAXV_asimdall_only_3()
    {
        
        {
            var raw = SMAXV(H1, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H1, V1.8H", asm);
        }
        
        {
            var raw = SMAXV(H31, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H31, V1.8H", asm);
        }
        
        {
            var raw = SMAXV(H1, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H1, V31.8H", asm);
        }
        
        {
            var raw = SMAXV(H31, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV H31, V31.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMAXV_asimdall_only_4()
    {
        
        {
            var raw = SMAXV(S1, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV S1, V1.4S", asm);
        }
        
        {
            var raw = SMAXV(S31, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV S31, V1.4S", asm);
        }
        
        {
            var raw = SMAXV(S1, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV S1, V31.4S", asm);
        }
        
        {
            var raw = SMAXV(S31, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMAXV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMAXV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMAXV S31, V31.4S", asm);
        }
    }
}
