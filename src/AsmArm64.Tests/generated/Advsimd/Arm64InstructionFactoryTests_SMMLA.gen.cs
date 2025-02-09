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
public class Arm64InstructionFactoryTests_SMMLA_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMMLA"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMMLA_asimdsame2_g_0()
    {
        
        {
            var raw = SMMLA(V0.T_4S, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V0.4S, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = SMMLA(V30.T_4S, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V30.4S, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = SMMLA(V0.T_4S, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V0.4S, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = SMMLA(V30.T_4S, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V30.4S, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = SMMLA(V0.T_4S, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V0.4S, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = SMMLA(V30.T_4S, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V30.4S, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = SMMLA(V0.T_4S, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V0.4S, V31.16B, V0.16B", asm);
        }
        
        {
            var raw = SMMLA(V30.T_4S, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMMLA_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMMLA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMMLA V30.4S, V31.16B, V0.16B", asm);
        }
    }
}
