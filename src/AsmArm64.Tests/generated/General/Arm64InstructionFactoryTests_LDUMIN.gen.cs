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
public class Arm64InstructionFactoryTests_LDUMIN_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMIN_32_memop_0()
    {
        
        {
            var raw = LDUMIN(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMIN_ldumin_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMIN W0, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMIN_ldumin_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMIN W15, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMIN_ldumin_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMIN WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMIN_64_memop_1()
    {
        
        {
            var raw = LDUMIN(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN X0, X1, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN X15, X1, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN XZR, X1, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN X0, X16, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN X15, X16, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMIN_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMIN XZR, X16, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMIN_ldumin_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMIN X0, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMIN_ldumin_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMIN X15, [X3]", asm);
        }
        
        {
            var raw = LDUMIN(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMIN_ldumin_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMIN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMIN XZR, [X3]", asm);
        }
    }
}
