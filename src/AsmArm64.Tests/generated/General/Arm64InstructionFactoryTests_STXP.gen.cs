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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STXP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STXP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STXP_sp32_ldstexclp_0()
    {
        TestInst(STXP(W0, W1, W2, _[X4]), asm => asm.STXP(W0, W1, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, W1, W2, [X4]");
        TestInst(STXP(W15, W1, W2, _[X4]), asm => asm.STXP(W15, W1, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, W1, W2, [X4]");
        TestInst(STXP(WZR, W1, W2, _[X4]), asm => asm.STXP(WZR, W1, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, W1, W2, [X4]");
        TestInst(STXP(W0, W16, W2, _[X4]), asm => asm.STXP(W0, W16, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, W16, W2, [X4]");
        TestInst(STXP(W15, W16, W2, _[X4]), asm => asm.STXP(W15, W16, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, W16, W2, [X4]");
        TestInst(STXP(WZR, W16, W2, _[X4]), asm => asm.STXP(WZR, W16, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, W16, W2, [X4]");
        TestInst(STXP(W0, WZR, W2, _[X4]), asm => asm.STXP(W0, WZR, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, WZR, W2, [X4]");
        TestInst(STXP(W15, WZR, W2, _[X4]), asm => asm.STXP(W15, WZR, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, WZR, W2, [X4]");
        TestInst(STXP(WZR, WZR, W2, _[X4]), asm => asm.STXP(WZR, WZR, W2, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, WZR, W2, [X4]");
        TestInst(STXP(W0, W1, W17, _[X4]), asm => asm.STXP(W0, W1, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, W1, W17, [X4]");
        TestInst(STXP(W15, W1, W17, _[X4]), asm => asm.STXP(W15, W1, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, W1, W17, [X4]");
        TestInst(STXP(WZR, W1, W17, _[X4]), asm => asm.STXP(WZR, W1, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, W1, W17, [X4]");
        TestInst(STXP(W0, W16, W17, _[X4]), asm => asm.STXP(W0, W16, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, W16, W17, [X4]");
        TestInst(STXP(W15, W16, W17, _[X4]), asm => asm.STXP(W15, W16, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, W16, W17, [X4]");
        TestInst(STXP(WZR, W16, W17, _[X4]), asm => asm.STXP(WZR, W16, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, W16, W17, [X4]");
        TestInst(STXP(W0, WZR, W17, _[X4]), asm => asm.STXP(W0, WZR, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, WZR, W17, [X4]");
        TestInst(STXP(W15, WZR, W17, _[X4]), asm => asm.STXP(W15, WZR, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, WZR, W17, [X4]");
        TestInst(STXP(WZR, WZR, W17, _[X4]), asm => asm.STXP(WZR, WZR, W17, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, WZR, W17, [X4]");
        TestInst(STXP(W0, W1, WZR, _[X4]), asm => asm.STXP(W0, W1, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, W1, WZR, [X4]");
        TestInst(STXP(W15, W1, WZR, _[X4]), asm => asm.STXP(W15, W1, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, W1, WZR, [X4]");
        TestInst(STXP(WZR, W1, WZR, _[X4]), asm => asm.STXP(WZR, W1, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, W1, WZR, [X4]");
        TestInst(STXP(W0, W16, WZR, _[X4]), asm => asm.STXP(W0, W16, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, W16, WZR, [X4]");
        TestInst(STXP(W15, W16, WZR, _[X4]), asm => asm.STXP(W15, W16, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, W16, WZR, [X4]");
        TestInst(STXP(WZR, W16, WZR, _[X4]), asm => asm.STXP(WZR, W16, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, W16, WZR, [X4]");
        TestInst(STXP(W0, WZR, WZR, _[X4]), asm => asm.STXP(W0, WZR, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, WZR, WZR, [X4]");
        TestInst(STXP(W15, WZR, WZR, _[X4]), asm => asm.STXP(W15, WZR, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, WZR, WZR, [X4]");
        TestInst(STXP(WZR, WZR, WZR, _[X4]), asm => asm.STXP(WZR, WZR, WZR, _[X4]), Arm64InstructionId.STXP_sp32_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, WZR, WZR, [X4]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STXP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STXP_sp64_ldstexclp_1()
    {
        TestInst(STXP(W0, X1, X2, _[X4]), asm => asm.STXP(W0, X1, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, X1, X2, [X4]");
        TestInst(STXP(W15, X1, X2, _[X4]), asm => asm.STXP(W15, X1, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, X1, X2, [X4]");
        TestInst(STXP(WZR, X1, X2, _[X4]), asm => asm.STXP(WZR, X1, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, X1, X2, [X4]");
        TestInst(STXP(W0, X16, X2, _[X4]), asm => asm.STXP(W0, X16, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, X16, X2, [X4]");
        TestInst(STXP(W15, X16, X2, _[X4]), asm => asm.STXP(W15, X16, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, X16, X2, [X4]");
        TestInst(STXP(WZR, X16, X2, _[X4]), asm => asm.STXP(WZR, X16, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, X16, X2, [X4]");
        TestInst(STXP(W0, XZR, X2, _[X4]), asm => asm.STXP(W0, XZR, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, XZR, X2, [X4]");
        TestInst(STXP(W15, XZR, X2, _[X4]), asm => asm.STXP(W15, XZR, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, XZR, X2, [X4]");
        TestInst(STXP(WZR, XZR, X2, _[X4]), asm => asm.STXP(WZR, XZR, X2, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, XZR, X2, [X4]");
        TestInst(STXP(W0, X1, X17, _[X4]), asm => asm.STXP(W0, X1, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, X1, X17, [X4]");
        TestInst(STXP(W15, X1, X17, _[X4]), asm => asm.STXP(W15, X1, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, X1, X17, [X4]");
        TestInst(STXP(WZR, X1, X17, _[X4]), asm => asm.STXP(WZR, X1, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, X1, X17, [X4]");
        TestInst(STXP(W0, X16, X17, _[X4]), asm => asm.STXP(W0, X16, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, X16, X17, [X4]");
        TestInst(STXP(W15, X16, X17, _[X4]), asm => asm.STXP(W15, X16, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, X16, X17, [X4]");
        TestInst(STXP(WZR, X16, X17, _[X4]), asm => asm.STXP(WZR, X16, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, X16, X17, [X4]");
        TestInst(STXP(W0, XZR, X17, _[X4]), asm => asm.STXP(W0, XZR, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, XZR, X17, [X4]");
        TestInst(STXP(W15, XZR, X17, _[X4]), asm => asm.STXP(W15, XZR, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, XZR, X17, [X4]");
        TestInst(STXP(WZR, XZR, X17, _[X4]), asm => asm.STXP(WZR, XZR, X17, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, XZR, X17, [X4]");
        TestInst(STXP(W0, X1, XZR, _[X4]), asm => asm.STXP(W0, X1, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, X1, XZR, [X4]");
        TestInst(STXP(W15, X1, XZR, _[X4]), asm => asm.STXP(W15, X1, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, X1, XZR, [X4]");
        TestInst(STXP(WZR, X1, XZR, _[X4]), asm => asm.STXP(WZR, X1, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, X1, XZR, [X4]");
        TestInst(STXP(W0, X16, XZR, _[X4]), asm => asm.STXP(W0, X16, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, X16, XZR, [X4]");
        TestInst(STXP(W15, X16, XZR, _[X4]), asm => asm.STXP(W15, X16, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, X16, XZR, [X4]");
        TestInst(STXP(WZR, X16, XZR, _[X4]), asm => asm.STXP(WZR, X16, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, X16, XZR, [X4]");
        TestInst(STXP(W0, XZR, XZR, _[X4]), asm => asm.STXP(W0, XZR, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W0, XZR, XZR, [X4]");
        TestInst(STXP(W15, XZR, XZR, _[X4]), asm => asm.STXP(W15, XZR, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP W15, XZR, XZR, [X4]");
        TestInst(STXP(WZR, XZR, XZR, _[X4]), asm => asm.STXP(WZR, XZR, XZR, _[X4]), Arm64InstructionId.STXP_sp64_ldstexclp, Arm64Mnemonic.STXP, "STXP WZR, XZR, XZR, [X4]");
    }
}
