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
public class Arm64InstructionFactoryTests_SWPTAL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTAL_32_memop_unpriv_0()
    {
        TestInst(SWPTAL(W0, W1, _[X3]), asm => asm.SWPTAL(W0, W1, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL W0, W1, [X3]");
        TestInst(SWPTAL(W15, W1, _[X3]), asm => asm.SWPTAL(W15, W1, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL W15, W1, [X3]");
        TestInst(SWPTAL(WZR, W1, _[X3]), asm => asm.SWPTAL(WZR, W1, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL WZR, W1, [X3]");
        TestInst(SWPTAL(W0, W16, _[X3]), asm => asm.SWPTAL(W0, W16, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL W0, W16, [X3]");
        TestInst(SWPTAL(W15, W16, _[X3]), asm => asm.SWPTAL(W15, W16, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL W15, W16, [X3]");
        TestInst(SWPTAL(WZR, W16, _[X3]), asm => asm.SWPTAL(WZR, W16, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL WZR, W16, [X3]");
        TestInst(SWPTAL(W0, WZR, _[X3]), asm => asm.SWPTAL(W0, WZR, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL W0, WZR, [X3]");
        TestInst(SWPTAL(W15, WZR, _[X3]), asm => asm.SWPTAL(W15, WZR, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL W15, WZR, [X3]");
        TestInst(SWPTAL(WZR, WZR, _[X3]), asm => asm.SWPTAL(WZR, WZR, _[X3]), Arm64InstructionId.SWPTAL_32_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTAL_64_memop_unpriv_1()
    {
        TestInst(SWPTAL(X0, X1, _[X3]), asm => asm.SWPTAL(X0, X1, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL X0, X1, [X3]");
        TestInst(SWPTAL(X15, X1, _[X3]), asm => asm.SWPTAL(X15, X1, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL X15, X1, [X3]");
        TestInst(SWPTAL(XZR, X1, _[X3]), asm => asm.SWPTAL(XZR, X1, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL XZR, X1, [X3]");
        TestInst(SWPTAL(X0, X16, _[X3]), asm => asm.SWPTAL(X0, X16, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL X0, X16, [X3]");
        TestInst(SWPTAL(X15, X16, _[X3]), asm => asm.SWPTAL(X15, X16, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL X15, X16, [X3]");
        TestInst(SWPTAL(XZR, X16, _[X3]), asm => asm.SWPTAL(XZR, X16, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL XZR, X16, [X3]");
        TestInst(SWPTAL(X0, XZR, _[X3]), asm => asm.SWPTAL(X0, XZR, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL X0, XZR, [X3]");
        TestInst(SWPTAL(X15, XZR, _[X3]), asm => asm.SWPTAL(X15, XZR, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL X15, XZR, [X3]");
        TestInst(SWPTAL(XZR, XZR, _[X3]), asm => asm.SWPTAL(XZR, XZR, _[X3]), Arm64InstructionId.SWPTAL_64_memop_unpriv, Arm64Mnemonic.SWPTAL, "SWPTAL XZR, XZR, [X3]");
    }
}
