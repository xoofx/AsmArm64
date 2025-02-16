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
public class Arm64InstructionFactoryTests_RCWSWPP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSWPP"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSWPP_128_memop_128_0()
    {
        TestInst(RCWSWPP(X0, X1, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP X0, X1, [X3]");
        TestInst(RCWSWPP(X15, X1, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP X15, X1, [X3]");
        TestInst(RCWSWPP(XZR, X1, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP XZR, X1, [X3]");
        TestInst(RCWSWPP(X0, X16, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP X0, X16, [X3]");
        TestInst(RCWSWPP(X15, X16, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP X15, X16, [X3]");
        TestInst(RCWSWPP(XZR, X16, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP XZR, X16, [X3]");
        TestInst(RCWSWPP(X0, XZR, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP X0, XZR, [X3]");
        TestInst(RCWSWPP(X15, XZR, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP X15, XZR, [X3]");
        TestInst(RCWSWPP(XZR, XZR, _[X3]), Arm64InstructionId.RCWSWPP_128_memop_128, Arm64Mnemonic.RCWSWPP, "RCWSWPP XZR, XZR, [X3]");
    }
}
