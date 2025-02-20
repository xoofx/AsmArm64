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
public class Arm64InstructionFactoryTests_UQSHRN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asisdshf_n_0()
    {
        TestInst(UQSHRN(B1, H2, 5), asm => asm.UQSHRN(B1, H2, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN B1, H2, #5");
        TestInst(UQSHRN(B31, H2, 5), asm => asm.UQSHRN(B31, H2, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN B31, H2, #5");
        TestInst(UQSHRN(B1, H0, 5), asm => asm.UQSHRN(B1, H0, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN B1, H0, #5");
        TestInst(UQSHRN(B31, H0, 5), asm => asm.UQSHRN(B31, H0, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN B31, H0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asisdshf_n_1()
    {
        TestInst(UQSHRN(H1, S2, 5), asm => asm.UQSHRN(H1, S2, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN H1, S2, #5");
        TestInst(UQSHRN(H31, S2, 5), asm => asm.UQSHRN(H31, S2, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN H31, S2, #5");
        TestInst(UQSHRN(H1, S0, 5), asm => asm.UQSHRN(H1, S0, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN H1, S0, #5");
        TestInst(UQSHRN(H31, S0, 5), asm => asm.UQSHRN(H31, S0, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN H31, S0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asisdshf_n_2()
    {
        TestInst(UQSHRN(S1, D2, 5), asm => asm.UQSHRN(S1, D2, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN S1, D2, #5");
        TestInst(UQSHRN(S31, D2, 5), asm => asm.UQSHRN(S31, D2, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN S31, D2, #5");
        TestInst(UQSHRN(S1, D0, 5), asm => asm.UQSHRN(S1, D0, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN S1, D0, #5");
        TestInst(UQSHRN(S31, D0, 5), asm => asm.UQSHRN(S31, D0, 5), Arm64InstructionId.UQSHRN_asisdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN S31, D0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asimdshf_n_3()
    {
        TestInst(UQSHRN(V0.T_8B, V1.T_8H, 5), asm => asm.UQSHRN(V0.T_8B, V1.T_8H, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V0.8B, V1.8H, #5");
        TestInst(UQSHRN(V30.T_8B, V1.T_8H, 5), asm => asm.UQSHRN(V30.T_8B, V1.T_8H, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V30.8B, V1.8H, #5");
        TestInst(UQSHRN(V0.T_8B, V31.T_8H, 5), asm => asm.UQSHRN(V0.T_8B, V31.T_8H, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V0.8B, V31.8H, #5");
        TestInst(UQSHRN(V30.T_8B, V31.T_8H, 5), asm => asm.UQSHRN(V30.T_8B, V31.T_8H, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V30.8B, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asimdshf_n_4()
    {
        TestInst(UQSHRN(V0.T_4H, V1.T_4S, 5), asm => asm.UQSHRN(V0.T_4H, V1.T_4S, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V0.4H, V1.4S, #5");
        TestInst(UQSHRN(V30.T_4H, V1.T_4S, 5), asm => asm.UQSHRN(V30.T_4H, V1.T_4S, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V30.4H, V1.4S, #5");
        TestInst(UQSHRN(V0.T_4H, V31.T_4S, 5), asm => asm.UQSHRN(V0.T_4H, V31.T_4S, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V0.4H, V31.4S, #5");
        TestInst(UQSHRN(V30.T_4H, V31.T_4S, 5), asm => asm.UQSHRN(V30.T_4H, V31.T_4S, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V30.4H, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQSHRN_asimdshf_n_5()
    {
        TestInst(UQSHRN(V0.T_2S, V1.T_2D, 5), asm => asm.UQSHRN(V0.T_2S, V1.T_2D, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V0.2S, V1.2D, #5");
        TestInst(UQSHRN(V30.T_2S, V1.T_2D, 5), asm => asm.UQSHRN(V30.T_2S, V1.T_2D, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V30.2S, V1.2D, #5");
        TestInst(UQSHRN(V0.T_2S, V31.T_2D, 5), asm => asm.UQSHRN(V0.T_2S, V31.T_2D, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V0.2S, V31.2D, #5");
        TestInst(UQSHRN(V30.T_2S, V31.T_2D, 5), asm => asm.UQSHRN(V30.T_2S, V31.T_2D, 5), Arm64InstructionId.UQSHRN_asimdshf_n, Arm64Mnemonic.UQSHRN, "UQSHRN V30.2S, V31.2D, #5");
    }
}
