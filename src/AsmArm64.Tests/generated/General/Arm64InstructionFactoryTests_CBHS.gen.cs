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
public class Arm64InstructionFactoryTests_CBHS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHS_32_regs_0()
    {
        TestInst(CBHS(W0, W1, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS W0, W1, #32");
        TestInst(CBHS(W15, W1, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS W15, W1, #32");
        TestInst(CBHS(WZR, W1, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS WZR, W1, #32");
        TestInst(CBHS(W0, W16, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS W0, W16, #32");
        TestInst(CBHS(W15, W16, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS W15, W16, #32");
        TestInst(CBHS(WZR, W16, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS WZR, W16, #32");
        TestInst(CBHS(W0, WZR, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS W0, WZR, #32");
        TestInst(CBHS(W15, WZR, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS W15, WZR, #32");
        TestInst(CBHS(WZR, WZR, 32), null, Arm64InstructionId.CBHS_32_regs, Arm64Mnemonic.CBHS, "CBHS WZR, WZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHS_64_regs_1()
    {
        TestInst(CBHS(X0, X1, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS X0, X1, #32");
        TestInst(CBHS(X15, X1, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS X15, X1, #32");
        TestInst(CBHS(XZR, X1, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS XZR, X1, #32");
        TestInst(CBHS(X0, X16, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS X0, X16, #32");
        TestInst(CBHS(X15, X16, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS X15, X16, #32");
        TestInst(CBHS(XZR, X16, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS XZR, X16, #32");
        TestInst(CBHS(X0, XZR, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS X0, XZR, #32");
        TestInst(CBHS(X15, XZR, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS X15, XZR, #32");
        TestInst(CBHS(XZR, XZR, 32), null, Arm64InstructionId.CBHS_64_regs, Arm64Mnemonic.CBHS, "CBHS XZR, XZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHS_cbhi_32_imm_2()
    {
        TestInst(CBHS(W0, 5, 32), null, Arm64InstructionId.CBHI_32_imm, Arm64Mnemonic.CBHI, "CBHI W0, #5, #32");
        TestInst(CBHS(W15, 5, 32), null, Arm64InstructionId.CBHI_32_imm, Arm64Mnemonic.CBHI, "CBHI W15, #5, #32");
        TestInst(CBHS(WZR, 5, 32), null, Arm64InstructionId.CBHI_32_imm, Arm64Mnemonic.CBHI, "CBHI WZR, #5, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHS_cbhi_64_imm_3()
    {
        TestInst(CBHS(X0, 5, 32), null, Arm64InstructionId.CBHI_64_imm, Arm64Mnemonic.CBHI, "CBHI X0, #5, #32");
        TestInst(CBHS(X15, 5, 32), null, Arm64InstructionId.CBHI_64_imm, Arm64Mnemonic.CBHI, "CBHI X15, #5, #32");
        TestInst(CBHS(XZR, 5, 32), null, Arm64InstructionId.CBHI_64_imm, Arm64Mnemonic.CBHI, "CBHI XZR, #5, #32");
    }
}
