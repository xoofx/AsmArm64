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
public class Arm64InstructionFactoryTests_FRINTI_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_asimdmiscfp16_r_0()
    {
        TestInst(FRINTI(V0.T_4H, V1.T_4H), asm => asm.FRINTI(V0.T_4H, V1.T_4H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V0.4H, V1.4H");
        TestInst(FRINTI(V30.T_4H, V1.T_4H), asm => asm.FRINTI(V30.T_4H, V1.T_4H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V30.4H, V1.4H");
        TestInst(FRINTI(V0.T_4H, V31.T_4H), asm => asm.FRINTI(V0.T_4H, V31.T_4H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V0.4H, V31.4H");
        TestInst(FRINTI(V30.T_4H, V31.T_4H), asm => asm.FRINTI(V30.T_4H, V31.T_4H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_asimdmiscfp16_r_1()
    {
        TestInst(FRINTI(V0.T_8H, V1.T_8H), asm => asm.FRINTI(V0.T_8H, V1.T_8H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V0.8H, V1.8H");
        TestInst(FRINTI(V30.T_8H, V1.T_8H), asm => asm.FRINTI(V30.T_8H, V1.T_8H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V30.8H, V1.8H");
        TestInst(FRINTI(V0.T_8H, V31.T_8H), asm => asm.FRINTI(V0.T_8H, V31.T_8H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V0.8H, V31.8H");
        TestInst(FRINTI(V30.T_8H, V31.T_8H), asm => asm.FRINTI(V30.T_8H, V31.T_8H), Arm64InstructionId.FRINTI_asimdmiscfp16_r, Arm64Mnemonic.FRINTI, "FRINTI V30.8H, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_asimdmisc_r_2()
    {
        TestInst(FRINTI(V0.T_2S, V1.T_2S), asm => asm.FRINTI(V0.T_2S, V1.T_2S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V0.2S, V1.2S");
        TestInst(FRINTI(V30.T_2S, V1.T_2S), asm => asm.FRINTI(V30.T_2S, V1.T_2S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V30.2S, V1.2S");
        TestInst(FRINTI(V0.T_2S, V31.T_2S), asm => asm.FRINTI(V0.T_2S, V31.T_2S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V0.2S, V31.2S");
        TestInst(FRINTI(V30.T_2S, V31.T_2S), asm => asm.FRINTI(V30.T_2S, V31.T_2S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_asimdmisc_r_3()
    {
        TestInst(FRINTI(V0.T_4S, V1.T_4S), asm => asm.FRINTI(V0.T_4S, V1.T_4S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V0.4S, V1.4S");
        TestInst(FRINTI(V30.T_4S, V1.T_4S), asm => asm.FRINTI(V30.T_4S, V1.T_4S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V30.4S, V1.4S");
        TestInst(FRINTI(V0.T_4S, V31.T_4S), asm => asm.FRINTI(V0.T_4S, V31.T_4S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V0.4S, V31.4S");
        TestInst(FRINTI(V30.T_4S, V31.T_4S), asm => asm.FRINTI(V30.T_4S, V31.T_4S), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V30.4S, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTI_asimdmisc_r_4()
    {
        TestInst(FRINTI(V0.T_2D, V1.T_2D), asm => asm.FRINTI(V0.T_2D, V1.T_2D), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V0.2D, V1.2D");
        TestInst(FRINTI(V30.T_2D, V1.T_2D), asm => asm.FRINTI(V30.T_2D, V1.T_2D), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V30.2D, V1.2D");
        TestInst(FRINTI(V0.T_2D, V31.T_2D), asm => asm.FRINTI(V0.T_2D, V31.T_2D), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V0.2D, V31.2D");
        TestInst(FRINTI(V30.T_2D, V31.T_2D), asm => asm.FRINTI(V30.T_2D, V31.T_2D), Arm64InstructionId.FRINTI_asimdmisc_r, Arm64Mnemonic.FRINTI, "FRINTI V30.2D, V31.2D");
    }
}
