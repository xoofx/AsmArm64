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
public class Arm64InstructionFactoryTests_UMAXV_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAXV_asimdall_only_0()
    {
        TestInst(UMAXV(B1, V1.T_8B), asm => asm.UMAXV(B1, V1.T_8B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B1, V1.8B");
        TestInst(UMAXV(B31, V1.T_8B), asm => asm.UMAXV(B31, V1.T_8B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B31, V1.8B");
        TestInst(UMAXV(B1, V31.T_8B), asm => asm.UMAXV(B1, V31.T_8B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B1, V31.8B");
        TestInst(UMAXV(B31, V31.T_8B), asm => asm.UMAXV(B31, V31.T_8B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B31, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAXV_asimdall_only_1()
    {
        TestInst(UMAXV(B1, V1.T_16B), asm => asm.UMAXV(B1, V1.T_16B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B1, V1.16B");
        TestInst(UMAXV(B31, V1.T_16B), asm => asm.UMAXV(B31, V1.T_16B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B31, V1.16B");
        TestInst(UMAXV(B1, V31.T_16B), asm => asm.UMAXV(B1, V31.T_16B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B1, V31.16B");
        TestInst(UMAXV(B31, V31.T_16B), asm => asm.UMAXV(B31, V31.T_16B), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV B31, V31.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAXV_asimdall_only_2()
    {
        TestInst(UMAXV(H1, V1.T_4H), asm => asm.UMAXV(H1, V1.T_4H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H1, V1.4H");
        TestInst(UMAXV(H31, V1.T_4H), asm => asm.UMAXV(H31, V1.T_4H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H31, V1.4H");
        TestInst(UMAXV(H1, V31.T_4H), asm => asm.UMAXV(H1, V31.T_4H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H1, V31.4H");
        TestInst(UMAXV(H31, V31.T_4H), asm => asm.UMAXV(H31, V31.T_4H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H31, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAXV_asimdall_only_3()
    {
        TestInst(UMAXV(H1, V1.T_8H), asm => asm.UMAXV(H1, V1.T_8H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H1, V1.8H");
        TestInst(UMAXV(H31, V1.T_8H), asm => asm.UMAXV(H31, V1.T_8H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H31, V1.8H");
        TestInst(UMAXV(H1, V31.T_8H), asm => asm.UMAXV(H1, V31.T_8H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H1, V31.8H");
        TestInst(UMAXV(H31, V31.T_8H), asm => asm.UMAXV(H31, V31.T_8H), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV H31, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAXV"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAXV_asimdall_only_4()
    {
        TestInst(UMAXV(S1, V1.T_4S), asm => asm.UMAXV(S1, V1.T_4S), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV S1, V1.4S");
        TestInst(UMAXV(S31, V1.T_4S), asm => asm.UMAXV(S31, V1.T_4S), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV S31, V1.4S");
        TestInst(UMAXV(S1, V31.T_4S), asm => asm.UMAXV(S1, V31.T_4S), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV S1, V31.4S");
        TestInst(UMAXV(S31, V31.T_4S), asm => asm.UMAXV(S31, V31.T_4S), Arm64InstructionId.UMAXV_asimdall_only, Arm64Mnemonic.UMAXV, "UMAXV S31, V31.4S");
    }
}
