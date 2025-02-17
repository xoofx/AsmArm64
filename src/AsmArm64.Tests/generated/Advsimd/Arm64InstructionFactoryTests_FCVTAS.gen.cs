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
public class Arm64InstructionFactoryTests_FCVTAS_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asisdmiscfp16_r_0()
    {
        TestInst(FCVTAS(H0, H1), asm => asm.FCVTAS(H0, H1), Arm64InstructionId.FCVTAS_asisdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS H0, H1");
        TestInst(FCVTAS(H31, H1), asm => asm.FCVTAS(H31, H1), Arm64InstructionId.FCVTAS_asisdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS H31, H1");
        TestInst(FCVTAS(H0, H31), asm => asm.FCVTAS(H0, H31), Arm64InstructionId.FCVTAS_asisdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS H0, H31");
        TestInst(FCVTAS(H31, H31), asm => asm.FCVTAS(H31, H31), Arm64InstructionId.FCVTAS_asisdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asisdmisc_r_1()
    {
        TestInst(FCVTAS(S1, S2), asm => asm.FCVTAS(S1, S2), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS S1, S2");
        TestInst(FCVTAS(S31, S2), asm => asm.FCVTAS(S31, S2), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS S31, S2");
        TestInst(FCVTAS(S1, S0), asm => asm.FCVTAS(S1, S0), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS S1, S0");
        TestInst(FCVTAS(S31, S0), asm => asm.FCVTAS(S31, S0), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asisdmisc_r_2()
    {
        TestInst(FCVTAS(D1, D2), asm => asm.FCVTAS(D1, D2), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS D1, D2");
        TestInst(FCVTAS(D31, D2), asm => asm.FCVTAS(D31, D2), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS D31, D2");
        TestInst(FCVTAS(D1, D0), asm => asm.FCVTAS(D1, D0), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS D1, D0");
        TestInst(FCVTAS(D31, D0), asm => asm.FCVTAS(D31, D0), Arm64InstructionId.FCVTAS_asisdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS D31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asimdmiscfp16_r_3()
    {
        TestInst(FCVTAS(V0.T_4H, V1.T_4H), asm => asm.FCVTAS(V0.T_4H, V1.T_4H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.4H, V1.4H");
        TestInst(FCVTAS(V30.T_4H, V1.T_4H), asm => asm.FCVTAS(V30.T_4H, V1.T_4H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.4H, V1.4H");
        TestInst(FCVTAS(V0.T_4H, V31.T_4H), asm => asm.FCVTAS(V0.T_4H, V31.T_4H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.4H, V31.4H");
        TestInst(FCVTAS(V30.T_4H, V31.T_4H), asm => asm.FCVTAS(V30.T_4H, V31.T_4H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asimdmiscfp16_r_4()
    {
        TestInst(FCVTAS(V0.T_8H, V1.T_8H), asm => asm.FCVTAS(V0.T_8H, V1.T_8H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.8H, V1.8H");
        TestInst(FCVTAS(V30.T_8H, V1.T_8H), asm => asm.FCVTAS(V30.T_8H, V1.T_8H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.8H, V1.8H");
        TestInst(FCVTAS(V0.T_8H, V31.T_8H), asm => asm.FCVTAS(V0.T_8H, V31.T_8H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.8H, V31.8H");
        TestInst(FCVTAS(V30.T_8H, V31.T_8H), asm => asm.FCVTAS(V30.T_8H, V31.T_8H), Arm64InstructionId.FCVTAS_asimdmiscfp16_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asimdmisc_r_5()
    {
        TestInst(FCVTAS(V0.T_2S, V1.T_2S), asm => asm.FCVTAS(V0.T_2S, V1.T_2S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.2S, V1.2S");
        TestInst(FCVTAS(V30.T_2S, V1.T_2S), asm => asm.FCVTAS(V30.T_2S, V1.T_2S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.2S, V1.2S");
        TestInst(FCVTAS(V0.T_2S, V31.T_2S), asm => asm.FCVTAS(V0.T_2S, V31.T_2S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.2S, V31.2S");
        TestInst(FCVTAS(V30.T_2S, V31.T_2S), asm => asm.FCVTAS(V30.T_2S, V31.T_2S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asimdmisc_r_6()
    {
        TestInst(FCVTAS(V0.T_4S, V1.T_4S), asm => asm.FCVTAS(V0.T_4S, V1.T_4S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.4S, V1.4S");
        TestInst(FCVTAS(V30.T_4S, V1.T_4S), asm => asm.FCVTAS(V30.T_4S, V1.T_4S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.4S, V1.4S");
        TestInst(FCVTAS(V0.T_4S, V31.T_4S), asm => asm.FCVTAS(V0.T_4S, V31.T_4S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.4S, V31.4S");
        TestInst(FCVTAS(V30.T_4S, V31.T_4S), asm => asm.FCVTAS(V30.T_4S, V31.T_4S), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAS_asimdmisc_r_7()
    {
        TestInst(FCVTAS(V0.T_2D, V1.T_2D), asm => asm.FCVTAS(V0.T_2D, V1.T_2D), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.2D, V1.2D");
        TestInst(FCVTAS(V30.T_2D, V1.T_2D), asm => asm.FCVTAS(V30.T_2D, V1.T_2D), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.2D, V1.2D");
        TestInst(FCVTAS(V0.T_2D, V31.T_2D), asm => asm.FCVTAS(V0.T_2D, V31.T_2D), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V0.2D, V31.2D");
        TestInst(FCVTAS(V30.T_2D, V31.T_2D), asm => asm.FCVTAS(V30.T_2D, V31.T_2D), Arm64InstructionId.FCVTAS_asimdmisc_r, Arm64Mnemonic.FCVTAS, "FCVTAS V30.2D, V31.2D");
    }
}
