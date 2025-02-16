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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_CBGT_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGT_32_imm_0()
    {
        TestInst(CBGT(W0, 5, 32), Arm64InstructionId.CBGT_32_imm, Arm64Mnemonic.CBGT, "CBGT W0, #5, #32");
        TestInst(CBGT(W15, 5, 32), Arm64InstructionId.CBGT_32_imm, Arm64Mnemonic.CBGT, "CBGT W15, #5, #32");
        TestInst(CBGT(WZR, 5, 32), Arm64InstructionId.CBGT_32_imm, Arm64Mnemonic.CBGT, "CBGT WZR, #5, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGT_64_imm_1()
    {
        TestInst(CBGT(X0, 5, 32), Arm64InstructionId.CBGT_64_imm, Arm64Mnemonic.CBGT, "CBGT X0, #5, #32");
        TestInst(CBGT(X15, 5, 32), Arm64InstructionId.CBGT_64_imm, Arm64Mnemonic.CBGT, "CBGT X15, #5, #32");
        TestInst(CBGT(XZR, 5, 32), Arm64InstructionId.CBGT_64_imm, Arm64Mnemonic.CBGT, "CBGT XZR, #5, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGT_32_regs_2()
    {
        TestInst(CBGT(W0, W1, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT W0, W1, #32");
        TestInst(CBGT(W15, W1, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT W15, W1, #32");
        TestInst(CBGT(WZR, W1, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT WZR, W1, #32");
        TestInst(CBGT(W0, W16, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT W0, W16, #32");
        TestInst(CBGT(W15, W16, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT W15, W16, #32");
        TestInst(CBGT(WZR, W16, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT WZR, W16, #32");
        TestInst(CBGT(W0, WZR, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT W0, WZR, #32");
        TestInst(CBGT(W15, WZR, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT W15, WZR, #32");
        TestInst(CBGT(WZR, WZR, 32), Arm64InstructionId.CBGT_32_regs, Arm64Mnemonic.CBGT, "CBGT WZR, WZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBGT_64_regs_3()
    {
        TestInst(CBGT(X0, X1, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT X0, X1, #32");
        TestInst(CBGT(X15, X1, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT X15, X1, #32");
        TestInst(CBGT(XZR, X1, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT XZR, X1, #32");
        TestInst(CBGT(X0, X16, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT X0, X16, #32");
        TestInst(CBGT(X15, X16, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT X15, X16, #32");
        TestInst(CBGT(XZR, X16, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT XZR, X16, #32");
        TestInst(CBGT(X0, XZR, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT X0, XZR, #32");
        TestInst(CBGT(X15, XZR, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT X15, XZR, #32");
        TestInst(CBGT(XZR, XZR, 32), Arm64InstructionId.CBGT_64_regs, Arm64Mnemonic.CBGT, "CBGT XZR, XZR, #32");
    }
}
