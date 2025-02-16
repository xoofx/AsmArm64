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
public class Arm64InstructionFactoryTests_RCWCLRA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWCLRA"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWCLRA_64_memop_0()
    {
        TestInst(RCWCLRA(X0, X1, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA X0, X1, [X3]");
        TestInst(RCWCLRA(X15, X1, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA X15, X1, [X3]");
        TestInst(RCWCLRA(XZR, X1, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA XZR, X1, [X3]");
        TestInst(RCWCLRA(X0, X16, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA X0, X16, [X3]");
        TestInst(RCWCLRA(X15, X16, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA X15, X16, [X3]");
        TestInst(RCWCLRA(XZR, X16, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA XZR, X16, [X3]");
        TestInst(RCWCLRA(X0, XZR, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA X0, XZR, [X3]");
        TestInst(RCWCLRA(X15, XZR, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA X15, XZR, [X3]");
        TestInst(RCWCLRA(XZR, XZR, _[X3]), Arm64InstructionId.RCWCLRA_64_memop, Arm64Mnemonic.RCWCLRA, "RCWCLRA XZR, XZR, [X3]");
    }
}
