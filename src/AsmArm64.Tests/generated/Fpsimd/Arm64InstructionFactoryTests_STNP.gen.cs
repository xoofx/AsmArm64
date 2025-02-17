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
public class Arm64InstructionFactoryTests_STNP_Fpsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STNP_s_ldstnapair_offs_0()
    {
        TestInst(STNP(S0, S1, _[X3, 20]), asm => asm.STNP(S0, S1, _[X3, 20]), Arm64InstructionId.STNP_s_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP S0, S1, [X3, #20]");
        TestInst(STNP(S31, S1, _[X3, 20]), asm => asm.STNP(S31, S1, _[X3, 20]), Arm64InstructionId.STNP_s_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP S31, S1, [X3, #20]");
        TestInst(STNP(S0, S31, _[X3, 20]), asm => asm.STNP(S0, S31, _[X3, 20]), Arm64InstructionId.STNP_s_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP S0, S31, [X3, #20]");
        TestInst(STNP(S31, S31, _[X3, 20]), asm => asm.STNP(S31, S31, _[X3, 20]), Arm64InstructionId.STNP_s_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP S31, S31, [X3, #20]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STNP_d_ldstnapair_offs_1()
    {
        TestInst(STNP(D0, D1, _[X3, 40]), asm => asm.STNP(D0, D1, _[X3, 40]), Arm64InstructionId.STNP_d_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP D0, D1, [X3, #40]");
        TestInst(STNP(D31, D1, _[X3, 40]), asm => asm.STNP(D31, D1, _[X3, 40]), Arm64InstructionId.STNP_d_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP D31, D1, [X3, #40]");
        TestInst(STNP(D0, D31, _[X3, 40]), asm => asm.STNP(D0, D31, _[X3, 40]), Arm64InstructionId.STNP_d_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP D0, D31, [X3, #40]");
        TestInst(STNP(D31, D31, _[X3, 40]), asm => asm.STNP(D31, D31, _[X3, 40]), Arm64InstructionId.STNP_d_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP D31, D31, [X3, #40]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STNP_q_ldstnapair_offs_2()
    {
        TestInst(STNP(Q0, Q1, _[X3, 80]), asm => asm.STNP(Q0, Q1, _[X3, 80]), Arm64InstructionId.STNP_q_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP Q0, Q1, [X3, #80]");
        TestInst(STNP(Q31, Q1, _[X3, 80]), asm => asm.STNP(Q31, Q1, _[X3, 80]), Arm64InstructionId.STNP_q_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP Q31, Q1, [X3, #80]");
        TestInst(STNP(Q0, Q31, _[X3, 80]), asm => asm.STNP(Q0, Q31, _[X3, 80]), Arm64InstructionId.STNP_q_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP Q0, Q31, [X3, #80]");
        TestInst(STNP(Q31, Q31, _[X3, 80]), asm => asm.STNP(Q31, Q31, _[X3, 80]), Arm64InstructionId.STNP_q_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP Q31, Q31, [X3, #80]");
    }
}
