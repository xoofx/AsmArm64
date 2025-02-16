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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_EXTR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EXTR"/>.
    /// </summary>
    [TestMethod]
    public void Test_EXTR_32_extract_0()
    {
        TestInst(EXTR(W0, W1, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, W1, W2, #5");
        TestInst(EXTR(W15, W1, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, W1, W2, #5");
        TestInst(EXTR(WZR, W1, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, W1, W2, #5");
        TestInst(EXTR(W0, W16, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, W16, W2, #5");
        TestInst(EXTR(W15, W16, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, W16, W2, #5");
        TestInst(EXTR(WZR, W16, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, W16, W2, #5");
        TestInst(EXTR(W0, WZR, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, WZR, W2, #5");
        TestInst(EXTR(W15, WZR, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, WZR, W2, #5");
        TestInst(EXTR(WZR, WZR, W2, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, WZR, W2, #5");
        TestInst(EXTR(W0, W1, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, W1, W17, #5");
        TestInst(EXTR(W15, W1, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, W1, W17, #5");
        TestInst(EXTR(WZR, W1, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, W1, W17, #5");
        TestInst(EXTR(W0, W16, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, W16, W17, #5");
        TestInst(EXTR(W15, W16, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, W16, W17, #5");
        TestInst(EXTR(WZR, W16, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, W16, W17, #5");
        TestInst(EXTR(W0, WZR, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, WZR, W17, #5");
        TestInst(EXTR(W15, WZR, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, WZR, W17, #5");
        TestInst(EXTR(WZR, WZR, W17, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, WZR, W17, #5");
        TestInst(EXTR(W0, W1, WZR, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, W1, WZR, #5");
        TestInst(EXTR(W15, W1, WZR, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, W1, WZR, #5");
        TestInst(EXTR(WZR, W1, WZR, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, W1, WZR, #5");
        TestInst(EXTR(W0, W16, WZR, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W0, W16, WZR, #5");
        TestInst(EXTR(W15, W16, WZR, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR W15, W16, WZR, #5");
        TestInst(EXTR(WZR, W16, WZR, 5), Arm64InstructionId.EXTR_32_extract, Arm64Mnemonic.EXTR, "EXTR WZR, W16, WZR, #5");
        TestInst(EXTR(W0, WZR, WZR, 5), Arm64InstructionId.ROR_extr_32_extract, Arm64Mnemonic.ROR, "ROR W0, WZR, #5");
        TestInst(EXTR(W15, WZR, WZR, 5), Arm64InstructionId.ROR_extr_32_extract, Arm64Mnemonic.ROR, "ROR W15, WZR, #5");
        TestInst(EXTR(WZR, WZR, WZR, 5), Arm64InstructionId.ROR_extr_32_extract, Arm64Mnemonic.ROR, "ROR WZR, WZR, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EXTR"/>.
    /// </summary>
    [TestMethod]
    public void Test_EXTR_64_extract_1()
    {
        TestInst(EXTR(X0, X1, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, X1, X2, #5");
        TestInst(EXTR(X15, X1, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, X1, X2, #5");
        TestInst(EXTR(XZR, X1, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, X1, X2, #5");
        TestInst(EXTR(X0, X16, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, X16, X2, #5");
        TestInst(EXTR(X15, X16, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, X16, X2, #5");
        TestInst(EXTR(XZR, X16, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, X16, X2, #5");
        TestInst(EXTR(X0, XZR, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, XZR, X2, #5");
        TestInst(EXTR(X15, XZR, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, XZR, X2, #5");
        TestInst(EXTR(XZR, XZR, X2, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, XZR, X2, #5");
        TestInst(EXTR(X0, X1, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, X1, X17, #5");
        TestInst(EXTR(X15, X1, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, X1, X17, #5");
        TestInst(EXTR(XZR, X1, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, X1, X17, #5");
        TestInst(EXTR(X0, X16, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, X16, X17, #5");
        TestInst(EXTR(X15, X16, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, X16, X17, #5");
        TestInst(EXTR(XZR, X16, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, X16, X17, #5");
        TestInst(EXTR(X0, XZR, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, XZR, X17, #5");
        TestInst(EXTR(X15, XZR, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, XZR, X17, #5");
        TestInst(EXTR(XZR, XZR, X17, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, XZR, X17, #5");
        TestInst(EXTR(X0, X1, XZR, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, X1, XZR, #5");
        TestInst(EXTR(X15, X1, XZR, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, X1, XZR, #5");
        TestInst(EXTR(XZR, X1, XZR, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, X1, XZR, #5");
        TestInst(EXTR(X0, X16, XZR, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X0, X16, XZR, #5");
        TestInst(EXTR(X15, X16, XZR, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR X15, X16, XZR, #5");
        TestInst(EXTR(XZR, X16, XZR, 5), Arm64InstructionId.EXTR_64_extract, Arm64Mnemonic.EXTR, "EXTR XZR, X16, XZR, #5");
        TestInst(EXTR(X0, XZR, XZR, 5), Arm64InstructionId.ROR_extr_64_extract, Arm64Mnemonic.ROR, "ROR X0, XZR, #5");
        TestInst(EXTR(X15, XZR, XZR, 5), Arm64InstructionId.ROR_extr_64_extract, Arm64Mnemonic.ROR, "ROR X15, XZR, #5");
        TestInst(EXTR(XZR, XZR, XZR, 5), Arm64InstructionId.ROR_extr_64_extract, Arm64Mnemonic.ROR, "ROR XZR, XZR, #5");
    }
}
