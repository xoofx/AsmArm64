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
public class Arm64InstructionFactoryTests_LDSETPL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSETPL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSETPL_128_memop_128_0()
    {
        TestInst(LDSETPL(X0, X1, _[X3]), asm => asm.LDSETPL(X0, X1, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL X0, X1, [X3]");
        TestInst(LDSETPL(X15, X1, _[X3]), asm => asm.LDSETPL(X15, X1, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL X15, X1, [X3]");
        TestInst(LDSETPL(XZR, X1, _[X3]), asm => asm.LDSETPL(XZR, X1, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL XZR, X1, [X3]");
        TestInst(LDSETPL(X0, X16, _[X3]), asm => asm.LDSETPL(X0, X16, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL X0, X16, [X3]");
        TestInst(LDSETPL(X15, X16, _[X3]), asm => asm.LDSETPL(X15, X16, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL X15, X16, [X3]");
        TestInst(LDSETPL(XZR, X16, _[X3]), asm => asm.LDSETPL(XZR, X16, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL XZR, X16, [X3]");
        TestInst(LDSETPL(X0, XZR, _[X3]), asm => asm.LDSETPL(X0, XZR, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL X0, XZR, [X3]");
        TestInst(LDSETPL(X15, XZR, _[X3]), asm => asm.LDSETPL(X15, XZR, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL X15, XZR, [X3]");
        TestInst(LDSETPL(XZR, XZR, _[X3]), asm => asm.LDSETPL(XZR, XZR, _[X3]), Arm64InstructionId.LDSETPL_128_memop_128, Arm64Mnemonic.LDSETPL, "LDSETPL XZR, XZR, [X3]");
    }
}
