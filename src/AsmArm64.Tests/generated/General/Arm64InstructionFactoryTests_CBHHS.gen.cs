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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_CBHHS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CBHHS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CBHHS_16_regs_0()
    {
        TestInst(CBHHS(W0, W1, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS W0, W1, #32");
        TestInst(CBHHS(W15, W1, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS W15, W1, #32");
        TestInst(CBHHS(WZR, W1, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS WZR, W1, #32");
        TestInst(CBHHS(W0, W16, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS W0, W16, #32");
        TestInst(CBHHS(W15, W16, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS W15, W16, #32");
        TestInst(CBHHS(WZR, W16, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS WZR, W16, #32");
        TestInst(CBHHS(W0, WZR, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS W0, WZR, #32");
        TestInst(CBHHS(W15, WZR, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS W15, WZR, #32");
        TestInst(CBHHS(WZR, WZR, 32), Arm64InstructionId.CBHHS_16_regs, Arm64Mnemonic.CBHHS, "CBHHS WZR, WZR, #32");
    }
}
