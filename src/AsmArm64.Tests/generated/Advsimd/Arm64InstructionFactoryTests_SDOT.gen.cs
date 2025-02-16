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
public class Arm64InstructionFactoryTests_SDOT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SDOT_asimdelem_d_0()
    {
        TestInst(SDOT(V0.T_2S, V1.T_8B, V2.T_4B[1]), asm => asm.SDOT(V0.T_2S, V1.T_8B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V1.8B, V2.4B[1]");
        TestInst(SDOT(V30.T_2S, V1.T_8B, V2.T_4B[1]), asm => asm.SDOT(V30.T_2S, V1.T_8B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V1.8B, V2.4B[1]");
        TestInst(SDOT(V0.T_2S, V31.T_8B, V2.T_4B[1]), asm => asm.SDOT(V0.T_2S, V31.T_8B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V31.8B, V2.4B[1]");
        TestInst(SDOT(V30.T_2S, V31.T_8B, V2.T_4B[1]), asm => asm.SDOT(V30.T_2S, V31.T_8B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V31.8B, V2.4B[1]");
        TestInst(SDOT(V0.T_2S, V1.T_8B, V0.T_4B[1]), asm => asm.SDOT(V0.T_2S, V1.T_8B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V1.8B, V0.4B[1]");
        TestInst(SDOT(V30.T_2S, V1.T_8B, V0.T_4B[1]), asm => asm.SDOT(V30.T_2S, V1.T_8B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V1.8B, V0.4B[1]");
        TestInst(SDOT(V0.T_2S, V31.T_8B, V0.T_4B[1]), asm => asm.SDOT(V0.T_2S, V31.T_8B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V31.8B, V0.4B[1]");
        TestInst(SDOT(V30.T_2S, V31.T_8B, V0.T_4B[1]), asm => asm.SDOT(V30.T_2S, V31.T_8B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V31.8B, V0.4B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SDOT_asimdelem_d_1()
    {
        TestInst(SDOT(V0.T_4S, V1.T_16B, V2.T_4B[1]), asm => asm.SDOT(V0.T_4S, V1.T_16B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V1.16B, V2.4B[1]");
        TestInst(SDOT(V30.T_4S, V1.T_16B, V2.T_4B[1]), asm => asm.SDOT(V30.T_4S, V1.T_16B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V1.16B, V2.4B[1]");
        TestInst(SDOT(V0.T_4S, V31.T_16B, V2.T_4B[1]), asm => asm.SDOT(V0.T_4S, V31.T_16B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V31.16B, V2.4B[1]");
        TestInst(SDOT(V30.T_4S, V31.T_16B, V2.T_4B[1]), asm => asm.SDOT(V30.T_4S, V31.T_16B, V2.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V31.16B, V2.4B[1]");
        TestInst(SDOT(V0.T_4S, V1.T_16B, V0.T_4B[1]), asm => asm.SDOT(V0.T_4S, V1.T_16B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V1.16B, V0.4B[1]");
        TestInst(SDOT(V30.T_4S, V1.T_16B, V0.T_4B[1]), asm => asm.SDOT(V30.T_4S, V1.T_16B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V1.16B, V0.4B[1]");
        TestInst(SDOT(V0.T_4S, V31.T_16B, V0.T_4B[1]), asm => asm.SDOT(V0.T_4S, V31.T_16B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V31.16B, V0.4B[1]");
        TestInst(SDOT(V30.T_4S, V31.T_16B, V0.T_4B[1]), asm => asm.SDOT(V30.T_4S, V31.T_16B, V0.T_4B[1]), Arm64InstructionId.SDOT_asimdelem_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V31.16B, V0.4B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SDOT_asimdsame2_d_2()
    {
        TestInst(SDOT(V0.T_2S, V1.T_8B, V2.T_8B), asm => asm.SDOT(V0.T_2S, V1.T_8B, V2.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V1.8B, V2.8B");
        TestInst(SDOT(V30.T_2S, V1.T_8B, V2.T_8B), asm => asm.SDOT(V30.T_2S, V1.T_8B, V2.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V1.8B, V2.8B");
        TestInst(SDOT(V0.T_2S, V31.T_8B, V2.T_8B), asm => asm.SDOT(V0.T_2S, V31.T_8B, V2.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V31.8B, V2.8B");
        TestInst(SDOT(V30.T_2S, V31.T_8B, V2.T_8B), asm => asm.SDOT(V30.T_2S, V31.T_8B, V2.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V31.8B, V2.8B");
        TestInst(SDOT(V0.T_2S, V1.T_8B, V0.T_8B), asm => asm.SDOT(V0.T_2S, V1.T_8B, V0.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V1.8B, V0.8B");
        TestInst(SDOT(V30.T_2S, V1.T_8B, V0.T_8B), asm => asm.SDOT(V30.T_2S, V1.T_8B, V0.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V1.8B, V0.8B");
        TestInst(SDOT(V0.T_2S, V31.T_8B, V0.T_8B), asm => asm.SDOT(V0.T_2S, V31.T_8B, V0.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.2S, V31.8B, V0.8B");
        TestInst(SDOT(V30.T_2S, V31.T_8B, V0.T_8B), asm => asm.SDOT(V30.T_2S, V31.T_8B, V0.T_8B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.2S, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SDOT_asimdsame2_d_3()
    {
        TestInst(SDOT(V0.T_4S, V1.T_16B, V2.T_16B), asm => asm.SDOT(V0.T_4S, V1.T_16B, V2.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V1.16B, V2.16B");
        TestInst(SDOT(V30.T_4S, V1.T_16B, V2.T_16B), asm => asm.SDOT(V30.T_4S, V1.T_16B, V2.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V1.16B, V2.16B");
        TestInst(SDOT(V0.T_4S, V31.T_16B, V2.T_16B), asm => asm.SDOT(V0.T_4S, V31.T_16B, V2.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V31.16B, V2.16B");
        TestInst(SDOT(V30.T_4S, V31.T_16B, V2.T_16B), asm => asm.SDOT(V30.T_4S, V31.T_16B, V2.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V31.16B, V2.16B");
        TestInst(SDOT(V0.T_4S, V1.T_16B, V0.T_16B), asm => asm.SDOT(V0.T_4S, V1.T_16B, V0.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V1.16B, V0.16B");
        TestInst(SDOT(V30.T_4S, V1.T_16B, V0.T_16B), asm => asm.SDOT(V30.T_4S, V1.T_16B, V0.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V1.16B, V0.16B");
        TestInst(SDOT(V0.T_4S, V31.T_16B, V0.T_16B), asm => asm.SDOT(V0.T_4S, V31.T_16B, V0.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V0.4S, V31.16B, V0.16B");
        TestInst(SDOT(V30.T_4S, V31.T_16B, V0.T_16B), asm => asm.SDOT(V30.T_4S, V31.T_16B, V0.T_16B), Arm64InstructionId.SDOT_asimdsame2_d, Arm64Mnemonic.SDOT, "SDOT V30.4S, V31.16B, V0.16B");
    }
}
