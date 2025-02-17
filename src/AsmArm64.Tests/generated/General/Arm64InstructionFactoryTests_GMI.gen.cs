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
public class Arm64InstructionFactoryTests_GMI_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.GMI"/>.
    /// </summary>
    [TestMethod]
    public void Test_GMI_64g_dp_2src_0()
    {
        TestInst(GMI(X0, X2, X2), asm => asm.GMI(X0, X2, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, X2, X2");
        TestInst(GMI(X15, X2, X2), asm => asm.GMI(X15, X2, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, X2, X2");
        TestInst(GMI(XZR, X2, X2), asm => asm.GMI(XZR, X2, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, X2, X2");
        TestInst(GMI(X0, X18, X2), asm => asm.GMI(X0, X18, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, X18, X2");
        TestInst(GMI(X15, X18, X2), asm => asm.GMI(X15, X18, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, X18, X2");
        TestInst(GMI(XZR, X18, X2), asm => asm.GMI(XZR, X18, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, X18, X2");
        TestInst(GMI(X0, SP, X2), asm => asm.GMI(X0, SP, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, SP, X2");
        TestInst(GMI(X15, SP, X2), asm => asm.GMI(X15, SP, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, SP, X2");
        TestInst(GMI(XZR, SP, X2), asm => asm.GMI(XZR, SP, X2), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, SP, X2");
        TestInst(GMI(X0, X2, X17), asm => asm.GMI(X0, X2, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, X2, X17");
        TestInst(GMI(X15, X2, X17), asm => asm.GMI(X15, X2, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, X2, X17");
        TestInst(GMI(XZR, X2, X17), asm => asm.GMI(XZR, X2, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, X2, X17");
        TestInst(GMI(X0, X18, X17), asm => asm.GMI(X0, X18, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, X18, X17");
        TestInst(GMI(X15, X18, X17), asm => asm.GMI(X15, X18, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, X18, X17");
        TestInst(GMI(XZR, X18, X17), asm => asm.GMI(XZR, X18, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, X18, X17");
        TestInst(GMI(X0, SP, X17), asm => asm.GMI(X0, SP, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, SP, X17");
        TestInst(GMI(X15, SP, X17), asm => asm.GMI(X15, SP, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, SP, X17");
        TestInst(GMI(XZR, SP, X17), asm => asm.GMI(XZR, SP, X17), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, SP, X17");
        TestInst(GMI(X0, X2, XZR), asm => asm.GMI(X0, X2, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, X2, XZR");
        TestInst(GMI(X15, X2, XZR), asm => asm.GMI(X15, X2, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, X2, XZR");
        TestInst(GMI(XZR, X2, XZR), asm => asm.GMI(XZR, X2, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, X2, XZR");
        TestInst(GMI(X0, X18, XZR), asm => asm.GMI(X0, X18, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, X18, XZR");
        TestInst(GMI(X15, X18, XZR), asm => asm.GMI(X15, X18, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, X18, XZR");
        TestInst(GMI(XZR, X18, XZR), asm => asm.GMI(XZR, X18, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, X18, XZR");
        TestInst(GMI(X0, SP, XZR), asm => asm.GMI(X0, SP, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X0, SP, XZR");
        TestInst(GMI(X15, SP, XZR), asm => asm.GMI(X15, SP, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI X15, SP, XZR");
        TestInst(GMI(XZR, SP, XZR), asm => asm.GMI(XZR, SP, XZR), Arm64InstructionId.GMI_64g_dp_2src, Arm64Mnemonic.GMI, "GMI XZR, SP, XZR");
    }
}
