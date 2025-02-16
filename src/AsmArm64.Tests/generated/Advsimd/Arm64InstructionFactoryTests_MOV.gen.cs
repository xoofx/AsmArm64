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
public class Arm64InstructionFactoryTests_MOV_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_iv_v_0()
    {
        TestInst(MOV(V0.B[0], V1.B[0]), asm => asm.MOV(V0.B[0], V1.B[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.B[0], V1.B[0]");
        TestInst(MOV(V30.B[1], V1.B[0]), asm => asm.MOV(V30.B[1], V1.B[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.B[1], V1.B[0]");
        TestInst(MOV(V0.B[0], V31.B[1]), asm => asm.MOV(V0.B[0], V31.B[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.B[0], V31.B[1]");
        TestInst(MOV(V30.B[1], V31.B[1]), asm => asm.MOV(V30.B[1], V31.B[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.B[1], V31.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_iv_v_1()
    {
        TestInst(MOV(V0.H[0], V1.H[0]), asm => asm.MOV(V0.H[0], V1.H[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.H[0], V1.H[0]");
        TestInst(MOV(V30.H[1], V1.H[0]), asm => asm.MOV(V30.H[1], V1.H[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.H[1], V1.H[0]");
        TestInst(MOV(V0.H[0], V31.H[1]), asm => asm.MOV(V0.H[0], V31.H[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.H[0], V31.H[1]");
        TestInst(MOV(V30.H[1], V31.H[1]), asm => asm.MOV(V30.H[1], V31.H[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.H[1], V31.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_iv_v_2()
    {
        TestInst(MOV(V0.S[0], V1.S[0]), asm => asm.MOV(V0.S[0], V1.S[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.S[0], V1.S[0]");
        TestInst(MOV(V30.S[1], V1.S[0]), asm => asm.MOV(V30.S[1], V1.S[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.S[1], V1.S[0]");
        TestInst(MOV(V0.S[0], V31.S[1]), asm => asm.MOV(V0.S[0], V31.S[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.S[0], V31.S[1]");
        TestInst(MOV(V30.S[1], V31.S[1]), asm => asm.MOV(V30.S[1], V31.S[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.S[1], V31.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_iv_v_3()
    {
        TestInst(MOV(V0.D[0], V1.D[0]), asm => asm.MOV(V0.D[0], V1.D[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.D[0], V1.D[0]");
        TestInst(MOV(V30.D[1], V1.D[0]), asm => asm.MOV(V30.D[1], V1.D[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.D[1], V1.D[0]");
        TestInst(MOV(V0.D[0], V31.D[1]), asm => asm.MOV(V0.D[0], V31.D[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.D[0], V31.D[1]");
        TestInst(MOV(V30.D[1], V31.D[1]), asm => asm.MOV(V30.D[1], V31.D[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.D[1], V31.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_ir_r_4()
    {
        TestInst(MOV(V0.B[0], W2), asm => asm.MOV(V0.B[0], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.B[0], W2");
        TestInst(MOV(V30.B[1], W2), asm => asm.MOV(V30.B[1], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.B[1], W2");
        TestInst(MOV(V0.B[0], WZR), asm => asm.MOV(V0.B[0], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.B[0], WZR");
        TestInst(MOV(V30.B[1], WZR), asm => asm.MOV(V30.B[1], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.B[1], WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_ir_r_5()
    {
        TestInst(MOV(V0.H[0], W2), asm => asm.MOV(V0.H[0], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.H[0], W2");
        TestInst(MOV(V30.H[1], W2), asm => asm.MOV(V30.H[1], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.H[1], W2");
        TestInst(MOV(V0.H[0], WZR), asm => asm.MOV(V0.H[0], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.H[0], WZR");
        TestInst(MOV(V30.H[1], WZR), asm => asm.MOV(V30.H[1], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.H[1], WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_ir_r_6()
    {
        TestInst(MOV(V0.S[0], W2), asm => asm.MOV(V0.S[0], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.S[0], W2");
        TestInst(MOV(V30.S[1], W2), asm => asm.MOV(V30.S[1], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.S[1], W2");
        TestInst(MOV(V0.S[0], WZR), asm => asm.MOV(V0.S[0], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.S[0], WZR");
        TestInst(MOV(V30.S[1], WZR), asm => asm.MOV(V30.S[1], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.S[1], WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_ins_asimdins_ir_r_7()
    {
        TestInst(MOV(V0.D[0], X2), asm => asm.MOV(V0.D[0], X2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.D[0], X2");
        TestInst(MOV(V30.D[1], X2), asm => asm.MOV(V30.D[1], X2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.D[1], X2");
        TestInst(MOV(V0.D[0], XZR), asm => asm.MOV(V0.D[0], XZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.D[0], XZR");
        TestInst(MOV(V30.D[1], XZR), asm => asm.MOV(V30.D[1], XZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.D[1], XZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_dup_asisdone_only_8()
    {
        TestInst(MOV(B1, V1.B[0]), asm => asm.MOV(B1, V1.B[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV B1, V1.B[0]");
        TestInst(MOV(B31, V1.B[0]), asm => asm.MOV(B31, V1.B[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV B31, V1.B[0]");
        TestInst(MOV(B1, V31.B[1]), asm => asm.MOV(B1, V31.B[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV B1, V31.B[1]");
        TestInst(MOV(B31, V31.B[1]), asm => asm.MOV(B31, V31.B[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV B31, V31.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_dup_asisdone_only_9()
    {
        TestInst(MOV(H1, V1.H[0]), asm => asm.MOV(H1, V1.H[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV H1, V1.H[0]");
        TestInst(MOV(H31, V1.H[0]), asm => asm.MOV(H31, V1.H[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV H31, V1.H[0]");
        TestInst(MOV(H1, V31.H[1]), asm => asm.MOV(H1, V31.H[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV H1, V31.H[1]");
        TestInst(MOV(H31, V31.H[1]), asm => asm.MOV(H31, V31.H[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV H31, V31.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_dup_asisdone_only_10()
    {
        TestInst(MOV(S1, V1.S[0]), asm => asm.MOV(S1, V1.S[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV S1, V1.S[0]");
        TestInst(MOV(S31, V1.S[0]), asm => asm.MOV(S31, V1.S[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV S31, V1.S[0]");
        TestInst(MOV(S1, V31.S[1]), asm => asm.MOV(S1, V31.S[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV S1, V31.S[1]");
        TestInst(MOV(S31, V31.S[1]), asm => asm.MOV(S31, V31.S[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV S31, V31.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_dup_asisdone_only_11()
    {
        TestInst(MOV(D1, V1.D[0]), asm => asm.MOV(D1, V1.D[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV D1, V1.D[0]");
        TestInst(MOV(D31, V1.D[0]), asm => asm.MOV(D31, V1.D[0]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV D31, V1.D[0]");
        TestInst(MOV(D1, V31.D[1]), asm => asm.MOV(D1, V31.D[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV D1, V31.D[1]");
        TestInst(MOV(D31, V31.D[1]), asm => asm.MOV(D31, V31.D[1]), Arm64InstructionId.MOV_dup_asisdone_only, Arm64Mnemonic.MOV, "MOV D31, V31.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_umov_asimdins_w_w_12()
    {
        TestInst(MOV(W0, V1.S[1]), asm => asm.MOV(W0, V1.S[1]), Arm64InstructionId.MOV_umov_asimdins_w_w, Arm64Mnemonic.MOV, "MOV W0, V1.S[1]");
        TestInst(MOV(W15, V1.S[1]), asm => asm.MOV(W15, V1.S[1]), Arm64InstructionId.MOV_umov_asimdins_w_w, Arm64Mnemonic.MOV, "MOV W15, V1.S[1]");
        TestInst(MOV(WZR, V1.S[1]), asm => asm.MOV(WZR, V1.S[1]), Arm64InstructionId.MOV_umov_asimdins_w_w, Arm64Mnemonic.MOV, "MOV WZR, V1.S[1]");
        TestInst(MOV(W0, V31.S[1]), asm => asm.MOV(W0, V31.S[1]), Arm64InstructionId.MOV_umov_asimdins_w_w, Arm64Mnemonic.MOV, "MOV W0, V31.S[1]");
        TestInst(MOV(W15, V31.S[1]), asm => asm.MOV(W15, V31.S[1]), Arm64InstructionId.MOV_umov_asimdins_w_w, Arm64Mnemonic.MOV, "MOV W15, V31.S[1]");
        TestInst(MOV(WZR, V31.S[1]), asm => asm.MOV(WZR, V31.S[1]), Arm64InstructionId.MOV_umov_asimdins_w_w, Arm64Mnemonic.MOV, "MOV WZR, V31.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_umov_asimdins_x_x_13()
    {
        TestInst(MOV(X0, V1.D[1]), asm => asm.MOV(X0, V1.D[1]), Arm64InstructionId.MOV_umov_asimdins_x_x, Arm64Mnemonic.MOV, "MOV X0, V1.D[1]");
        TestInst(MOV(X15, V1.D[1]), asm => asm.MOV(X15, V1.D[1]), Arm64InstructionId.MOV_umov_asimdins_x_x, Arm64Mnemonic.MOV, "MOV X15, V1.D[1]");
        TestInst(MOV(XZR, V1.D[1]), asm => asm.MOV(XZR, V1.D[1]), Arm64InstructionId.MOV_umov_asimdins_x_x, Arm64Mnemonic.MOV, "MOV XZR, V1.D[1]");
        TestInst(MOV(X0, V31.D[1]), asm => asm.MOV(X0, V31.D[1]), Arm64InstructionId.MOV_umov_asimdins_x_x, Arm64Mnemonic.MOV, "MOV X0, V31.D[1]");
        TestInst(MOV(X15, V31.D[1]), asm => asm.MOV(X15, V31.D[1]), Arm64InstructionId.MOV_umov_asimdins_x_x, Arm64Mnemonic.MOV, "MOV X15, V31.D[1]");
        TestInst(MOV(XZR, V31.D[1]), asm => asm.MOV(XZR, V31.D[1]), Arm64InstructionId.MOV_umov_asimdins_x_x, Arm64Mnemonic.MOV, "MOV XZR, V31.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_orr_asimdsame_only_14()
    {
        TestInst(MOV(V0.T_8B, V1.T_8B), asm => asm.MOV(V0.T_8B, V1.T_8B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V0.8B, V1.8B");
        TestInst(MOV(V30.T_8B, V1.T_8B), asm => asm.MOV(V30.T_8B, V1.T_8B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V30.8B, V1.8B");
        TestInst(MOV(V0.T_8B, V31.T_8B), asm => asm.MOV(V0.T_8B, V31.T_8B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V0.8B, V31.8B");
        TestInst(MOV(V30.T_8B, V31.T_8B), asm => asm.MOV(V30.T_8B, V31.T_8B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V30.8B, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOV_orr_asimdsame_only_15()
    {
        TestInst(MOV(V0.T_16B, V1.T_16B), asm => asm.MOV(V0.T_16B, V1.T_16B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V0.16B, V1.16B");
        TestInst(MOV(V30.T_16B, V1.T_16B), asm => asm.MOV(V30.T_16B, V1.T_16B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V30.16B, V1.16B");
        TestInst(MOV(V0.T_16B, V31.T_16B), asm => asm.MOV(V0.T_16B, V31.T_16B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V0.16B, V31.16B");
        TestInst(MOV(V30.T_16B, V31.T_16B), asm => asm.MOV(V30.T_16B, V31.T_16B), Arm64InstructionId.MOV_orr_asimdsame_only, Arm64Mnemonic.MOV, "MOV V30.16B, V31.16B");
    }
}
