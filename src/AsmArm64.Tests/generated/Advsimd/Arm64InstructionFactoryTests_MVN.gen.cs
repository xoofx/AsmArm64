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
public class Arm64InstructionFactoryTests_MVN_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MVN"/>.
    /// </summary>
    [TestMethod]
    public void Test_MVN_not_asimdmisc_r_0()
    {
        
        {
            var raw = MVN(V0.T_8B, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V0.8B, V1.8B", asm);
        }
        
        {
            var raw = MVN(V30.T_8B, V1.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V30.8B, V1.8B", asm);
        }
        
        {
            var raw = MVN(V0.T_8B, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V0.8B, V31.8B", asm);
        }
        
        {
            var raw = MVN(V30.T_8B, V31.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V30.8B, V31.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MVN"/>.
    /// </summary>
    [TestMethod]
    public void Test_MVN_not_asimdmisc_r_1()
    {
        
        {
            var raw = MVN(V0.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V0.16B, V1.16B", asm);
        }
        
        {
            var raw = MVN(V30.T_16B, V1.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V30.16B, V1.16B", asm);
        }
        
        {
            var raw = MVN(V0.T_16B, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V0.16B, V31.16B", asm);
        }
        
        {
            var raw = MVN(V30.T_16B, V31.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_not_asimdmisc_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN V30.16B, V31.16B", asm);
        }
    }
}
