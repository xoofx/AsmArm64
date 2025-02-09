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
public class Arm64InstructionFactoryTests_SETP_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SETP"/>.
    /// </summary>
    [TestMethod]
    public void Test_SETP_set_memcms_0()
    {
        
        {
            var raw = SETP(_[X1].Pre, X1, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, X1, X2", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, X16, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, X16, X2", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, XZR, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, XZR, X2", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, X1, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, X1, X17", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, X16, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, X16, X17", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, XZR, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, XZR, X17", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, X1, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, X1, XZR", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, X16, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, X16, XZR", asm);
        }
        
        {
            var raw = SETP(_[X1].Pre, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SETP_set_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SETP [X1]!, XZR, XZR", asm);
        }
    }
}
