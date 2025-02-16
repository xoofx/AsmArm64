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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_UQRSHRN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHRN_asisdshf_n_0()
    {
        TestInst(UQRSHRN(B1, H2, 5), asm => asm.UQRSHRN(B1, H2, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN B1, H2, #5");
        TestInst(UQRSHRN(B31, H2, 5), asm => asm.UQRSHRN(B31, H2, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN B31, H2, #5");
        TestInst(UQRSHRN(B1, H0, 5), asm => asm.UQRSHRN(B1, H0, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN B1, H0, #5");
        TestInst(UQRSHRN(B31, H0, 5), asm => asm.UQRSHRN(B31, H0, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN B31, H0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHRN_asisdshf_n_1()
    {
        TestInst(UQRSHRN(H1, S2, 5), asm => asm.UQRSHRN(H1, S2, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN H1, S2, #5");
        TestInst(UQRSHRN(H31, S2, 5), asm => asm.UQRSHRN(H31, S2, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN H31, S2, #5");
        TestInst(UQRSHRN(H1, S0, 5), asm => asm.UQRSHRN(H1, S0, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN H1, S0, #5");
        TestInst(UQRSHRN(H31, S0, 5), asm => asm.UQRSHRN(H31, S0, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN H31, S0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHRN_asisdshf_n_2()
    {
        TestInst(UQRSHRN(S1, D2, 5), asm => asm.UQRSHRN(S1, D2, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN S1, D2, #5");
        TestInst(UQRSHRN(S31, D2, 5), asm => asm.UQRSHRN(S31, D2, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN S31, D2, #5");
        TestInst(UQRSHRN(S1, D0, 5), asm => asm.UQRSHRN(S1, D0, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN S1, D0, #5");
        TestInst(UQRSHRN(S31, D0, 5), asm => asm.UQRSHRN(S31, D0, 5), Arm64InstructionId.UQRSHRN_asisdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN S31, D0, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHRN_asimdshf_n_3()
    {
        TestInst(UQRSHRN(V0.T_8B, V1.T_8H, 5), asm => asm.UQRSHRN(V0.T_8B, V1.T_8H, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V0.8B, V1.8H, #5");
        TestInst(UQRSHRN(V30.T_8B, V1.T_8H, 5), asm => asm.UQRSHRN(V30.T_8B, V1.T_8H, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V30.8B, V1.8H, #5");
        TestInst(UQRSHRN(V0.T_8B, V31.T_8H, 5), asm => asm.UQRSHRN(V0.T_8B, V31.T_8H, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V0.8B, V31.8H, #5");
        TestInst(UQRSHRN(V30.T_8B, V31.T_8H, 5), asm => asm.UQRSHRN(V30.T_8B, V31.T_8H, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V30.8B, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHRN_asimdshf_n_4()
    {
        TestInst(UQRSHRN(V0.T_4H, V1.T_4S, 5), asm => asm.UQRSHRN(V0.T_4H, V1.T_4S, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V0.4H, V1.4S, #5");
        TestInst(UQRSHRN(V30.T_4H, V1.T_4S, 5), asm => asm.UQRSHRN(V30.T_4H, V1.T_4S, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V30.4H, V1.4S, #5");
        TestInst(UQRSHRN(V0.T_4H, V31.T_4S, 5), asm => asm.UQRSHRN(V0.T_4H, V31.T_4S, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V0.4H, V31.4S, #5");
        TestInst(UQRSHRN(V30.T_4H, V31.T_4S, 5), asm => asm.UQRSHRN(V30.T_4H, V31.T_4S, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V30.4H, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UQRSHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UQRSHRN_asimdshf_n_5()
    {
        TestInst(UQRSHRN(V0.T_2S, V1.T_2D, 5), asm => asm.UQRSHRN(V0.T_2S, V1.T_2D, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V0.2S, V1.2D, #5");
        TestInst(UQRSHRN(V30.T_2S, V1.T_2D, 5), asm => asm.UQRSHRN(V30.T_2S, V1.T_2D, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V30.2S, V1.2D, #5");
        TestInst(UQRSHRN(V0.T_2S, V31.T_2D, 5), asm => asm.UQRSHRN(V0.T_2S, V31.T_2D, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V0.2S, V31.2D, #5");
        TestInst(UQRSHRN(V30.T_2S, V31.T_2D, 5), asm => asm.UQRSHRN(V30.T_2S, V31.T_2D, 5), Arm64InstructionId.UQRSHRN_asimdshf_n, Arm64Mnemonic.UQRSHRN, "UQRSHRN V30.2S, V31.2D, #5");
    }
}
