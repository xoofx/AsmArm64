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
public class Arm64InstructionFactoryTests_URSRA_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asisdshf_r_0()
    {
        TestInst(URSRA(D0, D1, 5), asm => asm.URSRA(D0, D1, 5), Arm64InstructionId.URSRA_asisdshf_r, Arm64Mnemonic.URSRA, "URSRA D0, D1, #5");
        TestInst(URSRA(D31, D1, 5), asm => asm.URSRA(D31, D1, 5), Arm64InstructionId.URSRA_asisdshf_r, Arm64Mnemonic.URSRA, "URSRA D31, D1, #5");
        TestInst(URSRA(D0, D31, 5), asm => asm.URSRA(D0, D31, 5), Arm64InstructionId.URSRA_asisdshf_r, Arm64Mnemonic.URSRA, "URSRA D0, D31, #5");
        TestInst(URSRA(D31, D31, 5), asm => asm.URSRA(D31, D31, 5), Arm64InstructionId.URSRA_asisdshf_r, Arm64Mnemonic.URSRA, "URSRA D31, D31, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_1()
    {
        TestInst(URSRA(V0.T_8B, V1.T_8B, 5), asm => asm.URSRA(V0.T_8B, V1.T_8B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.8B, V1.8B, #5");
        TestInst(URSRA(V30.T_8B, V1.T_8B, 5), asm => asm.URSRA(V30.T_8B, V1.T_8B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.8B, V1.8B, #5");
        TestInst(URSRA(V0.T_8B, V31.T_8B, 5), asm => asm.URSRA(V0.T_8B, V31.T_8B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.8B, V31.8B, #5");
        TestInst(URSRA(V30.T_8B, V31.T_8B, 5), asm => asm.URSRA(V30.T_8B, V31.T_8B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.8B, V31.8B, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_2()
    {
        TestInst(URSRA(V0.T_16B, V1.T_16B, 5), asm => asm.URSRA(V0.T_16B, V1.T_16B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.16B, V1.16B, #5");
        TestInst(URSRA(V30.T_16B, V1.T_16B, 5), asm => asm.URSRA(V30.T_16B, V1.T_16B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.16B, V1.16B, #5");
        TestInst(URSRA(V0.T_16B, V31.T_16B, 5), asm => asm.URSRA(V0.T_16B, V31.T_16B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.16B, V31.16B, #5");
        TestInst(URSRA(V30.T_16B, V31.T_16B, 5), asm => asm.URSRA(V30.T_16B, V31.T_16B, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.16B, V31.16B, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_3()
    {
        TestInst(URSRA(V0.T_4H, V1.T_4H, 5), asm => asm.URSRA(V0.T_4H, V1.T_4H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.4H, V1.4H, #5");
        TestInst(URSRA(V30.T_4H, V1.T_4H, 5), asm => asm.URSRA(V30.T_4H, V1.T_4H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.4H, V1.4H, #5");
        TestInst(URSRA(V0.T_4H, V31.T_4H, 5), asm => asm.URSRA(V0.T_4H, V31.T_4H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.4H, V31.4H, #5");
        TestInst(URSRA(V30.T_4H, V31.T_4H, 5), asm => asm.URSRA(V30.T_4H, V31.T_4H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.4H, V31.4H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_4()
    {
        TestInst(URSRA(V0.T_8H, V1.T_8H, 5), asm => asm.URSRA(V0.T_8H, V1.T_8H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.8H, V1.8H, #5");
        TestInst(URSRA(V30.T_8H, V1.T_8H, 5), asm => asm.URSRA(V30.T_8H, V1.T_8H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.8H, V1.8H, #5");
        TestInst(URSRA(V0.T_8H, V31.T_8H, 5), asm => asm.URSRA(V0.T_8H, V31.T_8H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.8H, V31.8H, #5");
        TestInst(URSRA(V30.T_8H, V31.T_8H, 5), asm => asm.URSRA(V30.T_8H, V31.T_8H, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.8H, V31.8H, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_5()
    {
        TestInst(URSRA(V0.T_2S, V1.T_2S, 5), asm => asm.URSRA(V0.T_2S, V1.T_2S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.2S, V1.2S, #5");
        TestInst(URSRA(V30.T_2S, V1.T_2S, 5), asm => asm.URSRA(V30.T_2S, V1.T_2S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.2S, V1.2S, #5");
        TestInst(URSRA(V0.T_2S, V31.T_2S, 5), asm => asm.URSRA(V0.T_2S, V31.T_2S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.2S, V31.2S, #5");
        TestInst(URSRA(V30.T_2S, V31.T_2S, 5), asm => asm.URSRA(V30.T_2S, V31.T_2S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.2S, V31.2S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_6()
    {
        TestInst(URSRA(V0.T_4S, V1.T_4S, 5), asm => asm.URSRA(V0.T_4S, V1.T_4S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.4S, V1.4S, #5");
        TestInst(URSRA(V30.T_4S, V1.T_4S, 5), asm => asm.URSRA(V30.T_4S, V1.T_4S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.4S, V1.4S, #5");
        TestInst(URSRA(V0.T_4S, V31.T_4S, 5), asm => asm.URSRA(V0.T_4S, V31.T_4S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.4S, V31.4S, #5");
        TestInst(URSRA(V30.T_4S, V31.T_4S, 5), asm => asm.URSRA(V30.T_4S, V31.T_4S, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.4S, V31.4S, #5");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URSRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_URSRA_asimdshf_r_7()
    {
        TestInst(URSRA(V0.T_2D, V1.T_2D, 5), asm => asm.URSRA(V0.T_2D, V1.T_2D, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.2D, V1.2D, #5");
        TestInst(URSRA(V30.T_2D, V1.T_2D, 5), asm => asm.URSRA(V30.T_2D, V1.T_2D, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.2D, V1.2D, #5");
        TestInst(URSRA(V0.T_2D, V31.T_2D, 5), asm => asm.URSRA(V0.T_2D, V31.T_2D, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V0.2D, V31.2D, #5");
        TestInst(URSRA(V30.T_2D, V31.T_2D, 5), asm => asm.URSRA(V30.T_2D, V31.T_2D, 5), Arm64InstructionId.URSRA_asimdshf_r, Arm64Mnemonic.URSRA, "URSRA V30.2D, V31.2D, #5");
    }
}
