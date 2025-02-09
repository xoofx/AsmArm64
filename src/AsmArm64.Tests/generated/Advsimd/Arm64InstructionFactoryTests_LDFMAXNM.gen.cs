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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_LDFMAXNM_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAXNM_16_0()
    {
        
        {
            var raw = LDFMAXNM(H0, H1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM H0, H1, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(H31, H1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM H31, H1, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(H0, H31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM H0, H31, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(H31, H31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM H31, H31, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAXNM_32_1()
    {
        
        {
            var raw = LDFMAXNM(S0, S1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_32, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM S0, S1, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(S31, S1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_32, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM S31, S1, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(S0, S31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_32, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM S0, S31, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(S31, S31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_32, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM S31, S31, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAXNM_64_2()
    {
        
        {
            var raw = LDFMAXNM(D0, D1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_64, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM D0, D1, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(D31, D1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_64, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM D31, D1, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(D0, D31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_64, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM D0, D31, [X3]", asm);
        }
        
        {
            var raw = LDFMAXNM(D31, D31, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDFMAXNM_64, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDFMAXNM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDFMAXNM D31, D31, [X3]", asm);
        }
    }
}
