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
public class Arm64InstructionFactoryTests_LD64B_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD64B"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD64B_64l_memop_0()
    {
        
        {
            var raw = LD64B(X0, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD64B_64l_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD64B, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD64B X0, [X2]", asm);
        }
        
        {
            var raw = LD64B(X15, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD64B_64l_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD64B, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD64B X15, [X2]", asm);
        }
        
        {
            var raw = LD64B(XZR, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD64B_64l_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD64B, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD64B XZR, [X2]", asm);
        }
    }
}
