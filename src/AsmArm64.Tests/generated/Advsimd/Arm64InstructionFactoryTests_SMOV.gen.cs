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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_SMOV_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMOV_asimdins_w_w_0()
    {
        TestInst(SMOV(W0, V1.B[0]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W0, V1.B[0]");
        TestInst(SMOV(W15, V1.B[0]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W15, V1.B[0]");
        TestInst(SMOV(WZR, V1.B[0]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV WZR, V1.B[0]");
        TestInst(SMOV(W0, V31.B[1]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W0, V31.B[1]");
        TestInst(SMOV(W15, V31.B[1]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W15, V31.B[1]");
        TestInst(SMOV(WZR, V31.B[1]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV WZR, V31.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMOV_asimdins_w_w_1()
    {
        TestInst(SMOV(W0, V1.H[0]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W0, V1.H[0]");
        TestInst(SMOV(W15, V1.H[0]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W15, V1.H[0]");
        TestInst(SMOV(WZR, V1.H[0]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV WZR, V1.H[0]");
        TestInst(SMOV(W0, V31.H[1]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W0, V31.H[1]");
        TestInst(SMOV(W15, V31.H[1]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV W15, V31.H[1]");
        TestInst(SMOV(WZR, V31.H[1]), Arm64InstructionId.SMOV_asimdins_w_w, Arm64Mnemonic.SMOV, "SMOV WZR, V31.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMOV_asimdins_x_x_2()
    {
        TestInst(SMOV(X0, V1.B[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X0, V1.B[0]");
        TestInst(SMOV(X15, V1.B[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X15, V1.B[0]");
        TestInst(SMOV(XZR, V1.B[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV XZR, V1.B[0]");
        TestInst(SMOV(X0, V31.B[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X0, V31.B[1]");
        TestInst(SMOV(X15, V31.B[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X15, V31.B[1]");
        TestInst(SMOV(XZR, V31.B[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV XZR, V31.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMOV_asimdins_x_x_3()
    {
        TestInst(SMOV(X0, V1.H[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X0, V1.H[0]");
        TestInst(SMOV(X15, V1.H[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X15, V1.H[0]");
        TestInst(SMOV(XZR, V1.H[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV XZR, V1.H[0]");
        TestInst(SMOV(X0, V31.H[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X0, V31.H[1]");
        TestInst(SMOV(X15, V31.H[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X15, V31.H[1]");
        TestInst(SMOV(XZR, V31.H[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV XZR, V31.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMOV_asimdins_x_x_4()
    {
        TestInst(SMOV(X0, V1.S[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X0, V1.S[0]");
        TestInst(SMOV(X15, V1.S[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X15, V1.S[0]");
        TestInst(SMOV(XZR, V1.S[0]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV XZR, V1.S[0]");
        TestInst(SMOV(X0, V31.S[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X0, V31.S[1]");
        TestInst(SMOV(X15, V31.S[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV X15, V31.S[1]");
        TestInst(SMOV(XZR, V31.S[1]), Arm64InstructionId.SMOV_asimdins_x_x, Arm64Mnemonic.SMOV, "SMOV XZR, V31.S[1]");
    }
}
