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
public class Arm64InstructionFactoryTests_UXTL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UXTL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UXTL_ushll_asimdshf_l_0()
    {
        TestInst(UXTL(V0.T_8H, V1.T_8B), asm => asm.UXTL(V0.T_8H, V1.T_8B), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V0.8H, V1.8B");
        TestInst(UXTL(V30.T_8H, V1.T_8B), asm => asm.UXTL(V30.T_8H, V1.T_8B), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V30.8H, V1.8B");
        TestInst(UXTL(V0.T_8H, V31.T_8B), asm => asm.UXTL(V0.T_8H, V31.T_8B), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V0.8H, V31.8B");
        TestInst(UXTL(V30.T_8H, V31.T_8B), asm => asm.UXTL(V30.T_8H, V31.T_8B), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V30.8H, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UXTL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UXTL_ushll_asimdshf_l_1()
    {
        TestInst(UXTL(V0.T_4S, V1.T_4H), asm => asm.UXTL(V0.T_4S, V1.T_4H), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V0.4S, V1.4H");
        TestInst(UXTL(V30.T_4S, V1.T_4H), asm => asm.UXTL(V30.T_4S, V1.T_4H), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V30.4S, V1.4H");
        TestInst(UXTL(V0.T_4S, V31.T_4H), asm => asm.UXTL(V0.T_4S, V31.T_4H), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V0.4S, V31.4H");
        TestInst(UXTL(V30.T_4S, V31.T_4H), asm => asm.UXTL(V30.T_4S, V31.T_4H), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V30.4S, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UXTL"/>.
    /// </summary>
    [TestMethod]
    public void Test_UXTL_ushll_asimdshf_l_2()
    {
        TestInst(UXTL(V0.T_2D, V1.T_2S), asm => asm.UXTL(V0.T_2D, V1.T_2S), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V0.2D, V1.2S");
        TestInst(UXTL(V30.T_2D, V1.T_2S), asm => asm.UXTL(V30.T_2D, V1.T_2S), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V30.2D, V1.2S");
        TestInst(UXTL(V0.T_2D, V31.T_2S), asm => asm.UXTL(V0.T_2D, V31.T_2S), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V0.2D, V31.2S");
        TestInst(UXTL(V30.T_2D, V31.T_2S), asm => asm.UXTL(V30.T_2D, V31.T_2S), Arm64InstructionId.UXTL_ushll_asimdshf_l, Arm64Mnemonic.UXTL, "UXTL V30.2D, V31.2S");
    }
}
