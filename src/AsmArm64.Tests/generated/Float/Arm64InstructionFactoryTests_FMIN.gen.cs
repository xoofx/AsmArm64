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
public class Arm64InstructionFactoryTests_FMIN_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_h_floatdp2_0()
    {
        TestInst(FMIN(H0, H1, H2), asm => asm.FMIN(H0, H1, H2), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H0, H1, H2");
        TestInst(FMIN(H31, H1, H2), asm => asm.FMIN(H31, H1, H2), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H31, H1, H2");
        TestInst(FMIN(H0, H31, H2), asm => asm.FMIN(H0, H31, H2), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H0, H31, H2");
        TestInst(FMIN(H31, H31, H2), asm => asm.FMIN(H31, H31, H2), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H31, H31, H2");
        TestInst(FMIN(H0, H1, H31), asm => asm.FMIN(H0, H1, H31), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H0, H1, H31");
        TestInst(FMIN(H31, H1, H31), asm => asm.FMIN(H31, H1, H31), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H31, H1, H31");
        TestInst(FMIN(H0, H31, H31), asm => asm.FMIN(H0, H31, H31), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H0, H31, H31");
        TestInst(FMIN(H31, H31, H31), asm => asm.FMIN(H31, H31, H31), Arm64InstructionId.FMIN_h_floatdp2, Arm64Mnemonic.FMIN, "FMIN H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_s_floatdp2_1()
    {
        TestInst(FMIN(S0, S1, S2), asm => asm.FMIN(S0, S1, S2), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S0, S1, S2");
        TestInst(FMIN(S31, S1, S2), asm => asm.FMIN(S31, S1, S2), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S31, S1, S2");
        TestInst(FMIN(S0, S31, S2), asm => asm.FMIN(S0, S31, S2), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S0, S31, S2");
        TestInst(FMIN(S31, S31, S2), asm => asm.FMIN(S31, S31, S2), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S31, S31, S2");
        TestInst(FMIN(S0, S1, S31), asm => asm.FMIN(S0, S1, S31), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S0, S1, S31");
        TestInst(FMIN(S31, S1, S31), asm => asm.FMIN(S31, S1, S31), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S31, S1, S31");
        TestInst(FMIN(S0, S31, S31), asm => asm.FMIN(S0, S31, S31), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S0, S31, S31");
        TestInst(FMIN(S31, S31, S31), asm => asm.FMIN(S31, S31, S31), Arm64InstructionId.FMIN_s_floatdp2, Arm64Mnemonic.FMIN, "FMIN S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMIN_d_floatdp2_2()
    {
        TestInst(FMIN(D0, D1, D2), asm => asm.FMIN(D0, D1, D2), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D0, D1, D2");
        TestInst(FMIN(D31, D1, D2), asm => asm.FMIN(D31, D1, D2), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D31, D1, D2");
        TestInst(FMIN(D0, D31, D2), asm => asm.FMIN(D0, D31, D2), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D0, D31, D2");
        TestInst(FMIN(D31, D31, D2), asm => asm.FMIN(D31, D31, D2), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D31, D31, D2");
        TestInst(FMIN(D0, D1, D31), asm => asm.FMIN(D0, D1, D31), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D0, D1, D31");
        TestInst(FMIN(D31, D1, D31), asm => asm.FMIN(D31, D1, D31), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D31, D1, D31");
        TestInst(FMIN(D0, D31, D31), asm => asm.FMIN(D0, D31, D31), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D0, D31, D31");
        TestInst(FMIN(D31, D31, D31), asm => asm.FMIN(D31, D31, D31), Arm64InstructionId.FMIN_d_floatdp2, Arm64Mnemonic.FMIN, "FMIN D31, D31, D31");
    }
}
