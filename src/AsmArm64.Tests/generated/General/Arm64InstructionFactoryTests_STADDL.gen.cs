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
public class Arm64InstructionFactoryTests_STADDL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STADDL_ldaddl_32_memop_0()
    {
        TestInst(STADDL(W0, _[X2]), asm => asm.STADDL(W0, _[X2]), Arm64InstructionId.STADDL_ldaddl_32_memop, Arm64Mnemonic.STADDL, "STADDL W0, [X2]");
        TestInst(STADDL(W15, _[X2]), asm => asm.STADDL(W15, _[X2]), Arm64InstructionId.STADDL_ldaddl_32_memop, Arm64Mnemonic.STADDL, "STADDL W15, [X2]");
        TestInst(STADDL(WZR, _[X2]), asm => asm.STADDL(WZR, _[X2]), Arm64InstructionId.STADDL_ldaddl_32_memop, Arm64Mnemonic.STADDL, "STADDL WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STADDL_ldaddl_64_memop_1()
    {
        TestInst(STADDL(X0, _[X2]), asm => asm.STADDL(X0, _[X2]), Arm64InstructionId.STADDL_ldaddl_64_memop, Arm64Mnemonic.STADDL, "STADDL X0, [X2]");
        TestInst(STADDL(X15, _[X2]), asm => asm.STADDL(X15, _[X2]), Arm64InstructionId.STADDL_ldaddl_64_memop, Arm64Mnemonic.STADDL, "STADDL X15, [X2]");
        TestInst(STADDL(XZR, _[X2]), asm => asm.STADDL(XZR, _[X2]), Arm64InstructionId.STADDL_ldaddl_64_memop, Arm64Mnemonic.STADDL, "STADDL XZR, [X2]");
    }
}
