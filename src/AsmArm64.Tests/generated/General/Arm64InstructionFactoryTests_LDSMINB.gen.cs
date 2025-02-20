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
public class Arm64InstructionFactoryTests_LDSMINB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMINB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMINB_32_memop_0()
    {
        TestInst(LDSMINB(W0, W1, _[X3]), asm => asm.LDSMINB(W0, W1, _[X3]), Arm64InstructionId.LDSMINB_32_memop, Arm64Mnemonic.LDSMINB, "LDSMINB W0, W1, [X3]");
        TestInst(LDSMINB(W15, W1, _[X3]), asm => asm.LDSMINB(W15, W1, _[X3]), Arm64InstructionId.LDSMINB_32_memop, Arm64Mnemonic.LDSMINB, "LDSMINB W15, W1, [X3]");
        TestInst(LDSMINB(WZR, W1, _[X3]), asm => asm.LDSMINB(WZR, W1, _[X3]), Arm64InstructionId.LDSMINB_32_memop, Arm64Mnemonic.LDSMINB, "LDSMINB WZR, W1, [X3]");
        TestInst(LDSMINB(W0, W16, _[X3]), asm => asm.LDSMINB(W0, W16, _[X3]), Arm64InstructionId.LDSMINB_32_memop, Arm64Mnemonic.LDSMINB, "LDSMINB W0, W16, [X3]");
        TestInst(LDSMINB(W15, W16, _[X3]), asm => asm.LDSMINB(W15, W16, _[X3]), Arm64InstructionId.LDSMINB_32_memop, Arm64Mnemonic.LDSMINB, "LDSMINB W15, W16, [X3]");
        TestInst(LDSMINB(WZR, W16, _[X3]), asm => asm.LDSMINB(WZR, W16, _[X3]), Arm64InstructionId.LDSMINB_32_memop, Arm64Mnemonic.LDSMINB, "LDSMINB WZR, W16, [X3]");
        TestInst(LDSMINB(W0, WZR, _[X3]), asm => asm.LDSMINB(W0, WZR, _[X3]), Arm64InstructionId.STSMINB_ldsminb_32_memop, Arm64Mnemonic.STSMINB, "STSMINB W0, [X3]");
        TestInst(LDSMINB(W15, WZR, _[X3]), asm => asm.LDSMINB(W15, WZR, _[X3]), Arm64InstructionId.STSMINB_ldsminb_32_memop, Arm64Mnemonic.STSMINB, "STSMINB W15, [X3]");
        TestInst(LDSMINB(WZR, WZR, _[X3]), asm => asm.LDSMINB(WZR, WZR, _[X3]), Arm64InstructionId.STSMINB_ldsminb_32_memop, Arm64Mnemonic.STSMINB, "STSMINB WZR, [X3]");
    }
}
