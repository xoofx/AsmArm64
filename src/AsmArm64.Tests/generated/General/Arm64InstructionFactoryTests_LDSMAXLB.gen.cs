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
public class Arm64InstructionFactoryTests_LDSMAXLB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDSMAXLB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDSMAXLB_32_memop_0()
    {
        TestInst(LDSMAXLB(W0, W1, _[X3]), asm => asm.LDSMAXLB(W0, W1, _[X3]), Arm64InstructionId.LDSMAXLB_32_memop, Arm64Mnemonic.LDSMAXLB, "LDSMAXLB W0, W1, [X3]");
        TestInst(LDSMAXLB(W15, W1, _[X3]), asm => asm.LDSMAXLB(W15, W1, _[X3]), Arm64InstructionId.LDSMAXLB_32_memop, Arm64Mnemonic.LDSMAXLB, "LDSMAXLB W15, W1, [X3]");
        TestInst(LDSMAXLB(WZR, W1, _[X3]), asm => asm.LDSMAXLB(WZR, W1, _[X3]), Arm64InstructionId.LDSMAXLB_32_memop, Arm64Mnemonic.LDSMAXLB, "LDSMAXLB WZR, W1, [X3]");
        TestInst(LDSMAXLB(W0, W16, _[X3]), asm => asm.LDSMAXLB(W0, W16, _[X3]), Arm64InstructionId.LDSMAXLB_32_memop, Arm64Mnemonic.LDSMAXLB, "LDSMAXLB W0, W16, [X3]");
        TestInst(LDSMAXLB(W15, W16, _[X3]), asm => asm.LDSMAXLB(W15, W16, _[X3]), Arm64InstructionId.LDSMAXLB_32_memop, Arm64Mnemonic.LDSMAXLB, "LDSMAXLB W15, W16, [X3]");
        TestInst(LDSMAXLB(WZR, W16, _[X3]), asm => asm.LDSMAXLB(WZR, W16, _[X3]), Arm64InstructionId.LDSMAXLB_32_memop, Arm64Mnemonic.LDSMAXLB, "LDSMAXLB WZR, W16, [X3]");
        TestInst(LDSMAXLB(W0, WZR, _[X3]), asm => asm.LDSMAXLB(W0, WZR, _[X3]), Arm64InstructionId.STSMAXLB_ldsmaxlb_32_memop, Arm64Mnemonic.STSMAXLB, "STSMAXLB W0, [X3]");
        TestInst(LDSMAXLB(W15, WZR, _[X3]), asm => asm.LDSMAXLB(W15, WZR, _[X3]), Arm64InstructionId.STSMAXLB_ldsmaxlb_32_memop, Arm64Mnemonic.STSMAXLB, "STSMAXLB W15, [X3]");
        TestInst(LDSMAXLB(WZR, WZR, _[X3]), asm => asm.LDSMAXLB(WZR, WZR, _[X3]), Arm64InstructionId.STSMAXLB_ldsmaxlb_32_memop, Arm64Mnemonic.STSMAXLB, "STSMAXLB WZR, [X3]");
    }
}
