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
public class Arm64InstructionFactoryTests_SMULH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMULH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMULH_64_dp_3src_0()
    {
        TestInst(SMULH(X0, X1, X2), asm => asm.SMULH(X0, X1, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, X1, X2");
        TestInst(SMULH(X15, X1, X2), asm => asm.SMULH(X15, X1, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, X1, X2");
        TestInst(SMULH(XZR, X1, X2), asm => asm.SMULH(XZR, X1, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, X1, X2");
        TestInst(SMULH(X0, X16, X2), asm => asm.SMULH(X0, X16, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, X16, X2");
        TestInst(SMULH(X15, X16, X2), asm => asm.SMULH(X15, X16, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, X16, X2");
        TestInst(SMULH(XZR, X16, X2), asm => asm.SMULH(XZR, X16, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, X16, X2");
        TestInst(SMULH(X0, XZR, X2), asm => asm.SMULH(X0, XZR, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, XZR, X2");
        TestInst(SMULH(X15, XZR, X2), asm => asm.SMULH(X15, XZR, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, XZR, X2");
        TestInst(SMULH(XZR, XZR, X2), asm => asm.SMULH(XZR, XZR, X2), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, XZR, X2");
        TestInst(SMULH(X0, X1, X17), asm => asm.SMULH(X0, X1, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, X1, X17");
        TestInst(SMULH(X15, X1, X17), asm => asm.SMULH(X15, X1, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, X1, X17");
        TestInst(SMULH(XZR, X1, X17), asm => asm.SMULH(XZR, X1, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, X1, X17");
        TestInst(SMULH(X0, X16, X17), asm => asm.SMULH(X0, X16, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, X16, X17");
        TestInst(SMULH(X15, X16, X17), asm => asm.SMULH(X15, X16, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, X16, X17");
        TestInst(SMULH(XZR, X16, X17), asm => asm.SMULH(XZR, X16, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, X16, X17");
        TestInst(SMULH(X0, XZR, X17), asm => asm.SMULH(X0, XZR, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, XZR, X17");
        TestInst(SMULH(X15, XZR, X17), asm => asm.SMULH(X15, XZR, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, XZR, X17");
        TestInst(SMULH(XZR, XZR, X17), asm => asm.SMULH(XZR, XZR, X17), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, XZR, X17");
        TestInst(SMULH(X0, X1, XZR), asm => asm.SMULH(X0, X1, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, X1, XZR");
        TestInst(SMULH(X15, X1, XZR), asm => asm.SMULH(X15, X1, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, X1, XZR");
        TestInst(SMULH(XZR, X1, XZR), asm => asm.SMULH(XZR, X1, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, X1, XZR");
        TestInst(SMULH(X0, X16, XZR), asm => asm.SMULH(X0, X16, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, X16, XZR");
        TestInst(SMULH(X15, X16, XZR), asm => asm.SMULH(X15, X16, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, X16, XZR");
        TestInst(SMULH(XZR, X16, XZR), asm => asm.SMULH(XZR, X16, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, X16, XZR");
        TestInst(SMULH(X0, XZR, XZR), asm => asm.SMULH(X0, XZR, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X0, XZR, XZR");
        TestInst(SMULH(X15, XZR, XZR), asm => asm.SMULH(X15, XZR, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH X15, XZR, XZR");
        TestInst(SMULH(XZR, XZR, XZR), asm => asm.SMULH(XZR, XZR, XZR), Arm64InstructionId.SMULH_64_dp_3src, Arm64Mnemonic.SMULH, "SMULH XZR, XZR, XZR");
    }
}
