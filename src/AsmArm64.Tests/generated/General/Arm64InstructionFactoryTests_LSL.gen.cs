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
public class Arm64InstructionFactoryTests_LSL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LSL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LSL_ubfm_32m_bitfield_0()
    {
        TestInst(LSL(W0, W1, 5), asm => asm.LSL(W0, W1, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W0, W1, #5, #1");
        TestInst(LSL(W15, W1, 5), asm => asm.LSL(W15, W1, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W15, W1, #5, #1");
        TestInst(LSL(WZR, W1, 5), asm => asm.LSL(WZR, W1, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ WZR, W1, #5, #1");
        TestInst(LSL(W0, W16, 5), asm => asm.LSL(W0, W16, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W0, W16, #5, #1");
        TestInst(LSL(W15, W16, 5), asm => asm.LSL(W15, W16, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W15, W16, #5, #1");
        TestInst(LSL(WZR, W16, 5), asm => asm.LSL(WZR, W16, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ WZR, W16, #5, #1");
        TestInst(LSL(W0, WZR, 5), asm => asm.LSL(W0, WZR, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W0, WZR, #5, #1");
        TestInst(LSL(W15, WZR, 5), asm => asm.LSL(W15, WZR, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W15, WZR, #5, #1");
        TestInst(LSL(WZR, WZR, 5), asm => asm.LSL(WZR, WZR, 5), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ WZR, WZR, #5, #1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LSL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LSL_ubfm_64m_bitfield_1()
    {
        TestInst(LSL(X0, X1, 5), asm => asm.LSL(X0, X1, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X0, X1, #5, #1");
        TestInst(LSL(X15, X1, 5), asm => asm.LSL(X15, X1, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X15, X1, #5, #1");
        TestInst(LSL(XZR, X1, 5), asm => asm.LSL(XZR, X1, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ XZR, X1, #5, #1");
        TestInst(LSL(X0, X16, 5), asm => asm.LSL(X0, X16, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X0, X16, #5, #1");
        TestInst(LSL(X15, X16, 5), asm => asm.LSL(X15, X16, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X15, X16, #5, #1");
        TestInst(LSL(XZR, X16, 5), asm => asm.LSL(XZR, X16, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ XZR, X16, #5, #1");
        TestInst(LSL(X0, XZR, 5), asm => asm.LSL(X0, XZR, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X0, XZR, #5, #1");
        TestInst(LSL(X15, XZR, 5), asm => asm.LSL(X15, XZR, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X15, XZR, #5, #1");
        TestInst(LSL(XZR, XZR, 5), asm => asm.LSL(XZR, XZR, 5), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ XZR, XZR, #5, #1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LSL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LSL_lslv_32_dp_2src_2()
    {
        TestInst(LSL(W0, W1, W2), asm => asm.LSL(W0, W1, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W1, W2");
        TestInst(LSL(W15, W1, W2), asm => asm.LSL(W15, W1, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W1, W2");
        TestInst(LSL(WZR, W1, W2), asm => asm.LSL(WZR, W1, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W1, W2");
        TestInst(LSL(W0, W16, W2), asm => asm.LSL(W0, W16, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W16, W2");
        TestInst(LSL(W15, W16, W2), asm => asm.LSL(W15, W16, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W16, W2");
        TestInst(LSL(WZR, W16, W2), asm => asm.LSL(WZR, W16, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W16, W2");
        TestInst(LSL(W0, WZR, W2), asm => asm.LSL(W0, WZR, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, WZR, W2");
        TestInst(LSL(W15, WZR, W2), asm => asm.LSL(W15, WZR, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, WZR, W2");
        TestInst(LSL(WZR, WZR, W2), asm => asm.LSL(WZR, WZR, W2), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, WZR, W2");
        TestInst(LSL(W0, W1, W17), asm => asm.LSL(W0, W1, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W1, W17");
        TestInst(LSL(W15, W1, W17), asm => asm.LSL(W15, W1, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W1, W17");
        TestInst(LSL(WZR, W1, W17), asm => asm.LSL(WZR, W1, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W1, W17");
        TestInst(LSL(W0, W16, W17), asm => asm.LSL(W0, W16, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W16, W17");
        TestInst(LSL(W15, W16, W17), asm => asm.LSL(W15, W16, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W16, W17");
        TestInst(LSL(WZR, W16, W17), asm => asm.LSL(WZR, W16, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W16, W17");
        TestInst(LSL(W0, WZR, W17), asm => asm.LSL(W0, WZR, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, WZR, W17");
        TestInst(LSL(W15, WZR, W17), asm => asm.LSL(W15, WZR, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, WZR, W17");
        TestInst(LSL(WZR, WZR, W17), asm => asm.LSL(WZR, WZR, W17), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, WZR, W17");
        TestInst(LSL(W0, W1, WZR), asm => asm.LSL(W0, W1, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W1, WZR");
        TestInst(LSL(W15, W1, WZR), asm => asm.LSL(W15, W1, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W1, WZR");
        TestInst(LSL(WZR, W1, WZR), asm => asm.LSL(WZR, W1, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W1, WZR");
        TestInst(LSL(W0, W16, WZR), asm => asm.LSL(W0, W16, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, W16, WZR");
        TestInst(LSL(W15, W16, WZR), asm => asm.LSL(W15, W16, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, W16, WZR");
        TestInst(LSL(WZR, W16, WZR), asm => asm.LSL(WZR, W16, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, W16, WZR");
        TestInst(LSL(W0, WZR, WZR), asm => asm.LSL(W0, WZR, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W0, WZR, WZR");
        TestInst(LSL(W15, WZR, WZR), asm => asm.LSL(W15, WZR, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL W15, WZR, WZR");
        TestInst(LSL(WZR, WZR, WZR), asm => asm.LSL(WZR, WZR, WZR), Arm64InstructionId.LSL_lslv_32_dp_2src, Arm64Mnemonic.LSL, "LSL WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LSL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LSL_lslv_64_dp_2src_3()
    {
        TestInst(LSL(X0, X1, X2), asm => asm.LSL(X0, X1, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X1, X2");
        TestInst(LSL(X15, X1, X2), asm => asm.LSL(X15, X1, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X1, X2");
        TestInst(LSL(XZR, X1, X2), asm => asm.LSL(XZR, X1, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X1, X2");
        TestInst(LSL(X0, X16, X2), asm => asm.LSL(X0, X16, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X16, X2");
        TestInst(LSL(X15, X16, X2), asm => asm.LSL(X15, X16, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X16, X2");
        TestInst(LSL(XZR, X16, X2), asm => asm.LSL(XZR, X16, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X16, X2");
        TestInst(LSL(X0, XZR, X2), asm => asm.LSL(X0, XZR, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, XZR, X2");
        TestInst(LSL(X15, XZR, X2), asm => asm.LSL(X15, XZR, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, XZR, X2");
        TestInst(LSL(XZR, XZR, X2), asm => asm.LSL(XZR, XZR, X2), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, XZR, X2");
        TestInst(LSL(X0, X1, X17), asm => asm.LSL(X0, X1, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X1, X17");
        TestInst(LSL(X15, X1, X17), asm => asm.LSL(X15, X1, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X1, X17");
        TestInst(LSL(XZR, X1, X17), asm => asm.LSL(XZR, X1, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X1, X17");
        TestInst(LSL(X0, X16, X17), asm => asm.LSL(X0, X16, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X16, X17");
        TestInst(LSL(X15, X16, X17), asm => asm.LSL(X15, X16, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X16, X17");
        TestInst(LSL(XZR, X16, X17), asm => asm.LSL(XZR, X16, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X16, X17");
        TestInst(LSL(X0, XZR, X17), asm => asm.LSL(X0, XZR, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, XZR, X17");
        TestInst(LSL(X15, XZR, X17), asm => asm.LSL(X15, XZR, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, XZR, X17");
        TestInst(LSL(XZR, XZR, X17), asm => asm.LSL(XZR, XZR, X17), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, XZR, X17");
        TestInst(LSL(X0, X1, XZR), asm => asm.LSL(X0, X1, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X1, XZR");
        TestInst(LSL(X15, X1, XZR), asm => asm.LSL(X15, X1, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X1, XZR");
        TestInst(LSL(XZR, X1, XZR), asm => asm.LSL(XZR, X1, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X1, XZR");
        TestInst(LSL(X0, X16, XZR), asm => asm.LSL(X0, X16, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, X16, XZR");
        TestInst(LSL(X15, X16, XZR), asm => asm.LSL(X15, X16, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, X16, XZR");
        TestInst(LSL(XZR, X16, XZR), asm => asm.LSL(XZR, X16, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, X16, XZR");
        TestInst(LSL(X0, XZR, XZR), asm => asm.LSL(X0, XZR, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X0, XZR, XZR");
        TestInst(LSL(X15, XZR, XZR), asm => asm.LSL(X15, XZR, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL X15, XZR, XZR");
        TestInst(LSL(XZR, XZR, XZR), asm => asm.LSL(XZR, XZR, XZR), Arm64InstructionId.LSL_lslv_64_dp_2src, Arm64Mnemonic.LSL, "LSL XZR, XZR, XZR");
    }
}
