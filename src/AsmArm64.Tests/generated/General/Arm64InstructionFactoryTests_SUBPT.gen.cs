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
public class Arm64InstructionFactoryTests_SUBPT_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SUBPT"/>.
    /// </summary>
    [TestMethod]
    public void Test_SUBPT_64_addsub_pt_0()
    {
        
        {
            var raw = SUBPT(X1, X2, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, X2, X2", asm);
        }
        
        {
            var raw = SUBPT(X17, X2, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, X2, X2", asm);
        }
        
        {
            var raw = SUBPT(SP, X2, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, X2, X2", asm);
        }
        
        {
            var raw = SUBPT(X1, X18, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, X18, X2", asm);
        }
        
        {
            var raw = SUBPT(X17, X18, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, X18, X2", asm);
        }
        
        {
            var raw = SUBPT(SP, X18, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, X18, X2", asm);
        }
        
        {
            var raw = SUBPT(X1, SP, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, SP, X2", asm);
        }
        
        {
            var raw = SUBPT(X17, SP, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, SP, X2", asm);
        }
        
        {
            var raw = SUBPT(SP, SP, X2, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, SP, X2", asm);
        }
        
        {
            var raw = SUBPT(X1, X2, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, X2, X17", asm);
        }
        
        {
            var raw = SUBPT(X17, X2, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, X2, X17", asm);
        }
        
        {
            var raw = SUBPT(SP, X2, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, X2, X17", asm);
        }
        
        {
            var raw = SUBPT(X1, X18, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, X18, X17", asm);
        }
        
        {
            var raw = SUBPT(X17, X18, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, X18, X17", asm);
        }
        
        {
            var raw = SUBPT(SP, X18, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, X18, X17", asm);
        }
        
        {
            var raw = SUBPT(X1, SP, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, SP, X17", asm);
        }
        
        {
            var raw = SUBPT(X17, SP, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, SP, X17", asm);
        }
        
        {
            var raw = SUBPT(SP, SP, X17, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, SP, X17", asm);
        }
        
        {
            var raw = SUBPT(X1, X2, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, X2, XZR", asm);
        }
        
        {
            var raw = SUBPT(X17, X2, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, X2, XZR", asm);
        }
        
        {
            var raw = SUBPT(SP, X2, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, X2, XZR", asm);
        }
        
        {
            var raw = SUBPT(X1, X18, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, X18, XZR", asm);
        }
        
        {
            var raw = SUBPT(X17, X18, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, X18, XZR", asm);
        }
        
        {
            var raw = SUBPT(SP, X18, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, X18, XZR", asm);
        }
        
        {
            var raw = SUBPT(X1, SP, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X1, SP, XZR", asm);
        }
        
        {
            var raw = SUBPT(X17, SP, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT X17, SP, XZR", asm);
        }
        
        {
            var raw = SUBPT(SP, SP, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SUBPT_64_addsub_pt, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SUBPT SP, SP, XZR", asm);
        }
    }
}
