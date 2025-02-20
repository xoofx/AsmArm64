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
public class Arm64InstructionFactoryTests_ADCS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADCS"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADCS_32_addsub_carry_0()
    {
        TestInst(ADCS(W0, W1, W2), asm => asm.ADCS(W0, W1, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, W1, W2");
        TestInst(ADCS(W15, W1, W2), asm => asm.ADCS(W15, W1, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, W1, W2");
        TestInst(ADCS(WZR, W1, W2), asm => asm.ADCS(WZR, W1, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, W1, W2");
        TestInst(ADCS(W0, W16, W2), asm => asm.ADCS(W0, W16, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, W16, W2");
        TestInst(ADCS(W15, W16, W2), asm => asm.ADCS(W15, W16, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, W16, W2");
        TestInst(ADCS(WZR, W16, W2), asm => asm.ADCS(WZR, W16, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, W16, W2");
        TestInst(ADCS(W0, WZR, W2), asm => asm.ADCS(W0, WZR, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, WZR, W2");
        TestInst(ADCS(W15, WZR, W2), asm => asm.ADCS(W15, WZR, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, WZR, W2");
        TestInst(ADCS(WZR, WZR, W2), asm => asm.ADCS(WZR, WZR, W2), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, WZR, W2");
        TestInst(ADCS(W0, W1, W17), asm => asm.ADCS(W0, W1, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, W1, W17");
        TestInst(ADCS(W15, W1, W17), asm => asm.ADCS(W15, W1, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, W1, W17");
        TestInst(ADCS(WZR, W1, W17), asm => asm.ADCS(WZR, W1, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, W1, W17");
        TestInst(ADCS(W0, W16, W17), asm => asm.ADCS(W0, W16, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, W16, W17");
        TestInst(ADCS(W15, W16, W17), asm => asm.ADCS(W15, W16, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, W16, W17");
        TestInst(ADCS(WZR, W16, W17), asm => asm.ADCS(WZR, W16, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, W16, W17");
        TestInst(ADCS(W0, WZR, W17), asm => asm.ADCS(W0, WZR, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, WZR, W17");
        TestInst(ADCS(W15, WZR, W17), asm => asm.ADCS(W15, WZR, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, WZR, W17");
        TestInst(ADCS(WZR, WZR, W17), asm => asm.ADCS(WZR, WZR, W17), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, WZR, W17");
        TestInst(ADCS(W0, W1, WZR), asm => asm.ADCS(W0, W1, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, W1, WZR");
        TestInst(ADCS(W15, W1, WZR), asm => asm.ADCS(W15, W1, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, W1, WZR");
        TestInst(ADCS(WZR, W1, WZR), asm => asm.ADCS(WZR, W1, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, W1, WZR");
        TestInst(ADCS(W0, W16, WZR), asm => asm.ADCS(W0, W16, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, W16, WZR");
        TestInst(ADCS(W15, W16, WZR), asm => asm.ADCS(W15, W16, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, W16, WZR");
        TestInst(ADCS(WZR, W16, WZR), asm => asm.ADCS(WZR, W16, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, W16, WZR");
        TestInst(ADCS(W0, WZR, WZR), asm => asm.ADCS(W0, WZR, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W0, WZR, WZR");
        TestInst(ADCS(W15, WZR, WZR), asm => asm.ADCS(W15, WZR, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS W15, WZR, WZR");
        TestInst(ADCS(WZR, WZR, WZR), asm => asm.ADCS(WZR, WZR, WZR), Arm64InstructionId.ADCS_32_addsub_carry, Arm64Mnemonic.ADCS, "ADCS WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADCS"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADCS_64_addsub_carry_1()
    {
        TestInst(ADCS(X0, X1, X2), asm => asm.ADCS(X0, X1, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, X1, X2");
        TestInst(ADCS(X15, X1, X2), asm => asm.ADCS(X15, X1, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, X1, X2");
        TestInst(ADCS(XZR, X1, X2), asm => asm.ADCS(XZR, X1, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, X1, X2");
        TestInst(ADCS(X0, X16, X2), asm => asm.ADCS(X0, X16, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, X16, X2");
        TestInst(ADCS(X15, X16, X2), asm => asm.ADCS(X15, X16, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, X16, X2");
        TestInst(ADCS(XZR, X16, X2), asm => asm.ADCS(XZR, X16, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, X16, X2");
        TestInst(ADCS(X0, XZR, X2), asm => asm.ADCS(X0, XZR, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, XZR, X2");
        TestInst(ADCS(X15, XZR, X2), asm => asm.ADCS(X15, XZR, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, XZR, X2");
        TestInst(ADCS(XZR, XZR, X2), asm => asm.ADCS(XZR, XZR, X2), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, XZR, X2");
        TestInst(ADCS(X0, X1, X17), asm => asm.ADCS(X0, X1, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, X1, X17");
        TestInst(ADCS(X15, X1, X17), asm => asm.ADCS(X15, X1, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, X1, X17");
        TestInst(ADCS(XZR, X1, X17), asm => asm.ADCS(XZR, X1, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, X1, X17");
        TestInst(ADCS(X0, X16, X17), asm => asm.ADCS(X0, X16, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, X16, X17");
        TestInst(ADCS(X15, X16, X17), asm => asm.ADCS(X15, X16, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, X16, X17");
        TestInst(ADCS(XZR, X16, X17), asm => asm.ADCS(XZR, X16, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, X16, X17");
        TestInst(ADCS(X0, XZR, X17), asm => asm.ADCS(X0, XZR, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, XZR, X17");
        TestInst(ADCS(X15, XZR, X17), asm => asm.ADCS(X15, XZR, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, XZR, X17");
        TestInst(ADCS(XZR, XZR, X17), asm => asm.ADCS(XZR, XZR, X17), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, XZR, X17");
        TestInst(ADCS(X0, X1, XZR), asm => asm.ADCS(X0, X1, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, X1, XZR");
        TestInst(ADCS(X15, X1, XZR), asm => asm.ADCS(X15, X1, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, X1, XZR");
        TestInst(ADCS(XZR, X1, XZR), asm => asm.ADCS(XZR, X1, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, X1, XZR");
        TestInst(ADCS(X0, X16, XZR), asm => asm.ADCS(X0, X16, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, X16, XZR");
        TestInst(ADCS(X15, X16, XZR), asm => asm.ADCS(X15, X16, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, X16, XZR");
        TestInst(ADCS(XZR, X16, XZR), asm => asm.ADCS(XZR, X16, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, X16, XZR");
        TestInst(ADCS(X0, XZR, XZR), asm => asm.ADCS(X0, XZR, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X0, XZR, XZR");
        TestInst(ADCS(X15, XZR, XZR), asm => asm.ADCS(X15, XZR, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS X15, XZR, XZR");
        TestInst(ADCS(XZR, XZR, XZR), asm => asm.ADCS(XZR, XZR, XZR), Arm64InstructionId.ADCS_64_addsub_carry, Arm64Mnemonic.ADCS, "ADCS XZR, XZR, XZR");
    }
}
