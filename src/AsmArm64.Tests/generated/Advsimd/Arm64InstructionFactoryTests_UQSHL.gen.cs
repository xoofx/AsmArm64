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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_UQSHL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdshf_r_0()
    {
        TestInst(UQSHL(B1, B2, 5), asm => asm.UQSHL(B1, B2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL B1, B2, #5");
        TestInst(UQSHL(B31, B2, 5), asm => asm.UQSHL(B31, B2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL B31, B2, #5");
        TestInst(UQSHL(B1, B0, 5), asm => asm.UQSHL(B1, B0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL B1, B0, #5");
        TestInst(UQSHL(B31, B0, 5), asm => asm.UQSHL(B31, B0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL B31, B0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdshf_r_1()
    {
        TestInst(UQSHL(H1, H2, 5), asm => asm.UQSHL(H1, H2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL H1, H2, #5");
        TestInst(UQSHL(H31, H2, 5), asm => asm.UQSHL(H31, H2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL H31, H2, #5");
        TestInst(UQSHL(H1, H0, 5), asm => asm.UQSHL(H1, H0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL H1, H0, #5");
        TestInst(UQSHL(H31, H0, 5), asm => asm.UQSHL(H31, H0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL H31, H0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdshf_r_2()
    {
        TestInst(UQSHL(S1, S2, 5), asm => asm.UQSHL(S1, S2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL S1, S2, #5");
        TestInst(UQSHL(S31, S2, 5), asm => asm.UQSHL(S31, S2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL S31, S2, #5");
        TestInst(UQSHL(S1, S0, 5), asm => asm.UQSHL(S1, S0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL S1, S0, #5");
        TestInst(UQSHL(S31, S0, 5), asm => asm.UQSHL(S31, S0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL S31, S0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdshf_r_3()
    {
        TestInst(UQSHL(D1, D2, 5), asm => asm.UQSHL(D1, D2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL D1, D2, #5");
        TestInst(UQSHL(D31, D2, 5), asm => asm.UQSHL(D31, D2, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL D31, D2, #5");
        TestInst(UQSHL(D1, D0, 5), asm => asm.UQSHL(D1, D0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL D1, D0, #5");
        TestInst(UQSHL(D31, D0, 5), asm => asm.UQSHL(D31, D0, 5), Arm64InstructionId.UQSHL_asisdshf_r, Arm64Mnemonic.UQSHL, "UQSHL D31, D0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_4()
    {
        TestInst(UQSHL(V0.T_8B, V1.T_8B, 5), asm => asm.UQSHL(V0.T_8B, V1.T_8B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.8B, V1.8B, #5");
        TestInst(UQSHL(V30.T_8B, V1.T_8B, 5), asm => asm.UQSHL(V30.T_8B, V1.T_8B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.8B, V1.8B, #5");
        TestInst(UQSHL(V0.T_8B, V31.T_8B, 5), asm => asm.UQSHL(V0.T_8B, V31.T_8B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.8B, V31.8B, #5");
        TestInst(UQSHL(V30.T_8B, V31.T_8B, 5), asm => asm.UQSHL(V30.T_8B, V31.T_8B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.8B, V31.8B, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_5()
    {
        TestInst(UQSHL(V0.T_16B, V1.T_16B, 5), asm => asm.UQSHL(V0.T_16B, V1.T_16B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.16B, V1.16B, #5");
        TestInst(UQSHL(V30.T_16B, V1.T_16B, 5), asm => asm.UQSHL(V30.T_16B, V1.T_16B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.16B, V1.16B, #5");
        TestInst(UQSHL(V0.T_16B, V31.T_16B, 5), asm => asm.UQSHL(V0.T_16B, V31.T_16B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.16B, V31.16B, #5");
        TestInst(UQSHL(V30.T_16B, V31.T_16B, 5), asm => asm.UQSHL(V30.T_16B, V31.T_16B, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.16B, V31.16B, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_6()
    {
        TestInst(UQSHL(V0.T_4H, V1.T_4H, 5), asm => asm.UQSHL(V0.T_4H, V1.T_4H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.4H, V1.4H, #5");
        TestInst(UQSHL(V30.T_4H, V1.T_4H, 5), asm => asm.UQSHL(V30.T_4H, V1.T_4H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.4H, V1.4H, #5");
        TestInst(UQSHL(V0.T_4H, V31.T_4H, 5), asm => asm.UQSHL(V0.T_4H, V31.T_4H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.4H, V31.4H, #5");
        TestInst(UQSHL(V30.T_4H, V31.T_4H, 5), asm => asm.UQSHL(V30.T_4H, V31.T_4H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.4H, V31.4H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_7()
    {
        TestInst(UQSHL(V0.T_8H, V1.T_8H, 5), asm => asm.UQSHL(V0.T_8H, V1.T_8H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.8H, V1.8H, #5");
        TestInst(UQSHL(V30.T_8H, V1.T_8H, 5), asm => asm.UQSHL(V30.T_8H, V1.T_8H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.8H, V1.8H, #5");
        TestInst(UQSHL(V0.T_8H, V31.T_8H, 5), asm => asm.UQSHL(V0.T_8H, V31.T_8H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.8H, V31.8H, #5");
        TestInst(UQSHL(V30.T_8H, V31.T_8H, 5), asm => asm.UQSHL(V30.T_8H, V31.T_8H, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.8H, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_8()
    {
        TestInst(UQSHL(V0.T_2S, V1.T_2S, 5), asm => asm.UQSHL(V0.T_2S, V1.T_2S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.2S, V1.2S, #5");
        TestInst(UQSHL(V30.T_2S, V1.T_2S, 5), asm => asm.UQSHL(V30.T_2S, V1.T_2S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.2S, V1.2S, #5");
        TestInst(UQSHL(V0.T_2S, V31.T_2S, 5), asm => asm.UQSHL(V0.T_2S, V31.T_2S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.2S, V31.2S, #5");
        TestInst(UQSHL(V30.T_2S, V31.T_2S, 5), asm => asm.UQSHL(V30.T_2S, V31.T_2S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.2S, V31.2S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_9()
    {
        TestInst(UQSHL(V0.T_4S, V1.T_4S, 5), asm => asm.UQSHL(V0.T_4S, V1.T_4S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.4S, V1.4S, #5");
        TestInst(UQSHL(V30.T_4S, V1.T_4S, 5), asm => asm.UQSHL(V30.T_4S, V1.T_4S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.4S, V1.4S, #5");
        TestInst(UQSHL(V0.T_4S, V31.T_4S, 5), asm => asm.UQSHL(V0.T_4S, V31.T_4S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.4S, V31.4S, #5");
        TestInst(UQSHL(V30.T_4S, V31.T_4S, 5), asm => asm.UQSHL(V30.T_4S, V31.T_4S, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.4S, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdshf_r_10()
    {
        TestInst(UQSHL(V0.T_2D, V1.T_2D, 5), asm => asm.UQSHL(V0.T_2D, V1.T_2D, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.2D, V1.2D, #5");
        TestInst(UQSHL(V30.T_2D, V1.T_2D, 5), asm => asm.UQSHL(V30.T_2D, V1.T_2D, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.2D, V1.2D, #5");
        TestInst(UQSHL(V0.T_2D, V31.T_2D, 5), asm => asm.UQSHL(V0.T_2D, V31.T_2D, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V0.2D, V31.2D, #5");
        TestInst(UQSHL(V30.T_2D, V31.T_2D, 5), asm => asm.UQSHL(V30.T_2D, V31.T_2D, 5), Arm64InstructionId.UQSHL_asimdshf_r, Arm64Mnemonic.UQSHL, "UQSHL V30.2D, V31.2D, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdsame_only_11()
    {
        TestInst(UQSHL(B1, B2, B3), asm => asm.UQSHL(B1, B2, B3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B1, B2, B3");
        TestInst(UQSHL(B31, B2, B3), asm => asm.UQSHL(B31, B2, B3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B31, B2, B3");
        TestInst(UQSHL(B1, B0, B3), asm => asm.UQSHL(B1, B0, B3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B1, B0, B3");
        TestInst(UQSHL(B31, B0, B3), asm => asm.UQSHL(B31, B0, B3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B31, B0, B3");
        TestInst(UQSHL(B1, B2, B1), asm => asm.UQSHL(B1, B2, B1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B1, B2, B1");
        TestInst(UQSHL(B31, B2, B1), asm => asm.UQSHL(B31, B2, B1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B31, B2, B1");
        TestInst(UQSHL(B1, B0, B1), asm => asm.UQSHL(B1, B0, B1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B1, B0, B1");
        TestInst(UQSHL(B31, B0, B1), asm => asm.UQSHL(B31, B0, B1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL B31, B0, B1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdsame_only_12()
    {
        TestInst(UQSHL(H1, H2, H3), asm => asm.UQSHL(H1, H2, H3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H1, H2, H3");
        TestInst(UQSHL(H31, H2, H3), asm => asm.UQSHL(H31, H2, H3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H31, H2, H3");
        TestInst(UQSHL(H1, H0, H3), asm => asm.UQSHL(H1, H0, H3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H1, H0, H3");
        TestInst(UQSHL(H31, H0, H3), asm => asm.UQSHL(H31, H0, H3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H31, H0, H3");
        TestInst(UQSHL(H1, H2, H1), asm => asm.UQSHL(H1, H2, H1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H1, H2, H1");
        TestInst(UQSHL(H31, H2, H1), asm => asm.UQSHL(H31, H2, H1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H31, H2, H1");
        TestInst(UQSHL(H1, H0, H1), asm => asm.UQSHL(H1, H0, H1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H1, H0, H1");
        TestInst(UQSHL(H31, H0, H1), asm => asm.UQSHL(H31, H0, H1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL H31, H0, H1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdsame_only_13()
    {
        TestInst(UQSHL(S1, S2, S3), asm => asm.UQSHL(S1, S2, S3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S1, S2, S3");
        TestInst(UQSHL(S31, S2, S3), asm => asm.UQSHL(S31, S2, S3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S31, S2, S3");
        TestInst(UQSHL(S1, S0, S3), asm => asm.UQSHL(S1, S0, S3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S1, S0, S3");
        TestInst(UQSHL(S31, S0, S3), asm => asm.UQSHL(S31, S0, S3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S31, S0, S3");
        TestInst(UQSHL(S1, S2, S1), asm => asm.UQSHL(S1, S2, S1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S1, S2, S1");
        TestInst(UQSHL(S31, S2, S1), asm => asm.UQSHL(S31, S2, S1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S31, S2, S1");
        TestInst(UQSHL(S1, S0, S1), asm => asm.UQSHL(S1, S0, S1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S1, S0, S1");
        TestInst(UQSHL(S31, S0, S1), asm => asm.UQSHL(S31, S0, S1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL S31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asisdsame_only_14()
    {
        TestInst(UQSHL(D1, D2, D3), asm => asm.UQSHL(D1, D2, D3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D1, D2, D3");
        TestInst(UQSHL(D31, D2, D3), asm => asm.UQSHL(D31, D2, D3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D31, D2, D3");
        TestInst(UQSHL(D1, D0, D3), asm => asm.UQSHL(D1, D0, D3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D1, D0, D3");
        TestInst(UQSHL(D31, D0, D3), asm => asm.UQSHL(D31, D0, D3), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D31, D0, D3");
        TestInst(UQSHL(D1, D2, D1), asm => asm.UQSHL(D1, D2, D1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D1, D2, D1");
        TestInst(UQSHL(D31, D2, D1), asm => asm.UQSHL(D31, D2, D1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D31, D2, D1");
        TestInst(UQSHL(D1, D0, D1), asm => asm.UQSHL(D1, D0, D1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D1, D0, D1");
        TestInst(UQSHL(D31, D0, D1), asm => asm.UQSHL(D31, D0, D1), Arm64InstructionId.UQSHL_asisdsame_only, Arm64Mnemonic.UQSHL, "UQSHL D31, D0, D1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_15()
    {
        TestInst(UQSHL(V0.T_8B, V1.T_8B, V2.T_8B), asm => asm.UQSHL(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8B, V1.8B, V2.8B");
        TestInst(UQSHL(V30.T_8B, V1.T_8B, V2.T_8B), asm => asm.UQSHL(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8B, V1.8B, V2.8B");
        TestInst(UQSHL(V0.T_8B, V31.T_8B, V2.T_8B), asm => asm.UQSHL(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8B, V31.8B, V2.8B");
        TestInst(UQSHL(V30.T_8B, V31.T_8B, V2.T_8B), asm => asm.UQSHL(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8B, V31.8B, V2.8B");
        TestInst(UQSHL(V0.T_8B, V1.T_8B, V0.T_8B), asm => asm.UQSHL(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8B, V1.8B, V0.8B");
        TestInst(UQSHL(V30.T_8B, V1.T_8B, V0.T_8B), asm => asm.UQSHL(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8B, V1.8B, V0.8B");
        TestInst(UQSHL(V0.T_8B, V31.T_8B, V0.T_8B), asm => asm.UQSHL(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8B, V31.8B, V0.8B");
        TestInst(UQSHL(V30.T_8B, V31.T_8B, V0.T_8B), asm => asm.UQSHL(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_16()
    {
        TestInst(UQSHL(V0.T_16B, V1.T_16B, V2.T_16B), asm => asm.UQSHL(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.16B, V1.16B, V2.16B");
        TestInst(UQSHL(V30.T_16B, V1.T_16B, V2.T_16B), asm => asm.UQSHL(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.16B, V1.16B, V2.16B");
        TestInst(UQSHL(V0.T_16B, V31.T_16B, V2.T_16B), asm => asm.UQSHL(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.16B, V31.16B, V2.16B");
        TestInst(UQSHL(V30.T_16B, V31.T_16B, V2.T_16B), asm => asm.UQSHL(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.16B, V31.16B, V2.16B");
        TestInst(UQSHL(V0.T_16B, V1.T_16B, V0.T_16B), asm => asm.UQSHL(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.16B, V1.16B, V0.16B");
        TestInst(UQSHL(V30.T_16B, V1.T_16B, V0.T_16B), asm => asm.UQSHL(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.16B, V1.16B, V0.16B");
        TestInst(UQSHL(V0.T_16B, V31.T_16B, V0.T_16B), asm => asm.UQSHL(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.16B, V31.16B, V0.16B");
        TestInst(UQSHL(V30.T_16B, V31.T_16B, V0.T_16B), asm => asm.UQSHL(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.16B, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_17()
    {
        TestInst(UQSHL(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.UQSHL(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4H, V1.4H, V2.4H");
        TestInst(UQSHL(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.UQSHL(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4H, V1.4H, V2.4H");
        TestInst(UQSHL(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.UQSHL(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4H, V31.4H, V2.4H");
        TestInst(UQSHL(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.UQSHL(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4H, V31.4H, V2.4H");
        TestInst(UQSHL(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.UQSHL(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4H, V1.4H, V0.4H");
        TestInst(UQSHL(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.UQSHL(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4H, V1.4H, V0.4H");
        TestInst(UQSHL(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.UQSHL(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4H, V31.4H, V0.4H");
        TestInst(UQSHL(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.UQSHL(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_18()
    {
        TestInst(UQSHL(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.UQSHL(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8H, V1.8H, V2.8H");
        TestInst(UQSHL(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.UQSHL(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8H, V1.8H, V2.8H");
        TestInst(UQSHL(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.UQSHL(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8H, V31.8H, V2.8H");
        TestInst(UQSHL(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.UQSHL(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8H, V31.8H, V2.8H");
        TestInst(UQSHL(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.UQSHL(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8H, V1.8H, V0.8H");
        TestInst(UQSHL(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.UQSHL(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8H, V1.8H, V0.8H");
        TestInst(UQSHL(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.UQSHL(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.8H, V31.8H, V0.8H");
        TestInst(UQSHL(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.UQSHL(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_19()
    {
        TestInst(UQSHL(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.UQSHL(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2S, V1.2S, V2.2S");
        TestInst(UQSHL(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.UQSHL(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2S, V1.2S, V2.2S");
        TestInst(UQSHL(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.UQSHL(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2S, V31.2S, V2.2S");
        TestInst(UQSHL(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.UQSHL(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2S, V31.2S, V2.2S");
        TestInst(UQSHL(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.UQSHL(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2S, V1.2S, V0.2S");
        TestInst(UQSHL(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.UQSHL(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2S, V1.2S, V0.2S");
        TestInst(UQSHL(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.UQSHL(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2S, V31.2S, V0.2S");
        TestInst(UQSHL(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.UQSHL(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_20()
    {
        TestInst(UQSHL(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.UQSHL(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4S, V1.4S, V2.4S");
        TestInst(UQSHL(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.UQSHL(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4S, V1.4S, V2.4S");
        TestInst(UQSHL(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.UQSHL(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4S, V31.4S, V2.4S");
        TestInst(UQSHL(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.UQSHL(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4S, V31.4S, V2.4S");
        TestInst(UQSHL(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.UQSHL(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4S, V1.4S, V0.4S");
        TestInst(UQSHL(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.UQSHL(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4S, V1.4S, V0.4S");
        TestInst(UQSHL(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.UQSHL(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.4S, V31.4S, V0.4S");
        TestInst(UQSHL(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.UQSHL(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHL_asimdsame_only_21()
    {
        TestInst(UQSHL(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.UQSHL(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2D, V1.2D, V2.2D");
        TestInst(UQSHL(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.UQSHL(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2D, V1.2D, V2.2D");
        TestInst(UQSHL(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.UQSHL(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2D, V31.2D, V2.2D");
        TestInst(UQSHL(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.UQSHL(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2D, V31.2D, V2.2D");
        TestInst(UQSHL(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.UQSHL(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2D, V1.2D, V0.2D");
        TestInst(UQSHL(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.UQSHL(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2D, V1.2D, V0.2D");
        TestInst(UQSHL(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.UQSHL(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V0.2D, V31.2D, V0.2D");
        TestInst(UQSHL(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.UQSHL(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.UQSHL_asimdsame_only, Arm64Mnemonic.UQSHL, "UQSHL V30.2D, V31.2D, V0.2D");
    }
}
