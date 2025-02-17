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
public class Arm64InstructionFactoryTests_SCVTF_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asisdshf_c_0()
    {
        TestInst(SCVTF(H1, H2, 5), asm => asm.SCVTF(H1, H2, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF H1, H2, #5");
        TestInst(SCVTF(H31, H2, 5), asm => asm.SCVTF(H31, H2, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF H31, H2, #5");
        TestInst(SCVTF(H1, H0, 5), asm => asm.SCVTF(H1, H0, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF H1, H0, #5");
        TestInst(SCVTF(H31, H0, 5), asm => asm.SCVTF(H31, H0, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF H31, H0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asisdshf_c_1()
    {
        TestInst(SCVTF(S1, S2, 5), asm => asm.SCVTF(S1, S2, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF S1, S2, #5");
        TestInst(SCVTF(S31, S2, 5), asm => asm.SCVTF(S31, S2, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF S31, S2, #5");
        TestInst(SCVTF(S1, S0, 5), asm => asm.SCVTF(S1, S0, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF S1, S0, #5");
        TestInst(SCVTF(S31, S0, 5), asm => asm.SCVTF(S31, S0, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF S31, S0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asisdshf_c_2()
    {
        TestInst(SCVTF(D1, D2, 5), asm => asm.SCVTF(D1, D2, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF D1, D2, #5");
        TestInst(SCVTF(D31, D2, 5), asm => asm.SCVTF(D31, D2, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF D31, D2, #5");
        TestInst(SCVTF(D1, D0, 5), asm => asm.SCVTF(D1, D0, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF D1, D0, #5");
        TestInst(SCVTF(D31, D0, 5), asm => asm.SCVTF(D31, D0, 5), Arm64InstructionId.SCVTF_asisdshf_c, Arm64Mnemonic.SCVTF, "SCVTF D31, D0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdshf_c_3()
    {
        TestInst(SCVTF(V0.T_4H, V1.T_4H, 5), asm => asm.SCVTF(V0.T_4H, V1.T_4H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.4H, V1.4H, #5");
        TestInst(SCVTF(V30.T_4H, V1.T_4H, 5), asm => asm.SCVTF(V30.T_4H, V1.T_4H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.4H, V1.4H, #5");
        TestInst(SCVTF(V0.T_4H, V31.T_4H, 5), asm => asm.SCVTF(V0.T_4H, V31.T_4H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.4H, V31.4H, #5");
        TestInst(SCVTF(V30.T_4H, V31.T_4H, 5), asm => asm.SCVTF(V30.T_4H, V31.T_4H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.4H, V31.4H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdshf_c_4()
    {
        TestInst(SCVTF(V0.T_8H, V1.T_8H, 5), asm => asm.SCVTF(V0.T_8H, V1.T_8H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.8H, V1.8H, #5");
        TestInst(SCVTF(V30.T_8H, V1.T_8H, 5), asm => asm.SCVTF(V30.T_8H, V1.T_8H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.8H, V1.8H, #5");
        TestInst(SCVTF(V0.T_8H, V31.T_8H, 5), asm => asm.SCVTF(V0.T_8H, V31.T_8H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.8H, V31.8H, #5");
        TestInst(SCVTF(V30.T_8H, V31.T_8H, 5), asm => asm.SCVTF(V30.T_8H, V31.T_8H, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.8H, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdshf_c_5()
    {
        TestInst(SCVTF(V0.T_2S, V1.T_2S, 5), asm => asm.SCVTF(V0.T_2S, V1.T_2S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.2S, V1.2S, #5");
        TestInst(SCVTF(V30.T_2S, V1.T_2S, 5), asm => asm.SCVTF(V30.T_2S, V1.T_2S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.2S, V1.2S, #5");
        TestInst(SCVTF(V0.T_2S, V31.T_2S, 5), asm => asm.SCVTF(V0.T_2S, V31.T_2S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.2S, V31.2S, #5");
        TestInst(SCVTF(V30.T_2S, V31.T_2S, 5), asm => asm.SCVTF(V30.T_2S, V31.T_2S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.2S, V31.2S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdshf_c_6()
    {
        TestInst(SCVTF(V0.T_4S, V1.T_4S, 5), asm => asm.SCVTF(V0.T_4S, V1.T_4S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.4S, V1.4S, #5");
        TestInst(SCVTF(V30.T_4S, V1.T_4S, 5), asm => asm.SCVTF(V30.T_4S, V1.T_4S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.4S, V1.4S, #5");
        TestInst(SCVTF(V0.T_4S, V31.T_4S, 5), asm => asm.SCVTF(V0.T_4S, V31.T_4S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.4S, V31.4S, #5");
        TestInst(SCVTF(V30.T_4S, V31.T_4S, 5), asm => asm.SCVTF(V30.T_4S, V31.T_4S, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.4S, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdshf_c_7()
    {
        TestInst(SCVTF(V0.T_2D, V1.T_2D, 5), asm => asm.SCVTF(V0.T_2D, V1.T_2D, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.2D, V1.2D, #5");
        TestInst(SCVTF(V30.T_2D, V1.T_2D, 5), asm => asm.SCVTF(V30.T_2D, V1.T_2D, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.2D, V1.2D, #5");
        TestInst(SCVTF(V0.T_2D, V31.T_2D, 5), asm => asm.SCVTF(V0.T_2D, V31.T_2D, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V0.2D, V31.2D, #5");
        TestInst(SCVTF(V30.T_2D, V31.T_2D, 5), asm => asm.SCVTF(V30.T_2D, V31.T_2D, 5), Arm64InstructionId.SCVTF_asimdshf_c, Arm64Mnemonic.SCVTF, "SCVTF V30.2D, V31.2D, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asisdmiscfp16_r_8()
    {
        TestInst(SCVTF(H0, H1), asm => asm.SCVTF(H0, H1), Arm64InstructionId.SCVTF_asisdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF H0, H1");
        TestInst(SCVTF(H31, H1), asm => asm.SCVTF(H31, H1), Arm64InstructionId.SCVTF_asisdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF H31, H1");
        TestInst(SCVTF(H0, H31), asm => asm.SCVTF(H0, H31), Arm64InstructionId.SCVTF_asisdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF H0, H31");
        TestInst(SCVTF(H31, H31), asm => asm.SCVTF(H31, H31), Arm64InstructionId.SCVTF_asisdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asisdmisc_r_9()
    {
        TestInst(SCVTF(S1, S2), asm => asm.SCVTF(S1, S2), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF S1, S2");
        TestInst(SCVTF(S31, S2), asm => asm.SCVTF(S31, S2), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF S31, S2");
        TestInst(SCVTF(S1, S0), asm => asm.SCVTF(S1, S0), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF S1, S0");
        TestInst(SCVTF(S31, S0), asm => asm.SCVTF(S31, S0), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asisdmisc_r_10()
    {
        TestInst(SCVTF(D1, D2), asm => asm.SCVTF(D1, D2), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF D1, D2");
        TestInst(SCVTF(D31, D2), asm => asm.SCVTF(D31, D2), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF D31, D2");
        TestInst(SCVTF(D1, D0), asm => asm.SCVTF(D1, D0), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF D1, D0");
        TestInst(SCVTF(D31, D0), asm => asm.SCVTF(D31, D0), Arm64InstructionId.SCVTF_asisdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF D31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdmiscfp16_r_11()
    {
        TestInst(SCVTF(V0.T_4H, V1.T_4H), asm => asm.SCVTF(V0.T_4H, V1.T_4H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V0.4H, V1.4H");
        TestInst(SCVTF(V30.T_4H, V1.T_4H), asm => asm.SCVTF(V30.T_4H, V1.T_4H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V30.4H, V1.4H");
        TestInst(SCVTF(V0.T_4H, V31.T_4H), asm => asm.SCVTF(V0.T_4H, V31.T_4H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V0.4H, V31.4H");
        TestInst(SCVTF(V30.T_4H, V31.T_4H), asm => asm.SCVTF(V30.T_4H, V31.T_4H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdmiscfp16_r_12()
    {
        TestInst(SCVTF(V0.T_8H, V1.T_8H), asm => asm.SCVTF(V0.T_8H, V1.T_8H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V0.8H, V1.8H");
        TestInst(SCVTF(V30.T_8H, V1.T_8H), asm => asm.SCVTF(V30.T_8H, V1.T_8H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V30.8H, V1.8H");
        TestInst(SCVTF(V0.T_8H, V31.T_8H), asm => asm.SCVTF(V0.T_8H, V31.T_8H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V0.8H, V31.8H");
        TestInst(SCVTF(V30.T_8H, V31.T_8H), asm => asm.SCVTF(V30.T_8H, V31.T_8H), Arm64InstructionId.SCVTF_asimdmiscfp16_r, Arm64Mnemonic.SCVTF, "SCVTF V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdmisc_r_13()
    {
        TestInst(SCVTF(V0.T_2S, V1.T_2S), asm => asm.SCVTF(V0.T_2S, V1.T_2S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V0.2S, V1.2S");
        TestInst(SCVTF(V30.T_2S, V1.T_2S), asm => asm.SCVTF(V30.T_2S, V1.T_2S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V30.2S, V1.2S");
        TestInst(SCVTF(V0.T_2S, V31.T_2S), asm => asm.SCVTF(V0.T_2S, V31.T_2S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V0.2S, V31.2S");
        TestInst(SCVTF(V30.T_2S, V31.T_2S), asm => asm.SCVTF(V30.T_2S, V31.T_2S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdmisc_r_14()
    {
        TestInst(SCVTF(V0.T_4S, V1.T_4S), asm => asm.SCVTF(V0.T_4S, V1.T_4S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V0.4S, V1.4S");
        TestInst(SCVTF(V30.T_4S, V1.T_4S), asm => asm.SCVTF(V30.T_4S, V1.T_4S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V30.4S, V1.4S");
        TestInst(SCVTF(V0.T_4S, V31.T_4S), asm => asm.SCVTF(V0.T_4S, V31.T_4S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V0.4S, V31.4S");
        TestInst(SCVTF(V30.T_4S, V31.T_4S), asm => asm.SCVTF(V30.T_4S, V31.T_4S), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_SCVTF_asimdmisc_r_15()
    {
        TestInst(SCVTF(V0.T_2D, V1.T_2D), asm => asm.SCVTF(V0.T_2D, V1.T_2D), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V0.2D, V1.2D");
        TestInst(SCVTF(V30.T_2D, V1.T_2D), asm => asm.SCVTF(V30.T_2D, V1.T_2D), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V30.2D, V1.2D");
        TestInst(SCVTF(V0.T_2D, V31.T_2D), asm => asm.SCVTF(V0.T_2D, V31.T_2D), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V0.2D, V31.2D");
        TestInst(SCVTF(V30.T_2D, V31.T_2D), asm => asm.SCVTF(V30.T_2D, V31.T_2D), Arm64InstructionId.SCVTF_asimdmisc_r, Arm64Mnemonic.SCVTF, "SCVTF V30.2D, V31.2D");
    }
}
