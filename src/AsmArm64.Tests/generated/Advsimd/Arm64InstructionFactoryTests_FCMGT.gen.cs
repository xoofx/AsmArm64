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
public class Arm64InstructionFactoryTests_FCMGT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asisdsamefp16_only_0()
    {
        TestInst(FCMGT(H0, H1, H2), asm => asm.FCMGT(H0, H1, H2), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H0, H1, H2");
        TestInst(FCMGT(H31, H1, H2), asm => asm.FCMGT(H31, H1, H2), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H31, H1, H2");
        TestInst(FCMGT(H0, H31, H2), asm => asm.FCMGT(H0, H31, H2), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H0, H31, H2");
        TestInst(FCMGT(H31, H31, H2), asm => asm.FCMGT(H31, H31, H2), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H31, H31, H2");
        TestInst(FCMGT(H0, H1, H31), asm => asm.FCMGT(H0, H1, H31), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H0, H1, H31");
        TestInst(FCMGT(H31, H1, H31), asm => asm.FCMGT(H31, H1, H31), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H31, H1, H31");
        TestInst(FCMGT(H0, H31, H31), asm => asm.FCMGT(H0, H31, H31), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H0, H31, H31");
        TestInst(FCMGT(H31, H31, H31), asm => asm.FCMGT(H31, H31, H31), Arm64InstructionId.FCMGT_asisdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asisdsame_only_1()
    {
        TestInst(FCMGT(S1, S2, S3), asm => asm.FCMGT(S1, S2, S3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S1, S2, S3");
        TestInst(FCMGT(S31, S2, S3), asm => asm.FCMGT(S31, S2, S3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S31, S2, S3");
        TestInst(FCMGT(S1, S0, S3), asm => asm.FCMGT(S1, S0, S3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S1, S0, S3");
        TestInst(FCMGT(S31, S0, S3), asm => asm.FCMGT(S31, S0, S3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S31, S0, S3");
        TestInst(FCMGT(S1, S2, S1), asm => asm.FCMGT(S1, S2, S1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S1, S2, S1");
        TestInst(FCMGT(S31, S2, S1), asm => asm.FCMGT(S31, S2, S1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S31, S2, S1");
        TestInst(FCMGT(S1, S0, S1), asm => asm.FCMGT(S1, S0, S1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S1, S0, S1");
        TestInst(FCMGT(S31, S0, S1), asm => asm.FCMGT(S31, S0, S1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT S31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asisdsame_only_2()
    {
        TestInst(FCMGT(D1, D2, D3), asm => asm.FCMGT(D1, D2, D3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D1, D2, D3");
        TestInst(FCMGT(D31, D2, D3), asm => asm.FCMGT(D31, D2, D3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D31, D2, D3");
        TestInst(FCMGT(D1, D0, D3), asm => asm.FCMGT(D1, D0, D3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D1, D0, D3");
        TestInst(FCMGT(D31, D0, D3), asm => asm.FCMGT(D31, D0, D3), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D31, D0, D3");
        TestInst(FCMGT(D1, D2, D1), asm => asm.FCMGT(D1, D2, D1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D1, D2, D1");
        TestInst(FCMGT(D31, D2, D1), asm => asm.FCMGT(D31, D2, D1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D31, D2, D1");
        TestInst(FCMGT(D1, D0, D1), asm => asm.FCMGT(D1, D0, D1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D1, D0, D1");
        TestInst(FCMGT(D31, D0, D1), asm => asm.FCMGT(D31, D0, D1), Arm64InstructionId.FCMGT_asisdsame_only, Arm64Mnemonic.FCMGT, "FCMGT D31, D0, D1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdsamefp16_only_3()
    {
        TestInst(FCMGT(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.FCMGT(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4H, V1.4H, V2.4H");
        TestInst(FCMGT(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.FCMGT(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4H, V1.4H, V2.4H");
        TestInst(FCMGT(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.FCMGT(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4H, V31.4H, V2.4H");
        TestInst(FCMGT(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.FCMGT(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4H, V31.4H, V2.4H");
        TestInst(FCMGT(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.FCMGT(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4H, V1.4H, V0.4H");
        TestInst(FCMGT(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.FCMGT(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4H, V1.4H, V0.4H");
        TestInst(FCMGT(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.FCMGT(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4H, V31.4H, V0.4H");
        TestInst(FCMGT(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.FCMGT(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdsamefp16_only_4()
    {
        TestInst(FCMGT(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.FCMGT(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.8H, V1.8H, V2.8H");
        TestInst(FCMGT(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.FCMGT(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.8H, V1.8H, V2.8H");
        TestInst(FCMGT(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.FCMGT(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.8H, V31.8H, V2.8H");
        TestInst(FCMGT(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.FCMGT(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.8H, V31.8H, V2.8H");
        TestInst(FCMGT(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.FCMGT(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.8H, V1.8H, V0.8H");
        TestInst(FCMGT(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.FCMGT(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.8H, V1.8H, V0.8H");
        TestInst(FCMGT(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.FCMGT(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V0.8H, V31.8H, V0.8H");
        TestInst(FCMGT(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.FCMGT(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.FCMGT_asimdsamefp16_only, Arm64Mnemonic.FCMGT, "FCMGT V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdsame_only_5()
    {
        TestInst(FCMGT(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.FCMGT(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2S, V1.2S, V2.2S");
        TestInst(FCMGT(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.FCMGT(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2S, V1.2S, V2.2S");
        TestInst(FCMGT(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.FCMGT(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2S, V31.2S, V2.2S");
        TestInst(FCMGT(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.FCMGT(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2S, V31.2S, V2.2S");
        TestInst(FCMGT(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.FCMGT(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2S, V1.2S, V0.2S");
        TestInst(FCMGT(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.FCMGT(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2S, V1.2S, V0.2S");
        TestInst(FCMGT(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.FCMGT(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2S, V31.2S, V0.2S");
        TestInst(FCMGT(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.FCMGT(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdsame_only_6()
    {
        TestInst(FCMGT(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.FCMGT(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4S, V1.4S, V2.4S");
        TestInst(FCMGT(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.FCMGT(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4S, V1.4S, V2.4S");
        TestInst(FCMGT(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.FCMGT(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4S, V31.4S, V2.4S");
        TestInst(FCMGT(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.FCMGT(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4S, V31.4S, V2.4S");
        TestInst(FCMGT(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.FCMGT(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4S, V1.4S, V0.4S");
        TestInst(FCMGT(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.FCMGT(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4S, V1.4S, V0.4S");
        TestInst(FCMGT(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.FCMGT(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.4S, V31.4S, V0.4S");
        TestInst(FCMGT(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.FCMGT(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdsame_only_7()
    {
        TestInst(FCMGT(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.FCMGT(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2D, V1.2D, V2.2D");
        TestInst(FCMGT(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.FCMGT(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2D, V1.2D, V2.2D");
        TestInst(FCMGT(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.FCMGT(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2D, V31.2D, V2.2D");
        TestInst(FCMGT(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.FCMGT(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2D, V31.2D, V2.2D");
        TestInst(FCMGT(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.FCMGT(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2D, V1.2D, V0.2D");
        TestInst(FCMGT(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.FCMGT(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2D, V1.2D, V0.2D");
        TestInst(FCMGT(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.FCMGT(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V0.2D, V31.2D, V0.2D");
        TestInst(FCMGT(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.FCMGT(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.FCMGT_asimdsame_only, Arm64Mnemonic.FCMGT, "FCMGT V30.2D, V31.2D, V0.2D");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asisdmiscfp16_fz_8()
    {
        TestInst(FCMGT(H0, H1, 0.0f), asm => asm.FCMGT(H0, H1, 0.0f), Arm64InstructionId.FCMGT_asisdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT H0, H1, #0.0");
        TestInst(FCMGT(H31, H1, 0.0f), asm => asm.FCMGT(H31, H1, 0.0f), Arm64InstructionId.FCMGT_asisdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT H31, H1, #0.0");
        TestInst(FCMGT(H0, H31, 0.0f), asm => asm.FCMGT(H0, H31, 0.0f), Arm64InstructionId.FCMGT_asisdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT H0, H31, #0.0");
        TestInst(FCMGT(H31, H31, 0.0f), asm => asm.FCMGT(H31, H31, 0.0f), Arm64InstructionId.FCMGT_asisdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT H31, H31, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asisdmisc_fz_9()
    {
        TestInst(FCMGT(S1, S2, 0.0f), asm => asm.FCMGT(S1, S2, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT S1, S2, #0.0");
        TestInst(FCMGT(S31, S2, 0.0f), asm => asm.FCMGT(S31, S2, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT S31, S2, #0.0");
        TestInst(FCMGT(S1, S0, 0.0f), asm => asm.FCMGT(S1, S0, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT S1, S0, #0.0");
        TestInst(FCMGT(S31, S0, 0.0f), asm => asm.FCMGT(S31, S0, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT S31, S0, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asisdmisc_fz_10()
    {
        TestInst(FCMGT(D1, D2, 0.0f), asm => asm.FCMGT(D1, D2, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT D1, D2, #0.0");
        TestInst(FCMGT(D31, D2, 0.0f), asm => asm.FCMGT(D31, D2, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT D31, D2, #0.0");
        TestInst(FCMGT(D1, D0, 0.0f), asm => asm.FCMGT(D1, D0, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT D1, D0, #0.0");
        TestInst(FCMGT(D31, D0, 0.0f), asm => asm.FCMGT(D31, D0, 0.0f), Arm64InstructionId.FCMGT_asisdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT D31, D0, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdmiscfp16_fz_11()
    {
        TestInst(FCMGT(V0.T_4H, V1.T_4H, 0.0f), asm => asm.FCMGT(V0.T_4H, V1.T_4H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.4H, V1.4H, #0.0");
        TestInst(FCMGT(V30.T_4H, V1.T_4H, 0.0f), asm => asm.FCMGT(V30.T_4H, V1.T_4H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.4H, V1.4H, #0.0");
        TestInst(FCMGT(V0.T_4H, V31.T_4H, 0.0f), asm => asm.FCMGT(V0.T_4H, V31.T_4H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.4H, V31.4H, #0.0");
        TestInst(FCMGT(V30.T_4H, V31.T_4H, 0.0f), asm => asm.FCMGT(V30.T_4H, V31.T_4H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.4H, V31.4H, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdmiscfp16_fz_12()
    {
        TestInst(FCMGT(V0.T_8H, V1.T_8H, 0.0f), asm => asm.FCMGT(V0.T_8H, V1.T_8H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.8H, V1.8H, #0.0");
        TestInst(FCMGT(V30.T_8H, V1.T_8H, 0.0f), asm => asm.FCMGT(V30.T_8H, V1.T_8H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.8H, V1.8H, #0.0");
        TestInst(FCMGT(V0.T_8H, V31.T_8H, 0.0f), asm => asm.FCMGT(V0.T_8H, V31.T_8H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.8H, V31.8H, #0.0");
        TestInst(FCMGT(V30.T_8H, V31.T_8H, 0.0f), asm => asm.FCMGT(V30.T_8H, V31.T_8H, 0.0f), Arm64InstructionId.FCMGT_asimdmiscfp16_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.8H, V31.8H, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdmisc_fz_13()
    {
        TestInst(FCMGT(V0.T_2S, V1.T_2S, 0.0f), asm => asm.FCMGT(V0.T_2S, V1.T_2S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.2S, V1.2S, #0.0");
        TestInst(FCMGT(V30.T_2S, V1.T_2S, 0.0f), asm => asm.FCMGT(V30.T_2S, V1.T_2S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.2S, V1.2S, #0.0");
        TestInst(FCMGT(V0.T_2S, V31.T_2S, 0.0f), asm => asm.FCMGT(V0.T_2S, V31.T_2S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.2S, V31.2S, #0.0");
        TestInst(FCMGT(V30.T_2S, V31.T_2S, 0.0f), asm => asm.FCMGT(V30.T_2S, V31.T_2S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.2S, V31.2S, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdmisc_fz_14()
    {
        TestInst(FCMGT(V0.T_4S, V1.T_4S, 0.0f), asm => asm.FCMGT(V0.T_4S, V1.T_4S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.4S, V1.4S, #0.0");
        TestInst(FCMGT(V30.T_4S, V1.T_4S, 0.0f), asm => asm.FCMGT(V30.T_4S, V1.T_4S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.4S, V1.4S, #0.0");
        TestInst(FCMGT(V0.T_4S, V31.T_4S, 0.0f), asm => asm.FCMGT(V0.T_4S, V31.T_4S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.4S, V31.4S, #0.0");
        TestInst(FCMGT(V30.T_4S, V31.T_4S, 0.0f), asm => asm.FCMGT(V30.T_4S, V31.T_4S, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.4S, V31.4S, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMGT_asimdmisc_fz_15()
    {
        TestInst(FCMGT(V0.T_2D, V1.T_2D, 0.0f), asm => asm.FCMGT(V0.T_2D, V1.T_2D, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.2D, V1.2D, #0.0");
        TestInst(FCMGT(V30.T_2D, V1.T_2D, 0.0f), asm => asm.FCMGT(V30.T_2D, V1.T_2D, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.2D, V1.2D, #0.0");
        TestInst(FCMGT(V0.T_2D, V31.T_2D, 0.0f), asm => asm.FCMGT(V0.T_2D, V31.T_2D, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V0.2D, V31.2D, #0.0");
        TestInst(FCMGT(V30.T_2D, V31.T_2D, 0.0f), asm => asm.FCMGT(V30.T_2D, V31.T_2D, 0.0f), Arm64InstructionId.FCMGT_asimdmisc_fz, Arm64Mnemonic.FCMGT, "FCMGT V30.2D, V31.2D, #0.0");
    }
}
