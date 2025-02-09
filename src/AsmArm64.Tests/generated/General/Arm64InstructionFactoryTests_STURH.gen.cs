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
public class Arm64InstructionFactoryTests_STURH_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STURH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STURH_32_ldst_unscaled_0()
    {
        
        {
            var raw = STURH(W0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STURH_32_ldst_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STURH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STURH W0, [X2, #5]", asm);
        }
        
        {
            var raw = STURH(W15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STURH_32_ldst_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STURH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STURH W15, [X2, #5]", asm);
        }
        
        {
            var raw = STURH(WZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STURH_32_ldst_unscaled, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STURH, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STURH WZR, [X2, #5]", asm);
        }
    }
}
