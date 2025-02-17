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
public class Arm64InstructionFactoryTests_LDTCLRL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTCLRL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTCLRL_32_memop_unpriv_0()
    {
        TestInst(LDTCLRL(W0, W1, _[X3]), asm => asm.LDTCLRL(W0, W1, _[X3]), Arm64InstructionId.LDTCLRL_32_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL W0, W1, [X3]");
        TestInst(LDTCLRL(W15, W1, _[X3]), asm => asm.LDTCLRL(W15, W1, _[X3]), Arm64InstructionId.LDTCLRL_32_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL W15, W1, [X3]");
        TestInst(LDTCLRL(WZR, W1, _[X3]), asm => asm.LDTCLRL(WZR, W1, _[X3]), Arm64InstructionId.LDTCLRL_32_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL WZR, W1, [X3]");
        TestInst(LDTCLRL(W0, W16, _[X3]), asm => asm.LDTCLRL(W0, W16, _[X3]), Arm64InstructionId.LDTCLRL_32_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL W0, W16, [X3]");
        TestInst(LDTCLRL(W15, W16, _[X3]), asm => asm.LDTCLRL(W15, W16, _[X3]), Arm64InstructionId.LDTCLRL_32_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL W15, W16, [X3]");
        TestInst(LDTCLRL(WZR, W16, _[X3]), asm => asm.LDTCLRL(WZR, W16, _[X3]), Arm64InstructionId.LDTCLRL_32_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL WZR, W16, [X3]");
        TestInst(LDTCLRL(W0, WZR, _[X3]), asm => asm.LDTCLRL(W0, WZR, _[X3]), Arm64InstructionId.STTCLRL_ldtclrl_32_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL W0, [X3]");
        TestInst(LDTCLRL(W15, WZR, _[X3]), asm => asm.LDTCLRL(W15, WZR, _[X3]), Arm64InstructionId.STTCLRL_ldtclrl_32_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL W15, [X3]");
        TestInst(LDTCLRL(WZR, WZR, _[X3]), asm => asm.LDTCLRL(WZR, WZR, _[X3]), Arm64InstructionId.STTCLRL_ldtclrl_32_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTCLRL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTCLRL_64_memop_unpriv_1()
    {
        TestInst(LDTCLRL(X0, X1, _[X3]), asm => asm.LDTCLRL(X0, X1, _[X3]), Arm64InstructionId.LDTCLRL_64_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL X0, X1, [X3]");
        TestInst(LDTCLRL(X15, X1, _[X3]), asm => asm.LDTCLRL(X15, X1, _[X3]), Arm64InstructionId.LDTCLRL_64_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL X15, X1, [X3]");
        TestInst(LDTCLRL(XZR, X1, _[X3]), asm => asm.LDTCLRL(XZR, X1, _[X3]), Arm64InstructionId.LDTCLRL_64_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL XZR, X1, [X3]");
        TestInst(LDTCLRL(X0, X16, _[X3]), asm => asm.LDTCLRL(X0, X16, _[X3]), Arm64InstructionId.LDTCLRL_64_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL X0, X16, [X3]");
        TestInst(LDTCLRL(X15, X16, _[X3]), asm => asm.LDTCLRL(X15, X16, _[X3]), Arm64InstructionId.LDTCLRL_64_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL X15, X16, [X3]");
        TestInst(LDTCLRL(XZR, X16, _[X3]), asm => asm.LDTCLRL(XZR, X16, _[X3]), Arm64InstructionId.LDTCLRL_64_memop_unpriv, Arm64Mnemonic.LDTCLRL, "LDTCLRL XZR, X16, [X3]");
        TestInst(LDTCLRL(X0, XZR, _[X3]), asm => asm.LDTCLRL(X0, XZR, _[X3]), Arm64InstructionId.STTCLRL_ldtclrl_64_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL X0, [X3]");
        TestInst(LDTCLRL(X15, XZR, _[X3]), asm => asm.LDTCLRL(X15, XZR, _[X3]), Arm64InstructionId.STTCLRL_ldtclrl_64_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL X15, [X3]");
        TestInst(LDTCLRL(XZR, XZR, _[X3]), asm => asm.LDTCLRL(XZR, XZR, _[X3]), Arm64InstructionId.STTCLRL_ldtclrl_64_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL XZR, [X3]");
    }
}
