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
public class Arm64InstructionFactoryTests_STTNP_Fpsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTNP_q_ldstnapair_offs_0()
    {
        TestInst(STTNP(Q0, Q1, _[X3, 5]), asm => asm.STTNP(Q0, Q1, _[X3, 5]), Arm64InstructionId.STTNP_q_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP Q0, Q1, [X3, #5]");
        TestInst(STTNP(Q31, Q1, _[X3, 5]), asm => asm.STTNP(Q31, Q1, _[X3, 5]), Arm64InstructionId.STTNP_q_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP Q31, Q1, [X3, #5]");
        TestInst(STTNP(Q0, Q31, _[X3, 5]), asm => asm.STTNP(Q0, Q31, _[X3, 5]), Arm64InstructionId.STTNP_q_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP Q0, Q31, [X3, #5]");
        TestInst(STTNP(Q31, Q31, _[X3, 5]), asm => asm.STTNP(Q31, Q31, _[X3, 5]), Arm64InstructionId.STTNP_q_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP Q31, Q31, [X3, #5]");
    }
}
