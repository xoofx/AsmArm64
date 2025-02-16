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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FMADD_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMADD_h_floatdp3_0()
    {
        TestInst(FMADD(H0, H1, H2, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H1, H2, H3");
        TestInst(FMADD(H31, H1, H2, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H1, H2, H3");
        TestInst(FMADD(H0, H31, H2, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H31, H2, H3");
        TestInst(FMADD(H31, H31, H2, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H31, H2, H3");
        TestInst(FMADD(H0, H1, H31, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H1, H31, H3");
        TestInst(FMADD(H31, H1, H31, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H1, H31, H3");
        TestInst(FMADD(H0, H31, H31, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H31, H31, H3");
        TestInst(FMADD(H31, H31, H31, H3), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H31, H31, H3");
        TestInst(FMADD(H0, H1, H2, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H1, H2, H31");
        TestInst(FMADD(H31, H1, H2, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H1, H2, H31");
        TestInst(FMADD(H0, H31, H2, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H31, H2, H31");
        TestInst(FMADD(H31, H31, H2, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H31, H2, H31");
        TestInst(FMADD(H0, H1, H31, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H1, H31, H31");
        TestInst(FMADD(H31, H1, H31, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H1, H31, H31");
        TestInst(FMADD(H0, H31, H31, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H0, H31, H31, H31");
        TestInst(FMADD(H31, H31, H31, H31), Arm64InstructionId.FMADD_h_floatdp3, Arm64Mnemonic.FMADD, "FMADD H31, H31, H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMADD_s_floatdp3_1()
    {
        TestInst(FMADD(S0, S1, S2, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S1, S2, S3");
        TestInst(FMADD(S31, S1, S2, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S1, S2, S3");
        TestInst(FMADD(S0, S31, S2, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S31, S2, S3");
        TestInst(FMADD(S31, S31, S2, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S31, S2, S3");
        TestInst(FMADD(S0, S1, S31, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S1, S31, S3");
        TestInst(FMADD(S31, S1, S31, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S1, S31, S3");
        TestInst(FMADD(S0, S31, S31, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S31, S31, S3");
        TestInst(FMADD(S31, S31, S31, S3), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S31, S31, S3");
        TestInst(FMADD(S0, S1, S2, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S1, S2, S31");
        TestInst(FMADD(S31, S1, S2, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S1, S2, S31");
        TestInst(FMADD(S0, S31, S2, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S31, S2, S31");
        TestInst(FMADD(S31, S31, S2, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S31, S2, S31");
        TestInst(FMADD(S0, S1, S31, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S1, S31, S31");
        TestInst(FMADD(S31, S1, S31, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S1, S31, S31");
        TestInst(FMADD(S0, S31, S31, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S0, S31, S31, S31");
        TestInst(FMADD(S31, S31, S31, S31), Arm64InstructionId.FMADD_s_floatdp3, Arm64Mnemonic.FMADD, "FMADD S31, S31, S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMADD_d_floatdp3_2()
    {
        TestInst(FMADD(D0, D1, D2, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D1, D2, D3");
        TestInst(FMADD(D31, D1, D2, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D1, D2, D3");
        TestInst(FMADD(D0, D31, D2, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D31, D2, D3");
        TestInst(FMADD(D31, D31, D2, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D31, D2, D3");
        TestInst(FMADD(D0, D1, D31, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D1, D31, D3");
        TestInst(FMADD(D31, D1, D31, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D1, D31, D3");
        TestInst(FMADD(D0, D31, D31, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D31, D31, D3");
        TestInst(FMADD(D31, D31, D31, D3), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D31, D31, D3");
        TestInst(FMADD(D0, D1, D2, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D1, D2, D31");
        TestInst(FMADD(D31, D1, D2, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D1, D2, D31");
        TestInst(FMADD(D0, D31, D2, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D31, D2, D31");
        TestInst(FMADD(D31, D31, D2, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D31, D2, D31");
        TestInst(FMADD(D0, D1, D31, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D1, D31, D31");
        TestInst(FMADD(D31, D1, D31, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D1, D31, D31");
        TestInst(FMADD(D0, D31, D31, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D0, D31, D31, D31");
        TestInst(FMADD(D31, D31, D31, D31), Arm64InstructionId.FMADD_d_floatdp3, Arm64Mnemonic.FMADD, "FMADD D31, D31, D31, D31");
    }
}
