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
public class Arm64InstructionFactoryTests_NGC_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.NGC"/>.
    /// </summary>
    [TestMethod]
    public void Test_NGC_sbc_32_addsub_carry_0()
    {
        
        {
            var raw = NGC(W0, W1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC W0, W1", asm);
        }
        
        {
            var raw = NGC(W15, W1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC W15, W1", asm);
        }
        
        {
            var raw = NGC(WZR, W1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC WZR, W1", asm);
        }
        
        {
            var raw = NGC(W0, W16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC W0, W16", asm);
        }
        
        {
            var raw = NGC(W15, W16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC W15, W16", asm);
        }
        
        {
            var raw = NGC(WZR, W16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC WZR, W16", asm);
        }
        
        {
            var raw = NGC(W0, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC W0, WZR", asm);
        }
        
        {
            var raw = NGC(W15, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC W15, WZR", asm);
        }
        
        {
            var raw = NGC(WZR, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_32_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC WZR, WZR", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.NGC"/>.
    /// </summary>
    [TestMethod]
    public void Test_NGC_sbc_64_addsub_carry_1()
    {
        
        {
            var raw = NGC(X0, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC X0, X1", asm);
        }
        
        {
            var raw = NGC(X15, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC X15, X1", asm);
        }
        
        {
            var raw = NGC(XZR, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC XZR, X1", asm);
        }
        
        {
            var raw = NGC(X0, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC X0, X16", asm);
        }
        
        {
            var raw = NGC(X15, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC X15, X16", asm);
        }
        
        {
            var raw = NGC(XZR, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC XZR, X16", asm);
        }
        
        {
            var raw = NGC(X0, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC X0, XZR", asm);
        }
        
        {
            var raw = NGC(X15, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC X15, XZR", asm);
        }
        
        {
            var raw = NGC(XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.NGC_sbc_64_addsub_carry, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.NGC, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("NGC XZR, XZR", asm);
        }
    }
}
