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
public class Arm64InstructionFactoryTests_RCWCAS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWCAS"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWCAS_c64_rcwcomswap_0()
    {
        TestInst(RCWCAS(X0, X1, _[X3]), asm => asm.RCWCAS(X0, X1, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS X0, X1, [X3]");
        TestInst(RCWCAS(X15, X1, _[X3]), asm => asm.RCWCAS(X15, X1, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS X15, X1, [X3]");
        TestInst(RCWCAS(XZR, X1, _[X3]), asm => asm.RCWCAS(XZR, X1, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS XZR, X1, [X3]");
        TestInst(RCWCAS(X0, X16, _[X3]), asm => asm.RCWCAS(X0, X16, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS X0, X16, [X3]");
        TestInst(RCWCAS(X15, X16, _[X3]), asm => asm.RCWCAS(X15, X16, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS X15, X16, [X3]");
        TestInst(RCWCAS(XZR, X16, _[X3]), asm => asm.RCWCAS(XZR, X16, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS XZR, X16, [X3]");
        TestInst(RCWCAS(X0, XZR, _[X3]), asm => asm.RCWCAS(X0, XZR, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS X0, XZR, [X3]");
        TestInst(RCWCAS(X15, XZR, _[X3]), asm => asm.RCWCAS(X15, XZR, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS X15, XZR, [X3]");
        TestInst(RCWCAS(XZR, XZR, _[X3]), asm => asm.RCWCAS(XZR, XZR, _[X3]), Arm64InstructionId.RCWCAS_c64_rcwcomswap, Arm64Mnemonic.RCWCAS, "RCWCAS XZR, XZR, [X3]");
    }
}
