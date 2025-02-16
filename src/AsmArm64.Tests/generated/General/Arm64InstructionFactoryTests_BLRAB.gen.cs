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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_BLRAB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BLRAB"/>.
    /// </summary>
    [TestMethod]
    public void Test_BLRAB_64p_branch_reg_0()
    {
        TestInst(BLRAB(X0, X2), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB X0, X2");
        TestInst(BLRAB(X15, X2), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB X15, X2");
        TestInst(BLRAB(XZR, X2), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB XZR, X2");
        TestInst(BLRAB(X0, X18), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB X0, X18");
        TestInst(BLRAB(X15, X18), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB X15, X18");
        TestInst(BLRAB(XZR, X18), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB XZR, X18");
        TestInst(BLRAB(X0, SP), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB X0, SP");
        TestInst(BLRAB(X15, SP), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB X15, SP");
        TestInst(BLRAB(XZR, SP), Arm64InstructionId.BLRAB_64p_branch_reg, Arm64Mnemonic.BLRAB, "BLRAB XZR, SP");
    }
}
