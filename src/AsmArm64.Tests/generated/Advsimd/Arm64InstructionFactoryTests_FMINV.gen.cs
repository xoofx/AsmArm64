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
public class Arm64InstructionFactoryTests_FMINV_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINV_asimdall_only_h_0()
    {
        
        {
            var raw = FMINV(H0, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H0, V1.4H", asm);
        }
        
        {
            var raw = FMINV(H31, V1.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H31, V1.4H", asm);
        }
        
        {
            var raw = FMINV(H0, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H0, V31.4H", asm);
        }
        
        {
            var raw = FMINV(H31, V31.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H31, V31.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINV_asimdall_only_h_1()
    {
        
        {
            var raw = FMINV(H0, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H0, V1.8H", asm);
        }
        
        {
            var raw = FMINV(H31, V1.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H31, V1.8H", asm);
        }
        
        {
            var raw = FMINV(H0, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H0, V31.8H", asm);
        }
        
        {
            var raw = FMINV(H31, V31.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV H31, V31.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINV_asimdall_only_sd_2()
    {
        
        {
            var raw = FMINV(S0, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_sd, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV S0, V1.4S", asm);
        }
        
        {
            var raw = FMINV(S31, V1.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_sd, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV S31, V1.4S", asm);
        }
        
        {
            var raw = FMINV(S0, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_sd, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV S0, V31.4S", asm);
        }
        
        {
            var raw = FMINV(S31, V31.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMINV_asimdall_only_sd, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMINV S31, V31.4S", asm);
        }
    }
}
