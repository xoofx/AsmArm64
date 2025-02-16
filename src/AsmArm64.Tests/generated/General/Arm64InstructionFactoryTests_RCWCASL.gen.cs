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
public class Arm64InstructionFactoryTests_RCWCASL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWCASL"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWCASL_c64_rcwcomswap_0()
    {
        TestInst(RCWCASL(X0, X1, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL X0, X1, [X3]");
        TestInst(RCWCASL(X15, X1, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL X15, X1, [X3]");
        TestInst(RCWCASL(XZR, X1, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL XZR, X1, [X3]");
        TestInst(RCWCASL(X0, X16, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL X0, X16, [X3]");
        TestInst(RCWCASL(X15, X16, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL X15, X16, [X3]");
        TestInst(RCWCASL(XZR, X16, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL XZR, X16, [X3]");
        TestInst(RCWCASL(X0, XZR, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL X0, XZR, [X3]");
        TestInst(RCWCASL(X15, XZR, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL X15, XZR, [X3]");
        TestInst(RCWCASL(XZR, XZR, _[X3]), Arm64InstructionId.RCWCASL_c64_rcwcomswap, Arm64Mnemonic.RCWCASL, "RCWCASL XZR, XZR, [X3]");
    }
}
