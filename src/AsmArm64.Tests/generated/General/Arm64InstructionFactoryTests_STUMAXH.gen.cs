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
public class Arm64InstructionFactoryTests_STUMAXH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STUMAXH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STUMAXH_ldumaxh_32_memop_0()
    {
        TestInst(STUMAXH(W0, _[X2]), asm => asm.STUMAXH(W0, _[X2]), Arm64InstructionId.STUMAXH_ldumaxh_32_memop, Arm64Mnemonic.STUMAXH, "STUMAXH W0, [X2]");
        TestInst(STUMAXH(W15, _[X2]), asm => asm.STUMAXH(W15, _[X2]), Arm64InstructionId.STUMAXH_ldumaxh_32_memop, Arm64Mnemonic.STUMAXH, "STUMAXH W15, [X2]");
        TestInst(STUMAXH(WZR, _[X2]), asm => asm.STUMAXH(WZR, _[X2]), Arm64InstructionId.STUMAXH_ldumaxh_32_memop, Arm64Mnemonic.STUMAXH, "STUMAXH WZR, [X2]");
    }
}
