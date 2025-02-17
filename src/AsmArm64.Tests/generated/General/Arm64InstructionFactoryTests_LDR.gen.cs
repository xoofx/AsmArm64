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
public class Arm64InstructionFactoryTests_LDR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_32_ldst_immpost_0()
    {
        TestInst(LDR(W0, _[X2], 5), asm => asm.LDR(W0, _[X2], 5), Arm64InstructionId.LDR_32_ldst_immpost, Arm64Mnemonic.LDR, "LDR W0, [X2], #5");
        TestInst(LDR(W15, _[X2], 5), asm => asm.LDR(W15, _[X2], 5), Arm64InstructionId.LDR_32_ldst_immpost, Arm64Mnemonic.LDR, "LDR W15, [X2], #5");
        TestInst(LDR(WZR, _[X2], 5), asm => asm.LDR(WZR, _[X2], 5), Arm64InstructionId.LDR_32_ldst_immpost, Arm64Mnemonic.LDR, "LDR WZR, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_64_ldst_immpost_1()
    {
        TestInst(LDR(X0, _[X2], 5), asm => asm.LDR(X0, _[X2], 5), Arm64InstructionId.LDR_64_ldst_immpost, Arm64Mnemonic.LDR, "LDR X0, [X2], #5");
        TestInst(LDR(X15, _[X2], 5), asm => asm.LDR(X15, _[X2], 5), Arm64InstructionId.LDR_64_ldst_immpost, Arm64Mnemonic.LDR, "LDR X15, [X2], #5");
        TestInst(LDR(XZR, _[X2], 5), asm => asm.LDR(XZR, _[X2], 5), Arm64InstructionId.LDR_64_ldst_immpost, Arm64Mnemonic.LDR, "LDR XZR, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_32_ldst_immpre_2()
    {
        TestInst(LDR(W0, _[X2, 5].Pre), asm => asm.LDR(W0, _[X2, 5].Pre), Arm64InstructionId.LDR_32_ldst_immpre, Arm64Mnemonic.LDR, "LDR W0, [X2, #5]!");
        TestInst(LDR(W15, _[X2, 5].Pre), asm => asm.LDR(W15, _[X2, 5].Pre), Arm64InstructionId.LDR_32_ldst_immpre, Arm64Mnemonic.LDR, "LDR W15, [X2, #5]!");
        TestInst(LDR(WZR, _[X2, 5].Pre), asm => asm.LDR(WZR, _[X2, 5].Pre), Arm64InstructionId.LDR_32_ldst_immpre, Arm64Mnemonic.LDR, "LDR WZR, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_64_ldst_immpre_3()
    {
        TestInst(LDR(X0, _[X2, 5].Pre), asm => asm.LDR(X0, _[X2, 5].Pre), Arm64InstructionId.LDR_64_ldst_immpre, Arm64Mnemonic.LDR, "LDR X0, [X2, #5]!");
        TestInst(LDR(X15, _[X2, 5].Pre), asm => asm.LDR(X15, _[X2, 5].Pre), Arm64InstructionId.LDR_64_ldst_immpre, Arm64Mnemonic.LDR, "LDR X15, [X2, #5]!");
        TestInst(LDR(XZR, _[X2, 5].Pre), asm => asm.LDR(XZR, _[X2, 5].Pre), Arm64InstructionId.LDR_64_ldst_immpre, Arm64Mnemonic.LDR, "LDR XZR, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_32_ldst_pos_4()
    {
        TestInst(LDR(W0, _[X2, 20]), asm => asm.LDR(W0, _[X2, 20]), Arm64InstructionId.LDR_32_ldst_pos, Arm64Mnemonic.LDR, "LDR W0, [X2, #20]");
        TestInst(LDR(W15, _[X2, 20]), asm => asm.LDR(W15, _[X2, 20]), Arm64InstructionId.LDR_32_ldst_pos, Arm64Mnemonic.LDR, "LDR W15, [X2, #20]");
        TestInst(LDR(WZR, _[X2, 20]), asm => asm.LDR(WZR, _[X2, 20]), Arm64InstructionId.LDR_32_ldst_pos, Arm64Mnemonic.LDR, "LDR WZR, [X2, #20]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_64_ldst_pos_5()
    {
        TestInst(LDR(X0, _[X2, 40]), asm => asm.LDR(X0, _[X2, 40]), Arm64InstructionId.LDR_64_ldst_pos, Arm64Mnemonic.LDR, "LDR X0, [X2, #40]");
        TestInst(LDR(X15, _[X2, 40]), asm => asm.LDR(X15, _[X2, 40]), Arm64InstructionId.LDR_64_ldst_pos, Arm64Mnemonic.LDR, "LDR X15, [X2, #40]");
        TestInst(LDR(XZR, _[X2, 40]), asm => asm.LDR(XZR, _[X2, 40]), Arm64InstructionId.LDR_64_ldst_pos, Arm64Mnemonic.LDR, "LDR XZR, [X2, #40]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_32_loadlit_6()
    {
        TestInst(LDR(W0, 32), null, Arm64InstructionId.LDR_32_loadlit, Arm64Mnemonic.LDR, "LDR W0, #32");
        TestInst(LDR(W15, 32), null, Arm64InstructionId.LDR_32_loadlit, Arm64Mnemonic.LDR, "LDR W15, #32");
        TestInst(LDR(WZR, 32), null, Arm64InstructionId.LDR_32_loadlit, Arm64Mnemonic.LDR, "LDR WZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_64_loadlit_7()
    {
        TestInst(LDR(X0, 32), null, Arm64InstructionId.LDR_64_loadlit, Arm64Mnemonic.LDR, "LDR X0, #32");
        TestInst(LDR(X15, 32), null, Arm64InstructionId.LDR_64_loadlit, Arm64Mnemonic.LDR, "LDR X15, #32");
        TestInst(LDR(XZR, 32), null, Arm64InstructionId.LDR_64_loadlit, Arm64Mnemonic.LDR, "LDR XZR, #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_32_ldst_regoff_8()
    {
        TestInst(LDR(W0, _[X2, X3, _LSL, 2]), asm => asm.LDR(W0, _[X2, X3, _LSL, 2]), Arm64InstructionId.LDR_32_ldst_regoff, Arm64Mnemonic.LDR, "LDR W0, [X2, X3, LSL #2]");
        TestInst(LDR(W15, _[X2, X3, _LSL, 2]), asm => asm.LDR(W15, _[X2, X3, _LSL, 2]), Arm64InstructionId.LDR_32_ldst_regoff, Arm64Mnemonic.LDR, "LDR W15, [X2, X3, LSL #2]");
        TestInst(LDR(WZR, _[X2, X3, _LSL, 2]), asm => asm.LDR(WZR, _[X2, X3, _LSL, 2]), Arm64InstructionId.LDR_32_ldst_regoff, Arm64Mnemonic.LDR, "LDR WZR, [X2, X3, LSL #2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_32_ldst_regoff_9()
    {
        TestInst(LDR(W0, _[X2, W3, _UXTW, 2]), asm => asm.LDR(W0, _[X2, W3, _UXTW, 2]), Arm64InstructionId.LDR_32_ldst_regoff, Arm64Mnemonic.LDR, "LDR W0, [X2, W3, UXTW #2]");
        TestInst(LDR(W15, _[X2, W3, _UXTW, 2]), asm => asm.LDR(W15, _[X2, W3, _UXTW, 2]), Arm64InstructionId.LDR_32_ldst_regoff, Arm64Mnemonic.LDR, "LDR W15, [X2, W3, UXTW #2]");
        TestInst(LDR(WZR, _[X2, W3, _UXTW, 2]), asm => asm.LDR(WZR, _[X2, W3, _UXTW, 2]), Arm64InstructionId.LDR_32_ldst_regoff, Arm64Mnemonic.LDR, "LDR WZR, [X2, W3, UXTW #2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_64_ldst_regoff_10()
    {
        TestInst(LDR(X0, _[X2, X3, _LSL, 3]), asm => asm.LDR(X0, _[X2, X3, _LSL, 3]), Arm64InstructionId.LDR_64_ldst_regoff, Arm64Mnemonic.LDR, "LDR X0, [X2, X3, LSL #3]");
        TestInst(LDR(X15, _[X2, X3, _LSL, 3]), asm => asm.LDR(X15, _[X2, X3, _LSL, 3]), Arm64InstructionId.LDR_64_ldst_regoff, Arm64Mnemonic.LDR, "LDR X15, [X2, X3, LSL #3]");
        TestInst(LDR(XZR, _[X2, X3, _LSL, 3]), asm => asm.LDR(XZR, _[X2, X3, _LSL, 3]), Arm64InstructionId.LDR_64_ldst_regoff, Arm64Mnemonic.LDR, "LDR XZR, [X2, X3, LSL #3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDR_64_ldst_regoff_11()
    {
        TestInst(LDR(X0, _[X2, W3, _UXTW, 3]), asm => asm.LDR(X0, _[X2, W3, _UXTW, 3]), Arm64InstructionId.LDR_64_ldst_regoff, Arm64Mnemonic.LDR, "LDR X0, [X2, W3, UXTW #3]");
        TestInst(LDR(X15, _[X2, W3, _UXTW, 3]), asm => asm.LDR(X15, _[X2, W3, _UXTW, 3]), Arm64InstructionId.LDR_64_ldst_regoff, Arm64Mnemonic.LDR, "LDR X15, [X2, W3, UXTW #3]");
        TestInst(LDR(XZR, _[X2, W3, _UXTW, 3]), asm => asm.LDR(XZR, _[X2, W3, _UXTW, 3]), Arm64InstructionId.LDR_64_ldst_regoff, Arm64Mnemonic.LDR, "LDR XZR, [X2, W3, UXTW #3]");
    }
}
