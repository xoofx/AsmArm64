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
public class Arm64InstructionFactoryTests_SWPTL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTL_32_memop_unpriv_0()
    {
        TestInst(SWPTL(W0, W1, _[X3]), asm => asm.SWPTL(W0, W1, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL W0, W1, [X3]");
        TestInst(SWPTL(W15, W1, _[X3]), asm => asm.SWPTL(W15, W1, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL W15, W1, [X3]");
        TestInst(SWPTL(WZR, W1, _[X3]), asm => asm.SWPTL(WZR, W1, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL WZR, W1, [X3]");
        TestInst(SWPTL(W0, W16, _[X3]), asm => asm.SWPTL(W0, W16, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL W0, W16, [X3]");
        TestInst(SWPTL(W15, W16, _[X3]), asm => asm.SWPTL(W15, W16, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL W15, W16, [X3]");
        TestInst(SWPTL(WZR, W16, _[X3]), asm => asm.SWPTL(WZR, W16, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL WZR, W16, [X3]");
        TestInst(SWPTL(W0, WZR, _[X3]), asm => asm.SWPTL(W0, WZR, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL W0, WZR, [X3]");
        TestInst(SWPTL(W15, WZR, _[X3]), asm => asm.SWPTL(W15, WZR, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL W15, WZR, [X3]");
        TestInst(SWPTL(WZR, WZR, _[X3]), asm => asm.SWPTL(WZR, WZR, _[X3]), Arm64InstructionId.SWPTL_32_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTL_64_memop_unpriv_1()
    {
        TestInst(SWPTL(X0, X1, _[X3]), asm => asm.SWPTL(X0, X1, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL X0, X1, [X3]");
        TestInst(SWPTL(X15, X1, _[X3]), asm => asm.SWPTL(X15, X1, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL X15, X1, [X3]");
        TestInst(SWPTL(XZR, X1, _[X3]), asm => asm.SWPTL(XZR, X1, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL XZR, X1, [X3]");
        TestInst(SWPTL(X0, X16, _[X3]), asm => asm.SWPTL(X0, X16, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL X0, X16, [X3]");
        TestInst(SWPTL(X15, X16, _[X3]), asm => asm.SWPTL(X15, X16, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL X15, X16, [X3]");
        TestInst(SWPTL(XZR, X16, _[X3]), asm => asm.SWPTL(XZR, X16, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL XZR, X16, [X3]");
        TestInst(SWPTL(X0, XZR, _[X3]), asm => asm.SWPTL(X0, XZR, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL X0, XZR, [X3]");
        TestInst(SWPTL(X15, XZR, _[X3]), asm => asm.SWPTL(X15, XZR, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL X15, XZR, [X3]");
        TestInst(SWPTL(XZR, XZR, _[X3]), asm => asm.SWPTL(XZR, XZR, _[X3]), Arm64InstructionId.SWPTL_64_memop_unpriv, Arm64Mnemonic.SWPTL, "SWPTL XZR, XZR, [X3]");
    }
}
