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
public class Arm64InstructionFactoryTests_SWPAH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPAH"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPAH_32_memop_0()
    {
        TestInst(SWPAH(W0, W1, _[X3]), asm => asm.SWPAH(W0, W1, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH W0, W1, [X3]");
        TestInst(SWPAH(W15, W1, _[X3]), asm => asm.SWPAH(W15, W1, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH W15, W1, [X3]");
        TestInst(SWPAH(WZR, W1, _[X3]), asm => asm.SWPAH(WZR, W1, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH WZR, W1, [X3]");
        TestInst(SWPAH(W0, W16, _[X3]), asm => asm.SWPAH(W0, W16, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH W0, W16, [X3]");
        TestInst(SWPAH(W15, W16, _[X3]), asm => asm.SWPAH(W15, W16, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH W15, W16, [X3]");
        TestInst(SWPAH(WZR, W16, _[X3]), asm => asm.SWPAH(WZR, W16, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH WZR, W16, [X3]");
        TestInst(SWPAH(W0, WZR, _[X3]), asm => asm.SWPAH(W0, WZR, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH W0, WZR, [X3]");
        TestInst(SWPAH(W15, WZR, _[X3]), asm => asm.SWPAH(W15, WZR, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH W15, WZR, [X3]");
        TestInst(SWPAH(WZR, WZR, _[X3]), asm => asm.SWPAH(WZR, WZR, _[X3]), Arm64InstructionId.SWPAH_32_memop, Arm64Mnemonic.SWPAH, "SWPAH WZR, WZR, [X3]");
    }
}
