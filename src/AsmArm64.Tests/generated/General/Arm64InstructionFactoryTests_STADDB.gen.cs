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
public class Arm64InstructionFactoryTests_STADDB_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STADDB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STADDB_ldaddb_32_memop_0()
    {
        
        {
            var raw = STADDB(W0, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STADDB_ldaddb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STADDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STADDB W0, [X2]", asm);
        }
        
        {
            var raw = STADDB(W15, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STADDB_ldaddb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STADDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STADDB W15, [X2]", asm);
        }
        
        {
            var raw = STADDB(WZR, _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STADDB_ldaddb_32_memop, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STADDB, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STADDB WZR, [X2]", asm);
        }
    }
}
