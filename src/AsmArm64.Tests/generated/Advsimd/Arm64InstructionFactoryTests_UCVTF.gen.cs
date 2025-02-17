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
public class Arm64InstructionFactoryTests_UCVTF_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asisdshf_c_0()
    {
        TestInst(UCVTF(H1, H2, 5), asm => asm.UCVTF(H1, H2, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF H1, H2, #5");
        TestInst(UCVTF(H31, H2, 5), asm => asm.UCVTF(H31, H2, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF H31, H2, #5");
        TestInst(UCVTF(H1, H0, 5), asm => asm.UCVTF(H1, H0, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF H1, H0, #5");
        TestInst(UCVTF(H31, H0, 5), asm => asm.UCVTF(H31, H0, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF H31, H0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asisdshf_c_1()
    {
        TestInst(UCVTF(S1, S2, 5), asm => asm.UCVTF(S1, S2, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF S1, S2, #5");
        TestInst(UCVTF(S31, S2, 5), asm => asm.UCVTF(S31, S2, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF S31, S2, #5");
        TestInst(UCVTF(S1, S0, 5), asm => asm.UCVTF(S1, S0, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF S1, S0, #5");
        TestInst(UCVTF(S31, S0, 5), asm => asm.UCVTF(S31, S0, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF S31, S0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asisdshf_c_2()
    {
        TestInst(UCVTF(D1, D2, 5), asm => asm.UCVTF(D1, D2, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF D1, D2, #5");
        TestInst(UCVTF(D31, D2, 5), asm => asm.UCVTF(D31, D2, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF D31, D2, #5");
        TestInst(UCVTF(D1, D0, 5), asm => asm.UCVTF(D1, D0, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF D1, D0, #5");
        TestInst(UCVTF(D31, D0, 5), asm => asm.UCVTF(D31, D0, 5), Arm64InstructionId.UCVTF_asisdshf_c, Arm64Mnemonic.UCVTF, "UCVTF D31, D0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdshf_c_3()
    {
        TestInst(UCVTF(V0.T_4H, V1.T_4H, 5), asm => asm.UCVTF(V0.T_4H, V1.T_4H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.4H, V1.4H, #5");
        TestInst(UCVTF(V30.T_4H, V1.T_4H, 5), asm => asm.UCVTF(V30.T_4H, V1.T_4H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.4H, V1.4H, #5");
        TestInst(UCVTF(V0.T_4H, V31.T_4H, 5), asm => asm.UCVTF(V0.T_4H, V31.T_4H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.4H, V31.4H, #5");
        TestInst(UCVTF(V30.T_4H, V31.T_4H, 5), asm => asm.UCVTF(V30.T_4H, V31.T_4H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.4H, V31.4H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdshf_c_4()
    {
        TestInst(UCVTF(V0.T_8H, V1.T_8H, 5), asm => asm.UCVTF(V0.T_8H, V1.T_8H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.8H, V1.8H, #5");
        TestInst(UCVTF(V30.T_8H, V1.T_8H, 5), asm => asm.UCVTF(V30.T_8H, V1.T_8H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.8H, V1.8H, #5");
        TestInst(UCVTF(V0.T_8H, V31.T_8H, 5), asm => asm.UCVTF(V0.T_8H, V31.T_8H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.8H, V31.8H, #5");
        TestInst(UCVTF(V30.T_8H, V31.T_8H, 5), asm => asm.UCVTF(V30.T_8H, V31.T_8H, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.8H, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdshf_c_5()
    {
        TestInst(UCVTF(V0.T_2S, V1.T_2S, 5), asm => asm.UCVTF(V0.T_2S, V1.T_2S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.2S, V1.2S, #5");
        TestInst(UCVTF(V30.T_2S, V1.T_2S, 5), asm => asm.UCVTF(V30.T_2S, V1.T_2S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.2S, V1.2S, #5");
        TestInst(UCVTF(V0.T_2S, V31.T_2S, 5), asm => asm.UCVTF(V0.T_2S, V31.T_2S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.2S, V31.2S, #5");
        TestInst(UCVTF(V30.T_2S, V31.T_2S, 5), asm => asm.UCVTF(V30.T_2S, V31.T_2S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.2S, V31.2S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdshf_c_6()
    {
        TestInst(UCVTF(V0.T_4S, V1.T_4S, 5), asm => asm.UCVTF(V0.T_4S, V1.T_4S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.4S, V1.4S, #5");
        TestInst(UCVTF(V30.T_4S, V1.T_4S, 5), asm => asm.UCVTF(V30.T_4S, V1.T_4S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.4S, V1.4S, #5");
        TestInst(UCVTF(V0.T_4S, V31.T_4S, 5), asm => asm.UCVTF(V0.T_4S, V31.T_4S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.4S, V31.4S, #5");
        TestInst(UCVTF(V30.T_4S, V31.T_4S, 5), asm => asm.UCVTF(V30.T_4S, V31.T_4S, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.4S, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdshf_c_7()
    {
        TestInst(UCVTF(V0.T_2D, V1.T_2D, 5), asm => asm.UCVTF(V0.T_2D, V1.T_2D, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.2D, V1.2D, #5");
        TestInst(UCVTF(V30.T_2D, V1.T_2D, 5), asm => asm.UCVTF(V30.T_2D, V1.T_2D, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.2D, V1.2D, #5");
        TestInst(UCVTF(V0.T_2D, V31.T_2D, 5), asm => asm.UCVTF(V0.T_2D, V31.T_2D, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V0.2D, V31.2D, #5");
        TestInst(UCVTF(V30.T_2D, V31.T_2D, 5), asm => asm.UCVTF(V30.T_2D, V31.T_2D, 5), Arm64InstructionId.UCVTF_asimdshf_c, Arm64Mnemonic.UCVTF, "UCVTF V30.2D, V31.2D, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asisdmiscfp16_r_8()
    {
        TestInst(UCVTF(H0, H1), asm => asm.UCVTF(H0, H1), Arm64InstructionId.UCVTF_asisdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF H0, H1");
        TestInst(UCVTF(H31, H1), asm => asm.UCVTF(H31, H1), Arm64InstructionId.UCVTF_asisdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF H31, H1");
        TestInst(UCVTF(H0, H31), asm => asm.UCVTF(H0, H31), Arm64InstructionId.UCVTF_asisdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF H0, H31");
        TestInst(UCVTF(H31, H31), asm => asm.UCVTF(H31, H31), Arm64InstructionId.UCVTF_asisdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asisdmisc_r_9()
    {
        TestInst(UCVTF(S1, S2), asm => asm.UCVTF(S1, S2), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF S1, S2");
        TestInst(UCVTF(S31, S2), asm => asm.UCVTF(S31, S2), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF S31, S2");
        TestInst(UCVTF(S1, S0), asm => asm.UCVTF(S1, S0), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF S1, S0");
        TestInst(UCVTF(S31, S0), asm => asm.UCVTF(S31, S0), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asisdmisc_r_10()
    {
        TestInst(UCVTF(D1, D2), asm => asm.UCVTF(D1, D2), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF D1, D2");
        TestInst(UCVTF(D31, D2), asm => asm.UCVTF(D31, D2), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF D31, D2");
        TestInst(UCVTF(D1, D0), asm => asm.UCVTF(D1, D0), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF D1, D0");
        TestInst(UCVTF(D31, D0), asm => asm.UCVTF(D31, D0), Arm64InstructionId.UCVTF_asisdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF D31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdmiscfp16_r_11()
    {
        TestInst(UCVTF(V0.T_4H, V1.T_4H), asm => asm.UCVTF(V0.T_4H, V1.T_4H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V0.4H, V1.4H");
        TestInst(UCVTF(V30.T_4H, V1.T_4H), asm => asm.UCVTF(V30.T_4H, V1.T_4H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V30.4H, V1.4H");
        TestInst(UCVTF(V0.T_4H, V31.T_4H), asm => asm.UCVTF(V0.T_4H, V31.T_4H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V0.4H, V31.4H");
        TestInst(UCVTF(V30.T_4H, V31.T_4H), asm => asm.UCVTF(V30.T_4H, V31.T_4H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdmiscfp16_r_12()
    {
        TestInst(UCVTF(V0.T_8H, V1.T_8H), asm => asm.UCVTF(V0.T_8H, V1.T_8H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V0.8H, V1.8H");
        TestInst(UCVTF(V30.T_8H, V1.T_8H), asm => asm.UCVTF(V30.T_8H, V1.T_8H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V30.8H, V1.8H");
        TestInst(UCVTF(V0.T_8H, V31.T_8H), asm => asm.UCVTF(V0.T_8H, V31.T_8H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V0.8H, V31.8H");
        TestInst(UCVTF(V30.T_8H, V31.T_8H), asm => asm.UCVTF(V30.T_8H, V31.T_8H), Arm64InstructionId.UCVTF_asimdmiscfp16_r, Arm64Mnemonic.UCVTF, "UCVTF V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdmisc_r_13()
    {
        TestInst(UCVTF(V0.T_2S, V1.T_2S), asm => asm.UCVTF(V0.T_2S, V1.T_2S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V0.2S, V1.2S");
        TestInst(UCVTF(V30.T_2S, V1.T_2S), asm => asm.UCVTF(V30.T_2S, V1.T_2S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V30.2S, V1.2S");
        TestInst(UCVTF(V0.T_2S, V31.T_2S), asm => asm.UCVTF(V0.T_2S, V31.T_2S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V0.2S, V31.2S");
        TestInst(UCVTF(V30.T_2S, V31.T_2S), asm => asm.UCVTF(V30.T_2S, V31.T_2S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdmisc_r_14()
    {
        TestInst(UCVTF(V0.T_4S, V1.T_4S), asm => asm.UCVTF(V0.T_4S, V1.T_4S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V0.4S, V1.4S");
        TestInst(UCVTF(V30.T_4S, V1.T_4S), asm => asm.UCVTF(V30.T_4S, V1.T_4S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V30.4S, V1.4S");
        TestInst(UCVTF(V0.T_4S, V31.T_4S), asm => asm.UCVTF(V0.T_4S, V31.T_4S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V0.4S, V31.4S");
        TestInst(UCVTF(V30.T_4S, V31.T_4S), asm => asm.UCVTF(V30.T_4S, V31.T_4S), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UCVTF"/>.
    /// </summary>
    [TestMethod]
    public void Test_UCVTF_asimdmisc_r_15()
    {
        TestInst(UCVTF(V0.T_2D, V1.T_2D), asm => asm.UCVTF(V0.T_2D, V1.T_2D), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V0.2D, V1.2D");
        TestInst(UCVTF(V30.T_2D, V1.T_2D), asm => asm.UCVTF(V30.T_2D, V1.T_2D), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V30.2D, V1.2D");
        TestInst(UCVTF(V0.T_2D, V31.T_2D), asm => asm.UCVTF(V0.T_2D, V31.T_2D), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V0.2D, V31.2D");
        TestInst(UCVTF(V30.T_2D, V31.T_2D), asm => asm.UCVTF(V30.T_2D, V31.T_2D), Arm64InstructionId.UCVTF_asimdmisc_r, Arm64Mnemonic.UCVTF, "UCVTF V30.2D, V31.2D");
    }
}
