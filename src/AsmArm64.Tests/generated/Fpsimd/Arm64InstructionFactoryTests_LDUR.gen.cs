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
namespace AsmArm64.Tests.Fpsimd;

[TestClass]
public class Arm64InstructionFactoryTests_LDUR_Fpsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUR_b_ldst_unscaled_0()
    {
        TestInst(LDUR(B0, _[X2, 5]), asm => asm.LDUR(B0, _[X2, 5]), Arm64InstructionId.LDUR_b_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR B0, [X2, #5]");
        TestInst(LDUR(B31, _[X2, 5]), asm => asm.LDUR(B31, _[X2, 5]), Arm64InstructionId.LDUR_b_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR B31, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUR_h_ldst_unscaled_1()
    {
        TestInst(LDUR(H0, _[X2, 5]), asm => asm.LDUR(H0, _[X2, 5]), Arm64InstructionId.LDUR_h_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR H0, [X2, #5]");
        TestInst(LDUR(H31, _[X2, 5]), asm => asm.LDUR(H31, _[X2, 5]), Arm64InstructionId.LDUR_h_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR H31, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUR_s_ldst_unscaled_2()
    {
        TestInst(LDUR(S0, _[X2, 5]), asm => asm.LDUR(S0, _[X2, 5]), Arm64InstructionId.LDUR_s_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR S0, [X2, #5]");
        TestInst(LDUR(S31, _[X2, 5]), asm => asm.LDUR(S31, _[X2, 5]), Arm64InstructionId.LDUR_s_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR S31, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUR_d_ldst_unscaled_3()
    {
        TestInst(LDUR(D0, _[X2, 5]), asm => asm.LDUR(D0, _[X2, 5]), Arm64InstructionId.LDUR_d_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR D0, [X2, #5]");
        TestInst(LDUR(D31, _[X2, 5]), asm => asm.LDUR(D31, _[X2, 5]), Arm64InstructionId.LDUR_d_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR D31, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUR_q_ldst_unscaled_4()
    {
        TestInst(LDUR(Q0, _[X2, 5]), asm => asm.LDUR(Q0, _[X2, 5]), Arm64InstructionId.LDUR_q_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR Q0, [X2, #5]");
        TestInst(LDUR(Q31, _[X2, 5]), asm => asm.LDUR(Q31, _[X2, 5]), Arm64InstructionId.LDUR_q_ldst_unscaled, Arm64Mnemonic.LDUR, "LDUR Q31, [X2, #5]");
    }
}
