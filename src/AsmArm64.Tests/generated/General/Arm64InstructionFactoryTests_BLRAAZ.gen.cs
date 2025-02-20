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
public class Arm64InstructionFactoryTests_BLRAAZ_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BLRAAZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_BLRAAZ_64_branch_reg_0()
    {
        TestInst(BLRAAZ(X0), asm => asm.BLRAAZ(X0), Arm64InstructionId.BLRAAZ_64_branch_reg, Arm64Mnemonic.BLRAAZ, "BLRAAZ X0");
        TestInst(BLRAAZ(X15), asm => asm.BLRAAZ(X15), Arm64InstructionId.BLRAAZ_64_branch_reg, Arm64Mnemonic.BLRAAZ, "BLRAAZ X15");
        TestInst(BLRAAZ(XZR), asm => asm.BLRAAZ(XZR), Arm64InstructionId.BLRAAZ_64_branch_reg, Arm64Mnemonic.BLRAAZ, "BLRAAZ XZR");
    }
}
