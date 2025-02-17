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
public class Arm64InstructionFactoryTests_FMLSL2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLSL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLSL2_asimdelem_lh_0()
    {
        TestInst(FMLSL2(V0.T_2S, V1.T_2H, V2.H[1]), asm => asm.FMLSL2(V0.T_2S, V1.T_2H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V1.2H, V2.H[1]");
        TestInst(FMLSL2(V30.T_2S, V1.T_2H, V2.H[1]), asm => asm.FMLSL2(V30.T_2S, V1.T_2H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V1.2H, V2.H[1]");
        TestInst(FMLSL2(V0.T_2S, V31.T_2H, V2.H[1]), asm => asm.FMLSL2(V0.T_2S, V31.T_2H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V31.2H, V2.H[1]");
        TestInst(FMLSL2(V30.T_2S, V31.T_2H, V2.H[1]), asm => asm.FMLSL2(V30.T_2S, V31.T_2H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V31.2H, V2.H[1]");
        TestInst(FMLSL2(V0.T_2S, V1.T_2H, V0.H[1]), asm => asm.FMLSL2(V0.T_2S, V1.T_2H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V1.2H, V0.H[1]");
        TestInst(FMLSL2(V30.T_2S, V1.T_2H, V0.H[1]), asm => asm.FMLSL2(V30.T_2S, V1.T_2H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V1.2H, V0.H[1]");
        TestInst(FMLSL2(V0.T_2S, V31.T_2H, V0.H[1]), asm => asm.FMLSL2(V0.T_2S, V31.T_2H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V31.2H, V0.H[1]");
        TestInst(FMLSL2(V30.T_2S, V31.T_2H, V0.H[1]), asm => asm.FMLSL2(V30.T_2S, V31.T_2H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V31.2H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLSL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLSL2_asimdelem_lh_1()
    {
        TestInst(FMLSL2(V0.T_4S, V1.T_4H, V2.H[1]), asm => asm.FMLSL2(V0.T_4S, V1.T_4H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V1.4H, V2.H[1]");
        TestInst(FMLSL2(V30.T_4S, V1.T_4H, V2.H[1]), asm => asm.FMLSL2(V30.T_4S, V1.T_4H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V1.4H, V2.H[1]");
        TestInst(FMLSL2(V0.T_4S, V31.T_4H, V2.H[1]), asm => asm.FMLSL2(V0.T_4S, V31.T_4H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V31.4H, V2.H[1]");
        TestInst(FMLSL2(V30.T_4S, V31.T_4H, V2.H[1]), asm => asm.FMLSL2(V30.T_4S, V31.T_4H, V2.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V31.4H, V2.H[1]");
        TestInst(FMLSL2(V0.T_4S, V1.T_4H, V0.H[1]), asm => asm.FMLSL2(V0.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V1.4H, V0.H[1]");
        TestInst(FMLSL2(V30.T_4S, V1.T_4H, V0.H[1]), asm => asm.FMLSL2(V30.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V1.4H, V0.H[1]");
        TestInst(FMLSL2(V0.T_4S, V31.T_4H, V0.H[1]), asm => asm.FMLSL2(V0.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V31.4H, V0.H[1]");
        TestInst(FMLSL2(V30.T_4S, V31.T_4H, V0.H[1]), asm => asm.FMLSL2(V30.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.FMLSL2_asimdelem_lh, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLSL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLSL2_asimdsame_f_2()
    {
        TestInst(FMLSL2(V0.T_2S, V1.T_2H, V2.T_2H), asm => asm.FMLSL2(V0.T_2S, V1.T_2H, V2.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V1.2H, V2.2H");
        TestInst(FMLSL2(V30.T_2S, V1.T_2H, V2.T_2H), asm => asm.FMLSL2(V30.T_2S, V1.T_2H, V2.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V1.2H, V2.2H");
        TestInst(FMLSL2(V0.T_2S, V31.T_2H, V2.T_2H), asm => asm.FMLSL2(V0.T_2S, V31.T_2H, V2.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V31.2H, V2.2H");
        TestInst(FMLSL2(V30.T_2S, V31.T_2H, V2.T_2H), asm => asm.FMLSL2(V30.T_2S, V31.T_2H, V2.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V31.2H, V2.2H");
        TestInst(FMLSL2(V0.T_2S, V1.T_2H, V0.T_2H), asm => asm.FMLSL2(V0.T_2S, V1.T_2H, V0.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V1.2H, V0.2H");
        TestInst(FMLSL2(V30.T_2S, V1.T_2H, V0.T_2H), asm => asm.FMLSL2(V30.T_2S, V1.T_2H, V0.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V1.2H, V0.2H");
        TestInst(FMLSL2(V0.T_2S, V31.T_2H, V0.T_2H), asm => asm.FMLSL2(V0.T_2S, V31.T_2H, V0.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.2S, V31.2H, V0.2H");
        TestInst(FMLSL2(V30.T_2S, V31.T_2H, V0.T_2H), asm => asm.FMLSL2(V30.T_2S, V31.T_2H, V0.T_2H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.2S, V31.2H, V0.2H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLSL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLSL2_asimdsame_f_3()
    {
        TestInst(FMLSL2(V0.T_4S, V1.T_4H, V2.T_4H), asm => asm.FMLSL2(V0.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V1.4H, V2.4H");
        TestInst(FMLSL2(V30.T_4S, V1.T_4H, V2.T_4H), asm => asm.FMLSL2(V30.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V1.4H, V2.4H");
        TestInst(FMLSL2(V0.T_4S, V31.T_4H, V2.T_4H), asm => asm.FMLSL2(V0.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V31.4H, V2.4H");
        TestInst(FMLSL2(V30.T_4S, V31.T_4H, V2.T_4H), asm => asm.FMLSL2(V30.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V31.4H, V2.4H");
        TestInst(FMLSL2(V0.T_4S, V1.T_4H, V0.T_4H), asm => asm.FMLSL2(V0.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V1.4H, V0.4H");
        TestInst(FMLSL2(V30.T_4S, V1.T_4H, V0.T_4H), asm => asm.FMLSL2(V30.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V1.4H, V0.4H");
        TestInst(FMLSL2(V0.T_4S, V31.T_4H, V0.T_4H), asm => asm.FMLSL2(V0.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V0.4S, V31.4H, V0.4H");
        TestInst(FMLSL2(V30.T_4S, V31.T_4H, V0.T_4H), asm => asm.FMLSL2(V30.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.FMLSL2_asimdsame_f, Arm64Mnemonic.FMLSL2, "FMLSL2 V30.4S, V31.4H, V0.4H");
    }
}
