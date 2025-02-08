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
public class Arm64InstructionFactoryTests_MSUBPT_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MSUBPT"/>.
    /// </summary>
    [TestMethod]
    public void Test_MSUBPT_64a_dp_3src_0()
    {
        
        {
            var raw = MSUBPT(X0, X1, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, X2, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, X2, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, X17, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, X17, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, XZR, X3);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, XZR, X3", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, X2, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, X2, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, X17, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, X17, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, XZR, X18);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, XZR, X18", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, X2, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, X2, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, X17, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, X17, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, X1, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X1, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, X1, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X1, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X1, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X1, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, X16, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, X16, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, X16, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, X16, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, X16, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, X16, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X0, XZR, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X0, XZR, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(X15, XZR, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT X15, XZR, XZR, XZR", asm);
        }
        
        {
            var raw = MSUBPT(XZR, XZR, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MSUBPT_64a_dp_3src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MSUBPT, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MSUBPT XZR, XZR, XZR, XZR", asm);
        }
    }
}
