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
public class Arm64InstructionFactoryTests_SWP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWP_32_memop_0()
    {
        TestInst(SWP(W0, W1, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP W0, W1, [X3]");
        TestInst(SWP(W15, W1, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP W15, W1, [X3]");
        TestInst(SWP(WZR, W1, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP WZR, W1, [X3]");
        TestInst(SWP(W0, W16, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP W0, W16, [X3]");
        TestInst(SWP(W15, W16, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP W15, W16, [X3]");
        TestInst(SWP(WZR, W16, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP WZR, W16, [X3]");
        TestInst(SWP(W0, WZR, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP W0, WZR, [X3]");
        TestInst(SWP(W15, WZR, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP W15, WZR, [X3]");
        TestInst(SWP(WZR, WZR, _[X3]), Arm64InstructionId.SWP_32_memop, Arm64Mnemonic.SWP, "SWP WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWP_64_memop_1()
    {
        TestInst(SWP(X0, X1, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP X0, X1, [X3]");
        TestInst(SWP(X15, X1, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP X15, X1, [X3]");
        TestInst(SWP(XZR, X1, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP XZR, X1, [X3]");
        TestInst(SWP(X0, X16, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP X0, X16, [X3]");
        TestInst(SWP(X15, X16, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP X15, X16, [X3]");
        TestInst(SWP(XZR, X16, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP XZR, X16, [X3]");
        TestInst(SWP(X0, XZR, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP X0, XZR, [X3]");
        TestInst(SWP(X15, XZR, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP X15, XZR, [X3]");
        TestInst(SWP(XZR, XZR, _[X3]), Arm64InstructionId.SWP_64_memop, Arm64Mnemonic.SWP, "SWP XZR, XZR, [X3]");
    }
}
