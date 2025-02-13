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
public class Arm64InstructionFactoryTests_LDEORL_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDEORL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDEORL_32_memop_0()
    {
        
        {
            var raw = LDEORL(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDEORL(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDEORL(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDEORL(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDEORL(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDEORL(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDEORL(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEORL_ldeorl_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEORL W0, [X3]", asm);
        }
        
        {
            var raw = LDEORL(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEORL_ldeorl_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEORL W15, [X3]", asm);
        }
        
        {
            var raw = LDEORL(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEORL_ldeorl_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEORL WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDEORL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDEORL_64_memop_1()
    {
        
        {
            var raw = LDEORL(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL X0, X1, [X3]", asm);
        }
        
        {
            var raw = LDEORL(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL X15, X1, [X3]", asm);
        }
        
        {
            var raw = LDEORL(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL XZR, X1, [X3]", asm);
        }
        
        {
            var raw = LDEORL(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL X0, X16, [X3]", asm);
        }
        
        {
            var raw = LDEORL(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL X15, X16, [X3]", asm);
        }
        
        {
            var raw = LDEORL(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDEORL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDEORL XZR, X16, [X3]", asm);
        }
        
        {
            var raw = LDEORL(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEORL_ldeorl_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEORL X0, [X3]", asm);
        }
        
        {
            var raw = LDEORL(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEORL_ldeorl_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEORL X15, [X3]", asm);
        }
        
        {
            var raw = LDEORL(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STEORL_ldeorl_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STEORL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STEORL XZR, [X3]", asm);
        }
    }
}
