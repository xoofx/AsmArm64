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
public class Arm64InstructionFactoryTests_FRSQRTE_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asisdmiscfp16_r_0()
    {
        TestInst(FRSQRTE(H0, H1), Arm64InstructionId.FRSQRTE_asisdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE H0, H1");
        TestInst(FRSQRTE(H31, H1), Arm64InstructionId.FRSQRTE_asisdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE H31, H1");
        TestInst(FRSQRTE(H0, H31), Arm64InstructionId.FRSQRTE_asisdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE H0, H31");
        TestInst(FRSQRTE(H31, H31), Arm64InstructionId.FRSQRTE_asisdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asisdmisc_r_1()
    {
        TestInst(FRSQRTE(S1, S2), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE S1, S2");
        TestInst(FRSQRTE(S31, S2), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE S31, S2");
        TestInst(FRSQRTE(S1, S0), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE S1, S0");
        TestInst(FRSQRTE(S31, S0), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asisdmisc_r_2()
    {
        TestInst(FRSQRTE(D1, D2), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE D1, D2");
        TestInst(FRSQRTE(D31, D2), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE D31, D2");
        TestInst(FRSQRTE(D1, D0), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE D1, D0");
        TestInst(FRSQRTE(D31, D0), Arm64InstructionId.FRSQRTE_asisdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE D31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asimdmiscfp16_r_3()
    {
        TestInst(FRSQRTE(V0.T_4H, V1.T_4H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.4H, V1.4H");
        TestInst(FRSQRTE(V30.T_4H, V1.T_4H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.4H, V1.4H");
        TestInst(FRSQRTE(V0.T_4H, V31.T_4H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.4H, V31.4H");
        TestInst(FRSQRTE(V30.T_4H, V31.T_4H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asimdmiscfp16_r_4()
    {
        TestInst(FRSQRTE(V0.T_8H, V1.T_8H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.8H, V1.8H");
        TestInst(FRSQRTE(V30.T_8H, V1.T_8H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.8H, V1.8H");
        TestInst(FRSQRTE(V0.T_8H, V31.T_8H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.8H, V31.8H");
        TestInst(FRSQRTE(V30.T_8H, V31.T_8H), Arm64InstructionId.FRSQRTE_asimdmiscfp16_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asimdmisc_r_5()
    {
        TestInst(FRSQRTE(V0.T_2S, V1.T_2S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.2S, V1.2S");
        TestInst(FRSQRTE(V30.T_2S, V1.T_2S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.2S, V1.2S");
        TestInst(FRSQRTE(V0.T_2S, V31.T_2S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.2S, V31.2S");
        TestInst(FRSQRTE(V30.T_2S, V31.T_2S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asimdmisc_r_6()
    {
        TestInst(FRSQRTE(V0.T_4S, V1.T_4S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.4S, V1.4S");
        TestInst(FRSQRTE(V30.T_4S, V1.T_4S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.4S, V1.4S");
        TestInst(FRSQRTE(V0.T_4S, V31.T_4S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.4S, V31.4S");
        TestInst(FRSQRTE(V30.T_4S, V31.T_4S), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRSQRTE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRSQRTE_asimdmisc_r_7()
    {
        TestInst(FRSQRTE(V0.T_2D, V1.T_2D), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.2D, V1.2D");
        TestInst(FRSQRTE(V30.T_2D, V1.T_2D), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.2D, V1.2D");
        TestInst(FRSQRTE(V0.T_2D, V31.T_2D), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V0.2D, V31.2D");
        TestInst(FRSQRTE(V30.T_2D, V31.T_2D), Arm64InstructionId.FRSQRTE_asimdmisc_r, Arm64Mnemonic.FRSQRTE, "FRSQRTE V30.2D, V31.2D");
    }
}
