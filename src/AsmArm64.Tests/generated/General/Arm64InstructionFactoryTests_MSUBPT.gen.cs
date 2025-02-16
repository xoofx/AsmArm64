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
public class Arm64InstructionFactoryTests_MSUBPT_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MSUBPT"/>.
    /// </summary>
    [TestMethod]
    public void Test_MSUBPT_64a_dp_3src_0()
    {
        TestInst(MSUBPT(X0, X1, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, X2, X3");
        TestInst(MSUBPT(X15, X1, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, X2, X3");
        TestInst(MSUBPT(XZR, X1, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, X2, X3");
        TestInst(MSUBPT(X0, X16, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, X2, X3");
        TestInst(MSUBPT(X15, X16, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, X2, X3");
        TestInst(MSUBPT(XZR, X16, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, X2, X3");
        TestInst(MSUBPT(X0, XZR, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, X2, X3");
        TestInst(MSUBPT(X15, XZR, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, X2, X3");
        TestInst(MSUBPT(XZR, XZR, X2, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, X2, X3");
        TestInst(MSUBPT(X0, X1, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, X17, X3");
        TestInst(MSUBPT(X15, X1, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, X17, X3");
        TestInst(MSUBPT(XZR, X1, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, X17, X3");
        TestInst(MSUBPT(X0, X16, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, X17, X3");
        TestInst(MSUBPT(X15, X16, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, X17, X3");
        TestInst(MSUBPT(XZR, X16, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, X17, X3");
        TestInst(MSUBPT(X0, XZR, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, X17, X3");
        TestInst(MSUBPT(X15, XZR, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, X17, X3");
        TestInst(MSUBPT(XZR, XZR, X17, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, X17, X3");
        TestInst(MSUBPT(X0, X1, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, XZR, X3");
        TestInst(MSUBPT(X15, X1, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, XZR, X3");
        TestInst(MSUBPT(XZR, X1, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, XZR, X3");
        TestInst(MSUBPT(X0, X16, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, XZR, X3");
        TestInst(MSUBPT(X15, X16, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, XZR, X3");
        TestInst(MSUBPT(XZR, X16, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, XZR, X3");
        TestInst(MSUBPT(X0, XZR, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, XZR, X3");
        TestInst(MSUBPT(X15, XZR, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, XZR, X3");
        TestInst(MSUBPT(XZR, XZR, XZR, X3), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, XZR, X3");
        TestInst(MSUBPT(X0, X1, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, X2, X18");
        TestInst(MSUBPT(X15, X1, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, X2, X18");
        TestInst(MSUBPT(XZR, X1, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, X2, X18");
        TestInst(MSUBPT(X0, X16, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, X2, X18");
        TestInst(MSUBPT(X15, X16, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, X2, X18");
        TestInst(MSUBPT(XZR, X16, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, X2, X18");
        TestInst(MSUBPT(X0, XZR, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, X2, X18");
        TestInst(MSUBPT(X15, XZR, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, X2, X18");
        TestInst(MSUBPT(XZR, XZR, X2, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, X2, X18");
        TestInst(MSUBPT(X0, X1, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, X17, X18");
        TestInst(MSUBPT(X15, X1, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, X17, X18");
        TestInst(MSUBPT(XZR, X1, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, X17, X18");
        TestInst(MSUBPT(X0, X16, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, X17, X18");
        TestInst(MSUBPT(X15, X16, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, X17, X18");
        TestInst(MSUBPT(XZR, X16, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, X17, X18");
        TestInst(MSUBPT(X0, XZR, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, X17, X18");
        TestInst(MSUBPT(X15, XZR, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, X17, X18");
        TestInst(MSUBPT(XZR, XZR, X17, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, X17, X18");
        TestInst(MSUBPT(X0, X1, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, XZR, X18");
        TestInst(MSUBPT(X15, X1, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, XZR, X18");
        TestInst(MSUBPT(XZR, X1, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, XZR, X18");
        TestInst(MSUBPT(X0, X16, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, XZR, X18");
        TestInst(MSUBPT(X15, X16, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, XZR, X18");
        TestInst(MSUBPT(XZR, X16, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, XZR, X18");
        TestInst(MSUBPT(X0, XZR, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, XZR, X18");
        TestInst(MSUBPT(X15, XZR, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, XZR, X18");
        TestInst(MSUBPT(XZR, XZR, XZR, X18), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, XZR, X18");
        TestInst(MSUBPT(X0, X1, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, X2, XZR");
        TestInst(MSUBPT(X15, X1, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, X2, XZR");
        TestInst(MSUBPT(XZR, X1, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, X2, XZR");
        TestInst(MSUBPT(X0, X16, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, X2, XZR");
        TestInst(MSUBPT(X15, X16, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, X2, XZR");
        TestInst(MSUBPT(XZR, X16, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, X2, XZR");
        TestInst(MSUBPT(X0, XZR, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, X2, XZR");
        TestInst(MSUBPT(X15, XZR, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, X2, XZR");
        TestInst(MSUBPT(XZR, XZR, X2, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, X2, XZR");
        TestInst(MSUBPT(X0, X1, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, X17, XZR");
        TestInst(MSUBPT(X15, X1, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, X17, XZR");
        TestInst(MSUBPT(XZR, X1, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, X17, XZR");
        TestInst(MSUBPT(X0, X16, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, X17, XZR");
        TestInst(MSUBPT(X15, X16, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, X17, XZR");
        TestInst(MSUBPT(XZR, X16, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, X17, XZR");
        TestInst(MSUBPT(X0, XZR, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, X17, XZR");
        TestInst(MSUBPT(X15, XZR, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, X17, XZR");
        TestInst(MSUBPT(XZR, XZR, X17, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, X17, XZR");
        TestInst(MSUBPT(X0, X1, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X1, XZR, XZR");
        TestInst(MSUBPT(X15, X1, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X1, XZR, XZR");
        TestInst(MSUBPT(XZR, X1, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X1, XZR, XZR");
        TestInst(MSUBPT(X0, X16, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, X16, XZR, XZR");
        TestInst(MSUBPT(X15, X16, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, X16, XZR, XZR");
        TestInst(MSUBPT(XZR, X16, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, X16, XZR, XZR");
        TestInst(MSUBPT(X0, XZR, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X0, XZR, XZR, XZR");
        TestInst(MSUBPT(X15, XZR, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT X15, XZR, XZR, XZR");
        TestInst(MSUBPT(XZR, XZR, XZR, XZR), Arm64InstructionId.MSUBPT_64a_dp_3src, Arm64Mnemonic.MSUBPT, "MSUBPT XZR, XZR, XZR, XZR");
    }
}
