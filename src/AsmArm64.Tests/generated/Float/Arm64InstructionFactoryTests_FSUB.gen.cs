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
public class Arm64InstructionFactoryTests_FSUB_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSUB"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSUB_h_floatdp2_0()
    {
        TestInst(FSUB(H0, H1, H2), asm => asm.FSUB(H0, H1, H2), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H0, H1, H2");
        TestInst(FSUB(H31, H1, H2), asm => asm.FSUB(H31, H1, H2), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H31, H1, H2");
        TestInst(FSUB(H0, H31, H2), asm => asm.FSUB(H0, H31, H2), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H0, H31, H2");
        TestInst(FSUB(H31, H31, H2), asm => asm.FSUB(H31, H31, H2), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H31, H31, H2");
        TestInst(FSUB(H0, H1, H31), asm => asm.FSUB(H0, H1, H31), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H0, H1, H31");
        TestInst(FSUB(H31, H1, H31), asm => asm.FSUB(H31, H1, H31), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H31, H1, H31");
        TestInst(FSUB(H0, H31, H31), asm => asm.FSUB(H0, H31, H31), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H0, H31, H31");
        TestInst(FSUB(H31, H31, H31), asm => asm.FSUB(H31, H31, H31), Arm64InstructionId.FSUB_h_floatdp2, Arm64Mnemonic.FSUB, "FSUB H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSUB"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSUB_s_floatdp2_1()
    {
        TestInst(FSUB(S0, S1, S2), asm => asm.FSUB(S0, S1, S2), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S0, S1, S2");
        TestInst(FSUB(S31, S1, S2), asm => asm.FSUB(S31, S1, S2), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S31, S1, S2");
        TestInst(FSUB(S0, S31, S2), asm => asm.FSUB(S0, S31, S2), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S0, S31, S2");
        TestInst(FSUB(S31, S31, S2), asm => asm.FSUB(S31, S31, S2), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S31, S31, S2");
        TestInst(FSUB(S0, S1, S31), asm => asm.FSUB(S0, S1, S31), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S0, S1, S31");
        TestInst(FSUB(S31, S1, S31), asm => asm.FSUB(S31, S1, S31), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S31, S1, S31");
        TestInst(FSUB(S0, S31, S31), asm => asm.FSUB(S0, S31, S31), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S0, S31, S31");
        TestInst(FSUB(S31, S31, S31), asm => asm.FSUB(S31, S31, S31), Arm64InstructionId.FSUB_s_floatdp2, Arm64Mnemonic.FSUB, "FSUB S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FSUB"/>.
    /// </summary>
    [TestMethod]
    public void Test_FSUB_d_floatdp2_2()
    {
        TestInst(FSUB(D0, D1, D2), asm => asm.FSUB(D0, D1, D2), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D0, D1, D2");
        TestInst(FSUB(D31, D1, D2), asm => asm.FSUB(D31, D1, D2), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D31, D1, D2");
        TestInst(FSUB(D0, D31, D2), asm => asm.FSUB(D0, D31, D2), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D0, D31, D2");
        TestInst(FSUB(D31, D31, D2), asm => asm.FSUB(D31, D31, D2), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D31, D31, D2");
        TestInst(FSUB(D0, D1, D31), asm => asm.FSUB(D0, D1, D31), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D0, D1, D31");
        TestInst(FSUB(D31, D1, D31), asm => asm.FSUB(D31, D1, D31), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D31, D1, D31");
        TestInst(FSUB(D0, D31, D31), asm => asm.FSUB(D0, D31, D31), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D0, D31, D31");
        TestInst(FSUB(D31, D31, D31), asm => asm.FSUB(D31, D31, D31), Arm64InstructionId.FSUB_d_floatdp2, Arm64Mnemonic.FSUB, "FSUB D31, D31, D31");
    }
}
