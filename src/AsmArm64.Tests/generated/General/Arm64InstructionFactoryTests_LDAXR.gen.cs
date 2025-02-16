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
public class Arm64InstructionFactoryTests_LDAXR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAXR_lr32_ldstexclr_0()
    {
        TestInst(LDAXR(W0, _[X2]), Arm64InstructionId.LDAXR_lr32_ldstexclr, Arm64Mnemonic.LDAXR, "LDAXR W0, [X2]");
        TestInst(LDAXR(W15, _[X2]), Arm64InstructionId.LDAXR_lr32_ldstexclr, Arm64Mnemonic.LDAXR, "LDAXR W15, [X2]");
        TestInst(LDAXR(WZR, _[X2]), Arm64InstructionId.LDAXR_lr32_ldstexclr, Arm64Mnemonic.LDAXR, "LDAXR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAXR_lr64_ldstexclr_1()
    {
        TestInst(LDAXR(X0, _[X2]), Arm64InstructionId.LDAXR_lr64_ldstexclr, Arm64Mnemonic.LDAXR, "LDAXR X0, [X2]");
        TestInst(LDAXR(X15, _[X2]), Arm64InstructionId.LDAXR_lr64_ldstexclr, Arm64Mnemonic.LDAXR, "LDAXR X15, [X2]");
        TestInst(LDAXR(XZR, _[X2]), Arm64InstructionId.LDAXR_lr64_ldstexclr, Arm64Mnemonic.LDAXR, "LDAXR XZR, [X2]");
    }
}
