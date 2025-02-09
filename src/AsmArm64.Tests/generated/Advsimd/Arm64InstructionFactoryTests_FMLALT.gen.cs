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
public class Arm64InstructionFactoryTests_FMLALT_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALT_asimdelem_h_0()
    {
        
        {
            var raw = FMLALT(V0.T_8H, V1.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V1.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V1.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V1.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V0.T_8H, V31.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V31.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V31.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V31.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V0.T_8H, V1.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V1.16B, V0.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V1.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V1.16B, V0.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V0.T_8H, V31.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V31.16B, V0.B[1]", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V31.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdelem_h, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V31.16B, V0.B[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALT_asimdsame2_j_1()
    {
        
        {
            var raw = FMLALT(V0.T_8H, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALT(V0.T_8H, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALT(V0.T_8H, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = FMLALT(V0.T_8H, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V0.8H, V31.16B, V0.16B", asm);
        }
        
        {
            var raw = FMLALT(V30.T_8H, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALT_asimdsame2_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALT V30.8H, V31.16B, V0.16B", asm);
        }
    }
}
