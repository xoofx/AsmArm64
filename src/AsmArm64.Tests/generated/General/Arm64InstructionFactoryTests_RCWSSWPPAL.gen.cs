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
public class Arm64InstructionFactoryTests_RCWSSWPPAL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSSWPPAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSSWPPAL_128_memop_128_0()
    {
        TestInst(RCWSSWPPAL(X0, X1, _[X3]), asm => asm.RCWSSWPPAL(X0, X1, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL X0, X1, [X3]");
        TestInst(RCWSSWPPAL(X15, X1, _[X3]), asm => asm.RCWSSWPPAL(X15, X1, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL X15, X1, [X3]");
        TestInst(RCWSSWPPAL(XZR, X1, _[X3]), asm => asm.RCWSSWPPAL(XZR, X1, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL XZR, X1, [X3]");
        TestInst(RCWSSWPPAL(X0, X16, _[X3]), asm => asm.RCWSSWPPAL(X0, X16, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL X0, X16, [X3]");
        TestInst(RCWSSWPPAL(X15, X16, _[X3]), asm => asm.RCWSSWPPAL(X15, X16, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL X15, X16, [X3]");
        TestInst(RCWSSWPPAL(XZR, X16, _[X3]), asm => asm.RCWSSWPPAL(XZR, X16, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL XZR, X16, [X3]");
        TestInst(RCWSSWPPAL(X0, XZR, _[X3]), asm => asm.RCWSSWPPAL(X0, XZR, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL X0, XZR, [X3]");
        TestInst(RCWSSWPPAL(X15, XZR, _[X3]), asm => asm.RCWSSWPPAL(X15, XZR, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL X15, XZR, [X3]");
        TestInst(RCWSSWPPAL(XZR, XZR, _[X3]), asm => asm.RCWSSWPPAL(XZR, XZR, _[X3]), Arm64InstructionId.RCWSSWPPAL_128_memop_128, Arm64Mnemonic.RCWSSWPPAL, "RCWSSWPPAL XZR, XZR, [X3]");
    }
}
