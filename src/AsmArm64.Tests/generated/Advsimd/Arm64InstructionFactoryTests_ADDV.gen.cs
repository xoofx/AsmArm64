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
public class Arm64InstructionFactoryTests_ADDV_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADDV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADDV_asimdall_only_0()
    {
        TestInst(ADDV(B1, V1.T_8B), asm => asm.ADDV(B1, V1.T_8B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B1, V1.8B");
        TestInst(ADDV(B31, V1.T_8B), asm => asm.ADDV(B31, V1.T_8B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B31, V1.8B");
        TestInst(ADDV(B1, V31.T_8B), asm => asm.ADDV(B1, V31.T_8B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B1, V31.8B");
        TestInst(ADDV(B31, V31.T_8B), asm => asm.ADDV(B31, V31.T_8B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B31, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADDV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADDV_asimdall_only_1()
    {
        TestInst(ADDV(B1, V1.T_16B), asm => asm.ADDV(B1, V1.T_16B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B1, V1.16B");
        TestInst(ADDV(B31, V1.T_16B), asm => asm.ADDV(B31, V1.T_16B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B31, V1.16B");
        TestInst(ADDV(B1, V31.T_16B), asm => asm.ADDV(B1, V31.T_16B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B1, V31.16B");
        TestInst(ADDV(B31, V31.T_16B), asm => asm.ADDV(B31, V31.T_16B), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV B31, V31.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADDV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADDV_asimdall_only_2()
    {
        TestInst(ADDV(H1, V1.T_4H), asm => asm.ADDV(H1, V1.T_4H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H1, V1.4H");
        TestInst(ADDV(H31, V1.T_4H), asm => asm.ADDV(H31, V1.T_4H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H31, V1.4H");
        TestInst(ADDV(H1, V31.T_4H), asm => asm.ADDV(H1, V31.T_4H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H1, V31.4H");
        TestInst(ADDV(H31, V31.T_4H), asm => asm.ADDV(H31, V31.T_4H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H31, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADDV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADDV_asimdall_only_3()
    {
        TestInst(ADDV(H1, V1.T_8H), asm => asm.ADDV(H1, V1.T_8H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H1, V1.8H");
        TestInst(ADDV(H31, V1.T_8H), asm => asm.ADDV(H31, V1.T_8H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H31, V1.8H");
        TestInst(ADDV(H1, V31.T_8H), asm => asm.ADDV(H1, V31.T_8H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H1, V31.8H");
        TestInst(ADDV(H31, V31.T_8H), asm => asm.ADDV(H31, V31.T_8H), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV H31, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADDV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADDV_asimdall_only_4()
    {
        TestInst(ADDV(S1, V1.T_4S), asm => asm.ADDV(S1, V1.T_4S), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV S1, V1.4S");
        TestInst(ADDV(S31, V1.T_4S), asm => asm.ADDV(S31, V1.T_4S), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV S31, V1.4S");
        TestInst(ADDV(S1, V31.T_4S), asm => asm.ADDV(S1, V31.T_4S), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV S1, V31.4S");
        TestInst(ADDV(S31, V31.T_4S), asm => asm.ADDV(S31, V31.T_4S), Arm64InstructionId.ADDV_asimdall_only, Arm64Mnemonic.ADDV, "ADDV S31, V31.4S");
    }
}
