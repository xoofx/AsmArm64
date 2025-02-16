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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_LDLARH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDLARH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDLARH_lr32_ldstord_0()
    {
        TestInst(LDLARH(W0, _[X2]), asm => asm.LDLARH(W0, _[X2]), Arm64InstructionId.LDLARH_lr32_ldstord, Arm64Mnemonic.LDLARH, "LDLARH W0, [X2]");
        TestInst(LDLARH(W15, _[X2]), asm => asm.LDLARH(W15, _[X2]), Arm64InstructionId.LDLARH_lr32_ldstord, Arm64Mnemonic.LDLARH, "LDLARH W15, [X2]");
        TestInst(LDLARH(WZR, _[X2]), asm => asm.LDLARH(WZR, _[X2]), Arm64InstructionId.LDLARH_lr32_ldstord, Arm64Mnemonic.LDLARH, "LDLARH WZR, [X2]");
    }
}
