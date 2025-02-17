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
public class Arm64InstructionFactoryTests_LDUMAXAH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMAXAH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMAXAH_32_memop_0()
    {
        TestInst(LDUMAXAH(W0, W1, _[X3]), asm => asm.LDUMAXAH(W0, W1, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH W0, W1, [X3]");
        TestInst(LDUMAXAH(W15, W1, _[X3]), asm => asm.LDUMAXAH(W15, W1, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH W15, W1, [X3]");
        TestInst(LDUMAXAH(WZR, W1, _[X3]), asm => asm.LDUMAXAH(WZR, W1, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH WZR, W1, [X3]");
        TestInst(LDUMAXAH(W0, W16, _[X3]), asm => asm.LDUMAXAH(W0, W16, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH W0, W16, [X3]");
        TestInst(LDUMAXAH(W15, W16, _[X3]), asm => asm.LDUMAXAH(W15, W16, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH W15, W16, [X3]");
        TestInst(LDUMAXAH(WZR, W16, _[X3]), asm => asm.LDUMAXAH(WZR, W16, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH WZR, W16, [X3]");
        TestInst(LDUMAXAH(W0, WZR, _[X3]), asm => asm.LDUMAXAH(W0, WZR, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH W0, WZR, [X3]");
        TestInst(LDUMAXAH(W15, WZR, _[X3]), asm => asm.LDUMAXAH(W15, WZR, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH W15, WZR, [X3]");
        TestInst(LDUMAXAH(WZR, WZR, _[X3]), asm => asm.LDUMAXAH(WZR, WZR, _[X3]), Arm64InstructionId.LDUMAXAH_32_memop, Arm64Mnemonic.LDUMAXAH, "LDUMAXAH WZR, WZR, [X3]");
    }
}
