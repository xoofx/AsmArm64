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
public class Arm64InstructionFactoryTests_STLXP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLXP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLXP_sp32_ldstexclp_0()
    {
        TestInst(STLXP(W0, W1, W2, _[X4]), asm => asm.STLXP(W0, W1, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, W1, W2, [X4]");
        TestInst(STLXP(W15, W1, W2, _[X4]), asm => asm.STLXP(W15, W1, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, W1, W2, [X4]");
        TestInst(STLXP(WZR, W1, W2, _[X4]), asm => asm.STLXP(WZR, W1, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, W1, W2, [X4]");
        TestInst(STLXP(W0, W16, W2, _[X4]), asm => asm.STLXP(W0, W16, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, W16, W2, [X4]");
        TestInst(STLXP(W15, W16, W2, _[X4]), asm => asm.STLXP(W15, W16, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, W16, W2, [X4]");
        TestInst(STLXP(WZR, W16, W2, _[X4]), asm => asm.STLXP(WZR, W16, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, W16, W2, [X4]");
        TestInst(STLXP(W0, WZR, W2, _[X4]), asm => asm.STLXP(W0, WZR, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, WZR, W2, [X4]");
        TestInst(STLXP(W15, WZR, W2, _[X4]), asm => asm.STLXP(W15, WZR, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, WZR, W2, [X4]");
        TestInst(STLXP(WZR, WZR, W2, _[X4]), asm => asm.STLXP(WZR, WZR, W2, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, WZR, W2, [X4]");
        TestInst(STLXP(W0, W1, W17, _[X4]), asm => asm.STLXP(W0, W1, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, W1, W17, [X4]");
        TestInst(STLXP(W15, W1, W17, _[X4]), asm => asm.STLXP(W15, W1, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, W1, W17, [X4]");
        TestInst(STLXP(WZR, W1, W17, _[X4]), asm => asm.STLXP(WZR, W1, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, W1, W17, [X4]");
        TestInst(STLXP(W0, W16, W17, _[X4]), asm => asm.STLXP(W0, W16, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, W16, W17, [X4]");
        TestInst(STLXP(W15, W16, W17, _[X4]), asm => asm.STLXP(W15, W16, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, W16, W17, [X4]");
        TestInst(STLXP(WZR, W16, W17, _[X4]), asm => asm.STLXP(WZR, W16, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, W16, W17, [X4]");
        TestInst(STLXP(W0, WZR, W17, _[X4]), asm => asm.STLXP(W0, WZR, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, WZR, W17, [X4]");
        TestInst(STLXP(W15, WZR, W17, _[X4]), asm => asm.STLXP(W15, WZR, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, WZR, W17, [X4]");
        TestInst(STLXP(WZR, WZR, W17, _[X4]), asm => asm.STLXP(WZR, WZR, W17, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, WZR, W17, [X4]");
        TestInst(STLXP(W0, W1, WZR, _[X4]), asm => asm.STLXP(W0, W1, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, W1, WZR, [X4]");
        TestInst(STLXP(W15, W1, WZR, _[X4]), asm => asm.STLXP(W15, W1, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, W1, WZR, [X4]");
        TestInst(STLXP(WZR, W1, WZR, _[X4]), asm => asm.STLXP(WZR, W1, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, W1, WZR, [X4]");
        TestInst(STLXP(W0, W16, WZR, _[X4]), asm => asm.STLXP(W0, W16, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, W16, WZR, [X4]");
        TestInst(STLXP(W15, W16, WZR, _[X4]), asm => asm.STLXP(W15, W16, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, W16, WZR, [X4]");
        TestInst(STLXP(WZR, W16, WZR, _[X4]), asm => asm.STLXP(WZR, W16, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, W16, WZR, [X4]");
        TestInst(STLXP(W0, WZR, WZR, _[X4]), asm => asm.STLXP(W0, WZR, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, WZR, WZR, [X4]");
        TestInst(STLXP(W15, WZR, WZR, _[X4]), asm => asm.STLXP(W15, WZR, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, WZR, WZR, [X4]");
        TestInst(STLXP(WZR, WZR, WZR, _[X4]), asm => asm.STLXP(WZR, WZR, WZR, _[X4]), Arm64InstructionId.STLXP_sp32_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, WZR, WZR, [X4]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLXP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLXP_sp64_ldstexclp_1()
    {
        TestInst(STLXP(W0, X1, X2, _[X4]), asm => asm.STLXP(W0, X1, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, X1, X2, [X4]");
        TestInst(STLXP(W15, X1, X2, _[X4]), asm => asm.STLXP(W15, X1, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, X1, X2, [X4]");
        TestInst(STLXP(WZR, X1, X2, _[X4]), asm => asm.STLXP(WZR, X1, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, X1, X2, [X4]");
        TestInst(STLXP(W0, X16, X2, _[X4]), asm => asm.STLXP(W0, X16, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, X16, X2, [X4]");
        TestInst(STLXP(W15, X16, X2, _[X4]), asm => asm.STLXP(W15, X16, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, X16, X2, [X4]");
        TestInst(STLXP(WZR, X16, X2, _[X4]), asm => asm.STLXP(WZR, X16, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, X16, X2, [X4]");
        TestInst(STLXP(W0, XZR, X2, _[X4]), asm => asm.STLXP(W0, XZR, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, XZR, X2, [X4]");
        TestInst(STLXP(W15, XZR, X2, _[X4]), asm => asm.STLXP(W15, XZR, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, XZR, X2, [X4]");
        TestInst(STLXP(WZR, XZR, X2, _[X4]), asm => asm.STLXP(WZR, XZR, X2, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, XZR, X2, [X4]");
        TestInst(STLXP(W0, X1, X17, _[X4]), asm => asm.STLXP(W0, X1, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, X1, X17, [X4]");
        TestInst(STLXP(W15, X1, X17, _[X4]), asm => asm.STLXP(W15, X1, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, X1, X17, [X4]");
        TestInst(STLXP(WZR, X1, X17, _[X4]), asm => asm.STLXP(WZR, X1, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, X1, X17, [X4]");
        TestInst(STLXP(W0, X16, X17, _[X4]), asm => asm.STLXP(W0, X16, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, X16, X17, [X4]");
        TestInst(STLXP(W15, X16, X17, _[X4]), asm => asm.STLXP(W15, X16, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, X16, X17, [X4]");
        TestInst(STLXP(WZR, X16, X17, _[X4]), asm => asm.STLXP(WZR, X16, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, X16, X17, [X4]");
        TestInst(STLXP(W0, XZR, X17, _[X4]), asm => asm.STLXP(W0, XZR, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, XZR, X17, [X4]");
        TestInst(STLXP(W15, XZR, X17, _[X4]), asm => asm.STLXP(W15, XZR, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, XZR, X17, [X4]");
        TestInst(STLXP(WZR, XZR, X17, _[X4]), asm => asm.STLXP(WZR, XZR, X17, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, XZR, X17, [X4]");
        TestInst(STLXP(W0, X1, XZR, _[X4]), asm => asm.STLXP(W0, X1, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, X1, XZR, [X4]");
        TestInst(STLXP(W15, X1, XZR, _[X4]), asm => asm.STLXP(W15, X1, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, X1, XZR, [X4]");
        TestInst(STLXP(WZR, X1, XZR, _[X4]), asm => asm.STLXP(WZR, X1, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, X1, XZR, [X4]");
        TestInst(STLXP(W0, X16, XZR, _[X4]), asm => asm.STLXP(W0, X16, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, X16, XZR, [X4]");
        TestInst(STLXP(W15, X16, XZR, _[X4]), asm => asm.STLXP(W15, X16, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, X16, XZR, [X4]");
        TestInst(STLXP(WZR, X16, XZR, _[X4]), asm => asm.STLXP(WZR, X16, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, X16, XZR, [X4]");
        TestInst(STLXP(W0, XZR, XZR, _[X4]), asm => asm.STLXP(W0, XZR, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W0, XZR, XZR, [X4]");
        TestInst(STLXP(W15, XZR, XZR, _[X4]), asm => asm.STLXP(W15, XZR, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP W15, XZR, XZR, [X4]");
        TestInst(STLXP(WZR, XZR, XZR, _[X4]), asm => asm.STLXP(WZR, XZR, XZR, _[X4]), Arm64InstructionId.STLXP_sp64_ldstexclp, Arm64Mnemonic.STLXP, "STLXP WZR, XZR, XZR, [X4]");
    }
}
