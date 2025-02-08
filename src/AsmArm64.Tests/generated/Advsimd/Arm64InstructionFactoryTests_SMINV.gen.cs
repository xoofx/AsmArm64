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
public class Arm64InstructionFactoryTests_SMINV_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMINV_asimdall_only_0()
    {
        
        {
            var raw = SMINV(B1, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B1, V1.8B", asm);
        }
        
        {
            var raw = SMINV(B31, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B31, V1.8B", asm);
        }
        
        {
            var raw = SMINV(B1, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B1, V31.8B", asm);
        }
        
        {
            var raw = SMINV(B31, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B31, V31.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMINV_asimdall_only_1()
    {
        
        {
            var raw = SMINV(B1, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B1, V1.16B", asm);
        }
        
        {
            var raw = SMINV(B31, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B31, V1.16B", asm);
        }
        
        {
            var raw = SMINV(B1, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B1, V31.16B", asm);
        }
        
        {
            var raw = SMINV(B31, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV B31, V31.16B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMINV_asimdall_only_2()
    {
        
        {
            var raw = SMINV(H1, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H1, V1.4H", asm);
        }
        
        {
            var raw = SMINV(H31, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H31, V1.4H", asm);
        }
        
        {
            var raw = SMINV(H1, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H1, V31.4H", asm);
        }
        
        {
            var raw = SMINV(H31, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H31, V31.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMINV_asimdall_only_3()
    {
        
        {
            var raw = SMINV(H1, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H1, V1.8H", asm);
        }
        
        {
            var raw = SMINV(H31, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H31, V1.8H", asm);
        }
        
        {
            var raw = SMINV(H1, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H1, V31.8H", asm);
        }
        
        {
            var raw = SMINV(H31, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV H31, V31.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMINV_asimdall_only_4()
    {
        
        {
            var raw = SMINV(S1, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV S1, V1.4S", asm);
        }
        
        {
            var raw = SMINV(S31, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV S31, V1.4S", asm);
        }
        
        {
            var raw = SMINV(S1, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV S1, V31.4S", asm);
        }
        
        {
            var raw = SMINV(S31, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMINV_asimdall_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMINV S31, V31.4S", asm);
        }
    }
}
