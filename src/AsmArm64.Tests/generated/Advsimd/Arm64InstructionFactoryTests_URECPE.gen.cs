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
public class Arm64InstructionFactoryTests_URECPE_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URECPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_URECPE_asimdmisc_r_0()
    {
        TestInst(URECPE(V0.T_2S, V1.T_2S), asm => asm.URECPE(V0.T_2S, V1.T_2S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V0.2S, V1.2S");
        TestInst(URECPE(V30.T_2S, V1.T_2S), asm => asm.URECPE(V30.T_2S, V1.T_2S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V30.2S, V1.2S");
        TestInst(URECPE(V0.T_2S, V31.T_2S), asm => asm.URECPE(V0.T_2S, V31.T_2S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V0.2S, V31.2S");
        TestInst(URECPE(V30.T_2S, V31.T_2S), asm => asm.URECPE(V30.T_2S, V31.T_2S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V30.2S, V31.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.URECPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_URECPE_asimdmisc_r_1()
    {
        TestInst(URECPE(V0.T_4S, V1.T_4S), asm => asm.URECPE(V0.T_4S, V1.T_4S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V0.4S, V1.4S");
        TestInst(URECPE(V30.T_4S, V1.T_4S), asm => asm.URECPE(V30.T_4S, V1.T_4S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V30.4S, V1.4S");
        TestInst(URECPE(V0.T_4S, V31.T_4S), asm => asm.URECPE(V0.T_4S, V31.T_4S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V0.4S, V31.4S");
        TestInst(URECPE(V30.T_4S, V31.T_4S), asm => asm.URECPE(V30.T_4S, V31.T_4S), Arm64InstructionId.URECPE_asimdmisc_r, Arm64Mnemonic.URECPE, "URECPE V30.4S, V31.4S");
    }
}
