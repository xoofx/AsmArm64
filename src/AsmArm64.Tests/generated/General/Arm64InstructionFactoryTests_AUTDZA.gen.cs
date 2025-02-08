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
public class Arm64InstructionFactoryTests_AUTDZA_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AUTDZA"/>.
    /// </summary>
    [TestMethod]
    public void Test_AUTDZA_64z_dp_1src_0()
    {
        
        {
            var raw = AUTDZA(X0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AUTDZA_64z_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AUTDZA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AUTDZA X0", asm);
        }
        
        {
            var raw = AUTDZA(X15);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AUTDZA_64z_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AUTDZA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AUTDZA X15", asm);
        }
        
        {
            var raw = AUTDZA(XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.AUTDZA_64z_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.AUTDZA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("AUTDZA XZR", asm);
        }
    }
}
