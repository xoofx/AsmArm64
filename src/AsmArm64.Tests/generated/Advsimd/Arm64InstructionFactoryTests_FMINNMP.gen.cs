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
public class Arm64InstructionFactoryTests_FMINNMP_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asisdpair_only_h_0()
    {
        TestInst(FMINNMP(H0, V1.T_2H), asm => asm.FMINNMP(H0, V1.T_2H), Arm64InstructionId.FMINNMP_asisdpair_only_h, Arm64Mnemonic.FMINNMP, "FMINNMP H0, V1.2H");
        TestInst(FMINNMP(H31, V1.T_2H), asm => asm.FMINNMP(H31, V1.T_2H), Arm64InstructionId.FMINNMP_asisdpair_only_h, Arm64Mnemonic.FMINNMP, "FMINNMP H31, V1.2H");
        TestInst(FMINNMP(H0, V31.T_2H), asm => asm.FMINNMP(H0, V31.T_2H), Arm64InstructionId.FMINNMP_asisdpair_only_h, Arm64Mnemonic.FMINNMP, "FMINNMP H0, V31.2H");
        TestInst(FMINNMP(H31, V31.T_2H), asm => asm.FMINNMP(H31, V31.T_2H), Arm64InstructionId.FMINNMP_asisdpair_only_h, Arm64Mnemonic.FMINNMP, "FMINNMP H31, V31.2H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asisdpair_only_sd_1()
    {
        TestInst(FMINNMP(S1, V1.T_2S), asm => asm.FMINNMP(S1, V1.T_2S), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP S1, V1.2S");
        TestInst(FMINNMP(S31, V1.T_2S), asm => asm.FMINNMP(S31, V1.T_2S), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP S31, V1.2S");
        TestInst(FMINNMP(S1, V31.T_2S), asm => asm.FMINNMP(S1, V31.T_2S), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP S1, V31.2S");
        TestInst(FMINNMP(S31, V31.T_2S), asm => asm.FMINNMP(S31, V31.T_2S), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP S31, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asisdpair_only_sd_2()
    {
        TestInst(FMINNMP(D1, V1.T_2D), asm => asm.FMINNMP(D1, V1.T_2D), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP D1, V1.2D");
        TestInst(FMINNMP(D31, V1.T_2D), asm => asm.FMINNMP(D31, V1.T_2D), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP D31, V1.2D");
        TestInst(FMINNMP(D1, V31.T_2D), asm => asm.FMINNMP(D1, V31.T_2D), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP D1, V31.2D");
        TestInst(FMINNMP(D31, V31.T_2D), asm => asm.FMINNMP(D31, V31.T_2D), Arm64InstructionId.FMINNMP_asisdpair_only_sd, Arm64Mnemonic.FMINNMP, "FMINNMP D31, V31.2D");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asimdsamefp16_only_3()
    {
        TestInst(FMINNMP(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.FMINNMP(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4H, V1.4H, V2.4H");
        TestInst(FMINNMP(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.FMINNMP(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4H, V1.4H, V2.4H");
        TestInst(FMINNMP(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.FMINNMP(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4H, V31.4H, V2.4H");
        TestInst(FMINNMP(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.FMINNMP(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4H, V31.4H, V2.4H");
        TestInst(FMINNMP(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.FMINNMP(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4H, V1.4H, V0.4H");
        TestInst(FMINNMP(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.FMINNMP(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4H, V1.4H, V0.4H");
        TestInst(FMINNMP(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.FMINNMP(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4H, V31.4H, V0.4H");
        TestInst(FMINNMP(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.FMINNMP(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asimdsamefp16_only_4()
    {
        TestInst(FMINNMP(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.FMINNMP(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.8H, V1.8H, V2.8H");
        TestInst(FMINNMP(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.FMINNMP(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.8H, V1.8H, V2.8H");
        TestInst(FMINNMP(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.FMINNMP(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.8H, V31.8H, V2.8H");
        TestInst(FMINNMP(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.FMINNMP(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.8H, V31.8H, V2.8H");
        TestInst(FMINNMP(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.FMINNMP(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.8H, V1.8H, V0.8H");
        TestInst(FMINNMP(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.FMINNMP(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.8H, V1.8H, V0.8H");
        TestInst(FMINNMP(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.FMINNMP(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.8H, V31.8H, V0.8H");
        TestInst(FMINNMP(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.FMINNMP(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FMINNMP_asimdsamefp16_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asimdsame_only_5()
    {
        TestInst(FMINNMP(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.FMINNMP(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2S, V1.2S, V2.2S");
        TestInst(FMINNMP(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.FMINNMP(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2S, V1.2S, V2.2S");
        TestInst(FMINNMP(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.FMINNMP(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2S, V31.2S, V2.2S");
        TestInst(FMINNMP(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.FMINNMP(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2S, V31.2S, V2.2S");
        TestInst(FMINNMP(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.FMINNMP(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2S, V1.2S, V0.2S");
        TestInst(FMINNMP(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.FMINNMP(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2S, V1.2S, V0.2S");
        TestInst(FMINNMP(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.FMINNMP(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2S, V31.2S, V0.2S");
        TestInst(FMINNMP(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.FMINNMP(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asimdsame_only_6()
    {
        TestInst(FMINNMP(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.FMINNMP(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4S, V1.4S, V2.4S");
        TestInst(FMINNMP(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.FMINNMP(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4S, V1.4S, V2.4S");
        TestInst(FMINNMP(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.FMINNMP(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4S, V31.4S, V2.4S");
        TestInst(FMINNMP(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.FMINNMP(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4S, V31.4S, V2.4S");
        TestInst(FMINNMP(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.FMINNMP(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4S, V1.4S, V0.4S");
        TestInst(FMINNMP(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.FMINNMP(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4S, V1.4S, V0.4S");
        TestInst(FMINNMP(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.FMINNMP(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.4S, V31.4S, V0.4S");
        TestInst(FMINNMP(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.FMINNMP(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMINNMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMINNMP_asimdsame_only_7()
    {
        TestInst(FMINNMP(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.FMINNMP(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2D, V1.2D, V2.2D");
        TestInst(FMINNMP(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.FMINNMP(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2D, V1.2D, V2.2D");
        TestInst(FMINNMP(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.FMINNMP(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2D, V31.2D, V2.2D");
        TestInst(FMINNMP(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.FMINNMP(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2D, V31.2D, V2.2D");
        TestInst(FMINNMP(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.FMINNMP(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2D, V1.2D, V0.2D");
        TestInst(FMINNMP(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.FMINNMP(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2D, V1.2D, V0.2D");
        TestInst(FMINNMP(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.FMINNMP(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V0.2D, V31.2D, V0.2D");
        TestInst(FMINNMP(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.FMINNMP(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FMINNMP_asimdsame_only, Arm64Mnemonic.FMINNMP, "FMINNMP V30.2D, V31.2D, V0.2D");
    }
}
