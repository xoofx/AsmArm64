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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_STBFMAXNML_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STBFMAXNML"/>.
    /// </summary>
    [TestMethod]
    public void Test_STBFMAXNML_16_0()
    {
        
        {
            var raw = STBFMAXNML(H0, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STBFMAXNML_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STBFMAXNML, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STBFMAXNML H0, [X2]", asm);
        }
        
        {
            var raw = STBFMAXNML(H31, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STBFMAXNML_16, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STBFMAXNML, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STBFMAXNML H31, [X2]", asm);
        }
    }
}
