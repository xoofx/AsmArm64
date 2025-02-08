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
public class Arm64InstructionFactoryTests_PACDB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACDB"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACDB_64p_dp_1src_0()
    {
        
        {
            var raw = PACDB(X0, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB X0, X2", asm);
        }
        
        {
            var raw = PACDB(X15, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB X15, X2", asm);
        }
        
        {
            var raw = PACDB(XZR, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB XZR, X2", asm);
        }
        
        {
            var raw = PACDB(X0, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB X0, X18", asm);
        }
        
        {
            var raw = PACDB(X15, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB X15, X18", asm);
        }
        
        {
            var raw = PACDB(XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB XZR, X18", asm);
        }
        
        {
            var raw = PACDB(X0, SP);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB X0, SP", asm);
        }
        
        {
            var raw = PACDB(X15, SP);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB X15, SP", asm);
        }
        
        {
            var raw = PACDB(XZR, SP);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACDB_64p_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACDB XZR, SP", asm);
        }
    }
}
