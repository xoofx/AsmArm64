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
public class Arm64InstructionFactoryTests_STLTXR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLTXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLTXR_sr32_ldstexclr_unpriv_0()
    {
        TestInst(STLTXR(W0, W1, _[X3]), asm => asm.STLTXR(W0, W1, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W0, W1, [X3]");
        TestInst(STLTXR(W15, W1, _[X3]), asm => asm.STLTXR(W15, W1, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W15, W1, [X3]");
        TestInst(STLTXR(WZR, W1, _[X3]), asm => asm.STLTXR(WZR, W1, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR WZR, W1, [X3]");
        TestInst(STLTXR(W0, W16, _[X3]), asm => asm.STLTXR(W0, W16, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W0, W16, [X3]");
        TestInst(STLTXR(W15, W16, _[X3]), asm => asm.STLTXR(W15, W16, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W15, W16, [X3]");
        TestInst(STLTXR(WZR, W16, _[X3]), asm => asm.STLTXR(WZR, W16, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR WZR, W16, [X3]");
        TestInst(STLTXR(W0, WZR, _[X3]), asm => asm.STLTXR(W0, WZR, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W0, WZR, [X3]");
        TestInst(STLTXR(W15, WZR, _[X3]), asm => asm.STLTXR(W15, WZR, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W15, WZR, [X3]");
        TestInst(STLTXR(WZR, WZR, _[X3]), asm => asm.STLTXR(WZR, WZR, _[X3]), Arm64InstructionId.STLTXR_sr32_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLTXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLTXR_sr64_ldstexclr_unpriv_1()
    {
        TestInst(STLTXR(W0, X1, _[X3]), asm => asm.STLTXR(W0, X1, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W0, X1, [X3]");
        TestInst(STLTXR(W15, X1, _[X3]), asm => asm.STLTXR(W15, X1, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W15, X1, [X3]");
        TestInst(STLTXR(WZR, X1, _[X3]), asm => asm.STLTXR(WZR, X1, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR WZR, X1, [X3]");
        TestInst(STLTXR(W0, X16, _[X3]), asm => asm.STLTXR(W0, X16, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W0, X16, [X3]");
        TestInst(STLTXR(W15, X16, _[X3]), asm => asm.STLTXR(W15, X16, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W15, X16, [X3]");
        TestInst(STLTXR(WZR, X16, _[X3]), asm => asm.STLTXR(WZR, X16, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR WZR, X16, [X3]");
        TestInst(STLTXR(W0, XZR, _[X3]), asm => asm.STLTXR(W0, XZR, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W0, XZR, [X3]");
        TestInst(STLTXR(W15, XZR, _[X3]), asm => asm.STLTXR(W15, XZR, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR W15, XZR, [X3]");
        TestInst(STLTXR(WZR, XZR, _[X3]), asm => asm.STLTXR(WZR, XZR, _[X3]), Arm64InstructionId.STLTXR_sr64_ldstexclr_unpriv, Arm64Mnemonic.STLTXR, "STLTXR WZR, XZR, [X3]");
    }
}
