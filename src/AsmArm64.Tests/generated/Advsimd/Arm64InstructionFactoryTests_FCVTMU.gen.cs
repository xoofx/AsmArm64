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
public class Arm64InstructionFactoryTests_FCVTMU_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asisdmiscfp16_r_0()
    {
        TestInst(FCVTMU(H0, H1), asm => asm.FCVTMU(H0, H1), Arm64InstructionId.FCVTMU_asisdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU H0, H1");
        TestInst(FCVTMU(H31, H1), asm => asm.FCVTMU(H31, H1), Arm64InstructionId.FCVTMU_asisdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU H31, H1");
        TestInst(FCVTMU(H0, H31), asm => asm.FCVTMU(H0, H31), Arm64InstructionId.FCVTMU_asisdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU H0, H31");
        TestInst(FCVTMU(H31, H31), asm => asm.FCVTMU(H31, H31), Arm64InstructionId.FCVTMU_asisdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asisdmisc_r_1()
    {
        TestInst(FCVTMU(S1, S2), asm => asm.FCVTMU(S1, S2), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU S1, S2");
        TestInst(FCVTMU(S31, S2), asm => asm.FCVTMU(S31, S2), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU S31, S2");
        TestInst(FCVTMU(S1, S0), asm => asm.FCVTMU(S1, S0), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU S1, S0");
        TestInst(FCVTMU(S31, S0), asm => asm.FCVTMU(S31, S0), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asisdmisc_r_2()
    {
        TestInst(FCVTMU(D1, D2), asm => asm.FCVTMU(D1, D2), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU D1, D2");
        TestInst(FCVTMU(D31, D2), asm => asm.FCVTMU(D31, D2), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU D31, D2");
        TestInst(FCVTMU(D1, D0), asm => asm.FCVTMU(D1, D0), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU D1, D0");
        TestInst(FCVTMU(D31, D0), asm => asm.FCVTMU(D31, D0), Arm64InstructionId.FCVTMU_asisdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU D31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asimdmiscfp16_r_3()
    {
        TestInst(FCVTMU(V0.T_4H, V1.T_4H), asm => asm.FCVTMU(V0.T_4H, V1.T_4H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.4H, V1.4H");
        TestInst(FCVTMU(V30.T_4H, V1.T_4H), asm => asm.FCVTMU(V30.T_4H, V1.T_4H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.4H, V1.4H");
        TestInst(FCVTMU(V0.T_4H, V31.T_4H), asm => asm.FCVTMU(V0.T_4H, V31.T_4H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.4H, V31.4H");
        TestInst(FCVTMU(V30.T_4H, V31.T_4H), asm => asm.FCVTMU(V30.T_4H, V31.T_4H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asimdmiscfp16_r_4()
    {
        TestInst(FCVTMU(V0.T_8H, V1.T_8H), asm => asm.FCVTMU(V0.T_8H, V1.T_8H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.8H, V1.8H");
        TestInst(FCVTMU(V30.T_8H, V1.T_8H), asm => asm.FCVTMU(V30.T_8H, V1.T_8H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.8H, V1.8H");
        TestInst(FCVTMU(V0.T_8H, V31.T_8H), asm => asm.FCVTMU(V0.T_8H, V31.T_8H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.8H, V31.8H");
        TestInst(FCVTMU(V30.T_8H, V31.T_8H), asm => asm.FCVTMU(V30.T_8H, V31.T_8H), Arm64InstructionId.FCVTMU_asimdmiscfp16_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asimdmisc_r_5()
    {
        TestInst(FCVTMU(V0.T_2S, V1.T_2S), asm => asm.FCVTMU(V0.T_2S, V1.T_2S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.2S, V1.2S");
        TestInst(FCVTMU(V30.T_2S, V1.T_2S), asm => asm.FCVTMU(V30.T_2S, V1.T_2S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.2S, V1.2S");
        TestInst(FCVTMU(V0.T_2S, V31.T_2S), asm => asm.FCVTMU(V0.T_2S, V31.T_2S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.2S, V31.2S");
        TestInst(FCVTMU(V30.T_2S, V31.T_2S), asm => asm.FCVTMU(V30.T_2S, V31.T_2S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asimdmisc_r_6()
    {
        TestInst(FCVTMU(V0.T_4S, V1.T_4S), asm => asm.FCVTMU(V0.T_4S, V1.T_4S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.4S, V1.4S");
        TestInst(FCVTMU(V30.T_4S, V1.T_4S), asm => asm.FCVTMU(V30.T_4S, V1.T_4S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.4S, V1.4S");
        TestInst(FCVTMU(V0.T_4S, V31.T_4S), asm => asm.FCVTMU(V0.T_4S, V31.T_4S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.4S, V31.4S");
        TestInst(FCVTMU(V30.T_4S, V31.T_4S), asm => asm.FCVTMU(V30.T_4S, V31.T_4S), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTMU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTMU_asimdmisc_r_7()
    {
        TestInst(FCVTMU(V0.T_2D, V1.T_2D), asm => asm.FCVTMU(V0.T_2D, V1.T_2D), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.2D, V1.2D");
        TestInst(FCVTMU(V30.T_2D, V1.T_2D), asm => asm.FCVTMU(V30.T_2D, V1.T_2D), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.2D, V1.2D");
        TestInst(FCVTMU(V0.T_2D, V31.T_2D), asm => asm.FCVTMU(V0.T_2D, V31.T_2D), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V0.2D, V31.2D");
        TestInst(FCVTMU(V30.T_2D, V31.T_2D), asm => asm.FCVTMU(V30.T_2D, V31.T_2D), Arm64InstructionId.FCVTMU_asimdmisc_r, Arm64Mnemonic.FCVTMU, "FCVTMU V30.2D, V31.2D");
    }
}
