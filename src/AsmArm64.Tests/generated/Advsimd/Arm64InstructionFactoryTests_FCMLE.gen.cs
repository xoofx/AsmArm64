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
public class Arm64InstructionFactoryTests_FCMLE_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asisdmiscfp16_fz_0()
    {
        TestInst(FCMLE(H0, H1, 0.0f), asm => asm.FCMLE(H0, H1, 0.0f), Arm64InstructionId.FCMLE_asisdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE H0, H1, #0.0");
        TestInst(FCMLE(H31, H1, 0.0f), asm => asm.FCMLE(H31, H1, 0.0f), Arm64InstructionId.FCMLE_asisdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE H31, H1, #0.0");
        TestInst(FCMLE(H0, H31, 0.0f), asm => asm.FCMLE(H0, H31, 0.0f), Arm64InstructionId.FCMLE_asisdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE H0, H31, #0.0");
        TestInst(FCMLE(H31, H31, 0.0f), asm => asm.FCMLE(H31, H31, 0.0f), Arm64InstructionId.FCMLE_asisdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE H31, H31, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asisdmisc_fz_1()
    {
        TestInst(FCMLE(S1, S2, 0.0f), asm => asm.FCMLE(S1, S2, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE S1, S2, #0.0");
        TestInst(FCMLE(S31, S2, 0.0f), asm => asm.FCMLE(S31, S2, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE S31, S2, #0.0");
        TestInst(FCMLE(S1, S0, 0.0f), asm => asm.FCMLE(S1, S0, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE S1, S0, #0.0");
        TestInst(FCMLE(S31, S0, 0.0f), asm => asm.FCMLE(S31, S0, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE S31, S0, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asisdmisc_fz_2()
    {
        TestInst(FCMLE(D1, D2, 0.0f), asm => asm.FCMLE(D1, D2, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE D1, D2, #0.0");
        TestInst(FCMLE(D31, D2, 0.0f), asm => asm.FCMLE(D31, D2, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE D31, D2, #0.0");
        TestInst(FCMLE(D1, D0, 0.0f), asm => asm.FCMLE(D1, D0, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE D1, D0, #0.0");
        TestInst(FCMLE(D31, D0, 0.0f), asm => asm.FCMLE(D31, D0, 0.0f), Arm64InstructionId.FCMLE_asisdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE D31, D0, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asimdmiscfp16_fz_3()
    {
        TestInst(FCMLE(V0.T_4H, V1.T_4H, 0.0f), asm => asm.FCMLE(V0.T_4H, V1.T_4H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.4H, V1.4H, #0.0");
        TestInst(FCMLE(V30.T_4H, V1.T_4H, 0.0f), asm => asm.FCMLE(V30.T_4H, V1.T_4H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.4H, V1.4H, #0.0");
        TestInst(FCMLE(V0.T_4H, V31.T_4H, 0.0f), asm => asm.FCMLE(V0.T_4H, V31.T_4H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.4H, V31.4H, #0.0");
        TestInst(FCMLE(V30.T_4H, V31.T_4H, 0.0f), asm => asm.FCMLE(V30.T_4H, V31.T_4H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.4H, V31.4H, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asimdmiscfp16_fz_4()
    {
        TestInst(FCMLE(V0.T_8H, V1.T_8H, 0.0f), asm => asm.FCMLE(V0.T_8H, V1.T_8H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.8H, V1.8H, #0.0");
        TestInst(FCMLE(V30.T_8H, V1.T_8H, 0.0f), asm => asm.FCMLE(V30.T_8H, V1.T_8H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.8H, V1.8H, #0.0");
        TestInst(FCMLE(V0.T_8H, V31.T_8H, 0.0f), asm => asm.FCMLE(V0.T_8H, V31.T_8H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.8H, V31.8H, #0.0");
        TestInst(FCMLE(V30.T_8H, V31.T_8H, 0.0f), asm => asm.FCMLE(V30.T_8H, V31.T_8H, 0.0f), Arm64InstructionId.FCMLE_asimdmiscfp16_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.8H, V31.8H, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asimdmisc_fz_5()
    {
        TestInst(FCMLE(V0.T_2S, V1.T_2S, 0.0f), asm => asm.FCMLE(V0.T_2S, V1.T_2S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.2S, V1.2S, #0.0");
        TestInst(FCMLE(V30.T_2S, V1.T_2S, 0.0f), asm => asm.FCMLE(V30.T_2S, V1.T_2S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.2S, V1.2S, #0.0");
        TestInst(FCMLE(V0.T_2S, V31.T_2S, 0.0f), asm => asm.FCMLE(V0.T_2S, V31.T_2S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.2S, V31.2S, #0.0");
        TestInst(FCMLE(V30.T_2S, V31.T_2S, 0.0f), asm => asm.FCMLE(V30.T_2S, V31.T_2S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.2S, V31.2S, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asimdmisc_fz_6()
    {
        TestInst(FCMLE(V0.T_4S, V1.T_4S, 0.0f), asm => asm.FCMLE(V0.T_4S, V1.T_4S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.4S, V1.4S, #0.0");
        TestInst(FCMLE(V30.T_4S, V1.T_4S, 0.0f), asm => asm.FCMLE(V30.T_4S, V1.T_4S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.4S, V1.4S, #0.0");
        TestInst(FCMLE(V0.T_4S, V31.T_4S, 0.0f), asm => asm.FCMLE(V0.T_4S, V31.T_4S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.4S, V31.4S, #0.0");
        TestInst(FCMLE(V30.T_4S, V31.T_4S, 0.0f), asm => asm.FCMLE(V30.T_4S, V31.T_4S, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.4S, V31.4S, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMLE_asimdmisc_fz_7()
    {
        TestInst(FCMLE(V0.T_2D, V1.T_2D, 0.0f), asm => asm.FCMLE(V0.T_2D, V1.T_2D, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.2D, V1.2D, #0.0");
        TestInst(FCMLE(V30.T_2D, V1.T_2D, 0.0f), asm => asm.FCMLE(V30.T_2D, V1.T_2D, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.2D, V1.2D, #0.0");
        TestInst(FCMLE(V0.T_2D, V31.T_2D, 0.0f), asm => asm.FCMLE(V0.T_2D, V31.T_2D, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V0.2D, V31.2D, #0.0");
        TestInst(FCMLE(V30.T_2D, V31.T_2D, 0.0f), asm => asm.FCMLE(V30.T_2D, V31.T_2D, 0.0f), Arm64InstructionId.FCMLE_asimdmisc_fz, Arm64Mnemonic.FCMLE, "FCMLE V30.2D, V31.2D, #0.0");
    }
}
