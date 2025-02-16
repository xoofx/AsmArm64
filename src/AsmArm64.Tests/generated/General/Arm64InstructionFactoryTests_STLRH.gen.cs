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
public class Arm64InstructionFactoryTests_STLRH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLRH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLRH_sl32_ldstord_0()
    {
        TestInst(STLRH(W0, _[X2]), Arm64InstructionId.STLRH_sl32_ldstord, Arm64Mnemonic.STLRH, "STLRH W0, [X2]");
        TestInst(STLRH(W15, _[X2]), Arm64InstructionId.STLRH_sl32_ldstord, Arm64Mnemonic.STLRH, "STLRH W15, [X2]");
        TestInst(STLRH(WZR, _[X2]), Arm64InstructionId.STLRH_sl32_ldstord, Arm64Mnemonic.STLRH, "STLRH WZR, [X2]");
    }
}
