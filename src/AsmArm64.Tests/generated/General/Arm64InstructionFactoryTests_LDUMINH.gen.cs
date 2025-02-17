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
public class Arm64InstructionFactoryTests_LDUMINH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMINH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMINH_32_memop_0()
    {
        TestInst(LDUMINH(W0, W1, _[X3]), asm => asm.LDUMINH(W0, W1, _[X3]), Arm64InstructionId.LDUMINH_32_memop, Arm64Mnemonic.LDUMINH, "LDUMINH W0, W1, [X3]");
        TestInst(LDUMINH(W15, W1, _[X3]), asm => asm.LDUMINH(W15, W1, _[X3]), Arm64InstructionId.LDUMINH_32_memop, Arm64Mnemonic.LDUMINH, "LDUMINH W15, W1, [X3]");
        TestInst(LDUMINH(WZR, W1, _[X3]), asm => asm.LDUMINH(WZR, W1, _[X3]), Arm64InstructionId.LDUMINH_32_memop, Arm64Mnemonic.LDUMINH, "LDUMINH WZR, W1, [X3]");
        TestInst(LDUMINH(W0, W16, _[X3]), asm => asm.LDUMINH(W0, W16, _[X3]), Arm64InstructionId.LDUMINH_32_memop, Arm64Mnemonic.LDUMINH, "LDUMINH W0, W16, [X3]");
        TestInst(LDUMINH(W15, W16, _[X3]), asm => asm.LDUMINH(W15, W16, _[X3]), Arm64InstructionId.LDUMINH_32_memop, Arm64Mnemonic.LDUMINH, "LDUMINH W15, W16, [X3]");
        TestInst(LDUMINH(WZR, W16, _[X3]), asm => asm.LDUMINH(WZR, W16, _[X3]), Arm64InstructionId.LDUMINH_32_memop, Arm64Mnemonic.LDUMINH, "LDUMINH WZR, W16, [X3]");
        TestInst(LDUMINH(W0, WZR, _[X3]), asm => asm.LDUMINH(W0, WZR, _[X3]), Arm64InstructionId.STUMINH_lduminh_32_memop, Arm64Mnemonic.STUMINH, "STUMINH W0, [X3]");
        TestInst(LDUMINH(W15, WZR, _[X3]), asm => asm.LDUMINH(W15, WZR, _[X3]), Arm64InstructionId.STUMINH_lduminh_32_memop, Arm64Mnemonic.STUMINH, "STUMINH W15, [X3]");
        TestInst(LDUMINH(WZR, WZR, _[X3]), asm => asm.LDUMINH(WZR, WZR, _[X3]), Arm64InstructionId.STUMINH_lduminh_32_memop, Arm64Mnemonic.STUMINH, "STUMINH WZR, [X3]");
    }
}
