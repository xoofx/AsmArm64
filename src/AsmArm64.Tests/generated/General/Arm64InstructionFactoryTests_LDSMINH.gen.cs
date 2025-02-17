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
public class Arm64InstructionFactoryTests_LDSMINH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMINH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMINH_32_memop_0()
    {
        TestInst(LDSMINH(W0, W1, _[X3]), asm => asm.LDSMINH(W0, W1, _[X3]), Arm64InstructionId.LDSMINH_32_memop, Arm64Mnemonic.LDSMINH, "LDSMINH W0, W1, [X3]");
        TestInst(LDSMINH(W15, W1, _[X3]), asm => asm.LDSMINH(W15, W1, _[X3]), Arm64InstructionId.LDSMINH_32_memop, Arm64Mnemonic.LDSMINH, "LDSMINH W15, W1, [X3]");
        TestInst(LDSMINH(WZR, W1, _[X3]), asm => asm.LDSMINH(WZR, W1, _[X3]), Arm64InstructionId.LDSMINH_32_memop, Arm64Mnemonic.LDSMINH, "LDSMINH WZR, W1, [X3]");
        TestInst(LDSMINH(W0, W16, _[X3]), asm => asm.LDSMINH(W0, W16, _[X3]), Arm64InstructionId.LDSMINH_32_memop, Arm64Mnemonic.LDSMINH, "LDSMINH W0, W16, [X3]");
        TestInst(LDSMINH(W15, W16, _[X3]), asm => asm.LDSMINH(W15, W16, _[X3]), Arm64InstructionId.LDSMINH_32_memop, Arm64Mnemonic.LDSMINH, "LDSMINH W15, W16, [X3]");
        TestInst(LDSMINH(WZR, W16, _[X3]), asm => asm.LDSMINH(WZR, W16, _[X3]), Arm64InstructionId.LDSMINH_32_memop, Arm64Mnemonic.LDSMINH, "LDSMINH WZR, W16, [X3]");
        TestInst(LDSMINH(W0, WZR, _[X3]), asm => asm.LDSMINH(W0, WZR, _[X3]), Arm64InstructionId.STSMINH_ldsminh_32_memop, Arm64Mnemonic.STSMINH, "STSMINH W0, [X3]");
        TestInst(LDSMINH(W15, WZR, _[X3]), asm => asm.LDSMINH(W15, WZR, _[X3]), Arm64InstructionId.STSMINH_ldsminh_32_memop, Arm64Mnemonic.STSMINH, "STSMINH W15, [X3]");
        TestInst(LDSMINH(WZR, WZR, _[X3]), asm => asm.LDSMINH(WZR, WZR, _[X3]), Arm64InstructionId.STSMINH_ldsminh_32_memop, Arm64Mnemonic.STSMINH, "STSMINH WZR, [X3]");
    }
}
