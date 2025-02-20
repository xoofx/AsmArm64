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
public class Arm64InstructionFactoryTests_CBHGE_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHGE"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHGE_16_regs_0()
    {
        TestInst(CBHGE(W0, W1, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE W0, W1, #32");
        TestInst(CBHGE(W15, W1, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE W15, W1, #32");
        TestInst(CBHGE(WZR, W1, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE WZR, W1, #32");
        TestInst(CBHGE(W0, W16, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE W0, W16, #32");
        TestInst(CBHGE(W15, W16, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE W15, W16, #32");
        TestInst(CBHGE(WZR, W16, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE WZR, W16, #32");
        TestInst(CBHGE(W0, WZR, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE W0, WZR, #32");
        TestInst(CBHGE(W15, WZR, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE W15, WZR, #32");
        TestInst(CBHGE(WZR, WZR, 32), null, Arm64InstructionId.CBHGE_16_regs, Arm64Mnemonic.CBHGE, "CBHGE WZR, WZR, #32");
    }
}
