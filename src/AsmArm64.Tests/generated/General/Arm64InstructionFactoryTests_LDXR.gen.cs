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
public class Arm64InstructionFactoryTests_LDXR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDXR_lr32_ldstexclr_0()
    {
        TestInst(LDXR(W0, _[X2]), asm => asm.LDXR(W0, _[X2]), Arm64InstructionId.LDXR_lr32_ldstexclr, Arm64Mnemonic.LDXR, "LDXR W0, [X2]");
        TestInst(LDXR(W15, _[X2]), asm => asm.LDXR(W15, _[X2]), Arm64InstructionId.LDXR_lr32_ldstexclr, Arm64Mnemonic.LDXR, "LDXR W15, [X2]");
        TestInst(LDXR(WZR, _[X2]), asm => asm.LDXR(WZR, _[X2]), Arm64InstructionId.LDXR_lr32_ldstexclr, Arm64Mnemonic.LDXR, "LDXR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDXR_lr64_ldstexclr_1()
    {
        TestInst(LDXR(X0, _[X2]), asm => asm.LDXR(X0, _[X2]), Arm64InstructionId.LDXR_lr64_ldstexclr, Arm64Mnemonic.LDXR, "LDXR X0, [X2]");
        TestInst(LDXR(X15, _[X2]), asm => asm.LDXR(X15, _[X2]), Arm64InstructionId.LDXR_lr64_ldstexclr, Arm64Mnemonic.LDXR, "LDXR X15, [X2]");
        TestInst(LDXR(XZR, _[X2]), asm => asm.LDXR(XZR, _[X2]), Arm64InstructionId.LDXR_lr64_ldstexclr, Arm64Mnemonic.LDXR, "LDXR XZR, [X2]");
    }
}
