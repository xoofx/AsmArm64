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
public class Arm64InstructionFactoryTests_UADDW_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UADDW"/>.
    /// </summary>
    [TestMethod]
    public void Test_UADDW_asimddiff_w_0()
    {
        TestInst(UADDW(V0.T_8H, V1.T_8H, V2.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.8H, V1.8H, V2.8B");
        TestInst(UADDW(V30.T_8H, V1.T_8H, V2.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.8H, V1.8H, V2.8B");
        TestInst(UADDW(V0.T_8H, V31.T_8H, V2.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.8H, V31.8H, V2.8B");
        TestInst(UADDW(V30.T_8H, V31.T_8H, V2.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.8H, V31.8H, V2.8B");
        TestInst(UADDW(V0.T_8H, V1.T_8H, V0.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.8H, V1.8H, V0.8B");
        TestInst(UADDW(V30.T_8H, V1.T_8H, V0.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.8H, V1.8H, V0.8B");
        TestInst(UADDW(V0.T_8H, V31.T_8H, V0.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.8H, V31.8H, V0.8B");
        TestInst(UADDW(V30.T_8H, V31.T_8H, V0.T_8B), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.8H, V31.8H, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UADDW"/>.
    /// </summary>
    [TestMethod]
    public void Test_UADDW_asimddiff_w_1()
    {
        TestInst(UADDW(V0.T_4S, V1.T_4S, V2.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.4S, V1.4S, V2.4H");
        TestInst(UADDW(V30.T_4S, V1.T_4S, V2.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.4S, V1.4S, V2.4H");
        TestInst(UADDW(V0.T_4S, V31.T_4S, V2.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.4S, V31.4S, V2.4H");
        TestInst(UADDW(V30.T_4S, V31.T_4S, V2.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.4S, V31.4S, V2.4H");
        TestInst(UADDW(V0.T_4S, V1.T_4S, V0.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.4S, V1.4S, V0.4H");
        TestInst(UADDW(V30.T_4S, V1.T_4S, V0.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.4S, V1.4S, V0.4H");
        TestInst(UADDW(V0.T_4S, V31.T_4S, V0.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.4S, V31.4S, V0.4H");
        TestInst(UADDW(V30.T_4S, V31.T_4S, V0.T_4H), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.4S, V31.4S, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UADDW"/>.
    /// </summary>
    [TestMethod]
    public void Test_UADDW_asimddiff_w_2()
    {
        TestInst(UADDW(V0.T_2D, V1.T_2D, V2.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.2D, V1.2D, V2.2S");
        TestInst(UADDW(V30.T_2D, V1.T_2D, V2.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.2D, V1.2D, V2.2S");
        TestInst(UADDW(V0.T_2D, V31.T_2D, V2.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.2D, V31.2D, V2.2S");
        TestInst(UADDW(V30.T_2D, V31.T_2D, V2.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.2D, V31.2D, V2.2S");
        TestInst(UADDW(V0.T_2D, V1.T_2D, V0.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.2D, V1.2D, V0.2S");
        TestInst(UADDW(V30.T_2D, V1.T_2D, V0.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.2D, V1.2D, V0.2S");
        TestInst(UADDW(V0.T_2D, V31.T_2D, V0.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V0.2D, V31.2D, V0.2S");
        TestInst(UADDW(V30.T_2D, V31.T_2D, V0.T_2S), Arm64InstructionId.UADDW_asimddiff_w, Arm64Mnemonic.UADDW, "UADDW V30.2D, V31.2D, V0.2S");
    }
}
