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
public class Arm64InstructionFactoryTests_SHRN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHRN_asimdshf_n_0()
    {
        TestInst(SHRN(V0.T_8B, V1.T_8H, 5), asm => asm.SHRN(V0.T_8B, V1.T_8H, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V0.8B, V1.8H, #5");
        TestInst(SHRN(V30.T_8B, V1.T_8H, 5), asm => asm.SHRN(V30.T_8B, V1.T_8H, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V30.8B, V1.8H, #5");
        TestInst(SHRN(V0.T_8B, V31.T_8H, 5), asm => asm.SHRN(V0.T_8B, V31.T_8H, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V0.8B, V31.8H, #5");
        TestInst(SHRN(V30.T_8B, V31.T_8H, 5), asm => asm.SHRN(V30.T_8B, V31.T_8H, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V30.8B, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHRN_asimdshf_n_1()
    {
        TestInst(SHRN(V0.T_4H, V1.T_4S, 5), asm => asm.SHRN(V0.T_4H, V1.T_4S, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V0.4H, V1.4S, #5");
        TestInst(SHRN(V30.T_4H, V1.T_4S, 5), asm => asm.SHRN(V30.T_4H, V1.T_4S, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V30.4H, V1.4S, #5");
        TestInst(SHRN(V0.T_4H, V31.T_4S, 5), asm => asm.SHRN(V0.T_4H, V31.T_4S, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V0.4H, V31.4S, #5");
        TestInst(SHRN(V30.T_4H, V31.T_4S, 5), asm => asm.SHRN(V30.T_4H, V31.T_4S, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V30.4H, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHRN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHRN_asimdshf_n_2()
    {
        TestInst(SHRN(V0.T_2S, V1.T_2D, 5), asm => asm.SHRN(V0.T_2S, V1.T_2D, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V0.2S, V1.2D, #5");
        TestInst(SHRN(V30.T_2S, V1.T_2D, 5), asm => asm.SHRN(V30.T_2S, V1.T_2D, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V30.2S, V1.2D, #5");
        TestInst(SHRN(V0.T_2S, V31.T_2D, 5), asm => asm.SHRN(V0.T_2S, V31.T_2D, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V0.2S, V31.2D, #5");
        TestInst(SHRN(V30.T_2S, V31.T_2D, 5), asm => asm.SHRN(V30.T_2S, V31.T_2D, 5), Arm64InstructionId.SHRN_asimdshf_n, Arm64Mnemonic.SHRN, "SHRN V30.2S, V31.2D, #5");
    }
}
