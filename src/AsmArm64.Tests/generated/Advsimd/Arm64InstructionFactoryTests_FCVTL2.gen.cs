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
public class Arm64InstructionFactoryTests_FCVTL2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTL2_asimdmisc_l_0()
    {
        TestInst(FCVTL2(V0.T_4S, V1.T_8H), asm => asm.FCVTL2(V0.T_4S, V1.T_8H), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V0.4S, V1.8H");
        TestInst(FCVTL2(V30.T_4S, V1.T_8H), asm => asm.FCVTL2(V30.T_4S, V1.T_8H), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V30.4S, V1.8H");
        TestInst(FCVTL2(V0.T_4S, V31.T_8H), asm => asm.FCVTL2(V0.T_4S, V31.T_8H), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V0.4S, V31.8H");
        TestInst(FCVTL2(V30.T_4S, V31.T_8H), asm => asm.FCVTL2(V30.T_4S, V31.T_8H), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V30.4S, V31.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCVTL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCVTL2_asimdmisc_l_1()
    {
        TestInst(FCVTL2(V0.T_2D, V1.T_4S), asm => asm.FCVTL2(V0.T_2D, V1.T_4S), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V0.2D, V1.4S");
        TestInst(FCVTL2(V30.T_2D, V1.T_4S), asm => asm.FCVTL2(V30.T_2D, V1.T_4S), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V30.2D, V1.4S");
        TestInst(FCVTL2(V0.T_2D, V31.T_4S), asm => asm.FCVTL2(V0.T_2D, V31.T_4S), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V0.2D, V31.4S");
        TestInst(FCVTL2(V30.T_2D, V31.T_4S), asm => asm.FCVTL2(V30.T_2D, V31.T_4S), Arm64InstructionId.FCVTL2_asimdmisc_l, Arm64Mnemonic.FCVTL2, "FCVTL2 V30.2D, V31.4S");
    }
}
