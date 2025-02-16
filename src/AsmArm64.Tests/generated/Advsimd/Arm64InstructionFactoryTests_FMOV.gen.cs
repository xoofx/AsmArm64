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
public class Arm64InstructionFactoryTests_FMOV_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMOV_asimdimm_h_h_0()
    {
        TestInst(FMOV(V0.T_4H, 0.50000000f), asm => asm.FMOV(V0.T_4H, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_h_h, Arm64Mnemonic.FMOV, "FMOV V0.4H, #0.50000000");
        TestInst(FMOV(V30.T_4H, 0.50000000f), asm => asm.FMOV(V30.T_4H, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_h_h, Arm64Mnemonic.FMOV, "FMOV V30.4H, #0.50000000");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMOV_asimdimm_h_h_1()
    {
        TestInst(FMOV(V0.T_8H, 0.50000000f), asm => asm.FMOV(V0.T_8H, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_h_h, Arm64Mnemonic.FMOV, "FMOV V0.8H, #0.50000000");
        TestInst(FMOV(V30.T_8H, 0.50000000f), asm => asm.FMOV(V30.T_8H, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_h_h, Arm64Mnemonic.FMOV, "FMOV V30.8H, #0.50000000");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMOV_asimdimm_s_s_2()
    {
        TestInst(FMOV(V0.T_2S, 0.50000000f), asm => asm.FMOV(V0.T_2S, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_s_s, Arm64Mnemonic.FMOV, "FMOV V0.2S, #0.50000000");
        TestInst(FMOV(V30.T_2S, 0.50000000f), asm => asm.FMOV(V30.T_2S, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_s_s, Arm64Mnemonic.FMOV, "FMOV V30.2S, #0.50000000");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMOV_asimdimm_s_s_3()
    {
        TestInst(FMOV(V0.T_4S, 0.50000000f), asm => asm.FMOV(V0.T_4S, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_s_s, Arm64Mnemonic.FMOV, "FMOV V0.4S, #0.50000000");
        TestInst(FMOV(V30.T_4S, 0.50000000f), asm => asm.FMOV(V30.T_4S, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_s_s, Arm64Mnemonic.FMOV, "FMOV V30.4S, #0.50000000");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMOV"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMOV_asimdimm_d2_d_4()
    {
        TestInst(FMOV(V0.T_2D, 0.50000000f), asm => asm.FMOV(V0.T_2D, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_d2_d, Arm64Mnemonic.FMOV, "FMOV V0.2D, #0.50000000");
        TestInst(FMOV(V30.T_2D, 0.50000000f), asm => asm.FMOV(V30.T_2D, 0.50000000f), Arm64InstructionId.FMOV_asimdimm_d2_d, Arm64Mnemonic.FMOV, "FMOV V30.2D, #0.50000000");
    }
}
