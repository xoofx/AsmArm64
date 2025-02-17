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
public class Arm64InstructionFactoryTests_FCMPE_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMPE_h_floatcmp_0()
    {
        TestInst(FCMPE(H0, H1), asm => asm.FCMPE(H0, H1), Arm64InstructionId.FCMPE_h_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE H0, H1");
        TestInst(FCMPE(H31, H1), asm => asm.FCMPE(H31, H1), Arm64InstructionId.FCMPE_h_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE H31, H1");
        TestInst(FCMPE(H0, H31), asm => asm.FCMPE(H0, H31), Arm64InstructionId.FCMPE_h_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE H0, H31");
        TestInst(FCMPE(H31, H31), asm => asm.FCMPE(H31, H31), Arm64InstructionId.FCMPE_h_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMPE_hz_floatcmp_1()
    {
        TestInst(FCMPE(H0, 0.0f), asm => asm.FCMPE(H0, 0.0f), Arm64InstructionId.FCMPE_hz_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE H0, #0.0");
        TestInst(FCMPE(H31, 0.0f), asm => asm.FCMPE(H31, 0.0f), Arm64InstructionId.FCMPE_hz_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE H31, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMPE_s_floatcmp_2()
    {
        TestInst(FCMPE(S0, S1), asm => asm.FCMPE(S0, S1), Arm64InstructionId.FCMPE_s_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE S0, S1");
        TestInst(FCMPE(S31, S1), asm => asm.FCMPE(S31, S1), Arm64InstructionId.FCMPE_s_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE S31, S1");
        TestInst(FCMPE(S0, S31), asm => asm.FCMPE(S0, S31), Arm64InstructionId.FCMPE_s_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE S0, S31");
        TestInst(FCMPE(S31, S31), asm => asm.FCMPE(S31, S31), Arm64InstructionId.FCMPE_s_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMPE_sz_floatcmp_3()
    {
        TestInst(FCMPE(S0, 0.0f), asm => asm.FCMPE(S0, 0.0f), Arm64InstructionId.FCMPE_sz_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE S0, #0.0");
        TestInst(FCMPE(S31, 0.0f), asm => asm.FCMPE(S31, 0.0f), Arm64InstructionId.FCMPE_sz_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE S31, #0.0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMPE_d_floatcmp_4()
    {
        TestInst(FCMPE(D0, D1), asm => asm.FCMPE(D0, D1), Arm64InstructionId.FCMPE_d_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE D0, D1");
        TestInst(FCMPE(D31, D1), asm => asm.FCMPE(D31, D1), Arm64InstructionId.FCMPE_d_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE D31, D1");
        TestInst(FCMPE(D0, D31), asm => asm.FCMPE(D0, D31), Arm64InstructionId.FCMPE_d_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE D0, D31");
        TestInst(FCMPE(D31, D31), asm => asm.FCMPE(D31, D31), Arm64InstructionId.FCMPE_d_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE D31, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCMPE_dz_floatcmp_5()
    {
        TestInst(FCMPE(D0, 0.0f), asm => asm.FCMPE(D0, 0.0f), Arm64InstructionId.FCMPE_dz_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE D0, #0.0");
        TestInst(FCMPE(D31, 0.0f), asm => asm.FCMPE(D31, 0.0f), Arm64InstructionId.FCMPE_dz_floatcmp, Arm64Mnemonic.FCMPE, "FCMPE D31, #0.0");
    }
}
