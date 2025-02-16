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
public class Arm64InstructionFactoryTests_CBHGT_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHGT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHGT_16_regs_0()
    {
        TestInst(CBHGT(W0, W1, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT W0, W1, #32");
        TestInst(CBHGT(W15, W1, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT W15, W1, #32");
        TestInst(CBHGT(WZR, W1, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT WZR, W1, #32");
        TestInst(CBHGT(W0, W16, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT W0, W16, #32");
        TestInst(CBHGT(W15, W16, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT W15, W16, #32");
        TestInst(CBHGT(WZR, W16, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT WZR, W16, #32");
        TestInst(CBHGT(W0, WZR, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT W0, WZR, #32");
        TestInst(CBHGT(W15, WZR, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT W15, WZR, #32");
        TestInst(CBHGT(WZR, WZR, 32), null, Arm64InstructionId.CBHGT_16_regs, Arm64Mnemonic.CBHGT, "CBHGT WZR, WZR, #32");
    }
}
