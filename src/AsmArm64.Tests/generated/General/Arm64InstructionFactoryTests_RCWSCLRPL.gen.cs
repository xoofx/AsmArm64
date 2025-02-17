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
public class Arm64InstructionFactoryTests_RCWSCLRPL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSCLRPL"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSCLRPL_128_memop_128_0()
    {
        TestInst(RCWSCLRPL(X0, X1, _[X3]), asm => asm.RCWSCLRPL(X0, X1, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL X0, X1, [X3]");
        TestInst(RCWSCLRPL(X15, X1, _[X3]), asm => asm.RCWSCLRPL(X15, X1, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL X15, X1, [X3]");
        TestInst(RCWSCLRPL(XZR, X1, _[X3]), asm => asm.RCWSCLRPL(XZR, X1, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL XZR, X1, [X3]");
        TestInst(RCWSCLRPL(X0, X16, _[X3]), asm => asm.RCWSCLRPL(X0, X16, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL X0, X16, [X3]");
        TestInst(RCWSCLRPL(X15, X16, _[X3]), asm => asm.RCWSCLRPL(X15, X16, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL X15, X16, [X3]");
        TestInst(RCWSCLRPL(XZR, X16, _[X3]), asm => asm.RCWSCLRPL(XZR, X16, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL XZR, X16, [X3]");
        TestInst(RCWSCLRPL(X0, XZR, _[X3]), asm => asm.RCWSCLRPL(X0, XZR, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL X0, XZR, [X3]");
        TestInst(RCWSCLRPL(X15, XZR, _[X3]), asm => asm.RCWSCLRPL(X15, XZR, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL X15, XZR, [X3]");
        TestInst(RCWSCLRPL(XZR, XZR, _[X3]), asm => asm.RCWSCLRPL(XZR, XZR, _[X3]), Arm64InstructionId.RCWSCLRPL_128_memop_128, Arm64Mnemonic.RCWSCLRPL, "RCWSCLRPL XZR, XZR, [X3]");
    }
}
