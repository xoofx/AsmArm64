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
public class Arm64InstructionFactoryTests_SQDMLAL_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asisdelem_l_0()
    {
        
        {
            var raw = SQDMLAL(S1, H2, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H2, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H2, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H2, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(S1, H0, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H0, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H0, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H0, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(S1, H2, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H2, V0.H[1]", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H2, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H2, V0.H[1]", asm);
        }
        
        {
            var raw = SQDMLAL(S1, H0, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H0, V0.H[1]", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H0, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H0, V0.H[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asisdelem_l_1()
    {
        
        {
            var raw = SQDMLAL(D1, S2, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S2, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S2, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S2, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(D1, S0, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S0, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S0, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S0, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(D1, S2, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S2, V0.S[1]", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S2, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S2, V0.S[1]", asm);
        }
        
        {
            var raw = SQDMLAL(D1, S0, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S0, V0.S[1]", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S0, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S0, V0.S[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asimdelem_l_2()
    {
        
        {
            var raw = SQDMLAL(V0.T_4S, V1.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V1.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V1.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V1.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_4S, V31.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V31.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V31.T_4H, V2.H[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V31.4H, V2.H[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_4S, V1.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V1.4H, V0.H[1]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V1.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V1.4H, V0.H[1]", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_4S, V31.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V31.4H, V0.H[1]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V31.T_4H, V0.H[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V31.4H, V0.H[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asimdelem_l_3()
    {
        
        {
            var raw = SQDMLAL(V0.T_2D, V1.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V1.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V1.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V1.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_2D, V31.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V31.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V31.T_2S, V2.S[0]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V31.2S, V2.S[0]", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_2D, V1.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V1.2S, V0.S[1]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V1.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V1.2S, V0.S[1]", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_2D, V31.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V31.2S, V0.S[1]", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V31.T_2S, V0.S[1]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimdelem_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V31.2S, V0.S[1]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asisddiff_only_4()
    {
        
        {
            var raw = SQDMLAL(S1, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H2, H3", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H2, H3", asm);
        }
        
        {
            var raw = SQDMLAL(S1, H0, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H0, H3", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H0, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H0, H3", asm);
        }
        
        {
            var raw = SQDMLAL(S1, H2, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H2, H1", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H2, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H2, H1", asm);
        }
        
        {
            var raw = SQDMLAL(S1, H0, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S1, H0, H1", asm);
        }
        
        {
            var raw = SQDMLAL(S31, H0, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL S31, H0, H1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asisddiff_only_5()
    {
        
        {
            var raw = SQDMLAL(D1, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S2, S3", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S2, S3", asm);
        }
        
        {
            var raw = SQDMLAL(D1, S0, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S0, S3", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S0, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S0, S3", asm);
        }
        
        {
            var raw = SQDMLAL(D1, S2, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S2, S1", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S2, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S2, S1", asm);
        }
        
        {
            var raw = SQDMLAL(D1, S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D1, S0, S1", asm);
        }
        
        {
            var raw = SQDMLAL(D31, S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asisddiff_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL D31, S0, S1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asimddiff_l_6()
    {
        
        {
            var raw = SQDMLAL(V0.T_4S, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_4S, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_4S, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_4S, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.4S, V31.4H, V0.4H", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_4S, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.4S, V31.4H, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMLAL_asimddiff_l_7()
    {
        
        {
            var raw = SQDMLAL(V0.T_2D, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_2D, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_2D, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V0.T_2D, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V0.2D, V31.2S, V0.2S", asm);
        }
        
        {
            var raw = SQDMLAL(V30.T_2D, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQDMLAL_asimddiff_l, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQDMLAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQDMLAL V30.2D, V31.2S, V0.2S", asm);
        }
    }
}
