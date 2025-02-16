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
public class Arm64InstructionFactoryTests_SWPTA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTA"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTA_32_memop_unpriv_0()
    {
        TestInst(SWPTA(W0, W1, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA W0, W1, [X3]");
        TestInst(SWPTA(W15, W1, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA W15, W1, [X3]");
        TestInst(SWPTA(WZR, W1, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA WZR, W1, [X3]");
        TestInst(SWPTA(W0, W16, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA W0, W16, [X3]");
        TestInst(SWPTA(W15, W16, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA W15, W16, [X3]");
        TestInst(SWPTA(WZR, W16, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA WZR, W16, [X3]");
        TestInst(SWPTA(W0, WZR, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA W0, WZR, [X3]");
        TestInst(SWPTA(W15, WZR, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA W15, WZR, [X3]");
        TestInst(SWPTA(WZR, WZR, _[X3]), Arm64InstructionId.SWPTA_32_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTA"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTA_64_memop_unpriv_1()
    {
        TestInst(SWPTA(X0, X1, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA X0, X1, [X3]");
        TestInst(SWPTA(X15, X1, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA X15, X1, [X3]");
        TestInst(SWPTA(XZR, X1, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA XZR, X1, [X3]");
        TestInst(SWPTA(X0, X16, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA X0, X16, [X3]");
        TestInst(SWPTA(X15, X16, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA X15, X16, [X3]");
        TestInst(SWPTA(XZR, X16, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA XZR, X16, [X3]");
        TestInst(SWPTA(X0, XZR, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA X0, XZR, [X3]");
        TestInst(SWPTA(X15, XZR, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA X15, XZR, [X3]");
        TestInst(SWPTA(XZR, XZR, _[X3]), Arm64InstructionId.SWPTA_64_memop_unpriv, Arm64Mnemonic.SWPTA, "SWPTA XZR, XZR, [X3]");
    }
}
