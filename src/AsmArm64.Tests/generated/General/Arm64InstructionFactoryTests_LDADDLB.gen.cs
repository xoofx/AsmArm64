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
public class Arm64InstructionFactoryTests_LDADDLB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDADDLB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDADDLB_32_memop_0()
    {
        
        {
            var raw = LDADDLB(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDLB W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDLB W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDLB WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDLB W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDLB W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDADDLB_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDADDLB WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STADDLB_ldaddlb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STADDLB W0, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STADDLB_ldaddlb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STADDLB W15, [X3]", asm);
        }
        
        {
            var raw = LDADDLB(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STADDLB_ldaddlb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STADDLB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STADDLB WZR, [X3]", asm);
        }
    }
}
