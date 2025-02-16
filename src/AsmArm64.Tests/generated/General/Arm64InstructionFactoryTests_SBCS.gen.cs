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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_SBCS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SBCS"/>.
    /// </summary>
    [TestMethod]
    public void Test_SBCS_32_addsub_carry_0()
    {
        TestInst(SBCS(W0, W1, W2), asm => asm.SBCS(W0, W1, W2), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W0, W1, W2");
        TestInst(SBCS(W15, W1, W2), asm => asm.SBCS(W15, W1, W2), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W15, W1, W2");
        TestInst(SBCS(WZR, W1, W2), asm => asm.SBCS(WZR, W1, W2), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS WZR, W1, W2");
        TestInst(SBCS(W0, W16, W2), asm => asm.SBCS(W0, W16, W2), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W0, W16, W2");
        TestInst(SBCS(W15, W16, W2), asm => asm.SBCS(W15, W16, W2), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W15, W16, W2");
        TestInst(SBCS(WZR, W16, W2), asm => asm.SBCS(WZR, W16, W2), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS WZR, W16, W2");
        TestInst(SBCS(W0, WZR, W2), asm => asm.SBCS(W0, WZR, W2), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W0, W2");
        TestInst(SBCS(W15, WZR, W2), asm => asm.SBCS(W15, WZR, W2), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W15, W2");
        TestInst(SBCS(WZR, WZR, W2), asm => asm.SBCS(WZR, WZR, W2), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS WZR, W2");
        TestInst(SBCS(W0, W1, W17), asm => asm.SBCS(W0, W1, W17), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W0, W1, W17");
        TestInst(SBCS(W15, W1, W17), asm => asm.SBCS(W15, W1, W17), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W15, W1, W17");
        TestInst(SBCS(WZR, W1, W17), asm => asm.SBCS(WZR, W1, W17), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS WZR, W1, W17");
        TestInst(SBCS(W0, W16, W17), asm => asm.SBCS(W0, W16, W17), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W0, W16, W17");
        TestInst(SBCS(W15, W16, W17), asm => asm.SBCS(W15, W16, W17), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W15, W16, W17");
        TestInst(SBCS(WZR, W16, W17), asm => asm.SBCS(WZR, W16, W17), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS WZR, W16, W17");
        TestInst(SBCS(W0, WZR, W17), asm => asm.SBCS(W0, WZR, W17), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W0, W17");
        TestInst(SBCS(W15, WZR, W17), asm => asm.SBCS(W15, WZR, W17), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W15, W17");
        TestInst(SBCS(WZR, WZR, W17), asm => asm.SBCS(WZR, WZR, W17), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS WZR, W17");
        TestInst(SBCS(W0, W1, WZR), asm => asm.SBCS(W0, W1, WZR), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W0, W1, WZR");
        TestInst(SBCS(W15, W1, WZR), asm => asm.SBCS(W15, W1, WZR), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W15, W1, WZR");
        TestInst(SBCS(WZR, W1, WZR), asm => asm.SBCS(WZR, W1, WZR), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS WZR, W1, WZR");
        TestInst(SBCS(W0, W16, WZR), asm => asm.SBCS(W0, W16, WZR), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W0, W16, WZR");
        TestInst(SBCS(W15, W16, WZR), asm => asm.SBCS(W15, W16, WZR), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS W15, W16, WZR");
        TestInst(SBCS(WZR, W16, WZR), asm => asm.SBCS(WZR, W16, WZR), Arm64InstructionId.SBCS_32_addsub_carry, Arm64Mnemonic.SBCS, "SBCS WZR, W16, WZR");
        TestInst(SBCS(W0, WZR, WZR), asm => asm.SBCS(W0, WZR, WZR), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W0, WZR");
        TestInst(SBCS(W15, WZR, WZR), asm => asm.SBCS(W15, WZR, WZR), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W15, WZR");
        TestInst(SBCS(WZR, WZR, WZR), asm => asm.SBCS(WZR, WZR, WZR), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SBCS"/>.
    /// </summary>
    [TestMethod]
    public void Test_SBCS_64_addsub_carry_1()
    {
        TestInst(SBCS(X0, X1, X2), asm => asm.SBCS(X0, X1, X2), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X0, X1, X2");
        TestInst(SBCS(X15, X1, X2), asm => asm.SBCS(X15, X1, X2), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X15, X1, X2");
        TestInst(SBCS(XZR, X1, X2), asm => asm.SBCS(XZR, X1, X2), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS XZR, X1, X2");
        TestInst(SBCS(X0, X16, X2), asm => asm.SBCS(X0, X16, X2), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X0, X16, X2");
        TestInst(SBCS(X15, X16, X2), asm => asm.SBCS(X15, X16, X2), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X15, X16, X2");
        TestInst(SBCS(XZR, X16, X2), asm => asm.SBCS(XZR, X16, X2), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS XZR, X16, X2");
        TestInst(SBCS(X0, XZR, X2), asm => asm.SBCS(X0, XZR, X2), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X0, X2");
        TestInst(SBCS(X15, XZR, X2), asm => asm.SBCS(X15, XZR, X2), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X15, X2");
        TestInst(SBCS(XZR, XZR, X2), asm => asm.SBCS(XZR, XZR, X2), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS XZR, X2");
        TestInst(SBCS(X0, X1, X17), asm => asm.SBCS(X0, X1, X17), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X0, X1, X17");
        TestInst(SBCS(X15, X1, X17), asm => asm.SBCS(X15, X1, X17), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X15, X1, X17");
        TestInst(SBCS(XZR, X1, X17), asm => asm.SBCS(XZR, X1, X17), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS XZR, X1, X17");
        TestInst(SBCS(X0, X16, X17), asm => asm.SBCS(X0, X16, X17), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X0, X16, X17");
        TestInst(SBCS(X15, X16, X17), asm => asm.SBCS(X15, X16, X17), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X15, X16, X17");
        TestInst(SBCS(XZR, X16, X17), asm => asm.SBCS(XZR, X16, X17), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS XZR, X16, X17");
        TestInst(SBCS(X0, XZR, X17), asm => asm.SBCS(X0, XZR, X17), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X0, X17");
        TestInst(SBCS(X15, XZR, X17), asm => asm.SBCS(X15, XZR, X17), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X15, X17");
        TestInst(SBCS(XZR, XZR, X17), asm => asm.SBCS(XZR, XZR, X17), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS XZR, X17");
        TestInst(SBCS(X0, X1, XZR), asm => asm.SBCS(X0, X1, XZR), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X0, X1, XZR");
        TestInst(SBCS(X15, X1, XZR), asm => asm.SBCS(X15, X1, XZR), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X15, X1, XZR");
        TestInst(SBCS(XZR, X1, XZR), asm => asm.SBCS(XZR, X1, XZR), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS XZR, X1, XZR");
        TestInst(SBCS(X0, X16, XZR), asm => asm.SBCS(X0, X16, XZR), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X0, X16, XZR");
        TestInst(SBCS(X15, X16, XZR), asm => asm.SBCS(X15, X16, XZR), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS X15, X16, XZR");
        TestInst(SBCS(XZR, X16, XZR), asm => asm.SBCS(XZR, X16, XZR), Arm64InstructionId.SBCS_64_addsub_carry, Arm64Mnemonic.SBCS, "SBCS XZR, X16, XZR");
        TestInst(SBCS(X0, XZR, XZR), asm => asm.SBCS(X0, XZR, XZR), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X0, XZR");
        TestInst(SBCS(X15, XZR, XZR), asm => asm.SBCS(X15, XZR, XZR), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X15, XZR");
        TestInst(SBCS(XZR, XZR, XZR), asm => asm.SBCS(XZR, XZR, XZR), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS XZR, XZR");
    }
}
