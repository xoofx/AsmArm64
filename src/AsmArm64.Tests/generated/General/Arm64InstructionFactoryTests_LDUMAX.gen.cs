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
public class Arm64InstructionFactoryTests_LDUMAX_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMAX_32_memop_0()
    {
        TestInst(LDUMAX(W0, W1, _[X3]), asm => asm.LDUMAX(W0, W1, _[X3]), Arm64InstructionId.LDUMAX_32_memop, Arm64Mnemonic.LDUMAX, "LDUMAX W0, W1, [X3]");
        TestInst(LDUMAX(W15, W1, _[X3]), asm => asm.LDUMAX(W15, W1, _[X3]), Arm64InstructionId.LDUMAX_32_memop, Arm64Mnemonic.LDUMAX, "LDUMAX W15, W1, [X3]");
        TestInst(LDUMAX(WZR, W1, _[X3]), asm => asm.LDUMAX(WZR, W1, _[X3]), Arm64InstructionId.LDUMAX_32_memop, Arm64Mnemonic.LDUMAX, "LDUMAX WZR, W1, [X3]");
        TestInst(LDUMAX(W0, W16, _[X3]), asm => asm.LDUMAX(W0, W16, _[X3]), Arm64InstructionId.LDUMAX_32_memop, Arm64Mnemonic.LDUMAX, "LDUMAX W0, W16, [X3]");
        TestInst(LDUMAX(W15, W16, _[X3]), asm => asm.LDUMAX(W15, W16, _[X3]), Arm64InstructionId.LDUMAX_32_memop, Arm64Mnemonic.LDUMAX, "LDUMAX W15, W16, [X3]");
        TestInst(LDUMAX(WZR, W16, _[X3]), asm => asm.LDUMAX(WZR, W16, _[X3]), Arm64InstructionId.LDUMAX_32_memop, Arm64Mnemonic.LDUMAX, "LDUMAX WZR, W16, [X3]");
        TestInst(LDUMAX(W0, WZR, _[X3]), asm => asm.LDUMAX(W0, WZR, _[X3]), Arm64InstructionId.STUMAX_ldumax_32_memop, Arm64Mnemonic.STUMAX, "STUMAX W0, [X3]");
        TestInst(LDUMAX(W15, WZR, _[X3]), asm => asm.LDUMAX(W15, WZR, _[X3]), Arm64InstructionId.STUMAX_ldumax_32_memop, Arm64Mnemonic.STUMAX, "STUMAX W15, [X3]");
        TestInst(LDUMAX(WZR, WZR, _[X3]), asm => asm.LDUMAX(WZR, WZR, _[X3]), Arm64InstructionId.STUMAX_ldumax_32_memop, Arm64Mnemonic.STUMAX, "STUMAX WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMAX_64_memop_1()
    {
        TestInst(LDUMAX(X0, X1, _[X3]), asm => asm.LDUMAX(X0, X1, _[X3]), Arm64InstructionId.LDUMAX_64_memop, Arm64Mnemonic.LDUMAX, "LDUMAX X0, X1, [X3]");
        TestInst(LDUMAX(X15, X1, _[X3]), asm => asm.LDUMAX(X15, X1, _[X3]), Arm64InstructionId.LDUMAX_64_memop, Arm64Mnemonic.LDUMAX, "LDUMAX X15, X1, [X3]");
        TestInst(LDUMAX(XZR, X1, _[X3]), asm => asm.LDUMAX(XZR, X1, _[X3]), Arm64InstructionId.LDUMAX_64_memop, Arm64Mnemonic.LDUMAX, "LDUMAX XZR, X1, [X3]");
        TestInst(LDUMAX(X0, X16, _[X3]), asm => asm.LDUMAX(X0, X16, _[X3]), Arm64InstructionId.LDUMAX_64_memop, Arm64Mnemonic.LDUMAX, "LDUMAX X0, X16, [X3]");
        TestInst(LDUMAX(X15, X16, _[X3]), asm => asm.LDUMAX(X15, X16, _[X3]), Arm64InstructionId.LDUMAX_64_memop, Arm64Mnemonic.LDUMAX, "LDUMAX X15, X16, [X3]");
        TestInst(LDUMAX(XZR, X16, _[X3]), asm => asm.LDUMAX(XZR, X16, _[X3]), Arm64InstructionId.LDUMAX_64_memop, Arm64Mnemonic.LDUMAX, "LDUMAX XZR, X16, [X3]");
        TestInst(LDUMAX(X0, XZR, _[X3]), asm => asm.LDUMAX(X0, XZR, _[X3]), Arm64InstructionId.STUMAX_ldumax_64_memop, Arm64Mnemonic.STUMAX, "STUMAX X0, [X3]");
        TestInst(LDUMAX(X15, XZR, _[X3]), asm => asm.LDUMAX(X15, XZR, _[X3]), Arm64InstructionId.STUMAX_ldumax_64_memop, Arm64Mnemonic.STUMAX, "STUMAX X15, [X3]");
        TestInst(LDUMAX(XZR, XZR, _[X3]), asm => asm.LDUMAX(XZR, XZR, _[X3]), Arm64InstructionId.STUMAX_ldumax_64_memop, Arm64Mnemonic.STUMAX, "STUMAX XZR, [X3]");
    }
}
