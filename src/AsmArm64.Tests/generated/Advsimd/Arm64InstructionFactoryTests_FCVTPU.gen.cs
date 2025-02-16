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
public class Arm64InstructionFactoryTests_FCVTPU_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asisdmiscfp16_r_0()
    {
        TestInst(FCVTPU(H0, H1), asm => asm.FCVTPU(H0, H1), Arm64InstructionId.FCVTPU_asisdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU H0, H1");
        TestInst(FCVTPU(H31, H1), asm => asm.FCVTPU(H31, H1), Arm64InstructionId.FCVTPU_asisdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU H31, H1");
        TestInst(FCVTPU(H0, H31), asm => asm.FCVTPU(H0, H31), Arm64InstructionId.FCVTPU_asisdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU H0, H31");
        TestInst(FCVTPU(H31, H31), asm => asm.FCVTPU(H31, H31), Arm64InstructionId.FCVTPU_asisdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asisdmisc_r_1()
    {
        TestInst(FCVTPU(S1, S2), asm => asm.FCVTPU(S1, S2), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU S1, S2");
        TestInst(FCVTPU(S31, S2), asm => asm.FCVTPU(S31, S2), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU S31, S2");
        TestInst(FCVTPU(S1, S0), asm => asm.FCVTPU(S1, S0), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU S1, S0");
        TestInst(FCVTPU(S31, S0), asm => asm.FCVTPU(S31, S0), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asisdmisc_r_2()
    {
        TestInst(FCVTPU(D1, D2), asm => asm.FCVTPU(D1, D2), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU D1, D2");
        TestInst(FCVTPU(D31, D2), asm => asm.FCVTPU(D31, D2), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU D31, D2");
        TestInst(FCVTPU(D1, D0), asm => asm.FCVTPU(D1, D0), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU D1, D0");
        TestInst(FCVTPU(D31, D0), asm => asm.FCVTPU(D31, D0), Arm64InstructionId.FCVTPU_asisdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU D31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asimdmiscfp16_r_3()
    {
        TestInst(FCVTPU(V0.T_4H, V1.T_4H), asm => asm.FCVTPU(V0.T_4H, V1.T_4H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.4H, V1.4H");
        TestInst(FCVTPU(V30.T_4H, V1.T_4H), asm => asm.FCVTPU(V30.T_4H, V1.T_4H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.4H, V1.4H");
        TestInst(FCVTPU(V0.T_4H, V31.T_4H), asm => asm.FCVTPU(V0.T_4H, V31.T_4H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.4H, V31.4H");
        TestInst(FCVTPU(V30.T_4H, V31.T_4H), asm => asm.FCVTPU(V30.T_4H, V31.T_4H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asimdmiscfp16_r_4()
    {
        TestInst(FCVTPU(V0.T_8H, V1.T_8H), asm => asm.FCVTPU(V0.T_8H, V1.T_8H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.8H, V1.8H");
        TestInst(FCVTPU(V30.T_8H, V1.T_8H), asm => asm.FCVTPU(V30.T_8H, V1.T_8H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.8H, V1.8H");
        TestInst(FCVTPU(V0.T_8H, V31.T_8H), asm => asm.FCVTPU(V0.T_8H, V31.T_8H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.8H, V31.8H");
        TestInst(FCVTPU(V30.T_8H, V31.T_8H), asm => asm.FCVTPU(V30.T_8H, V31.T_8H), Arm64InstructionId.FCVTPU_asimdmiscfp16_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asimdmisc_r_5()
    {
        TestInst(FCVTPU(V0.T_2S, V1.T_2S), asm => asm.FCVTPU(V0.T_2S, V1.T_2S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.2S, V1.2S");
        TestInst(FCVTPU(V30.T_2S, V1.T_2S), asm => asm.FCVTPU(V30.T_2S, V1.T_2S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.2S, V1.2S");
        TestInst(FCVTPU(V0.T_2S, V31.T_2S), asm => asm.FCVTPU(V0.T_2S, V31.T_2S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.2S, V31.2S");
        TestInst(FCVTPU(V30.T_2S, V31.T_2S), asm => asm.FCVTPU(V30.T_2S, V31.T_2S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asimdmisc_r_6()
    {
        TestInst(FCVTPU(V0.T_4S, V1.T_4S), asm => asm.FCVTPU(V0.T_4S, V1.T_4S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.4S, V1.4S");
        TestInst(FCVTPU(V30.T_4S, V1.T_4S), asm => asm.FCVTPU(V30.T_4S, V1.T_4S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.4S, V1.4S");
        TestInst(FCVTPU(V0.T_4S, V31.T_4S), asm => asm.FCVTPU(V0.T_4S, V31.T_4S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.4S, V31.4S");
        TestInst(FCVTPU(V30.T_4S, V31.T_4S), asm => asm.FCVTPU(V30.T_4S, V31.T_4S), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_asimdmisc_r_7()
    {
        TestInst(FCVTPU(V0.T_2D, V1.T_2D), asm => asm.FCVTPU(V0.T_2D, V1.T_2D), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.2D, V1.2D");
        TestInst(FCVTPU(V30.T_2D, V1.T_2D), asm => asm.FCVTPU(V30.T_2D, V1.T_2D), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.2D, V1.2D");
        TestInst(FCVTPU(V0.T_2D, V31.T_2D), asm => asm.FCVTPU(V0.T_2D, V31.T_2D), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V0.2D, V31.2D");
        TestInst(FCVTPU(V30.T_2D, V31.T_2D), asm => asm.FCVTPU(V30.T_2D, V31.T_2D), Arm64InstructionId.FCVTPU_asimdmisc_r, Arm64Mnemonic.FCVTPU, "FCVTPU V30.2D, V31.2D");
    }
}
