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
public class Arm64InstructionFactoryTests_LDATXR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDATXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDATXR_lr32_ldstexclr_unpriv_0()
    {
        TestInst(LDATXR(W0, _[X2]), Arm64InstructionId.LDATXR_lr32_ldstexclr_unpriv, Arm64Mnemonic.LDATXR, "LDATXR W0, [X2]");
        TestInst(LDATXR(W15, _[X2]), Arm64InstructionId.LDATXR_lr32_ldstexclr_unpriv, Arm64Mnemonic.LDATXR, "LDATXR W15, [X2]");
        TestInst(LDATXR(WZR, _[X2]), Arm64InstructionId.LDATXR_lr32_ldstexclr_unpriv, Arm64Mnemonic.LDATXR, "LDATXR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDATXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDATXR_lr64_ldstexclr_unpriv_1()
    {
        TestInst(LDATXR(X0, _[X2]), Arm64InstructionId.LDATXR_lr64_ldstexclr_unpriv, Arm64Mnemonic.LDATXR, "LDATXR X0, [X2]");
        TestInst(LDATXR(X15, _[X2]), Arm64InstructionId.LDATXR_lr64_ldstexclr_unpriv, Arm64Mnemonic.LDATXR, "LDATXR X15, [X2]");
        TestInst(LDATXR(XZR, _[X2]), Arm64InstructionId.LDATXR_lr64_ldstexclr_unpriv, Arm64Mnemonic.LDATXR, "LDATXR XZR, [X2]");
    }
}
