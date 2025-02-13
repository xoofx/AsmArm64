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
public class Arm64InstructionFactoryTests_LDUMAXH_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDUMAXH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDUMAXH_32_memop_0()
    {
        
        {
            var raw = LDUMAXH(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMAXH_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMAXH W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMAXH_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMAXH W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMAXH_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMAXH WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMAXH_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMAXH W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMAXH_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMAXH W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDUMAXH_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDUMAXH WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMAXH_ldumaxh_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMAXH W0, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMAXH_ldumaxh_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMAXH W15, [X3]", asm);
        }
        
        {
            var raw = LDUMAXH(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMAXH_ldumaxh_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMAXH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMAXH WZR, [X3]", asm);
        }
    }
}
