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
public class Arm64InstructionFactoryTests_FCVTN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN_asimdsame2_d_0()
    {
        TestInst(FCVTN(V0.T_8B, V1.T_4H, V2.T_4H), asm => asm.FCVTN(V0.T_8B, V1.T_4H, V2.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V1.4H, V2.4H");
        TestInst(FCVTN(V30.T_8B, V1.T_4H, V2.T_4H), asm => asm.FCVTN(V30.T_8B, V1.T_4H, V2.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V1.4H, V2.4H");
        TestInst(FCVTN(V0.T_8B, V31.T_4H, V2.T_4H), asm => asm.FCVTN(V0.T_8B, V31.T_4H, V2.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V31.4H, V2.4H");
        TestInst(FCVTN(V30.T_8B, V31.T_4H, V2.T_4H), asm => asm.FCVTN(V30.T_8B, V31.T_4H, V2.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V31.4H, V2.4H");
        TestInst(FCVTN(V0.T_8B, V1.T_4H, V0.T_4H), asm => asm.FCVTN(V0.T_8B, V1.T_4H, V0.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V1.4H, V0.4H");
        TestInst(FCVTN(V30.T_8B, V1.T_4H, V0.T_4H), asm => asm.FCVTN(V30.T_8B, V1.T_4H, V0.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V1.4H, V0.4H");
        TestInst(FCVTN(V0.T_8B, V31.T_4H, V0.T_4H), asm => asm.FCVTN(V0.T_8B, V31.T_4H, V0.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V31.4H, V0.4H");
        TestInst(FCVTN(V30.T_8B, V31.T_4H, V0.T_4H), asm => asm.FCVTN(V30.T_8B, V31.T_4H, V0.T_4H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN_asimdsame2_d_1()
    {
        TestInst(FCVTN(V0.T_16B, V1.T_8H, V2.T_8H), asm => asm.FCVTN(V0.T_16B, V1.T_8H, V2.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.16B, V1.8H, V2.8H");
        TestInst(FCVTN(V30.T_16B, V1.T_8H, V2.T_8H), asm => asm.FCVTN(V30.T_16B, V1.T_8H, V2.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.16B, V1.8H, V2.8H");
        TestInst(FCVTN(V0.T_16B, V31.T_8H, V2.T_8H), asm => asm.FCVTN(V0.T_16B, V31.T_8H, V2.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.16B, V31.8H, V2.8H");
        TestInst(FCVTN(V30.T_16B, V31.T_8H, V2.T_8H), asm => asm.FCVTN(V30.T_16B, V31.T_8H, V2.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.16B, V31.8H, V2.8H");
        TestInst(FCVTN(V0.T_16B, V1.T_8H, V0.T_8H), asm => asm.FCVTN(V0.T_16B, V1.T_8H, V0.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.16B, V1.8H, V0.8H");
        TestInst(FCVTN(V30.T_16B, V1.T_8H, V0.T_8H), asm => asm.FCVTN(V30.T_16B, V1.T_8H, V0.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.16B, V1.8H, V0.8H");
        TestInst(FCVTN(V0.T_16B, V31.T_8H, V0.T_8H), asm => asm.FCVTN(V0.T_16B, V31.T_8H, V0.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V0.16B, V31.8H, V0.8H");
        TestInst(FCVTN(V30.T_16B, V31.T_8H, V0.T_8H), asm => asm.FCVTN(V30.T_16B, V31.T_8H, V0.T_8H), Arm64InstructionId.FCVTN_asimdsame2_d, Arm64Mnemonic.FCVTN, "FCVTN V30.16B, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN_asimdmisc_n_2()
    {
        TestInst(FCVTN(V0.T_4H, V1.T_4S), asm => asm.FCVTN(V0.T_4H, V1.T_4S), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V0.4H, V1.4S");
        TestInst(FCVTN(V30.T_4H, V1.T_4S), asm => asm.FCVTN(V30.T_4H, V1.T_4S), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V30.4H, V1.4S");
        TestInst(FCVTN(V0.T_4H, V31.T_4S), asm => asm.FCVTN(V0.T_4H, V31.T_4S), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V0.4H, V31.4S");
        TestInst(FCVTN(V30.T_4H, V31.T_4S), asm => asm.FCVTN(V30.T_4H, V31.T_4S), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V30.4H, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN_asimdmisc_n_3()
    {
        TestInst(FCVTN(V0.T_2S, V1.T_2D), asm => asm.FCVTN(V0.T_2S, V1.T_2D), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V0.2S, V1.2D");
        TestInst(FCVTN(V30.T_2S, V1.T_2D), asm => asm.FCVTN(V30.T_2S, V1.T_2D), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V30.2S, V1.2D");
        TestInst(FCVTN(V0.T_2S, V31.T_2D), asm => asm.FCVTN(V0.T_2S, V31.T_2D), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V0.2S, V31.2D");
        TestInst(FCVTN(V30.T_2S, V31.T_2D), asm => asm.FCVTN(V30.T_2S, V31.T_2D), Arm64InstructionId.FCVTN_asimdmisc_n, Arm64Mnemonic.FCVTN, "FCVTN V30.2S, V31.2D");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTN_asimdsame2_h_4()
    {
        TestInst(FCVTN(V0.T_8B, V1.T_4S, V2.T_4S), asm => asm.FCVTN(V0.T_8B, V1.T_4S, V2.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V1.4S, V2.4S");
        TestInst(FCVTN(V30.T_8B, V1.T_4S, V2.T_4S), asm => asm.FCVTN(V30.T_8B, V1.T_4S, V2.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V1.4S, V2.4S");
        TestInst(FCVTN(V0.T_8B, V31.T_4S, V2.T_4S), asm => asm.FCVTN(V0.T_8B, V31.T_4S, V2.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V31.4S, V2.4S");
        TestInst(FCVTN(V30.T_8B, V31.T_4S, V2.T_4S), asm => asm.FCVTN(V30.T_8B, V31.T_4S, V2.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V31.4S, V2.4S");
        TestInst(FCVTN(V0.T_8B, V1.T_4S, V0.T_4S), asm => asm.FCVTN(V0.T_8B, V1.T_4S, V0.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V1.4S, V0.4S");
        TestInst(FCVTN(V30.T_8B, V1.T_4S, V0.T_4S), asm => asm.FCVTN(V30.T_8B, V1.T_4S, V0.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V1.4S, V0.4S");
        TestInst(FCVTN(V0.T_8B, V31.T_4S, V0.T_4S), asm => asm.FCVTN(V0.T_8B, V31.T_4S, V0.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V0.8B, V31.4S, V0.4S");
        TestInst(FCVTN(V30.T_8B, V31.T_4S, V0.T_4S), asm => asm.FCVTN(V30.T_8B, V31.T_4S, V0.T_4S), Arm64InstructionId.FCVTN_asimdsame2_h, Arm64Mnemonic.FCVTN, "FCVTN V30.8B, V31.4S, V0.4S");
    }
}
