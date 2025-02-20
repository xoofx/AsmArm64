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
public class Arm64InstructionFactoryTests_LDUMAXAL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMAXAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMAXAL_32_memop_0()
    {
        TestInst(LDUMAXAL(W0, W1, _[X3]), asm => asm.LDUMAXAL(W0, W1, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL W0, W1, [X3]");
        TestInst(LDUMAXAL(W15, W1, _[X3]), asm => asm.LDUMAXAL(W15, W1, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL W15, W1, [X3]");
        TestInst(LDUMAXAL(WZR, W1, _[X3]), asm => asm.LDUMAXAL(WZR, W1, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL WZR, W1, [X3]");
        TestInst(LDUMAXAL(W0, W16, _[X3]), asm => asm.LDUMAXAL(W0, W16, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL W0, W16, [X3]");
        TestInst(LDUMAXAL(W15, W16, _[X3]), asm => asm.LDUMAXAL(W15, W16, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL W15, W16, [X3]");
        TestInst(LDUMAXAL(WZR, W16, _[X3]), asm => asm.LDUMAXAL(WZR, W16, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL WZR, W16, [X3]");
        TestInst(LDUMAXAL(W0, WZR, _[X3]), asm => asm.LDUMAXAL(W0, WZR, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL W0, WZR, [X3]");
        TestInst(LDUMAXAL(W15, WZR, _[X3]), asm => asm.LDUMAXAL(W15, WZR, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL W15, WZR, [X3]");
        TestInst(LDUMAXAL(WZR, WZR, _[X3]), asm => asm.LDUMAXAL(WZR, WZR, _[X3]), Arm64InstructionId.LDUMAXAL_32_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMAXAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMAXAL_64_memop_1()
    {
        TestInst(LDUMAXAL(X0, X1, _[X3]), asm => asm.LDUMAXAL(X0, X1, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL X0, X1, [X3]");
        TestInst(LDUMAXAL(X15, X1, _[X3]), asm => asm.LDUMAXAL(X15, X1, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL X15, X1, [X3]");
        TestInst(LDUMAXAL(XZR, X1, _[X3]), asm => asm.LDUMAXAL(XZR, X1, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL XZR, X1, [X3]");
        TestInst(LDUMAXAL(X0, X16, _[X3]), asm => asm.LDUMAXAL(X0, X16, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL X0, X16, [X3]");
        TestInst(LDUMAXAL(X15, X16, _[X3]), asm => asm.LDUMAXAL(X15, X16, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL X15, X16, [X3]");
        TestInst(LDUMAXAL(XZR, X16, _[X3]), asm => asm.LDUMAXAL(XZR, X16, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL XZR, X16, [X3]");
        TestInst(LDUMAXAL(X0, XZR, _[X3]), asm => asm.LDUMAXAL(X0, XZR, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL X0, XZR, [X3]");
        TestInst(LDUMAXAL(X15, XZR, _[X3]), asm => asm.LDUMAXAL(X15, XZR, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL X15, XZR, [X3]");
        TestInst(LDUMAXAL(XZR, XZR, _[X3]), asm => asm.LDUMAXAL(XZR, XZR, _[X3]), Arm64InstructionId.LDUMAXAL_64_memop, Arm64Mnemonic.LDUMAXAL, "LDUMAXAL XZR, XZR, [X3]");
    }
}
