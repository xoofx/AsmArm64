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
public class Arm64InstructionFactoryTests_IC_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.IC"/>.
    /// </summary>
    [TestMethod]
    public void Test_IC_sys_cr_systeminstrs_0()
    {
        TestInst(IC(IALLU, X1), asm => asm.IC(IALLU, X1), Arm64InstructionId.IC_sys_cr_systeminstrs, Arm64Mnemonic.IC, "IC iallu, X1");
        TestInst(IC(IALLU, X16), asm => asm.IC(IALLU, X16), Arm64InstructionId.IC_sys_cr_systeminstrs, Arm64Mnemonic.IC, "IC iallu, X16");
    }
}
