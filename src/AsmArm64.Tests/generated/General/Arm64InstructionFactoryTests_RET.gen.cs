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
public class Arm64InstructionFactoryTests_RET_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RET"/>.
    /// </summary>
    [TestMethod]
    public void Test_RET_64r_branch_reg_0()
    {
        TestInst(RET(X0), asm => asm.RET(X0), Arm64InstructionId.RET_64r_branch_reg, Arm64Mnemonic.RET, "RET X0");
        TestInst(RET(X15), asm => asm.RET(X15), Arm64InstructionId.RET_64r_branch_reg, Arm64Mnemonic.RET, "RET X15");
    }
}
