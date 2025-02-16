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
public class Arm64InstructionFactoryTests_FCVTPU_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_sisd_32h_0()
    {
        TestInst(FCVTPU(S0, H1), asm => asm.FCVTPU(S0, H1), Arm64InstructionId.FCVTPU_sisd_32h, Arm64Mnemonic.FCVTPU, "FCVTPU S0, H1");
        TestInst(FCVTPU(S31, H1), asm => asm.FCVTPU(S31, H1), Arm64InstructionId.FCVTPU_sisd_32h, Arm64Mnemonic.FCVTPU, "FCVTPU S31, H1");
        TestInst(FCVTPU(S0, H31), asm => asm.FCVTPU(S0, H31), Arm64InstructionId.FCVTPU_sisd_32h, Arm64Mnemonic.FCVTPU, "FCVTPU S0, H31");
        TestInst(FCVTPU(S31, H31), asm => asm.FCVTPU(S31, H31), Arm64InstructionId.FCVTPU_sisd_32h, Arm64Mnemonic.FCVTPU, "FCVTPU S31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_sisd_64h_1()
    {
        TestInst(FCVTPU(D0, H1), asm => asm.FCVTPU(D0, H1), Arm64InstructionId.FCVTPU_sisd_64h, Arm64Mnemonic.FCVTPU, "FCVTPU D0, H1");
        TestInst(FCVTPU(D31, H1), asm => asm.FCVTPU(D31, H1), Arm64InstructionId.FCVTPU_sisd_64h, Arm64Mnemonic.FCVTPU, "FCVTPU D31, H1");
        TestInst(FCVTPU(D0, H31), asm => asm.FCVTPU(D0, H31), Arm64InstructionId.FCVTPU_sisd_64h, Arm64Mnemonic.FCVTPU, "FCVTPU D0, H31");
        TestInst(FCVTPU(D31, H31), asm => asm.FCVTPU(D31, H31), Arm64InstructionId.FCVTPU_sisd_64h, Arm64Mnemonic.FCVTPU, "FCVTPU D31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_sisd_64s_2()
    {
        TestInst(FCVTPU(D0, S1), asm => asm.FCVTPU(D0, S1), Arm64InstructionId.FCVTPU_sisd_64s, Arm64Mnemonic.FCVTPU, "FCVTPU D0, S1");
        TestInst(FCVTPU(D31, S1), asm => asm.FCVTPU(D31, S1), Arm64InstructionId.FCVTPU_sisd_64s, Arm64Mnemonic.FCVTPU, "FCVTPU D31, S1");
        TestInst(FCVTPU(D0, S31), asm => asm.FCVTPU(D0, S31), Arm64InstructionId.FCVTPU_sisd_64s, Arm64Mnemonic.FCVTPU, "FCVTPU D0, S31");
        TestInst(FCVTPU(D31, S31), asm => asm.FCVTPU(D31, S31), Arm64InstructionId.FCVTPU_sisd_64s, Arm64Mnemonic.FCVTPU, "FCVTPU D31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_sisd_32d_3()
    {
        TestInst(FCVTPU(S0, D1), asm => asm.FCVTPU(S0, D1), Arm64InstructionId.FCVTPU_sisd_32d, Arm64Mnemonic.FCVTPU, "FCVTPU S0, D1");
        TestInst(FCVTPU(S31, D1), asm => asm.FCVTPU(S31, D1), Arm64InstructionId.FCVTPU_sisd_32d, Arm64Mnemonic.FCVTPU, "FCVTPU S31, D1");
        TestInst(FCVTPU(S0, D31), asm => asm.FCVTPU(S0, D31), Arm64InstructionId.FCVTPU_sisd_32d, Arm64Mnemonic.FCVTPU, "FCVTPU S0, D31");
        TestInst(FCVTPU(S31, D31), asm => asm.FCVTPU(S31, D31), Arm64InstructionId.FCVTPU_sisd_32d, Arm64Mnemonic.FCVTPU, "FCVTPU S31, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_32h_float2int_4()
    {
        TestInst(FCVTPU(W0, H1), asm => asm.FCVTPU(W0, H1), Arm64InstructionId.FCVTPU_32h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W0, H1");
        TestInst(FCVTPU(W15, H1), asm => asm.FCVTPU(W15, H1), Arm64InstructionId.FCVTPU_32h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W15, H1");
        TestInst(FCVTPU(WZR, H1), asm => asm.FCVTPU(WZR, H1), Arm64InstructionId.FCVTPU_32h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU WZR, H1");
        TestInst(FCVTPU(W0, H31), asm => asm.FCVTPU(W0, H31), Arm64InstructionId.FCVTPU_32h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W0, H31");
        TestInst(FCVTPU(W15, H31), asm => asm.FCVTPU(W15, H31), Arm64InstructionId.FCVTPU_32h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W15, H31");
        TestInst(FCVTPU(WZR, H31), asm => asm.FCVTPU(WZR, H31), Arm64InstructionId.FCVTPU_32h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU WZR, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_64h_float2int_5()
    {
        TestInst(FCVTPU(X0, H1), asm => asm.FCVTPU(X0, H1), Arm64InstructionId.FCVTPU_64h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X0, H1");
        TestInst(FCVTPU(X15, H1), asm => asm.FCVTPU(X15, H1), Arm64InstructionId.FCVTPU_64h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X15, H1");
        TestInst(FCVTPU(XZR, H1), asm => asm.FCVTPU(XZR, H1), Arm64InstructionId.FCVTPU_64h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU XZR, H1");
        TestInst(FCVTPU(X0, H31), asm => asm.FCVTPU(X0, H31), Arm64InstructionId.FCVTPU_64h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X0, H31");
        TestInst(FCVTPU(X15, H31), asm => asm.FCVTPU(X15, H31), Arm64InstructionId.FCVTPU_64h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X15, H31");
        TestInst(FCVTPU(XZR, H31), asm => asm.FCVTPU(XZR, H31), Arm64InstructionId.FCVTPU_64h_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU XZR, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_32s_float2int_6()
    {
        TestInst(FCVTPU(W0, S1), asm => asm.FCVTPU(W0, S1), Arm64InstructionId.FCVTPU_32s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W0, S1");
        TestInst(FCVTPU(W15, S1), asm => asm.FCVTPU(W15, S1), Arm64InstructionId.FCVTPU_32s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W15, S1");
        TestInst(FCVTPU(WZR, S1), asm => asm.FCVTPU(WZR, S1), Arm64InstructionId.FCVTPU_32s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU WZR, S1");
        TestInst(FCVTPU(W0, S31), asm => asm.FCVTPU(W0, S31), Arm64InstructionId.FCVTPU_32s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W0, S31");
        TestInst(FCVTPU(W15, S31), asm => asm.FCVTPU(W15, S31), Arm64InstructionId.FCVTPU_32s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W15, S31");
        TestInst(FCVTPU(WZR, S31), asm => asm.FCVTPU(WZR, S31), Arm64InstructionId.FCVTPU_32s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU WZR, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_64s_float2int_7()
    {
        TestInst(FCVTPU(X0, S1), asm => asm.FCVTPU(X0, S1), Arm64InstructionId.FCVTPU_64s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X0, S1");
        TestInst(FCVTPU(X15, S1), asm => asm.FCVTPU(X15, S1), Arm64InstructionId.FCVTPU_64s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X15, S1");
        TestInst(FCVTPU(XZR, S1), asm => asm.FCVTPU(XZR, S1), Arm64InstructionId.FCVTPU_64s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU XZR, S1");
        TestInst(FCVTPU(X0, S31), asm => asm.FCVTPU(X0, S31), Arm64InstructionId.FCVTPU_64s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X0, S31");
        TestInst(FCVTPU(X15, S31), asm => asm.FCVTPU(X15, S31), Arm64InstructionId.FCVTPU_64s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X15, S31");
        TestInst(FCVTPU(XZR, S31), asm => asm.FCVTPU(XZR, S31), Arm64InstructionId.FCVTPU_64s_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU XZR, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_32d_float2int_8()
    {
        TestInst(FCVTPU(W0, D1), asm => asm.FCVTPU(W0, D1), Arm64InstructionId.FCVTPU_32d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W0, D1");
        TestInst(FCVTPU(W15, D1), asm => asm.FCVTPU(W15, D1), Arm64InstructionId.FCVTPU_32d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W15, D1");
        TestInst(FCVTPU(WZR, D1), asm => asm.FCVTPU(WZR, D1), Arm64InstructionId.FCVTPU_32d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU WZR, D1");
        TestInst(FCVTPU(W0, D31), asm => asm.FCVTPU(W0, D31), Arm64InstructionId.FCVTPU_32d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W0, D31");
        TestInst(FCVTPU(W15, D31), asm => asm.FCVTPU(W15, D31), Arm64InstructionId.FCVTPU_32d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU W15, D31");
        TestInst(FCVTPU(WZR, D31), asm => asm.FCVTPU(WZR, D31), Arm64InstructionId.FCVTPU_32d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU WZR, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTPU"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTPU_64d_float2int_9()
    {
        TestInst(FCVTPU(X0, D1), asm => asm.FCVTPU(X0, D1), Arm64InstructionId.FCVTPU_64d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X0, D1");
        TestInst(FCVTPU(X15, D1), asm => asm.FCVTPU(X15, D1), Arm64InstructionId.FCVTPU_64d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X15, D1");
        TestInst(FCVTPU(XZR, D1), asm => asm.FCVTPU(XZR, D1), Arm64InstructionId.FCVTPU_64d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU XZR, D1");
        TestInst(FCVTPU(X0, D31), asm => asm.FCVTPU(X0, D31), Arm64InstructionId.FCVTPU_64d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X0, D31");
        TestInst(FCVTPU(X15, D31), asm => asm.FCVTPU(X15, D31), Arm64InstructionId.FCVTPU_64d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU X15, D31");
        TestInst(FCVTPU(XZR, D31), asm => asm.FCVTPU(XZR, D31), Arm64InstructionId.FCVTPU_64d_float2int, Arm64Mnemonic.FCVTPU, "FCVTPU XZR, D31");
    }
}
