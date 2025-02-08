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
public class Arm64InstructionFactoryTests_FRINTA_Float
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTA"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTA_h_floatdp1_0()
    {
        
        {
            var raw = FRINTA(H0, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA H0, H1", asm);
        }
        
        {
            var raw = FRINTA(H31, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA H31, H1", asm);
        }
        
        {
            var raw = FRINTA(H0, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA H0, H31", asm);
        }
        
        {
            var raw = FRINTA(H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_h_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA H31, H31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTA"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTA_s_floatdp1_1()
    {
        
        {
            var raw = FRINTA(S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA S0, S1", asm);
        }
        
        {
            var raw = FRINTA(S31, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA S31, S1", asm);
        }
        
        {
            var raw = FRINTA(S0, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA S0, S31", asm);
        }
        
        {
            var raw = FRINTA(S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_s_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA S31, S31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTA"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTA_d_floatdp1_2()
    {
        
        {
            var raw = FRINTA(D0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA D0, D1", asm);
        }
        
        {
            var raw = FRINTA(D31, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA D31, D1", asm);
        }
        
        {
            var raw = FRINTA(D0, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA D0, D31", asm);
        }
        
        {
            var raw = FRINTA(D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FRINTA_d_floatdp1, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FRINTA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FRINTA D31, D31", asm);
        }
    }
}
