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
public class Arm64InstructionFactoryTests_LDRSH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_32_ldst_immpost_0()
    {
        TestInst(LDRSH(W0, _[X2], 5), Arm64InstructionId.LDRSH_32_ldst_immpost, Arm64Mnemonic.LDRSH, "LDRSH W0, [X2], #5");
        TestInst(LDRSH(W15, _[X2], 5), Arm64InstructionId.LDRSH_32_ldst_immpost, Arm64Mnemonic.LDRSH, "LDRSH W15, [X2], #5");
        TestInst(LDRSH(WZR, _[X2], 5), Arm64InstructionId.LDRSH_32_ldst_immpost, Arm64Mnemonic.LDRSH, "LDRSH WZR, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_64_ldst_immpost_1()
    {
        TestInst(LDRSH(X0, _[X2], 5), Arm64InstructionId.LDRSH_64_ldst_immpost, Arm64Mnemonic.LDRSH, "LDRSH X0, [X2], #5");
        TestInst(LDRSH(X15, _[X2], 5), Arm64InstructionId.LDRSH_64_ldst_immpost, Arm64Mnemonic.LDRSH, "LDRSH X15, [X2], #5");
        TestInst(LDRSH(XZR, _[X2], 5), Arm64InstructionId.LDRSH_64_ldst_immpost, Arm64Mnemonic.LDRSH, "LDRSH XZR, [X2], #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_32_ldst_immpre_2()
    {
        TestInst(LDRSH(W0, _[X2, 5].Pre), Arm64InstructionId.LDRSH_32_ldst_immpre, Arm64Mnemonic.LDRSH, "LDRSH W0, [X2, #5]!");
        TestInst(LDRSH(W15, _[X2, 5].Pre), Arm64InstructionId.LDRSH_32_ldst_immpre, Arm64Mnemonic.LDRSH, "LDRSH W15, [X2, #5]!");
        TestInst(LDRSH(WZR, _[X2, 5].Pre), Arm64InstructionId.LDRSH_32_ldst_immpre, Arm64Mnemonic.LDRSH, "LDRSH WZR, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_64_ldst_immpre_3()
    {
        TestInst(LDRSH(X0, _[X2, 5].Pre), Arm64InstructionId.LDRSH_64_ldst_immpre, Arm64Mnemonic.LDRSH, "LDRSH X0, [X2, #5]!");
        TestInst(LDRSH(X15, _[X2, 5].Pre), Arm64InstructionId.LDRSH_64_ldst_immpre, Arm64Mnemonic.LDRSH, "LDRSH X15, [X2, #5]!");
        TestInst(LDRSH(XZR, _[X2, 5].Pre), Arm64InstructionId.LDRSH_64_ldst_immpre, Arm64Mnemonic.LDRSH, "LDRSH XZR, [X2, #5]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_32_ldst_pos_4()
    {
        TestInst(LDRSH(W0, _[X2, 10]), Arm64InstructionId.LDRSH_32_ldst_pos, Arm64Mnemonic.LDRSH, "LDRSH W0, [X2, #10]");
        TestInst(LDRSH(W15, _[X2, 10]), Arm64InstructionId.LDRSH_32_ldst_pos, Arm64Mnemonic.LDRSH, "LDRSH W15, [X2, #10]");
        TestInst(LDRSH(WZR, _[X2, 10]), Arm64InstructionId.LDRSH_32_ldst_pos, Arm64Mnemonic.LDRSH, "LDRSH WZR, [X2, #10]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_64_ldst_pos_5()
    {
        TestInst(LDRSH(X0, _[X2, 10]), Arm64InstructionId.LDRSH_64_ldst_pos, Arm64Mnemonic.LDRSH, "LDRSH X0, [X2, #10]");
        TestInst(LDRSH(X15, _[X2, 10]), Arm64InstructionId.LDRSH_64_ldst_pos, Arm64Mnemonic.LDRSH, "LDRSH X15, [X2, #10]");
        TestInst(LDRSH(XZR, _[X2, 10]), Arm64InstructionId.LDRSH_64_ldst_pos, Arm64Mnemonic.LDRSH, "LDRSH XZR, [X2, #10]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_32_ldst_regoff_6()
    {
        TestInst(LDRSH(W0, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDRSH_32_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH W0, [X2, X3, LSL #1]");
        TestInst(LDRSH(W15, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDRSH_32_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH W15, [X2, X3, LSL #1]");
        TestInst(LDRSH(WZR, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDRSH_32_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH WZR, [X2, X3, LSL #1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_32_ldst_regoff_7()
    {
        TestInst(LDRSH(W0, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDRSH_32_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH W0, [X2, W3, UXTW #1]");
        TestInst(LDRSH(W15, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDRSH_32_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH W15, [X2, W3, UXTW #1]");
        TestInst(LDRSH(WZR, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDRSH_32_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH WZR, [X2, W3, UXTW #1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_64_ldst_regoff_8()
    {
        TestInst(LDRSH(X0, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDRSH_64_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH X0, [X2, X3, LSL #1]");
        TestInst(LDRSH(X15, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDRSH_64_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH X15, [X2, X3, LSL #1]");
        TestInst(LDRSH(XZR, _[X2, X3, _LSL, 1]), Arm64InstructionId.LDRSH_64_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH XZR, [X2, X3, LSL #1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDRSH_64_ldst_regoff_9()
    {
        TestInst(LDRSH(X0, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDRSH_64_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH X0, [X2, W3, UXTW #1]");
        TestInst(LDRSH(X15, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDRSH_64_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH X15, [X2, W3, UXTW #1]");
        TestInst(LDRSH(XZR, _[X2, W3, _UXTW, 1]), Arm64InstructionId.LDRSH_64_ldst_regoff, Arm64Mnemonic.LDRSH, "LDRSH XZR, [X2, W3, UXTW #1]");
    }
}
