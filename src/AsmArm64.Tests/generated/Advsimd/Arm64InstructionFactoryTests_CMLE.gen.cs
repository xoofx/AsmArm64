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
public class Arm64InstructionFactoryTests_CMLE_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asisdmisc_z_0()
    {
        TestInst(CMLE(D0, D1, 0), Arm64InstructionId.CMLE_asisdmisc_z, Arm64Mnemonic.CMLE, "CMLE D0, D1, #0");
        TestInst(CMLE(D31, D1, 0), Arm64InstructionId.CMLE_asisdmisc_z, Arm64Mnemonic.CMLE, "CMLE D31, D1, #0");
        TestInst(CMLE(D0, D31, 0), Arm64InstructionId.CMLE_asisdmisc_z, Arm64Mnemonic.CMLE, "CMLE D0, D31, #0");
        TestInst(CMLE(D31, D31, 0), Arm64InstructionId.CMLE_asisdmisc_z, Arm64Mnemonic.CMLE, "CMLE D31, D31, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_1()
    {
        TestInst(CMLE(V0.T_8B, V1.T_8B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.8B, V1.8B, #0");
        TestInst(CMLE(V30.T_8B, V1.T_8B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.8B, V1.8B, #0");
        TestInst(CMLE(V0.T_8B, V31.T_8B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.8B, V31.8B, #0");
        TestInst(CMLE(V30.T_8B, V31.T_8B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.8B, V31.8B, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_2()
    {
        TestInst(CMLE(V0.T_16B, V1.T_16B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.16B, V1.16B, #0");
        TestInst(CMLE(V30.T_16B, V1.T_16B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.16B, V1.16B, #0");
        TestInst(CMLE(V0.T_16B, V31.T_16B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.16B, V31.16B, #0");
        TestInst(CMLE(V30.T_16B, V31.T_16B, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.16B, V31.16B, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_3()
    {
        TestInst(CMLE(V0.T_4H, V1.T_4H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.4H, V1.4H, #0");
        TestInst(CMLE(V30.T_4H, V1.T_4H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.4H, V1.4H, #0");
        TestInst(CMLE(V0.T_4H, V31.T_4H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.4H, V31.4H, #0");
        TestInst(CMLE(V30.T_4H, V31.T_4H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.4H, V31.4H, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_4()
    {
        TestInst(CMLE(V0.T_8H, V1.T_8H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.8H, V1.8H, #0");
        TestInst(CMLE(V30.T_8H, V1.T_8H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.8H, V1.8H, #0");
        TestInst(CMLE(V0.T_8H, V31.T_8H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.8H, V31.8H, #0");
        TestInst(CMLE(V30.T_8H, V31.T_8H, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.8H, V31.8H, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_5()
    {
        TestInst(CMLE(V0.T_2S, V1.T_2S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.2S, V1.2S, #0");
        TestInst(CMLE(V30.T_2S, V1.T_2S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.2S, V1.2S, #0");
        TestInst(CMLE(V0.T_2S, V31.T_2S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.2S, V31.2S, #0");
        TestInst(CMLE(V30.T_2S, V31.T_2S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.2S, V31.2S, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_6()
    {
        TestInst(CMLE(V0.T_4S, V1.T_4S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.4S, V1.4S, #0");
        TestInst(CMLE(V30.T_4S, V1.T_4S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.4S, V1.4S, #0");
        TestInst(CMLE(V0.T_4S, V31.T_4S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.4S, V31.4S, #0");
        TestInst(CMLE(V30.T_4S, V31.T_4S, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.4S, V31.4S, #0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMLE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMLE_asimdmisc_z_7()
    {
        TestInst(CMLE(V0.T_2D, V1.T_2D, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.2D, V1.2D, #0");
        TestInst(CMLE(V30.T_2D, V1.T_2D, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.2D, V1.2D, #0");
        TestInst(CMLE(V0.T_2D, V31.T_2D, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V0.2D, V31.2D, #0");
        TestInst(CMLE(V30.T_2D, V31.T_2D, 0), Arm64InstructionId.CMLE_asimdmisc_z, Arm64Mnemonic.CMLE, "CMLE V30.2D, V31.2D, #0");
    }
}
