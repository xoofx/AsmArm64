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
public class Arm64InstructionFactoryTests_LDTNP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTNP_64_ldstnapair_offs_0()
    {
        TestInst(LDTNP(X0, X1, _[X3, 5]), asm => asm.LDTNP(X0, X1, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP X0, X1, [X3, #5]");
        TestInst(LDTNP(X15, X1, _[X3, 5]), asm => asm.LDTNP(X15, X1, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP X15, X1, [X3, #5]");
        TestInst(LDTNP(XZR, X1, _[X3, 5]), asm => asm.LDTNP(XZR, X1, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP XZR, X1, [X3, #5]");
        TestInst(LDTNP(X0, X16, _[X3, 5]), asm => asm.LDTNP(X0, X16, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP X0, X16, [X3, #5]");
        TestInst(LDTNP(X15, X16, _[X3, 5]), asm => asm.LDTNP(X15, X16, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP X15, X16, [X3, #5]");
        TestInst(LDTNP(XZR, X16, _[X3, 5]), asm => asm.LDTNP(XZR, X16, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP XZR, X16, [X3, #5]");
        TestInst(LDTNP(X0, XZR, _[X3, 5]), asm => asm.LDTNP(X0, XZR, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP X0, XZR, [X3, #5]");
        TestInst(LDTNP(X15, XZR, _[X3, 5]), asm => asm.LDTNP(X15, XZR, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP X15, XZR, [X3, #5]");
        TestInst(LDTNP(XZR, XZR, _[X3, 5]), asm => asm.LDTNP(XZR, XZR, _[X3, 5]), Arm64InstructionId.LDTNP_64_ldstnapair_offs, Arm64Mnemonic.LDTNP, "LDTNP XZR, XZR, [X3, #5]");
    }
}
