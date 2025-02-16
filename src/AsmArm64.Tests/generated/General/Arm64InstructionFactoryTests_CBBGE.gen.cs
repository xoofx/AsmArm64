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
public class Arm64InstructionFactoryTests_CBBGE_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBBGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBBGE_8_regs_0()
    {
        TestInst(CBBGE(W0, W1, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE W0, W1, #32");
        TestInst(CBBGE(W15, W1, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE W15, W1, #32");
        TestInst(CBBGE(WZR, W1, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE WZR, W1, #32");
        TestInst(CBBGE(W0, W16, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE W0, W16, #32");
        TestInst(CBBGE(W15, W16, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE W15, W16, #32");
        TestInst(CBBGE(WZR, W16, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE WZR, W16, #32");
        TestInst(CBBGE(W0, WZR, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE W0, WZR, #32");
        TestInst(CBBGE(W15, WZR, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE W15, WZR, #32");
        TestInst(CBBGE(WZR, WZR, 32), null, Arm64InstructionId.CBBGE_8_regs, Arm64Mnemonic.CBBGE, "CBBGE WZR, WZR, #32");
    }
}
