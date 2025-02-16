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
public class Arm64InstructionFactoryTests_RADDHN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RADDHN"/>.
    /// </summary>
    [TestMethod]
    public void Test_RADDHN_asimddiff_n_0()
    {
        TestInst(RADDHN(V0.T_8B, V1.T_8H, V2.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.8B, V1.8H, V2.8H");
        TestInst(RADDHN(V30.T_8B, V1.T_8H, V2.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.8B, V1.8H, V2.8H");
        TestInst(RADDHN(V0.T_8B, V31.T_8H, V2.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.8B, V31.8H, V2.8H");
        TestInst(RADDHN(V30.T_8B, V31.T_8H, V2.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.8B, V31.8H, V2.8H");
        TestInst(RADDHN(V0.T_8B, V1.T_8H, V0.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.8B, V1.8H, V0.8H");
        TestInst(RADDHN(V30.T_8B, V1.T_8H, V0.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.8B, V1.8H, V0.8H");
        TestInst(RADDHN(V0.T_8B, V31.T_8H, V0.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.8B, V31.8H, V0.8H");
        TestInst(RADDHN(V30.T_8B, V31.T_8H, V0.T_8H), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.8B, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RADDHN"/>.
    /// </summary>
    [TestMethod]
    public void Test_RADDHN_asimddiff_n_1()
    {
        TestInst(RADDHN(V0.T_4H, V1.T_4S, V2.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.4H, V1.4S, V2.4S");
        TestInst(RADDHN(V30.T_4H, V1.T_4S, V2.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.4H, V1.4S, V2.4S");
        TestInst(RADDHN(V0.T_4H, V31.T_4S, V2.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.4H, V31.4S, V2.4S");
        TestInst(RADDHN(V30.T_4H, V31.T_4S, V2.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.4H, V31.4S, V2.4S");
        TestInst(RADDHN(V0.T_4H, V1.T_4S, V0.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.4H, V1.4S, V0.4S");
        TestInst(RADDHN(V30.T_4H, V1.T_4S, V0.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.4H, V1.4S, V0.4S");
        TestInst(RADDHN(V0.T_4H, V31.T_4S, V0.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.4H, V31.4S, V0.4S");
        TestInst(RADDHN(V30.T_4H, V31.T_4S, V0.T_4S), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.4H, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RADDHN"/>.
    /// </summary>
    [TestMethod]
    public void Test_RADDHN_asimddiff_n_2()
    {
        TestInst(RADDHN(V0.T_2S, V1.T_2D, V2.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.2S, V1.2D, V2.2D");
        TestInst(RADDHN(V30.T_2S, V1.T_2D, V2.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.2S, V1.2D, V2.2D");
        TestInst(RADDHN(V0.T_2S, V31.T_2D, V2.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.2S, V31.2D, V2.2D");
        TestInst(RADDHN(V30.T_2S, V31.T_2D, V2.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.2S, V31.2D, V2.2D");
        TestInst(RADDHN(V0.T_2S, V1.T_2D, V0.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.2S, V1.2D, V0.2D");
        TestInst(RADDHN(V30.T_2S, V1.T_2D, V0.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.2S, V1.2D, V0.2D");
        TestInst(RADDHN(V0.T_2S, V31.T_2D, V0.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V0.2S, V31.2D, V0.2D");
        TestInst(RADDHN(V30.T_2S, V31.T_2D, V0.T_2D), Arm64InstructionId.RADDHN_asimddiff_n, Arm64Mnemonic.RADDHN, "RADDHN V30.2S, V31.2D, V0.2D");
    }
}
