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
public class Arm64InstructionFactoryTests_LDTADDAL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTADDAL_32_memop_unpriv_0()
    {
        TestInst(LDTADDAL(W0, W1, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL W0, W1, [X3]");
        TestInst(LDTADDAL(W15, W1, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL W15, W1, [X3]");
        TestInst(LDTADDAL(WZR, W1, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL WZR, W1, [X3]");
        TestInst(LDTADDAL(W0, W16, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL W0, W16, [X3]");
        TestInst(LDTADDAL(W15, W16, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL W15, W16, [X3]");
        TestInst(LDTADDAL(WZR, W16, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL WZR, W16, [X3]");
        TestInst(LDTADDAL(W0, WZR, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL W0, WZR, [X3]");
        TestInst(LDTADDAL(W15, WZR, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL W15, WZR, [X3]");
        TestInst(LDTADDAL(WZR, WZR, _[X3]), Arm64InstructionId.LDTADDAL_32_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL WZR, WZR, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTADDAL_64_memop_unpriv_1()
    {
        TestInst(LDTADDAL(X0, X1, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL X0, X1, [X3]");
        TestInst(LDTADDAL(X15, X1, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL X15, X1, [X3]");
        TestInst(LDTADDAL(XZR, X1, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL XZR, X1, [X3]");
        TestInst(LDTADDAL(X0, X16, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL X0, X16, [X3]");
        TestInst(LDTADDAL(X15, X16, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL X15, X16, [X3]");
        TestInst(LDTADDAL(XZR, X16, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL XZR, X16, [X3]");
        TestInst(LDTADDAL(X0, XZR, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL X0, XZR, [X3]");
        TestInst(LDTADDAL(X15, XZR, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL X15, XZR, [X3]");
        TestInst(LDTADDAL(XZR, XZR, _[X3]), Arm64InstructionId.LDTADDAL_64_memop_unpriv, Arm64Mnemonic.LDTADDAL, "LDTADDAL XZR, XZR, [X3]");
    }
}
