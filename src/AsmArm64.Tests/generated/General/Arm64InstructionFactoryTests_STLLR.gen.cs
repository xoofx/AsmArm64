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
public class Arm64InstructionFactoryTests_STLLR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLLR_sl32_ldstord_0()
    {
        TestInst(STLLR(W0, _[X2]), asm => asm.STLLR(W0, _[X2]), Arm64InstructionId.STLLR_sl32_ldstord, Arm64Mnemonic.STLLR, "STLLR W0, [X2]");
        TestInst(STLLR(W15, _[X2]), asm => asm.STLLR(W15, _[X2]), Arm64InstructionId.STLLR_sl32_ldstord, Arm64Mnemonic.STLLR, "STLLR W15, [X2]");
        TestInst(STLLR(WZR, _[X2]), asm => asm.STLLR(WZR, _[X2]), Arm64InstructionId.STLLR_sl32_ldstord, Arm64Mnemonic.STLLR, "STLLR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLLR_sl64_ldstord_1()
    {
        TestInst(STLLR(X0, _[X2]), asm => asm.STLLR(X0, _[X2]), Arm64InstructionId.STLLR_sl64_ldstord, Arm64Mnemonic.STLLR, "STLLR X0, [X2]");
        TestInst(STLLR(X15, _[X2]), asm => asm.STLLR(X15, _[X2]), Arm64InstructionId.STLLR_sl64_ldstord, Arm64Mnemonic.STLLR, "STLLR X15, [X2]");
        TestInst(STLLR(XZR, _[X2]), asm => asm.STLLR(XZR, _[X2]), Arm64InstructionId.STLLR_sl64_ldstord, Arm64Mnemonic.STLLR, "STLLR XZR, [X2]");
    }
}
