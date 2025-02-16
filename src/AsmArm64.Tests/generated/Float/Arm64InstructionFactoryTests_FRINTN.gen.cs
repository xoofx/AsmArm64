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
public class Arm64InstructionFactoryTests_FRINTN_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTN_h_floatdp1_0()
    {
        TestInst(FRINTN(H0, H1), asm => asm.FRINTN(H0, H1), Arm64InstructionId.FRINTN_h_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN H0, H1");
        TestInst(FRINTN(H31, H1), asm => asm.FRINTN(H31, H1), Arm64InstructionId.FRINTN_h_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN H31, H1");
        TestInst(FRINTN(H0, H31), asm => asm.FRINTN(H0, H31), Arm64InstructionId.FRINTN_h_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN H0, H31");
        TestInst(FRINTN(H31, H31), asm => asm.FRINTN(H31, H31), Arm64InstructionId.FRINTN_h_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTN_s_floatdp1_1()
    {
        TestInst(FRINTN(S0, S1), asm => asm.FRINTN(S0, S1), Arm64InstructionId.FRINTN_s_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN S0, S1");
        TestInst(FRINTN(S31, S1), asm => asm.FRINTN(S31, S1), Arm64InstructionId.FRINTN_s_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN S31, S1");
        TestInst(FRINTN(S0, S31), asm => asm.FRINTN(S0, S31), Arm64InstructionId.FRINTN_s_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN S0, S31");
        TestInst(FRINTN(S31, S31), asm => asm.FRINTN(S31, S31), Arm64InstructionId.FRINTN_s_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINTN_d_floatdp1_2()
    {
        TestInst(FRINTN(D0, D1), asm => asm.FRINTN(D0, D1), Arm64InstructionId.FRINTN_d_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN D0, D1");
        TestInst(FRINTN(D31, D1), asm => asm.FRINTN(D31, D1), Arm64InstructionId.FRINTN_d_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN D31, D1");
        TestInst(FRINTN(D0, D31), asm => asm.FRINTN(D0, D31), Arm64InstructionId.FRINTN_d_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN D0, D31");
        TestInst(FRINTN(D31, D31), asm => asm.FRINTN(D31, D31), Arm64InstructionId.FRINTN_d_floatdp1, Arm64Mnemonic.FRINTN, "FRINTN D31, D31");
    }
}
