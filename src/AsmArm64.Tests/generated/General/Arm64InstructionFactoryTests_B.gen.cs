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
public class Arm64InstructionFactoryTests_B_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.B"/>.
    /// </summary>
    [TestMethod]
    public void Test_B_only_branch_imm_0()
    {
        
        {
            var raw = B(32);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.B_only_branch_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.B, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("B #32", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.B"/>.
    /// </summary>
    [TestMethod]
    public void Test_B_only_condbranch_1()
    {
        Assert.Inconclusive("TODO");
    }
}
