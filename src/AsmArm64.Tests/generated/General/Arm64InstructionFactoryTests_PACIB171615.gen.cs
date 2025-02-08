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
public class Arm64InstructionFactoryTests_PACIB171615_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACIB171615"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACIB171615_64lr_dp_1src_0()
    {
        
        {
            var raw = PACIB171615();
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.PACIB171615_64lr_dp_1src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.PACIB171615, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("PACIB171615", asm);
        }
    }
}
