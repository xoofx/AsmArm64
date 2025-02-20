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
namespace AsmArm64.Tests.Fpsimd;

[TestClass]
public class Arm64InstructionFactoryTests_LDR_Fpsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_b_ldst_regoff_0()
    {
        TestInst(LDR(B0, _[X2, X3, _LSL, 0]), asm => asm.LDR(B0, _[X2, X3, _LSL, 0]), Arm64InstructionId.LDR_bl_ldst_regoff, Arm64Mnemonic.LDR, "LDR B0, [X2, X3, LSL #0]");
        TestInst(LDR(B31, _[X2, X3, _LSL, 0]), asm => asm.LDR(B31, _[X2, X3, _LSL, 0]), Arm64InstructionId.LDR_bl_ldst_regoff, Arm64Mnemonic.LDR, "LDR B31, [X2, X3, LSL #0]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_b_ldst_regoff_1()
    {
        TestInst(LDR(B0, _[X2, W3, _UXTW, 0]), asm => asm.LDR(B0, _[X2, W3, _UXTW, 0]), Arm64InstructionId.LDR_b_ldst_regoff, Arm64Mnemonic.LDR, "LDR B0, [X2, W3, UXTW #0]");
        TestInst(LDR(B31, _[X2, W3, _UXTW, 0]), asm => asm.LDR(B31, _[X2, W3, _UXTW, 0]), Arm64InstructionId.LDR_b_ldst_regoff, Arm64Mnemonic.LDR, "LDR B31, [X2, W3, UXTW #0]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_b_ldst_immpost_2()
    {
        TestInst(LDR(B0, _[X2], 5), asm => asm.LDR(B0, _[X2], 5), Arm64InstructionId.LDR_b_ldst_immpost, Arm64Mnemonic.LDR, "LDR B0, [X2], #5");
        TestInst(LDR(B31, _[X2], 5), asm => asm.LDR(B31, _[X2], 5), Arm64InstructionId.LDR_b_ldst_immpost, Arm64Mnemonic.LDR, "LDR B31, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_h_ldst_immpost_3()
    {
        TestInst(LDR(H0, _[X2], 5), asm => asm.LDR(H0, _[X2], 5), Arm64InstructionId.LDR_h_ldst_immpost, Arm64Mnemonic.LDR, "LDR H0, [X2], #5");
        TestInst(LDR(H31, _[X2], 5), asm => asm.LDR(H31, _[X2], 5), Arm64InstructionId.LDR_h_ldst_immpost, Arm64Mnemonic.LDR, "LDR H31, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_s_ldst_immpost_4()
    {
        TestInst(LDR(S0, _[X2], 5), asm => asm.LDR(S0, _[X2], 5), Arm64InstructionId.LDR_s_ldst_immpost, Arm64Mnemonic.LDR, "LDR S0, [X2], #5");
        TestInst(LDR(S31, _[X2], 5), asm => asm.LDR(S31, _[X2], 5), Arm64InstructionId.LDR_s_ldst_immpost, Arm64Mnemonic.LDR, "LDR S31, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_d_ldst_immpost_5()
    {
        TestInst(LDR(D0, _[X2], 5), asm => asm.LDR(D0, _[X2], 5), Arm64InstructionId.LDR_d_ldst_immpost, Arm64Mnemonic.LDR, "LDR D0, [X2], #5");
        TestInst(LDR(D31, _[X2], 5), asm => asm.LDR(D31, _[X2], 5), Arm64InstructionId.LDR_d_ldst_immpost, Arm64Mnemonic.LDR, "LDR D31, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_q_ldst_immpost_6()
    {
        TestInst(LDR(Q0, _[X2], 5), asm => asm.LDR(Q0, _[X2], 5), Arm64InstructionId.LDR_q_ldst_immpost, Arm64Mnemonic.LDR, "LDR Q0, [X2], #5");
        TestInst(LDR(Q31, _[X2], 5), asm => asm.LDR(Q31, _[X2], 5), Arm64InstructionId.LDR_q_ldst_immpost, Arm64Mnemonic.LDR, "LDR Q31, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_b_ldst_immpre_7()
    {
        TestInst(LDR(B0, _[X2, 5].Pre), asm => asm.LDR(B0, _[X2, 5].Pre), Arm64InstructionId.LDR_b_ldst_immpre, Arm64Mnemonic.LDR, "LDR B0, [X2, #5]!");
        TestInst(LDR(B31, _[X2, 5].Pre), asm => asm.LDR(B31, _[X2, 5].Pre), Arm64InstructionId.LDR_b_ldst_immpre, Arm64Mnemonic.LDR, "LDR B31, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_h_ldst_immpre_8()
    {
        TestInst(LDR(H0, _[X2, 5].Pre), asm => asm.LDR(H0, _[X2, 5].Pre), Arm64InstructionId.LDR_h_ldst_immpre, Arm64Mnemonic.LDR, "LDR H0, [X2, #5]!");
        TestInst(LDR(H31, _[X2, 5].Pre), asm => asm.LDR(H31, _[X2, 5].Pre), Arm64InstructionId.LDR_h_ldst_immpre, Arm64Mnemonic.LDR, "LDR H31, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_s_ldst_immpre_9()
    {
        TestInst(LDR(S0, _[X2, 5].Pre), asm => asm.LDR(S0, _[X2, 5].Pre), Arm64InstructionId.LDR_s_ldst_immpre, Arm64Mnemonic.LDR, "LDR S0, [X2, #5]!");
        TestInst(LDR(S31, _[X2, 5].Pre), asm => asm.LDR(S31, _[X2, 5].Pre), Arm64InstructionId.LDR_s_ldst_immpre, Arm64Mnemonic.LDR, "LDR S31, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_d_ldst_immpre_10()
    {
        TestInst(LDR(D0, _[X2, 5].Pre), asm => asm.LDR(D0, _[X2, 5].Pre), Arm64InstructionId.LDR_d_ldst_immpre, Arm64Mnemonic.LDR, "LDR D0, [X2, #5]!");
        TestInst(LDR(D31, _[X2, 5].Pre), asm => asm.LDR(D31, _[X2, 5].Pre), Arm64InstructionId.LDR_d_ldst_immpre, Arm64Mnemonic.LDR, "LDR D31, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_q_ldst_immpre_11()
    {
        TestInst(LDR(Q0, _[X2, 5].Pre), asm => asm.LDR(Q0, _[X2, 5].Pre), Arm64InstructionId.LDR_q_ldst_immpre, Arm64Mnemonic.LDR, "LDR Q0, [X2, #5]!");
        TestInst(LDR(Q31, _[X2, 5].Pre), asm => asm.LDR(Q31, _[X2, 5].Pre), Arm64InstructionId.LDR_q_ldst_immpre, Arm64Mnemonic.LDR, "LDR Q31, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_b_ldst_pos_12()
    {
        TestInst(LDR(B0, _[X2, 5]), asm => asm.LDR(B0, _[X2, 5]), Arm64InstructionId.LDR_b_ldst_pos, Arm64Mnemonic.LDR, "LDR B0, [X2, #5]");
        TestInst(LDR(B31, _[X2, 5]), asm => asm.LDR(B31, _[X2, 5]), Arm64InstructionId.LDR_b_ldst_pos, Arm64Mnemonic.LDR, "LDR B31, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_h_ldst_pos_13()
    {
        TestInst(LDR(H0, _[X2, 10]), asm => asm.LDR(H0, _[X2, 10]), Arm64InstructionId.LDR_h_ldst_pos, Arm64Mnemonic.LDR, "LDR H0, [X2, #10]");
        TestInst(LDR(H31, _[X2, 10]), asm => asm.LDR(H31, _[X2, 10]), Arm64InstructionId.LDR_h_ldst_pos, Arm64Mnemonic.LDR, "LDR H31, [X2, #10]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_s_ldst_pos_14()
    {
        TestInst(LDR(S0, _[X2, 20]), asm => asm.LDR(S0, _[X2, 20]), Arm64InstructionId.LDR_s_ldst_pos, Arm64Mnemonic.LDR, "LDR S0, [X2, #20]");
        TestInst(LDR(S31, _[X2, 20]), asm => asm.LDR(S31, _[X2, 20]), Arm64InstructionId.LDR_s_ldst_pos, Arm64Mnemonic.LDR, "LDR S31, [X2, #20]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_d_ldst_pos_15()
    {
        TestInst(LDR(D0, _[X2, 40]), asm => asm.LDR(D0, _[X2, 40]), Arm64InstructionId.LDR_d_ldst_pos, Arm64Mnemonic.LDR, "LDR D0, [X2, #40]");
        TestInst(LDR(D31, _[X2, 40]), asm => asm.LDR(D31, _[X2, 40]), Arm64InstructionId.LDR_d_ldst_pos, Arm64Mnemonic.LDR, "LDR D31, [X2, #40]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_q_ldst_pos_16()
    {
        TestInst(LDR(Q0, _[X2, 5]), asm => asm.LDR(Q0, _[X2, 5]), Arm64InstructionId.LDR_q_ldst_pos, Arm64Mnemonic.LDR, "LDR Q0, [X2, #5]");
        TestInst(LDR(Q31, _[X2, 5]), asm => asm.LDR(Q31, _[X2, 5]), Arm64InstructionId.LDR_q_ldst_pos, Arm64Mnemonic.LDR, "LDR Q31, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_s_loadlit_17()
    {
        TestInst(LDR(S0, 32), null, Arm64InstructionId.LDR_s_loadlit, Arm64Mnemonic.LDR, "LDR S0, #32");
        TestInst(LDR(S31, 32), null, Arm64InstructionId.LDR_s_loadlit, Arm64Mnemonic.LDR, "LDR S31, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_d_loadlit_18()
    {
        TestInst(LDR(D0, 32), null, Arm64InstructionId.LDR_d_loadlit, Arm64Mnemonic.LDR, "LDR D0, #32");
        TestInst(LDR(D31, 32), null, Arm64InstructionId.LDR_d_loadlit, Arm64Mnemonic.LDR, "LDR D31, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_q_loadlit_19()
    {
        TestInst(LDR(Q0, 32), null, Arm64InstructionId.LDR_q_loadlit, Arm64Mnemonic.LDR, "LDR Q0, #32");
        TestInst(LDR(Q31, 32), null, Arm64InstructionId.LDR_q_loadlit, Arm64Mnemonic.LDR, "LDR Q31, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_h_ldst_regoff_20()
    {
        TestInst(LDR(H0, _[X2, X3, _LSL, 1]), asm => asm.LDR(H0, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDR_h_ldst_regoff, Arm64Mnemonic.LDR, "LDR H0, [X2, X3, LSL #1]");
        TestInst(LDR(H31, _[X2, X3, _LSL, 1]), asm => asm.LDR(H31, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDR_h_ldst_regoff, Arm64Mnemonic.LDR, "LDR H31, [X2, X3, LSL #1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_h_ldst_regoff_21()
    {
        TestInst(LDR(H0, _[X2, W3, _UXTW, 1]), asm => asm.LDR(H0, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDR_h_ldst_regoff, Arm64Mnemonic.LDR, "LDR H0, [X2, W3, UXTW #1]");
        TestInst(LDR(H31, _[X2, W3, _UXTW, 1]), asm => asm.LDR(H31, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDR_h_ldst_regoff, Arm64Mnemonic.LDR, "LDR H31, [X2, W3, UXTW #1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_s_ldst_regoff_22()
    {
        TestInst(LDR(S0, _[X2, X3, _LSL, 2]), asm => asm.LDR(S0, _[X2, X3, _LSL, 2]), Arm64InstructionId.LDR_s_ldst_regoff, Arm64Mnemonic.LDR, "LDR S0, [X2, X3, LSL #2]");
        TestInst(LDR(S31, _[X2, X3, _LSL, 2]), asm => asm.LDR(S31, _[X2, X3, _LSL, 2]), Arm64InstructionId.LDR_s_ldst_regoff, Arm64Mnemonic.LDR, "LDR S31, [X2, X3, LSL #2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_s_ldst_regoff_23()
    {
        TestInst(LDR(S0, _[X2, W3, _UXTW, 2]), asm => asm.LDR(S0, _[X2, W3, _UXTW, 2]), Arm64InstructionId.LDR_s_ldst_regoff, Arm64Mnemonic.LDR, "LDR S0, [X2, W3, UXTW #2]");
        TestInst(LDR(S31, _[X2, W3, _UXTW, 2]), asm => asm.LDR(S31, _[X2, W3, _UXTW, 2]), Arm64InstructionId.LDR_s_ldst_regoff, Arm64Mnemonic.LDR, "LDR S31, [X2, W3, UXTW #2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_d_ldst_regoff_24()
    {
        TestInst(LDR(D0, _[X2, X3, _LSL, 3]), asm => asm.LDR(D0, _[X2, X3, _LSL, 3]), Arm64InstructionId.LDR_d_ldst_regoff, Arm64Mnemonic.LDR, "LDR D0, [X2, X3, LSL #3]");
        TestInst(LDR(D31, _[X2, X3, _LSL, 3]), asm => asm.LDR(D31, _[X2, X3, _LSL, 3]), Arm64InstructionId.LDR_d_ldst_regoff, Arm64Mnemonic.LDR, "LDR D31, [X2, X3, LSL #3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_d_ldst_regoff_25()
    {
        TestInst(LDR(D0, _[X2, W3, _UXTW, 3]), asm => asm.LDR(D0, _[X2, W3, _UXTW, 3]), Arm64InstructionId.LDR_d_ldst_regoff, Arm64Mnemonic.LDR, "LDR D0, [X2, W3, UXTW #3]");
        TestInst(LDR(D31, _[X2, W3, _UXTW, 3]), asm => asm.LDR(D31, _[X2, W3, _UXTW, 3]), Arm64InstructionId.LDR_d_ldst_regoff, Arm64Mnemonic.LDR, "LDR D31, [X2, W3, UXTW #3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_q_ldst_regoff_26()
    {
        TestInst(LDR(Q0, _[X2, X3, _LSL, 4]), asm => asm.LDR(Q0, _[X2, X3, _LSL, 4]), Arm64InstructionId.LDR_q_ldst_regoff, Arm64Mnemonic.LDR, "LDR Q0, [X2, X3, LSL #4]");
        TestInst(LDR(Q31, _[X2, X3, _LSL, 4]), asm => asm.LDR(Q31, _[X2, X3, _LSL, 4]), Arm64InstructionId.LDR_q_ldst_regoff, Arm64Mnemonic.LDR, "LDR Q31, [X2, X3, LSL #4]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_q_ldst_regoff_27()
    {
        TestInst(LDR(Q0, _[X2, W3, _UXTW, 4]), asm => asm.LDR(Q0, _[X2, W3, _UXTW, 4]), Arm64InstructionId.LDR_q_ldst_regoff, Arm64Mnemonic.LDR, "LDR Q0, [X2, W3, UXTW #4]");
        TestInst(LDR(Q31, _[X2, W3, _UXTW, 4]), asm => asm.LDR(Q31, _[X2, W3, _UXTW, 4]), Arm64InstructionId.LDR_q_ldst_regoff, Arm64Mnemonic.LDR, "LDR Q31, [X2, W3, UXTW #4]");
    }
}
