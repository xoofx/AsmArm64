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
public class Arm64InstructionFactoryTests_LDSMAXA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMAXA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMAXA_32_memop_0()
    {
        TestInst(LDSMAXA(W0, W1, _[X3]), asm => asm.LDSMAXA(W0, W1, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA W0, W1, [X3]");
        TestInst(LDSMAXA(W15, W1, _[X3]), asm => asm.LDSMAXA(W15, W1, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA W15, W1, [X3]");
        TestInst(LDSMAXA(WZR, W1, _[X3]), asm => asm.LDSMAXA(WZR, W1, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA WZR, W1, [X3]");
        TestInst(LDSMAXA(W0, W16, _[X3]), asm => asm.LDSMAXA(W0, W16, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA W0, W16, [X3]");
        TestInst(LDSMAXA(W15, W16, _[X3]), asm => asm.LDSMAXA(W15, W16, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA W15, W16, [X3]");
        TestInst(LDSMAXA(WZR, W16, _[X3]), asm => asm.LDSMAXA(WZR, W16, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA WZR, W16, [X3]");
        TestInst(LDSMAXA(W0, WZR, _[X3]), asm => asm.LDSMAXA(W0, WZR, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA W0, WZR, [X3]");
        TestInst(LDSMAXA(W15, WZR, _[X3]), asm => asm.LDSMAXA(W15, WZR, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA W15, WZR, [X3]");
        TestInst(LDSMAXA(WZR, WZR, _[X3]), asm => asm.LDSMAXA(WZR, WZR, _[X3]), Arm64InstructionId.LDSMAXA_32_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMAXA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMAXA_64_memop_1()
    {
        TestInst(LDSMAXA(X0, X1, _[X3]), asm => asm.LDSMAXA(X0, X1, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA X0, X1, [X3]");
        TestInst(LDSMAXA(X15, X1, _[X3]), asm => asm.LDSMAXA(X15, X1, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA X15, X1, [X3]");
        TestInst(LDSMAXA(XZR, X1, _[X3]), asm => asm.LDSMAXA(XZR, X1, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA XZR, X1, [X3]");
        TestInst(LDSMAXA(X0, X16, _[X3]), asm => asm.LDSMAXA(X0, X16, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA X0, X16, [X3]");
        TestInst(LDSMAXA(X15, X16, _[X3]), asm => asm.LDSMAXA(X15, X16, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA X15, X16, [X3]");
        TestInst(LDSMAXA(XZR, X16, _[X3]), asm => asm.LDSMAXA(XZR, X16, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA XZR, X16, [X3]");
        TestInst(LDSMAXA(X0, XZR, _[X3]), asm => asm.LDSMAXA(X0, XZR, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA X0, XZR, [X3]");
        TestInst(LDSMAXA(X15, XZR, _[X3]), asm => asm.LDSMAXA(X15, XZR, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA X15, XZR, [X3]");
        TestInst(LDSMAXA(XZR, XZR, _[X3]), asm => asm.LDSMAXA(XZR, XZR, _[X3]), Arm64InstructionId.LDSMAXA_64_memop, Arm64Mnemonic.LDSMAXA, "LDSMAXA XZR, XZR, [X3]");
    }
}
