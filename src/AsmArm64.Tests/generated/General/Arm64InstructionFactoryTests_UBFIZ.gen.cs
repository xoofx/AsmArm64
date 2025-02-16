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
public class Arm64InstructionFactoryTests_UBFIZ_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UBFIZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_UBFIZ_ubfm_32m_bitfield_0()
    {
        TestInst(UBFIZ(W0, W1, 5, 1), asm => asm.UBFIZ(W0, W1, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W0, W1, #5, #1");
        TestInst(UBFIZ(W15, W1, 5, 1), asm => asm.UBFIZ(W15, W1, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W15, W1, #5, #1");
        TestInst(UBFIZ(WZR, W1, 5, 1), asm => asm.UBFIZ(WZR, W1, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ WZR, W1, #5, #1");
        TestInst(UBFIZ(W0, W16, 5, 1), asm => asm.UBFIZ(W0, W16, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W0, W16, #5, #1");
        TestInst(UBFIZ(W15, W16, 5, 1), asm => asm.UBFIZ(W15, W16, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W15, W16, #5, #1");
        TestInst(UBFIZ(WZR, W16, 5, 1), asm => asm.UBFIZ(WZR, W16, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ WZR, W16, #5, #1");
        TestInst(UBFIZ(W0, WZR, 5, 1), asm => asm.UBFIZ(W0, WZR, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W0, WZR, #5, #1");
        TestInst(UBFIZ(W15, WZR, 5, 1), asm => asm.UBFIZ(W15, WZR, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ W15, WZR, #5, #1");
        TestInst(UBFIZ(WZR, WZR, 5, 1), asm => asm.UBFIZ(WZR, WZR, 5, 1), Arm64InstructionId.UBFIZ_ubfm_32m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ WZR, WZR, #5, #1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.UBFIZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_UBFIZ_ubfm_64m_bitfield_1()
    {
        TestInst(UBFIZ(X0, X1, 5, 1), asm => asm.UBFIZ(X0, X1, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X0, X1, #5, #1");
        TestInst(UBFIZ(X15, X1, 5, 1), asm => asm.UBFIZ(X15, X1, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X15, X1, #5, #1");
        TestInst(UBFIZ(XZR, X1, 5, 1), asm => asm.UBFIZ(XZR, X1, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ XZR, X1, #5, #1");
        TestInst(UBFIZ(X0, X16, 5, 1), asm => asm.UBFIZ(X0, X16, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X0, X16, #5, #1");
        TestInst(UBFIZ(X15, X16, 5, 1), asm => asm.UBFIZ(X15, X16, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X15, X16, #5, #1");
        TestInst(UBFIZ(XZR, X16, 5, 1), asm => asm.UBFIZ(XZR, X16, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ XZR, X16, #5, #1");
        TestInst(UBFIZ(X0, XZR, 5, 1), asm => asm.UBFIZ(X0, XZR, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X0, XZR, #5, #1");
        TestInst(UBFIZ(X15, XZR, 5, 1), asm => asm.UBFIZ(X15, XZR, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ X15, XZR, #5, #1");
        TestInst(UBFIZ(XZR, XZR, 5, 1), asm => asm.UBFIZ(XZR, XZR, 5, 1), Arm64InstructionId.UBFIZ_ubfm_64m_bitfield, Arm64Mnemonic.UBFIZ, "UBFIZ XZR, XZR, #5, #1");
    }
}
