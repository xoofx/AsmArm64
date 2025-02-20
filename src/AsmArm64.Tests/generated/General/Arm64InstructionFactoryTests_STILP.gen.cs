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
public class Arm64InstructionFactoryTests_STILP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STILP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STILP_32se_ldiappstilp_0()
    {
        TestInst(STILP(W0, W1, _[X3, -8].Pre), asm => asm.STILP(W0, W1, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP W0, W1, [X3, #-8]!");
        TestInst(STILP(W15, W1, _[X3, -8].Pre), asm => asm.STILP(W15, W1, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP W15, W1, [X3, #-8]!");
        TestInst(STILP(WZR, W1, _[X3, -8].Pre), asm => asm.STILP(WZR, W1, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP WZR, W1, [X3, #-8]!");
        TestInst(STILP(W0, W16, _[X3, -8].Pre), asm => asm.STILP(W0, W16, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP W0, W16, [X3, #-8]!");
        TestInst(STILP(W15, W16, _[X3, -8].Pre), asm => asm.STILP(W15, W16, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP W15, W16, [X3, #-8]!");
        TestInst(STILP(WZR, W16, _[X3, -8].Pre), asm => asm.STILP(WZR, W16, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP WZR, W16, [X3, #-8]!");
        TestInst(STILP(W0, WZR, _[X3, -8].Pre), asm => asm.STILP(W0, WZR, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP W0, WZR, [X3, #-8]!");
        TestInst(STILP(W15, WZR, _[X3, -8].Pre), asm => asm.STILP(W15, WZR, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP W15, WZR, [X3, #-8]!");
        TestInst(STILP(WZR, WZR, _[X3, -8].Pre), asm => asm.STILP(WZR, WZR, _[X3, -8].Pre), Arm64InstructionId.STILP_32se_ldiappstilp, Arm64Mnemonic.STILP, "STILP WZR, WZR, [X3, #-8]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STILP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STILP_32s_ldiappstilp_1()
    {
        TestInst(STILP(W0, W1, _[X3]), asm => asm.STILP(W0, W1, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP W0, W1, [X3]");
        TestInst(STILP(W15, W1, _[X3]), asm => asm.STILP(W15, W1, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP W15, W1, [X3]");
        TestInst(STILP(WZR, W1, _[X3]), asm => asm.STILP(WZR, W1, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP WZR, W1, [X3]");
        TestInst(STILP(W0, W16, _[X3]), asm => asm.STILP(W0, W16, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP W0, W16, [X3]");
        TestInst(STILP(W15, W16, _[X3]), asm => asm.STILP(W15, W16, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP W15, W16, [X3]");
        TestInst(STILP(WZR, W16, _[X3]), asm => asm.STILP(WZR, W16, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP WZR, W16, [X3]");
        TestInst(STILP(W0, WZR, _[X3]), asm => asm.STILP(W0, WZR, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP W0, WZR, [X3]");
        TestInst(STILP(W15, WZR, _[X3]), asm => asm.STILP(W15, WZR, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP W15, WZR, [X3]");
        TestInst(STILP(WZR, WZR, _[X3]), asm => asm.STILP(WZR, WZR, _[X3]), Arm64InstructionId.STILP_32s_ldiappstilp, Arm64Mnemonic.STILP, "STILP WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STILP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STILP_64ss_ldiappstilp_2()
    {
        TestInst(STILP(X0, X1, _[X3, -16].Pre), asm => asm.STILP(X0, X1, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP X0, X1, [X3, #-16]!");
        TestInst(STILP(X15, X1, _[X3, -16].Pre), asm => asm.STILP(X15, X1, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP X15, X1, [X3, #-16]!");
        TestInst(STILP(XZR, X1, _[X3, -16].Pre), asm => asm.STILP(XZR, X1, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP XZR, X1, [X3, #-16]!");
        TestInst(STILP(X0, X16, _[X3, -16].Pre), asm => asm.STILP(X0, X16, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP X0, X16, [X3, #-16]!");
        TestInst(STILP(X15, X16, _[X3, -16].Pre), asm => asm.STILP(X15, X16, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP X15, X16, [X3, #-16]!");
        TestInst(STILP(XZR, X16, _[X3, -16].Pre), asm => asm.STILP(XZR, X16, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP XZR, X16, [X3, #-16]!");
        TestInst(STILP(X0, XZR, _[X3, -16].Pre), asm => asm.STILP(X0, XZR, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP X0, XZR, [X3, #-16]!");
        TestInst(STILP(X15, XZR, _[X3, -16].Pre), asm => asm.STILP(X15, XZR, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP X15, XZR, [X3, #-16]!");
        TestInst(STILP(XZR, XZR, _[X3, -16].Pre), asm => asm.STILP(XZR, XZR, _[X3, -16].Pre), Arm64InstructionId.STILP_64ss_ldiappstilp, Arm64Mnemonic.STILP, "STILP XZR, XZR, [X3, #-16]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STILP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STILP_64s_ldiappstilp_3()
    {
        TestInst(STILP(X0, X1, _[X3]), asm => asm.STILP(X0, X1, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP X0, X1, [X3]");
        TestInst(STILP(X15, X1, _[X3]), asm => asm.STILP(X15, X1, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP X15, X1, [X3]");
        TestInst(STILP(XZR, X1, _[X3]), asm => asm.STILP(XZR, X1, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP XZR, X1, [X3]");
        TestInst(STILP(X0, X16, _[X3]), asm => asm.STILP(X0, X16, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP X0, X16, [X3]");
        TestInst(STILP(X15, X16, _[X3]), asm => asm.STILP(X15, X16, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP X15, X16, [X3]");
        TestInst(STILP(XZR, X16, _[X3]), asm => asm.STILP(XZR, X16, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP XZR, X16, [X3]");
        TestInst(STILP(X0, XZR, _[X3]), asm => asm.STILP(X0, XZR, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP X0, XZR, [X3]");
        TestInst(STILP(X15, XZR, _[X3]), asm => asm.STILP(X15, XZR, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP X15, XZR, [X3]");
        TestInst(STILP(XZR, XZR, _[X3]), asm => asm.STILP(XZR, XZR, _[X3]), Arm64InstructionId.STILP_64s_ldiappstilp, Arm64Mnemonic.STILP, "STILP XZR, XZR, [X3]");
    }
}
