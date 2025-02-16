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
public class Arm64InstructionFactoryTests_SQXTUN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN_asisdmisc_n_0()
    {
        TestInst(SQXTUN(B1, H2), asm => asm.SQXTUN(B1, H2), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN B1, H2");
        TestInst(SQXTUN(B31, H2), asm => asm.SQXTUN(B31, H2), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN B31, H2");
        TestInst(SQXTUN(B1, H0), asm => asm.SQXTUN(B1, H0), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN B1, H0");
        TestInst(SQXTUN(B31, H0), asm => asm.SQXTUN(B31, H0), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN B31, H0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN_asisdmisc_n_1()
    {
        TestInst(SQXTUN(H1, S2), asm => asm.SQXTUN(H1, S2), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN H1, S2");
        TestInst(SQXTUN(H31, S2), asm => asm.SQXTUN(H31, S2), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN H31, S2");
        TestInst(SQXTUN(H1, S0), asm => asm.SQXTUN(H1, S0), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN H1, S0");
        TestInst(SQXTUN(H31, S0), asm => asm.SQXTUN(H31, S0), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN H31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN_asisdmisc_n_2()
    {
        TestInst(SQXTUN(S1, D2), asm => asm.SQXTUN(S1, D2), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN S1, D2");
        TestInst(SQXTUN(S31, D2), asm => asm.SQXTUN(S31, D2), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN S31, D2");
        TestInst(SQXTUN(S1, D0), asm => asm.SQXTUN(S1, D0), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN S1, D0");
        TestInst(SQXTUN(S31, D0), asm => asm.SQXTUN(S31, D0), Arm64InstructionId.SQXTUN_asisdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN S31, D0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN_asimdmisc_n_3()
    {
        TestInst(SQXTUN(V0.T_8B, V1.T_8H), asm => asm.SQXTUN(V0.T_8B, V1.T_8H), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V0.8B, V1.8H");
        TestInst(SQXTUN(V30.T_8B, V1.T_8H), asm => asm.SQXTUN(V30.T_8B, V1.T_8H), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V30.8B, V1.8H");
        TestInst(SQXTUN(V0.T_8B, V31.T_8H), asm => asm.SQXTUN(V0.T_8B, V31.T_8H), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V0.8B, V31.8H");
        TestInst(SQXTUN(V30.T_8B, V31.T_8H), asm => asm.SQXTUN(V30.T_8B, V31.T_8H), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V30.8B, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN_asimdmisc_n_4()
    {
        TestInst(SQXTUN(V0.T_4H, V1.T_4S), asm => asm.SQXTUN(V0.T_4H, V1.T_4S), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V0.4H, V1.4S");
        TestInst(SQXTUN(V30.T_4H, V1.T_4S), asm => asm.SQXTUN(V30.T_4H, V1.T_4S), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V30.4H, V1.4S");
        TestInst(SQXTUN(V0.T_4H, V31.T_4S), asm => asm.SQXTUN(V0.T_4H, V31.T_4S), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V0.4H, V31.4S");
        TestInst(SQXTUN(V30.T_4H, V31.T_4S), asm => asm.SQXTUN(V30.T_4H, V31.T_4S), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V30.4H, V31.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SQXTUN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SQXTUN_asimdmisc_n_5()
    {
        TestInst(SQXTUN(V0.T_2S, V1.T_2D), asm => asm.SQXTUN(V0.T_2S, V1.T_2D), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V0.2S, V1.2D");
        TestInst(SQXTUN(V30.T_2S, V1.T_2D), asm => asm.SQXTUN(V30.T_2S, V1.T_2D), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V30.2S, V1.2D");
        TestInst(SQXTUN(V0.T_2S, V31.T_2D), asm => asm.SQXTUN(V0.T_2S, V31.T_2D), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V0.2S, V31.2D");
        TestInst(SQXTUN(V30.T_2S, V31.T_2D), asm => asm.SQXTUN(V30.T_2S, V31.T_2D), Arm64InstructionId.SQXTUN_asimdmisc_n, Arm64Mnemonic.SQXTUN, "SQXTUN V30.2S, V31.2D");
    }
}
