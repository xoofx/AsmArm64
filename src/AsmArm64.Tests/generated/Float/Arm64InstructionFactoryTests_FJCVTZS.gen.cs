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
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FJCVTZS_Float
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FJCVTZS"/>.
    /// </summary>
    [TestMethod]
    public void Test_FJCVTZS_32d_float2int_0()
    {
        
        {
            var raw = FJCVTZS(W0, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FJCVTZS_32d_float2int, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FJCVTZS, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FJCVTZS W0, D1", asm);
        }
        
        {
            var raw = FJCVTZS(W15, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FJCVTZS_32d_float2int, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FJCVTZS, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FJCVTZS W15, D1", asm);
        }
        
        {
            var raw = FJCVTZS(WZR, D1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FJCVTZS_32d_float2int, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FJCVTZS, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FJCVTZS WZR, D1", asm);
        }
        
        {
            var raw = FJCVTZS(W0, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FJCVTZS_32d_float2int, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FJCVTZS, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FJCVTZS W0, D31", asm);
        }
        
        {
            var raw = FJCVTZS(W15, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FJCVTZS_32d_float2int, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FJCVTZS, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FJCVTZS W15, D31", asm);
        }
        
        {
            var raw = FJCVTZS(WZR, D31);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.FJCVTZS_32d_float2int, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.FJCVTZS, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("FJCVTZS WZR, D31", asm);
        }
    }
}
