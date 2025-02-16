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
public class Arm64InstructionFactoryTests_INS_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_iv_v_0()
    {
        TestInst(INS(V0.B[0], V1.B[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.B[0], V1.B[0]");
        TestInst(INS(V30.B[1], V1.B[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.B[1], V1.B[0]");
        TestInst(INS(V0.B[0], V31.B[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.B[0], V31.B[1]");
        TestInst(INS(V30.B[1], V31.B[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.B[1], V31.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_iv_v_1()
    {
        TestInst(INS(V0.H[0], V1.H[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.H[0], V1.H[0]");
        TestInst(INS(V30.H[1], V1.H[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.H[1], V1.H[0]");
        TestInst(INS(V0.H[0], V31.H[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.H[0], V31.H[1]");
        TestInst(INS(V30.H[1], V31.H[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.H[1], V31.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_iv_v_2()
    {
        TestInst(INS(V0.S[0], V1.S[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.S[0], V1.S[0]");
        TestInst(INS(V30.S[1], V1.S[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.S[1], V1.S[0]");
        TestInst(INS(V0.S[0], V31.S[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.S[0], V31.S[1]");
        TestInst(INS(V30.S[1], V31.S[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.S[1], V31.S[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_iv_v_3()
    {
        TestInst(INS(V0.D[0], V1.D[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.D[0], V1.D[0]");
        TestInst(INS(V30.D[1], V1.D[0]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.D[1], V1.D[0]");
        TestInst(INS(V0.D[0], V31.D[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V0.D[0], V31.D[1]");
        TestInst(INS(V30.D[1], V31.D[1]), Arm64InstructionId.MOV_ins_asimdins_iv_v, Arm64Mnemonic.MOV, "MOV V30.D[1], V31.D[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_ir_r_4()
    {
        TestInst(INS(V0.B[0], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.B[0], W2");
        TestInst(INS(V30.B[1], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.B[1], W2");
        TestInst(INS(V0.B[0], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.B[0], WZR");
        TestInst(INS(V30.B[1], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.B[1], WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_ir_r_5()
    {
        TestInst(INS(V0.H[0], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.H[0], W2");
        TestInst(INS(V30.H[1], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.H[1], W2");
        TestInst(INS(V0.H[0], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.H[0], WZR");
        TestInst(INS(V30.H[1], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.H[1], WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_ir_r_6()
    {
        TestInst(INS(V0.S[0], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.S[0], W2");
        TestInst(INS(V30.S[1], W2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.S[1], W2");
        TestInst(INS(V0.S[0], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.S[0], WZR");
        TestInst(INS(V30.S[1], WZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.S[1], WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.INS"/>.
    /// </summary>
    [TestMethod]
    public void Test_INS_asimdins_ir_r_7()
    {
        TestInst(INS(V0.D[0], X2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.D[0], X2");
        TestInst(INS(V30.D[1], X2), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.D[1], X2");
        TestInst(INS(V0.D[0], XZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V0.D[0], XZR");
        TestInst(INS(V30.D[1], XZR), Arm64InstructionId.MOV_ins_asimdins_ir_r, Arm64Mnemonic.MOV, "MOV V30.D[1], XZR");
    }
}
