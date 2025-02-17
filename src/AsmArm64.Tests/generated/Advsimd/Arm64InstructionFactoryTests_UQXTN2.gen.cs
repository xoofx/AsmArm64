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
public class Arm64InstructionFactoryTests_UQXTN2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQXTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQXTN2_asimdmisc_n_0()
    {
        TestInst(UQXTN2(V0.T_16B, V1.T_8H), asm => asm.UQXTN2(V0.T_16B, V1.T_8H), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V0.16B, V1.8H");
        TestInst(UQXTN2(V30.T_16B, V1.T_8H), asm => asm.UQXTN2(V30.T_16B, V1.T_8H), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V30.16B, V1.8H");
        TestInst(UQXTN2(V0.T_16B, V31.T_8H), asm => asm.UQXTN2(V0.T_16B, V31.T_8H), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V0.16B, V31.8H");
        TestInst(UQXTN2(V30.T_16B, V31.T_8H), asm => asm.UQXTN2(V30.T_16B, V31.T_8H), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V30.16B, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQXTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQXTN2_asimdmisc_n_1()
    {
        TestInst(UQXTN2(V0.T_8H, V1.T_4S), asm => asm.UQXTN2(V0.T_8H, V1.T_4S), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V0.8H, V1.4S");
        TestInst(UQXTN2(V30.T_8H, V1.T_4S), asm => asm.UQXTN2(V30.T_8H, V1.T_4S), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V30.8H, V1.4S");
        TestInst(UQXTN2(V0.T_8H, V31.T_4S), asm => asm.UQXTN2(V0.T_8H, V31.T_4S), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V0.8H, V31.4S");
        TestInst(UQXTN2(V30.T_8H, V31.T_4S), asm => asm.UQXTN2(V30.T_8H, V31.T_4S), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V30.8H, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQXTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQXTN2_asimdmisc_n_2()
    {
        TestInst(UQXTN2(V0.T_4S, V1.T_2D), asm => asm.UQXTN2(V0.T_4S, V1.T_2D), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V0.4S, V1.2D");
        TestInst(UQXTN2(V30.T_4S, V1.T_2D), asm => asm.UQXTN2(V30.T_4S, V1.T_2D), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V30.4S, V1.2D");
        TestInst(UQXTN2(V0.T_4S, V31.T_2D), asm => asm.UQXTN2(V0.T_4S, V31.T_2D), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V0.4S, V31.2D");
        TestInst(UQXTN2(V30.T_4S, V31.T_2D), asm => asm.UQXTN2(V30.T_4S, V31.T_2D), Arm64InstructionId.UQXTN2_asimdmisc_n, Arm64Mnemonic.UQXTN2, "UQXTN2 V30.4S, V31.2D");
    }
}
