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
public class Arm64InstructionFactoryTests_CBHI_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHI"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHI_32_imm_0()
    {
        TestInst(CBHI(W0, 5, 32), null, Arm64InstructionId.CBHI_32_imm, Arm64Mnemonic.CBHI, "CBHI W0, #5, #32");
        TestInst(CBHI(W15, 5, 32), null, Arm64InstructionId.CBHI_32_imm, Arm64Mnemonic.CBHI, "CBHI W15, #5, #32");
        TestInst(CBHI(WZR, 5, 32), null, Arm64InstructionId.CBHI_32_imm, Arm64Mnemonic.CBHI, "CBHI WZR, #5, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHI"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHI_64_imm_1()
    {
        TestInst(CBHI(X0, 5, 32), null, Arm64InstructionId.CBHI_64_imm, Arm64Mnemonic.CBHI, "CBHI X0, #5, #32");
        TestInst(CBHI(X15, 5, 32), null, Arm64InstructionId.CBHI_64_imm, Arm64Mnemonic.CBHI, "CBHI X15, #5, #32");
        TestInst(CBHI(XZR, 5, 32), null, Arm64InstructionId.CBHI_64_imm, Arm64Mnemonic.CBHI, "CBHI XZR, #5, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHI"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHI_32_regs_2()
    {
        TestInst(CBHI(W0, W1, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI W0, W1, #32");
        TestInst(CBHI(W15, W1, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI W15, W1, #32");
        TestInst(CBHI(WZR, W1, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI WZR, W1, #32");
        TestInst(CBHI(W0, W16, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI W0, W16, #32");
        TestInst(CBHI(W15, W16, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI W15, W16, #32");
        TestInst(CBHI(WZR, W16, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI WZR, W16, #32");
        TestInst(CBHI(W0, WZR, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI W0, WZR, #32");
        TestInst(CBHI(W15, WZR, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI W15, WZR, #32");
        TestInst(CBHI(WZR, WZR, 32), null, Arm64InstructionId.CBHI_32_regs, Arm64Mnemonic.CBHI, "CBHI WZR, WZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHI"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHI_64_regs_3()
    {
        TestInst(CBHI(X0, X1, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI X0, X1, #32");
        TestInst(CBHI(X15, X1, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI X15, X1, #32");
        TestInst(CBHI(XZR, X1, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI XZR, X1, #32");
        TestInst(CBHI(X0, X16, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI X0, X16, #32");
        TestInst(CBHI(X15, X16, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI X15, X16, #32");
        TestInst(CBHI(XZR, X16, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI XZR, X16, #32");
        TestInst(CBHI(X0, XZR, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI X0, XZR, #32");
        TestInst(CBHI(X15, XZR, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI X15, XZR, #32");
        TestInst(CBHI(XZR, XZR, 32), null, Arm64InstructionId.CBHI_64_regs, Arm64Mnemonic.CBHI, "CBHI XZR, XZR, #32");
    }
}
