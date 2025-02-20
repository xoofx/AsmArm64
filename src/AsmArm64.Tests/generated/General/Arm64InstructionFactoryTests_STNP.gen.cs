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
public class Arm64InstructionFactoryTests_STNP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STNP_32_ldstnapair_offs_0()
    {
        TestInst(STNP(W0, W1, _[X3, 20]), asm => asm.STNP(W0, W1, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP W0, W1, [X3, #20]");
        TestInst(STNP(W15, W1, _[X3, 20]), asm => asm.STNP(W15, W1, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP W15, W1, [X3, #20]");
        TestInst(STNP(WZR, W1, _[X3, 20]), asm => asm.STNP(WZR, W1, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP WZR, W1, [X3, #20]");
        TestInst(STNP(W0, W16, _[X3, 20]), asm => asm.STNP(W0, W16, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP W0, W16, [X3, #20]");
        TestInst(STNP(W15, W16, _[X3, 20]), asm => asm.STNP(W15, W16, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP W15, W16, [X3, #20]");
        TestInst(STNP(WZR, W16, _[X3, 20]), asm => asm.STNP(WZR, W16, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP WZR, W16, [X3, #20]");
        TestInst(STNP(W0, WZR, _[X3, 20]), asm => asm.STNP(W0, WZR, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP W0, WZR, [X3, #20]");
        TestInst(STNP(W15, WZR, _[X3, 20]), asm => asm.STNP(W15, WZR, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP W15, WZR, [X3, #20]");
        TestInst(STNP(WZR, WZR, _[X3, 20]), asm => asm.STNP(WZR, WZR, _[X3, 20]), Arm64InstructionId.STNP_32_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP WZR, WZR, [X3, #20]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STNP_64_ldstnapair_offs_1()
    {
        TestInst(STNP(X0, X1, _[X3, 5]), asm => asm.STNP(X0, X1, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP X0, X1, [X3, #5]");
        TestInst(STNP(X15, X1, _[X3, 5]), asm => asm.STNP(X15, X1, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP X15, X1, [X3, #5]");
        TestInst(STNP(XZR, X1, _[X3, 5]), asm => asm.STNP(XZR, X1, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP XZR, X1, [X3, #5]");
        TestInst(STNP(X0, X16, _[X3, 5]), asm => asm.STNP(X0, X16, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP X0, X16, [X3, #5]");
        TestInst(STNP(X15, X16, _[X3, 5]), asm => asm.STNP(X15, X16, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP X15, X16, [X3, #5]");
        TestInst(STNP(XZR, X16, _[X3, 5]), asm => asm.STNP(XZR, X16, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP XZR, X16, [X3, #5]");
        TestInst(STNP(X0, XZR, _[X3, 5]), asm => asm.STNP(X0, XZR, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP X0, XZR, [X3, #5]");
        TestInst(STNP(X15, XZR, _[X3, 5]), asm => asm.STNP(X15, XZR, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP X15, XZR, [X3, #5]");
        TestInst(STNP(XZR, XZR, _[X3, 5]), asm => asm.STNP(XZR, XZR, _[X3, 5]), Arm64InstructionId.STNP_64_ldstnapair_offs, Arm64Mnemonic.STNP, "STNP XZR, XZR, [X3, #5]");
    }
}
