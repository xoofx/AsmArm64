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
public class Arm64InstructionFactoryTests_LDUMIN_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMIN_32_memop_0()
    {
        TestInst(LDUMIN(W0, W1, _[X3]), asm => asm.LDUMIN(W0, W1, _[X3]), Arm64InstructionId.LDUMIN_32_memop, Arm64Mnemonic.LDUMIN, "LDUMIN W0, W1, [X3]");
        TestInst(LDUMIN(W15, W1, _[X3]), asm => asm.LDUMIN(W15, W1, _[X3]), Arm64InstructionId.LDUMIN_32_memop, Arm64Mnemonic.LDUMIN, "LDUMIN W15, W1, [X3]");
        TestInst(LDUMIN(WZR, W1, _[X3]), asm => asm.LDUMIN(WZR, W1, _[X3]), Arm64InstructionId.LDUMIN_32_memop, Arm64Mnemonic.LDUMIN, "LDUMIN WZR, W1, [X3]");
        TestInst(LDUMIN(W0, W16, _[X3]), asm => asm.LDUMIN(W0, W16, _[X3]), Arm64InstructionId.LDUMIN_32_memop, Arm64Mnemonic.LDUMIN, "LDUMIN W0, W16, [X3]");
        TestInst(LDUMIN(W15, W16, _[X3]), asm => asm.LDUMIN(W15, W16, _[X3]), Arm64InstructionId.LDUMIN_32_memop, Arm64Mnemonic.LDUMIN, "LDUMIN W15, W16, [X3]");
        TestInst(LDUMIN(WZR, W16, _[X3]), asm => asm.LDUMIN(WZR, W16, _[X3]), Arm64InstructionId.LDUMIN_32_memop, Arm64Mnemonic.LDUMIN, "LDUMIN WZR, W16, [X3]");
        TestInst(LDUMIN(W0, WZR, _[X3]), asm => asm.LDUMIN(W0, WZR, _[X3]), Arm64InstructionId.STUMIN_ldumin_32_memop, Arm64Mnemonic.STUMIN, "STUMIN W0, [X3]");
        TestInst(LDUMIN(W15, WZR, _[X3]), asm => asm.LDUMIN(W15, WZR, _[X3]), Arm64InstructionId.STUMIN_ldumin_32_memop, Arm64Mnemonic.STUMIN, "STUMIN W15, [X3]");
        TestInst(LDUMIN(WZR, WZR, _[X3]), asm => asm.LDUMIN(WZR, WZR, _[X3]), Arm64InstructionId.STUMIN_ldumin_32_memop, Arm64Mnemonic.STUMIN, "STUMIN WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMIN_64_memop_1()
    {
        TestInst(LDUMIN(X0, X1, _[X3]), asm => asm.LDUMIN(X0, X1, _[X3]), Arm64InstructionId.LDUMIN_64_memop, Arm64Mnemonic.LDUMIN, "LDUMIN X0, X1, [X3]");
        TestInst(LDUMIN(X15, X1, _[X3]), asm => asm.LDUMIN(X15, X1, _[X3]), Arm64InstructionId.LDUMIN_64_memop, Arm64Mnemonic.LDUMIN, "LDUMIN X15, X1, [X3]");
        TestInst(LDUMIN(XZR, X1, _[X3]), asm => asm.LDUMIN(XZR, X1, _[X3]), Arm64InstructionId.LDUMIN_64_memop, Arm64Mnemonic.LDUMIN, "LDUMIN XZR, X1, [X3]");
        TestInst(LDUMIN(X0, X16, _[X3]), asm => asm.LDUMIN(X0, X16, _[X3]), Arm64InstructionId.LDUMIN_64_memop, Arm64Mnemonic.LDUMIN, "LDUMIN X0, X16, [X3]");
        TestInst(LDUMIN(X15, X16, _[X3]), asm => asm.LDUMIN(X15, X16, _[X3]), Arm64InstructionId.LDUMIN_64_memop, Arm64Mnemonic.LDUMIN, "LDUMIN X15, X16, [X3]");
        TestInst(LDUMIN(XZR, X16, _[X3]), asm => asm.LDUMIN(XZR, X16, _[X3]), Arm64InstructionId.LDUMIN_64_memop, Arm64Mnemonic.LDUMIN, "LDUMIN XZR, X16, [X3]");
        TestInst(LDUMIN(X0, XZR, _[X3]), asm => asm.LDUMIN(X0, XZR, _[X3]), Arm64InstructionId.STUMIN_ldumin_64_memop, Arm64Mnemonic.STUMIN, "STUMIN X0, [X3]");
        TestInst(LDUMIN(X15, XZR, _[X3]), asm => asm.LDUMIN(X15, XZR, _[X3]), Arm64InstructionId.STUMIN_ldumin_64_memop, Arm64Mnemonic.STUMIN, "STUMIN X15, [X3]");
        TestInst(LDUMIN(XZR, XZR, _[X3]), asm => asm.LDUMIN(XZR, XZR, _[X3]), Arm64InstructionId.STUMIN_ldumin_64_memop, Arm64Mnemonic.STUMIN, "STUMIN XZR, [X3]");
    }
}
