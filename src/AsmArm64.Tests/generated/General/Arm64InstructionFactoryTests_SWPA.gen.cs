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
public class Arm64InstructionFactoryTests_SWPA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPA"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPA_32_memop_0()
    {
        TestInst(SWPA(W0, W1, _[X3]), asm => asm.SWPA(W0, W1, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA W0, W1, [X3]");
        TestInst(SWPA(W15, W1, _[X3]), asm => asm.SWPA(W15, W1, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA W15, W1, [X3]");
        TestInst(SWPA(WZR, W1, _[X3]), asm => asm.SWPA(WZR, W1, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA WZR, W1, [X3]");
        TestInst(SWPA(W0, W16, _[X3]), asm => asm.SWPA(W0, W16, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA W0, W16, [X3]");
        TestInst(SWPA(W15, W16, _[X3]), asm => asm.SWPA(W15, W16, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA W15, W16, [X3]");
        TestInst(SWPA(WZR, W16, _[X3]), asm => asm.SWPA(WZR, W16, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA WZR, W16, [X3]");
        TestInst(SWPA(W0, WZR, _[X3]), asm => asm.SWPA(W0, WZR, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA W0, WZR, [X3]");
        TestInst(SWPA(W15, WZR, _[X3]), asm => asm.SWPA(W15, WZR, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA W15, WZR, [X3]");
        TestInst(SWPA(WZR, WZR, _[X3]), asm => asm.SWPA(WZR, WZR, _[X3]), Arm64InstructionId.SWPA_32_memop, Arm64Mnemonic.SWPA, "SWPA WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPA"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPA_64_memop_1()
    {
        TestInst(SWPA(X0, X1, _[X3]), asm => asm.SWPA(X0, X1, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA X0, X1, [X3]");
        TestInst(SWPA(X15, X1, _[X3]), asm => asm.SWPA(X15, X1, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA X15, X1, [X3]");
        TestInst(SWPA(XZR, X1, _[X3]), asm => asm.SWPA(XZR, X1, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA XZR, X1, [X3]");
        TestInst(SWPA(X0, X16, _[X3]), asm => asm.SWPA(X0, X16, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA X0, X16, [X3]");
        TestInst(SWPA(X15, X16, _[X3]), asm => asm.SWPA(X15, X16, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA X15, X16, [X3]");
        TestInst(SWPA(XZR, X16, _[X3]), asm => asm.SWPA(XZR, X16, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA XZR, X16, [X3]");
        TestInst(SWPA(X0, XZR, _[X3]), asm => asm.SWPA(X0, XZR, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA X0, XZR, [X3]");
        TestInst(SWPA(X15, XZR, _[X3]), asm => asm.SWPA(X15, XZR, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA X15, XZR, [X3]");
        TestInst(SWPA(XZR, XZR, _[X3]), asm => asm.SWPA(XZR, XZR, _[X3]), Arm64InstructionId.SWPA_64_memop, Arm64Mnemonic.SWPA, "SWPA XZR, XZR, [X3]");
    }
}
