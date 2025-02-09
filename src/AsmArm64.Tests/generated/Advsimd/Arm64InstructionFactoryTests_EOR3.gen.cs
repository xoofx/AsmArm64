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
public class Arm64InstructionFactoryTests_EOR3_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EOR3"/>.
    /// </summary>
    [TestMethod]
    public void Test_EOR3_vvv16_crypto4_0()
    {
        
        {
            var raw = EOR3(V0.T_16B, V1.T_16B, V2.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V1.16B, V2.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V1.T_16B, V2.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V1.16B, V2.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V31.T_16B, V2.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V31.16B, V2.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V31.T_16B, V2.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V31.16B, V2.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V1.T_16B, V0.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V1.16B, V0.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V1.T_16B, V0.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V1.16B, V0.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V31.T_16B, V0.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V31.16B, V0.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V31.T_16B, V0.T_16B, V3.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V31.16B, V0.16B, V3.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V1.T_16B, V2.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V1.16B, V2.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V1.T_16B, V2.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V1.16B, V2.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V31.T_16B, V2.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V31.16B, V2.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V31.T_16B, V2.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V31.16B, V2.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V1.T_16B, V0.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V1.16B, V0.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V1.T_16B, V0.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V1.16B, V0.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V0.T_16B, V31.T_16B, V0.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V0.16B, V31.16B, V0.16B, V1.16B", asm);
        }
        
        {
            var raw = EOR3(V30.T_16B, V31.T_16B, V0.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR3_vvv16_crypto4, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR3, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR3 V30.16B, V31.16B, V0.16B, V1.16B", asm);
        }
    }
}
