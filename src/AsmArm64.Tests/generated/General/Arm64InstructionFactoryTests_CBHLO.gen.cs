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
public class Arm64InstructionFactoryTests_CBHLO_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHLO"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHLO_cbhhi_16_regs_0()
    {
        TestInst(CBHLO(W0, W1, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI W1, W0, #32");
        TestInst(CBHLO(W15, W1, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI W1, W15, #32");
        TestInst(CBHLO(WZR, W1, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI W1, WZR, #32");
        TestInst(CBHLO(W0, W16, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI W16, W0, #32");
        TestInst(CBHLO(W15, W16, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI W16, W15, #32");
        TestInst(CBHLO(WZR, W16, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI W16, WZR, #32");
        TestInst(CBHLO(W0, WZR, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI WZR, W0, #32");
        TestInst(CBHLO(W15, WZR, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI WZR, W15, #32");
        TestInst(CBHLO(WZR, WZR, 32), null, Arm64InstructionId.CBHHI_16_regs, Arm64Mnemonic.CBHHI, "CBHHI WZR, WZR, #32");
    }
}
