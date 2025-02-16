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
public class Arm64InstructionFactoryTests_FMINP_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asisdpair_only_h_0()
    {
        TestInst(FMINP(H0, V1.T_2H), Arm64InstructionId.FMINP_asisdpair_only_h, Arm64Mnemonic.FMINP, "FMINP H0, V1.2H");
        TestInst(FMINP(H31, V1.T_2H), Arm64InstructionId.FMINP_asisdpair_only_h, Arm64Mnemonic.FMINP, "FMINP H31, V1.2H");
        TestInst(FMINP(H0, V31.T_2H), Arm64InstructionId.FMINP_asisdpair_only_h, Arm64Mnemonic.FMINP, "FMINP H0, V31.2H");
        TestInst(FMINP(H31, V31.T_2H), Arm64InstructionId.FMINP_asisdpair_only_h, Arm64Mnemonic.FMINP, "FMINP H31, V31.2H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asisdpair_only_sd_1()
    {
        TestInst(FMINP(S1, V1.T_2S), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP S1, V1.2S");
        TestInst(FMINP(S31, V1.T_2S), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP S31, V1.2S");
        TestInst(FMINP(S1, V31.T_2S), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP S1, V31.2S");
        TestInst(FMINP(S31, V31.T_2S), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP S31, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asisdpair_only_sd_2()
    {
        TestInst(FMINP(D1, V1.T_2D), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP D1, V1.2D");
        TestInst(FMINP(D31, V1.T_2D), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP D31, V1.2D");
        TestInst(FMINP(D1, V31.T_2D), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP D1, V31.2D");
        TestInst(FMINP(D31, V31.T_2D), Arm64InstructionId.FMINP_asisdpair_only_sd, Arm64Mnemonic.FMINP, "FMINP D31, V31.2D");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asimdsamefp16_only_3()
    {
        TestInst(FMINP(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.4H, V1.4H, V2.4H");
        TestInst(FMINP(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.4H, V1.4H, V2.4H");
        TestInst(FMINP(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.4H, V31.4H, V2.4H");
        TestInst(FMINP(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.4H, V31.4H, V2.4H");
        TestInst(FMINP(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.4H, V1.4H, V0.4H");
        TestInst(FMINP(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.4H, V1.4H, V0.4H");
        TestInst(FMINP(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.4H, V31.4H, V0.4H");
        TestInst(FMINP(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asimdsamefp16_only_4()
    {
        TestInst(FMINP(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.8H, V1.8H, V2.8H");
        TestInst(FMINP(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.8H, V1.8H, V2.8H");
        TestInst(FMINP(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.8H, V31.8H, V2.8H");
        TestInst(FMINP(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.8H, V31.8H, V2.8H");
        TestInst(FMINP(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.8H, V1.8H, V0.8H");
        TestInst(FMINP(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.8H, V1.8H, V0.8H");
        TestInst(FMINP(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V0.8H, V31.8H, V0.8H");
        TestInst(FMINP(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMINP_asimdsamefp16_only, Arm64Mnemonic.FMINP, "FMINP V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asimdsame_only_5()
    {
        TestInst(FMINP(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2S, V1.2S, V2.2S");
        TestInst(FMINP(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2S, V1.2S, V2.2S");
        TestInst(FMINP(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2S, V31.2S, V2.2S");
        TestInst(FMINP(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2S, V31.2S, V2.2S");
        TestInst(FMINP(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2S, V1.2S, V0.2S");
        TestInst(FMINP(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2S, V1.2S, V0.2S");
        TestInst(FMINP(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2S, V31.2S, V0.2S");
        TestInst(FMINP(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asimdsame_only_6()
    {
        TestInst(FMINP(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.4S, V1.4S, V2.4S");
        TestInst(FMINP(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.4S, V1.4S, V2.4S");
        TestInst(FMINP(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.4S, V31.4S, V2.4S");
        TestInst(FMINP(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.4S, V31.4S, V2.4S");
        TestInst(FMINP(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.4S, V1.4S, V0.4S");
        TestInst(FMINP(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.4S, V1.4S, V0.4S");
        TestInst(FMINP(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.4S, V31.4S, V0.4S");
        TestInst(FMINP(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINP_asimdsame_only_7()
    {
        TestInst(FMINP(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2D, V1.2D, V2.2D");
        TestInst(FMINP(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2D, V1.2D, V2.2D");
        TestInst(FMINP(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2D, V31.2D, V2.2D");
        TestInst(FMINP(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2D, V31.2D, V2.2D");
        TestInst(FMINP(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2D, V1.2D, V0.2D");
        TestInst(FMINP(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2D, V1.2D, V0.2D");
        TestInst(FMINP(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V0.2D, V31.2D, V0.2D");
        TestInst(FMINP(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMINP_asimdsame_only, Arm64Mnemonic.FMINP, "FMINP V30.2D, V31.2D, V0.2D");
    }
}
