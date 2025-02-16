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
public class Arm64InstructionFactoryTests_DSB_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.DSB"/>.
    /// </summary>
    [TestMethod]
    public void Test_DSB_bo_barriers_0()
    {
        TestInst(DSB(OSHLD), asm => asm.DSB(OSHLD), Arm64InstructionId.DSB_bo_barriers, Arm64Mnemonic.DSB, "DSB OSHLD");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.DSB"/>.
    /// </summary>
    [TestMethod]
    public void Test_DSB_bon_barriers_1()
    {
        TestInst(DSB(OSH), asm => asm.DSB(OSH), Arm64InstructionId.DSB_bon_barriers, Arm64Mnemonic.DSB, "DSB OSH");
    }
}
