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
public class Arm64InstructionFactoryTests_FMLALLBT_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALLBT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALLBT_asimdelem_j_0()
    {
        
        {
            var raw = FMLALLBT(V0.T_4S, V1.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V1.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V1.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V1.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V0.T_4S, V31.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V31.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V31.T_16B, V2.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V31.16B, V2.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V0.T_4S, V1.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V1.16B, V0.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V1.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V1.16B, V0.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V0.T_4S, V31.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V31.16B, V0.B[1]", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V31.T_16B, V0.B[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdelem_j, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V31.16B, V0.B[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALLBT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALLBT_asimdsame2_g_1()
    {
        
        {
            var raw = FMLALLBT(V0.T_4S, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V0.T_4S, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V0.T_4S, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V0.T_4S, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V0.4S, V31.16B, V0.16B", asm);
        }
        
        {
            var raw = FMLALLBT(V30.T_4S, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FMLALLBT_asimdsame2_g, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FMLALLBT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FMLALLBT V30.4S, V31.16B, V0.16B", asm);
        }
    }
}
