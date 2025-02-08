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
public class Arm64InstructionFactoryTests_FNMADD_Float
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMADD_h_floatdp3_0()
    {
        
        {
            var raw = FNMADD(H0, H1, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H1, H2, H3", asm);
        }
        
        {
            var raw = FNMADD(H31, H1, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H1, H2, H3", asm);
        }
        
        {
            var raw = FNMADD(H0, H31, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H31, H2, H3", asm);
        }
        
        {
            var raw = FNMADD(H31, H31, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H31, H2, H3", asm);
        }
        
        {
            var raw = FNMADD(H0, H1, H31, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H1, H31, H3", asm);
        }
        
        {
            var raw = FNMADD(H31, H1, H31, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H1, H31, H3", asm);
        }
        
        {
            var raw = FNMADD(H0, H31, H31, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H31, H31, H3", asm);
        }
        
        {
            var raw = FNMADD(H31, H31, H31, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H31, H31, H3", asm);
        }
        
        {
            var raw = FNMADD(H0, H1, H2, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H1, H2, H31", asm);
        }
        
        {
            var raw = FNMADD(H31, H1, H2, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H1, H2, H31", asm);
        }
        
        {
            var raw = FNMADD(H0, H31, H2, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H31, H2, H31", asm);
        }
        
        {
            var raw = FNMADD(H31, H31, H2, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H31, H2, H31", asm);
        }
        
        {
            var raw = FNMADD(H0, H1, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H1, H31, H31", asm);
        }
        
        {
            var raw = FNMADD(H31, H1, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H1, H31, H31", asm);
        }
        
        {
            var raw = FNMADD(H0, H31, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H0, H31, H31, H31", asm);
        }
        
        {
            var raw = FNMADD(H31, H31, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_h_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD H31, H31, H31, H31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMADD_s_floatdp3_1()
    {
        
        {
            var raw = FNMADD(S0, S1, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S1, S2, S3", asm);
        }
        
        {
            var raw = FNMADD(S31, S1, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S1, S2, S3", asm);
        }
        
        {
            var raw = FNMADD(S0, S31, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S31, S2, S3", asm);
        }
        
        {
            var raw = FNMADD(S31, S31, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S31, S2, S3", asm);
        }
        
        {
            var raw = FNMADD(S0, S1, S31, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S1, S31, S3", asm);
        }
        
        {
            var raw = FNMADD(S31, S1, S31, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S1, S31, S3", asm);
        }
        
        {
            var raw = FNMADD(S0, S31, S31, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S31, S31, S3", asm);
        }
        
        {
            var raw = FNMADD(S31, S31, S31, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S31, S31, S3", asm);
        }
        
        {
            var raw = FNMADD(S0, S1, S2, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S1, S2, S31", asm);
        }
        
        {
            var raw = FNMADD(S31, S1, S2, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S1, S2, S31", asm);
        }
        
        {
            var raw = FNMADD(S0, S31, S2, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S31, S2, S31", asm);
        }
        
        {
            var raw = FNMADD(S31, S31, S2, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S31, S2, S31", asm);
        }
        
        {
            var raw = FNMADD(S0, S1, S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S1, S31, S31", asm);
        }
        
        {
            var raw = FNMADD(S31, S1, S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S1, S31, S31", asm);
        }
        
        {
            var raw = FNMADD(S0, S31, S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S0, S31, S31, S31", asm);
        }
        
        {
            var raw = FNMADD(S31, S31, S31, S31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_s_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD S31, S31, S31, S31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMADD_d_floatdp3_2()
    {
        
        {
            var raw = FNMADD(D0, D1, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D1, D2, D3", asm);
        }
        
        {
            var raw = FNMADD(D31, D1, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D1, D2, D3", asm);
        }
        
        {
            var raw = FNMADD(D0, D31, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D31, D2, D3", asm);
        }
        
        {
            var raw = FNMADD(D31, D31, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D31, D2, D3", asm);
        }
        
        {
            var raw = FNMADD(D0, D1, D31, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D1, D31, D3", asm);
        }
        
        {
            var raw = FNMADD(D31, D1, D31, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D1, D31, D3", asm);
        }
        
        {
            var raw = FNMADD(D0, D31, D31, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D31, D31, D3", asm);
        }
        
        {
            var raw = FNMADD(D31, D31, D31, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D31, D31, D3", asm);
        }
        
        {
            var raw = FNMADD(D0, D1, D2, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D1, D2, D31", asm);
        }
        
        {
            var raw = FNMADD(D31, D1, D2, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D1, D2, D31", asm);
        }
        
        {
            var raw = FNMADD(D0, D31, D2, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D31, D2, D31", asm);
        }
        
        {
            var raw = FNMADD(D31, D31, D2, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D31, D2, D31", asm);
        }
        
        {
            var raw = FNMADD(D0, D1, D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D1, D31, D31", asm);
        }
        
        {
            var raw = FNMADD(D31, D1, D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D1, D31, D31", asm);
        }
        
        {
            var raw = FNMADD(D0, D31, D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D0, D31, D31, D31", asm);
        }
        
        {
            var raw = FNMADD(D31, D31, D31, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FNMADD_d_floatdp3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FNMADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FNMADD D31, D31, D31, D31", asm);
        }
    }
}
