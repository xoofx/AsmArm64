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
public class Arm64InstructionFactoryTests_LDADDL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDL_32_memop_0()
    {
        TestInst(LDADDL(W0, W1, _[X3]), asm => asm.LDADDL(W0, W1, _[X3]), Arm64InstructionId.LDADDL_32_memop, Arm64Mnemonic.LDADDL, "LDADDL W0, W1, [X3]");
        TestInst(LDADDL(W15, W1, _[X3]), asm => asm.LDADDL(W15, W1, _[X3]), Arm64InstructionId.LDADDL_32_memop, Arm64Mnemonic.LDADDL, "LDADDL W15, W1, [X3]");
        TestInst(LDADDL(WZR, W1, _[X3]), asm => asm.LDADDL(WZR, W1, _[X3]), Arm64InstructionId.LDADDL_32_memop, Arm64Mnemonic.LDADDL, "LDADDL WZR, W1, [X3]");
        TestInst(LDADDL(W0, W16, _[X3]), asm => asm.LDADDL(W0, W16, _[X3]), Arm64InstructionId.LDADDL_32_memop, Arm64Mnemonic.LDADDL, "LDADDL W0, W16, [X3]");
        TestInst(LDADDL(W15, W16, _[X3]), asm => asm.LDADDL(W15, W16, _[X3]), Arm64InstructionId.LDADDL_32_memop, Arm64Mnemonic.LDADDL, "LDADDL W15, W16, [X3]");
        TestInst(LDADDL(WZR, W16, _[X3]), asm => asm.LDADDL(WZR, W16, _[X3]), Arm64InstructionId.LDADDL_32_memop, Arm64Mnemonic.LDADDL, "LDADDL WZR, W16, [X3]");
        TestInst(LDADDL(W0, WZR, _[X3]), asm => asm.LDADDL(W0, WZR, _[X3]), Arm64InstructionId.STADDL_ldaddl_32_memop, Arm64Mnemonic.STADDL, "STADDL W0, [X3]");
        TestInst(LDADDL(W15, WZR, _[X3]), asm => asm.LDADDL(W15, WZR, _[X3]), Arm64InstructionId.STADDL_ldaddl_32_memop, Arm64Mnemonic.STADDL, "STADDL W15, [X3]");
        TestInst(LDADDL(WZR, WZR, _[X3]), asm => asm.LDADDL(WZR, WZR, _[X3]), Arm64InstructionId.STADDL_ldaddl_32_memop, Arm64Mnemonic.STADDL, "STADDL WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDL_64_memop_1()
    {
        TestInst(LDADDL(X0, X1, _[X3]), asm => asm.LDADDL(X0, X1, _[X3]), Arm64InstructionId.LDADDL_64_memop, Arm64Mnemonic.LDADDL, "LDADDL X0, X1, [X3]");
        TestInst(LDADDL(X15, X1, _[X3]), asm => asm.LDADDL(X15, X1, _[X3]), Arm64InstructionId.LDADDL_64_memop, Arm64Mnemonic.LDADDL, "LDADDL X15, X1, [X3]");
        TestInst(LDADDL(XZR, X1, _[X3]), asm => asm.LDADDL(XZR, X1, _[X3]), Arm64InstructionId.LDADDL_64_memop, Arm64Mnemonic.LDADDL, "LDADDL XZR, X1, [X3]");
        TestInst(LDADDL(X0, X16, _[X3]), asm => asm.LDADDL(X0, X16, _[X3]), Arm64InstructionId.LDADDL_64_memop, Arm64Mnemonic.LDADDL, "LDADDL X0, X16, [X3]");
        TestInst(LDADDL(X15, X16, _[X3]), asm => asm.LDADDL(X15, X16, _[X3]), Arm64InstructionId.LDADDL_64_memop, Arm64Mnemonic.LDADDL, "LDADDL X15, X16, [X3]");
        TestInst(LDADDL(XZR, X16, _[X3]), asm => asm.LDADDL(XZR, X16, _[X3]), Arm64InstructionId.LDADDL_64_memop, Arm64Mnemonic.LDADDL, "LDADDL XZR, X16, [X3]");
        TestInst(LDADDL(X0, XZR, _[X3]), asm => asm.LDADDL(X0, XZR, _[X3]), Arm64InstructionId.STADDL_ldaddl_64_memop, Arm64Mnemonic.STADDL, "STADDL X0, [X3]");
        TestInst(LDADDL(X15, XZR, _[X3]), asm => asm.LDADDL(X15, XZR, _[X3]), Arm64InstructionId.STADDL_ldaddl_64_memop, Arm64Mnemonic.STADDL, "STADDL X15, [X3]");
        TestInst(LDADDL(XZR, XZR, _[X3]), asm => asm.LDADDL(XZR, XZR, _[X3]), Arm64InstructionId.STADDL_ldaddl_64_memop, Arm64Mnemonic.STADDL, "STADDL XZR, [X3]");
    }
}
