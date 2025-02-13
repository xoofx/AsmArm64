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
public class Arm64InstructionFactoryTests_LDEOR_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDEOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDEOR_32_memop_0()
    {
        
        {
            var raw = LDEOR(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDEOR(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDEOR(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDEOR(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDEOR(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDEOR(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDEOR(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEOR_ldeor_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEOR W0, [X3]", asm);
        }
        
        {
            var raw = LDEOR(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEOR_ldeor_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEOR W15, [X3]", asm);
        }
        
        {
            var raw = LDEOR(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEOR_ldeor_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEOR WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDEOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDEOR_64_memop_1()
    {
        
        {
            var raw = LDEOR(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR X0, X1, [X3]", asm);
        }
        
        {
            var raw = LDEOR(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR X15, X1, [X3]", asm);
        }
        
        {
            var raw = LDEOR(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR XZR, X1, [X3]", asm);
        }
        
        {
            var raw = LDEOR(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR X0, X16, [X3]", asm);
        }
        
        {
            var raw = LDEOR(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR X15, X16, [X3]", asm);
        }
        
        {
            var raw = LDEOR(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEOR_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEOR XZR, X16, [X3]", asm);
        }
        
        {
            var raw = LDEOR(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEOR_ldeor_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEOR X0, [X3]", asm);
        }
        
        {
            var raw = LDEOR(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEOR_ldeor_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEOR X15, [X3]", asm);
        }
        
        {
            var raw = LDEOR(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEOR_ldeor_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEOR XZR, [X3]", asm);
        }
    }
}
