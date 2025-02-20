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
public class Arm64InstructionFactoryTests_UMIN_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMIN_32u_minmax_imm_0()
    {
        TestInst(UMIN(W0, W1, 5), asm => asm.UMIN(W0, W1, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN W0, W1, #5");
        TestInst(UMIN(W15, W1, 5), asm => asm.UMIN(W15, W1, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN W15, W1, #5");
        TestInst(UMIN(WZR, W1, 5), asm => asm.UMIN(WZR, W1, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN WZR, W1, #5");
        TestInst(UMIN(W0, W16, 5), asm => asm.UMIN(W0, W16, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN W0, W16, #5");
        TestInst(UMIN(W15, W16, 5), asm => asm.UMIN(W15, W16, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN W15, W16, #5");
        TestInst(UMIN(WZR, W16, 5), asm => asm.UMIN(WZR, W16, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN WZR, W16, #5");
        TestInst(UMIN(W0, WZR, 5), asm => asm.UMIN(W0, WZR, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN W0, WZR, #5");
        TestInst(UMIN(W15, WZR, 5), asm => asm.UMIN(W15, WZR, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN W15, WZR, #5");
        TestInst(UMIN(WZR, WZR, 5), asm => asm.UMIN(WZR, WZR, 5), Arm64InstructionId.UMIN_32u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN WZR, WZR, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMIN_64u_minmax_imm_1()
    {
        TestInst(UMIN(X0, X1, 5), asm => asm.UMIN(X0, X1, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN X0, X1, #5");
        TestInst(UMIN(X15, X1, 5), asm => asm.UMIN(X15, X1, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN X15, X1, #5");
        TestInst(UMIN(XZR, X1, 5), asm => asm.UMIN(XZR, X1, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN XZR, X1, #5");
        TestInst(UMIN(X0, X16, 5), asm => asm.UMIN(X0, X16, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN X0, X16, #5");
        TestInst(UMIN(X15, X16, 5), asm => asm.UMIN(X15, X16, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN X15, X16, #5");
        TestInst(UMIN(XZR, X16, 5), asm => asm.UMIN(XZR, X16, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN XZR, X16, #5");
        TestInst(UMIN(X0, XZR, 5), asm => asm.UMIN(X0, XZR, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN X0, XZR, #5");
        TestInst(UMIN(X15, XZR, 5), asm => asm.UMIN(X15, XZR, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN X15, XZR, #5");
        TestInst(UMIN(XZR, XZR, 5), asm => asm.UMIN(XZR, XZR, 5), Arm64InstructionId.UMIN_64u_minmax_imm, Arm64Mnemonic.UMIN, "UMIN XZR, XZR, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMIN_32_dp_2src_2()
    {
        TestInst(UMIN(W0, W1, W2), asm => asm.UMIN(W0, W1, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, W1, W2");
        TestInst(UMIN(W15, W1, W2), asm => asm.UMIN(W15, W1, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, W1, W2");
        TestInst(UMIN(WZR, W1, W2), asm => asm.UMIN(WZR, W1, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, W1, W2");
        TestInst(UMIN(W0, W16, W2), asm => asm.UMIN(W0, W16, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, W16, W2");
        TestInst(UMIN(W15, W16, W2), asm => asm.UMIN(W15, W16, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, W16, W2");
        TestInst(UMIN(WZR, W16, W2), asm => asm.UMIN(WZR, W16, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, W16, W2");
        TestInst(UMIN(W0, WZR, W2), asm => asm.UMIN(W0, WZR, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, WZR, W2");
        TestInst(UMIN(W15, WZR, W2), asm => asm.UMIN(W15, WZR, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, WZR, W2");
        TestInst(UMIN(WZR, WZR, W2), asm => asm.UMIN(WZR, WZR, W2), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, WZR, W2");
        TestInst(UMIN(W0, W1, W17), asm => asm.UMIN(W0, W1, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, W1, W17");
        TestInst(UMIN(W15, W1, W17), asm => asm.UMIN(W15, W1, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, W1, W17");
        TestInst(UMIN(WZR, W1, W17), asm => asm.UMIN(WZR, W1, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, W1, W17");
        TestInst(UMIN(W0, W16, W17), asm => asm.UMIN(W0, W16, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, W16, W17");
        TestInst(UMIN(W15, W16, W17), asm => asm.UMIN(W15, W16, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, W16, W17");
        TestInst(UMIN(WZR, W16, W17), asm => asm.UMIN(WZR, W16, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, W16, W17");
        TestInst(UMIN(W0, WZR, W17), asm => asm.UMIN(W0, WZR, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, WZR, W17");
        TestInst(UMIN(W15, WZR, W17), asm => asm.UMIN(W15, WZR, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, WZR, W17");
        TestInst(UMIN(WZR, WZR, W17), asm => asm.UMIN(WZR, WZR, W17), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, WZR, W17");
        TestInst(UMIN(W0, W1, WZR), asm => asm.UMIN(W0, W1, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, W1, WZR");
        TestInst(UMIN(W15, W1, WZR), asm => asm.UMIN(W15, W1, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, W1, WZR");
        TestInst(UMIN(WZR, W1, WZR), asm => asm.UMIN(WZR, W1, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, W1, WZR");
        TestInst(UMIN(W0, W16, WZR), asm => asm.UMIN(W0, W16, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, W16, WZR");
        TestInst(UMIN(W15, W16, WZR), asm => asm.UMIN(W15, W16, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, W16, WZR");
        TestInst(UMIN(WZR, W16, WZR), asm => asm.UMIN(WZR, W16, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, W16, WZR");
        TestInst(UMIN(W0, WZR, WZR), asm => asm.UMIN(W0, WZR, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W0, WZR, WZR");
        TestInst(UMIN(W15, WZR, WZR), asm => asm.UMIN(W15, WZR, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN W15, WZR, WZR");
        TestInst(UMIN(WZR, WZR, WZR), asm => asm.UMIN(WZR, WZR, WZR), Arm64InstructionId.UMIN_32_dp_2src, Arm64Mnemonic.UMIN, "UMIN WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_UMIN_64_dp_2src_3()
    {
        TestInst(UMIN(X0, X1, X2), asm => asm.UMIN(X0, X1, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, X1, X2");
        TestInst(UMIN(X15, X1, X2), asm => asm.UMIN(X15, X1, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, X1, X2");
        TestInst(UMIN(XZR, X1, X2), asm => asm.UMIN(XZR, X1, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, X1, X2");
        TestInst(UMIN(X0, X16, X2), asm => asm.UMIN(X0, X16, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, X16, X2");
        TestInst(UMIN(X15, X16, X2), asm => asm.UMIN(X15, X16, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, X16, X2");
        TestInst(UMIN(XZR, X16, X2), asm => asm.UMIN(XZR, X16, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, X16, X2");
        TestInst(UMIN(X0, XZR, X2), asm => asm.UMIN(X0, XZR, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, XZR, X2");
        TestInst(UMIN(X15, XZR, X2), asm => asm.UMIN(X15, XZR, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, XZR, X2");
        TestInst(UMIN(XZR, XZR, X2), asm => asm.UMIN(XZR, XZR, X2), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, XZR, X2");
        TestInst(UMIN(X0, X1, X17), asm => asm.UMIN(X0, X1, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, X1, X17");
        TestInst(UMIN(X15, X1, X17), asm => asm.UMIN(X15, X1, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, X1, X17");
        TestInst(UMIN(XZR, X1, X17), asm => asm.UMIN(XZR, X1, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, X1, X17");
        TestInst(UMIN(X0, X16, X17), asm => asm.UMIN(X0, X16, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, X16, X17");
        TestInst(UMIN(X15, X16, X17), asm => asm.UMIN(X15, X16, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, X16, X17");
        TestInst(UMIN(XZR, X16, X17), asm => asm.UMIN(XZR, X16, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, X16, X17");
        TestInst(UMIN(X0, XZR, X17), asm => asm.UMIN(X0, XZR, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, XZR, X17");
        TestInst(UMIN(X15, XZR, X17), asm => asm.UMIN(X15, XZR, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, XZR, X17");
        TestInst(UMIN(XZR, XZR, X17), asm => asm.UMIN(XZR, XZR, X17), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, XZR, X17");
        TestInst(UMIN(X0, X1, XZR), asm => asm.UMIN(X0, X1, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, X1, XZR");
        TestInst(UMIN(X15, X1, XZR), asm => asm.UMIN(X15, X1, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, X1, XZR");
        TestInst(UMIN(XZR, X1, XZR), asm => asm.UMIN(XZR, X1, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, X1, XZR");
        TestInst(UMIN(X0, X16, XZR), asm => asm.UMIN(X0, X16, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, X16, XZR");
        TestInst(UMIN(X15, X16, XZR), asm => asm.UMIN(X15, X16, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, X16, XZR");
        TestInst(UMIN(XZR, X16, XZR), asm => asm.UMIN(XZR, X16, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, X16, XZR");
        TestInst(UMIN(X0, XZR, XZR), asm => asm.UMIN(X0, XZR, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X0, XZR, XZR");
        TestInst(UMIN(X15, XZR, XZR), asm => asm.UMIN(X15, XZR, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN X15, XZR, XZR");
        TestInst(UMIN(XZR, XZR, XZR), asm => asm.UMIN(XZR, XZR, XZR), Arm64InstructionId.UMIN_64_dp_2src, Arm64Mnemonic.UMIN, "UMIN XZR, XZR, XZR");
    }
}
