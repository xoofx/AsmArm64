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
public class Arm64InstructionFactoryTests_SADALP_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADALP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADALP_asimdmisc_p_0()
    {
        TestInst(SADALP(V0.T_4H, V1.T_8B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.4H, V1.8B");
        TestInst(SADALP(V30.T_4H, V1.T_8B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.4H, V1.8B");
        TestInst(SADALP(V0.T_4H, V31.T_8B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.4H, V31.8B");
        TestInst(SADALP(V30.T_4H, V31.T_8B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.4H, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADALP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADALP_asimdmisc_p_1()
    {
        TestInst(SADALP(V0.T_8H, V1.T_16B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.8H, V1.16B");
        TestInst(SADALP(V30.T_8H, V1.T_16B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.8H, V1.16B");
        TestInst(SADALP(V0.T_8H, V31.T_16B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.8H, V31.16B");
        TestInst(SADALP(V30.T_8H, V31.T_16B), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.8H, V31.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADALP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADALP_asimdmisc_p_2()
    {
        TestInst(SADALP(V0.T_2S, V1.T_4H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.2S, V1.4H");
        TestInst(SADALP(V30.T_2S, V1.T_4H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.2S, V1.4H");
        TestInst(SADALP(V0.T_2S, V31.T_4H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.2S, V31.4H");
        TestInst(SADALP(V30.T_2S, V31.T_4H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.2S, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADALP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADALP_asimdmisc_p_3()
    {
        TestInst(SADALP(V0.T_4S, V1.T_8H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.4S, V1.8H");
        TestInst(SADALP(V30.T_4S, V1.T_8H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.4S, V1.8H");
        TestInst(SADALP(V0.T_4S, V31.T_8H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.4S, V31.8H");
        TestInst(SADALP(V30.T_4S, V31.T_8H), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.4S, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADALP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADALP_asimdmisc_p_4()
    {
        TestInst(SADALP(V0.T_1D, V1.T_2S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.1D, V1.2S");
        TestInst(SADALP(V30.T_1D, V1.T_2S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.1D, V1.2S");
        TestInst(SADALP(V0.T_1D, V31.T_2S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.1D, V31.2S");
        TestInst(SADALP(V30.T_1D, V31.T_2S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.1D, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADALP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADALP_asimdmisc_p_5()
    {
        TestInst(SADALP(V0.T_2D, V1.T_4S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.2D, V1.4S");
        TestInst(SADALP(V30.T_2D, V1.T_4S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.2D, V1.4S");
        TestInst(SADALP(V0.T_2D, V31.T_4S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V0.2D, V31.4S");
        TestInst(SADALP(V30.T_2D, V31.T_4S), Arm64InstructionId.SADALP_asimdmisc_p, Arm64Mnemonic.SADALP, "SADALP V30.2D, V31.4S");
    }
}
