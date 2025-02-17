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
namespace AsmArm64.Tests.System;

[TestClass]
public class Arm64InstructionFactoryTests_WFIT_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.WFIT"/>.
    /// </summary>
    [TestMethod]
    public void Test_WFIT_only_systeminstrswithreg_0()
    {
        TestInst(WFIT(X0), asm => asm.WFIT(X0), Arm64InstructionId.WFIT_only_systeminstrswithreg, Arm64Mnemonic.WFIT, "WFIT X0");
        TestInst(WFIT(X15), asm => asm.WFIT(X15), Arm64InstructionId.WFIT_only_systeminstrswithreg, Arm64Mnemonic.WFIT, "WFIT X15");
        TestInst(WFIT(XZR), asm => asm.WFIT(XZR), Arm64InstructionId.WFIT_only_systeminstrswithreg, Arm64Mnemonic.WFIT, "WFIT XZR");
    }
}
