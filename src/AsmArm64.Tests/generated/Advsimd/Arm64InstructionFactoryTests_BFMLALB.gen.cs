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
public class Arm64InstructionFactoryTests_BFMLALB_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFMLALB"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFMLALB_asimdelem_f_0()
    {
        TestInst(BFMLALB(V0.T_4S, V1.T_8H, V2.H[1]), asm => asm.BFMLALB(V0.T_4S, V1.T_8H, V2.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V1.8H, V2.H[1]");
        TestInst(BFMLALB(V30.T_4S, V1.T_8H, V2.H[1]), asm => asm.BFMLALB(V30.T_4S, V1.T_8H, V2.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V1.8H, V2.H[1]");
        TestInst(BFMLALB(V0.T_4S, V31.T_8H, V2.H[1]), asm => asm.BFMLALB(V0.T_4S, V31.T_8H, V2.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V31.8H, V2.H[1]");
        TestInst(BFMLALB(V30.T_4S, V31.T_8H, V2.H[1]), asm => asm.BFMLALB(V30.T_4S, V31.T_8H, V2.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V31.8H, V2.H[1]");
        TestInst(BFMLALB(V0.T_4S, V1.T_8H, V0.H[1]), asm => asm.BFMLALB(V0.T_4S, V1.T_8H, V0.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V1.8H, V0.H[1]");
        TestInst(BFMLALB(V30.T_4S, V1.T_8H, V0.H[1]), asm => asm.BFMLALB(V30.T_4S, V1.T_8H, V0.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V1.8H, V0.H[1]");
        TestInst(BFMLALB(V0.T_4S, V31.T_8H, V0.H[1]), asm => asm.BFMLALB(V0.T_4S, V31.T_8H, V0.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V31.8H, V0.H[1]");
        TestInst(BFMLALB(V30.T_4S, V31.T_8H, V0.H[1]), asm => asm.BFMLALB(V30.T_4S, V31.T_8H, V0.H[1]), Arm64InstructionId.BFMLALB_asimdelem_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V31.8H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFMLALB"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFMLALB_asimdsame2_f_1()
    {
        TestInst(BFMLALB(V0.T_4S, V1.T_8H, V2.T_8H), asm => asm.BFMLALB(V0.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V1.8H, V2.8H");
        TestInst(BFMLALB(V30.T_4S, V1.T_8H, V2.T_8H), asm => asm.BFMLALB(V30.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V1.8H, V2.8H");
        TestInst(BFMLALB(V0.T_4S, V31.T_8H, V2.T_8H), asm => asm.BFMLALB(V0.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V31.8H, V2.8H");
        TestInst(BFMLALB(V30.T_4S, V31.T_8H, V2.T_8H), asm => asm.BFMLALB(V30.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V31.8H, V2.8H");
        TestInst(BFMLALB(V0.T_4S, V1.T_8H, V0.T_8H), asm => asm.BFMLALB(V0.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V1.8H, V0.8H");
        TestInst(BFMLALB(V30.T_4S, V1.T_8H, V0.T_8H), asm => asm.BFMLALB(V30.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V1.8H, V0.8H");
        TestInst(BFMLALB(V0.T_4S, V31.T_8H, V0.T_8H), asm => asm.BFMLALB(V0.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V0.4S, V31.8H, V0.8H");
        TestInst(BFMLALB(V30.T_4S, V31.T_8H, V0.T_8H), asm => asm.BFMLALB(V30.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.BFMLALB_asimdsame2_f, Arm64Mnemonic.BFMLALB, "BFMLALB V30.4S, V31.8H, V0.8H");
    }
}
