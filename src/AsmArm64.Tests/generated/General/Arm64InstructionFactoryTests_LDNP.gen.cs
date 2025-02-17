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
public class Arm64InstructionFactoryTests_LDNP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDNP_32_ldstnapair_offs_0()
    {
        TestInst(LDNP(W0, W1, _[X3, 20]), asm => asm.LDNP(W0, W1, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP W0, W1, [X3, #20]");
        TestInst(LDNP(W15, W1, _[X3, 20]), asm => asm.LDNP(W15, W1, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP W15, W1, [X3, #20]");
        TestInst(LDNP(WZR, W1, _[X3, 20]), asm => asm.LDNP(WZR, W1, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP WZR, W1, [X3, #20]");
        TestInst(LDNP(W0, W16, _[X3, 20]), asm => asm.LDNP(W0, W16, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP W0, W16, [X3, #20]");
        TestInst(LDNP(W15, W16, _[X3, 20]), asm => asm.LDNP(W15, W16, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP W15, W16, [X3, #20]");
        TestInst(LDNP(WZR, W16, _[X3, 20]), asm => asm.LDNP(WZR, W16, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP WZR, W16, [X3, #20]");
        TestInst(LDNP(W0, WZR, _[X3, 20]), asm => asm.LDNP(W0, WZR, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP W0, WZR, [X3, #20]");
        TestInst(LDNP(W15, WZR, _[X3, 20]), asm => asm.LDNP(W15, WZR, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP W15, WZR, [X3, #20]");
        TestInst(LDNP(WZR, WZR, _[X3, 20]), asm => asm.LDNP(WZR, WZR, _[X3, 20]), Arm64InstructionId.LDNP_32_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP WZR, WZR, [X3, #20]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDNP_64_ldstnapair_offs_1()
    {
        TestInst(LDNP(X0, X1, _[X3, 40]), asm => asm.LDNP(X0, X1, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP X0, X1, [X3, #40]");
        TestInst(LDNP(X15, X1, _[X3, 40]), asm => asm.LDNP(X15, X1, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP X15, X1, [X3, #40]");
        TestInst(LDNP(XZR, X1, _[X3, 40]), asm => asm.LDNP(XZR, X1, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP XZR, X1, [X3, #40]");
        TestInst(LDNP(X0, X16, _[X3, 40]), asm => asm.LDNP(X0, X16, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP X0, X16, [X3, #40]");
        TestInst(LDNP(X15, X16, _[X3, 40]), asm => asm.LDNP(X15, X16, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP X15, X16, [X3, #40]");
        TestInst(LDNP(XZR, X16, _[X3, 40]), asm => asm.LDNP(XZR, X16, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP XZR, X16, [X3, #40]");
        TestInst(LDNP(X0, XZR, _[X3, 40]), asm => asm.LDNP(X0, XZR, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP X0, XZR, [X3, #40]");
        TestInst(LDNP(X15, XZR, _[X3, 40]), asm => asm.LDNP(X15, XZR, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP X15, XZR, [X3, #40]");
        TestInst(LDNP(XZR, XZR, _[X3, 40]), asm => asm.LDNP(XZR, XZR, _[X3, 40]), Arm64InstructionId.LDNP_64_ldstnapair_offs, Arm64Mnemonic.LDNP, "LDNP XZR, XZR, [X3, #40]");
    }
}
