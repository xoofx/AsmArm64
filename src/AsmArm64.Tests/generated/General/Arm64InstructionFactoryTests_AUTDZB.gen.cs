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
public class Arm64InstructionFactoryTests_AUTDZB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AUTDZB"/>.
    /// </summary>
    [TestMethod]
    public void Test_AUTDZB_64z_dp_1src_0()
    {
        TestInst(AUTDZB(X0), asm => asm.AUTDZB(X0), Arm64InstructionId.AUTDZB_64z_dp_1src, Arm64Mnemonic.AUTDZB, "AUTDZB X0");
        TestInst(AUTDZB(X15), asm => asm.AUTDZB(X15), Arm64InstructionId.AUTDZB_64z_dp_1src, Arm64Mnemonic.AUTDZB, "AUTDZB X15");
        TestInst(AUTDZB(XZR), asm => asm.AUTDZB(XZR), Arm64InstructionId.AUTDZB_64z_dp_1src, Arm64Mnemonic.AUTDZB, "AUTDZB XZR");
    }
}
