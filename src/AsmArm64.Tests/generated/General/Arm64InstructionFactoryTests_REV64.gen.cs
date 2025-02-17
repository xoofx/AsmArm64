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
public class Arm64InstructionFactoryTests_REV64_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV64"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV64_rev_64_dp_1src_0()
    {
        TestInst(REV64(X0, X1), asm => asm.REV64(X0, X1), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X0, X1");
        TestInst(REV64(X15, X1), asm => asm.REV64(X15, X1), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X15, X1");
        TestInst(REV64(XZR, X1), asm => asm.REV64(XZR, X1), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV XZR, X1");
        TestInst(REV64(X0, X16), asm => asm.REV64(X0, X16), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X0, X16");
        TestInst(REV64(X15, X16), asm => asm.REV64(X15, X16), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X15, X16");
        TestInst(REV64(XZR, X16), asm => asm.REV64(XZR, X16), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV XZR, X16");
        TestInst(REV64(X0, XZR), asm => asm.REV64(X0, XZR), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X0, XZR");
        TestInst(REV64(X15, XZR), asm => asm.REV64(X15, XZR), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X15, XZR");
        TestInst(REV64(XZR, XZR), asm => asm.REV64(XZR, XZR), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV XZR, XZR");
    }
}
