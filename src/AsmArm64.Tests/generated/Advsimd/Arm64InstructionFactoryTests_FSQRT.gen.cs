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
public class Arm64InstructionFactoryTests_FSQRT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSQRT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSQRT_asimdmiscfp16_r_0()
    {
        TestInst(FSQRT(V0.T_4H, V1.T_4H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V0.4H, V1.4H");
        TestInst(FSQRT(V30.T_4H, V1.T_4H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V30.4H, V1.4H");
        TestInst(FSQRT(V0.T_4H, V31.T_4H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V0.4H, V31.4H");
        TestInst(FSQRT(V30.T_4H, V31.T_4H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSQRT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSQRT_asimdmiscfp16_r_1()
    {
        TestInst(FSQRT(V0.T_8H, V1.T_8H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V0.8H, V1.8H");
        TestInst(FSQRT(V30.T_8H, V1.T_8H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V30.8H, V1.8H");
        TestInst(FSQRT(V0.T_8H, V31.T_8H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V0.8H, V31.8H");
        TestInst(FSQRT(V30.T_8H, V31.T_8H), Arm64InstructionId.FSQRT_asimdmiscfp16_r, Arm64Mnemonic.FSQRT, "FSQRT V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSQRT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSQRT_asimdmisc_r_2()
    {
        TestInst(FSQRT(V0.T_2S, V1.T_2S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V0.2S, V1.2S");
        TestInst(FSQRT(V30.T_2S, V1.T_2S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V30.2S, V1.2S");
        TestInst(FSQRT(V0.T_2S, V31.T_2S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V0.2S, V31.2S");
        TestInst(FSQRT(V30.T_2S, V31.T_2S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSQRT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSQRT_asimdmisc_r_3()
    {
        TestInst(FSQRT(V0.T_4S, V1.T_4S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V0.4S, V1.4S");
        TestInst(FSQRT(V30.T_4S, V1.T_4S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V30.4S, V1.4S");
        TestInst(FSQRT(V0.T_4S, V31.T_4S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V0.4S, V31.4S");
        TestInst(FSQRT(V30.T_4S, V31.T_4S), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSQRT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSQRT_asimdmisc_r_4()
    {
        TestInst(FSQRT(V0.T_2D, V1.T_2D), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V0.2D, V1.2D");
        TestInst(FSQRT(V30.T_2D, V1.T_2D), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V30.2D, V1.2D");
        TestInst(FSQRT(V0.T_2D, V31.T_2D), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V0.2D, V31.2D");
        TestInst(FSQRT(V30.T_2D, V31.T_2D), Arm64InstructionId.FSQRT_asimdmisc_r, Arm64Mnemonic.FSQRT, "FSQRT V30.2D, V31.2D");
    }
}
