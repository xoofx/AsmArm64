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
public class Arm64InstructionFactoryTests_AND_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AND"/>.
    /// </summary>
    [TestMethod]
    public void Test_AND_asimdsame_only_0()
    {
        
        {
            var raw = AND(V0.T_8B, V1.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.8B, V1.8B, V2.8B", asm);
        }
        
        {
            var raw = AND(V30.T_8B, V1.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.8B, V1.8B, V2.8B", asm);
        }
        
        {
            var raw = AND(V0.T_8B, V31.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.8B, V31.8B, V2.8B", asm);
        }
        
        {
            var raw = AND(V30.T_8B, V31.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.8B, V31.8B, V2.8B", asm);
        }
        
        {
            var raw = AND(V0.T_8B, V1.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.8B, V1.8B, V0.8B", asm);
        }
        
        {
            var raw = AND(V30.T_8B, V1.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.8B, V1.8B, V0.8B", asm);
        }
        
        {
            var raw = AND(V0.T_8B, V31.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.8B, V31.8B, V0.8B", asm);
        }
        
        {
            var raw = AND(V30.T_8B, V31.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.8B, V31.8B, V0.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AND"/>.
    /// </summary>
    [TestMethod]
    public void Test_AND_asimdsame_only_1()
    {
        
        {
            var raw = AND(V0.T_16B, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.16B, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = AND(V30.T_16B, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.16B, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = AND(V0.T_16B, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.16B, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = AND(V30.T_16B, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.16B, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = AND(V0.T_16B, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.16B, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = AND(V30.T_16B, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.16B, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = AND(V0.T_16B, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V0.16B, V31.16B, V0.16B", asm);
        }
        
        {
            var raw = AND(V30.T_16B, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AND_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AND, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AND V30.16B, V31.16B, V0.16B", asm);
        }
    }
}
