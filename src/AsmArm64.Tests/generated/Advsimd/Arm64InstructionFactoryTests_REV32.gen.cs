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
public class Arm64InstructionFactoryTests_REV32_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV32"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV32_asimdmisc_r_0()
    {
        TestInst(REV32(V0.T_8B, V1.T_8B), asm => asm.REV32(V0.T_8B, V1.T_8B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.8B, V1.8B");
        TestInst(REV32(V30.T_8B, V1.T_8B), asm => asm.REV32(V30.T_8B, V1.T_8B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.8B, V1.8B");
        TestInst(REV32(V0.T_8B, V31.T_8B), asm => asm.REV32(V0.T_8B, V31.T_8B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.8B, V31.8B");
        TestInst(REV32(V30.T_8B, V31.T_8B), asm => asm.REV32(V30.T_8B, V31.T_8B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.8B, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV32"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV32_asimdmisc_r_1()
    {
        TestInst(REV32(V0.T_16B, V1.T_16B), asm => asm.REV32(V0.T_16B, V1.T_16B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.16B, V1.16B");
        TestInst(REV32(V30.T_16B, V1.T_16B), asm => asm.REV32(V30.T_16B, V1.T_16B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.16B, V1.16B");
        TestInst(REV32(V0.T_16B, V31.T_16B), asm => asm.REV32(V0.T_16B, V31.T_16B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.16B, V31.16B");
        TestInst(REV32(V30.T_16B, V31.T_16B), asm => asm.REV32(V30.T_16B, V31.T_16B), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.16B, V31.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV32"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV32_asimdmisc_r_2()
    {
        TestInst(REV32(V0.T_4H, V1.T_4H), asm => asm.REV32(V0.T_4H, V1.T_4H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.4H, V1.4H");
        TestInst(REV32(V30.T_4H, V1.T_4H), asm => asm.REV32(V30.T_4H, V1.T_4H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.4H, V1.4H");
        TestInst(REV32(V0.T_4H, V31.T_4H), asm => asm.REV32(V0.T_4H, V31.T_4H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.4H, V31.4H");
        TestInst(REV32(V30.T_4H, V31.T_4H), asm => asm.REV32(V30.T_4H, V31.T_4H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.4H, V31.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV32"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV32_asimdmisc_r_3()
    {
        TestInst(REV32(V0.T_8H, V1.T_8H), asm => asm.REV32(V0.T_8H, V1.T_8H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.8H, V1.8H");
        TestInst(REV32(V30.T_8H, V1.T_8H), asm => asm.REV32(V30.T_8H, V1.T_8H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.8H, V1.8H");
        TestInst(REV32(V0.T_8H, V31.T_8H), asm => asm.REV32(V0.T_8H, V31.T_8H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V0.8H, V31.8H");
        TestInst(REV32(V30.T_8H, V31.T_8H), asm => asm.REV32(V30.T_8H, V31.T_8H), Arm64InstructionId.REV32_asimdmisc_r, Arm64Mnemonic.REV32, "REV32 V30.8H, V31.8H");
    }
}
