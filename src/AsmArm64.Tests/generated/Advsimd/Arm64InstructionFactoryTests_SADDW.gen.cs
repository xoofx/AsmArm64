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
public class Arm64InstructionFactoryTests_SADDW_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDW"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDW_asimddiff_w_0()
    {
        TestInst(SADDW(V0.T_8H, V1.T_8H, V2.T_8B), asm => asm.SADDW(V0.T_8H, V1.T_8H, V2.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.8H, V1.8H, V2.8B");
        TestInst(SADDW(V30.T_8H, V1.T_8H, V2.T_8B), asm => asm.SADDW(V30.T_8H, V1.T_8H, V2.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.8H, V1.8H, V2.8B");
        TestInst(SADDW(V0.T_8H, V31.T_8H, V2.T_8B), asm => asm.SADDW(V0.T_8H, V31.T_8H, V2.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.8H, V31.8H, V2.8B");
        TestInst(SADDW(V30.T_8H, V31.T_8H, V2.T_8B), asm => asm.SADDW(V30.T_8H, V31.T_8H, V2.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.8H, V31.8H, V2.8B");
        TestInst(SADDW(V0.T_8H, V1.T_8H, V0.T_8B), asm => asm.SADDW(V0.T_8H, V1.T_8H, V0.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.8H, V1.8H, V0.8B");
        TestInst(SADDW(V30.T_8H, V1.T_8H, V0.T_8B), asm => asm.SADDW(V30.T_8H, V1.T_8H, V0.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.8H, V1.8H, V0.8B");
        TestInst(SADDW(V0.T_8H, V31.T_8H, V0.T_8B), asm => asm.SADDW(V0.T_8H, V31.T_8H, V0.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.8H, V31.8H, V0.8B");
        TestInst(SADDW(V30.T_8H, V31.T_8H, V0.T_8B), asm => asm.SADDW(V30.T_8H, V31.T_8H, V0.T_8B), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.8H, V31.8H, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDW"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDW_asimddiff_w_1()
    {
        TestInst(SADDW(V0.T_4S, V1.T_4S, V2.T_4H), asm => asm.SADDW(V0.T_4S, V1.T_4S, V2.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.4S, V1.4S, V2.4H");
        TestInst(SADDW(V30.T_4S, V1.T_4S, V2.T_4H), asm => asm.SADDW(V30.T_4S, V1.T_4S, V2.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.4S, V1.4S, V2.4H");
        TestInst(SADDW(V0.T_4S, V31.T_4S, V2.T_4H), asm => asm.SADDW(V0.T_4S, V31.T_4S, V2.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.4S, V31.4S, V2.4H");
        TestInst(SADDW(V30.T_4S, V31.T_4S, V2.T_4H), asm => asm.SADDW(V30.T_4S, V31.T_4S, V2.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.4S, V31.4S, V2.4H");
        TestInst(SADDW(V0.T_4S, V1.T_4S, V0.T_4H), asm => asm.SADDW(V0.T_4S, V1.T_4S, V0.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.4S, V1.4S, V0.4H");
        TestInst(SADDW(V30.T_4S, V1.T_4S, V0.T_4H), asm => asm.SADDW(V30.T_4S, V1.T_4S, V0.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.4S, V1.4S, V0.4H");
        TestInst(SADDW(V0.T_4S, V31.T_4S, V0.T_4H), asm => asm.SADDW(V0.T_4S, V31.T_4S, V0.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.4S, V31.4S, V0.4H");
        TestInst(SADDW(V30.T_4S, V31.T_4S, V0.T_4H), asm => asm.SADDW(V30.T_4S, V31.T_4S, V0.T_4H), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.4S, V31.4S, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SADDW"/>.
    /// </summary>
    [TestMethod]
    public void Test_SADDW_asimddiff_w_2()
    {
        TestInst(SADDW(V0.T_2D, V1.T_2D, V2.T_2S), asm => asm.SADDW(V0.T_2D, V1.T_2D, V2.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.2D, V1.2D, V2.2S");
        TestInst(SADDW(V30.T_2D, V1.T_2D, V2.T_2S), asm => asm.SADDW(V30.T_2D, V1.T_2D, V2.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.2D, V1.2D, V2.2S");
        TestInst(SADDW(V0.T_2D, V31.T_2D, V2.T_2S), asm => asm.SADDW(V0.T_2D, V31.T_2D, V2.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.2D, V31.2D, V2.2S");
        TestInst(SADDW(V30.T_2D, V31.T_2D, V2.T_2S), asm => asm.SADDW(V30.T_2D, V31.T_2D, V2.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.2D, V31.2D, V2.2S");
        TestInst(SADDW(V0.T_2D, V1.T_2D, V0.T_2S), asm => asm.SADDW(V0.T_2D, V1.T_2D, V0.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.2D, V1.2D, V0.2S");
        TestInst(SADDW(V30.T_2D, V1.T_2D, V0.T_2S), asm => asm.SADDW(V30.T_2D, V1.T_2D, V0.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.2D, V1.2D, V0.2S");
        TestInst(SADDW(V0.T_2D, V31.T_2D, V0.T_2S), asm => asm.SADDW(V0.T_2D, V31.T_2D, V0.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V0.2D, V31.2D, V0.2S");
        TestInst(SADDW(V30.T_2D, V31.T_2D, V0.T_2S), asm => asm.SADDW(V30.T_2D, V31.T_2D, V0.T_2S), Arm64InstructionId.SADDW_asimddiff_w, Arm64Mnemonic.SADDW, "SADDW V30.2D, V31.2D, V0.2S");
    }
}
