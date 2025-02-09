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
public class Arm64InstructionFactoryTests_XAR_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.XAR"/>.
    /// </summary>
    [TestMethod]
    public void Test_XAR_vvv2_crypto3_imm6_0()
    {
        
        {
            var raw = XAR(V0.T_2D, V1.T_2D, V2.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V0.2D, V1.2D, V2.2D, #5", asm);
        }
        
        {
            var raw = XAR(V30.T_2D, V1.T_2D, V2.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V30.2D, V1.2D, V2.2D, #5", asm);
        }
        
        {
            var raw = XAR(V0.T_2D, V31.T_2D, V2.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V0.2D, V31.2D, V2.2D, #5", asm);
        }
        
        {
            var raw = XAR(V30.T_2D, V31.T_2D, V2.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V30.2D, V31.2D, V2.2D, #5", asm);
        }
        
        {
            var raw = XAR(V0.T_2D, V1.T_2D, V0.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V0.2D, V1.2D, V0.2D, #5", asm);
        }
        
        {
            var raw = XAR(V30.T_2D, V1.T_2D, V0.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V30.2D, V1.2D, V0.2D, #5", asm);
        }
        
        {
            var raw = XAR(V0.T_2D, V31.T_2D, V0.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V0.2D, V31.2D, V0.2D, #5", asm);
        }
        
        {
            var raw = XAR(V30.T_2D, V31.T_2D, V0.T_2D, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.XAR_vvv2_crypto3_imm6, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.XAR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("XAR V30.2D, V31.2D, V0.2D, #5", asm);
        }
    }
}
