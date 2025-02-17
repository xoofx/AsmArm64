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
public class Arm64InstructionFactoryTests_FMLALLBT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALLBT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALLBT_asimdelem_j_0()
    {
        TestInst(FMLALLBT(V0.T_4S, V1.T_16B, V2.B[1]), asm => asm.FMLALLBT(V0.T_4S, V1.T_16B, V2.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V1.16B, V2.B[1]");
        TestInst(FMLALLBT(V30.T_4S, V1.T_16B, V2.B[1]), asm => asm.FMLALLBT(V30.T_4S, V1.T_16B, V2.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V1.16B, V2.B[1]");
        TestInst(FMLALLBT(V0.T_4S, V31.T_16B, V2.B[1]), asm => asm.FMLALLBT(V0.T_4S, V31.T_16B, V2.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V31.16B, V2.B[1]");
        TestInst(FMLALLBT(V30.T_4S, V31.T_16B, V2.B[1]), asm => asm.FMLALLBT(V30.T_4S, V31.T_16B, V2.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V31.16B, V2.B[1]");
        TestInst(FMLALLBT(V0.T_4S, V1.T_16B, V0.B[1]), asm => asm.FMLALLBT(V0.T_4S, V1.T_16B, V0.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V1.16B, V0.B[1]");
        TestInst(FMLALLBT(V30.T_4S, V1.T_16B, V0.B[1]), asm => asm.FMLALLBT(V30.T_4S, V1.T_16B, V0.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V1.16B, V0.B[1]");
        TestInst(FMLALLBT(V0.T_4S, V31.T_16B, V0.B[1]), asm => asm.FMLALLBT(V0.T_4S, V31.T_16B, V0.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V31.16B, V0.B[1]");
        TestInst(FMLALLBT(V30.T_4S, V31.T_16B, V0.B[1]), asm => asm.FMLALLBT(V30.T_4S, V31.T_16B, V0.B[1]), Arm64InstructionId.FMLALLBT_asimdelem_j, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V31.16B, V0.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALLBT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALLBT_asimdsame2_g_1()
    {
        TestInst(FMLALLBT(V0.T_4S, V1.T_16B, V2.T_16B), asm => asm.FMLALLBT(V0.T_4S, V1.T_16B, V2.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V1.16B, V2.16B");
        TestInst(FMLALLBT(V30.T_4S, V1.T_16B, V2.T_16B), asm => asm.FMLALLBT(V30.T_4S, V1.T_16B, V2.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V1.16B, V2.16B");
        TestInst(FMLALLBT(V0.T_4S, V31.T_16B, V2.T_16B), asm => asm.FMLALLBT(V0.T_4S, V31.T_16B, V2.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V31.16B, V2.16B");
        TestInst(FMLALLBT(V30.T_4S, V31.T_16B, V2.T_16B), asm => asm.FMLALLBT(V30.T_4S, V31.T_16B, V2.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V31.16B, V2.16B");
        TestInst(FMLALLBT(V0.T_4S, V1.T_16B, V0.T_16B), asm => asm.FMLALLBT(V0.T_4S, V1.T_16B, V0.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V1.16B, V0.16B");
        TestInst(FMLALLBT(V30.T_4S, V1.T_16B, V0.T_16B), asm => asm.FMLALLBT(V30.T_4S, V1.T_16B, V0.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V1.16B, V0.16B");
        TestInst(FMLALLBT(V0.T_4S, V31.T_16B, V0.T_16B), asm => asm.FMLALLBT(V0.T_4S, V31.T_16B, V0.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V0.4S, V31.16B, V0.16B");
        TestInst(FMLALLBT(V30.T_4S, V31.T_16B, V0.T_16B), asm => asm.FMLALLBT(V30.T_4S, V31.T_16B, V0.T_16B), Arm64InstructionId.FMLALLBT_asimdsame2_g, Arm64Mnemonic.FMLALLBT, "FMLALLBT V30.4S, V31.16B, V0.16B");
    }
}
