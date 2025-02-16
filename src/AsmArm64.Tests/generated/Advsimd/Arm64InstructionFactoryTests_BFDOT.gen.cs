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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_BFDOT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdelem_e_0()
    {
        TestInst(BFDOT(V0.T_2S, V1.T_4H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V1.4H, V2.2H[1]");
        TestInst(BFDOT(V30.T_2S, V1.T_4H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V1.4H, V2.2H[1]");
        TestInst(BFDOT(V0.T_2S, V31.T_4H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V31.4H, V2.2H[1]");
        TestInst(BFDOT(V30.T_2S, V31.T_4H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V31.4H, V2.2H[1]");
        TestInst(BFDOT(V0.T_2S, V1.T_4H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V1.4H, V0.2H[1]");
        TestInst(BFDOT(V30.T_2S, V1.T_4H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V1.4H, V0.2H[1]");
        TestInst(BFDOT(V0.T_2S, V31.T_4H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V31.4H, V0.2H[1]");
        TestInst(BFDOT(V30.T_2S, V31.T_4H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V31.4H, V0.2H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdelem_e_1()
    {
        TestInst(BFDOT(V0.T_4S, V1.T_8H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V1.8H, V2.2H[1]");
        TestInst(BFDOT(V30.T_4S, V1.T_8H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V1.8H, V2.2H[1]");
        TestInst(BFDOT(V0.T_4S, V31.T_8H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V31.8H, V2.2H[1]");
        TestInst(BFDOT(V30.T_4S, V31.T_8H, V2.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V31.8H, V2.2H[1]");
        TestInst(BFDOT(V0.T_4S, V1.T_8H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V1.8H, V0.2H[1]");
        TestInst(BFDOT(V30.T_4S, V1.T_8H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V1.8H, V0.2H[1]");
        TestInst(BFDOT(V0.T_4S, V31.T_8H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V31.8H, V0.2H[1]");
        TestInst(BFDOT(V30.T_4S, V31.T_8H, V0.T_2H[1]), Arm64InstructionId.BFDOT_asimdelem_e, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V31.8H, V0.2H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdsame2_d_2()
    {
        TestInst(BFDOT(V0.T_2S, V1.T_4H, V2.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V1.4H, V2.4H");
        TestInst(BFDOT(V30.T_2S, V1.T_4H, V2.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V1.4H, V2.4H");
        TestInst(BFDOT(V0.T_2S, V31.T_4H, V2.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V31.4H, V2.4H");
        TestInst(BFDOT(V30.T_2S, V31.T_4H, V2.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V31.4H, V2.4H");
        TestInst(BFDOT(V0.T_2S, V1.T_4H, V0.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V1.4H, V0.4H");
        TestInst(BFDOT(V30.T_2S, V1.T_4H, V0.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V1.4H, V0.4H");
        TestInst(BFDOT(V0.T_2S, V31.T_4H, V0.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.2S, V31.4H, V0.4H");
        TestInst(BFDOT(V30.T_2S, V31.T_4H, V0.T_4H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.2S, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFDOT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFDOT_asimdsame2_d_3()
    {
        TestInst(BFDOT(V0.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V1.8H, V2.8H");
        TestInst(BFDOT(V30.T_4S, V1.T_8H, V2.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V1.8H, V2.8H");
        TestInst(BFDOT(V0.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V31.8H, V2.8H");
        TestInst(BFDOT(V30.T_4S, V31.T_8H, V2.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V31.8H, V2.8H");
        TestInst(BFDOT(V0.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V1.8H, V0.8H");
        TestInst(BFDOT(V30.T_4S, V1.T_8H, V0.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V1.8H, V0.8H");
        TestInst(BFDOT(V0.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V0.4S, V31.8H, V0.8H");
        TestInst(BFDOT(V30.T_4S, V31.T_8H, V0.T_8H), Arm64InstructionId.BFDOT_asimdsame2_d, Arm64Mnemonic.BFDOT, "BFDOT V30.4S, V31.8H, V0.8H");
    }
}
