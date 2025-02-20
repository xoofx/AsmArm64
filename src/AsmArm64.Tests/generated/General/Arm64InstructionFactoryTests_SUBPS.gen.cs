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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_SUBPS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SUBPS"/>.
    /// </summary>
    [TestMethod]
    public void Test_SUBPS_64s_dp_2src_0()
    {
        TestInst(SUBPS(X0, X2, X3), asm => asm.SUBPS(X0, X2, X3), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, X2, X3");
        TestInst(SUBPS(X15, X2, X3), asm => asm.SUBPS(X15, X2, X3), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, X2, X3");
        TestInst(SUBPS(XZR, X2, X3), asm => asm.SUBPS(XZR, X2, X3), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X2, X3");
        TestInst(SUBPS(X0, X18, X3), asm => asm.SUBPS(X0, X18, X3), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, X18, X3");
        TestInst(SUBPS(X15, X18, X3), asm => asm.SUBPS(X15, X18, X3), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, X18, X3");
        TestInst(SUBPS(XZR, X18, X3), asm => asm.SUBPS(XZR, X18, X3), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X18, X3");
        TestInst(SUBPS(X0, SP, X3), asm => asm.SUBPS(X0, SP, X3), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, SP, X3");
        TestInst(SUBPS(X15, SP, X3), asm => asm.SUBPS(X15, SP, X3), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, SP, X3");
        TestInst(SUBPS(XZR, SP, X3), asm => asm.SUBPS(XZR, SP, X3), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP SP, X3");
        TestInst(SUBPS(X0, X2, X19), asm => asm.SUBPS(X0, X2, X19), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, X2, X19");
        TestInst(SUBPS(X15, X2, X19), asm => asm.SUBPS(X15, X2, X19), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, X2, X19");
        TestInst(SUBPS(XZR, X2, X19), asm => asm.SUBPS(XZR, X2, X19), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X2, X19");
        TestInst(SUBPS(X0, X18, X19), asm => asm.SUBPS(X0, X18, X19), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, X18, X19");
        TestInst(SUBPS(X15, X18, X19), asm => asm.SUBPS(X15, X18, X19), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, X18, X19");
        TestInst(SUBPS(XZR, X18, X19), asm => asm.SUBPS(XZR, X18, X19), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X18, X19");
        TestInst(SUBPS(X0, SP, X19), asm => asm.SUBPS(X0, SP, X19), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, SP, X19");
        TestInst(SUBPS(X15, SP, X19), asm => asm.SUBPS(X15, SP, X19), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, SP, X19");
        TestInst(SUBPS(XZR, SP, X19), asm => asm.SUBPS(XZR, SP, X19), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP SP, X19");
        TestInst(SUBPS(X0, X2, SP), asm => asm.SUBPS(X0, X2, SP), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, X2, SP");
        TestInst(SUBPS(X15, X2, SP), asm => asm.SUBPS(X15, X2, SP), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, X2, SP");
        TestInst(SUBPS(XZR, X2, SP), asm => asm.SUBPS(XZR, X2, SP), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X2, SP");
        TestInst(SUBPS(X0, X18, SP), asm => asm.SUBPS(X0, X18, SP), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, X18, SP");
        TestInst(SUBPS(X15, X18, SP), asm => asm.SUBPS(X15, X18, SP), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, X18, SP");
        TestInst(SUBPS(XZR, X18, SP), asm => asm.SUBPS(XZR, X18, SP), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X18, SP");
        TestInst(SUBPS(X0, SP, SP), asm => asm.SUBPS(X0, SP, SP), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X0, SP, SP");
        TestInst(SUBPS(X15, SP, SP), asm => asm.SUBPS(X15, SP, SP), Arm64InstructionId.SUBPS_64s_dp_2src, Arm64Mnemonic.SUBPS, "SUBPS X15, SP, SP");
        TestInst(SUBPS(XZR, SP, SP), asm => asm.SUBPS(XZR, SP, SP), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP SP, SP");
    }
}
