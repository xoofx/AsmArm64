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
public class Arm64InstructionFactoryTests_RCWSET_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSET"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSET_64_memop_0()
    {
        TestInst(RCWSET(X0, X1, _[X3]), asm => asm.RCWSET(X0, X1, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET X0, X1, [X3]");
        TestInst(RCWSET(X15, X1, _[X3]), asm => asm.RCWSET(X15, X1, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET X15, X1, [X3]");
        TestInst(RCWSET(XZR, X1, _[X3]), asm => asm.RCWSET(XZR, X1, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET XZR, X1, [X3]");
        TestInst(RCWSET(X0, X16, _[X3]), asm => asm.RCWSET(X0, X16, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET X0, X16, [X3]");
        TestInst(RCWSET(X15, X16, _[X3]), asm => asm.RCWSET(X15, X16, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET X15, X16, [X3]");
        TestInst(RCWSET(XZR, X16, _[X3]), asm => asm.RCWSET(XZR, X16, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET XZR, X16, [X3]");
        TestInst(RCWSET(X0, XZR, _[X3]), asm => asm.RCWSET(X0, XZR, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET X0, XZR, [X3]");
        TestInst(RCWSET(X15, XZR, _[X3]), asm => asm.RCWSET(X15, XZR, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET X15, XZR, [X3]");
        TestInst(RCWSET(XZR, XZR, _[X3]), asm => asm.RCWSET(XZR, XZR, _[X3]), Arm64InstructionId.RCWSET_64_memop, Arm64Mnemonic.RCWSET, "RCWSET XZR, XZR, [X3]");
    }
}
