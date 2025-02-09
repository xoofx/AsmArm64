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
public class Arm64InstructionFactoryTests_LDLARH_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDLARH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDLARH_lr32_ldstord_0()
    {
        
        {
            var raw = LDLARH(W0, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDLARH_lr32_ldstord, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDLARH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDLARH W0, [X2]", asm);
        }
        
        {
            var raw = LDLARH(W15, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDLARH_lr32_ldstord, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDLARH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDLARH W15, [X2]", asm);
        }
        
        {
            var raw = LDLARH(WZR, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDLARH_lr32_ldstord, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDLARH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDLARH WZR, [X2]", asm);
        }
    }
}
