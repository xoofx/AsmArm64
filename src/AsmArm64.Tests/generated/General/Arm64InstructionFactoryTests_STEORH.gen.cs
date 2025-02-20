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
public class Arm64InstructionFactoryTests_STEORH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STEORH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STEORH_ldeorh_32_memop_0()
    {
        TestInst(STEORH(W0, _[X2]), asm => asm.STEORH(W0, _[X2]), Arm64InstructionId.STEORH_ldeorh_32_memop, Arm64Mnemonic.STEORH, "STEORH W0, [X2]");
        TestInst(STEORH(W15, _[X2]), asm => asm.STEORH(W15, _[X2]), Arm64InstructionId.STEORH_ldeorh_32_memop, Arm64Mnemonic.STEORH, "STEORH W15, [X2]");
        TestInst(STEORH(WZR, _[X2]), asm => asm.STEORH(WZR, _[X2]), Arm64InstructionId.STEORH_ldeorh_32_memop, Arm64Mnemonic.STEORH, "STEORH WZR, [X2]");
    }
}
