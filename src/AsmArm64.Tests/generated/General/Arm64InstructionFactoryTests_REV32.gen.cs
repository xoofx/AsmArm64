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
public class Arm64InstructionFactoryTests_REV32_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV32"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV32_64_dp_1src_0()
    {
        
        {
            var raw = REV32(X0, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 X0, X1", asm);
        }
        
        {
            var raw = REV32(X15, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 X15, X1", asm);
        }
        
        {
            var raw = REV32(XZR, X1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 XZR, X1", asm);
        }
        
        {
            var raw = REV32(X0, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 X0, X16", asm);
        }
        
        {
            var raw = REV32(X15, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 X15, X16", asm);
        }
        
        {
            var raw = REV32(XZR, X16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 XZR, X16", asm);
        }
        
        {
            var raw = REV32(X0, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 X0, XZR", asm);
        }
        
        {
            var raw = REV32(X15, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 X15, XZR", asm);
        }
        
        {
            var raw = REV32(XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.REV32_64_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.REV32, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("REV32 XZR, XZR", asm);
        }
    }
}
