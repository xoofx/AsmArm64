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
public class Arm64InstructionFactoryTests_LDADDAL_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDAL_32_memop_0()
    {
        
        {
            var raw = LDADDAL(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL W0, WZR, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL W15, WZR, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL WZR, WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDAL_64_memop_1()
    {
        
        {
            var raw = LDADDAL(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL X0, X1, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL X15, X1, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL XZR, X1, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL X0, X16, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL X15, X16, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL XZR, X16, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL X0, XZR, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL X15, XZR, [X3]", asm);
        }
        
        {
            var raw = LDADDAL(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDAL_64_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDAL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDAL XZR, XZR, [X3]", asm);
        }
    }
}
