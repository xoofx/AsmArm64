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
public class Arm64InstructionFactoryTests_ORR_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ORR"/>.
    /// </summary>
    [TestMethod]
    public void Test_ORR_asimdimm_l_hl_0()
    {
        TestInst(ORR(V0.T_4H, 5, _LSL, 8), asm => asm.ORR(V0.T_4H, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_hl, Arm64Mnemonic.ORR, "ORR V0.4H, #5, LSL #8");
        TestInst(ORR(V30.T_4H, 5, _LSL, 8), asm => asm.ORR(V30.T_4H, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_hl, Arm64Mnemonic.ORR, "ORR V30.4H, #5, LSL #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ORR"/>.
    /// </summary>
    [TestMethod]
    public void Test_ORR_asimdimm_l_hl_1()
    {
        TestInst(ORR(V0.T_8H, 5, _LSL, 8), asm => asm.ORR(V0.T_8H, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_hl, Arm64Mnemonic.ORR, "ORR V0.8H, #5, LSL #8");
        TestInst(ORR(V30.T_8H, 5, _LSL, 8), asm => asm.ORR(V30.T_8H, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_hl, Arm64Mnemonic.ORR, "ORR V30.8H, #5, LSL #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ORR"/>.
    /// </summary>
    [TestMethod]
    public void Test_ORR_asimdimm_l_sl_2()
    {
        TestInst(ORR(V0.T_2S, 5, _LSL, 8), asm => asm.ORR(V0.T_2S, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_sl, Arm64Mnemonic.ORR, "ORR V0.2S, #5, LSL #8");
        TestInst(ORR(V30.T_2S, 5, _LSL, 8), asm => asm.ORR(V30.T_2S, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_sl, Arm64Mnemonic.ORR, "ORR V30.2S, #5, LSL #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ORR"/>.
    /// </summary>
    [TestMethod]
    public void Test_ORR_asimdimm_l_sl_3()
    {
        TestInst(ORR(V0.T_4S, 5, _LSL, 8), asm => asm.ORR(V0.T_4S, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_sl, Arm64Mnemonic.ORR, "ORR V0.4S, #5, LSL #8");
        TestInst(ORR(V30.T_4S, 5, _LSL, 8), asm => asm.ORR(V30.T_4S, 5, _LSL, 8), Arm64InstructionId.ORR_asimdimm_l_sl, Arm64Mnemonic.ORR, "ORR V30.4S, #5, LSL #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ORR"/>.
    /// </summary>
    [TestMethod]
    public void Test_ORR_asimdsame_only_4()
    {
        TestInst(ORR(V0.T_8B, V1.T_8B, V2.T_8B), asm => asm.ORR(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.8B, V1.8B, V2.8B");
        TestInst(ORR(V30.T_8B, V1.T_8B, V2.T_8B), asm => asm.ORR(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.8B, V1.8B, V2.8B");
        TestInst(ORR(V0.T_8B, V31.T_8B, V2.T_8B), asm => asm.ORR(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.8B, V31.8B, V2.8B");
        TestInst(ORR(V30.T_8B, V31.T_8B, V2.T_8B), asm => asm.ORR(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.8B, V31.8B, V2.8B");
        TestInst(ORR(V0.T_8B, V1.T_8B, V0.T_8B), asm => asm.ORR(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.8B, V1.8B, V0.8B");
        TestInst(ORR(V30.T_8B, V1.T_8B, V0.T_8B), asm => asm.ORR(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.8B, V1.8B, V0.8B");
        TestInst(ORR(V0.T_8B, V31.T_8B, V0.T_8B), asm => asm.ORR(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.8B, V31.8B, V0.8B");
        TestInst(ORR(V30.T_8B, V31.T_8B, V0.T_8B), asm => asm.ORR(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ORR"/>.
    /// </summary>
    [TestMethod]
    public void Test_ORR_asimdsame_only_5()
    {
        TestInst(ORR(V0.T_16B, V1.T_16B, V2.T_16B), asm => asm.ORR(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.16B, V1.16B, V2.16B");
        TestInst(ORR(V30.T_16B, V1.T_16B, V2.T_16B), asm => asm.ORR(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.16B, V1.16B, V2.16B");
        TestInst(ORR(V0.T_16B, V31.T_16B, V2.T_16B), asm => asm.ORR(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.16B, V31.16B, V2.16B");
        TestInst(ORR(V30.T_16B, V31.T_16B, V2.T_16B), asm => asm.ORR(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.16B, V31.16B, V2.16B");
        TestInst(ORR(V0.T_16B, V1.T_16B, V0.T_16B), asm => asm.ORR(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.16B, V1.16B, V0.16B");
        TestInst(ORR(V30.T_16B, V1.T_16B, V0.T_16B), asm => asm.ORR(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.16B, V1.16B, V0.16B");
        TestInst(ORR(V0.T_16B, V31.T_16B, V0.T_16B), asm => asm.ORR(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V0.16B, V31.16B, V0.16B");
        TestInst(ORR(V30.T_16B, V31.T_16B, V0.T_16B), asm => asm.ORR(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.ORR_asimdsame_only, Arm64Mnemonic.ORR, "ORR V30.16B, V31.16B, V0.16B");
    }
}
