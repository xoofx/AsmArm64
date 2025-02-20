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
public class Arm64InstructionFactoryTests_LDADDLH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDLH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDLH_32_memop_0()
    {
        TestInst(LDADDLH(W0, W1, _[X3]), asm => asm.LDADDLH(W0, W1, _[X3]), Arm64InstructionId.LDADDLH_32_memop, Arm64Mnemonic.LDADDLH, "LDADDLH W0, W1, [X3]");
        TestInst(LDADDLH(W15, W1, _[X3]), asm => asm.LDADDLH(W15, W1, _[X3]), Arm64InstructionId.LDADDLH_32_memop, Arm64Mnemonic.LDADDLH, "LDADDLH W15, W1, [X3]");
        TestInst(LDADDLH(WZR, W1, _[X3]), asm => asm.LDADDLH(WZR, W1, _[X3]), Arm64InstructionId.LDADDLH_32_memop, Arm64Mnemonic.LDADDLH, "LDADDLH WZR, W1, [X3]");
        TestInst(LDADDLH(W0, W16, _[X3]), asm => asm.LDADDLH(W0, W16, _[X3]), Arm64InstructionId.LDADDLH_32_memop, Arm64Mnemonic.LDADDLH, "LDADDLH W0, W16, [X3]");
        TestInst(LDADDLH(W15, W16, _[X3]), asm => asm.LDADDLH(W15, W16, _[X3]), Arm64InstructionId.LDADDLH_32_memop, Arm64Mnemonic.LDADDLH, "LDADDLH W15, W16, [X3]");
        TestInst(LDADDLH(WZR, W16, _[X3]), asm => asm.LDADDLH(WZR, W16, _[X3]), Arm64InstructionId.LDADDLH_32_memop, Arm64Mnemonic.LDADDLH, "LDADDLH WZR, W16, [X3]");
        TestInst(LDADDLH(W0, WZR, _[X3]), asm => asm.LDADDLH(W0, WZR, _[X3]), Arm64InstructionId.STADDLH_ldaddlh_32_memop, Arm64Mnemonic.STADDLH, "STADDLH W0, [X3]");
        TestInst(LDADDLH(W15, WZR, _[X3]), asm => asm.LDADDLH(W15, WZR, _[X3]), Arm64InstructionId.STADDLH_ldaddlh_32_memop, Arm64Mnemonic.STADDLH, "STADDLH W15, [X3]");
        TestInst(LDADDLH(WZR, WZR, _[X3]), asm => asm.LDADDLH(WZR, WZR, _[X3]), Arm64InstructionId.STADDLH_ldaddlh_32_memop, Arm64Mnemonic.STADDLH, "STADDLH WZR, [X3]");
    }
}
