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
public class Arm64InstructionFactoryTests_USHLL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.USHLL"/>.
    /// </summary>
    [TestMethod]
    public void Test_USHLL_asimdshf_l_0()
    {
        TestInst(USHLL(V0.T_8H, V1.T_8B, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V0.8H, V1.8B, #5");
        TestInst(USHLL(V30.T_8H, V1.T_8B, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V30.8H, V1.8B, #5");
        TestInst(USHLL(V0.T_8H, V31.T_8B, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V0.8H, V31.8B, #5");
        TestInst(USHLL(V30.T_8H, V31.T_8B, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V30.8H, V31.8B, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.USHLL"/>.
    /// </summary>
    [TestMethod]
    public void Test_USHLL_asimdshf_l_1()
    {
        TestInst(USHLL(V0.T_4S, V1.T_4H, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V0.4S, V1.4H, #5");
        TestInst(USHLL(V30.T_4S, V1.T_4H, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V30.4S, V1.4H, #5");
        TestInst(USHLL(V0.T_4S, V31.T_4H, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V0.4S, V31.4H, #5");
        TestInst(USHLL(V30.T_4S, V31.T_4H, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V30.4S, V31.4H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.USHLL"/>.
    /// </summary>
    [TestMethod]
    public void Test_USHLL_asimdshf_l_2()
    {
        TestInst(USHLL(V0.T_2D, V1.T_2S, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V0.2D, V1.2S, #5");
        TestInst(USHLL(V30.T_2D, V1.T_2S, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V30.2D, V1.2S, #5");
        TestInst(USHLL(V0.T_2D, V31.T_2S, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V0.2D, V31.2S, #5");
        TestInst(USHLL(V30.T_2D, V31.T_2S, 5), Arm64InstructionId.USHLL_asimdshf_l, Arm64Mnemonic.USHLL, "USHLL V30.2D, V31.2S, #5");
    }
}
