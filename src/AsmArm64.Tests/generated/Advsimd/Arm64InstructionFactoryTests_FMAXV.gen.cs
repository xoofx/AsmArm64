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
public class Arm64InstructionFactoryTests_FMAXV_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAXV_asimdall_only_h_0()
    {
        TestInst(FMAXV(H0, V1.T_4H), asm => asm.FMAXV(H0, V1.T_4H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H0, V1.4H");
        TestInst(FMAXV(H31, V1.T_4H), asm => asm.FMAXV(H31, V1.T_4H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H31, V1.4H");
        TestInst(FMAXV(H0, V31.T_4H), asm => asm.FMAXV(H0, V31.T_4H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H0, V31.4H");
        TestInst(FMAXV(H31, V31.T_4H), asm => asm.FMAXV(H31, V31.T_4H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H31, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAXV_asimdall_only_h_1()
    {
        TestInst(FMAXV(H0, V1.T_8H), asm => asm.FMAXV(H0, V1.T_8H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H0, V1.8H");
        TestInst(FMAXV(H31, V1.T_8H), asm => asm.FMAXV(H31, V1.T_8H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H31, V1.8H");
        TestInst(FMAXV(H0, V31.T_8H), asm => asm.FMAXV(H0, V31.T_8H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H0, V31.8H");
        TestInst(FMAXV(H31, V31.T_8H), asm => asm.FMAXV(H31, V31.T_8H), Arm64InstructionId.FMAXV_asimdall_only_h, Arm64Mnemonic.FMAXV, "FMAXV H31, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAXV_asimdall_only_sd_2()
    {
        TestInst(FMAXV(S0, V1.T_4S), asm => asm.FMAXV(S0, V1.T_4S), Arm64InstructionId.FMAXV_asimdall_only_sd, Arm64Mnemonic.FMAXV, "FMAXV S0, V1.4S");
        TestInst(FMAXV(S31, V1.T_4S), asm => asm.FMAXV(S31, V1.T_4S), Arm64InstructionId.FMAXV_asimdall_only_sd, Arm64Mnemonic.FMAXV, "FMAXV S31, V1.4S");
        TestInst(FMAXV(S0, V31.T_4S), asm => asm.FMAXV(S0, V31.T_4S), Arm64InstructionId.FMAXV_asimdall_only_sd, Arm64Mnemonic.FMAXV, "FMAXV S0, V31.4S");
        TestInst(FMAXV(S31, V31.T_4S), asm => asm.FMAXV(S31, V31.T_4S), Arm64InstructionId.FMAXV_asimdall_only_sd, Arm64Mnemonic.FMAXV, "FMAXV S31, V31.4S");
    }
}
