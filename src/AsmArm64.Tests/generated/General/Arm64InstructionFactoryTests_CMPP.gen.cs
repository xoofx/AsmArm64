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
public class Arm64InstructionFactoryTests_CMPP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CMPP"/>.
    /// </summary>
    [TestMethod]
    public void Test_CMPP_subps_64s_dp_2src_0()
    {
        TestInst(CMPP(X1, X2), asm => asm.CMPP(X1, X2), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X1, X2");
        TestInst(CMPP(X17, X2), asm => asm.CMPP(X17, X2), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X17, X2");
        TestInst(CMPP(SP, X2), asm => asm.CMPP(SP, X2), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP SP, X2");
        TestInst(CMPP(X1, X18), asm => asm.CMPP(X1, X18), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X1, X18");
        TestInst(CMPP(X17, X18), asm => asm.CMPP(X17, X18), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X17, X18");
        TestInst(CMPP(SP, X18), asm => asm.CMPP(SP, X18), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP SP, X18");
        TestInst(CMPP(X1, SP), asm => asm.CMPP(X1, SP), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X1, SP");
        TestInst(CMPP(X17, SP), asm => asm.CMPP(X17, SP), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP X17, SP");
        TestInst(CMPP(SP, SP), asm => asm.CMPP(SP, SP), Arm64InstructionId.CMPP_subps_64s_dp_2src, Arm64Mnemonic.CMPP, "CMPP SP, SP");
    }
}
