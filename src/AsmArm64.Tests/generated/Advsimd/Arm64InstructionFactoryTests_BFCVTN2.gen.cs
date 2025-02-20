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
public class Arm64InstructionFactoryTests_BFCVTN2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BFCVTN2"/>.
    /// </summary>
    [TestMethod]
    public void Test_BFCVTN2_asimdmisc_4s_0()
    {
        TestInst(BFCVTN2(V0.T_8H, V1.T_4S), asm => asm.BFCVTN2(V0.T_8H, V1.T_4S), Arm64InstructionId.BFCVTN2_asimdmisc_4s, Arm64Mnemonic.BFCVTN2, "BFCVTN2 V0.8H, V1.4S");
        TestInst(BFCVTN2(V30.T_8H, V1.T_4S), asm => asm.BFCVTN2(V30.T_8H, V1.T_4S), Arm64InstructionId.BFCVTN2_asimdmisc_4s, Arm64Mnemonic.BFCVTN2, "BFCVTN2 V30.8H, V1.4S");
        TestInst(BFCVTN2(V0.T_8H, V31.T_4S), asm => asm.BFCVTN2(V0.T_8H, V31.T_4S), Arm64InstructionId.BFCVTN2_asimdmisc_4s, Arm64Mnemonic.BFCVTN2, "BFCVTN2 V0.8H, V31.4S");
        TestInst(BFCVTN2(V30.T_8H, V31.T_4S), asm => asm.BFCVTN2(V30.T_8H, V31.T_4S), Arm64InstructionId.BFCVTN2_asimdmisc_4s, Arm64Mnemonic.BFCVTN2, "BFCVTN2 V30.8H, V31.4S");
    }
}
