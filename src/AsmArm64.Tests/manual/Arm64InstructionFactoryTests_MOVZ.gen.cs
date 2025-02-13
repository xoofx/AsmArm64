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
namespace AsmArm64.Tests.manual;

[TestClass]
public class Arm64InstructionFactoryTests_MOVZ_General
{

    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOVZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOVZ_32_movewide_0()
    {

        {
            var raw = MOVZ(W0, 5, _LSL, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MOVZ_32_movewide, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MOVZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MOVZ W0, #5, LSL #16", asm);
        }

        {
            var raw = MOVZ(W15, 5, _LSL, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MOVZ_32_movewide, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MOVZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MOVZ W15, #5, LSL #16", asm);
        }

        {
            var raw = MOVZ(WZR, 5, _LSL, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MOVZ_32_movewide, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MOVZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MOVZ WZR, #5, LSL #16", asm);
        }
    }

    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOVZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOVZ_64_movewide_1()
    {

        {
            var raw = MOVZ(X0, 5, _LSL, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MOVZ_64_movewide, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MOVZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MOVZ X0, #5, LSL #16", asm);
        }

        {
            var raw = MOVZ(X15, 5, _LSL, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MOVZ_64_movewide, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MOVZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MOVZ X15, #5, LSL #16", asm);
        }

        {
            var raw = MOVZ(XZR, 5, _LSL, 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MOVZ_64_movewide, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MOVZ, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MOVZ XZR, #5, LSL #16", asm);
        }
    }
}
