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
public class Arm64InstructionFactoryTests_STUMINB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STUMINB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STUMINB_lduminb_32_memop_0()
    {
        
        {
            var raw = STUMINB(W0, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMINB_lduminb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMINB W0, [X2]", asm);
        }
        
        {
            var raw = STUMINB(W15, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMINB_lduminb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMINB W15, [X2]", asm);
        }
        
        {
            var raw = STUMINB(WZR, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STUMINB_lduminb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STUMINB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STUMINB WZR, [X2]", asm);
        }
    }
}
