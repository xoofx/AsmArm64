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
public class Arm64InstructionFactoryTests_LSLV_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LSLV"/>.
    /// </summary>
    [TestMethod]
    public void Test_LSLV_32_dp_2src_0()
    {
        TestInst(LSLV(W0, W1, W2), asm => asm.LSLV(W0, W1, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W1, W2");
        TestInst(LSLV(W15, W1, W2), asm => asm.LSLV(W15, W1, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W1, W2");
        TestInst(LSLV(WZR, W1, W2), asm => asm.LSLV(WZR, W1, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W1, W2");
        TestInst(LSLV(W0, W16, W2), asm => asm.LSLV(W0, W16, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W16, W2");
        TestInst(LSLV(W15, W16, W2), asm => asm.LSLV(W15, W16, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W16, W2");
        TestInst(LSLV(WZR, W16, W2), asm => asm.LSLV(WZR, W16, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W16, W2");
        TestInst(LSLV(W0, WZR, W2), asm => asm.LSLV(W0, WZR, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, WZR, W2");
        TestInst(LSLV(W15, WZR, W2), asm => asm.LSLV(W15, WZR, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, WZR, W2");
        TestInst(LSLV(WZR, WZR, W2), asm => asm.LSLV(WZR, WZR, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, WZR, W2");
        TestInst(LSLV(W0, W1, W17), asm => asm.LSLV(W0, W1, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W1, W17");
        TestInst(LSLV(W15, W1, W17), asm => asm.LSLV(W15, W1, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W1, W17");
        TestInst(LSLV(WZR, W1, W17), asm => asm.LSLV(WZR, W1, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W1, W17");
        TestInst(LSLV(W0, W16, W17), asm => asm.LSLV(W0, W16, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W16, W17");
        TestInst(LSLV(W15, W16, W17), asm => asm.LSLV(W15, W16, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W16, W17");
        TestInst(LSLV(WZR, W16, W17), asm => asm.LSLV(WZR, W16, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W16, W17");
        TestInst(LSLV(W0, WZR, W17), asm => asm.LSLV(W0, WZR, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, WZR, W17");
        TestInst(LSLV(W15, WZR, W17), asm => asm.LSLV(W15, WZR, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, WZR, W17");
        TestInst(LSLV(WZR, WZR, W17), asm => asm.LSLV(WZR, WZR, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, WZR, W17");
        TestInst(LSLV(W0, W1, WZR), asm => asm.LSLV(W0, W1, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W1, WZR");
        TestInst(LSLV(W15, W1, WZR), asm => asm.LSLV(W15, W1, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W1, WZR");
        TestInst(LSLV(WZR, W1, WZR), asm => asm.LSLV(WZR, W1, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W1, WZR");
        TestInst(LSLV(W0, W16, WZR), asm => asm.LSLV(W0, W16, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W16, WZR");
        TestInst(LSLV(W15, W16, WZR), asm => asm.LSLV(W15, W16, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W16, WZR");
        TestInst(LSLV(WZR, W16, WZR), asm => asm.LSLV(WZR, W16, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W16, WZR");
        TestInst(LSLV(W0, WZR, WZR), asm => asm.LSLV(W0, WZR, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, WZR, WZR");
        TestInst(LSLV(W15, WZR, WZR), asm => asm.LSLV(W15, WZR, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, WZR, WZR");
        TestInst(LSLV(WZR, WZR, WZR), asm => asm.LSLV(WZR, WZR, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LSLV"/>.
    /// </summary>
    [TestMethod]
    public void Test_LSLV_64_dp_2src_1()
    {
        TestInst(LSLV(X0, X1, X2), asm => asm.LSLV(X0, X1, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X1, X2");
        TestInst(LSLV(X15, X1, X2), asm => asm.LSLV(X15, X1, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X1, X2");
        TestInst(LSLV(XZR, X1, X2), asm => asm.LSLV(XZR, X1, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X1, X2");
        TestInst(LSLV(X0, X16, X2), asm => asm.LSLV(X0, X16, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X16, X2");
        TestInst(LSLV(X15, X16, X2), asm => asm.LSLV(X15, X16, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X16, X2");
        TestInst(LSLV(XZR, X16, X2), asm => asm.LSLV(XZR, X16, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X16, X2");
        TestInst(LSLV(X0, XZR, X2), asm => asm.LSLV(X0, XZR, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, XZR, X2");
        TestInst(LSLV(X15, XZR, X2), asm => asm.LSLV(X15, XZR, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, XZR, X2");
        TestInst(LSLV(XZR, XZR, X2), asm => asm.LSLV(XZR, XZR, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, XZR, X2");
        TestInst(LSLV(X0, X1, X17), asm => asm.LSLV(X0, X1, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X1, X17");
        TestInst(LSLV(X15, X1, X17), asm => asm.LSLV(X15, X1, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X1, X17");
        TestInst(LSLV(XZR, X1, X17), asm => asm.LSLV(XZR, X1, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X1, X17");
        TestInst(LSLV(X0, X16, X17), asm => asm.LSLV(X0, X16, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X16, X17");
        TestInst(LSLV(X15, X16, X17), asm => asm.LSLV(X15, X16, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X16, X17");
        TestInst(LSLV(XZR, X16, X17), asm => asm.LSLV(XZR, X16, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X16, X17");
        TestInst(LSLV(X0, XZR, X17), asm => asm.LSLV(X0, XZR, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, XZR, X17");
        TestInst(LSLV(X15, XZR, X17), asm => asm.LSLV(X15, XZR, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, XZR, X17");
        TestInst(LSLV(XZR, XZR, X17), asm => asm.LSLV(XZR, XZR, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, XZR, X17");
        TestInst(LSLV(X0, X1, XZR), asm => asm.LSLV(X0, X1, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X1, XZR");
        TestInst(LSLV(X15, X1, XZR), asm => asm.LSLV(X15, X1, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X1, XZR");
        TestInst(LSLV(XZR, X1, XZR), asm => asm.LSLV(XZR, X1, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X1, XZR");
        TestInst(LSLV(X0, X16, XZR), asm => asm.LSLV(X0, X16, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X16, XZR");
        TestInst(LSLV(X15, X16, XZR), asm => asm.LSLV(X15, X16, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X16, XZR");
        TestInst(LSLV(XZR, X16, XZR), asm => asm.LSLV(XZR, X16, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X16, XZR");
        TestInst(LSLV(X0, XZR, XZR), asm => asm.LSLV(X0, XZR, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, XZR, XZR");
        TestInst(LSLV(X15, XZR, XZR), asm => asm.LSLV(X15, XZR, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, XZR, XZR");
        TestInst(LSLV(XZR, XZR, XZR), asm => asm.LSLV(XZR, XZR, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, XZR, XZR");
    }
}
