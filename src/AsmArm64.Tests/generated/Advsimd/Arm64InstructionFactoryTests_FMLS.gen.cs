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
public class Arm64InstructionFactoryTests_FMLS_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asisdelem_rh_h_0()
    {
        TestInst(FMLS(H0, H1, V2.H[1]), asm => asm.FMLS(H0, H1, V2.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H0, H1, V2.H[1]");
        TestInst(FMLS(H31, H1, V2.H[1]), asm => asm.FMLS(H31, H1, V2.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H31, H1, V2.H[1]");
        TestInst(FMLS(H0, H31, V2.H[1]), asm => asm.FMLS(H0, H31, V2.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H0, H31, V2.H[1]");
        TestInst(FMLS(H31, H31, V2.H[1]), asm => asm.FMLS(H31, H31, V2.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H31, H31, V2.H[1]");
        TestInst(FMLS(H0, H1, V0.H[1]), asm => asm.FMLS(H0, H1, V0.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H0, H1, V0.H[1]");
        TestInst(FMLS(H31, H1, V0.H[1]), asm => asm.FMLS(H31, H1, V0.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H31, H1, V0.H[1]");
        TestInst(FMLS(H0, H31, V0.H[1]), asm => asm.FMLS(H0, H31, V0.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H0, H31, V0.H[1]");
        TestInst(FMLS(H31, H31, V0.H[1]), asm => asm.FMLS(H31, H31, V0.H[1]), Arm64InstructionId.FMLS_asisdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS H31, H31, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asisdelem_r_sd_1()
    {
        TestInst(FMLS(S1, S2, V2.S[0]), asm => asm.FMLS(S1, S2, V2.S[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S1, S2, V2.S[0]");
        TestInst(FMLS(S31, S2, V2.S[0]), asm => asm.FMLS(S31, S2, V2.S[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S31, S2, V2.S[0]");
        TestInst(FMLS(S1, S0, V2.S[0]), asm => asm.FMLS(S1, S0, V2.S[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S1, S0, V2.S[0]");
        TestInst(FMLS(S31, S0, V2.S[0]), asm => asm.FMLS(S31, S0, V2.S[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S31, S0, V2.S[0]");
        TestInst(FMLS(S1, S2, V0.S[1]), asm => asm.FMLS(S1, S2, V0.S[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S1, S2, V0.S[1]");
        TestInst(FMLS(S31, S2, V0.S[1]), asm => asm.FMLS(S31, S2, V0.S[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S31, S2, V0.S[1]");
        TestInst(FMLS(S1, S0, V0.S[1]), asm => asm.FMLS(S1, S0, V0.S[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S1, S0, V0.S[1]");
        TestInst(FMLS(S31, S0, V0.S[1]), asm => asm.FMLS(S31, S0, V0.S[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS S31, S0, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asisdelem_r_sd_2()
    {
        TestInst(FMLS(D1, D2, V2.D[0]), asm => asm.FMLS(D1, D2, V2.D[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D1, D2, V2.D[0]");
        TestInst(FMLS(D31, D2, V2.D[0]), asm => asm.FMLS(D31, D2, V2.D[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D31, D2, V2.D[0]");
        TestInst(FMLS(D1, D0, V2.D[0]), asm => asm.FMLS(D1, D0, V2.D[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D1, D0, V2.D[0]");
        TestInst(FMLS(D31, D0, V2.D[0]), asm => asm.FMLS(D31, D0, V2.D[0]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D31, D0, V2.D[0]");
        TestInst(FMLS(D1, D2, V0.D[1]), asm => asm.FMLS(D1, D2, V0.D[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D1, D2, V0.D[1]");
        TestInst(FMLS(D31, D2, V0.D[1]), asm => asm.FMLS(D31, D2, V0.D[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D31, D2, V0.D[1]");
        TestInst(FMLS(D1, D0, V0.D[1]), asm => asm.FMLS(D1, D0, V0.D[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D1, D0, V0.D[1]");
        TestInst(FMLS(D31, D0, V0.D[1]), asm => asm.FMLS(D31, D0, V0.D[1]), Arm64InstructionId.FMLS_asisdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS D31, D0, V0.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdelem_rh_h_3()
    {
        TestInst(FMLS(V0.T_4H, V1.T_4H, V2.H[1]), asm => asm.FMLS(V0.T_4H, V1.T_4H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.4H, V1.4H, V2.H[1]");
        TestInst(FMLS(V30.T_4H, V1.T_4H, V2.H[1]), asm => asm.FMLS(V30.T_4H, V1.T_4H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.4H, V1.4H, V2.H[1]");
        TestInst(FMLS(V0.T_4H, V31.T_4H, V2.H[1]), asm => asm.FMLS(V0.T_4H, V31.T_4H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.4H, V31.4H, V2.H[1]");
        TestInst(FMLS(V30.T_4H, V31.T_4H, V2.H[1]), asm => asm.FMLS(V30.T_4H, V31.T_4H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.4H, V31.4H, V2.H[1]");
        TestInst(FMLS(V0.T_4H, V1.T_4H, V0.H[1]), asm => asm.FMLS(V0.T_4H, V1.T_4H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.4H, V1.4H, V0.H[1]");
        TestInst(FMLS(V30.T_4H, V1.T_4H, V0.H[1]), asm => asm.FMLS(V30.T_4H, V1.T_4H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.4H, V1.4H, V0.H[1]");
        TestInst(FMLS(V0.T_4H, V31.T_4H, V0.H[1]), asm => asm.FMLS(V0.T_4H, V31.T_4H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.4H, V31.4H, V0.H[1]");
        TestInst(FMLS(V30.T_4H, V31.T_4H, V0.H[1]), asm => asm.FMLS(V30.T_4H, V31.T_4H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.4H, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdelem_rh_h_4()
    {
        TestInst(FMLS(V0.T_8H, V1.T_8H, V2.H[1]), asm => asm.FMLS(V0.T_8H, V1.T_8H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.8H, V1.8H, V2.H[1]");
        TestInst(FMLS(V30.T_8H, V1.T_8H, V2.H[1]), asm => asm.FMLS(V30.T_8H, V1.T_8H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.8H, V1.8H, V2.H[1]");
        TestInst(FMLS(V0.T_8H, V31.T_8H, V2.H[1]), asm => asm.FMLS(V0.T_8H, V31.T_8H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.8H, V31.8H, V2.H[1]");
        TestInst(FMLS(V30.T_8H, V31.T_8H, V2.H[1]), asm => asm.FMLS(V30.T_8H, V31.T_8H, V2.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.8H, V31.8H, V2.H[1]");
        TestInst(FMLS(V0.T_8H, V1.T_8H, V0.H[1]), asm => asm.FMLS(V0.T_8H, V1.T_8H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.8H, V1.8H, V0.H[1]");
        TestInst(FMLS(V30.T_8H, V1.T_8H, V0.H[1]), asm => asm.FMLS(V30.T_8H, V1.T_8H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.8H, V1.8H, V0.H[1]");
        TestInst(FMLS(V0.T_8H, V31.T_8H, V0.H[1]), asm => asm.FMLS(V0.T_8H, V31.T_8H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V0.8H, V31.8H, V0.H[1]");
        TestInst(FMLS(V30.T_8H, V31.T_8H, V0.H[1]), asm => asm.FMLS(V30.T_8H, V31.T_8H, V0.H[1]), Arm64InstructionId.FMLS_asimdelem_rh_h, Arm64Mnemonic.FMLS, "FMLS V30.8H, V31.8H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdelem_r_sd_5()
    {
        TestInst(FMLS(V0.T_2S, V1.T_2S, V2.S[0]), asm => asm.FMLS(V0.T_2S, V1.T_2S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2S, V1.2S, V2.S[0]");
        TestInst(FMLS(V30.T_2S, V1.T_2S, V2.S[0]), asm => asm.FMLS(V30.T_2S, V1.T_2S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2S, V1.2S, V2.S[0]");
        TestInst(FMLS(V0.T_2S, V31.T_2S, V2.S[0]), asm => asm.FMLS(V0.T_2S, V31.T_2S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2S, V31.2S, V2.S[0]");
        TestInst(FMLS(V30.T_2S, V31.T_2S, V2.S[0]), asm => asm.FMLS(V30.T_2S, V31.T_2S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2S, V31.2S, V2.S[0]");
        TestInst(FMLS(V0.T_2S, V1.T_2S, V0.S[1]), asm => asm.FMLS(V0.T_2S, V1.T_2S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2S, V1.2S, V0.S[1]");
        TestInst(FMLS(V30.T_2S, V1.T_2S, V0.S[1]), asm => asm.FMLS(V30.T_2S, V1.T_2S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2S, V1.2S, V0.S[1]");
        TestInst(FMLS(V0.T_2S, V31.T_2S, V0.S[1]), asm => asm.FMLS(V0.T_2S, V31.T_2S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2S, V31.2S, V0.S[1]");
        TestInst(FMLS(V30.T_2S, V31.T_2S, V0.S[1]), asm => asm.FMLS(V30.T_2S, V31.T_2S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2S, V31.2S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdelem_r_sd_6()
    {
        TestInst(FMLS(V0.T_4S, V1.T_4S, V2.S[0]), asm => asm.FMLS(V0.T_4S, V1.T_4S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.4S, V1.4S, V2.S[0]");
        TestInst(FMLS(V30.T_4S, V1.T_4S, V2.S[0]), asm => asm.FMLS(V30.T_4S, V1.T_4S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.4S, V1.4S, V2.S[0]");
        TestInst(FMLS(V0.T_4S, V31.T_4S, V2.S[0]), asm => asm.FMLS(V0.T_4S, V31.T_4S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.4S, V31.4S, V2.S[0]");
        TestInst(FMLS(V30.T_4S, V31.T_4S, V2.S[0]), asm => asm.FMLS(V30.T_4S, V31.T_4S, V2.S[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.4S, V31.4S, V2.S[0]");
        TestInst(FMLS(V0.T_4S, V1.T_4S, V0.S[1]), asm => asm.FMLS(V0.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.4S, V1.4S, V0.S[1]");
        TestInst(FMLS(V30.T_4S, V1.T_4S, V0.S[1]), asm => asm.FMLS(V30.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.4S, V1.4S, V0.S[1]");
        TestInst(FMLS(V0.T_4S, V31.T_4S, V0.S[1]), asm => asm.FMLS(V0.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.4S, V31.4S, V0.S[1]");
        TestInst(FMLS(V30.T_4S, V31.T_4S, V0.S[1]), asm => asm.FMLS(V30.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.4S, V31.4S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdelem_r_sd_7()
    {
        TestInst(FMLS(V0.T_2D, V1.T_2D, V2.D[0]), asm => asm.FMLS(V0.T_2D, V1.T_2D, V2.D[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2D, V1.2D, V2.D[0]");
        TestInst(FMLS(V30.T_2D, V1.T_2D, V2.D[0]), asm => asm.FMLS(V30.T_2D, V1.T_2D, V2.D[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2D, V1.2D, V2.D[0]");
        TestInst(FMLS(V0.T_2D, V31.T_2D, V2.D[0]), asm => asm.FMLS(V0.T_2D, V31.T_2D, V2.D[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2D, V31.2D, V2.D[0]");
        TestInst(FMLS(V30.T_2D, V31.T_2D, V2.D[0]), asm => asm.FMLS(V30.T_2D, V31.T_2D, V2.D[0]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2D, V31.2D, V2.D[0]");
        TestInst(FMLS(V0.T_2D, V1.T_2D, V0.D[1]), asm => asm.FMLS(V0.T_2D, V1.T_2D, V0.D[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2D, V1.2D, V0.D[1]");
        TestInst(FMLS(V30.T_2D, V1.T_2D, V0.D[1]), asm => asm.FMLS(V30.T_2D, V1.T_2D, V0.D[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2D, V1.2D, V0.D[1]");
        TestInst(FMLS(V0.T_2D, V31.T_2D, V0.D[1]), asm => asm.FMLS(V0.T_2D, V31.T_2D, V0.D[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V0.2D, V31.2D, V0.D[1]");
        TestInst(FMLS(V30.T_2D, V31.T_2D, V0.D[1]), asm => asm.FMLS(V30.T_2D, V31.T_2D, V0.D[1]), Arm64InstructionId.FMLS_asimdelem_r_sd, Arm64Mnemonic.FMLS, "FMLS V30.2D, V31.2D, V0.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdsamefp16_only_8()
    {
        TestInst(FMLS(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.FMLS(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.4H, V1.4H, V2.4H");
        TestInst(FMLS(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.FMLS(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.4H, V1.4H, V2.4H");
        TestInst(FMLS(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.FMLS(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.4H, V31.4H, V2.4H");
        TestInst(FMLS(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.FMLS(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.4H, V31.4H, V2.4H");
        TestInst(FMLS(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.FMLS(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.4H, V1.4H, V0.4H");
        TestInst(FMLS(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.FMLS(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.4H, V1.4H, V0.4H");
        TestInst(FMLS(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.FMLS(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.4H, V31.4H, V0.4H");
        TestInst(FMLS(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.FMLS(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdsamefp16_only_9()
    {
        TestInst(FMLS(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.FMLS(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.8H, V1.8H, V2.8H");
        TestInst(FMLS(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.FMLS(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.8H, V1.8H, V2.8H");
        TestInst(FMLS(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.FMLS(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.8H, V31.8H, V2.8H");
        TestInst(FMLS(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.FMLS(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.8H, V31.8H, V2.8H");
        TestInst(FMLS(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.FMLS(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.8H, V1.8H, V0.8H");
        TestInst(FMLS(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.FMLS(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.8H, V1.8H, V0.8H");
        TestInst(FMLS(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.FMLS(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V0.8H, V31.8H, V0.8H");
        TestInst(FMLS(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.FMLS(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMLS_asimdsamefp16_only, Arm64Mnemonic.FMLS, "FMLS V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdsame_only_10()
    {
        TestInst(FMLS(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.FMLS(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2S, V1.2S, V2.2S");
        TestInst(FMLS(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.FMLS(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2S, V1.2S, V2.2S");
        TestInst(FMLS(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.FMLS(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2S, V31.2S, V2.2S");
        TestInst(FMLS(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.FMLS(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2S, V31.2S, V2.2S");
        TestInst(FMLS(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.FMLS(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2S, V1.2S, V0.2S");
        TestInst(FMLS(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.FMLS(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2S, V1.2S, V0.2S");
        TestInst(FMLS(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.FMLS(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2S, V31.2S, V0.2S");
        TestInst(FMLS(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.FMLS(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdsame_only_11()
    {
        TestInst(FMLS(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.FMLS(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.4S, V1.4S, V2.4S");
        TestInst(FMLS(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.FMLS(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.4S, V1.4S, V2.4S");
        TestInst(FMLS(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.FMLS(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.4S, V31.4S, V2.4S");
        TestInst(FMLS(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.FMLS(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.4S, V31.4S, V2.4S");
        TestInst(FMLS(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.FMLS(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.4S, V1.4S, V0.4S");
        TestInst(FMLS(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.FMLS(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.4S, V1.4S, V0.4S");
        TestInst(FMLS(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.FMLS(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.4S, V31.4S, V0.4S");
        TestInst(FMLS(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.FMLS(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLS_asimdsame_only_12()
    {
        TestInst(FMLS(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.FMLS(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2D, V1.2D, V2.2D");
        TestInst(FMLS(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.FMLS(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2D, V1.2D, V2.2D");
        TestInst(FMLS(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.FMLS(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2D, V31.2D, V2.2D");
        TestInst(FMLS(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.FMLS(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2D, V31.2D, V2.2D");
        TestInst(FMLS(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.FMLS(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2D, V1.2D, V0.2D");
        TestInst(FMLS(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.FMLS(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2D, V1.2D, V0.2D");
        TestInst(FMLS(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.FMLS(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V0.2D, V31.2D, V0.2D");
        TestInst(FMLS(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.FMLS(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMLS_asimdsame_only, Arm64Mnemonic.FMLS, "FMLS V30.2D, V31.2D, V0.2D");
    }
}
