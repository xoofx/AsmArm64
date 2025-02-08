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
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FRINTI_Float
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_h_floatdp1_0()
    {
        
        {
            var raw = FRINTI(H0, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI H0, H1", asm);
        }
        
        {
            var raw = FRINTI(H31, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI H31, H1", asm);
        }
        
        {
            var raw = FRINTI(H0, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI H0, H31", asm);
        }
        
        {
            var raw = FRINTI(H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI H31, H31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_s_floatdp1_1()
    {
        
        {
            var raw = FRINTI(S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI S0, S1", asm);
        }
        
        {
            var raw = FRINTI(S31, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI S31, S1", asm);
        }
        
        {
            var raw = FRINTI(S0, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI S0, S31", asm);
        }
        
        {
            var raw = FRINTI(S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI S31, S31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_d_floatdp1_2()
    {
        
        {
            var raw = FRINTI(D0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI D0, D1", asm);
        }
        
        {
            var raw = FRINTI(D31, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI D31, D1", asm);
        }
        
        {
            var raw = FRINTI(D0, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI D0, D31", asm);
        }
        
        {
            var raw = FRINTI(D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTI_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTI, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTI D31, D31", asm);
        }
    }
}
