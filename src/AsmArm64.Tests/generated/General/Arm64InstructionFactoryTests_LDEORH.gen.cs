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
public class Arm64InstructionFactoryTests_LDEORH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDEORH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDEORH_32_memop_0()
    {
        TestInst(LDEORH(W0, W1, _[X3]), asm => asm.LDEORH(W0, W1, _[X3]), Arm64InstructionId.LDEORH_32_memop, Arm64Mnemonic.LDEORH, "LDEORH W0, W1, [X3]");
        TestInst(LDEORH(W15, W1, _[X3]), asm => asm.LDEORH(W15, W1, _[X3]), Arm64InstructionId.LDEORH_32_memop, Arm64Mnemonic.LDEORH, "LDEORH W15, W1, [X3]");
        TestInst(LDEORH(WZR, W1, _[X3]), asm => asm.LDEORH(WZR, W1, _[X3]), Arm64InstructionId.LDEORH_32_memop, Arm64Mnemonic.LDEORH, "LDEORH WZR, W1, [X3]");
        TestInst(LDEORH(W0, W16, _[X3]), asm => asm.LDEORH(W0, W16, _[X3]), Arm64InstructionId.LDEORH_32_memop, Arm64Mnemonic.LDEORH, "LDEORH W0, W16, [X3]");
        TestInst(LDEORH(W15, W16, _[X3]), asm => asm.LDEORH(W15, W16, _[X3]), Arm64InstructionId.LDEORH_32_memop, Arm64Mnemonic.LDEORH, "LDEORH W15, W16, [X3]");
        TestInst(LDEORH(WZR, W16, _[X3]), asm => asm.LDEORH(WZR, W16, _[X3]), Arm64InstructionId.LDEORH_32_memop, Arm64Mnemonic.LDEORH, "LDEORH WZR, W16, [X3]");
        TestInst(LDEORH(W0, WZR, _[X3]), asm => asm.LDEORH(W0, WZR, _[X3]), Arm64InstructionId.STEORH_ldeorh_32_memop, Arm64Mnemonic.STEORH, "STEORH W0, [X3]");
        TestInst(LDEORH(W15, WZR, _[X3]), asm => asm.LDEORH(W15, WZR, _[X3]), Arm64InstructionId.STEORH_ldeorh_32_memop, Arm64Mnemonic.STEORH, "STEORH W15, [X3]");
        TestInst(LDEORH(WZR, WZR, _[X3]), asm => asm.LDEORH(WZR, WZR, _[X3]), Arm64InstructionId.STEORH_ldeorh_32_memop, Arm64Mnemonic.STEORH, "STEORH WZR, [X3]");
    }
}
