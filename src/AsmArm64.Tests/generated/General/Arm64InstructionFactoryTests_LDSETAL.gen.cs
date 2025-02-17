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
public class Arm64InstructionFactoryTests_LDSETAL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSETAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSETAL_32_memop_0()
    {
        TestInst(LDSETAL(W0, W1, _[X3]), asm => asm.LDSETAL(W0, W1, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL W0, W1, [X3]");
        TestInst(LDSETAL(W15, W1, _[X3]), asm => asm.LDSETAL(W15, W1, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL W15, W1, [X3]");
        TestInst(LDSETAL(WZR, W1, _[X3]), asm => asm.LDSETAL(WZR, W1, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL WZR, W1, [X3]");
        TestInst(LDSETAL(W0, W16, _[X3]), asm => asm.LDSETAL(W0, W16, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL W0, W16, [X3]");
        TestInst(LDSETAL(W15, W16, _[X3]), asm => asm.LDSETAL(W15, W16, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL W15, W16, [X3]");
        TestInst(LDSETAL(WZR, W16, _[X3]), asm => asm.LDSETAL(WZR, W16, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL WZR, W16, [X3]");
        TestInst(LDSETAL(W0, WZR, _[X3]), asm => asm.LDSETAL(W0, WZR, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL W0, WZR, [X3]");
        TestInst(LDSETAL(W15, WZR, _[X3]), asm => asm.LDSETAL(W15, WZR, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL W15, WZR, [X3]");
        TestInst(LDSETAL(WZR, WZR, _[X3]), asm => asm.LDSETAL(WZR, WZR, _[X3]), Arm64InstructionId.LDSETAL_32_memop, Arm64Mnemonic.LDSETAL, "LDSETAL WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSETAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSETAL_64_memop_1()
    {
        TestInst(LDSETAL(X0, X1, _[X3]), asm => asm.LDSETAL(X0, X1, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL X0, X1, [X3]");
        TestInst(LDSETAL(X15, X1, _[X3]), asm => asm.LDSETAL(X15, X1, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL X15, X1, [X3]");
        TestInst(LDSETAL(XZR, X1, _[X3]), asm => asm.LDSETAL(XZR, X1, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL XZR, X1, [X3]");
        TestInst(LDSETAL(X0, X16, _[X3]), asm => asm.LDSETAL(X0, X16, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL X0, X16, [X3]");
        TestInst(LDSETAL(X15, X16, _[X3]), asm => asm.LDSETAL(X15, X16, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL X15, X16, [X3]");
        TestInst(LDSETAL(XZR, X16, _[X3]), asm => asm.LDSETAL(XZR, X16, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL XZR, X16, [X3]");
        TestInst(LDSETAL(X0, XZR, _[X3]), asm => asm.LDSETAL(X0, XZR, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL X0, XZR, [X3]");
        TestInst(LDSETAL(X15, XZR, _[X3]), asm => asm.LDSETAL(X15, XZR, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL X15, XZR, [X3]");
        TestInst(LDSETAL(XZR, XZR, _[X3]), asm => asm.LDSETAL(XZR, XZR, _[X3]), Arm64InstructionId.LDSETAL_64_memop, Arm64Mnemonic.LDSETAL, "LDSETAL XZR, XZR, [X3]");
    }
}
