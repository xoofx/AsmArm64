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
public class Arm64InstructionFactoryTests_PACGA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACGA"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACGA_64p_dp_2src_0()
    {
        TestInst(PACGA(X0, X1, X3), asm => asm.PACGA(X0, X1, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, X1, X3");
        TestInst(PACGA(X15, X1, X3), asm => asm.PACGA(X15, X1, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, X1, X3");
        TestInst(PACGA(XZR, X1, X3), asm => asm.PACGA(XZR, X1, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, X1, X3");
        TestInst(PACGA(X0, X16, X3), asm => asm.PACGA(X0, X16, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, X16, X3");
        TestInst(PACGA(X15, X16, X3), asm => asm.PACGA(X15, X16, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, X16, X3");
        TestInst(PACGA(XZR, X16, X3), asm => asm.PACGA(XZR, X16, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, X16, X3");
        TestInst(PACGA(X0, XZR, X3), asm => asm.PACGA(X0, XZR, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, XZR, X3");
        TestInst(PACGA(X15, XZR, X3), asm => asm.PACGA(X15, XZR, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, XZR, X3");
        TestInst(PACGA(XZR, XZR, X3), asm => asm.PACGA(XZR, XZR, X3), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, XZR, X3");
        TestInst(PACGA(X0, X1, X19), asm => asm.PACGA(X0, X1, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, X1, X19");
        TestInst(PACGA(X15, X1, X19), asm => asm.PACGA(X15, X1, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, X1, X19");
        TestInst(PACGA(XZR, X1, X19), asm => asm.PACGA(XZR, X1, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, X1, X19");
        TestInst(PACGA(X0, X16, X19), asm => asm.PACGA(X0, X16, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, X16, X19");
        TestInst(PACGA(X15, X16, X19), asm => asm.PACGA(X15, X16, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, X16, X19");
        TestInst(PACGA(XZR, X16, X19), asm => asm.PACGA(XZR, X16, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, X16, X19");
        TestInst(PACGA(X0, XZR, X19), asm => asm.PACGA(X0, XZR, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, XZR, X19");
        TestInst(PACGA(X15, XZR, X19), asm => asm.PACGA(X15, XZR, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, XZR, X19");
        TestInst(PACGA(XZR, XZR, X19), asm => asm.PACGA(XZR, XZR, X19), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, XZR, X19");
        TestInst(PACGA(X0, X1, SP), asm => asm.PACGA(X0, X1, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, X1, SP");
        TestInst(PACGA(X15, X1, SP), asm => asm.PACGA(X15, X1, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, X1, SP");
        TestInst(PACGA(XZR, X1, SP), asm => asm.PACGA(XZR, X1, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, X1, SP");
        TestInst(PACGA(X0, X16, SP), asm => asm.PACGA(X0, X16, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, X16, SP");
        TestInst(PACGA(X15, X16, SP), asm => asm.PACGA(X15, X16, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, X16, SP");
        TestInst(PACGA(XZR, X16, SP), asm => asm.PACGA(XZR, X16, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, X16, SP");
        TestInst(PACGA(X0, XZR, SP), asm => asm.PACGA(X0, XZR, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X0, XZR, SP");
        TestInst(PACGA(X15, XZR, SP), asm => asm.PACGA(X15, XZR, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA X15, XZR, SP");
        TestInst(PACGA(XZR, XZR, SP), asm => asm.PACGA(XZR, XZR, SP), Arm64InstructionId.PACGA_64p_dp_2src, Arm64Mnemonic.PACGA, "PACGA XZR, XZR, SP");
    }
}
