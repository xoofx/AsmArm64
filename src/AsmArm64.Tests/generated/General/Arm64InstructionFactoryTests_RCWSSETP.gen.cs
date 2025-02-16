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
public class Arm64InstructionFactoryTests_RCWSSETP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSSETP"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSSETP_128_memop_128_0()
    {
        TestInst(RCWSSETP(X0, X1, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP X0, X1, [X3]");
        TestInst(RCWSSETP(X15, X1, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP X15, X1, [X3]");
        TestInst(RCWSSETP(XZR, X1, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP XZR, X1, [X3]");
        TestInst(RCWSSETP(X0, X16, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP X0, X16, [X3]");
        TestInst(RCWSSETP(X15, X16, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP X15, X16, [X3]");
        TestInst(RCWSSETP(XZR, X16, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP XZR, X16, [X3]");
        TestInst(RCWSSETP(X0, XZR, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP X0, XZR, [X3]");
        TestInst(RCWSSETP(X15, XZR, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP X15, XZR, [X3]");
        TestInst(RCWSSETP(XZR, XZR, _[X3]), Arm64InstructionId.RCWSSETP_128_memop_128, Arm64Mnemonic.RCWSSETP, "RCWSSETP XZR, XZR, [X3]");
    }
}
