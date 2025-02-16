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
public class Arm64InstructionFactoryTests_LDCLRA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDCLRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDCLRA_32_memop_0()
    {
        TestInst(LDCLRA(W0, W1, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA W0, W1, [X3]");
        TestInst(LDCLRA(W15, W1, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA W15, W1, [X3]");
        TestInst(LDCLRA(WZR, W1, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA WZR, W1, [X3]");
        TestInst(LDCLRA(W0, W16, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA W0, W16, [X3]");
        TestInst(LDCLRA(W15, W16, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA W15, W16, [X3]");
        TestInst(LDCLRA(WZR, W16, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA WZR, W16, [X3]");
        TestInst(LDCLRA(W0, WZR, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA W0, WZR, [X3]");
        TestInst(LDCLRA(W15, WZR, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA W15, WZR, [X3]");
        TestInst(LDCLRA(WZR, WZR, _[X3]), Arm64InstructionId.LDCLRA_32_memop, Arm64Mnemonic.LDCLRA, "LDCLRA WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDCLRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDCLRA_64_memop_1()
    {
        TestInst(LDCLRA(X0, X1, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA X0, X1, [X3]");
        TestInst(LDCLRA(X15, X1, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA X15, X1, [X3]");
        TestInst(LDCLRA(XZR, X1, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA XZR, X1, [X3]");
        TestInst(LDCLRA(X0, X16, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA X0, X16, [X3]");
        TestInst(LDCLRA(X15, X16, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA X15, X16, [X3]");
        TestInst(LDCLRA(XZR, X16, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA XZR, X16, [X3]");
        TestInst(LDCLRA(X0, XZR, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA X0, XZR, [X3]");
        TestInst(LDCLRA(X15, XZR, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA X15, XZR, [X3]");
        TestInst(LDCLRA(XZR, XZR, _[X3]), Arm64InstructionId.LDCLRA_64_memop, Arm64Mnemonic.LDCLRA, "LDCLRA XZR, XZR, [X3]");
    }
}
