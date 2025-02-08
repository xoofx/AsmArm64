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
public class Arm64InstructionFactoryTests_SMLAL_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMLAL_asimdelem_l_0()
    {
        
        {
            var raw = SMLAL(V0.T_4S, V1.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V1.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V1.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V1.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SMLAL(V0.T_4S, V31.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V31.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V31.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V31.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SMLAL(V0.T_4S, V1.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V1.4H, V0.H[1]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V1.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V1.4H, V0.H[1]", asm);
        }
        
        {
            var raw = SMLAL(V0.T_4S, V31.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V31.4H, V0.H[1]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V31.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V31.4H, V0.H[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMLAL_asimdelem_l_1()
    {
        
        {
            var raw = SMLAL(V0.T_2D, V1.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V1.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V1.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V1.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SMLAL(V0.T_2D, V31.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V31.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V31.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V31.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SMLAL(V0.T_2D, V1.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V1.2S, V0.S[1]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V1.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V1.2S, V0.S[1]", asm);
        }
        
        {
            var raw = SMLAL(V0.T_2D, V31.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V31.2S, V0.S[1]", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V31.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V31.2S, V0.S[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMLAL_asimddiff_l_2()
    {
        
        {
            var raw = SMLAL(V0.T_8H, V1.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.8H, V1.8B, V2.8B", asm);
        }
        
        {
            var raw = SMLAL(V30.T_8H, V1.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.8H, V1.8B, V2.8B", asm);
        }
        
        {
            var raw = SMLAL(V0.T_8H, V31.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.8H, V31.8B, V2.8B", asm);
        }
        
        {
            var raw = SMLAL(V30.T_8H, V31.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.8H, V31.8B, V2.8B", asm);
        }
        
        {
            var raw = SMLAL(V0.T_8H, V1.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.8H, V1.8B, V0.8B", asm);
        }
        
        {
            var raw = SMLAL(V30.T_8H, V1.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.8H, V1.8B, V0.8B", asm);
        }
        
        {
            var raw = SMLAL(V0.T_8H, V31.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.8H, V31.8B, V0.8B", asm);
        }
        
        {
            var raw = SMLAL(V30.T_8H, V31.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.8H, V31.8B, V0.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMLAL_asimddiff_l_3()
    {
        
        {
            var raw = SMLAL(V0.T_4S, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = SMLAL(V0.T_4S, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = SMLAL(V0.T_4S, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = SMLAL(V0.T_4S, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.4S, V31.4H, V0.4H", asm);
        }
        
        {
            var raw = SMLAL(V30.T_4S, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.4S, V31.4H, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMLAL_asimddiff_l_4()
    {
        
        {
            var raw = SMLAL(V0.T_2D, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = SMLAL(V0.T_2D, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = SMLAL(V0.T_2D, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = SMLAL(V0.T_2D, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V0.2D, V31.2S, V0.2S", asm);
        }
        
        {
            var raw = SMLAL(V30.T_2D, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SMLAL V30.2D, V31.2S, V0.2S", asm);
        }
    }
}
