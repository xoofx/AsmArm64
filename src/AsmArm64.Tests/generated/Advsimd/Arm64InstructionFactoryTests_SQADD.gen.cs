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
public class Arm64InstructionFactoryTests_SQADD_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asisdsame_only_0()
    {
        
        {
            var raw = SQADD(B1, B2, B3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B1, B2, B3", asm);
        }
        
        {
            var raw = SQADD(B31, B2, B3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B31, B2, B3", asm);
        }
        
        {
            var raw = SQADD(B1, B0, B3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B1, B0, B3", asm);
        }
        
        {
            var raw = SQADD(B31, B0, B3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B31, B0, B3", asm);
        }
        
        {
            var raw = SQADD(B1, B2, B1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B1, B2, B1", asm);
        }
        
        {
            var raw = SQADD(B31, B2, B1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B31, B2, B1", asm);
        }
        
        {
            var raw = SQADD(B1, B0, B1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B1, B0, B1", asm);
        }
        
        {
            var raw = SQADD(B31, B0, B1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD B31, B0, B1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asisdsame_only_1()
    {
        
        {
            var raw = SQADD(H1, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H1, H2, H3", asm);
        }
        
        {
            var raw = SQADD(H31, H2, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H31, H2, H3", asm);
        }
        
        {
            var raw = SQADD(H1, H0, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H1, H0, H3", asm);
        }
        
        {
            var raw = SQADD(H31, H0, H3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H31, H0, H3", asm);
        }
        
        {
            var raw = SQADD(H1, H2, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H1, H2, H1", asm);
        }
        
        {
            var raw = SQADD(H31, H2, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H31, H2, H1", asm);
        }
        
        {
            var raw = SQADD(H1, H0, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H1, H0, H1", asm);
        }
        
        {
            var raw = SQADD(H31, H0, H1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD H31, H0, H1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asisdsame_only_2()
    {
        
        {
            var raw = SQADD(S1, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S1, S2, S3", asm);
        }
        
        {
            var raw = SQADD(S31, S2, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S31, S2, S3", asm);
        }
        
        {
            var raw = SQADD(S1, S0, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S1, S0, S3", asm);
        }
        
        {
            var raw = SQADD(S31, S0, S3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S31, S0, S3", asm);
        }
        
        {
            var raw = SQADD(S1, S2, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S1, S2, S1", asm);
        }
        
        {
            var raw = SQADD(S31, S2, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S31, S2, S1", asm);
        }
        
        {
            var raw = SQADD(S1, S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S1, S0, S1", asm);
        }
        
        {
            var raw = SQADD(S31, S0, S1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD S31, S0, S1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asisdsame_only_3()
    {
        
        {
            var raw = SQADD(D1, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D1, D2, D3", asm);
        }
        
        {
            var raw = SQADD(D31, D2, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D31, D2, D3", asm);
        }
        
        {
            var raw = SQADD(D1, D0, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D1, D0, D3", asm);
        }
        
        {
            var raw = SQADD(D31, D0, D3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D31, D0, D3", asm);
        }
        
        {
            var raw = SQADD(D1, D2, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D1, D2, D1", asm);
        }
        
        {
            var raw = SQADD(D31, D2, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D31, D2, D1", asm);
        }
        
        {
            var raw = SQADD(D1, D0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D1, D0, D1", asm);
        }
        
        {
            var raw = SQADD(D31, D0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asisdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD D31, D0, D1", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_4()
    {
        
        {
            var raw = SQADD(V0.T_8B, V1.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8B, V1.8B, V2.8B", asm);
        }
        
        {
            var raw = SQADD(V30.T_8B, V1.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8B, V1.8B, V2.8B", asm);
        }
        
        {
            var raw = SQADD(V0.T_8B, V31.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8B, V31.8B, V2.8B", asm);
        }
        
        {
            var raw = SQADD(V30.T_8B, V31.T_8B, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8B, V31.8B, V2.8B", asm);
        }
        
        {
            var raw = SQADD(V0.T_8B, V1.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8B, V1.8B, V0.8B", asm);
        }
        
        {
            var raw = SQADD(V30.T_8B, V1.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8B, V1.8B, V0.8B", asm);
        }
        
        {
            var raw = SQADD(V0.T_8B, V31.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8B, V31.8B, V0.8B", asm);
        }
        
        {
            var raw = SQADD(V30.T_8B, V31.T_8B, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8B, V31.8B, V0.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_5()
    {
        
        {
            var raw = SQADD(V0.T_16B, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.16B, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = SQADD(V30.T_16B, V1.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.16B, V1.16B, V2.16B", asm);
        }
        
        {
            var raw = SQADD(V0.T_16B, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.16B, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = SQADD(V30.T_16B, V31.T_16B, V2.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.16B, V31.16B, V2.16B", asm);
        }
        
        {
            var raw = SQADD(V0.T_16B, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.16B, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = SQADD(V30.T_16B, V1.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.16B, V1.16B, V0.16B", asm);
        }
        
        {
            var raw = SQADD(V0.T_16B, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.16B, V31.16B, V0.16B", asm);
        }
        
        {
            var raw = SQADD(V30.T_16B, V31.T_16B, V0.T_16B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.16B, V31.16B, V0.16B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_6()
    {
        
        {
            var raw = SQADD(V0.T_4H, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4H, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = SQADD(V30.T_4H, V1.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4H, V1.4H, V2.4H", asm);
        }
        
        {
            var raw = SQADD(V0.T_4H, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4H, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = SQADD(V30.T_4H, V31.T_4H, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4H, V31.4H, V2.4H", asm);
        }
        
        {
            var raw = SQADD(V0.T_4H, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4H, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = SQADD(V30.T_4H, V1.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4H, V1.4H, V0.4H", asm);
        }
        
        {
            var raw = SQADD(V0.T_4H, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4H, V31.4H, V0.4H", asm);
        }
        
        {
            var raw = SQADD(V30.T_4H, V31.T_4H, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4H, V31.4H, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_7()
    {
        
        {
            var raw = SQADD(V0.T_8H, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8H, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = SQADD(V30.T_8H, V1.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8H, V1.8H, V2.8H", asm);
        }
        
        {
            var raw = SQADD(V0.T_8H, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8H, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = SQADD(V30.T_8H, V31.T_8H, V2.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8H, V31.8H, V2.8H", asm);
        }
        
        {
            var raw = SQADD(V0.T_8H, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8H, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = SQADD(V30.T_8H, V1.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8H, V1.8H, V0.8H", asm);
        }
        
        {
            var raw = SQADD(V0.T_8H, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.8H, V31.8H, V0.8H", asm);
        }
        
        {
            var raw = SQADD(V30.T_8H, V31.T_8H, V0.T_8H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.8H, V31.8H, V0.8H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_8()
    {
        
        {
            var raw = SQADD(V0.T_2S, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2S, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = SQADD(V30.T_2S, V1.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2S, V1.2S, V2.2S", asm);
        }
        
        {
            var raw = SQADD(V0.T_2S, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2S, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = SQADD(V30.T_2S, V31.T_2S, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2S, V31.2S, V2.2S", asm);
        }
        
        {
            var raw = SQADD(V0.T_2S, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2S, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = SQADD(V30.T_2S, V1.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2S, V1.2S, V0.2S", asm);
        }
        
        {
            var raw = SQADD(V0.T_2S, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2S, V31.2S, V0.2S", asm);
        }
        
        {
            var raw = SQADD(V30.T_2S, V31.T_2S, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2S, V31.2S, V0.2S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_9()
    {
        
        {
            var raw = SQADD(V0.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = SQADD(V30.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = SQADD(V0.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = SQADD(V30.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = SQADD(V0.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = SQADD(V30.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = SQADD(V0.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.4S, V31.4S, V0.4S", asm);
        }
        
        {
            var raw = SQADD(V30.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.4S, V31.4S, V0.4S", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQADD_asimdsame_only_10()
    {
        
        {
            var raw = SQADD(V0.T_2D, V1.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2D, V1.2D, V2.2D", asm);
        }
        
        {
            var raw = SQADD(V30.T_2D, V1.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2D, V1.2D, V2.2D", asm);
        }
        
        {
            var raw = SQADD(V0.T_2D, V31.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2D, V31.2D, V2.2D", asm);
        }
        
        {
            var raw = SQADD(V30.T_2D, V31.T_2D, V2.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2D, V31.2D, V2.2D", asm);
        }
        
        {
            var raw = SQADD(V0.T_2D, V1.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2D, V1.2D, V0.2D", asm);
        }
        
        {
            var raw = SQADD(V30.T_2D, V1.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2D, V1.2D, V0.2D", asm);
        }
        
        {
            var raw = SQADD(V0.T_2D, V31.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V0.2D, V31.2D, V0.2D", asm);
        }
        
        {
            var raw = SQADD(V30.T_2D, V31.T_2D, V0.T_2D);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SQADD_asimdsame_only, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SQADD, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SQADD V30.2D, V31.2D, V0.2D", asm);
        }
    }
}
