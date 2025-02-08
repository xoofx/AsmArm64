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
public class Arm64InstructionFactoryTests_FCMGE_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asisdsamefp16_only_0()
    {
        
        {
            var raw = FCMGE(H0, H1, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H0, H1, H2", asm);
        }
        
        {
            var raw = FCMGE(H31, H1, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H31, H1, H2", asm);
        }
        
        {
            var raw = FCMGE(H0, H31, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H0, H31, H2", asm);
        }
        
        {
            var raw = FCMGE(H31, H31, H2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H31, H31, H2", asm);
        }
        
        {
            var raw = FCMGE(H0, H1, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H0, H1, H31", asm);
        }
        
        {
            var raw = FCMGE(H31, H1, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H31, H1, H31", asm);
        }
        
        {
            var raw = FCMGE(H0, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H0, H31, H31", asm);
        }
        
        {
            var raw = FCMGE(H31, H31, H31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE H31, H31, H31", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asisdsame_only_1()
    {
        
        {
            var raw = FCMGE(S1, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S1, S2, S3", asm);
        }
        
        {
            var raw = FCMGE(S31, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S31, S2, S3", asm);
        }
        
        {
            var raw = FCMGE(S1, S0, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S1, S0, S3", asm);
        }
        
        {
            var raw = FCMGE(S31, S0, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S31, S0, S3", asm);
        }
        
        {
            var raw = FCMGE(S1, S2, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S1, S2, S1", asm);
        }
        
        {
            var raw = FCMGE(S31, S2, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S31, S2, S1", asm);
        }
        
        {
            var raw = FCMGE(S1, S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S1, S0, S1", asm);
        }
        
        {
            var raw = FCMGE(S31, S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE S31, S0, S1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asisdsame_only_2()
    {
        
        {
            var raw = FCMGE(D1, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D1, D2, D3", asm);
        }
        
        {
            var raw = FCMGE(D31, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D31, D2, D3", asm);
        }
        
        {
            var raw = FCMGE(D1, D0, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D1, D0, D3", asm);
        }
        
        {
            var raw = FCMGE(D31, D0, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D31, D0, D3", asm);
        }
        
        {
            var raw = FCMGE(D1, D2, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D1, D2, D1", asm);
        }
        
        {
            var raw = FCMGE(D31, D2, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D31, D2, D1", asm);
        }
        
        {
            var raw = FCMGE(D1, D0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D1, D0, D1", asm);
        }
        
        {
            var raw = FCMGE(D31, D0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE D31, D0, D1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdsamefp16_only_3()
    {
        
        {
            var raw = FCMGE(V0.T_4H, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4H, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4H, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4H, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = FCMGE(V0.T_4H, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4H, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4H, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4H, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = FCMGE(V0.T_4H, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4H, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4H, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4H, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = FCMGE(V0.T_4H, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4H, V31.4H, V0.4H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4H, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4H, V31.4H, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdsamefp16_only_4()
    {
        
        {
            var raw = FCMGE(V0.T_8H, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.8H, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_8H, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.8H, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = FCMGE(V0.T_8H, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.8H, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_8H, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.8H, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = FCMGE(V0.T_8H, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.8H, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_8H, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.8H, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = FCMGE(V0.T_8H, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.8H, V31.8H, V0.8H", asm);
        }
        
        {
            var raw = FCMGE(V30.T_8H, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsamefp16_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.8H, V31.8H, V0.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdsame_only_5()
    {
        
        {
            var raw = FCMGE(V0.T_2S, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2S, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2S, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2S, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = FCMGE(V0.T_2S, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2S, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2S, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2S, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = FCMGE(V0.T_2S, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2S, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2S, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2S, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = FCMGE(V0.T_2S, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2S, V31.2S, V0.2S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2S, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2S, V31.2S, V0.2S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdsame_only_6()
    {
        
        {
            var raw = FCMGE(V0.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = FCMGE(V0.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = FCMGE(V0.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = FCMGE(V0.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.4S, V31.4S, V0.4S", asm);
        }
        
        {
            var raw = FCMGE(V30.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.4S, V31.4S, V0.4S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdsame_only_7()
    {
        
        {
            var raw = FCMGE(V0.T_2D, V1.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2D, V1.2D, V2.2D", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2D, V1.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2D, V1.2D, V2.2D", asm);
        }
        
        {
            var raw = FCMGE(V0.T_2D, V31.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2D, V31.2D, V2.2D", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2D, V31.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2D, V31.2D, V2.2D", asm);
        }
        
        {
            var raw = FCMGE(V0.T_2D, V1.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2D, V1.2D, V0.2D", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2D, V1.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2D, V1.2D, V0.2D", asm);
        }
        
        {
            var raw = FCMGE(V0.T_2D, V31.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V0.2D, V31.2D, V0.2D", asm);
        }
        
        {
            var raw = FCMGE(V30.T_2D, V31.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FCMGE_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FCMGE, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FCMGE V30.2D, V31.2D, V0.2D", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asisdmiscfp16_fz_8()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asisdmisc_fz_9()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asisdmisc_fz_10()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdmiscfp16_fz_11()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdmiscfp16_fz_12()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdmisc_fz_13()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdmisc_fz_14()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGE_asimdmisc_fz_15()
    {
        Assert.Inconclusive("TODO");
    }
}
