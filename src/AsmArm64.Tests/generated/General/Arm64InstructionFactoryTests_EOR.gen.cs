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
public class Arm64InstructionFactoryTests_EOR_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_EOR_32_log_imm_0()
    {
        
        {
            var raw = EOR(W1, W1, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR W1, W1, #0x3030303", asm);
        }
        
        {
            var raw = EOR(W17, W1, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR W17, W1, #0x3030303", asm);
        }
        
        {
            var raw = EOR(WSP, W1, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR WSP, W1, #0x3030303", asm);
        }
        
        {
            var raw = EOR(W1, W16, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR W1, W16, #0x3030303", asm);
        }
        
        {
            var raw = EOR(W17, W16, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR W17, W16, #0x3030303", asm);
        }
        
        {
            var raw = EOR(WSP, W16, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR WSP, W16, #0x3030303", asm);
        }
        
        {
            var raw = EOR(W1, WZR, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR W1, WZR, #0x3030303", asm);
        }
        
        {
            var raw = EOR(W17, WZR, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR W17, WZR, #0x3030303", asm);
        }
        
        {
            var raw = EOR(WSP, WZR, 0x3030303);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_32_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR WSP, WZR, #0x3030303", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_EOR_64_log_imm_1()
    {
        
        {
            var raw = EOR(X1, X1, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR X1, X1, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(X17, X1, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR X17, X1, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(SP, X1, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR SP, X1, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(X1, X16, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR X1, X16, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(X17, X16, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR X17, X16, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(SP, X16, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR SP, X16, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(X1, XZR, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR X1, XZR, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(X17, XZR, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR X17, XZR, #0x303030303030303", asm);
        }
        
        {
            var raw = EOR(SP, XZR, 0x303030303030303UL);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.EOR_64_log_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.EOR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("EOR SP, XZR, #0x303030303030303", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_EOR_32_log_shift_2()
    {
        Assert.Inconclusive("TODO");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_EOR_64_log_shift_3()
    {
        Assert.Inconclusive("TODO");
    }
}
