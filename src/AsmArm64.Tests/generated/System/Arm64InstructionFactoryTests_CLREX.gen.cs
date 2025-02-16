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
public class Arm64InstructionFactoryTests_CLREX_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CLREX"/>.
    /// </summary>
    [TestMethod]
    public void Test_CLREX_bn_barriers_0()
    {
        TestInst(CLREX(5), asm => asm.CLREX(5), Arm64InstructionId.CLREX_bn_barriers, Arm64Mnemonic.CLREX, "CLREX #5");
    }
}
