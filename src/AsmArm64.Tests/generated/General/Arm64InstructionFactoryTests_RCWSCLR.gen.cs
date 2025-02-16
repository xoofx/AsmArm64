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
public class Arm64InstructionFactoryTests_RCWSCLR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSCLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSCLR_64_memop_0()
    {
        TestInst(RCWSCLR(X0, X1, _[X3]), asm => asm.RCWSCLR(X0, X1, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR X0, X1, [X3]");
        TestInst(RCWSCLR(X15, X1, _[X3]), asm => asm.RCWSCLR(X15, X1, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR X15, X1, [X3]");
        TestInst(RCWSCLR(XZR, X1, _[X3]), asm => asm.RCWSCLR(XZR, X1, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR XZR, X1, [X3]");
        TestInst(RCWSCLR(X0, X16, _[X3]), asm => asm.RCWSCLR(X0, X16, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR X0, X16, [X3]");
        TestInst(RCWSCLR(X15, X16, _[X3]), asm => asm.RCWSCLR(X15, X16, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR X15, X16, [X3]");
        TestInst(RCWSCLR(XZR, X16, _[X3]), asm => asm.RCWSCLR(XZR, X16, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR XZR, X16, [X3]");
        TestInst(RCWSCLR(X0, XZR, _[X3]), asm => asm.RCWSCLR(X0, XZR, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR X0, XZR, [X3]");
        TestInst(RCWSCLR(X15, XZR, _[X3]), asm => asm.RCWSCLR(X15, XZR, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR X15, XZR, [X3]");
        TestInst(RCWSCLR(XZR, XZR, _[X3]), asm => asm.RCWSCLR(XZR, XZR, _[X3]), Arm64InstructionId.RCWSCLR_64_memop, Arm64Mnemonic.RCWSCLR, "RCWSCLR XZR, XZR, [X3]");
    }
}
