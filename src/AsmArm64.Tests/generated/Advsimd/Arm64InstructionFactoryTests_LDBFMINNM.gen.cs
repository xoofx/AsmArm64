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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_LDBFMINNM_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDBFMINNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDBFMINNM_16_0()
    {
        
        {
            var raw = LDBFMINNM(H0, H1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDBFMINNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDBFMINNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDBFMINNM H0, H1, [X3]", asm);
        }
        
        {
            var raw = LDBFMINNM(H31, H1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDBFMINNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDBFMINNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDBFMINNM H31, H1, [X3]", asm);
        }
        
        {
            var raw = LDBFMINNM(H0, H31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDBFMINNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDBFMINNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDBFMINNM H0, H31, [X3]", asm);
        }
        
        {
            var raw = LDBFMINNM(H31, H31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDBFMINNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDBFMINNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDBFMINNM H31, H31, [X3]", asm);
        }
    }
}
