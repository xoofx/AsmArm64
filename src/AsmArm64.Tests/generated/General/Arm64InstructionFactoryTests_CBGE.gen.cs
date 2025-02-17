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
public class Arm64InstructionFactoryTests_CBGE_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGE_32_regs_0()
    {
        TestInst(CBGE(W0, W1, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE W0, W1, #32");
        TestInst(CBGE(W15, W1, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE W15, W1, #32");
        TestInst(CBGE(WZR, W1, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE WZR, W1, #32");
        TestInst(CBGE(W0, W16, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE W0, W16, #32");
        TestInst(CBGE(W15, W16, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE W15, W16, #32");
        TestInst(CBGE(WZR, W16, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE WZR, W16, #32");
        TestInst(CBGE(W0, WZR, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE W0, WZR, #32");
        TestInst(CBGE(W15, WZR, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE W15, WZR, #32");
        TestInst(CBGE(WZR, WZR, 32), null, Arm64InstructionId.CBGE_32_regs, Arm64Mnemonic.CBGE, "CBGE WZR, WZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGE_64_regs_1()
    {
        TestInst(CBGE(X0, X1, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE X0, X1, #32");
        TestInst(CBGE(X15, X1, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE X15, X1, #32");
        TestInst(CBGE(XZR, X1, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE XZR, X1, #32");
        TestInst(CBGE(X0, X16, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE X0, X16, #32");
        TestInst(CBGE(X15, X16, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE X15, X16, #32");
        TestInst(CBGE(XZR, X16, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE XZR, X16, #32");
        TestInst(CBGE(X0, XZR, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE X0, XZR, #32");
        TestInst(CBGE(X15, XZR, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE X15, XZR, #32");
        TestInst(CBGE(XZR, XZR, 32), null, Arm64InstructionId.CBGE_64_regs, Arm64Mnemonic.CBGE, "CBGE XZR, XZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGE_cbgt_32_imm_2()
    {
        TestInst(CBGE(W0, 5, 32), null, Arm64InstructionId.CBGT_32_imm, Arm64Mnemonic.CBGT, "CBGT W0, #5, #32");
        TestInst(CBGE(W15, 5, 32), null, Arm64InstructionId.CBGT_32_imm, Arm64Mnemonic.CBGT, "CBGT W15, #5, #32");
        TestInst(CBGE(WZR, 5, 32), null, Arm64InstructionId.CBGT_32_imm, Arm64Mnemonic.CBGT, "CBGT WZR, #5, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGE_cbgt_64_imm_3()
    {
        TestInst(CBGE(X0, 5, 32), null, Arm64InstructionId.CBGT_64_imm, Arm64Mnemonic.CBGT, "CBGT X0, #5, #32");
        TestInst(CBGE(X15, 5, 32), null, Arm64InstructionId.CBGT_64_imm, Arm64Mnemonic.CBGT, "CBGT X15, #5, #32");
        TestInst(CBGE(XZR, 5, 32), null, Arm64InstructionId.CBGT_64_imm, Arm64Mnemonic.CBGT, "CBGT XZR, #5, #32");
    }
}
