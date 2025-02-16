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
public class Arm64InstructionFactoryTests_FACGE_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asisdsamefp16_only_0()
    {
        TestInst(FACGE(H0, H1, H2), asm => asm.FACGE(H0, H1, H2), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H0, H1, H2");
        TestInst(FACGE(H31, H1, H2), asm => asm.FACGE(H31, H1, H2), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H31, H1, H2");
        TestInst(FACGE(H0, H31, H2), asm => asm.FACGE(H0, H31, H2), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H0, H31, H2");
        TestInst(FACGE(H31, H31, H2), asm => asm.FACGE(H31, H31, H2), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H31, H31, H2");
        TestInst(FACGE(H0, H1, H31), asm => asm.FACGE(H0, H1, H31), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H0, H1, H31");
        TestInst(FACGE(H31, H1, H31), asm => asm.FACGE(H31, H1, H31), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H31, H1, H31");
        TestInst(FACGE(H0, H31, H31), asm => asm.FACGE(H0, H31, H31), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H0, H31, H31");
        TestInst(FACGE(H31, H31, H31), asm => asm.FACGE(H31, H31, H31), Arm64InstructionId.FACGE_asisdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asisdsame_only_1()
    {
        TestInst(FACGE(S1, S2, S3), asm => asm.FACGE(S1, S2, S3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S1, S2, S3");
        TestInst(FACGE(S31, S2, S3), asm => asm.FACGE(S31, S2, S3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S31, S2, S3");
        TestInst(FACGE(S1, S0, S3), asm => asm.FACGE(S1, S0, S3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S1, S0, S3");
        TestInst(FACGE(S31, S0, S3), asm => asm.FACGE(S31, S0, S3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S31, S0, S3");
        TestInst(FACGE(S1, S2, S1), asm => asm.FACGE(S1, S2, S1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S1, S2, S1");
        TestInst(FACGE(S31, S2, S1), asm => asm.FACGE(S31, S2, S1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S31, S2, S1");
        TestInst(FACGE(S1, S0, S1), asm => asm.FACGE(S1, S0, S1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S1, S0, S1");
        TestInst(FACGE(S31, S0, S1), asm => asm.FACGE(S31, S0, S1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE S31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asisdsame_only_2()
    {
        TestInst(FACGE(D1, D2, D3), asm => asm.FACGE(D1, D2, D3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D1, D2, D3");
        TestInst(FACGE(D31, D2, D3), asm => asm.FACGE(D31, D2, D3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D31, D2, D3");
        TestInst(FACGE(D1, D0, D3), asm => asm.FACGE(D1, D0, D3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D1, D0, D3");
        TestInst(FACGE(D31, D0, D3), asm => asm.FACGE(D31, D0, D3), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D31, D0, D3");
        TestInst(FACGE(D1, D2, D1), asm => asm.FACGE(D1, D2, D1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D1, D2, D1");
        TestInst(FACGE(D31, D2, D1), asm => asm.FACGE(D31, D2, D1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D31, D2, D1");
        TestInst(FACGE(D1, D0, D1), asm => asm.FACGE(D1, D0, D1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D1, D0, D1");
        TestInst(FACGE(D31, D0, D1), asm => asm.FACGE(D31, D0, D1), Arm64InstructionId.FACGE_asisdsame_only, Arm64Mnemonic.FACGE, "FACGE D31, D0, D1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asimdsamefp16_only_3()
    {
        TestInst(FACGE(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.FACGE(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.4H, V1.4H, V2.4H");
        TestInst(FACGE(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.FACGE(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.4H, V1.4H, V2.4H");
        TestInst(FACGE(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.FACGE(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.4H, V31.4H, V2.4H");
        TestInst(FACGE(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.FACGE(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.4H, V31.4H, V2.4H");
        TestInst(FACGE(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.FACGE(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.4H, V1.4H, V0.4H");
        TestInst(FACGE(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.FACGE(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.4H, V1.4H, V0.4H");
        TestInst(FACGE(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.FACGE(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.4H, V31.4H, V0.4H");
        TestInst(FACGE(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.FACGE(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asimdsamefp16_only_4()
    {
        TestInst(FACGE(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.FACGE(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.8H, V1.8H, V2.8H");
        TestInst(FACGE(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.FACGE(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.8H, V1.8H, V2.8H");
        TestInst(FACGE(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.FACGE(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.8H, V31.8H, V2.8H");
        TestInst(FACGE(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.FACGE(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.8H, V31.8H, V2.8H");
        TestInst(FACGE(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.FACGE(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.8H, V1.8H, V0.8H");
        TestInst(FACGE(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.FACGE(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.8H, V1.8H, V0.8H");
        TestInst(FACGE(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.FACGE(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V0.8H, V31.8H, V0.8H");
        TestInst(FACGE(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.FACGE(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FACGE_asimdsamefp16_only, Arm64Mnemonic.FACGE, "FACGE V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asimdsame_only_5()
    {
        TestInst(FACGE(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.FACGE(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2S, V1.2S, V2.2S");
        TestInst(FACGE(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.FACGE(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2S, V1.2S, V2.2S");
        TestInst(FACGE(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.FACGE(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2S, V31.2S, V2.2S");
        TestInst(FACGE(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.FACGE(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2S, V31.2S, V2.2S");
        TestInst(FACGE(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.FACGE(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2S, V1.2S, V0.2S");
        TestInst(FACGE(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.FACGE(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2S, V1.2S, V0.2S");
        TestInst(FACGE(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.FACGE(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2S, V31.2S, V0.2S");
        TestInst(FACGE(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.FACGE(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asimdsame_only_6()
    {
        TestInst(FACGE(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.FACGE(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.4S, V1.4S, V2.4S");
        TestInst(FACGE(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.FACGE(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.4S, V1.4S, V2.4S");
        TestInst(FACGE(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.FACGE(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.4S, V31.4S, V2.4S");
        TestInst(FACGE(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.FACGE(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.4S, V31.4S, V2.4S");
        TestInst(FACGE(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.FACGE(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.4S, V1.4S, V0.4S");
        TestInst(FACGE(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.FACGE(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.4S, V1.4S, V0.4S");
        TestInst(FACGE(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.FACGE(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.4S, V31.4S, V0.4S");
        TestInst(FACGE(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.FACGE(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FACGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FACGE_asimdsame_only_7()
    {
        TestInst(FACGE(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.FACGE(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2D, V1.2D, V2.2D");
        TestInst(FACGE(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.FACGE(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2D, V1.2D, V2.2D");
        TestInst(FACGE(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.FACGE(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2D, V31.2D, V2.2D");
        TestInst(FACGE(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.FACGE(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2D, V31.2D, V2.2D");
        TestInst(FACGE(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.FACGE(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2D, V1.2D, V0.2D");
        TestInst(FACGE(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.FACGE(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2D, V1.2D, V0.2D");
        TestInst(FACGE(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.FACGE(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V0.2D, V31.2D, V0.2D");
        TestInst(FACGE(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.FACGE(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FACGE_asimdsame_only, Arm64Mnemonic.FACGE, "FACGE V30.2D, V31.2D, V0.2D");
    }
}
