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
public class Arm64InstructionFactoryTests_PACIBZ_System
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACIBZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACIBZ_hi_hints_0()
    {
        
        {
            var raw = PACIBZ();
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACIBZ_hi_hints, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACIBZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACIBZ", asm);
        }
    }
}
