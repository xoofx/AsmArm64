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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_SQXTN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTN_asisdmisc_n_0()
    {
        TestInst(SQXTN(B1, H2), asm => asm.SQXTN(B1, H2), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN B1, H2");
        TestInst(SQXTN(B31, H2), asm => asm.SQXTN(B31, H2), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN B31, H2");
        TestInst(SQXTN(B1, H0), asm => asm.SQXTN(B1, H0), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN B1, H0");
        TestInst(SQXTN(B31, H0), asm => asm.SQXTN(B31, H0), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN B31, H0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTN_asisdmisc_n_1()
    {
        TestInst(SQXTN(H1, S2), asm => asm.SQXTN(H1, S2), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN H1, S2");
        TestInst(SQXTN(H31, S2), asm => asm.SQXTN(H31, S2), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN H31, S2");
        TestInst(SQXTN(H1, S0), asm => asm.SQXTN(H1, S0), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN H1, S0");
        TestInst(SQXTN(H31, S0), asm => asm.SQXTN(H31, S0), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN H31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTN_asisdmisc_n_2()
    {
        TestInst(SQXTN(S1, D2), asm => asm.SQXTN(S1, D2), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN S1, D2");
        TestInst(SQXTN(S31, D2), asm => asm.SQXTN(S31, D2), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN S31, D2");
        TestInst(SQXTN(S1, D0), asm => asm.SQXTN(S1, D0), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN S1, D0");
        TestInst(SQXTN(S31, D0), asm => asm.SQXTN(S31, D0), Arm64InstructionId.SQXTN_asisdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN S31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTN_asimdmisc_n_3()
    {
        TestInst(SQXTN(V0.T_8B, V1.T_8H), asm => asm.SQXTN(V0.T_8B, V1.T_8H), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V0.8B, V1.8H");
        TestInst(SQXTN(V30.T_8B, V1.T_8H), asm => asm.SQXTN(V30.T_8B, V1.T_8H), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V30.8B, V1.8H");
        TestInst(SQXTN(V0.T_8B, V31.T_8H), asm => asm.SQXTN(V0.T_8B, V31.T_8H), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V0.8B, V31.8H");
        TestInst(SQXTN(V30.T_8B, V31.T_8H), asm => asm.SQXTN(V30.T_8B, V31.T_8H), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V30.8B, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTN_asimdmisc_n_4()
    {
        TestInst(SQXTN(V0.T_4H, V1.T_4S), asm => asm.SQXTN(V0.T_4H, V1.T_4S), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V0.4H, V1.4S");
        TestInst(SQXTN(V30.T_4H, V1.T_4S), asm => asm.SQXTN(V30.T_4H, V1.T_4S), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V30.4H, V1.4S");
        TestInst(SQXTN(V0.T_4H, V31.T_4S), asm => asm.SQXTN(V0.T_4H, V31.T_4S), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V0.4H, V31.4S");
        TestInst(SQXTN(V30.T_4H, V31.T_4S), asm => asm.SQXTN(V30.T_4H, V31.T_4S), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V30.4H, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTN_asimdmisc_n_5()
    {
        TestInst(SQXTN(V0.T_2S, V1.T_2D), asm => asm.SQXTN(V0.T_2S, V1.T_2D), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V0.2S, V1.2D");
        TestInst(SQXTN(V30.T_2S, V1.T_2D), asm => asm.SQXTN(V30.T_2S, V1.T_2D), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V30.2S, V1.2D");
        TestInst(SQXTN(V0.T_2S, V31.T_2D), asm => asm.SQXTN(V0.T_2S, V31.T_2D), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V0.2S, V31.2D");
        TestInst(SQXTN(V30.T_2S, V31.T_2D), asm => asm.SQXTN(V30.T_2S, V31.T_2D), Arm64InstructionId.SQXTN_asimdmisc_n, Arm64Mnemonic.SQXTN, "SQXTN V30.2S, V31.2D");
    }
}
