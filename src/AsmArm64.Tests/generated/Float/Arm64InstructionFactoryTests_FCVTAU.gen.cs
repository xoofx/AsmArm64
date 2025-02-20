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
public class Arm64InstructionFactoryTests_FCVTAU_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_sisd_32h_0()
    {
        TestInst(FCVTAU(S0, H1), asm => asm.FCVTAU(S0, H1), Arm64InstructionId.FCVTAU_sisd_32h, Arm64Mnemonic.FCVTAU, "FCVTAU S0, H1");
        TestInst(FCVTAU(S31, H1), asm => asm.FCVTAU(S31, H1), Arm64InstructionId.FCVTAU_sisd_32h, Arm64Mnemonic.FCVTAU, "FCVTAU S31, H1");
        TestInst(FCVTAU(S0, H31), asm => asm.FCVTAU(S0, H31), Arm64InstructionId.FCVTAU_sisd_32h, Arm64Mnemonic.FCVTAU, "FCVTAU S0, H31");
        TestInst(FCVTAU(S31, H31), asm => asm.FCVTAU(S31, H31), Arm64InstructionId.FCVTAU_sisd_32h, Arm64Mnemonic.FCVTAU, "FCVTAU S31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_sisd_64h_1()
    {
        TestInst(FCVTAU(D0, H1), asm => asm.FCVTAU(D0, H1), Arm64InstructionId.FCVTAU_sisd_64h, Arm64Mnemonic.FCVTAU, "FCVTAU D0, H1");
        TestInst(FCVTAU(D31, H1), asm => asm.FCVTAU(D31, H1), Arm64InstructionId.FCVTAU_sisd_64h, Arm64Mnemonic.FCVTAU, "FCVTAU D31, H1");
        TestInst(FCVTAU(D0, H31), asm => asm.FCVTAU(D0, H31), Arm64InstructionId.FCVTAU_sisd_64h, Arm64Mnemonic.FCVTAU, "FCVTAU D0, H31");
        TestInst(FCVTAU(D31, H31), asm => asm.FCVTAU(D31, H31), Arm64InstructionId.FCVTAU_sisd_64h, Arm64Mnemonic.FCVTAU, "FCVTAU D31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_sisd_64s_2()
    {
        TestInst(FCVTAU(D0, S1), asm => asm.FCVTAU(D0, S1), Arm64InstructionId.FCVTAU_sisd_64s, Arm64Mnemonic.FCVTAU, "FCVTAU D0, S1");
        TestInst(FCVTAU(D31, S1), asm => asm.FCVTAU(D31, S1), Arm64InstructionId.FCVTAU_sisd_64s, Arm64Mnemonic.FCVTAU, "FCVTAU D31, S1");
        TestInst(FCVTAU(D0, S31), asm => asm.FCVTAU(D0, S31), Arm64InstructionId.FCVTAU_sisd_64s, Arm64Mnemonic.FCVTAU, "FCVTAU D0, S31");
        TestInst(FCVTAU(D31, S31), asm => asm.FCVTAU(D31, S31), Arm64InstructionId.FCVTAU_sisd_64s, Arm64Mnemonic.FCVTAU, "FCVTAU D31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_sisd_32d_3()
    {
        TestInst(FCVTAU(S0, D1), asm => asm.FCVTAU(S0, D1), Arm64InstructionId.FCVTAU_sisd_32d, Arm64Mnemonic.FCVTAU, "FCVTAU S0, D1");
        TestInst(FCVTAU(S31, D1), asm => asm.FCVTAU(S31, D1), Arm64InstructionId.FCVTAU_sisd_32d, Arm64Mnemonic.FCVTAU, "FCVTAU S31, D1");
        TestInst(FCVTAU(S0, D31), asm => asm.FCVTAU(S0, D31), Arm64InstructionId.FCVTAU_sisd_32d, Arm64Mnemonic.FCVTAU, "FCVTAU S0, D31");
        TestInst(FCVTAU(S31, D31), asm => asm.FCVTAU(S31, D31), Arm64InstructionId.FCVTAU_sisd_32d, Arm64Mnemonic.FCVTAU, "FCVTAU S31, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_32h_float2int_4()
    {
        TestInst(FCVTAU(W0, H1), asm => asm.FCVTAU(W0, H1), Arm64InstructionId.FCVTAU_32h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W0, H1");
        TestInst(FCVTAU(W15, H1), asm => asm.FCVTAU(W15, H1), Arm64InstructionId.FCVTAU_32h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W15, H1");
        TestInst(FCVTAU(WZR, H1), asm => asm.FCVTAU(WZR, H1), Arm64InstructionId.FCVTAU_32h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU WZR, H1");
        TestInst(FCVTAU(W0, H31), asm => asm.FCVTAU(W0, H31), Arm64InstructionId.FCVTAU_32h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W0, H31");
        TestInst(FCVTAU(W15, H31), asm => asm.FCVTAU(W15, H31), Arm64InstructionId.FCVTAU_32h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W15, H31");
        TestInst(FCVTAU(WZR, H31), asm => asm.FCVTAU(WZR, H31), Arm64InstructionId.FCVTAU_32h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU WZR, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_64h_float2int_5()
    {
        TestInst(FCVTAU(X0, H1), asm => asm.FCVTAU(X0, H1), Arm64InstructionId.FCVTAU_64h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X0, H1");
        TestInst(FCVTAU(X15, H1), asm => asm.FCVTAU(X15, H1), Arm64InstructionId.FCVTAU_64h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X15, H1");
        TestInst(FCVTAU(XZR, H1), asm => asm.FCVTAU(XZR, H1), Arm64InstructionId.FCVTAU_64h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU XZR, H1");
        TestInst(FCVTAU(X0, H31), asm => asm.FCVTAU(X0, H31), Arm64InstructionId.FCVTAU_64h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X0, H31");
        TestInst(FCVTAU(X15, H31), asm => asm.FCVTAU(X15, H31), Arm64InstructionId.FCVTAU_64h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X15, H31");
        TestInst(FCVTAU(XZR, H31), asm => asm.FCVTAU(XZR, H31), Arm64InstructionId.FCVTAU_64h_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU XZR, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_32s_float2int_6()
    {
        TestInst(FCVTAU(W0, S1), asm => asm.FCVTAU(W0, S1), Arm64InstructionId.FCVTAU_32s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W0, S1");
        TestInst(FCVTAU(W15, S1), asm => asm.FCVTAU(W15, S1), Arm64InstructionId.FCVTAU_32s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W15, S1");
        TestInst(FCVTAU(WZR, S1), asm => asm.FCVTAU(WZR, S1), Arm64InstructionId.FCVTAU_32s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU WZR, S1");
        TestInst(FCVTAU(W0, S31), asm => asm.FCVTAU(W0, S31), Arm64InstructionId.FCVTAU_32s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W0, S31");
        TestInst(FCVTAU(W15, S31), asm => asm.FCVTAU(W15, S31), Arm64InstructionId.FCVTAU_32s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W15, S31");
        TestInst(FCVTAU(WZR, S31), asm => asm.FCVTAU(WZR, S31), Arm64InstructionId.FCVTAU_32s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU WZR, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_64s_float2int_7()
    {
        TestInst(FCVTAU(X0, S1), asm => asm.FCVTAU(X0, S1), Arm64InstructionId.FCVTAU_64s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X0, S1");
        TestInst(FCVTAU(X15, S1), asm => asm.FCVTAU(X15, S1), Arm64InstructionId.FCVTAU_64s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X15, S1");
        TestInst(FCVTAU(XZR, S1), asm => asm.FCVTAU(XZR, S1), Arm64InstructionId.FCVTAU_64s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU XZR, S1");
        TestInst(FCVTAU(X0, S31), asm => asm.FCVTAU(X0, S31), Arm64InstructionId.FCVTAU_64s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X0, S31");
        TestInst(FCVTAU(X15, S31), asm => asm.FCVTAU(X15, S31), Arm64InstructionId.FCVTAU_64s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X15, S31");
        TestInst(FCVTAU(XZR, S31), asm => asm.FCVTAU(XZR, S31), Arm64InstructionId.FCVTAU_64s_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU XZR, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_32d_float2int_8()
    {
        TestInst(FCVTAU(W0, D1), asm => asm.FCVTAU(W0, D1), Arm64InstructionId.FCVTAU_32d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W0, D1");
        TestInst(FCVTAU(W15, D1), asm => asm.FCVTAU(W15, D1), Arm64InstructionId.FCVTAU_32d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W15, D1");
        TestInst(FCVTAU(WZR, D1), asm => asm.FCVTAU(WZR, D1), Arm64InstructionId.FCVTAU_32d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU WZR, D1");
        TestInst(FCVTAU(W0, D31), asm => asm.FCVTAU(W0, D31), Arm64InstructionId.FCVTAU_32d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W0, D31");
        TestInst(FCVTAU(W15, D31), asm => asm.FCVTAU(W15, D31), Arm64InstructionId.FCVTAU_32d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU W15, D31");
        TestInst(FCVTAU(WZR, D31), asm => asm.FCVTAU(WZR, D31), Arm64InstructionId.FCVTAU_32d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU WZR, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTAU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTAU_64d_float2int_9()
    {
        TestInst(FCVTAU(X0, D1), asm => asm.FCVTAU(X0, D1), Arm64InstructionId.FCVTAU_64d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X0, D1");
        TestInst(FCVTAU(X15, D1), asm => asm.FCVTAU(X15, D1), Arm64InstructionId.FCVTAU_64d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X15, D1");
        TestInst(FCVTAU(XZR, D1), asm => asm.FCVTAU(XZR, D1), Arm64InstructionId.FCVTAU_64d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU XZR, D1");
        TestInst(FCVTAU(X0, D31), asm => asm.FCVTAU(X0, D31), Arm64InstructionId.FCVTAU_64d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X0, D31");
        TestInst(FCVTAU(X15, D31), asm => asm.FCVTAU(X15, D31), Arm64InstructionId.FCVTAU_64d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU X15, D31");
        TestInst(FCVTAU(XZR, D31), asm => asm.FCVTAU(XZR, D31), Arm64InstructionId.FCVTAU_64d_float2int, Arm64Mnemonic.FCVTAU, "FCVTAU XZR, D31");
    }
}
