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
public class Arm64InstructionFactoryTests_LDCLRALH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDCLRALH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDCLRALH_32_memop_0()
    {
        TestInst(LDCLRALH(W0, W1, _[X3]), asm => asm.LDCLRALH(W0, W1, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH W0, W1, [X3]");
        TestInst(LDCLRALH(W15, W1, _[X3]), asm => asm.LDCLRALH(W15, W1, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH W15, W1, [X3]");
        TestInst(LDCLRALH(WZR, W1, _[X3]), asm => asm.LDCLRALH(WZR, W1, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH WZR, W1, [X3]");
        TestInst(LDCLRALH(W0, W16, _[X3]), asm => asm.LDCLRALH(W0, W16, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH W0, W16, [X3]");
        TestInst(LDCLRALH(W15, W16, _[X3]), asm => asm.LDCLRALH(W15, W16, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH W15, W16, [X3]");
        TestInst(LDCLRALH(WZR, W16, _[X3]), asm => asm.LDCLRALH(WZR, W16, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH WZR, W16, [X3]");
        TestInst(LDCLRALH(W0, WZR, _[X3]), asm => asm.LDCLRALH(W0, WZR, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH W0, WZR, [X3]");
        TestInst(LDCLRALH(W15, WZR, _[X3]), asm => asm.LDCLRALH(W15, WZR, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH W15, WZR, [X3]");
        TestInst(LDCLRALH(WZR, WZR, _[X3]), asm => asm.LDCLRALH(WZR, WZR, _[X3]), Arm64InstructionId.LDCLRALH_32_memop, Arm64Mnemonic.LDCLRALH, "LDCLRALH WZR, WZR, [X3]");
    }
}
