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
public class Arm64InstructionFactoryTests_LDADDALH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDALH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDALH_32_memop_0()
    {
        TestInst(LDADDALH(W0, W1, _[X3]), asm => asm.LDADDALH(W0, W1, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH W0, W1, [X3]");
        TestInst(LDADDALH(W15, W1, _[X3]), asm => asm.LDADDALH(W15, W1, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH W15, W1, [X3]");
        TestInst(LDADDALH(WZR, W1, _[X3]), asm => asm.LDADDALH(WZR, W1, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH WZR, W1, [X3]");
        TestInst(LDADDALH(W0, W16, _[X3]), asm => asm.LDADDALH(W0, W16, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH W0, W16, [X3]");
        TestInst(LDADDALH(W15, W16, _[X3]), asm => asm.LDADDALH(W15, W16, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH W15, W16, [X3]");
        TestInst(LDADDALH(WZR, W16, _[X3]), asm => asm.LDADDALH(WZR, W16, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH WZR, W16, [X3]");
        TestInst(LDADDALH(W0, WZR, _[X3]), asm => asm.LDADDALH(W0, WZR, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH W0, WZR, [X3]");
        TestInst(LDADDALH(W15, WZR, _[X3]), asm => asm.LDADDALH(W15, WZR, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH W15, WZR, [X3]");
        TestInst(LDADDALH(WZR, WZR, _[X3]), asm => asm.LDADDALH(WZR, WZR, _[X3]), Arm64InstructionId.LDADDALH_32_memop, Arm64Mnemonic.LDADDALH, "LDADDALH WZR, WZR, [X3]");
    }
}
