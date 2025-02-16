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
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FDIV_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FDIV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FDIV_h_floatdp2_0()
    {
        TestInst(FDIV(H0, H1, H2), asm => asm.FDIV(H0, H1, H2), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H0, H1, H2");
        TestInst(FDIV(H31, H1, H2), asm => asm.FDIV(H31, H1, H2), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H31, H1, H2");
        TestInst(FDIV(H0, H31, H2), asm => asm.FDIV(H0, H31, H2), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H0, H31, H2");
        TestInst(FDIV(H31, H31, H2), asm => asm.FDIV(H31, H31, H2), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H31, H31, H2");
        TestInst(FDIV(H0, H1, H31), asm => asm.FDIV(H0, H1, H31), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H0, H1, H31");
        TestInst(FDIV(H31, H1, H31), asm => asm.FDIV(H31, H1, H31), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H31, H1, H31");
        TestInst(FDIV(H0, H31, H31), asm => asm.FDIV(H0, H31, H31), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H0, H31, H31");
        TestInst(FDIV(H31, H31, H31), asm => asm.FDIV(H31, H31, H31), Arm64InstructionId.FDIV_h_floatdp2, Arm64Mnemonic.FDIV, "FDIV H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FDIV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FDIV_s_floatdp2_1()
    {
        TestInst(FDIV(S0, S1, S2), asm => asm.FDIV(S0, S1, S2), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S0, S1, S2");
        TestInst(FDIV(S31, S1, S2), asm => asm.FDIV(S31, S1, S2), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S31, S1, S2");
        TestInst(FDIV(S0, S31, S2), asm => asm.FDIV(S0, S31, S2), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S0, S31, S2");
        TestInst(FDIV(S31, S31, S2), asm => asm.FDIV(S31, S31, S2), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S31, S31, S2");
        TestInst(FDIV(S0, S1, S31), asm => asm.FDIV(S0, S1, S31), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S0, S1, S31");
        TestInst(FDIV(S31, S1, S31), asm => asm.FDIV(S31, S1, S31), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S31, S1, S31");
        TestInst(FDIV(S0, S31, S31), asm => asm.FDIV(S0, S31, S31), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S0, S31, S31");
        TestInst(FDIV(S31, S31, S31), asm => asm.FDIV(S31, S31, S31), Arm64InstructionId.FDIV_s_floatdp2, Arm64Mnemonic.FDIV, "FDIV S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FDIV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FDIV_d_floatdp2_2()
    {
        TestInst(FDIV(D0, D1, D2), asm => asm.FDIV(D0, D1, D2), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D0, D1, D2");
        TestInst(FDIV(D31, D1, D2), asm => asm.FDIV(D31, D1, D2), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D31, D1, D2");
        TestInst(FDIV(D0, D31, D2), asm => asm.FDIV(D0, D31, D2), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D0, D31, D2");
        TestInst(FDIV(D31, D31, D2), asm => asm.FDIV(D31, D31, D2), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D31, D31, D2");
        TestInst(FDIV(D0, D1, D31), asm => asm.FDIV(D0, D1, D31), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D0, D1, D31");
        TestInst(FDIV(D31, D1, D31), asm => asm.FDIV(D31, D1, D31), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D31, D1, D31");
        TestInst(FDIV(D0, D31, D31), asm => asm.FDIV(D0, D31, D31), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D0, D31, D31");
        TestInst(FDIV(D31, D31, D31), asm => asm.FDIV(D31, D31, D31), Arm64InstructionId.FDIV_d_floatdp2, Arm64Mnemonic.FDIV, "FDIV D31, D31, D31");
    }
}
