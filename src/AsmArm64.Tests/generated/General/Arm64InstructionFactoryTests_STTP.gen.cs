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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STTP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTP_64_ldstpair_post_0()
    {
        TestInst(STTP(X0, X1, _[X3], 40), asm => asm.STTP(X0, X1, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP X0, X1, [X3], #40");
        TestInst(STTP(X15, X1, _[X3], 40), asm => asm.STTP(X15, X1, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP X15, X1, [X3], #40");
        TestInst(STTP(XZR, X1, _[X3], 40), asm => asm.STTP(XZR, X1, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP XZR, X1, [X3], #40");
        TestInst(STTP(X0, X16, _[X3], 40), asm => asm.STTP(X0, X16, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP X0, X16, [X3], #40");
        TestInst(STTP(X15, X16, _[X3], 40), asm => asm.STTP(X15, X16, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP X15, X16, [X3], #40");
        TestInst(STTP(XZR, X16, _[X3], 40), asm => asm.STTP(XZR, X16, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP XZR, X16, [X3], #40");
        TestInst(STTP(X0, XZR, _[X3], 40), asm => asm.STTP(X0, XZR, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP X0, XZR, [X3], #40");
        TestInst(STTP(X15, XZR, _[X3], 40), asm => asm.STTP(X15, XZR, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP X15, XZR, [X3], #40");
        TestInst(STTP(XZR, XZR, _[X3], 40), asm => asm.STTP(XZR, XZR, _[X3], 40), Arm64InstructionId.STTP_64_ldstpair_post, Arm64Mnemonic.STTP, "STTP XZR, XZR, [X3], #40");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTP_64_ldstpair_pre_1()
    {
        TestInst(STTP(X0, X1, _[X3, 5].Pre), asm => asm.STTP(X0, X1, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP X0, X1, [X3, #5]!");
        TestInst(STTP(X15, X1, _[X3, 5].Pre), asm => asm.STTP(X15, X1, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP X15, X1, [X3, #5]!");
        TestInst(STTP(XZR, X1, _[X3, 5].Pre), asm => asm.STTP(XZR, X1, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP XZR, X1, [X3, #5]!");
        TestInst(STTP(X0, X16, _[X3, 5].Pre), asm => asm.STTP(X0, X16, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP X0, X16, [X3, #5]!");
        TestInst(STTP(X15, X16, _[X3, 5].Pre), asm => asm.STTP(X15, X16, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP X15, X16, [X3, #5]!");
        TestInst(STTP(XZR, X16, _[X3, 5].Pre), asm => asm.STTP(XZR, X16, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP XZR, X16, [X3, #5]!");
        TestInst(STTP(X0, XZR, _[X3, 5].Pre), asm => asm.STTP(X0, XZR, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP X0, XZR, [X3, #5]!");
        TestInst(STTP(X15, XZR, _[X3, 5].Pre), asm => asm.STTP(X15, XZR, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP X15, XZR, [X3, #5]!");
        TestInst(STTP(XZR, XZR, _[X3, 5].Pre), asm => asm.STTP(XZR, XZR, _[X3, 5].Pre), Arm64InstructionId.STTP_64_ldstpair_pre, Arm64Mnemonic.STTP, "STTP XZR, XZR, [X3, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTP_64_ldstpair_off_2()
    {
        TestInst(STTP(X0, X1, _[X3, 5]), asm => asm.STTP(X0, X1, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP X0, X1, [X3, #5]");
        TestInst(STTP(X15, X1, _[X3, 5]), asm => asm.STTP(X15, X1, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP X15, X1, [X3, #5]");
        TestInst(STTP(XZR, X1, _[X3, 5]), asm => asm.STTP(XZR, X1, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP XZR, X1, [X3, #5]");
        TestInst(STTP(X0, X16, _[X3, 5]), asm => asm.STTP(X0, X16, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP X0, X16, [X3, #5]");
        TestInst(STTP(X15, X16, _[X3, 5]), asm => asm.STTP(X15, X16, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP X15, X16, [X3, #5]");
        TestInst(STTP(XZR, X16, _[X3, 5]), asm => asm.STTP(XZR, X16, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP XZR, X16, [X3, #5]");
        TestInst(STTP(X0, XZR, _[X3, 5]), asm => asm.STTP(X0, XZR, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP X0, XZR, [X3, #5]");
        TestInst(STTP(X15, XZR, _[X3, 5]), asm => asm.STTP(X15, XZR, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP X15, XZR, [X3, #5]");
        TestInst(STTP(XZR, XZR, _[X3, 5]), asm => asm.STTP(XZR, XZR, _[X3, 5]), Arm64InstructionId.STTP_64_ldstpair_off, Arm64Mnemonic.STTP, "STTP XZR, XZR, [X3, #5]");
    }
}
