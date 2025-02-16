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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_FCVTN2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN2_asimdmisc_n_0()
    {
        TestInst(FCVTN2(V0.T_8H, V1.T_4S), asm => asm.FCVTN2(V0.T_8H, V1.T_4S), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.8H, V1.4S");
        TestInst(FCVTN2(V30.T_8H, V1.T_4S), asm => asm.FCVTN2(V30.T_8H, V1.T_4S), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.8H, V1.4S");
        TestInst(FCVTN2(V0.T_8H, V31.T_4S), asm => asm.FCVTN2(V0.T_8H, V31.T_4S), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.8H, V31.4S");
        TestInst(FCVTN2(V30.T_8H, V31.T_4S), asm => asm.FCVTN2(V30.T_8H, V31.T_4S), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.8H, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN2_asimdmisc_n_1()
    {
        TestInst(FCVTN2(V0.T_4S, V1.T_2D), asm => asm.FCVTN2(V0.T_4S, V1.T_2D), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.4S, V1.2D");
        TestInst(FCVTN2(V30.T_4S, V1.T_2D), asm => asm.FCVTN2(V30.T_4S, V1.T_2D), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.4S, V1.2D");
        TestInst(FCVTN2(V0.T_4S, V31.T_2D), asm => asm.FCVTN2(V0.T_4S, V31.T_2D), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.4S, V31.2D");
        TestInst(FCVTN2(V30.T_4S, V31.T_2D), asm => asm.FCVTN2(V30.T_4S, V31.T_2D), Arm64InstructionId.FCVTN2_asimdmisc_n, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.4S, V31.2D");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN2_asimdsame2_h_2()
    {
        TestInst(FCVTN2(V0.T_16B, V1.T_4S, V2.T_4S), asm => asm.FCVTN2(V0.T_16B, V1.T_4S, V2.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.16B, V1.4S, V2.4S");
        TestInst(FCVTN2(V30.T_16B, V1.T_4S, V2.T_4S), asm => asm.FCVTN2(V30.T_16B, V1.T_4S, V2.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.16B, V1.4S, V2.4S");
        TestInst(FCVTN2(V0.T_16B, V31.T_4S, V2.T_4S), asm => asm.FCVTN2(V0.T_16B, V31.T_4S, V2.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.16B, V31.4S, V2.4S");
        TestInst(FCVTN2(V30.T_16B, V31.T_4S, V2.T_4S), asm => asm.FCVTN2(V30.T_16B, V31.T_4S, V2.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.16B, V31.4S, V2.4S");
        TestInst(FCVTN2(V0.T_16B, V1.T_4S, V0.T_4S), asm => asm.FCVTN2(V0.T_16B, V1.T_4S, V0.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.16B, V1.4S, V0.4S");
        TestInst(FCVTN2(V30.T_16B, V1.T_4S, V0.T_4S), asm => asm.FCVTN2(V30.T_16B, V1.T_4S, V0.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.16B, V1.4S, V0.4S");
        TestInst(FCVTN2(V0.T_16B, V31.T_4S, V0.T_4S), asm => asm.FCVTN2(V0.T_16B, V31.T_4S, V0.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V0.16B, V31.4S, V0.4S");
        TestInst(FCVTN2(V30.T_16B, V31.T_4S, V0.T_4S), asm => asm.FCVTN2(V30.T_16B, V31.T_4S, V0.T_4S), Arm64InstructionId.FCVTN2_asimdsame2_h, Arm64Mnemonic.FCVTN2, "FCVTN2 V30.16B, V31.4S, V0.4S");
    }
}
