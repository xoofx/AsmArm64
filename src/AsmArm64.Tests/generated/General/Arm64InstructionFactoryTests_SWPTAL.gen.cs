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
public class Arm64InstructionFactoryTests_SWPTAL_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTAL_32_memop_unpriv_0()
    {
        
        {
            var raw = SWPTAL(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL W0, W1, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL W15, W1, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL WZR, W1, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL W0, W16, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL W15, W16, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL WZR, W16, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL W0, WZR, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL W15, WZR, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL WZR, WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SWPTAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SWPTAL_64_memop_unpriv_1()
    {
        
        {
            var raw = SWPTAL(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL X0, X1, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL X15, X1, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL XZR, X1, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL X0, X16, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL X15, X16, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL XZR, X16, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL X0, XZR, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL X15, XZR, [X3]", asm);
        }
        
        {
            var raw = SWPTAL(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SWPTAL_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SWPTAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SWPTAL XZR, XZR, [X3]", asm);
        }
    }
}
