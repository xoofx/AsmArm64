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
namespace AsmArm64.Tests.System;

[TestClass]
public class Arm64InstructionFactoryTests_TRCIT_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TRCIT"/>.
    /// </summary>
    [TestMethod]
    public void Test_TRCIT_sys_cr_systeminstrs_0()
    {
        TestInst(TRCIT(X0), Arm64InstructionId.TRCIT_sys_cr_systeminstrs, Arm64Mnemonic.TRCIT, "TRCIT X0");
        TestInst(TRCIT(X15), Arm64InstructionId.TRCIT_sys_cr_systeminstrs, Arm64Mnemonic.TRCIT, "TRCIT X15");
        TestInst(TRCIT(XZR), Arm64InstructionId.TRCIT_sys_cr_systeminstrs, Arm64Mnemonic.TRCIT, "TRCIT XZR");
    }
}
