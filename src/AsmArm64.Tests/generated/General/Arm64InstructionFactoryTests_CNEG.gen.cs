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
public class Arm64InstructionFactoryTests_CNEG_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CNEG"/>.
    /// </summary>
    [TestMethod]
    public void Test_CNEG_csneg_32_condsel_0()
    {
        TestInst(CNEG(W0, W1, NE), asm => asm.CNEG(W0, W1, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W0, W1, NE");
        TestInst(CNEG(W15, W1, NE), asm => asm.CNEG(W15, W1, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W15, W1, NE");
        TestInst(CNEG(WZR, W1, NE), asm => asm.CNEG(WZR, W1, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG WZR, W1, NE");
        TestInst(CNEG(W0, W16, NE), asm => asm.CNEG(W0, W16, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W0, W16, NE");
        TestInst(CNEG(W15, W16, NE), asm => asm.CNEG(W15, W16, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W15, W16, NE");
        TestInst(CNEG(WZR, W16, NE), asm => asm.CNEG(WZR, W16, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG WZR, W16, NE");
        TestInst(CNEG(W0, WZR, NE), asm => asm.CNEG(W0, WZR, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W0, WZR, NE");
        TestInst(CNEG(W15, WZR, NE), asm => asm.CNEG(W15, WZR, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W15, WZR, NE");
        TestInst(CNEG(WZR, WZR, NE), asm => asm.CNEG(WZR, WZR, NE), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG WZR, WZR, NE");
        TestInst(CNEG(W0, W1, HS), asm => asm.CNEG(W0, W1, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W0, W1, HS");
        TestInst(CNEG(W15, W1, HS), asm => asm.CNEG(W15, W1, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W15, W1, HS");
        TestInst(CNEG(WZR, W1, HS), asm => asm.CNEG(WZR, W1, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG WZR, W1, HS");
        TestInst(CNEG(W0, W16, HS), asm => asm.CNEG(W0, W16, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W0, W16, HS");
        TestInst(CNEG(W15, W16, HS), asm => asm.CNEG(W15, W16, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W15, W16, HS");
        TestInst(CNEG(WZR, W16, HS), asm => asm.CNEG(WZR, W16, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG WZR, W16, HS");
        TestInst(CNEG(W0, WZR, HS), asm => asm.CNEG(W0, WZR, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W0, WZR, HS");
        TestInst(CNEG(W15, WZR, HS), asm => asm.CNEG(W15, WZR, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG W15, WZR, HS");
        TestInst(CNEG(WZR, WZR, HS), asm => asm.CNEG(WZR, WZR, HS), Arm64InstructionId.CNEG_csneg_32_condsel, Arm64Mnemonic.CNEG, "CNEG WZR, WZR, HS");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CNEG"/>.
    /// </summary>
    [TestMethod]
    public void Test_CNEG_csneg_64_condsel_1()
    {
        TestInst(CNEG(X0, X1, NE), asm => asm.CNEG(X0, X1, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X0, X1, NE");
        TestInst(CNEG(X15, X1, NE), asm => asm.CNEG(X15, X1, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X15, X1, NE");
        TestInst(CNEG(XZR, X1, NE), asm => asm.CNEG(XZR, X1, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG XZR, X1, NE");
        TestInst(CNEG(X0, X16, NE), asm => asm.CNEG(X0, X16, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X0, X16, NE");
        TestInst(CNEG(X15, X16, NE), asm => asm.CNEG(X15, X16, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X15, X16, NE");
        TestInst(CNEG(XZR, X16, NE), asm => asm.CNEG(XZR, X16, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG XZR, X16, NE");
        TestInst(CNEG(X0, XZR, NE), asm => asm.CNEG(X0, XZR, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X0, XZR, NE");
        TestInst(CNEG(X15, XZR, NE), asm => asm.CNEG(X15, XZR, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X15, XZR, NE");
        TestInst(CNEG(XZR, XZR, NE), asm => asm.CNEG(XZR, XZR, NE), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG XZR, XZR, NE");
        TestInst(CNEG(X0, X1, HS), asm => asm.CNEG(X0, X1, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X0, X1, HS");
        TestInst(CNEG(X15, X1, HS), asm => asm.CNEG(X15, X1, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X15, X1, HS");
        TestInst(CNEG(XZR, X1, HS), asm => asm.CNEG(XZR, X1, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG XZR, X1, HS");
        TestInst(CNEG(X0, X16, HS), asm => asm.CNEG(X0, X16, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X0, X16, HS");
        TestInst(CNEG(X15, X16, HS), asm => asm.CNEG(X15, X16, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X15, X16, HS");
        TestInst(CNEG(XZR, X16, HS), asm => asm.CNEG(XZR, X16, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG XZR, X16, HS");
        TestInst(CNEG(X0, XZR, HS), asm => asm.CNEG(X0, XZR, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X0, XZR, HS");
        TestInst(CNEG(X15, XZR, HS), asm => asm.CNEG(X15, XZR, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG X15, XZR, HS");
        TestInst(CNEG(XZR, XZR, HS), asm => asm.CNEG(XZR, XZR, HS), Arm64InstructionId.CNEG_csneg_64_condsel, Arm64Mnemonic.CNEG, "CNEG XZR, XZR, HS");
    }
}
