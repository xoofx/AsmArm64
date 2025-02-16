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
public class Arm64InstructionFactoryTests_UQRSHL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asisdsame_only_0()
    {
        TestInst(UQRSHL(B1, B2, B3), asm => asm.UQRSHL(B1, B2, B3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B1, B2, B3");
        TestInst(UQRSHL(B31, B2, B3), asm => asm.UQRSHL(B31, B2, B3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B31, B2, B3");
        TestInst(UQRSHL(B1, B0, B3), asm => asm.UQRSHL(B1, B0, B3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B1, B0, B3");
        TestInst(UQRSHL(B31, B0, B3), asm => asm.UQRSHL(B31, B0, B3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B31, B0, B3");
        TestInst(UQRSHL(B1, B2, B1), asm => asm.UQRSHL(B1, B2, B1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B1, B2, B1");
        TestInst(UQRSHL(B31, B2, B1), asm => asm.UQRSHL(B31, B2, B1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B31, B2, B1");
        TestInst(UQRSHL(B1, B0, B1), asm => asm.UQRSHL(B1, B0, B1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B1, B0, B1");
        TestInst(UQRSHL(B31, B0, B1), asm => asm.UQRSHL(B31, B0, B1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL B31, B0, B1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asisdsame_only_1()
    {
        TestInst(UQRSHL(H1, H2, H3), asm => asm.UQRSHL(H1, H2, H3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H1, H2, H3");
        TestInst(UQRSHL(H31, H2, H3), asm => asm.UQRSHL(H31, H2, H3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H31, H2, H3");
        TestInst(UQRSHL(H1, H0, H3), asm => asm.UQRSHL(H1, H0, H3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H1, H0, H3");
        TestInst(UQRSHL(H31, H0, H3), asm => asm.UQRSHL(H31, H0, H3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H31, H0, H3");
        TestInst(UQRSHL(H1, H2, H1), asm => asm.UQRSHL(H1, H2, H1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H1, H2, H1");
        TestInst(UQRSHL(H31, H2, H1), asm => asm.UQRSHL(H31, H2, H1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H31, H2, H1");
        TestInst(UQRSHL(H1, H0, H1), asm => asm.UQRSHL(H1, H0, H1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H1, H0, H1");
        TestInst(UQRSHL(H31, H0, H1), asm => asm.UQRSHL(H31, H0, H1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL H31, H0, H1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asisdsame_only_2()
    {
        TestInst(UQRSHL(S1, S2, S3), asm => asm.UQRSHL(S1, S2, S3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S1, S2, S3");
        TestInst(UQRSHL(S31, S2, S3), asm => asm.UQRSHL(S31, S2, S3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S31, S2, S3");
        TestInst(UQRSHL(S1, S0, S3), asm => asm.UQRSHL(S1, S0, S3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S1, S0, S3");
        TestInst(UQRSHL(S31, S0, S3), asm => asm.UQRSHL(S31, S0, S3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S31, S0, S3");
        TestInst(UQRSHL(S1, S2, S1), asm => asm.UQRSHL(S1, S2, S1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S1, S2, S1");
        TestInst(UQRSHL(S31, S2, S1), asm => asm.UQRSHL(S31, S2, S1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S31, S2, S1");
        TestInst(UQRSHL(S1, S0, S1), asm => asm.UQRSHL(S1, S0, S1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S1, S0, S1");
        TestInst(UQRSHL(S31, S0, S1), asm => asm.UQRSHL(S31, S0, S1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL S31, S0, S1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asisdsame_only_3()
    {
        TestInst(UQRSHL(D1, D2, D3), asm => asm.UQRSHL(D1, D2, D3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D1, D2, D3");
        TestInst(UQRSHL(D31, D2, D3), asm => asm.UQRSHL(D31, D2, D3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D31, D2, D3");
        TestInst(UQRSHL(D1, D0, D3), asm => asm.UQRSHL(D1, D0, D3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D1, D0, D3");
        TestInst(UQRSHL(D31, D0, D3), asm => asm.UQRSHL(D31, D0, D3), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D31, D0, D3");
        TestInst(UQRSHL(D1, D2, D1), asm => asm.UQRSHL(D1, D2, D1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D1, D2, D1");
        TestInst(UQRSHL(D31, D2, D1), asm => asm.UQRSHL(D31, D2, D1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D31, D2, D1");
        TestInst(UQRSHL(D1, D0, D1), asm => asm.UQRSHL(D1, D0, D1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D1, D0, D1");
        TestInst(UQRSHL(D31, D0, D1), asm => asm.UQRSHL(D31, D0, D1), Arm64InstructionId.UQRSHL_asisdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL D31, D0, D1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_4()
    {
        TestInst(UQRSHL(V0.T_8B, V1.T_8B, V2.T_8B), asm => asm.UQRSHL(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8B, V1.8B, V2.8B");
        TestInst(UQRSHL(V30.T_8B, V1.T_8B, V2.T_8B), asm => asm.UQRSHL(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8B, V1.8B, V2.8B");
        TestInst(UQRSHL(V0.T_8B, V31.T_8B, V2.T_8B), asm => asm.UQRSHL(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8B, V31.8B, V2.8B");
        TestInst(UQRSHL(V30.T_8B, V31.T_8B, V2.T_8B), asm => asm.UQRSHL(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8B, V31.8B, V2.8B");
        TestInst(UQRSHL(V0.T_8B, V1.T_8B, V0.T_8B), asm => asm.UQRSHL(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8B, V1.8B, V0.8B");
        TestInst(UQRSHL(V30.T_8B, V1.T_8B, V0.T_8B), asm => asm.UQRSHL(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8B, V1.8B, V0.8B");
        TestInst(UQRSHL(V0.T_8B, V31.T_8B, V0.T_8B), asm => asm.UQRSHL(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8B, V31.8B, V0.8B");
        TestInst(UQRSHL(V30.T_8B, V31.T_8B, V0.T_8B), asm => asm.UQRSHL(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_5()
    {
        TestInst(UQRSHL(V0.T_16B, V1.T_16B, V2.T_16B), asm => asm.UQRSHL(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.16B, V1.16B, V2.16B");
        TestInst(UQRSHL(V30.T_16B, V1.T_16B, V2.T_16B), asm => asm.UQRSHL(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.16B, V1.16B, V2.16B");
        TestInst(UQRSHL(V0.T_16B, V31.T_16B, V2.T_16B), asm => asm.UQRSHL(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.16B, V31.16B, V2.16B");
        TestInst(UQRSHL(V30.T_16B, V31.T_16B, V2.T_16B), asm => asm.UQRSHL(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.16B, V31.16B, V2.16B");
        TestInst(UQRSHL(V0.T_16B, V1.T_16B, V0.T_16B), asm => asm.UQRSHL(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.16B, V1.16B, V0.16B");
        TestInst(UQRSHL(V30.T_16B, V1.T_16B, V0.T_16B), asm => asm.UQRSHL(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.16B, V1.16B, V0.16B");
        TestInst(UQRSHL(V0.T_16B, V31.T_16B, V0.T_16B), asm => asm.UQRSHL(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.16B, V31.16B, V0.16B");
        TestInst(UQRSHL(V30.T_16B, V31.T_16B, V0.T_16B), asm => asm.UQRSHL(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.16B, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_6()
    {
        TestInst(UQRSHL(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.UQRSHL(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4H, V1.4H, V2.4H");
        TestInst(UQRSHL(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.UQRSHL(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4H, V1.4H, V2.4H");
        TestInst(UQRSHL(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.UQRSHL(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4H, V31.4H, V2.4H");
        TestInst(UQRSHL(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.UQRSHL(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4H, V31.4H, V2.4H");
        TestInst(UQRSHL(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.UQRSHL(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4H, V1.4H, V0.4H");
        TestInst(UQRSHL(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.UQRSHL(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4H, V1.4H, V0.4H");
        TestInst(UQRSHL(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.UQRSHL(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4H, V31.4H, V0.4H");
        TestInst(UQRSHL(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.UQRSHL(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_7()
    {
        TestInst(UQRSHL(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.UQRSHL(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8H, V1.8H, V2.8H");
        TestInst(UQRSHL(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.UQRSHL(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8H, V1.8H, V2.8H");
        TestInst(UQRSHL(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.UQRSHL(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8H, V31.8H, V2.8H");
        TestInst(UQRSHL(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.UQRSHL(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8H, V31.8H, V2.8H");
        TestInst(UQRSHL(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.UQRSHL(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8H, V1.8H, V0.8H");
        TestInst(UQRSHL(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.UQRSHL(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8H, V1.8H, V0.8H");
        TestInst(UQRSHL(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.UQRSHL(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.8H, V31.8H, V0.8H");
        TestInst(UQRSHL(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.UQRSHL(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_8()
    {
        TestInst(UQRSHL(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.UQRSHL(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2S, V1.2S, V2.2S");
        TestInst(UQRSHL(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.UQRSHL(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2S, V1.2S, V2.2S");
        TestInst(UQRSHL(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.UQRSHL(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2S, V31.2S, V2.2S");
        TestInst(UQRSHL(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.UQRSHL(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2S, V31.2S, V2.2S");
        TestInst(UQRSHL(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.UQRSHL(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2S, V1.2S, V0.2S");
        TestInst(UQRSHL(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.UQRSHL(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2S, V1.2S, V0.2S");
        TestInst(UQRSHL(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.UQRSHL(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2S, V31.2S, V0.2S");
        TestInst(UQRSHL(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.UQRSHL(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_9()
    {
        TestInst(UQRSHL(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.UQRSHL(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4S, V1.4S, V2.4S");
        TestInst(UQRSHL(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.UQRSHL(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4S, V1.4S, V2.4S");
        TestInst(UQRSHL(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.UQRSHL(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4S, V31.4S, V2.4S");
        TestInst(UQRSHL(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.UQRSHL(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4S, V31.4S, V2.4S");
        TestInst(UQRSHL(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.UQRSHL(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4S, V1.4S, V0.4S");
        TestInst(UQRSHL(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.UQRSHL(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4S, V1.4S, V0.4S");
        TestInst(UQRSHL(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.UQRSHL(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.4S, V31.4S, V0.4S");
        TestInst(UQRSHL(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.UQRSHL(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHL_asimdsame_only_10()
    {
        TestInst(UQRSHL(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.UQRSHL(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2D, V1.2D, V2.2D");
        TestInst(UQRSHL(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.UQRSHL(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2D, V1.2D, V2.2D");
        TestInst(UQRSHL(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.UQRSHL(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2D, V31.2D, V2.2D");
        TestInst(UQRSHL(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.UQRSHL(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2D, V31.2D, V2.2D");
        TestInst(UQRSHL(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.UQRSHL(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2D, V1.2D, V0.2D");
        TestInst(UQRSHL(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.UQRSHL(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2D, V1.2D, V0.2D");
        TestInst(UQRSHL(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.UQRSHL(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V0.2D, V31.2D, V0.2D");
        TestInst(UQRSHL(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.UQRSHL(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.UQRSHL_asimdsame_only, Arm64Mnemonic.UQRSHL, "UQRSHL V30.2D, V31.2D, V0.2D");
    }
}
