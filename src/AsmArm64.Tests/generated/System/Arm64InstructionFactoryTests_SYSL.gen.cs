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
namespace AsmArm64.Tests.System;

[TestClass]
public class Arm64InstructionFactoryTests_SYSL_System
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SYSL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SYSL_rc_systeminstrs_0()
    {
        
        {
            var raw = SYSL(X0, 5, C2, C3, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X0, #5, C2, C3, #5", asm);
        }
        
        {
            var raw = SYSL(X15, 5, C2, C3, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X15, #5, C2, C3, #5", asm);
        }
        
        {
            var raw = SYSL(XZR, 5, C2, C3, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL XZR, #5, C2, C3, #5", asm);
        }
        
        {
            var raw = SYSL(X0, 5, C15, C3, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X0, #5, C15, C3, #5", asm);
        }
        
        {
            var raw = SYSL(X15, 5, C15, C3, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X15, #5, C15, C3, #5", asm);
        }
        
        {
            var raw = SYSL(XZR, 5, C15, C3, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL XZR, #5, C15, C3, #5", asm);
        }
        
        {
            var raw = SYSL(X0, 5, C2, C15, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X0, #5, C2, C15, #5", asm);
        }
        
        {
            var raw = SYSL(X15, 5, C2, C15, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X15, #5, C2, C15, #5", asm);
        }
        
        {
            var raw = SYSL(XZR, 5, C2, C15, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL XZR, #5, C2, C15, #5", asm);
        }
        
        {
            var raw = SYSL(X0, 5, C15, C15, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X0, #5, C15, C15, #5", asm);
        }
        
        {
            var raw = SYSL(X15, 5, C15, C15, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL X15, #5, C15, C15, #5", asm);
        }
        
        {
            var raw = SYSL(XZR, 5, C15, C15, 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SYSL_rc_systeminstrs, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SYSL, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SYSL XZR, #5, C15, C15, #5", asm);
        }
    }
}
