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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STLLRH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLLRH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLLRH_sl32_ldstord_0()
    {
        TestInst(STLLRH(W0, _[X2]), asm => asm.STLLRH(W0, _[X2]), Arm64InstructionId.STLLRH_sl32_ldstord, Arm64Mnemonic.STLLRH, "STLLRH W0, [X2]");
        TestInst(STLLRH(W15, _[X2]), asm => asm.STLLRH(W15, _[X2]), Arm64InstructionId.STLLRH_sl32_ldstord, Arm64Mnemonic.STLLRH, "STLLRH W15, [X2]");
        TestInst(STLLRH(WZR, _[X2]), asm => asm.STLLRH(WZR, _[X2]), Arm64InstructionId.STLLRH_sl32_ldstord, Arm64Mnemonic.STLLRH, "STLLRH WZR, [X2]");
    }
}
