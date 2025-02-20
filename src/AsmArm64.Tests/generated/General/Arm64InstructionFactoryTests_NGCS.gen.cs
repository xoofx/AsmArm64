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
public class Arm64InstructionFactoryTests_NGCS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.NGCS"/>.
    /// </summary>
    [TestMethod]
    public void Test_NGCS_sbcs_32_addsub_carry_0()
    {
        TestInst(NGCS(W0, W1), asm => asm.NGCS(W0, W1), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W0, W1");
        TestInst(NGCS(W15, W1), asm => asm.NGCS(W15, W1), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W15, W1");
        TestInst(NGCS(WZR, W1), asm => asm.NGCS(WZR, W1), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS WZR, W1");
        TestInst(NGCS(W0, W16), asm => asm.NGCS(W0, W16), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W0, W16");
        TestInst(NGCS(W15, W16), asm => asm.NGCS(W15, W16), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W15, W16");
        TestInst(NGCS(WZR, W16), asm => asm.NGCS(WZR, W16), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS WZR, W16");
        TestInst(NGCS(W0, WZR), asm => asm.NGCS(W0, WZR), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W0, WZR");
        TestInst(NGCS(W15, WZR), asm => asm.NGCS(W15, WZR), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS W15, WZR");
        TestInst(NGCS(WZR, WZR), asm => asm.NGCS(WZR, WZR), Arm64InstructionId.NGCS_sbcs_32_addsub_carry, Arm64Mnemonic.NGCS, "NGCS WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.NGCS"/>.
    /// </summary>
    [TestMethod]
    public void Test_NGCS_sbcs_64_addsub_carry_1()
    {
        TestInst(NGCS(X0, X1), asm => asm.NGCS(X0, X1), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X0, X1");
        TestInst(NGCS(X15, X1), asm => asm.NGCS(X15, X1), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X15, X1");
        TestInst(NGCS(XZR, X1), asm => asm.NGCS(XZR, X1), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS XZR, X1");
        TestInst(NGCS(X0, X16), asm => asm.NGCS(X0, X16), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X0, X16");
        TestInst(NGCS(X15, X16), asm => asm.NGCS(X15, X16), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X15, X16");
        TestInst(NGCS(XZR, X16), asm => asm.NGCS(XZR, X16), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS XZR, X16");
        TestInst(NGCS(X0, XZR), asm => asm.NGCS(X0, XZR), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X0, XZR");
        TestInst(NGCS(X15, XZR), asm => asm.NGCS(X15, XZR), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS X15, XZR");
        TestInst(NGCS(XZR, XZR), asm => asm.NGCS(XZR, XZR), Arm64InstructionId.NGCS_sbcs_64_addsub_carry, Arm64Mnemonic.NGCS, "NGCS XZR, XZR");
    }
}
