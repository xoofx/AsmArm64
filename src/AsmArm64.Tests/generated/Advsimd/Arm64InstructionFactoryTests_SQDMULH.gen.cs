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
public class Arm64InstructionFactoryTests_SQDMULH_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asisdelem_r_0()
    {
        TestInst(SQDMULH(H1, H2, V2.H[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H2, V2.H[0]");
        TestInst(SQDMULH(H31, H2, V2.H[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H2, V2.H[0]");
        TestInst(SQDMULH(H1, H0, V2.H[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H0, V2.H[0]");
        TestInst(SQDMULH(H31, H0, V2.H[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H0, V2.H[0]");
        TestInst(SQDMULH(H1, H2, V0.H[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H2, V0.H[1]");
        TestInst(SQDMULH(H31, H2, V0.H[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H2, V0.H[1]");
        TestInst(SQDMULH(H1, H0, V0.H[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H0, V0.H[1]");
        TestInst(SQDMULH(H31, H0, V0.H[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H0, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asisdelem_r_1()
    {
        TestInst(SQDMULH(S1, S2, V2.S[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S2, V2.S[0]");
        TestInst(SQDMULH(S31, S2, V2.S[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S2, V2.S[0]");
        TestInst(SQDMULH(S1, S0, V2.S[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S0, V2.S[0]");
        TestInst(SQDMULH(S31, S0, V2.S[0]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S0, V2.S[0]");
        TestInst(SQDMULH(S1, S2, V0.S[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S2, V0.S[1]");
        TestInst(SQDMULH(S31, S2, V0.S[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S2, V0.S[1]");
        TestInst(SQDMULH(S1, S0, V0.S[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S0, V0.S[1]");
        TestInst(SQDMULH(S31, S0, V0.S[1]), Arm64InstructionId.SQDMULH_asisdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S0, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdelem_r_2()
    {
        TestInst(SQDMULH(V0.T_4H, V1.T_4H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V1.4H, V2.H[0]");
        TestInst(SQDMULH(V30.T_4H, V1.T_4H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V1.4H, V2.H[0]");
        TestInst(SQDMULH(V0.T_4H, V31.T_4H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V31.4H, V2.H[0]");
        TestInst(SQDMULH(V30.T_4H, V31.T_4H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V31.4H, V2.H[0]");
        TestInst(SQDMULH(V0.T_4H, V1.T_4H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V1.4H, V0.H[1]");
        TestInst(SQDMULH(V30.T_4H, V1.T_4H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V1.4H, V0.H[1]");
        TestInst(SQDMULH(V0.T_4H, V31.T_4H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V31.4H, V0.H[1]");
        TestInst(SQDMULH(V30.T_4H, V31.T_4H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdelem_r_3()
    {
        TestInst(SQDMULH(V0.T_8H, V1.T_8H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V1.8H, V2.H[0]");
        TestInst(SQDMULH(V30.T_8H, V1.T_8H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V1.8H, V2.H[0]");
        TestInst(SQDMULH(V0.T_8H, V31.T_8H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V31.8H, V2.H[0]");
        TestInst(SQDMULH(V30.T_8H, V31.T_8H, V2.H[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V31.8H, V2.H[0]");
        TestInst(SQDMULH(V0.T_8H, V1.T_8H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V1.8H, V0.H[1]");
        TestInst(SQDMULH(V30.T_8H, V1.T_8H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V1.8H, V0.H[1]");
        TestInst(SQDMULH(V0.T_8H, V31.T_8H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V31.8H, V0.H[1]");
        TestInst(SQDMULH(V30.T_8H, V31.T_8H, V0.H[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V31.8H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdelem_r_4()
    {
        TestInst(SQDMULH(V0.T_2S, V1.T_2S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V1.2S, V2.S[0]");
        TestInst(SQDMULH(V30.T_2S, V1.T_2S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V1.2S, V2.S[0]");
        TestInst(SQDMULH(V0.T_2S, V31.T_2S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V31.2S, V2.S[0]");
        TestInst(SQDMULH(V30.T_2S, V31.T_2S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V31.2S, V2.S[0]");
        TestInst(SQDMULH(V0.T_2S, V1.T_2S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V1.2S, V0.S[1]");
        TestInst(SQDMULH(V30.T_2S, V1.T_2S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V1.2S, V0.S[1]");
        TestInst(SQDMULH(V0.T_2S, V31.T_2S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V31.2S, V0.S[1]");
        TestInst(SQDMULH(V30.T_2S, V31.T_2S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V31.2S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdelem_r_5()
    {
        TestInst(SQDMULH(V0.T_4S, V1.T_4S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V1.4S, V2.S[0]");
        TestInst(SQDMULH(V30.T_4S, V1.T_4S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V1.4S, V2.S[0]");
        TestInst(SQDMULH(V0.T_4S, V31.T_4S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V31.4S, V2.S[0]");
        TestInst(SQDMULH(V30.T_4S, V31.T_4S, V2.S[0]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V31.4S, V2.S[0]");
        TestInst(SQDMULH(V0.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V1.4S, V0.S[1]");
        TestInst(SQDMULH(V30.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V1.4S, V0.S[1]");
        TestInst(SQDMULH(V0.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V31.4S, V0.S[1]");
        TestInst(SQDMULH(V30.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.SQDMULH_asimdelem_r, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V31.4S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asisdsame_only_6()
    {
        TestInst(SQDMULH(H1, H2, H3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H2, H3");
        TestInst(SQDMULH(H31, H2, H3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H2, H3");
        TestInst(SQDMULH(H1, H0, H3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H0, H3");
        TestInst(SQDMULH(H31, H0, H3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H0, H3");
        TestInst(SQDMULH(H1, H2, H1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H2, H1");
        TestInst(SQDMULH(H31, H2, H1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H2, H1");
        TestInst(SQDMULH(H1, H0, H1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H1, H0, H1");
        TestInst(SQDMULH(H31, H0, H1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH H31, H0, H1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asisdsame_only_7()
    {
        TestInst(SQDMULH(S1, S2, S3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S2, S3");
        TestInst(SQDMULH(S31, S2, S3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S2, S3");
        TestInst(SQDMULH(S1, S0, S3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S0, S3");
        TestInst(SQDMULH(S31, S0, S3), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S0, S3");
        TestInst(SQDMULH(S1, S2, S1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S2, S1");
        TestInst(SQDMULH(S31, S2, S1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S2, S1");
        TestInst(SQDMULH(S1, S0, S1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S1, S0, S1");
        TestInst(SQDMULH(S31, S0, S1), Arm64InstructionId.SQDMULH_asisdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH S31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdsame_only_8()
    {
        TestInst(SQDMULH(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V1.4H, V2.4H");
        TestInst(SQDMULH(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V1.4H, V2.4H");
        TestInst(SQDMULH(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V31.4H, V2.4H");
        TestInst(SQDMULH(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V31.4H, V2.4H");
        TestInst(SQDMULH(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V1.4H, V0.4H");
        TestInst(SQDMULH(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V1.4H, V0.4H");
        TestInst(SQDMULH(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4H, V31.4H, V0.4H");
        TestInst(SQDMULH(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdsame_only_9()
    {
        TestInst(SQDMULH(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V1.8H, V2.8H");
        TestInst(SQDMULH(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V1.8H, V2.8H");
        TestInst(SQDMULH(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V31.8H, V2.8H");
        TestInst(SQDMULH(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V31.8H, V2.8H");
        TestInst(SQDMULH(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V1.8H, V0.8H");
        TestInst(SQDMULH(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V1.8H, V0.8H");
        TestInst(SQDMULH(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.8H, V31.8H, V0.8H");
        TestInst(SQDMULH(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdsame_only_10()
    {
        TestInst(SQDMULH(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V1.2S, V2.2S");
        TestInst(SQDMULH(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V1.2S, V2.2S");
        TestInst(SQDMULH(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V31.2S, V2.2S");
        TestInst(SQDMULH(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V31.2S, V2.2S");
        TestInst(SQDMULH(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V1.2S, V0.2S");
        TestInst(SQDMULH(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V1.2S, V0.2S");
        TestInst(SQDMULH(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.2S, V31.2S, V0.2S");
        TestInst(SQDMULH(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULH_asimdsame_only_11()
    {
        TestInst(SQDMULH(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V1.4S, V2.4S");
        TestInst(SQDMULH(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V1.4S, V2.4S");
        TestInst(SQDMULH(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V31.4S, V2.4S");
        TestInst(SQDMULH(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V31.4S, V2.4S");
        TestInst(SQDMULH(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V1.4S, V0.4S");
        TestInst(SQDMULH(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V1.4S, V0.4S");
        TestInst(SQDMULH(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V0.4S, V31.4S, V0.4S");
        TestInst(SQDMULH(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.SQDMULH_asimdsame_only, Arm64Mnemonic.SQDMULH, "SQDMULH V30.4S, V31.4S, V0.4S");
    }
}
