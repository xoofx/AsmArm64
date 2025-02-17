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
public class Arm64InstructionFactoryTests_STADD_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_STADD_ldadd_32_memop_0()
    {
        TestInst(STADD(W0, _[X2]), asm => asm.STADD(W0, _[X2]), Arm64InstructionId.STADD_ldadd_32_memop, Arm64Mnemonic.STADD, "STADD W0, [X2]");
        TestInst(STADD(W15, _[X2]), asm => asm.STADD(W15, _[X2]), Arm64InstructionId.STADD_ldadd_32_memop, Arm64Mnemonic.STADD, "STADD W15, [X2]");
        TestInst(STADD(WZR, _[X2]), asm => asm.STADD(WZR, _[X2]), Arm64InstructionId.STADD_ldadd_32_memop, Arm64Mnemonic.STADD, "STADD WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_STADD_ldadd_64_memop_1()
    {
        TestInst(STADD(X0, _[X2]), asm => asm.STADD(X0, _[X2]), Arm64InstructionId.STADD_ldadd_64_memop, Arm64Mnemonic.STADD, "STADD X0, [X2]");
        TestInst(STADD(X15, _[X2]), asm => asm.STADD(X15, _[X2]), Arm64InstructionId.STADD_ldadd_64_memop, Arm64Mnemonic.STADD, "STADD X15, [X2]");
        TestInst(STADD(XZR, _[X2]), asm => asm.STADD(XZR, _[X2]), Arm64InstructionId.STADD_ldadd_64_memop, Arm64Mnemonic.STADD, "STADD XZR, [X2]");
    }
}
