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
public class Arm64InstructionFactoryTests_STLXR_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLXR_sr32_ldstexclr_0()
    {
        
        {
            var raw = STLXR(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W0, W1, [X3]", asm);
        }
        
        {
            var raw = STLXR(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W15, W1, [X3]", asm);
        }
        
        {
            var raw = STLXR(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR WZR, W1, [X3]", asm);
        }
        
        {
            var raw = STLXR(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W0, W16, [X3]", asm);
        }
        
        {
            var raw = STLXR(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W15, W16, [X3]", asm);
        }
        
        {
            var raw = STLXR(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR WZR, W16, [X3]", asm);
        }
        
        {
            var raw = STLXR(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W0, WZR, [X3]", asm);
        }
        
        {
            var raw = STLXR(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W15, WZR, [X3]", asm);
        }
        
        {
            var raw = STLXR(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr32_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR WZR, WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLXR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLXR_sr64_ldstexclr_1()
    {
        
        {
            var raw = STLXR(W0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W0, X1, [X3]", asm);
        }
        
        {
            var raw = STLXR(W15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W15, X1, [X3]", asm);
        }
        
        {
            var raw = STLXR(WZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR WZR, X1, [X3]", asm);
        }
        
        {
            var raw = STLXR(W0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W0, X16, [X3]", asm);
        }
        
        {
            var raw = STLXR(W15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W15, X16, [X3]", asm);
        }
        
        {
            var raw = STLXR(WZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR WZR, X16, [X3]", asm);
        }
        
        {
            var raw = STLXR(W0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W0, XZR, [X3]", asm);
        }
        
        {
            var raw = STLXR(W15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR W15, XZR, [X3]", asm);
        }
        
        {
            var raw = STLXR(WZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STLXR_sr64_ldstexclr, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STLXR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STLXR WZR, XZR, [X3]", asm);
        }
    }
}
