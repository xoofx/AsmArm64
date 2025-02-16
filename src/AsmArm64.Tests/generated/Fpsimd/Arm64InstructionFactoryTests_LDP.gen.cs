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
public class Arm64InstructionFactoryTests_LDP_Fpsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_s_ldstpair_post_0()
    {
        TestInst(LDP(S0, S1, _[X3], 20), asm => asm.LDP(S0, S1, _[X3], 20), Arm64InstructionId.LDP_s_ldstpair_post, Arm64Mnemonic.LDP, "LDP S0, S1, [X3], #20");
        TestInst(LDP(S31, S1, _[X3], 20), asm => asm.LDP(S31, S1, _[X3], 20), Arm64InstructionId.LDP_s_ldstpair_post, Arm64Mnemonic.LDP, "LDP S31, S1, [X3], #20");
        TestInst(LDP(S0, S31, _[X3], 20), asm => asm.LDP(S0, S31, _[X3], 20), Arm64InstructionId.LDP_s_ldstpair_post, Arm64Mnemonic.LDP, "LDP S0, S31, [X3], #20");
        TestInst(LDP(S31, S31, _[X3], 20), asm => asm.LDP(S31, S31, _[X3], 20), Arm64InstructionId.LDP_s_ldstpair_post, Arm64Mnemonic.LDP, "LDP S31, S31, [X3], #20");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_d_ldstpair_post_1()
    {
        TestInst(LDP(D0, D1, _[X3], 40), asm => asm.LDP(D0, D1, _[X3], 40), Arm64InstructionId.LDP_d_ldstpair_post, Arm64Mnemonic.LDP, "LDP D0, D1, [X3], #40");
        TestInst(LDP(D31, D1, _[X3], 40), asm => asm.LDP(D31, D1, _[X3], 40), Arm64InstructionId.LDP_d_ldstpair_post, Arm64Mnemonic.LDP, "LDP D31, D1, [X3], #40");
        TestInst(LDP(D0, D31, _[X3], 40), asm => asm.LDP(D0, D31, _[X3], 40), Arm64InstructionId.LDP_d_ldstpair_post, Arm64Mnemonic.LDP, "LDP D0, D31, [X3], #40");
        TestInst(LDP(D31, D31, _[X3], 40), asm => asm.LDP(D31, D31, _[X3], 40), Arm64InstructionId.LDP_d_ldstpair_post, Arm64Mnemonic.LDP, "LDP D31, D31, [X3], #40");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_q_ldstpair_post_2()
    {
        TestInst(LDP(Q0, Q1, _[X3], 80), asm => asm.LDP(Q0, Q1, _[X3], 80), Arm64InstructionId.LDP_q_ldstpair_post, Arm64Mnemonic.LDP, "LDP Q0, Q1, [X3], #80");
        TestInst(LDP(Q31, Q1, _[X3], 80), asm => asm.LDP(Q31, Q1, _[X3], 80), Arm64InstructionId.LDP_q_ldstpair_post, Arm64Mnemonic.LDP, "LDP Q31, Q1, [X3], #80");
        TestInst(LDP(Q0, Q31, _[X3], 80), asm => asm.LDP(Q0, Q31, _[X3], 80), Arm64InstructionId.LDP_q_ldstpair_post, Arm64Mnemonic.LDP, "LDP Q0, Q31, [X3], #80");
        TestInst(LDP(Q31, Q31, _[X3], 80), asm => asm.LDP(Q31, Q31, _[X3], 80), Arm64InstructionId.LDP_q_ldstpair_post, Arm64Mnemonic.LDP, "LDP Q31, Q31, [X3], #80");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_s_ldstpair_pre_3()
    {
        TestInst(LDP(S0, S1, _[X3, 20].Pre), asm => asm.LDP(S0, S1, _[X3, 20].Pre), Arm64InstructionId.LDP_s_ldstpair_pre, Arm64Mnemonic.LDP, "LDP S0, S1, [X3, #20]!");
        TestInst(LDP(S31, S1, _[X3, 20].Pre), asm => asm.LDP(S31, S1, _[X3, 20].Pre), Arm64InstructionId.LDP_s_ldstpair_pre, Arm64Mnemonic.LDP, "LDP S31, S1, [X3, #20]!");
        TestInst(LDP(S0, S31, _[X3, 20].Pre), asm => asm.LDP(S0, S31, _[X3, 20].Pre), Arm64InstructionId.LDP_s_ldstpair_pre, Arm64Mnemonic.LDP, "LDP S0, S31, [X3, #20]!");
        TestInst(LDP(S31, S31, _[X3, 20].Pre), asm => asm.LDP(S31, S31, _[X3, 20].Pre), Arm64InstructionId.LDP_s_ldstpair_pre, Arm64Mnemonic.LDP, "LDP S31, S31, [X3, #20]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_d_ldstpair_pre_4()
    {
        TestInst(LDP(D0, D1, _[X3, 40].Pre), asm => asm.LDP(D0, D1, _[X3, 40].Pre), Arm64InstructionId.LDP_d_ldstpair_pre, Arm64Mnemonic.LDP, "LDP D0, D1, [X3, #40]!");
        TestInst(LDP(D31, D1, _[X3, 40].Pre), asm => asm.LDP(D31, D1, _[X3, 40].Pre), Arm64InstructionId.LDP_d_ldstpair_pre, Arm64Mnemonic.LDP, "LDP D31, D1, [X3, #40]!");
        TestInst(LDP(D0, D31, _[X3, 40].Pre), asm => asm.LDP(D0, D31, _[X3, 40].Pre), Arm64InstructionId.LDP_d_ldstpair_pre, Arm64Mnemonic.LDP, "LDP D0, D31, [X3, #40]!");
        TestInst(LDP(D31, D31, _[X3, 40].Pre), asm => asm.LDP(D31, D31, _[X3, 40].Pre), Arm64InstructionId.LDP_d_ldstpair_pre, Arm64Mnemonic.LDP, "LDP D31, D31, [X3, #40]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_q_ldstpair_pre_5()
    {
        TestInst(LDP(Q0, Q1, _[X3, 80].Pre), asm => asm.LDP(Q0, Q1, _[X3, 80].Pre), Arm64InstructionId.LDP_q_ldstpair_pre, Arm64Mnemonic.LDP, "LDP Q0, Q1, [X3, #80]!");
        TestInst(LDP(Q31, Q1, _[X3, 80].Pre), asm => asm.LDP(Q31, Q1, _[X3, 80].Pre), Arm64InstructionId.LDP_q_ldstpair_pre, Arm64Mnemonic.LDP, "LDP Q31, Q1, [X3, #80]!");
        TestInst(LDP(Q0, Q31, _[X3, 80].Pre), asm => asm.LDP(Q0, Q31, _[X3, 80].Pre), Arm64InstructionId.LDP_q_ldstpair_pre, Arm64Mnemonic.LDP, "LDP Q0, Q31, [X3, #80]!");
        TestInst(LDP(Q31, Q31, _[X3, 80].Pre), asm => asm.LDP(Q31, Q31, _[X3, 80].Pre), Arm64InstructionId.LDP_q_ldstpair_pre, Arm64Mnemonic.LDP, "LDP Q31, Q31, [X3, #80]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_s_ldstpair_off_6()
    {
        TestInst(LDP(S0, S1, _[X3, 20]), asm => asm.LDP(S0, S1, _[X3, 20]), Arm64InstructionId.LDP_s_ldstpair_off, Arm64Mnemonic.LDP, "LDP S0, S1, [X3, #20]");
        TestInst(LDP(S31, S1, _[X3, 20]), asm => asm.LDP(S31, S1, _[X3, 20]), Arm64InstructionId.LDP_s_ldstpair_off, Arm64Mnemonic.LDP, "LDP S31, S1, [X3, #20]");
        TestInst(LDP(S0, S31, _[X3, 20]), asm => asm.LDP(S0, S31, _[X3, 20]), Arm64InstructionId.LDP_s_ldstpair_off, Arm64Mnemonic.LDP, "LDP S0, S31, [X3, #20]");
        TestInst(LDP(S31, S31, _[X3, 20]), asm => asm.LDP(S31, S31, _[X3, 20]), Arm64InstructionId.LDP_s_ldstpair_off, Arm64Mnemonic.LDP, "LDP S31, S31, [X3, #20]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_d_ldstpair_off_7()
    {
        TestInst(LDP(D0, D1, _[X3, 40]), asm => asm.LDP(D0, D1, _[X3, 40]), Arm64InstructionId.LDP_d_ldstpair_off, Arm64Mnemonic.LDP, "LDP D0, D1, [X3, #40]");
        TestInst(LDP(D31, D1, _[X3, 40]), asm => asm.LDP(D31, D1, _[X3, 40]), Arm64InstructionId.LDP_d_ldstpair_off, Arm64Mnemonic.LDP, "LDP D31, D1, [X3, #40]");
        TestInst(LDP(D0, D31, _[X3, 40]), asm => asm.LDP(D0, D31, _[X3, 40]), Arm64InstructionId.LDP_d_ldstpair_off, Arm64Mnemonic.LDP, "LDP D0, D31, [X3, #40]");
        TestInst(LDP(D31, D31, _[X3, 40]), asm => asm.LDP(D31, D31, _[X3, 40]), Arm64InstructionId.LDP_d_ldstpair_off, Arm64Mnemonic.LDP, "LDP D31, D31, [X3, #40]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDP_q_ldstpair_off_8()
    {
        TestInst(LDP(Q0, Q1, _[X3, 80]), asm => asm.LDP(Q0, Q1, _[X3, 80]), Arm64InstructionId.LDP_q_ldstpair_off, Arm64Mnemonic.LDP, "LDP Q0, Q1, [X3, #80]");
        TestInst(LDP(Q31, Q1, _[X3, 80]), asm => asm.LDP(Q31, Q1, _[X3, 80]), Arm64InstructionId.LDP_q_ldstpair_off, Arm64Mnemonic.LDP, "LDP Q31, Q1, [X3, #80]");
        TestInst(LDP(Q0, Q31, _[X3, 80]), asm => asm.LDP(Q0, Q31, _[X3, 80]), Arm64InstructionId.LDP_q_ldstpair_off, Arm64Mnemonic.LDP, "LDP Q0, Q31, [X3, #80]");
        TestInst(LDP(Q31, Q31, _[X3, 80]), asm => asm.LDP(Q31, Q31, _[X3, 80]), Arm64InstructionId.LDP_q_ldstpair_off, Arm64Mnemonic.LDP, "LDP Q31, Q31, [X3, #80]");
    }
}
