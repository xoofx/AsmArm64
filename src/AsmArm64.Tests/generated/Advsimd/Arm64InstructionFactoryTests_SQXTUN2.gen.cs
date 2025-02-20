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
public class Arm64InstructionFactoryTests_SQXTUN2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN2_asimdmisc_n_0()
    {
        TestInst(SQXTUN2(V0.T_16B, V1.T_8H), asm => asm.SQXTUN2(V0.T_16B, V1.T_8H), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V0.16B, V1.8H");
        TestInst(SQXTUN2(V30.T_16B, V1.T_8H), asm => asm.SQXTUN2(V30.T_16B, V1.T_8H), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V30.16B, V1.8H");
        TestInst(SQXTUN2(V0.T_16B, V31.T_8H), asm => asm.SQXTUN2(V0.T_16B, V31.T_8H), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V0.16B, V31.8H");
        TestInst(SQXTUN2(V30.T_16B, V31.T_8H), asm => asm.SQXTUN2(V30.T_16B, V31.T_8H), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V30.16B, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN2_asimdmisc_n_1()
    {
        TestInst(SQXTUN2(V0.T_8H, V1.T_4S), asm => asm.SQXTUN2(V0.T_8H, V1.T_4S), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V0.8H, V1.4S");
        TestInst(SQXTUN2(V30.T_8H, V1.T_4S), asm => asm.SQXTUN2(V30.T_8H, V1.T_4S), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V30.8H, V1.4S");
        TestInst(SQXTUN2(V0.T_8H, V31.T_4S), asm => asm.SQXTUN2(V0.T_8H, V31.T_4S), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V0.8H, V31.4S");
        TestInst(SQXTUN2(V30.T_8H, V31.T_4S), asm => asm.SQXTUN2(V30.T_8H, V31.T_4S), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V30.8H, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN2_asimdmisc_n_2()
    {
        TestInst(SQXTUN2(V0.T_4S, V1.T_2D), asm => asm.SQXTUN2(V0.T_4S, V1.T_2D), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V0.4S, V1.2D");
        TestInst(SQXTUN2(V30.T_4S, V1.T_2D), asm => asm.SQXTUN2(V30.T_4S, V1.T_2D), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V30.4S, V1.2D");
        TestInst(SQXTUN2(V0.T_4S, V31.T_2D), asm => asm.SQXTUN2(V0.T_4S, V31.T_2D), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V0.4S, V31.2D");
        TestInst(SQXTUN2(V30.T_4S, V31.T_2D), asm => asm.SQXTUN2(V30.T_4S, V31.T_2D), Arm64InstructionId.SQXTUN2_asimdmisc_n, Arm64Mnemonic.SQXTUN2, "SQXTUN2 V30.4S, V31.2D");
    }
}
