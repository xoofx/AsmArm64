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
public class Arm64InstructionFactoryTests_FNMADD_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMADD_h_floatdp3_0()
    {
        TestInst(FNMADD(H0, H1, H2, H3), asm => asm.FNMADD(H0, H1, H2, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H1, H2, H3");
        TestInst(FNMADD(H31, H1, H2, H3), asm => asm.FNMADD(H31, H1, H2, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H1, H2, H3");
        TestInst(FNMADD(H0, H31, H2, H3), asm => asm.FNMADD(H0, H31, H2, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H31, H2, H3");
        TestInst(FNMADD(H31, H31, H2, H3), asm => asm.FNMADD(H31, H31, H2, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H31, H2, H3");
        TestInst(FNMADD(H0, H1, H31, H3), asm => asm.FNMADD(H0, H1, H31, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H1, H31, H3");
        TestInst(FNMADD(H31, H1, H31, H3), asm => asm.FNMADD(H31, H1, H31, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H1, H31, H3");
        TestInst(FNMADD(H0, H31, H31, H3), asm => asm.FNMADD(H0, H31, H31, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H31, H31, H3");
        TestInst(FNMADD(H31, H31, H31, H3), asm => asm.FNMADD(H31, H31, H31, H3), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H31, H31, H3");
        TestInst(FNMADD(H0, H1, H2, H31), asm => asm.FNMADD(H0, H1, H2, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H1, H2, H31");
        TestInst(FNMADD(H31, H1, H2, H31), asm => asm.FNMADD(H31, H1, H2, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H1, H2, H31");
        TestInst(FNMADD(H0, H31, H2, H31), asm => asm.FNMADD(H0, H31, H2, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H31, H2, H31");
        TestInst(FNMADD(H31, H31, H2, H31), asm => asm.FNMADD(H31, H31, H2, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H31, H2, H31");
        TestInst(FNMADD(H0, H1, H31, H31), asm => asm.FNMADD(H0, H1, H31, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H1, H31, H31");
        TestInst(FNMADD(H31, H1, H31, H31), asm => asm.FNMADD(H31, H1, H31, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H1, H31, H31");
        TestInst(FNMADD(H0, H31, H31, H31), asm => asm.FNMADD(H0, H31, H31, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H0, H31, H31, H31");
        TestInst(FNMADD(H31, H31, H31, H31), asm => asm.FNMADD(H31, H31, H31, H31), Arm64InstructionId.FNMADD_h_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD H31, H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMADD_s_floatdp3_1()
    {
        TestInst(FNMADD(S0, S1, S2, S3), asm => asm.FNMADD(S0, S1, S2, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S1, S2, S3");
        TestInst(FNMADD(S31, S1, S2, S3), asm => asm.FNMADD(S31, S1, S2, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S1, S2, S3");
        TestInst(FNMADD(S0, S31, S2, S3), asm => asm.FNMADD(S0, S31, S2, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S31, S2, S3");
        TestInst(FNMADD(S31, S31, S2, S3), asm => asm.FNMADD(S31, S31, S2, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S31, S2, S3");
        TestInst(FNMADD(S0, S1, S31, S3), asm => asm.FNMADD(S0, S1, S31, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S1, S31, S3");
        TestInst(FNMADD(S31, S1, S31, S3), asm => asm.FNMADD(S31, S1, S31, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S1, S31, S3");
        TestInst(FNMADD(S0, S31, S31, S3), asm => asm.FNMADD(S0, S31, S31, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S31, S31, S3");
        TestInst(FNMADD(S31, S31, S31, S3), asm => asm.FNMADD(S31, S31, S31, S3), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S31, S31, S3");
        TestInst(FNMADD(S0, S1, S2, S31), asm => asm.FNMADD(S0, S1, S2, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S1, S2, S31");
        TestInst(FNMADD(S31, S1, S2, S31), asm => asm.FNMADD(S31, S1, S2, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S1, S2, S31");
        TestInst(FNMADD(S0, S31, S2, S31), asm => asm.FNMADD(S0, S31, S2, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S31, S2, S31");
        TestInst(FNMADD(S31, S31, S2, S31), asm => asm.FNMADD(S31, S31, S2, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S31, S2, S31");
        TestInst(FNMADD(S0, S1, S31, S31), asm => asm.FNMADD(S0, S1, S31, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S1, S31, S31");
        TestInst(FNMADD(S31, S1, S31, S31), asm => asm.FNMADD(S31, S1, S31, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S1, S31, S31");
        TestInst(FNMADD(S0, S31, S31, S31), asm => asm.FNMADD(S0, S31, S31, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S0, S31, S31, S31");
        TestInst(FNMADD(S31, S31, S31, S31), asm => asm.FNMADD(S31, S31, S31, S31), Arm64InstructionId.FNMADD_s_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD S31, S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FNMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FNMADD_d_floatdp3_2()
    {
        TestInst(FNMADD(D0, D1, D2, D3), asm => asm.FNMADD(D0, D1, D2, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D1, D2, D3");
        TestInst(FNMADD(D31, D1, D2, D3), asm => asm.FNMADD(D31, D1, D2, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D1, D2, D3");
        TestInst(FNMADD(D0, D31, D2, D3), asm => asm.FNMADD(D0, D31, D2, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D31, D2, D3");
        TestInst(FNMADD(D31, D31, D2, D3), asm => asm.FNMADD(D31, D31, D2, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D31, D2, D3");
        TestInst(FNMADD(D0, D1, D31, D3), asm => asm.FNMADD(D0, D1, D31, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D1, D31, D3");
        TestInst(FNMADD(D31, D1, D31, D3), asm => asm.FNMADD(D31, D1, D31, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D1, D31, D3");
        TestInst(FNMADD(D0, D31, D31, D3), asm => asm.FNMADD(D0, D31, D31, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D31, D31, D3");
        TestInst(FNMADD(D31, D31, D31, D3), asm => asm.FNMADD(D31, D31, D31, D3), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D31, D31, D3");
        TestInst(FNMADD(D0, D1, D2, D31), asm => asm.FNMADD(D0, D1, D2, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D1, D2, D31");
        TestInst(FNMADD(D31, D1, D2, D31), asm => asm.FNMADD(D31, D1, D2, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D1, D2, D31");
        TestInst(FNMADD(D0, D31, D2, D31), asm => asm.FNMADD(D0, D31, D2, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D31, D2, D31");
        TestInst(FNMADD(D31, D31, D2, D31), asm => asm.FNMADD(D31, D31, D2, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D31, D2, D31");
        TestInst(FNMADD(D0, D1, D31, D31), asm => asm.FNMADD(D0, D1, D31, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D1, D31, D31");
        TestInst(FNMADD(D31, D1, D31, D31), asm => asm.FNMADD(D31, D1, D31, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D1, D31, D31");
        TestInst(FNMADD(D0, D31, D31, D31), asm => asm.FNMADD(D0, D31, D31, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D0, D31, D31, D31");
        TestInst(FNMADD(D31, D31, D31, D31), asm => asm.FNMADD(D31, D31, D31, D31), Arm64InstructionId.FNMADD_d_floatdp3, Arm64Mnemonic.FNMADD, "FNMADD D31, D31, D31, D31");
    }
}
