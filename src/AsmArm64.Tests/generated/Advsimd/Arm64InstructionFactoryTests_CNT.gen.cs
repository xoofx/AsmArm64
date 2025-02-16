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
public class Arm64InstructionFactoryTests_CNT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CNT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CNT_asimdmisc_r_0()
    {
        TestInst(CNT(V0.T_8B, V1.T_8B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V0.8B, V1.8B");
        TestInst(CNT(V30.T_8B, V1.T_8B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V30.8B, V1.8B");
        TestInst(CNT(V0.T_8B, V31.T_8B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V0.8B, V31.8B");
        TestInst(CNT(V30.T_8B, V31.T_8B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V30.8B, V31.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CNT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CNT_asimdmisc_r_1()
    {
        TestInst(CNT(V0.T_16B, V1.T_16B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V0.16B, V1.16B");
        TestInst(CNT(V30.T_16B, V1.T_16B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V30.16B, V1.16B");
        TestInst(CNT(V0.T_16B, V31.T_16B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V0.16B, V31.16B");
        TestInst(CNT(V30.T_16B, V31.T_16B), Arm64InstructionId.CNT_asimdmisc_r, Arm64Mnemonic.CNT, "CNT V30.16B, V31.16B");
    }
}
