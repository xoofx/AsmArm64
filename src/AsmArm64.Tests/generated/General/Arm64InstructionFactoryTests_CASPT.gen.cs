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
public class Arm64InstructionFactoryTests_CASPT_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CASPT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CASPT_cp64_comswappr_unpriv_0()
    {
        TestInst(CASPT(X0, X1, X2, X3, _[X5]), asm => asm.CASPT(X0, X1, X2, X3, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT X0, X1, X2, X3, [X5]");
        TestInst(CASPT(X15, X16, X2, X3, _[X5]), asm => asm.CASPT(X15, X16, X2, X3, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT X15, X16, X2, X3, [X5]");
        TestInst(CASPT(XZR, X0, X2, X3, _[X5]), asm => asm.CASPT(XZR, X0, X2, X3, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT XZR, X0, X2, X3, [X5]");
        TestInst(CASPT(X0, X1, X17, X18, _[X5]), asm => asm.CASPT(X0, X1, X17, X18, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT X0, X1, X17, X18, [X5]");
        TestInst(CASPT(X15, X16, X17, X18, _[X5]), asm => asm.CASPT(X15, X16, X17, X18, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT X15, X16, X17, X18, [X5]");
        TestInst(CASPT(XZR, X0, X17, X18, _[X5]), asm => asm.CASPT(XZR, X0, X17, X18, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT XZR, X0, X17, X18, [X5]");
        TestInst(CASPT(X0, X1, XZR, X0, _[X5]), asm => asm.CASPT(X0, X1, XZR, X0, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT X0, X1, XZR, X0, [X5]");
        TestInst(CASPT(X15, X16, XZR, X0, _[X5]), asm => asm.CASPT(X15, X16, XZR, X0, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT X15, X16, XZR, X0, [X5]");
        TestInst(CASPT(XZR, X0, XZR, X0, _[X5]), asm => asm.CASPT(XZR, X0, XZR, X0, _[X5]), Arm64InstructionId.CASPT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPT, "CASPT XZR, X0, XZR, X0, [X5]");
    }
}
