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
public class Arm64InstructionFactoryTests_LDAPURSB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPURSB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPURSB_32_ldapstl_unscaled_0()
    {
        
        {
            var raw = LDAPURSB(W0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDAPURSB_32_ldapstl_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDAPURSB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDAPURSB W0, [X2, #5]", asm);
        }
        
        {
            var raw = LDAPURSB(W15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDAPURSB_32_ldapstl_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDAPURSB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDAPURSB W15, [X2, #5]", asm);
        }
        
        {
            var raw = LDAPURSB(WZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDAPURSB_32_ldapstl_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDAPURSB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDAPURSB WZR, [X2, #5]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPURSB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPURSB_64_ldapstl_unscaled_1()
    {
        
        {
            var raw = LDAPURSB(X0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDAPURSB_64_ldapstl_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDAPURSB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDAPURSB X0, [X2, #5]", asm);
        }
        
        {
            var raw = LDAPURSB(X15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDAPURSB_64_ldapstl_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDAPURSB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDAPURSB X15, [X2, #5]", asm);
        }
        
        {
            var raw = LDAPURSB(XZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDAPURSB_64_ldapstl_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDAPURSB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDAPURSB XZR, [X2, #5]", asm);
        }
    }
}
