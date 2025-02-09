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
public class Arm64InstructionFactoryTests_STGP_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STGP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STGP_64_ldstpair_post_0()
    {
        
        {
            var raw = STGP(X0, X1, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, X1, [X3], #80", asm);
        }
        
        {
            var raw = STGP(X15, X1, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, X1, [X3], #80", asm);
        }
        
        {
            var raw = STGP(XZR, X1, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, X1, [X3], #80", asm);
        }
        
        {
            var raw = STGP(X0, X16, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, X16, [X3], #80", asm);
        }
        
        {
            var raw = STGP(X15, X16, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, X16, [X3], #80", asm);
        }
        
        {
            var raw = STGP(XZR, X16, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, X16, [X3], #80", asm);
        }
        
        {
            var raw = STGP(X0, XZR, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, XZR, [X3], #80", asm);
        }
        
        {
            var raw = STGP(X15, XZR, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, XZR, [X3], #80", asm);
        }
        
        {
            var raw = STGP(XZR, XZR, _[X3], 80);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_post, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, XZR, [X3], #80", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STGP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STGP_64_ldstpair_pre_1()
    {
        
        {
            var raw = STGP(X0, X1, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, X1, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(X15, X1, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, X1, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(XZR, X1, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, X1, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(X0, X16, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, X16, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(X15, X16, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, X16, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(XZR, X16, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, X16, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(X0, XZR, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, XZR, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(X15, XZR, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, XZR, [X3, #80]!", asm);
        }
        
        {
            var raw = STGP(XZR, XZR, _[X3, 80].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_pre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, XZR, [X3, #80]!", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STGP"/>.
    /// </summary>
    [TestMethod]
    public void Test_STGP_64_ldstpair_off_2()
    {
        
        {
            var raw = STGP(X0, X1, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, X1, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(X15, X1, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, X1, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(XZR, X1, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, X1, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(X0, X16, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, X16, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(X15, X16, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, X16, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(XZR, X16, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, X16, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(X0, XZR, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X0, XZR, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(X15, XZR, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP X15, XZR, [X3, #80]", asm);
        }
        
        {
            var raw = STGP(XZR, XZR, _[X3, 80]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STGP_64_ldstpair_off, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STGP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STGP XZR, XZR, [X3, #80]", asm);
        }
    }
}
