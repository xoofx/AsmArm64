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
public class Arm64InstructionFactoryTests_LDUMINLB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMINLB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMINLB_32_memop_0()
    {
        TestInst(LDUMINLB(W0, W1, _[X3]), asm => asm.LDUMINLB(W0, W1, _[X3]), Arm64InstructionId.LDUMINLB_32_memop, Arm64Mnemonic.LDUMINLB, "LDUMINLB W0, W1, [X3]");
        TestInst(LDUMINLB(W15, W1, _[X3]), asm => asm.LDUMINLB(W15, W1, _[X3]), Arm64InstructionId.LDUMINLB_32_memop, Arm64Mnemonic.LDUMINLB, "LDUMINLB W15, W1, [X3]");
        TestInst(LDUMINLB(WZR, W1, _[X3]), asm => asm.LDUMINLB(WZR, W1, _[X3]), Arm64InstructionId.LDUMINLB_32_memop, Arm64Mnemonic.LDUMINLB, "LDUMINLB WZR, W1, [X3]");
        TestInst(LDUMINLB(W0, W16, _[X3]), asm => asm.LDUMINLB(W0, W16, _[X3]), Arm64InstructionId.LDUMINLB_32_memop, Arm64Mnemonic.LDUMINLB, "LDUMINLB W0, W16, [X3]");
        TestInst(LDUMINLB(W15, W16, _[X3]), asm => asm.LDUMINLB(W15, W16, _[X3]), Arm64InstructionId.LDUMINLB_32_memop, Arm64Mnemonic.LDUMINLB, "LDUMINLB W15, W16, [X3]");
        TestInst(LDUMINLB(WZR, W16, _[X3]), asm => asm.LDUMINLB(WZR, W16, _[X3]), Arm64InstructionId.LDUMINLB_32_memop, Arm64Mnemonic.LDUMINLB, "LDUMINLB WZR, W16, [X3]");
        TestInst(LDUMINLB(W0, WZR, _[X3]), asm => asm.LDUMINLB(W0, WZR, _[X3]), Arm64InstructionId.STUMINLB_lduminlb_32_memop, Arm64Mnemonic.STUMINLB, "STUMINLB W0, [X3]");
        TestInst(LDUMINLB(W15, WZR, _[X3]), asm => asm.LDUMINLB(W15, WZR, _[X3]), Arm64InstructionId.STUMINLB_lduminlb_32_memop, Arm64Mnemonic.STUMINLB, "STUMINLB W15, [X3]");
        TestInst(LDUMINLB(WZR, WZR, _[X3]), asm => asm.LDUMINLB(WZR, WZR, _[X3]), Arm64InstructionId.STUMINLB_lduminlb_32_memop, Arm64Mnemonic.STUMINLB, "STUMINLB WZR, [X3]");
    }
}
