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
public class Arm64InstructionFactoryTests_SQDMULL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asimdelem_l_0()
    {
        TestInst(SQDMULL(V0.T_4S, V1.T_4H, V2.H[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V1.4H, V2.H[0]");
        TestInst(SQDMULL(V30.T_4S, V1.T_4H, V2.H[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V1.4H, V2.H[0]");
        TestInst(SQDMULL(V0.T_4S, V31.T_4H, V2.H[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V31.4H, V2.H[0]");
        TestInst(SQDMULL(V30.T_4S, V31.T_4H, V2.H[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V31.4H, V2.H[0]");
        TestInst(SQDMULL(V0.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V1.4H, V0.H[1]");
        TestInst(SQDMULL(V30.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V1.4H, V0.H[1]");
        TestInst(SQDMULL(V0.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V31.4H, V0.H[1]");
        TestInst(SQDMULL(V30.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asimdelem_l_1()
    {
        TestInst(SQDMULL(V0.T_2D, V1.T_2S, V2.S[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V1.2S, V2.S[0]");
        TestInst(SQDMULL(V30.T_2D, V1.T_2S, V2.S[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V1.2S, V2.S[0]");
        TestInst(SQDMULL(V0.T_2D, V31.T_2S, V2.S[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V31.2S, V2.S[0]");
        TestInst(SQDMULL(V30.T_2D, V31.T_2S, V2.S[0]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V31.2S, V2.S[0]");
        TestInst(SQDMULL(V0.T_2D, V1.T_2S, V0.S[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V1.2S, V0.S[1]");
        TestInst(SQDMULL(V30.T_2D, V1.T_2S, V0.S[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V1.2S, V0.S[1]");
        TestInst(SQDMULL(V0.T_2D, V31.T_2S, V0.S[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V31.2S, V0.S[1]");
        TestInst(SQDMULL(V30.T_2D, V31.T_2S, V0.S[1]), Arm64InstructionId.SQDMULL_asimdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V31.2S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asisdelem_l_2()
    {
        TestInst(SQDMULL(S1, H2, V2.H[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H2, V2.H[0]");
        TestInst(SQDMULL(S31, H2, V2.H[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H2, V2.H[0]");
        TestInst(SQDMULL(S1, H0, V2.H[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H0, V2.H[0]");
        TestInst(SQDMULL(S31, H0, V2.H[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H0, V2.H[0]");
        TestInst(SQDMULL(S1, H2, V0.H[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H2, V0.H[1]");
        TestInst(SQDMULL(S31, H2, V0.H[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H2, V0.H[1]");
        TestInst(SQDMULL(S1, H0, V0.H[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H0, V0.H[1]");
        TestInst(SQDMULL(S31, H0, V0.H[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H0, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asisdelem_l_3()
    {
        TestInst(SQDMULL(D1, S2, V2.S[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S2, V2.S[0]");
        TestInst(SQDMULL(D31, S2, V2.S[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S2, V2.S[0]");
        TestInst(SQDMULL(D1, S0, V2.S[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S0, V2.S[0]");
        TestInst(SQDMULL(D31, S0, V2.S[0]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S0, V2.S[0]");
        TestInst(SQDMULL(D1, S2, V0.S[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S2, V0.S[1]");
        TestInst(SQDMULL(D31, S2, V0.S[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S2, V0.S[1]");
        TestInst(SQDMULL(D1, S0, V0.S[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S0, V0.S[1]");
        TestInst(SQDMULL(D31, S0, V0.S[1]), Arm64InstructionId.SQDMULL_asisdelem_l, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S0, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asisddiff_only_4()
    {
        TestInst(SQDMULL(S1, H2, H3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H2, H3");
        TestInst(SQDMULL(S31, H2, H3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H2, H3");
        TestInst(SQDMULL(S1, H0, H3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H0, H3");
        TestInst(SQDMULL(S31, H0, H3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H0, H3");
        TestInst(SQDMULL(S1, H2, H1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H2, H1");
        TestInst(SQDMULL(S31, H2, H1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H2, H1");
        TestInst(SQDMULL(S1, H0, H1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S1, H0, H1");
        TestInst(SQDMULL(S31, H0, H1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL S31, H0, H1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asisddiff_only_5()
    {
        TestInst(SQDMULL(D1, S2, S3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S2, S3");
        TestInst(SQDMULL(D31, S2, S3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S2, S3");
        TestInst(SQDMULL(D1, S0, S3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S0, S3");
        TestInst(SQDMULL(D31, S0, S3), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S0, S3");
        TestInst(SQDMULL(D1, S2, S1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S2, S1");
        TestInst(SQDMULL(D31, S2, S1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S2, S1");
        TestInst(SQDMULL(D1, S0, S1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D1, S0, S1");
        TestInst(SQDMULL(D31, S0, S1), Arm64InstructionId.SQDMULL_asisddiff_only, Arm64Mnemonic.SQDMULL, "SQDMULL D31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asimddiff_l_6()
    {
        TestInst(SQDMULL(V0.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V1.4H, V2.4H");
        TestInst(SQDMULL(V30.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V1.4H, V2.4H");
        TestInst(SQDMULL(V0.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V31.4H, V2.4H");
        TestInst(SQDMULL(V30.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V31.4H, V2.4H");
        TestInst(SQDMULL(V0.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V1.4H, V0.4H");
        TestInst(SQDMULL(V30.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V1.4H, V0.4H");
        TestInst(SQDMULL(V0.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.4S, V31.4H, V0.4H");
        TestInst(SQDMULL(V30.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.4S, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQDMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQDMULL_asimddiff_l_7()
    {
        TestInst(SQDMULL(V0.T_2D, V1.T_2S, V2.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V1.2S, V2.2S");
        TestInst(SQDMULL(V30.T_2D, V1.T_2S, V2.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V1.2S, V2.2S");
        TestInst(SQDMULL(V0.T_2D, V31.T_2S, V2.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V31.2S, V2.2S");
        TestInst(SQDMULL(V30.T_2D, V31.T_2S, V2.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V31.2S, V2.2S");
        TestInst(SQDMULL(V0.T_2D, V1.T_2S, V0.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V1.2S, V0.2S");
        TestInst(SQDMULL(V30.T_2D, V1.T_2S, V0.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V1.2S, V0.2S");
        TestInst(SQDMULL(V0.T_2D, V31.T_2S, V0.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V0.2D, V31.2S, V0.2S");
        TestInst(SQDMULL(V30.T_2D, V31.T_2S, V0.T_2S), Arm64InstructionId.SQDMULL_asimddiff_l, Arm64Mnemonic.SQDMULL, "SQDMULL V30.2D, V31.2S, V0.2S");
    }
}
