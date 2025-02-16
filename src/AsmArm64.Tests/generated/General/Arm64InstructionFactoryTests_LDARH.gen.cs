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
public class Arm64InstructionFactoryTests_LDARH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDARH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDARH_lr32_ldstord_0()
    {
        TestInst(LDARH(W0, _[X2]), Arm64InstructionId.LDARH_lr32_ldstord, Arm64Mnemonic.LDARH, "LDARH W0, [X2]");
        TestInst(LDARH(W15, _[X2]), Arm64InstructionId.LDARH_lr32_ldstord, Arm64Mnemonic.LDARH, "LDARH W15, [X2]");
        TestInst(LDARH(WZR, _[X2]), Arm64InstructionId.LDARH_lr32_ldstord, Arm64Mnemonic.LDARH, "LDARH WZR, [X2]");
    }
}
