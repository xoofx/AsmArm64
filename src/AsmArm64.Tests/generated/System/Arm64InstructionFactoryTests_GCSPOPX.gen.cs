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
public class Arm64InstructionFactoryTests_GCSPOPX_System
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.GCSPOPX"/>.
    /// </summary>
    [TestMethod]
    public void Test_GCSPOPX_sys_cr_systeminstrs_0()
    {
        
        {
            var raw = GCSPOPX();
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.GCSPOPX_sys_cr_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.GCSPOPX, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("GCSPOPX", asm);
        }
    }
}
