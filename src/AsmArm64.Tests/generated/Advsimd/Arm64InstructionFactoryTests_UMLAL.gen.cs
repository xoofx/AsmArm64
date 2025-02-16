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
public class Arm64InstructionFactoryTests_UMLAL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL_asimdelem_l_0()
    {
        TestInst(UMLAL(V0.T_4S, V1.T_4H, V2.H[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V1.4H, V2.H[0]");
        TestInst(UMLAL(V30.T_4S, V1.T_4H, V2.H[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V1.4H, V2.H[0]");
        TestInst(UMLAL(V0.T_4S, V31.T_4H, V2.H[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V31.4H, V2.H[0]");
        TestInst(UMLAL(V30.T_4S, V31.T_4H, V2.H[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V31.4H, V2.H[0]");
        TestInst(UMLAL(V0.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V1.4H, V0.H[1]");
        TestInst(UMLAL(V30.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V1.4H, V0.H[1]");
        TestInst(UMLAL(V0.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V31.4H, V0.H[1]");
        TestInst(UMLAL(V30.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL_asimdelem_l_1()
    {
        TestInst(UMLAL(V0.T_2D, V1.T_2S, V2.S[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V1.2S, V2.S[0]");
        TestInst(UMLAL(V30.T_2D, V1.T_2S, V2.S[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V1.2S, V2.S[0]");
        TestInst(UMLAL(V0.T_2D, V31.T_2S, V2.S[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V31.2S, V2.S[0]");
        TestInst(UMLAL(V30.T_2D, V31.T_2S, V2.S[0]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V31.2S, V2.S[0]");
        TestInst(UMLAL(V0.T_2D, V1.T_2S, V0.S[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V1.2S, V0.S[1]");
        TestInst(UMLAL(V30.T_2D, V1.T_2S, V0.S[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V1.2S, V0.S[1]");
        TestInst(UMLAL(V0.T_2D, V31.T_2S, V0.S[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V31.2S, V0.S[1]");
        TestInst(UMLAL(V30.T_2D, V31.T_2S, V0.S[1]), Arm64InstructionId.UMLAL_asimdelem_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V31.2S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL_asimddiff_l_2()
    {
        TestInst(UMLAL(V0.T_8H, V1.T_8B, V2.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.8H, V1.8B, V2.8B");
        TestInst(UMLAL(V30.T_8H, V1.T_8B, V2.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.8H, V1.8B, V2.8B");
        TestInst(UMLAL(V0.T_8H, V31.T_8B, V2.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.8H, V31.8B, V2.8B");
        TestInst(UMLAL(V30.T_8H, V31.T_8B, V2.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.8H, V31.8B, V2.8B");
        TestInst(UMLAL(V0.T_8H, V1.T_8B, V0.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.8H, V1.8B, V0.8B");
        TestInst(UMLAL(V30.T_8H, V1.T_8B, V0.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.8H, V1.8B, V0.8B");
        TestInst(UMLAL(V0.T_8H, V31.T_8B, V0.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.8H, V31.8B, V0.8B");
        TestInst(UMLAL(V30.T_8H, V31.T_8B, V0.T_8B), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.8H, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL_asimddiff_l_3()
    {
        TestInst(UMLAL(V0.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V1.4H, V2.4H");
        TestInst(UMLAL(V30.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V1.4H, V2.4H");
        TestInst(UMLAL(V0.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V31.4H, V2.4H");
        TestInst(UMLAL(V30.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V31.4H, V2.4H");
        TestInst(UMLAL(V0.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V1.4H, V0.4H");
        TestInst(UMLAL(V30.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V1.4H, V0.4H");
        TestInst(UMLAL(V0.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.4S, V31.4H, V0.4H");
        TestInst(UMLAL(V30.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.4S, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL_asimddiff_l_4()
    {
        TestInst(UMLAL(V0.T_2D, V1.T_2S, V2.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V1.2S, V2.2S");
        TestInst(UMLAL(V30.T_2D, V1.T_2S, V2.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V1.2S, V2.2S");
        TestInst(UMLAL(V0.T_2D, V31.T_2S, V2.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V31.2S, V2.2S");
        TestInst(UMLAL(V30.T_2D, V31.T_2S, V2.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V31.2S, V2.2S");
        TestInst(UMLAL(V0.T_2D, V1.T_2S, V0.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V1.2S, V0.2S");
        TestInst(UMLAL(V30.T_2D, V1.T_2S, V0.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V1.2S, V0.2S");
        TestInst(UMLAL(V0.T_2D, V31.T_2S, V0.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V0.2D, V31.2S, V0.2S");
        TestInst(UMLAL(V30.T_2D, V31.T_2S, V0.T_2S), Arm64InstructionId.UMLAL_asimddiff_l, Arm64Mnemonic.UMLAL, "UMLAL V30.2D, V31.2S, V0.2S");
    }
}
