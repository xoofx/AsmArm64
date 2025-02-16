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
public class Arm64InstructionFactoryTests_UMLAL2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL2_asimdelem_l_0()
    {
        TestInst(UMLAL2(V0.T_4S, V1.T_8H, V2.H[0]), asm => asm.UMLAL2(V0.T_4S, V1.T_8H, V2.H[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V1.8H, V2.H[0]");
        TestInst(UMLAL2(V30.T_4S, V1.T_8H, V2.H[0]), asm => asm.UMLAL2(V30.T_4S, V1.T_8H, V2.H[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V1.8H, V2.H[0]");
        TestInst(UMLAL2(V0.T_4S, V31.T_8H, V2.H[0]), asm => asm.UMLAL2(V0.T_4S, V31.T_8H, V2.H[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V31.8H, V2.H[0]");
        TestInst(UMLAL2(V30.T_4S, V31.T_8H, V2.H[0]), asm => asm.UMLAL2(V30.T_4S, V31.T_8H, V2.H[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V31.8H, V2.H[0]");
        TestInst(UMLAL2(V0.T_4S, V1.T_8H, V0.H[1]), asm => asm.UMLAL2(V0.T_4S, V1.T_8H, V0.H[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V1.8H, V0.H[1]");
        TestInst(UMLAL2(V30.T_4S, V1.T_8H, V0.H[1]), asm => asm.UMLAL2(V30.T_4S, V1.T_8H, V0.H[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V1.8H, V0.H[1]");
        TestInst(UMLAL2(V0.T_4S, V31.T_8H, V0.H[1]), asm => asm.UMLAL2(V0.T_4S, V31.T_8H, V0.H[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V31.8H, V0.H[1]");
        TestInst(UMLAL2(V30.T_4S, V31.T_8H, V0.H[1]), asm => asm.UMLAL2(V30.T_4S, V31.T_8H, V0.H[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V31.8H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL2_asimdelem_l_1()
    {
        TestInst(UMLAL2(V0.T_2D, V1.T_4S, V2.S[0]), asm => asm.UMLAL2(V0.T_2D, V1.T_4S, V2.S[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V1.4S, V2.S[0]");
        TestInst(UMLAL2(V30.T_2D, V1.T_4S, V2.S[0]), asm => asm.UMLAL2(V30.T_2D, V1.T_4S, V2.S[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V1.4S, V2.S[0]");
        TestInst(UMLAL2(V0.T_2D, V31.T_4S, V2.S[0]), asm => asm.UMLAL2(V0.T_2D, V31.T_4S, V2.S[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V31.4S, V2.S[0]");
        TestInst(UMLAL2(V30.T_2D, V31.T_4S, V2.S[0]), asm => asm.UMLAL2(V30.T_2D, V31.T_4S, V2.S[0]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V31.4S, V2.S[0]");
        TestInst(UMLAL2(V0.T_2D, V1.T_4S, V0.S[1]), asm => asm.UMLAL2(V0.T_2D, V1.T_4S, V0.S[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V1.4S, V0.S[1]");
        TestInst(UMLAL2(V30.T_2D, V1.T_4S, V0.S[1]), asm => asm.UMLAL2(V30.T_2D, V1.T_4S, V0.S[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V1.4S, V0.S[1]");
        TestInst(UMLAL2(V0.T_2D, V31.T_4S, V0.S[1]), asm => asm.UMLAL2(V0.T_2D, V31.T_4S, V0.S[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V31.4S, V0.S[1]");
        TestInst(UMLAL2(V30.T_2D, V31.T_4S, V0.S[1]), asm => asm.UMLAL2(V30.T_2D, V31.T_4S, V0.S[1]), Arm64InstructionId.UMLAL2_asimdelem_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V31.4S, V0.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL2_asimddiff_l_2()
    {
        TestInst(UMLAL2(V0.T_8H, V1.T_16B, V2.T_16B), asm => asm.UMLAL2(V0.T_8H, V1.T_16B, V2.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.8H, V1.16B, V2.16B");
        TestInst(UMLAL2(V30.T_8H, V1.T_16B, V2.T_16B), asm => asm.UMLAL2(V30.T_8H, V1.T_16B, V2.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.8H, V1.16B, V2.16B");
        TestInst(UMLAL2(V0.T_8H, V31.T_16B, V2.T_16B), asm => asm.UMLAL2(V0.T_8H, V31.T_16B, V2.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.8H, V31.16B, V2.16B");
        TestInst(UMLAL2(V30.T_8H, V31.T_16B, V2.T_16B), asm => asm.UMLAL2(V30.T_8H, V31.T_16B, V2.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.8H, V31.16B, V2.16B");
        TestInst(UMLAL2(V0.T_8H, V1.T_16B, V0.T_16B), asm => asm.UMLAL2(V0.T_8H, V1.T_16B, V0.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.8H, V1.16B, V0.16B");
        TestInst(UMLAL2(V30.T_8H, V1.T_16B, V0.T_16B), asm => asm.UMLAL2(V30.T_8H, V1.T_16B, V0.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.8H, V1.16B, V0.16B");
        TestInst(UMLAL2(V0.T_8H, V31.T_16B, V0.T_16B), asm => asm.UMLAL2(V0.T_8H, V31.T_16B, V0.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.8H, V31.16B, V0.16B");
        TestInst(UMLAL2(V30.T_8H, V31.T_16B, V0.T_16B), asm => asm.UMLAL2(V30.T_8H, V31.T_16B, V0.T_16B), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.8H, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL2_asimddiff_l_3()
    {
        TestInst(UMLAL2(V0.T_4S, V1.T_8H, V2.T_8H), asm => asm.UMLAL2(V0.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V1.8H, V2.8H");
        TestInst(UMLAL2(V30.T_4S, V1.T_8H, V2.T_8H), asm => asm.UMLAL2(V30.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V1.8H, V2.8H");
        TestInst(UMLAL2(V0.T_4S, V31.T_8H, V2.T_8H), asm => asm.UMLAL2(V0.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V31.8H, V2.8H");
        TestInst(UMLAL2(V30.T_4S, V31.T_8H, V2.T_8H), asm => asm.UMLAL2(V30.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V31.8H, V2.8H");
        TestInst(UMLAL2(V0.T_4S, V1.T_8H, V0.T_8H), asm => asm.UMLAL2(V0.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V1.8H, V0.8H");
        TestInst(UMLAL2(V30.T_4S, V1.T_8H, V0.T_8H), asm => asm.UMLAL2(V30.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V1.8H, V0.8H");
        TestInst(UMLAL2(V0.T_4S, V31.T_8H, V0.T_8H), asm => asm.UMLAL2(V0.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.4S, V31.8H, V0.8H");
        TestInst(UMLAL2(V30.T_4S, V31.T_8H, V0.T_8H), asm => asm.UMLAL2(V30.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.4S, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMLAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMLAL2_asimddiff_l_4()
    {
        TestInst(UMLAL2(V0.T_2D, V1.T_4S, V2.T_4S), asm => asm.UMLAL2(V0.T_2D, V1.T_4S, V2.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V1.4S, V2.4S");
        TestInst(UMLAL2(V30.T_2D, V1.T_4S, V2.T_4S), asm => asm.UMLAL2(V30.T_2D, V1.T_4S, V2.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V1.4S, V2.4S");
        TestInst(UMLAL2(V0.T_2D, V31.T_4S, V2.T_4S), asm => asm.UMLAL2(V0.T_2D, V31.T_4S, V2.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V31.4S, V2.4S");
        TestInst(UMLAL2(V30.T_2D, V31.T_4S, V2.T_4S), asm => asm.UMLAL2(V30.T_2D, V31.T_4S, V2.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V31.4S, V2.4S");
        TestInst(UMLAL2(V0.T_2D, V1.T_4S, V0.T_4S), asm => asm.UMLAL2(V0.T_2D, V1.T_4S, V0.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V1.4S, V0.4S");
        TestInst(UMLAL2(V30.T_2D, V1.T_4S, V0.T_4S), asm => asm.UMLAL2(V30.T_2D, V1.T_4S, V0.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V1.4S, V0.4S");
        TestInst(UMLAL2(V0.T_2D, V31.T_4S, V0.T_4S), asm => asm.UMLAL2(V0.T_2D, V31.T_4S, V0.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V0.2D, V31.4S, V0.4S");
        TestInst(UMLAL2(V30.T_2D, V31.T_4S, V0.T_4S), asm => asm.UMLAL2(V30.T_2D, V31.T_4S, V0.T_4S), Arm64InstructionId.UMLAL2_asimddiff_l, Arm64Mnemonic.UMLAL2, "UMLAL2 V30.2D, V31.4S, V0.4S");
    }
}
