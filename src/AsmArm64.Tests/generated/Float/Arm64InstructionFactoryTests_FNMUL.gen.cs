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
public class Arm64InstructionFactoryTests_FNMUL_Float
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMUL_h_floatdp2_0()
    {
        
        {
            var raw = FNMUL(H0, H1, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H0, H1, H2", asm);
        }
        
        {
            var raw = FNMUL(H31, H1, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H31, H1, H2", asm);
        }
        
        {
            var raw = FNMUL(H0, H31, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H0, H31, H2", asm);
        }
        
        {
            var raw = FNMUL(H31, H31, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H31, H31, H2", asm);
        }
        
        {
            var raw = FNMUL(H0, H1, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H0, H1, H31", asm);
        }
        
        {
            var raw = FNMUL(H31, H1, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H31, H1, H31", asm);
        }
        
        {
            var raw = FNMUL(H0, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H0, H31, H31", asm);
        }
        
        {
            var raw = FNMUL(H31, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_h_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL H31, H31, H31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMUL_s_floatdp2_1()
    {
        
        {
            var raw = FNMUL(S0, S1, S2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S0, S1, S2", asm);
        }
        
        {
            var raw = FNMUL(S31, S1, S2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S31, S1, S2", asm);
        }
        
        {
            var raw = FNMUL(S0, S31, S2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S0, S31, S2", asm);
        }
        
        {
            var raw = FNMUL(S31, S31, S2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S31, S31, S2", asm);
        }
        
        {
            var raw = FNMUL(S0, S1, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S0, S1, S31", asm);
        }
        
        {
            var raw = FNMUL(S31, S1, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S31, S1, S31", asm);
        }
        
        {
            var raw = FNMUL(S0, S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S0, S31, S31", asm);
        }
        
        {
            var raw = FNMUL(S31, S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_s_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL S31, S31, S31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMUL_d_floatdp2_2()
    {
        
        {
            var raw = FNMUL(D0, D1, D2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D0, D1, D2", asm);
        }
        
        {
            var raw = FNMUL(D31, D1, D2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D31, D1, D2", asm);
        }
        
        {
            var raw = FNMUL(D0, D31, D2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D0, D31, D2", asm);
        }
        
        {
            var raw = FNMUL(D31, D31, D2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D31, D31, D2", asm);
        }
        
        {
            var raw = FNMUL(D0, D1, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D0, D1, D31", asm);
        }
        
        {
            var raw = FNMUL(D31, D1, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D31, D1, D31", asm);
        }
        
        {
            var raw = FNMUL(D0, D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D0, D31, D31", asm);
        }
        
        {
            var raw = FNMUL(D31, D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMUL_d_floatdp2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMUL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMUL D31, D31, D31", asm);
        }
    }
}
