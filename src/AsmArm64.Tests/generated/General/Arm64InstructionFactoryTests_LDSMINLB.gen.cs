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
public class Arm64InstructionFactoryTests_LDSMINLB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMINLB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMINLB_32_memop_0()
    {
        TestInst(LDSMINLB(W0, W1, _[X3]), asm => asm.LDSMINLB(W0, W1, _[X3]), Arm64InstructionId.LDSMINLB_32_memop, Arm64Mnemonic.LDSMINLB, "LDSMINLB W0, W1, [X3]");
        TestInst(LDSMINLB(W15, W1, _[X3]), asm => asm.LDSMINLB(W15, W1, _[X3]), Arm64InstructionId.LDSMINLB_32_memop, Arm64Mnemonic.LDSMINLB, "LDSMINLB W15, W1, [X3]");
        TestInst(LDSMINLB(WZR, W1, _[X3]), asm => asm.LDSMINLB(WZR, W1, _[X3]), Arm64InstructionId.LDSMINLB_32_memop, Arm64Mnemonic.LDSMINLB, "LDSMINLB WZR, W1, [X3]");
        TestInst(LDSMINLB(W0, W16, _[X3]), asm => asm.LDSMINLB(W0, W16, _[X3]), Arm64InstructionId.LDSMINLB_32_memop, Arm64Mnemonic.LDSMINLB, "LDSMINLB W0, W16, [X3]");
        TestInst(LDSMINLB(W15, W16, _[X3]), asm => asm.LDSMINLB(W15, W16, _[X3]), Arm64InstructionId.LDSMINLB_32_memop, Arm64Mnemonic.LDSMINLB, "LDSMINLB W15, W16, [X3]");
        TestInst(LDSMINLB(WZR, W16, _[X3]), asm => asm.LDSMINLB(WZR, W16, _[X3]), Arm64InstructionId.LDSMINLB_32_memop, Arm64Mnemonic.LDSMINLB, "LDSMINLB WZR, W16, [X3]");
        TestInst(LDSMINLB(W0, WZR, _[X3]), asm => asm.LDSMINLB(W0, WZR, _[X3]), Arm64InstructionId.STSMINLB_ldsminlb_32_memop, Arm64Mnemonic.STSMINLB, "STSMINLB W0, [X3]");
        TestInst(LDSMINLB(W15, WZR, _[X3]), asm => asm.LDSMINLB(W15, WZR, _[X3]), Arm64InstructionId.STSMINLB_ldsminlb_32_memop, Arm64Mnemonic.STSMINLB, "STSMINLB W15, [X3]");
        TestInst(LDSMINLB(WZR, WZR, _[X3]), asm => asm.LDSMINLB(WZR, WZR, _[X3]), Arm64InstructionId.STSMINLB_ldsminlb_32_memop, Arm64Mnemonic.STSMINLB, "STSMINLB WZR, [X3]");
    }
}
