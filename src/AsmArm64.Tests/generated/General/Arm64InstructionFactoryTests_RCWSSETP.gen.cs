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
public class Arm64InstructionFactoryTests_RCWSSETP_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSSETP"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSSETP_128_memop_128_0()
    {
        
        {
            var raw = RCWSSETP(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP X0, X1, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP X15, X1, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP XZR, X1, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP X0, X16, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP X15, X16, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP XZR, X16, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP X0, XZR, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP X15, XZR, [X3]", asm);
        }
        
        {
            var raw = RCWSSETP(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.RCWSSETP_128_memop_128, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.RCWSSETP, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("RCWSSETP XZR, XZR, [X3]", asm);
        }
    }
}
