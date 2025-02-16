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
public class Arm64InstructionFactoryTests_FMLAL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLAL_asimdelem_lh_0()
    {
        TestInst(FMLAL(V0.T_2S, V1.T_2H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V1.2H, V2.H[1]");
        TestInst(FMLAL(V30.T_2S, V1.T_2H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V1.2H, V2.H[1]");
        TestInst(FMLAL(V0.T_2S, V31.T_2H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V31.2H, V2.H[1]");
        TestInst(FMLAL(V30.T_2S, V31.T_2H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V31.2H, V2.H[1]");
        TestInst(FMLAL(V0.T_2S, V1.T_2H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V1.2H, V0.H[1]");
        TestInst(FMLAL(V30.T_2S, V1.T_2H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V1.2H, V0.H[1]");
        TestInst(FMLAL(V0.T_2S, V31.T_2H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V31.2H, V0.H[1]");
        TestInst(FMLAL(V30.T_2S, V31.T_2H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V31.2H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLAL_asimdelem_lh_1()
    {
        TestInst(FMLAL(V0.T_4S, V1.T_4H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V1.4H, V2.H[1]");
        TestInst(FMLAL(V30.T_4S, V1.T_4H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V1.4H, V2.H[1]");
        TestInst(FMLAL(V0.T_4S, V31.T_4H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V31.4H, V2.H[1]");
        TestInst(FMLAL(V30.T_4S, V31.T_4H, V2.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V31.4H, V2.H[1]");
        TestInst(FMLAL(V0.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V1.4H, V0.H[1]");
        TestInst(FMLAL(V30.T_4S, V1.T_4H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V1.4H, V0.H[1]");
        TestInst(FMLAL(V0.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V31.4H, V0.H[1]");
        TestInst(FMLAL(V30.T_4S, V31.T_4H, V0.H[1]), Arm64InstructionId.FMLAL_asimdelem_lh, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V31.4H, V0.H[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLAL_asimdsame_f_2()
    {
        TestInst(FMLAL(V0.T_2S, V1.T_2H, V2.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V1.2H, V2.2H");
        TestInst(FMLAL(V30.T_2S, V1.T_2H, V2.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V1.2H, V2.2H");
        TestInst(FMLAL(V0.T_2S, V31.T_2H, V2.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V31.2H, V2.2H");
        TestInst(FMLAL(V30.T_2S, V31.T_2H, V2.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V31.2H, V2.2H");
        TestInst(FMLAL(V0.T_2S, V1.T_2H, V0.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V1.2H, V0.2H");
        TestInst(FMLAL(V30.T_2S, V1.T_2H, V0.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V1.2H, V0.2H");
        TestInst(FMLAL(V0.T_2S, V31.T_2H, V0.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.2S, V31.2H, V0.2H");
        TestInst(FMLAL(V30.T_2S, V31.T_2H, V0.T_2H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.2S, V31.2H, V0.2H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLAL_asimdsame_f_3()
    {
        TestInst(FMLAL(V0.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V1.4H, V2.4H");
        TestInst(FMLAL(V30.T_4S, V1.T_4H, V2.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V1.4H, V2.4H");
        TestInst(FMLAL(V0.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V31.4H, V2.4H");
        TestInst(FMLAL(V30.T_4S, V31.T_4H, V2.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V31.4H, V2.4H");
        TestInst(FMLAL(V0.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V1.4H, V0.4H");
        TestInst(FMLAL(V30.T_4S, V1.T_4H, V0.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V1.4H, V0.4H");
        TestInst(FMLAL(V0.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V0.4S, V31.4H, V0.4H");
        TestInst(FMLAL(V30.T_4S, V31.T_4H, V0.T_4H), Arm64InstructionId.FMLAL_asimdsame_f, Arm64Mnemonic.FMLAL, "FMLAL V30.4S, V31.4H, V0.4H");
    }
}
