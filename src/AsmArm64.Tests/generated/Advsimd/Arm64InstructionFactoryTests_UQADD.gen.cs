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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_UQADD_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asisdsame_only_0()
    {
        TestInst(UQADD(B1, B2, B3), asm => asm.UQADD(B1, B2, B3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B1, B2, B3");
        TestInst(UQADD(B31, B2, B3), asm => asm.UQADD(B31, B2, B3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B31, B2, B3");
        TestInst(UQADD(B1, B0, B3), asm => asm.UQADD(B1, B0, B3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B1, B0, B3");
        TestInst(UQADD(B31, B0, B3), asm => asm.UQADD(B31, B0, B3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B31, B0, B3");
        TestInst(UQADD(B1, B2, B1), asm => asm.UQADD(B1, B2, B1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B1, B2, B1");
        TestInst(UQADD(B31, B2, B1), asm => asm.UQADD(B31, B2, B1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B31, B2, B1");
        TestInst(UQADD(B1, B0, B1), asm => asm.UQADD(B1, B0, B1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B1, B0, B1");
        TestInst(UQADD(B31, B0, B1), asm => asm.UQADD(B31, B0, B1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD B31, B0, B1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asisdsame_only_1()
    {
        TestInst(UQADD(H1, H2, H3), asm => asm.UQADD(H1, H2, H3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H1, H2, H3");
        TestInst(UQADD(H31, H2, H3), asm => asm.UQADD(H31, H2, H3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H31, H2, H3");
        TestInst(UQADD(H1, H0, H3), asm => asm.UQADD(H1, H0, H3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H1, H0, H3");
        TestInst(UQADD(H31, H0, H3), asm => asm.UQADD(H31, H0, H3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H31, H0, H3");
        TestInst(UQADD(H1, H2, H1), asm => asm.UQADD(H1, H2, H1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H1, H2, H1");
        TestInst(UQADD(H31, H2, H1), asm => asm.UQADD(H31, H2, H1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H31, H2, H1");
        TestInst(UQADD(H1, H0, H1), asm => asm.UQADD(H1, H0, H1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H1, H0, H1");
        TestInst(UQADD(H31, H0, H1), asm => asm.UQADD(H31, H0, H1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD H31, H0, H1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asisdsame_only_2()
    {
        TestInst(UQADD(S1, S2, S3), asm => asm.UQADD(S1, S2, S3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S1, S2, S3");
        TestInst(UQADD(S31, S2, S3), asm => asm.UQADD(S31, S2, S3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S31, S2, S3");
        TestInst(UQADD(S1, S0, S3), asm => asm.UQADD(S1, S0, S3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S1, S0, S3");
        TestInst(UQADD(S31, S0, S3), asm => asm.UQADD(S31, S0, S3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S31, S0, S3");
        TestInst(UQADD(S1, S2, S1), asm => asm.UQADD(S1, S2, S1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S1, S2, S1");
        TestInst(UQADD(S31, S2, S1), asm => asm.UQADD(S31, S2, S1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S31, S2, S1");
        TestInst(UQADD(S1, S0, S1), asm => asm.UQADD(S1, S0, S1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S1, S0, S1");
        TestInst(UQADD(S31, S0, S1), asm => asm.UQADD(S31, S0, S1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD S31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asisdsame_only_3()
    {
        TestInst(UQADD(D1, D2, D3), asm => asm.UQADD(D1, D2, D3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D1, D2, D3");
        TestInst(UQADD(D31, D2, D3), asm => asm.UQADD(D31, D2, D3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D31, D2, D3");
        TestInst(UQADD(D1, D0, D3), asm => asm.UQADD(D1, D0, D3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D1, D0, D3");
        TestInst(UQADD(D31, D0, D3), asm => asm.UQADD(D31, D0, D3), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D31, D0, D3");
        TestInst(UQADD(D1, D2, D1), asm => asm.UQADD(D1, D2, D1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D1, D2, D1");
        TestInst(UQADD(D31, D2, D1), asm => asm.UQADD(D31, D2, D1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D31, D2, D1");
        TestInst(UQADD(D1, D0, D1), asm => asm.UQADD(D1, D0, D1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D1, D0, D1");
        TestInst(UQADD(D31, D0, D1), asm => asm.UQADD(D31, D0, D1), Arm64InstructionId.UQADD_asisdsame_only, Arm64Mnemonic.UQADD, "UQADD D31, D0, D1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_4()
    {
        TestInst(UQADD(V0.T_8B, V1.T_8B, V2.T_8B), asm => asm.UQADD(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8B, V1.8B, V2.8B");
        TestInst(UQADD(V30.T_8B, V1.T_8B, V2.T_8B), asm => asm.UQADD(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8B, V1.8B, V2.8B");
        TestInst(UQADD(V0.T_8B, V31.T_8B, V2.T_8B), asm => asm.UQADD(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8B, V31.8B, V2.8B");
        TestInst(UQADD(V30.T_8B, V31.T_8B, V2.T_8B), asm => asm.UQADD(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8B, V31.8B, V2.8B");
        TestInst(UQADD(V0.T_8B, V1.T_8B, V0.T_8B), asm => asm.UQADD(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8B, V1.8B, V0.8B");
        TestInst(UQADD(V30.T_8B, V1.T_8B, V0.T_8B), asm => asm.UQADD(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8B, V1.8B, V0.8B");
        TestInst(UQADD(V0.T_8B, V31.T_8B, V0.T_8B), asm => asm.UQADD(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8B, V31.8B, V0.8B");
        TestInst(UQADD(V30.T_8B, V31.T_8B, V0.T_8B), asm => asm.UQADD(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_5()
    {
        TestInst(UQADD(V0.T_16B, V1.T_16B, V2.T_16B), asm => asm.UQADD(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.16B, V1.16B, V2.16B");
        TestInst(UQADD(V30.T_16B, V1.T_16B, V2.T_16B), asm => asm.UQADD(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.16B, V1.16B, V2.16B");
        TestInst(UQADD(V0.T_16B, V31.T_16B, V2.T_16B), asm => asm.UQADD(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.16B, V31.16B, V2.16B");
        TestInst(UQADD(V30.T_16B, V31.T_16B, V2.T_16B), asm => asm.UQADD(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.16B, V31.16B, V2.16B");
        TestInst(UQADD(V0.T_16B, V1.T_16B, V0.T_16B), asm => asm.UQADD(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.16B, V1.16B, V0.16B");
        TestInst(UQADD(V30.T_16B, V1.T_16B, V0.T_16B), asm => asm.UQADD(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.16B, V1.16B, V0.16B");
        TestInst(UQADD(V0.T_16B, V31.T_16B, V0.T_16B), asm => asm.UQADD(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.16B, V31.16B, V0.16B");
        TestInst(UQADD(V30.T_16B, V31.T_16B, V0.T_16B), asm => asm.UQADD(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.16B, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_6()
    {
        TestInst(UQADD(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.UQADD(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4H, V1.4H, V2.4H");
        TestInst(UQADD(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.UQADD(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4H, V1.4H, V2.4H");
        TestInst(UQADD(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.UQADD(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4H, V31.4H, V2.4H");
        TestInst(UQADD(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.UQADD(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4H, V31.4H, V2.4H");
        TestInst(UQADD(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.UQADD(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4H, V1.4H, V0.4H");
        TestInst(UQADD(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.UQADD(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4H, V1.4H, V0.4H");
        TestInst(UQADD(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.UQADD(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4H, V31.4H, V0.4H");
        TestInst(UQADD(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.UQADD(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_7()
    {
        TestInst(UQADD(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.UQADD(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8H, V1.8H, V2.8H");
        TestInst(UQADD(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.UQADD(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8H, V1.8H, V2.8H");
        TestInst(UQADD(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.UQADD(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8H, V31.8H, V2.8H");
        TestInst(UQADD(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.UQADD(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8H, V31.8H, V2.8H");
        TestInst(UQADD(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.UQADD(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8H, V1.8H, V0.8H");
        TestInst(UQADD(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.UQADD(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8H, V1.8H, V0.8H");
        TestInst(UQADD(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.UQADD(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.8H, V31.8H, V0.8H");
        TestInst(UQADD(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.UQADD(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_8()
    {
        TestInst(UQADD(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.UQADD(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2S, V1.2S, V2.2S");
        TestInst(UQADD(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.UQADD(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2S, V1.2S, V2.2S");
        TestInst(UQADD(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.UQADD(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2S, V31.2S, V2.2S");
        TestInst(UQADD(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.UQADD(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2S, V31.2S, V2.2S");
        TestInst(UQADD(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.UQADD(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2S, V1.2S, V0.2S");
        TestInst(UQADD(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.UQADD(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2S, V1.2S, V0.2S");
        TestInst(UQADD(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.UQADD(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2S, V31.2S, V0.2S");
        TestInst(UQADD(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.UQADD(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_9()
    {
        TestInst(UQADD(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.UQADD(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4S, V1.4S, V2.4S");
        TestInst(UQADD(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.UQADD(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4S, V1.4S, V2.4S");
        TestInst(UQADD(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.UQADD(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4S, V31.4S, V2.4S");
        TestInst(UQADD(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.UQADD(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4S, V31.4S, V2.4S");
        TestInst(UQADD(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.UQADD(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4S, V1.4S, V0.4S");
        TestInst(UQADD(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.UQADD(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4S, V1.4S, V0.4S");
        TestInst(UQADD(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.UQADD(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.4S, V31.4S, V0.4S");
        TestInst(UQADD(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.UQADD(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQADD_asimdsame_only_10()
    {
        TestInst(UQADD(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.UQADD(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2D, V1.2D, V2.2D");
        TestInst(UQADD(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.UQADD(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2D, V1.2D, V2.2D");
        TestInst(UQADD(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.UQADD(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2D, V31.2D, V2.2D");
        TestInst(UQADD(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.UQADD(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2D, V31.2D, V2.2D");
        TestInst(UQADD(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.UQADD(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2D, V1.2D, V0.2D");
        TestInst(UQADD(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.UQADD(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2D, V1.2D, V0.2D");
        TestInst(UQADD(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.UQADD(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V0.2D, V31.2D, V0.2D");
        TestInst(UQADD(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.UQADD(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.UQADD_asimdsame_only, Arm64Mnemonic.UQADD, "UQADD V30.2D, V31.2D, V0.2D");
    }
}
