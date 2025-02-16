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
public class Arm64InstructionFactoryTests_UMAX_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAX_32u_minmax_imm_0()
    {
        TestInst(UMAX(W0, W1, 5), asm => asm.UMAX(W0, W1, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX W0, W1, #5");
        TestInst(UMAX(W15, W1, 5), asm => asm.UMAX(W15, W1, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX W15, W1, #5");
        TestInst(UMAX(WZR, W1, 5), asm => asm.UMAX(WZR, W1, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX WZR, W1, #5");
        TestInst(UMAX(W0, W16, 5), asm => asm.UMAX(W0, W16, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX W0, W16, #5");
        TestInst(UMAX(W15, W16, 5), asm => asm.UMAX(W15, W16, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX W15, W16, #5");
        TestInst(UMAX(WZR, W16, 5), asm => asm.UMAX(WZR, W16, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX WZR, W16, #5");
        TestInst(UMAX(W0, WZR, 5), asm => asm.UMAX(W0, WZR, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX W0, WZR, #5");
        TestInst(UMAX(W15, WZR, 5), asm => asm.UMAX(W15, WZR, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX W15, WZR, #5");
        TestInst(UMAX(WZR, WZR, 5), asm => asm.UMAX(WZR, WZR, 5), Arm64InstructionId.UMAX_32u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX WZR, WZR, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAX_64u_minmax_imm_1()
    {
        TestInst(UMAX(X0, X1, 5), asm => asm.UMAX(X0, X1, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX X0, X1, #5");
        TestInst(UMAX(X15, X1, 5), asm => asm.UMAX(X15, X1, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX X15, X1, #5");
        TestInst(UMAX(XZR, X1, 5), asm => asm.UMAX(XZR, X1, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX XZR, X1, #5");
        TestInst(UMAX(X0, X16, 5), asm => asm.UMAX(X0, X16, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX X0, X16, #5");
        TestInst(UMAX(X15, X16, 5), asm => asm.UMAX(X15, X16, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX X15, X16, #5");
        TestInst(UMAX(XZR, X16, 5), asm => asm.UMAX(XZR, X16, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX XZR, X16, #5");
        TestInst(UMAX(X0, XZR, 5), asm => asm.UMAX(X0, XZR, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX X0, XZR, #5");
        TestInst(UMAX(X15, XZR, 5), asm => asm.UMAX(X15, XZR, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX X15, XZR, #5");
        TestInst(UMAX(XZR, XZR, 5), asm => asm.UMAX(XZR, XZR, 5), Arm64InstructionId.UMAX_64u_minmax_imm, Arm64Mnemonic.UMAX, "UMAX XZR, XZR, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAX_32_dp_2src_2()
    {
        TestInst(UMAX(W0, W1, W2), asm => asm.UMAX(W0, W1, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, W1, W2");
        TestInst(UMAX(W15, W1, W2), asm => asm.UMAX(W15, W1, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, W1, W2");
        TestInst(UMAX(WZR, W1, W2), asm => asm.UMAX(WZR, W1, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, W1, W2");
        TestInst(UMAX(W0, W16, W2), asm => asm.UMAX(W0, W16, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, W16, W2");
        TestInst(UMAX(W15, W16, W2), asm => asm.UMAX(W15, W16, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, W16, W2");
        TestInst(UMAX(WZR, W16, W2), asm => asm.UMAX(WZR, W16, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, W16, W2");
        TestInst(UMAX(W0, WZR, W2), asm => asm.UMAX(W0, WZR, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, WZR, W2");
        TestInst(UMAX(W15, WZR, W2), asm => asm.UMAX(W15, WZR, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, WZR, W2");
        TestInst(UMAX(WZR, WZR, W2), asm => asm.UMAX(WZR, WZR, W2), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, WZR, W2");
        TestInst(UMAX(W0, W1, W17), asm => asm.UMAX(W0, W1, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, W1, W17");
        TestInst(UMAX(W15, W1, W17), asm => asm.UMAX(W15, W1, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, W1, W17");
        TestInst(UMAX(WZR, W1, W17), asm => asm.UMAX(WZR, W1, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, W1, W17");
        TestInst(UMAX(W0, W16, W17), asm => asm.UMAX(W0, W16, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, W16, W17");
        TestInst(UMAX(W15, W16, W17), asm => asm.UMAX(W15, W16, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, W16, W17");
        TestInst(UMAX(WZR, W16, W17), asm => asm.UMAX(WZR, W16, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, W16, W17");
        TestInst(UMAX(W0, WZR, W17), asm => asm.UMAX(W0, WZR, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, WZR, W17");
        TestInst(UMAX(W15, WZR, W17), asm => asm.UMAX(W15, WZR, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, WZR, W17");
        TestInst(UMAX(WZR, WZR, W17), asm => asm.UMAX(WZR, WZR, W17), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, WZR, W17");
        TestInst(UMAX(W0, W1, WZR), asm => asm.UMAX(W0, W1, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, W1, WZR");
        TestInst(UMAX(W15, W1, WZR), asm => asm.UMAX(W15, W1, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, W1, WZR");
        TestInst(UMAX(WZR, W1, WZR), asm => asm.UMAX(WZR, W1, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, W1, WZR");
        TestInst(UMAX(W0, W16, WZR), asm => asm.UMAX(W0, W16, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, W16, WZR");
        TestInst(UMAX(W15, W16, WZR), asm => asm.UMAX(W15, W16, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, W16, WZR");
        TestInst(UMAX(WZR, W16, WZR), asm => asm.UMAX(WZR, W16, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, W16, WZR");
        TestInst(UMAX(W0, WZR, WZR), asm => asm.UMAX(W0, WZR, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W0, WZR, WZR");
        TestInst(UMAX(W15, WZR, WZR), asm => asm.UMAX(W15, WZR, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX W15, WZR, WZR");
        TestInst(UMAX(WZR, WZR, WZR), asm => asm.UMAX(WZR, WZR, WZR), Arm64InstructionId.UMAX_32_dp_2src, Arm64Mnemonic.UMAX, "UMAX WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMAX_64_dp_2src_3()
    {
        TestInst(UMAX(X0, X1, X2), asm => asm.UMAX(X0, X1, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, X1, X2");
        TestInst(UMAX(X15, X1, X2), asm => asm.UMAX(X15, X1, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, X1, X2");
        TestInst(UMAX(XZR, X1, X2), asm => asm.UMAX(XZR, X1, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, X1, X2");
        TestInst(UMAX(X0, X16, X2), asm => asm.UMAX(X0, X16, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, X16, X2");
        TestInst(UMAX(X15, X16, X2), asm => asm.UMAX(X15, X16, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, X16, X2");
        TestInst(UMAX(XZR, X16, X2), asm => asm.UMAX(XZR, X16, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, X16, X2");
        TestInst(UMAX(X0, XZR, X2), asm => asm.UMAX(X0, XZR, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, XZR, X2");
        TestInst(UMAX(X15, XZR, X2), asm => asm.UMAX(X15, XZR, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, XZR, X2");
        TestInst(UMAX(XZR, XZR, X2), asm => asm.UMAX(XZR, XZR, X2), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, XZR, X2");
        TestInst(UMAX(X0, X1, X17), asm => asm.UMAX(X0, X1, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, X1, X17");
        TestInst(UMAX(X15, X1, X17), asm => asm.UMAX(X15, X1, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, X1, X17");
        TestInst(UMAX(XZR, X1, X17), asm => asm.UMAX(XZR, X1, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, X1, X17");
        TestInst(UMAX(X0, X16, X17), asm => asm.UMAX(X0, X16, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, X16, X17");
        TestInst(UMAX(X15, X16, X17), asm => asm.UMAX(X15, X16, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, X16, X17");
        TestInst(UMAX(XZR, X16, X17), asm => asm.UMAX(XZR, X16, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, X16, X17");
        TestInst(UMAX(X0, XZR, X17), asm => asm.UMAX(X0, XZR, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, XZR, X17");
        TestInst(UMAX(X15, XZR, X17), asm => asm.UMAX(X15, XZR, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, XZR, X17");
        TestInst(UMAX(XZR, XZR, X17), asm => asm.UMAX(XZR, XZR, X17), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, XZR, X17");
        TestInst(UMAX(X0, X1, XZR), asm => asm.UMAX(X0, X1, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, X1, XZR");
        TestInst(UMAX(X15, X1, XZR), asm => asm.UMAX(X15, X1, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, X1, XZR");
        TestInst(UMAX(XZR, X1, XZR), asm => asm.UMAX(XZR, X1, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, X1, XZR");
        TestInst(UMAX(X0, X16, XZR), asm => asm.UMAX(X0, X16, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, X16, XZR");
        TestInst(UMAX(X15, X16, XZR), asm => asm.UMAX(X15, X16, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, X16, XZR");
        TestInst(UMAX(XZR, X16, XZR), asm => asm.UMAX(XZR, X16, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, X16, XZR");
        TestInst(UMAX(X0, XZR, XZR), asm => asm.UMAX(X0, XZR, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X0, XZR, XZR");
        TestInst(UMAX(X15, XZR, XZR), asm => asm.UMAX(X15, XZR, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX X15, XZR, XZR");
        TestInst(UMAX(XZR, XZR, XZR), asm => asm.UMAX(XZR, XZR, XZR), Arm64InstructionId.UMAX_64_dp_2src, Arm64Mnemonic.UMAX, "UMAX XZR, XZR, XZR");
    }
}
