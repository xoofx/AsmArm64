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
public class Arm64InstructionFactoryTests_LDADD_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADD_32_memop_0()
    {
        TestInst(LDADD(W0, W1, _[X3]), asm => asm.LDADD(W0, W1, _[X3]), Arm64InstructionId.LDADD_32_memop, Arm64Mnemonic.LDADD, "LDADD W0, W1, [X3]");
        TestInst(LDADD(W15, W1, _[X3]), asm => asm.LDADD(W15, W1, _[X3]), Arm64InstructionId.LDADD_32_memop, Arm64Mnemonic.LDADD, "LDADD W15, W1, [X3]");
        TestInst(LDADD(WZR, W1, _[X3]), asm => asm.LDADD(WZR, W1, _[X3]), Arm64InstructionId.LDADD_32_memop, Arm64Mnemonic.LDADD, "LDADD WZR, W1, [X3]");
        TestInst(LDADD(W0, W16, _[X3]), asm => asm.LDADD(W0, W16, _[X3]), Arm64InstructionId.LDADD_32_memop, Arm64Mnemonic.LDADD, "LDADD W0, W16, [X3]");
        TestInst(LDADD(W15, W16, _[X3]), asm => asm.LDADD(W15, W16, _[X3]), Arm64InstructionId.LDADD_32_memop, Arm64Mnemonic.LDADD, "LDADD W15, W16, [X3]");
        TestInst(LDADD(WZR, W16, _[X3]), asm => asm.LDADD(WZR, W16, _[X3]), Arm64InstructionId.LDADD_32_memop, Arm64Mnemonic.LDADD, "LDADD WZR, W16, [X3]");
        TestInst(LDADD(W0, WZR, _[X3]), asm => asm.LDADD(W0, WZR, _[X3]), Arm64InstructionId.STADD_ldadd_32_memop, Arm64Mnemonic.STADD, "STADD W0, [X3]");
        TestInst(LDADD(W15, WZR, _[X3]), asm => asm.LDADD(W15, WZR, _[X3]), Arm64InstructionId.STADD_ldadd_32_memop, Arm64Mnemonic.STADD, "STADD W15, [X3]");
        TestInst(LDADD(WZR, WZR, _[X3]), asm => asm.LDADD(WZR, WZR, _[X3]), Arm64InstructionId.STADD_ldadd_32_memop, Arm64Mnemonic.STADD, "STADD WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADD_64_memop_1()
    {
        TestInst(LDADD(X0, X1, _[X3]), asm => asm.LDADD(X0, X1, _[X3]), Arm64InstructionId.LDADD_64_memop, Arm64Mnemonic.LDADD, "LDADD X0, X1, [X3]");
        TestInst(LDADD(X15, X1, _[X3]), asm => asm.LDADD(X15, X1, _[X3]), Arm64InstructionId.LDADD_64_memop, Arm64Mnemonic.LDADD, "LDADD X15, X1, [X3]");
        TestInst(LDADD(XZR, X1, _[X3]), asm => asm.LDADD(XZR, X1, _[X3]), Arm64InstructionId.LDADD_64_memop, Arm64Mnemonic.LDADD, "LDADD XZR, X1, [X3]");
        TestInst(LDADD(X0, X16, _[X3]), asm => asm.LDADD(X0, X16, _[X3]), Arm64InstructionId.LDADD_64_memop, Arm64Mnemonic.LDADD, "LDADD X0, X16, [X3]");
        TestInst(LDADD(X15, X16, _[X3]), asm => asm.LDADD(X15, X16, _[X3]), Arm64InstructionId.LDADD_64_memop, Arm64Mnemonic.LDADD, "LDADD X15, X16, [X3]");
        TestInst(LDADD(XZR, X16, _[X3]), asm => asm.LDADD(XZR, X16, _[X3]), Arm64InstructionId.LDADD_64_memop, Arm64Mnemonic.LDADD, "LDADD XZR, X16, [X3]");
        TestInst(LDADD(X0, XZR, _[X3]), asm => asm.LDADD(X0, XZR, _[X3]), Arm64InstructionId.STADD_ldadd_64_memop, Arm64Mnemonic.STADD, "STADD X0, [X3]");
        TestInst(LDADD(X15, XZR, _[X3]), asm => asm.LDADD(X15, XZR, _[X3]), Arm64InstructionId.STADD_ldadd_64_memop, Arm64Mnemonic.STADD, "STADD X15, [X3]");
        TestInst(LDADD(XZR, XZR, _[X3]), asm => asm.LDADD(XZR, XZR, _[X3]), Arm64InstructionId.STADD_ldadd_64_memop, Arm64Mnemonic.STADD, "STADD XZR, [X3]");
    }
}
