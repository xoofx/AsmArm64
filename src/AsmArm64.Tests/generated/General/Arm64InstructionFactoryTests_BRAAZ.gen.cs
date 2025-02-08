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
public class Arm64InstructionFactoryTests_BRAAZ_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BRAAZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_BRAAZ_64_branch_reg_0()
    {
        
        {
            var raw = BRAAZ(X0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BRAAZ_64_branch_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BRAAZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BRAAZ X0", asm);
        }
        
        {
            var raw = BRAAZ(X15);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BRAAZ_64_branch_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BRAAZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BRAAZ X15", asm);
        }
        
        {
            var raw = BRAAZ(XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.BRAAZ_64_branch_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.BRAAZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("BRAAZ XZR", asm);
        }
    }
}
