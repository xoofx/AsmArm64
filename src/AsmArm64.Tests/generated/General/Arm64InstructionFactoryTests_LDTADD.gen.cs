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
public class Arm64InstructionFactoryTests_LDTADD_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTADD_32_memop_unpriv_0()
    {
        TestInst(LDTADD(W0, W1, _[X3]), asm => asm.LDTADD(W0, W1, _[X3]), Arm64InstructionId.LDTADD_32_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD W0, W1, [X3]");
        TestInst(LDTADD(W15, W1, _[X3]), asm => asm.LDTADD(W15, W1, _[X3]), Arm64InstructionId.LDTADD_32_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD W15, W1, [X3]");
        TestInst(LDTADD(WZR, W1, _[X3]), asm => asm.LDTADD(WZR, W1, _[X3]), Arm64InstructionId.LDTADD_32_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD WZR, W1, [X3]");
        TestInst(LDTADD(W0, W16, _[X3]), asm => asm.LDTADD(W0, W16, _[X3]), Arm64InstructionId.LDTADD_32_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD W0, W16, [X3]");
        TestInst(LDTADD(W15, W16, _[X3]), asm => asm.LDTADD(W15, W16, _[X3]), Arm64InstructionId.LDTADD_32_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD W15, W16, [X3]");
        TestInst(LDTADD(WZR, W16, _[X3]), asm => asm.LDTADD(WZR, W16, _[X3]), Arm64InstructionId.LDTADD_32_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD WZR, W16, [X3]");
        TestInst(LDTADD(W0, WZR, _[X3]), asm => asm.LDTADD(W0, WZR, _[X3]), Arm64InstructionId.STTADD_ldtadd_32_memop_unpriv, Arm64Mnemonic.STTADD, "STTADD W0, [X3]");
        TestInst(LDTADD(W15, WZR, _[X3]), asm => asm.LDTADD(W15, WZR, _[X3]), Arm64InstructionId.STTADD_ldtadd_32_memop_unpriv, Arm64Mnemonic.STTADD, "STTADD W15, [X3]");
        TestInst(LDTADD(WZR, WZR, _[X3]), asm => asm.LDTADD(WZR, WZR, _[X3]), Arm64InstructionId.STTADD_ldtadd_32_memop_unpriv, Arm64Mnemonic.STTADD, "STTADD WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTADD_64_memop_unpriv_1()
    {
        TestInst(LDTADD(X0, X1, _[X3]), asm => asm.LDTADD(X0, X1, _[X3]), Arm64InstructionId.LDTADD_64_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD X0, X1, [X3]");
        TestInst(LDTADD(X15, X1, _[X3]), asm => asm.LDTADD(X15, X1, _[X3]), Arm64InstructionId.LDTADD_64_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD X15, X1, [X3]");
        TestInst(LDTADD(XZR, X1, _[X3]), asm => asm.LDTADD(XZR, X1, _[X3]), Arm64InstructionId.LDTADD_64_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD XZR, X1, [X3]");
        TestInst(LDTADD(X0, X16, _[X3]), asm => asm.LDTADD(X0, X16, _[X3]), Arm64InstructionId.LDTADD_64_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD X0, X16, [X3]");
        TestInst(LDTADD(X15, X16, _[X3]), asm => asm.LDTADD(X15, X16, _[X3]), Arm64InstructionId.LDTADD_64_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD X15, X16, [X3]");
        TestInst(LDTADD(XZR, X16, _[X3]), asm => asm.LDTADD(XZR, X16, _[X3]), Arm64InstructionId.LDTADD_64_memop_unpriv, Arm64Mnemonic.LDTADD, "LDTADD XZR, X16, [X3]");
        TestInst(LDTADD(X0, XZR, _[X3]), asm => asm.LDTADD(X0, XZR, _[X3]), Arm64InstructionId.STTADD_ldtadd_64_memop_unpriv, Arm64Mnemonic.STTADD, "STTADD X0, [X3]");
        TestInst(LDTADD(X15, XZR, _[X3]), asm => asm.LDTADD(X15, XZR, _[X3]), Arm64InstructionId.STTADD_ldtadd_64_memop_unpriv, Arm64Mnemonic.STTADD, "STTADD X15, [X3]");
        TestInst(LDTADD(XZR, XZR, _[X3]), asm => asm.LDTADD(XZR, XZR, _[X3]), Arm64InstructionId.STTADD_ldtadd_64_memop_unpriv, Arm64Mnemonic.STTADD, "STTADD XZR, [X3]");
    }
}
