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
public class Arm64InstructionFactoryTests_FMUL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asisdelem_rh_h_0()
    {
        TestInst(FMUL(H0, H1, V2.H[1]), asm => asm.FMUL(H0, H1, V2.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H0, H1, V2.H[1]");
        TestInst(FMUL(H31, H1, V2.H[1]), asm => asm.FMUL(H31, H1, V2.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H31, H1, V2.H[1]");
        TestInst(FMUL(H0, H31, V2.H[1]), asm => asm.FMUL(H0, H31, V2.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H0, H31, V2.H[1]");
        TestInst(FMUL(H31, H31, V2.H[1]), asm => asm.FMUL(H31, H31, V2.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H31, H31, V2.H[1]");
        TestInst(FMUL(H0, H1, V0.H[1]), asm => asm.FMUL(H0, H1, V0.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H0, H1, V0.H[1]");
        TestInst(FMUL(H31, H1, V0.H[1]), asm => asm.FMUL(H31, H1, V0.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H31, H1, V0.H[1]");
        TestInst(FMUL(H0, H31, V0.H[1]), asm => asm.FMUL(H0, H31, V0.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H0, H31, V0.H[1]");
        TestInst(FMUL(H31, H31, V0.H[1]), asm => asm.FMUL(H31, H31, V0.H[1]), Arm64InstructionId.FMUL_asisdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL H31, H31, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asisdelem_r_sd_1()
    {
        TestInst(FMUL(S1, S2, V2.S[0]), asm => asm.FMUL(S1, S2, V2.S[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S1, S2, V2.S[0]");
        TestInst(FMUL(S31, S2, V2.S[0]), asm => asm.FMUL(S31, S2, V2.S[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S31, S2, V2.S[0]");
        TestInst(FMUL(S1, S0, V2.S[0]), asm => asm.FMUL(S1, S0, V2.S[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S1, S0, V2.S[0]");
        TestInst(FMUL(S31, S0, V2.S[0]), asm => asm.FMUL(S31, S0, V2.S[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S31, S0, V2.S[0]");
        TestInst(FMUL(S1, S2, V0.S[1]), asm => asm.FMUL(S1, S2, V0.S[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S1, S2, V0.S[1]");
        TestInst(FMUL(S31, S2, V0.S[1]), asm => asm.FMUL(S31, S2, V0.S[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S31, S2, V0.S[1]");
        TestInst(FMUL(S1, S0, V0.S[1]), asm => asm.FMUL(S1, S0, V0.S[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S1, S0, V0.S[1]");
        TestInst(FMUL(S31, S0, V0.S[1]), asm => asm.FMUL(S31, S0, V0.S[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL S31, S0, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asisdelem_r_sd_2()
    {
        TestInst(FMUL(D1, D2, V2.D[0]), asm => asm.FMUL(D1, D2, V2.D[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D1, D2, V2.D[0]");
        TestInst(FMUL(D31, D2, V2.D[0]), asm => asm.FMUL(D31, D2, V2.D[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D31, D2, V2.D[0]");
        TestInst(FMUL(D1, D0, V2.D[0]), asm => asm.FMUL(D1, D0, V2.D[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D1, D0, V2.D[0]");
        TestInst(FMUL(D31, D0, V2.D[0]), asm => asm.FMUL(D31, D0, V2.D[0]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D31, D0, V2.D[0]");
        TestInst(FMUL(D1, D2, V0.D[1]), asm => asm.FMUL(D1, D2, V0.D[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D1, D2, V0.D[1]");
        TestInst(FMUL(D31, D2, V0.D[1]), asm => asm.FMUL(D31, D2, V0.D[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D31, D2, V0.D[1]");
        TestInst(FMUL(D1, D0, V0.D[1]), asm => asm.FMUL(D1, D0, V0.D[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D1, D0, V0.D[1]");
        TestInst(FMUL(D31, D0, V0.D[1]), asm => asm.FMUL(D31, D0, V0.D[1]), Arm64InstructionId.FMUL_asisdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL D31, D0, V0.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdelem_rh_h_3()
    {
        TestInst(FMUL(V0.T_4H, V1.T_4H, V2.H[1]), asm => asm.FMUL(V0.T_4H, V1.T_4H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.4H, V1.4H, V2.H[1]");
        TestInst(FMUL(V30.T_4H, V1.T_4H, V2.H[1]), asm => asm.FMUL(V30.T_4H, V1.T_4H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.4H, V1.4H, V2.H[1]");
        TestInst(FMUL(V0.T_4H, V31.T_4H, V2.H[1]), asm => asm.FMUL(V0.T_4H, V31.T_4H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.4H, V31.4H, V2.H[1]");
        TestInst(FMUL(V30.T_4H, V31.T_4H, V2.H[1]), asm => asm.FMUL(V30.T_4H, V31.T_4H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.4H, V31.4H, V2.H[1]");
        TestInst(FMUL(V0.T_4H, V1.T_4H, V0.H[1]), asm => asm.FMUL(V0.T_4H, V1.T_4H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.4H, V1.4H, V0.H[1]");
        TestInst(FMUL(V30.T_4H, V1.T_4H, V0.H[1]), asm => asm.FMUL(V30.T_4H, V1.T_4H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.4H, V1.4H, V0.H[1]");
        TestInst(FMUL(V0.T_4H, V31.T_4H, V0.H[1]), asm => asm.FMUL(V0.T_4H, V31.T_4H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.4H, V31.4H, V0.H[1]");
        TestInst(FMUL(V30.T_4H, V31.T_4H, V0.H[1]), asm => asm.FMUL(V30.T_4H, V31.T_4H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.4H, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdelem_rh_h_4()
    {
        TestInst(FMUL(V0.T_8H, V1.T_8H, V2.H[1]), asm => asm.FMUL(V0.T_8H, V1.T_8H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.8H, V1.8H, V2.H[1]");
        TestInst(FMUL(V30.T_8H, V1.T_8H, V2.H[1]), asm => asm.FMUL(V30.T_8H, V1.T_8H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.8H, V1.8H, V2.H[1]");
        TestInst(FMUL(V0.T_8H, V31.T_8H, V2.H[1]), asm => asm.FMUL(V0.T_8H, V31.T_8H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.8H, V31.8H, V2.H[1]");
        TestInst(FMUL(V30.T_8H, V31.T_8H, V2.H[1]), asm => asm.FMUL(V30.T_8H, V31.T_8H, V2.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.8H, V31.8H, V2.H[1]");
        TestInst(FMUL(V0.T_8H, V1.T_8H, V0.H[1]), asm => asm.FMUL(V0.T_8H, V1.T_8H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.8H, V1.8H, V0.H[1]");
        TestInst(FMUL(V30.T_8H, V1.T_8H, V0.H[1]), asm => asm.FMUL(V30.T_8H, V1.T_8H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.8H, V1.8H, V0.H[1]");
        TestInst(FMUL(V0.T_8H, V31.T_8H, V0.H[1]), asm => asm.FMUL(V0.T_8H, V31.T_8H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V0.8H, V31.8H, V0.H[1]");
        TestInst(FMUL(V30.T_8H, V31.T_8H, V0.H[1]), asm => asm.FMUL(V30.T_8H, V31.T_8H, V0.H[1]), Arm64InstructionId.FMUL_asimdelem_rh_h, Arm64Mnemonic.FMUL, "FMUL V30.8H, V31.8H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdelem_r_sd_5()
    {
        TestInst(FMUL(V0.T_2S, V1.T_2S, V2.S[0]), asm => asm.FMUL(V0.T_2S, V1.T_2S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2S, V1.2S, V2.S[0]");
        TestInst(FMUL(V30.T_2S, V1.T_2S, V2.S[0]), asm => asm.FMUL(V30.T_2S, V1.T_2S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2S, V1.2S, V2.S[0]");
        TestInst(FMUL(V0.T_2S, V31.T_2S, V2.S[0]), asm => asm.FMUL(V0.T_2S, V31.T_2S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2S, V31.2S, V2.S[0]");
        TestInst(FMUL(V30.T_2S, V31.T_2S, V2.S[0]), asm => asm.FMUL(V30.T_2S, V31.T_2S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2S, V31.2S, V2.S[0]");
        TestInst(FMUL(V0.T_2S, V1.T_2S, V0.S[1]), asm => asm.FMUL(V0.T_2S, V1.T_2S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2S, V1.2S, V0.S[1]");
        TestInst(FMUL(V30.T_2S, V1.T_2S, V0.S[1]), asm => asm.FMUL(V30.T_2S, V1.T_2S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2S, V1.2S, V0.S[1]");
        TestInst(FMUL(V0.T_2S, V31.T_2S, V0.S[1]), asm => asm.FMUL(V0.T_2S, V31.T_2S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2S, V31.2S, V0.S[1]");
        TestInst(FMUL(V30.T_2S, V31.T_2S, V0.S[1]), asm => asm.FMUL(V30.T_2S, V31.T_2S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2S, V31.2S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdelem_r_sd_6()
    {
        TestInst(FMUL(V0.T_4S, V1.T_4S, V2.S[0]), asm => asm.FMUL(V0.T_4S, V1.T_4S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.4S, V1.4S, V2.S[0]");
        TestInst(FMUL(V30.T_4S, V1.T_4S, V2.S[0]), asm => asm.FMUL(V30.T_4S, V1.T_4S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.4S, V1.4S, V2.S[0]");
        TestInst(FMUL(V0.T_4S, V31.T_4S, V2.S[0]), asm => asm.FMUL(V0.T_4S, V31.T_4S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.4S, V31.4S, V2.S[0]");
        TestInst(FMUL(V30.T_4S, V31.T_4S, V2.S[0]), asm => asm.FMUL(V30.T_4S, V31.T_4S, V2.S[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.4S, V31.4S, V2.S[0]");
        TestInst(FMUL(V0.T_4S, V1.T_4S, V0.S[1]), asm => asm.FMUL(V0.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.4S, V1.4S, V0.S[1]");
        TestInst(FMUL(V30.T_4S, V1.T_4S, V0.S[1]), asm => asm.FMUL(V30.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.4S, V1.4S, V0.S[1]");
        TestInst(FMUL(V0.T_4S, V31.T_4S, V0.S[1]), asm => asm.FMUL(V0.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.4S, V31.4S, V0.S[1]");
        TestInst(FMUL(V30.T_4S, V31.T_4S, V0.S[1]), asm => asm.FMUL(V30.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.4S, V31.4S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdelem_r_sd_7()
    {
        TestInst(FMUL(V0.T_2D, V1.T_2D, V2.D[0]), asm => asm.FMUL(V0.T_2D, V1.T_2D, V2.D[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2D, V1.2D, V2.D[0]");
        TestInst(FMUL(V30.T_2D, V1.T_2D, V2.D[0]), asm => asm.FMUL(V30.T_2D, V1.T_2D, V2.D[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2D, V1.2D, V2.D[0]");
        TestInst(FMUL(V0.T_2D, V31.T_2D, V2.D[0]), asm => asm.FMUL(V0.T_2D, V31.T_2D, V2.D[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2D, V31.2D, V2.D[0]");
        TestInst(FMUL(V30.T_2D, V31.T_2D, V2.D[0]), asm => asm.FMUL(V30.T_2D, V31.T_2D, V2.D[0]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2D, V31.2D, V2.D[0]");
        TestInst(FMUL(V0.T_2D, V1.T_2D, V0.D[1]), asm => asm.FMUL(V0.T_2D, V1.T_2D, V0.D[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2D, V1.2D, V0.D[1]");
        TestInst(FMUL(V30.T_2D, V1.T_2D, V0.D[1]), asm => asm.FMUL(V30.T_2D, V1.T_2D, V0.D[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2D, V1.2D, V0.D[1]");
        TestInst(FMUL(V0.T_2D, V31.T_2D, V0.D[1]), asm => asm.FMUL(V0.T_2D, V31.T_2D, V0.D[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V0.2D, V31.2D, V0.D[1]");
        TestInst(FMUL(V30.T_2D, V31.T_2D, V0.D[1]), asm => asm.FMUL(V30.T_2D, V31.T_2D, V0.D[1]), Arm64InstructionId.FMUL_asimdelem_r_sd, Arm64Mnemonic.FMUL, "FMUL V30.2D, V31.2D, V0.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdsamefp16_only_8()
    {
        TestInst(FMUL(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.FMUL(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.4H, V1.4H, V2.4H");
        TestInst(FMUL(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.FMUL(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.4H, V1.4H, V2.4H");
        TestInst(FMUL(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.FMUL(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.4H, V31.4H, V2.4H");
        TestInst(FMUL(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.FMUL(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.4H, V31.4H, V2.4H");
        TestInst(FMUL(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.FMUL(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.4H, V1.4H, V0.4H");
        TestInst(FMUL(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.FMUL(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.4H, V1.4H, V0.4H");
        TestInst(FMUL(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.FMUL(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.4H, V31.4H, V0.4H");
        TestInst(FMUL(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.FMUL(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdsamefp16_only_9()
    {
        TestInst(FMUL(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.FMUL(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.8H, V1.8H, V2.8H");
        TestInst(FMUL(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.FMUL(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.8H, V1.8H, V2.8H");
        TestInst(FMUL(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.FMUL(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.8H, V31.8H, V2.8H");
        TestInst(FMUL(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.FMUL(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.8H, V31.8H, V2.8H");
        TestInst(FMUL(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.FMUL(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.8H, V1.8H, V0.8H");
        TestInst(FMUL(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.FMUL(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.8H, V1.8H, V0.8H");
        TestInst(FMUL(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.FMUL(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V0.8H, V31.8H, V0.8H");
        TestInst(FMUL(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.FMUL(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMUL_asimdsamefp16_only, Arm64Mnemonic.FMUL, "FMUL V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdsame_only_10()
    {
        TestInst(FMUL(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.FMUL(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2S, V1.2S, V2.2S");
        TestInst(FMUL(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.FMUL(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2S, V1.2S, V2.2S");
        TestInst(FMUL(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.FMUL(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2S, V31.2S, V2.2S");
        TestInst(FMUL(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.FMUL(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2S, V31.2S, V2.2S");
        TestInst(FMUL(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.FMUL(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2S, V1.2S, V0.2S");
        TestInst(FMUL(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.FMUL(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2S, V1.2S, V0.2S");
        TestInst(FMUL(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.FMUL(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2S, V31.2S, V0.2S");
        TestInst(FMUL(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.FMUL(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdsame_only_11()
    {
        TestInst(FMUL(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.FMUL(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.4S, V1.4S, V2.4S");
        TestInst(FMUL(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.FMUL(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.4S, V1.4S, V2.4S");
        TestInst(FMUL(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.FMUL(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.4S, V31.4S, V2.4S");
        TestInst(FMUL(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.FMUL(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.4S, V31.4S, V2.4S");
        TestInst(FMUL(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.FMUL(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.4S, V1.4S, V0.4S");
        TestInst(FMUL(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.FMUL(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.4S, V1.4S, V0.4S");
        TestInst(FMUL(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.FMUL(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.4S, V31.4S, V0.4S");
        TestInst(FMUL(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.FMUL(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMUL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMUL_asimdsame_only_12()
    {
        TestInst(FMUL(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.FMUL(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2D, V1.2D, V2.2D");
        TestInst(FMUL(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.FMUL(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2D, V1.2D, V2.2D");
        TestInst(FMUL(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.FMUL(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2D, V31.2D, V2.2D");
        TestInst(FMUL(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.FMUL(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2D, V31.2D, V2.2D");
        TestInst(FMUL(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.FMUL(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2D, V1.2D, V0.2D");
        TestInst(FMUL(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.FMUL(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2D, V1.2D, V0.2D");
        TestInst(FMUL(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.FMUL(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V0.2D, V31.2D, V0.2D");
        TestInst(FMUL(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.FMUL(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMUL_asimdsame_only, Arm64Mnemonic.FMUL, "FMUL V30.2D, V31.2D, V0.2D");
    }
}
