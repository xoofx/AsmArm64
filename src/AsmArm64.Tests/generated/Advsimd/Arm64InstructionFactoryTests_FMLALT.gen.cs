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
public class Arm64InstructionFactoryTests_FMLALT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALT_asimdelem_h_0()
    {
        TestInst(FMLALT(V0.T_8H, V1.T_16B, V2.B[1]), asm => asm.FMLALT(V0.T_8H, V1.T_16B, V2.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V1.16B, V2.B[1]");
        TestInst(FMLALT(V30.T_8H, V1.T_16B, V2.B[1]), asm => asm.FMLALT(V30.T_8H, V1.T_16B, V2.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V1.16B, V2.B[1]");
        TestInst(FMLALT(V0.T_8H, V31.T_16B, V2.B[1]), asm => asm.FMLALT(V0.T_8H, V31.T_16B, V2.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V31.16B, V2.B[1]");
        TestInst(FMLALT(V30.T_8H, V31.T_16B, V2.B[1]), asm => asm.FMLALT(V30.T_8H, V31.T_16B, V2.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V31.16B, V2.B[1]");
        TestInst(FMLALT(V0.T_8H, V1.T_16B, V0.B[1]), asm => asm.FMLALT(V0.T_8H, V1.T_16B, V0.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V1.16B, V0.B[1]");
        TestInst(FMLALT(V30.T_8H, V1.T_16B, V0.B[1]), asm => asm.FMLALT(V30.T_8H, V1.T_16B, V0.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V1.16B, V0.B[1]");
        TestInst(FMLALT(V0.T_8H, V31.T_16B, V0.B[1]), asm => asm.FMLALT(V0.T_8H, V31.T_16B, V0.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V31.16B, V0.B[1]");
        TestInst(FMLALT(V30.T_8H, V31.T_16B, V0.B[1]), asm => asm.FMLALT(V30.T_8H, V31.T_16B, V0.B[1]), Arm64InstructionId.FMLALT_asimdelem_h, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V31.16B, V0.B[1]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FMLALT"/>.
    /// </summary>
    [TestMethod]
    public void Test_FMLALT_asimdsame2_j_1()
    {
        TestInst(FMLALT(V0.T_8H, V1.T_16B, V2.T_16B), asm => asm.FMLALT(V0.T_8H, V1.T_16B, V2.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V1.16B, V2.16B");
        TestInst(FMLALT(V30.T_8H, V1.T_16B, V2.T_16B), asm => asm.FMLALT(V30.T_8H, V1.T_16B, V2.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V1.16B, V2.16B");
        TestInst(FMLALT(V0.T_8H, V31.T_16B, V2.T_16B), asm => asm.FMLALT(V0.T_8H, V31.T_16B, V2.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V31.16B, V2.16B");
        TestInst(FMLALT(V30.T_8H, V31.T_16B, V2.T_16B), asm => asm.FMLALT(V30.T_8H, V31.T_16B, V2.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V31.16B, V2.16B");
        TestInst(FMLALT(V0.T_8H, V1.T_16B, V0.T_16B), asm => asm.FMLALT(V0.T_8H, V1.T_16B, V0.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V1.16B, V0.16B");
        TestInst(FMLALT(V30.T_8H, V1.T_16B, V0.T_16B), asm => asm.FMLALT(V30.T_8H, V1.T_16B, V0.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V1.16B, V0.16B");
        TestInst(FMLALT(V0.T_8H, V31.T_16B, V0.T_16B), asm => asm.FMLALT(V0.T_8H, V31.T_16B, V0.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V0.8H, V31.16B, V0.16B");
        TestInst(FMLALT(V30.T_8H, V31.T_16B, V0.T_16B), asm => asm.FMLALT(V30.T_8H, V31.T_16B, V0.T_16B), Arm64InstructionId.FMLALT_asimdsame2_j, Arm64Mnemonic.FMLALT, "FMLALT V30.8H, V31.16B, V0.16B");
    }
}
