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
public class Arm64InstructionFactoryTests_STRB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STRB_32b_ldst_regoff_0()
    {
        TestInst(STRB(W0, _[X2, X3, _LSL, 0]), asm => asm.STRB(W0, _[X2, X3, _LSL, 0]), Arm64InstructionId.STRB_32bl_ldst_regoff, Arm64Mnemonic.STRB, "STRB W0, [X2, X3, LSL #0]");
        TestInst(STRB(W15, _[X2, X3, _LSL, 0]), asm => asm.STRB(W15, _[X2, X3, _LSL, 0]), Arm64InstructionId.STRB_32bl_ldst_regoff, Arm64Mnemonic.STRB, "STRB W15, [X2, X3, LSL #0]");
        TestInst(STRB(WZR, _[X2, X3, _LSL, 0]), asm => asm.STRB(WZR, _[X2, X3, _LSL, 0]), Arm64InstructionId.STRB_32bl_ldst_regoff, Arm64Mnemonic.STRB, "STRB WZR, [X2, X3, LSL #0]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STRB_32b_ldst_regoff_1()
    {
        TestInst(STRB(W0, _[X2, W3, _UXTW, 0]), asm => asm.STRB(W0, _[X2, W3, _UXTW, 0]), Arm64InstructionId.STRB_32b_ldst_regoff, Arm64Mnemonic.STRB, "STRB W0, [X2, W3, UXTW #0]");
        TestInst(STRB(W15, _[X2, W3, _UXTW, 0]), asm => asm.STRB(W15, _[X2, W3, _UXTW, 0]), Arm64InstructionId.STRB_32b_ldst_regoff, Arm64Mnemonic.STRB, "STRB W15, [X2, W3, UXTW #0]");
        TestInst(STRB(WZR, _[X2, W3, _UXTW, 0]), asm => asm.STRB(WZR, _[X2, W3, _UXTW, 0]), Arm64InstructionId.STRB_32b_ldst_regoff, Arm64Mnemonic.STRB, "STRB WZR, [X2, W3, UXTW #0]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STRB_32_ldst_immpost_2()
    {
        TestInst(STRB(W0, _[X2], 5), asm => asm.STRB(W0, _[X2], 5), Arm64InstructionId.STRB_32_ldst_immpost, Arm64Mnemonic.STRB, "STRB W0, [X2], #5");
        TestInst(STRB(W15, _[X2], 5), asm => asm.STRB(W15, _[X2], 5), Arm64InstructionId.STRB_32_ldst_immpost, Arm64Mnemonic.STRB, "STRB W15, [X2], #5");
        TestInst(STRB(WZR, _[X2], 5), asm => asm.STRB(WZR, _[X2], 5), Arm64InstructionId.STRB_32_ldst_immpost, Arm64Mnemonic.STRB, "STRB WZR, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STRB_32_ldst_immpre_3()
    {
        TestInst(STRB(W0, _[X2, 5].Pre), asm => asm.STRB(W0, _[X2, 5].Pre), Arm64InstructionId.STRB_32_ldst_immpre, Arm64Mnemonic.STRB, "STRB W0, [X2, #5]!");
        TestInst(STRB(W15, _[X2, 5].Pre), asm => asm.STRB(W15, _[X2, 5].Pre), Arm64InstructionId.STRB_32_ldst_immpre, Arm64Mnemonic.STRB, "STRB W15, [X2, #5]!");
        TestInst(STRB(WZR, _[X2, 5].Pre), asm => asm.STRB(WZR, _[X2, 5].Pre), Arm64InstructionId.STRB_32_ldst_immpre, Arm64Mnemonic.STRB, "STRB WZR, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STRB_32_ldst_pos_4()
    {
        TestInst(STRB(W0, _[X2, 5]), asm => asm.STRB(W0, _[X2, 5]), Arm64InstructionId.STRB_32_ldst_pos, Arm64Mnemonic.STRB, "STRB W0, [X2, #5]");
        TestInst(STRB(W15, _[X2, 5]), asm => asm.STRB(W15, _[X2, 5]), Arm64InstructionId.STRB_32_ldst_pos, Arm64Mnemonic.STRB, "STRB W15, [X2, #5]");
        TestInst(STRB(WZR, _[X2, 5]), asm => asm.STRB(WZR, _[X2, 5]), Arm64InstructionId.STRB_32_ldst_pos, Arm64Mnemonic.STRB, "STRB WZR, [X2, #5]");
    }
}
