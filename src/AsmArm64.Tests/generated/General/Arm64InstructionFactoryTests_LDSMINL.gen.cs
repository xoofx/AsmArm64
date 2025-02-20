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
public class Arm64InstructionFactoryTests_LDSMINL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMINL_32_memop_0()
    {
        TestInst(LDSMINL(W0, W1, _[X3]), asm => asm.LDSMINL(W0, W1, _[X3]), Arm64InstructionId.LDSMINL_32_memop, Arm64Mnemonic.LDSMINL, "LDSMINL W0, W1, [X3]");
        TestInst(LDSMINL(W15, W1, _[X3]), asm => asm.LDSMINL(W15, W1, _[X3]), Arm64InstructionId.LDSMINL_32_memop, Arm64Mnemonic.LDSMINL, "LDSMINL W15, W1, [X3]");
        TestInst(LDSMINL(WZR, W1, _[X3]), asm => asm.LDSMINL(WZR, W1, _[X3]), Arm64InstructionId.LDSMINL_32_memop, Arm64Mnemonic.LDSMINL, "LDSMINL WZR, W1, [X3]");
        TestInst(LDSMINL(W0, W16, _[X3]), asm => asm.LDSMINL(W0, W16, _[X3]), Arm64InstructionId.LDSMINL_32_memop, Arm64Mnemonic.LDSMINL, "LDSMINL W0, W16, [X3]");
        TestInst(LDSMINL(W15, W16, _[X3]), asm => asm.LDSMINL(W15, W16, _[X3]), Arm64InstructionId.LDSMINL_32_memop, Arm64Mnemonic.LDSMINL, "LDSMINL W15, W16, [X3]");
        TestInst(LDSMINL(WZR, W16, _[X3]), asm => asm.LDSMINL(WZR, W16, _[X3]), Arm64InstructionId.LDSMINL_32_memop, Arm64Mnemonic.LDSMINL, "LDSMINL WZR, W16, [X3]");
        TestInst(LDSMINL(W0, WZR, _[X3]), asm => asm.LDSMINL(W0, WZR, _[X3]), Arm64InstructionId.STSMINL_ldsminl_32_memop, Arm64Mnemonic.STSMINL, "STSMINL W0, [X3]");
        TestInst(LDSMINL(W15, WZR, _[X3]), asm => asm.LDSMINL(W15, WZR, _[X3]), Arm64InstructionId.STSMINL_ldsminl_32_memop, Arm64Mnemonic.STSMINL, "STSMINL W15, [X3]");
        TestInst(LDSMINL(WZR, WZR, _[X3]), asm => asm.LDSMINL(WZR, WZR, _[X3]), Arm64InstructionId.STSMINL_ldsminl_32_memop, Arm64Mnemonic.STSMINL, "STSMINL WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMINL_64_memop_1()
    {
        TestInst(LDSMINL(X0, X1, _[X3]), asm => asm.LDSMINL(X0, X1, _[X3]), Arm64InstructionId.LDSMINL_64_memop, Arm64Mnemonic.LDSMINL, "LDSMINL X0, X1, [X3]");
        TestInst(LDSMINL(X15, X1, _[X3]), asm => asm.LDSMINL(X15, X1, _[X3]), Arm64InstructionId.LDSMINL_64_memop, Arm64Mnemonic.LDSMINL, "LDSMINL X15, X1, [X3]");
        TestInst(LDSMINL(XZR, X1, _[X3]), asm => asm.LDSMINL(XZR, X1, _[X3]), Arm64InstructionId.LDSMINL_64_memop, Arm64Mnemonic.LDSMINL, "LDSMINL XZR, X1, [X3]");
        TestInst(LDSMINL(X0, X16, _[X3]), asm => asm.LDSMINL(X0, X16, _[X3]), Arm64InstructionId.LDSMINL_64_memop, Arm64Mnemonic.LDSMINL, "LDSMINL X0, X16, [X3]");
        TestInst(LDSMINL(X15, X16, _[X3]), asm => asm.LDSMINL(X15, X16, _[X3]), Arm64InstructionId.LDSMINL_64_memop, Arm64Mnemonic.LDSMINL, "LDSMINL X15, X16, [X3]");
        TestInst(LDSMINL(XZR, X16, _[X3]), asm => asm.LDSMINL(XZR, X16, _[X3]), Arm64InstructionId.LDSMINL_64_memop, Arm64Mnemonic.LDSMINL, "LDSMINL XZR, X16, [X3]");
        TestInst(LDSMINL(X0, XZR, _[X3]), asm => asm.LDSMINL(X0, XZR, _[X3]), Arm64InstructionId.STSMINL_ldsminl_64_memop, Arm64Mnemonic.STSMINL, "STSMINL X0, [X3]");
        TestInst(LDSMINL(X15, XZR, _[X3]), asm => asm.LDSMINL(X15, XZR, _[X3]), Arm64InstructionId.STSMINL_ldsminl_64_memop, Arm64Mnemonic.STSMINL, "STSMINL X15, [X3]");
        TestInst(LDSMINL(XZR, XZR, _[X3]), asm => asm.LDSMINL(XZR, XZR, _[X3]), Arm64InstructionId.STSMINL_ldsminl_64_memop, Arm64Mnemonic.STSMINL, "STSMINL XZR, [X3]");
    }
}
