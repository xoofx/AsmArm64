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
public class Arm64InstructionFactoryTests_SQSHRUN2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQSHRUN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQSHRUN2_asimdshf_n_0()
    {
        TestInst(SQSHRUN2(V0.T_16B, V1.T_8H, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V0.16B, V1.8H, #5");
        TestInst(SQSHRUN2(V30.T_16B, V1.T_8H, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V30.16B, V1.8H, #5");
        TestInst(SQSHRUN2(V0.T_16B, V31.T_8H, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V0.16B, V31.8H, #5");
        TestInst(SQSHRUN2(V30.T_16B, V31.T_8H, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V30.16B, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQSHRUN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQSHRUN2_asimdshf_n_1()
    {
        TestInst(SQSHRUN2(V0.T_8H, V1.T_4S, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V0.8H, V1.4S, #5");
        TestInst(SQSHRUN2(V30.T_8H, V1.T_4S, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V30.8H, V1.4S, #5");
        TestInst(SQSHRUN2(V0.T_8H, V31.T_4S, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V0.8H, V31.4S, #5");
        TestInst(SQSHRUN2(V30.T_8H, V31.T_4S, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V30.8H, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQSHRUN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQSHRUN2_asimdshf_n_2()
    {
        TestInst(SQSHRUN2(V0.T_4S, V1.T_2D, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V0.4S, V1.2D, #5");
        TestInst(SQSHRUN2(V30.T_4S, V1.T_2D, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V30.4S, V1.2D, #5");
        TestInst(SQSHRUN2(V0.T_4S, V31.T_2D, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V0.4S, V31.2D, #5");
        TestInst(SQSHRUN2(V30.T_4S, V31.T_2D, 5), Arm64InstructionId.SQSHRUN2_asimdshf_n, Arm64Mnemonic.SQSHRUN2, "SQSHRUN2 V30.4S, V31.2D, #5");
    }
}
