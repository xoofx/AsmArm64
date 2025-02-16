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
namespace AsmArm64.Tests.System;

[TestClass]
public class Arm64InstructionFactoryTests_WFET_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.WFET"/>.
    /// </summary>
    [TestMethod]
    public void Test_WFET_only_systeminstrswithreg_0()
    {
        TestInst(WFET(X0), asm => asm.WFET(X0), Arm64InstructionId.WFET_only_systeminstrswithreg, Arm64Mnemonic.WFET, "WFET X0");
        TestInst(WFET(X15), asm => asm.WFET(X15), Arm64InstructionId.WFET_only_systeminstrswithreg, Arm64Mnemonic.WFET, "WFET X15");
        TestInst(WFET(XZR), asm => asm.WFET(XZR), Arm64InstructionId.WFET_only_systeminstrswithreg, Arm64Mnemonic.WFET, "WFET XZR");
    }
}
