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
public class Arm64InstructionFactoryTests_STG_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STG"/>.
    /// </summary>
    [TestMethod]
    public void Test_STG_64spost_ldsttags_0()
    {
        
        {
            var raw = STG(X1, _[X2], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64spost_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG X1, [X2], #80", asm);
        }
        
        {
            var raw = STG(X17, _[X2], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64spost_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG X17, [X2], #80", asm);
        }
        
        {
            var raw = STG(SP, _[X2], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64spost_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG SP, [X2], #80", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STG"/>.
    /// </summary>
    [TestMethod]
    public void Test_STG_64spre_ldsttags_1()
    {
        
        {
            var raw = STG(X1, _[X2, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64spre_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG X1, [X2, #80]!", asm);
        }
        
        {
            var raw = STG(X17, _[X2, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64spre_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG X17, [X2, #80]!", asm);
        }
        
        {
            var raw = STG(SP, _[X2, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64spre_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG SP, [X2, #80]!", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STG"/>.
    /// </summary>
    [TestMethod]
    public void Test_STG_64soffset_ldsttags_2()
    {
        
        {
            var raw = STG(X1, _[X2, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64soffset_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG X1, [X2, #80]", asm);
        }
        
        {
            var raw = STG(X17, _[X2, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64soffset_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG X17, [X2, #80]", asm);
        }
        
        {
            var raw = STG(SP, _[X2, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STG_64soffset_ldsttags, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STG, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STG SP, [X2, #80]", asm);
        }
    }
}
