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
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FMAX_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAX_h_floatdp2_0()
    {
        TestInst(FMAX(H0, H1, H2), asm => asm.FMAX(H0, H1, H2), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H0, H1, H2");
        TestInst(FMAX(H31, H1, H2), asm => asm.FMAX(H31, H1, H2), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H31, H1, H2");
        TestInst(FMAX(H0, H31, H2), asm => asm.FMAX(H0, H31, H2), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H0, H31, H2");
        TestInst(FMAX(H31, H31, H2), asm => asm.FMAX(H31, H31, H2), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H31, H31, H2");
        TestInst(FMAX(H0, H1, H31), asm => asm.FMAX(H0, H1, H31), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H0, H1, H31");
        TestInst(FMAX(H31, H1, H31), asm => asm.FMAX(H31, H1, H31), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H31, H1, H31");
        TestInst(FMAX(H0, H31, H31), asm => asm.FMAX(H0, H31, H31), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H0, H31, H31");
        TestInst(FMAX(H31, H31, H31), asm => asm.FMAX(H31, H31, H31), Arm64InstructionId.FMAX_h_floatdp2, Arm64Mnemonic.FMAX, "FMAX H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAX_s_floatdp2_1()
    {
        TestInst(FMAX(S0, S1, S2), asm => asm.FMAX(S0, S1, S2), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S0, S1, S2");
        TestInst(FMAX(S31, S1, S2), asm => asm.FMAX(S31, S1, S2), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S31, S1, S2");
        TestInst(FMAX(S0, S31, S2), asm => asm.FMAX(S0, S31, S2), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S0, S31, S2");
        TestInst(FMAX(S31, S31, S2), asm => asm.FMAX(S31, S31, S2), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S31, S31, S2");
        TestInst(FMAX(S0, S1, S31), asm => asm.FMAX(S0, S1, S31), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S0, S1, S31");
        TestInst(FMAX(S31, S1, S31), asm => asm.FMAX(S31, S1, S31), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S31, S1, S31");
        TestInst(FMAX(S0, S31, S31), asm => asm.FMAX(S0, S31, S31), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S0, S31, S31");
        TestInst(FMAX(S31, S31, S31), asm => asm.FMAX(S31, S31, S31), Arm64InstructionId.FMAX_s_floatdp2, Arm64Mnemonic.FMAX, "FMAX S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAX_d_floatdp2_2()
    {
        TestInst(FMAX(D0, D1, D2), asm => asm.FMAX(D0, D1, D2), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D0, D1, D2");
        TestInst(FMAX(D31, D1, D2), asm => asm.FMAX(D31, D1, D2), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D31, D1, D2");
        TestInst(FMAX(D0, D31, D2), asm => asm.FMAX(D0, D31, D2), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D0, D31, D2");
        TestInst(FMAX(D31, D31, D2), asm => asm.FMAX(D31, D31, D2), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D31, D31, D2");
        TestInst(FMAX(D0, D1, D31), asm => asm.FMAX(D0, D1, D31), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D0, D1, D31");
        TestInst(FMAX(D31, D1, D31), asm => asm.FMAX(D31, D1, D31), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D31, D1, D31");
        TestInst(FMAX(D0, D31, D31), asm => asm.FMAX(D0, D31, D31), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D0, D31, D31");
        TestInst(FMAX(D31, D31, D31), asm => asm.FMAX(D31, D31, D31), Arm64InstructionId.FMAX_d_floatdp2, Arm64Mnemonic.FMAX, "FMAX D31, D31, D31");
    }
}
