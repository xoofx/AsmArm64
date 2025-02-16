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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STTNP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTNP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTNP_64_ldstnapair_offs_0()
    {
        TestInst(STTNP(X0, X1, _[X3, 5]), asm => asm.STTNP(X0, X1, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP X0, X1, [X3, #5]");
        TestInst(STTNP(X15, X1, _[X3, 5]), asm => asm.STTNP(X15, X1, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP X15, X1, [X3, #5]");
        TestInst(STTNP(XZR, X1, _[X3, 5]), asm => asm.STTNP(XZR, X1, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP XZR, X1, [X3, #5]");
        TestInst(STTNP(X0, X16, _[X3, 5]), asm => asm.STTNP(X0, X16, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP X0, X16, [X3, #5]");
        TestInst(STTNP(X15, X16, _[X3, 5]), asm => asm.STTNP(X15, X16, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP X15, X16, [X3, #5]");
        TestInst(STTNP(XZR, X16, _[X3, 5]), asm => asm.STTNP(XZR, X16, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP XZR, X16, [X3, #5]");
        TestInst(STTNP(X0, XZR, _[X3, 5]), asm => asm.STTNP(X0, XZR, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP X0, XZR, [X3, #5]");
        TestInst(STTNP(X15, XZR, _[X3, 5]), asm => asm.STTNP(X15, XZR, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP X15, XZR, [X3, #5]");
        TestInst(STTNP(XZR, XZR, _[X3, 5]), asm => asm.STTNP(XZR, XZR, _[X3, 5]), Arm64InstructionId.STTNP_64_ldstnapair_offs, Arm64Mnemonic.STTNP, "STTNP XZR, XZR, [X3, #5]");
    }
}
