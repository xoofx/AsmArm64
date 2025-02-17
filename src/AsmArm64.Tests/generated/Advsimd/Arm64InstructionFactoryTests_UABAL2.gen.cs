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
public class Arm64InstructionFactoryTests_UABAL2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UABAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UABAL2_asimddiff_l_0()
    {
        TestInst(UABAL2(V0.T_8H, V1.T_16B, V2.T_16B), asm => asm.UABAL2(V0.T_8H, V1.T_16B, V2.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.8H, V1.16B, V2.16B");
        TestInst(UABAL2(V30.T_8H, V1.T_16B, V2.T_16B), asm => asm.UABAL2(V30.T_8H, V1.T_16B, V2.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.8H, V1.16B, V2.16B");
        TestInst(UABAL2(V0.T_8H, V31.T_16B, V2.T_16B), asm => asm.UABAL2(V0.T_8H, V31.T_16B, V2.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.8H, V31.16B, V2.16B");
        TestInst(UABAL2(V30.T_8H, V31.T_16B, V2.T_16B), asm => asm.UABAL2(V30.T_8H, V31.T_16B, V2.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.8H, V31.16B, V2.16B");
        TestInst(UABAL2(V0.T_8H, V1.T_16B, V0.T_16B), asm => asm.UABAL2(V0.T_8H, V1.T_16B, V0.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.8H, V1.16B, V0.16B");
        TestInst(UABAL2(V30.T_8H, V1.T_16B, V0.T_16B), asm => asm.UABAL2(V30.T_8H, V1.T_16B, V0.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.8H, V1.16B, V0.16B");
        TestInst(UABAL2(V0.T_8H, V31.T_16B, V0.T_16B), asm => asm.UABAL2(V0.T_8H, V31.T_16B, V0.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.8H, V31.16B, V0.16B");
        TestInst(UABAL2(V30.T_8H, V31.T_16B, V0.T_16B), asm => asm.UABAL2(V30.T_8H, V31.T_16B, V0.T_16B), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.8H, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UABAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UABAL2_asimddiff_l_1()
    {
        TestInst(UABAL2(V0.T_4S, V1.T_8H, V2.T_8H), asm => asm.UABAL2(V0.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.4S, V1.8H, V2.8H");
        TestInst(UABAL2(V30.T_4S, V1.T_8H, V2.T_8H), asm => asm.UABAL2(V30.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.4S, V1.8H, V2.8H");
        TestInst(UABAL2(V0.T_4S, V31.T_8H, V2.T_8H), asm => asm.UABAL2(V0.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.4S, V31.8H, V2.8H");
        TestInst(UABAL2(V30.T_4S, V31.T_8H, V2.T_8H), asm => asm.UABAL2(V30.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.4S, V31.8H, V2.8H");
        TestInst(UABAL2(V0.T_4S, V1.T_8H, V0.T_8H), asm => asm.UABAL2(V0.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.4S, V1.8H, V0.8H");
        TestInst(UABAL2(V30.T_4S, V1.T_8H, V0.T_8H), asm => asm.UABAL2(V30.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.4S, V1.8H, V0.8H");
        TestInst(UABAL2(V0.T_4S, V31.T_8H, V0.T_8H), asm => asm.UABAL2(V0.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.4S, V31.8H, V0.8H");
        TestInst(UABAL2(V30.T_4S, V31.T_8H, V0.T_8H), asm => asm.UABAL2(V30.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.4S, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UABAL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UABAL2_asimddiff_l_2()
    {
        TestInst(UABAL2(V0.T_2D, V1.T_4S, V2.T_4S), asm => asm.UABAL2(V0.T_2D, V1.T_4S, V2.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.2D, V1.4S, V2.4S");
        TestInst(UABAL2(V30.T_2D, V1.T_4S, V2.T_4S), asm => asm.UABAL2(V30.T_2D, V1.T_4S, V2.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.2D, V1.4S, V2.4S");
        TestInst(UABAL2(V0.T_2D, V31.T_4S, V2.T_4S), asm => asm.UABAL2(V0.T_2D, V31.T_4S, V2.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.2D, V31.4S, V2.4S");
        TestInst(UABAL2(V30.T_2D, V31.T_4S, V2.T_4S), asm => asm.UABAL2(V30.T_2D, V31.T_4S, V2.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.2D, V31.4S, V2.4S");
        TestInst(UABAL2(V0.T_2D, V1.T_4S, V0.T_4S), asm => asm.UABAL2(V0.T_2D, V1.T_4S, V0.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.2D, V1.4S, V0.4S");
        TestInst(UABAL2(V30.T_2D, V1.T_4S, V0.T_4S), asm => asm.UABAL2(V30.T_2D, V1.T_4S, V0.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.2D, V1.4S, V0.4S");
        TestInst(UABAL2(V0.T_2D, V31.T_4S, V0.T_4S), asm => asm.UABAL2(V0.T_2D, V31.T_4S, V0.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V0.2D, V31.4S, V0.4S");
        TestInst(UABAL2(V30.T_2D, V31.T_4S, V0.T_4S), asm => asm.UABAL2(V30.T_2D, V31.T_4S, V0.T_4S), Arm64InstructionId.UABAL2_asimddiff_l, Arm64Mnemonic.UABAL2, "UABAL2 V30.2D, V31.4S, V0.4S");
    }
}
