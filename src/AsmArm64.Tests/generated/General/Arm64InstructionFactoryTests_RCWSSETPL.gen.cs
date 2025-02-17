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
public class Arm64InstructionFactoryTests_RCWSSETPL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSSETPL"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSSETPL_128_memop_128_0()
    {
        TestInst(RCWSSETPL(X0, X1, _[X3]), asm => asm.RCWSSETPL(X0, X1, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL X0, X1, [X3]");
        TestInst(RCWSSETPL(X15, X1, _[X3]), asm => asm.RCWSSETPL(X15, X1, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL X15, X1, [X3]");
        TestInst(RCWSSETPL(XZR, X1, _[X3]), asm => asm.RCWSSETPL(XZR, X1, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL XZR, X1, [X3]");
        TestInst(RCWSSETPL(X0, X16, _[X3]), asm => asm.RCWSSETPL(X0, X16, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL X0, X16, [X3]");
        TestInst(RCWSSETPL(X15, X16, _[X3]), asm => asm.RCWSSETPL(X15, X16, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL X15, X16, [X3]");
        TestInst(RCWSSETPL(XZR, X16, _[X3]), asm => asm.RCWSSETPL(XZR, X16, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL XZR, X16, [X3]");
        TestInst(RCWSSETPL(X0, XZR, _[X3]), asm => asm.RCWSSETPL(X0, XZR, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL X0, XZR, [X3]");
        TestInst(RCWSSETPL(X15, XZR, _[X3]), asm => asm.RCWSSETPL(X15, XZR, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL X15, XZR, [X3]");
        TestInst(RCWSSETPL(XZR, XZR, _[X3]), asm => asm.RCWSSETPL(XZR, XZR, _[X3]), Arm64InstructionId.RCWSSETPL_128_memop_128, Arm64Mnemonic.RCWSSETPL, "RCWSSETPL XZR, XZR, [X3]");
    }
}
