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
public class Arm64InstructionFactoryTests_AT_System
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AT"/>.
    /// </summary>
    [TestMethod]
    public void Test_AT_sys_cr_systeminstrs_0()
    {
        
        {
            var raw = AT(S12E0R, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AT_sys_cr_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AT s12e0r, X1", asm);
        }
        
        {
            var raw = AT(S12E0R, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AT_sys_cr_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AT s12e0r, X16", asm);
        }
        
        {
            var raw = AT(S12E0R, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AT_sys_cr_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AT s12e0r, XZR", asm);
        }
    }
}
