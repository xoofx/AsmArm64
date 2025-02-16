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
public class Arm64InstructionFactoryTests_FMAXNM_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAXNM_h_floatdp2_0()
    {
        TestInst(FMAXNM(H0, H1, H2), asm => asm.FMAXNM(H0, H1, H2), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H0, H1, H2");
        TestInst(FMAXNM(H31, H1, H2), asm => asm.FMAXNM(H31, H1, H2), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H31, H1, H2");
        TestInst(FMAXNM(H0, H31, H2), asm => asm.FMAXNM(H0, H31, H2), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H0, H31, H2");
        TestInst(FMAXNM(H31, H31, H2), asm => asm.FMAXNM(H31, H31, H2), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H31, H31, H2");
        TestInst(FMAXNM(H0, H1, H31), asm => asm.FMAXNM(H0, H1, H31), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H0, H1, H31");
        TestInst(FMAXNM(H31, H1, H31), asm => asm.FMAXNM(H31, H1, H31), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H31, H1, H31");
        TestInst(FMAXNM(H0, H31, H31), asm => asm.FMAXNM(H0, H31, H31), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H0, H31, H31");
        TestInst(FMAXNM(H31, H31, H31), asm => asm.FMAXNM(H31, H31, H31), Arm64InstructionId.FMAXNM_h_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAXNM_s_floatdp2_1()
    {
        TestInst(FMAXNM(S0, S1, S2), asm => asm.FMAXNM(S0, S1, S2), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S0, S1, S2");
        TestInst(FMAXNM(S31, S1, S2), asm => asm.FMAXNM(S31, S1, S2), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S31, S1, S2");
        TestInst(FMAXNM(S0, S31, S2), asm => asm.FMAXNM(S0, S31, S2), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S0, S31, S2");
        TestInst(FMAXNM(S31, S31, S2), asm => asm.FMAXNM(S31, S31, S2), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S31, S31, S2");
        TestInst(FMAXNM(S0, S1, S31), asm => asm.FMAXNM(S0, S1, S31), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S0, S1, S31");
        TestInst(FMAXNM(S31, S1, S31), asm => asm.FMAXNM(S31, S1, S31), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S31, S1, S31");
        TestInst(FMAXNM(S0, S31, S31), asm => asm.FMAXNM(S0, S31, S31), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S0, S31, S31");
        TestInst(FMAXNM(S31, S31, S31), asm => asm.FMAXNM(S31, S31, S31), Arm64InstructionId.FMAXNM_s_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMAXNM_d_floatdp2_2()
    {
        TestInst(FMAXNM(D0, D1, D2), asm => asm.FMAXNM(D0, D1, D2), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D0, D1, D2");
        TestInst(FMAXNM(D31, D1, D2), asm => asm.FMAXNM(D31, D1, D2), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D31, D1, D2");
        TestInst(FMAXNM(D0, D31, D2), asm => asm.FMAXNM(D0, D31, D2), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D0, D31, D2");
        TestInst(FMAXNM(D31, D31, D2), asm => asm.FMAXNM(D31, D31, D2), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D31, D31, D2");
        TestInst(FMAXNM(D0, D1, D31), asm => asm.FMAXNM(D0, D1, D31), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D0, D1, D31");
        TestInst(FMAXNM(D31, D1, D31), asm => asm.FMAXNM(D31, D1, D31), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D31, D1, D31");
        TestInst(FMAXNM(D0, D31, D31), asm => asm.FMAXNM(D0, D31, D31), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D0, D31, D31");
        TestInst(FMAXNM(D31, D31, D31), asm => asm.FMAXNM(D31, D31, D31), Arm64InstructionId.FMAXNM_d_floatdp2, Arm64Mnemonic.FMAXNM, "FMAXNM D31, D31, D31");
    }
}
