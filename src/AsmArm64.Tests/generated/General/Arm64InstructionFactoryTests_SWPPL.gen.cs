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
public class Arm64InstructionFactoryTests_SWPPL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPPL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPPL_128_memop_128_0()
    {
        TestInst(SWPPL(X0, X1, _[X3]), asm => asm.SWPPL(X0, X1, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL X0, X1, [X3]");
        TestInst(SWPPL(X15, X1, _[X3]), asm => asm.SWPPL(X15, X1, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL X15, X1, [X3]");
        TestInst(SWPPL(XZR, X1, _[X3]), asm => asm.SWPPL(XZR, X1, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL XZR, X1, [X3]");
        TestInst(SWPPL(X0, X16, _[X3]), asm => asm.SWPPL(X0, X16, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL X0, X16, [X3]");
        TestInst(SWPPL(X15, X16, _[X3]), asm => asm.SWPPL(X15, X16, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL X15, X16, [X3]");
        TestInst(SWPPL(XZR, X16, _[X3]), asm => asm.SWPPL(XZR, X16, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL XZR, X16, [X3]");
        TestInst(SWPPL(X0, XZR, _[X3]), asm => asm.SWPPL(X0, XZR, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL X0, XZR, [X3]");
        TestInst(SWPPL(X15, XZR, _[X3]), asm => asm.SWPPL(X15, XZR, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL X15, XZR, [X3]");
        TestInst(SWPPL(XZR, XZR, _[X3]), asm => asm.SWPPL(XZR, XZR, _[X3]), Arm64InstructionId.SWPPL_128_memop_128, Arm64Mnemonic.SWPPL, "SWPPL XZR, XZR, [X3]");
    }
}
