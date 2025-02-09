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
public class Arm64InstructionFactoryTests_CPYEWN_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CPYEWN"/>.
    /// </summary>
    [TestMethod]
    public void Test_CPYEWN_cpy_memcms_0()
    {
        
        {
            var raw = CPYEWN(_[X1].Pre, _[X2].Pre, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CPYEWN_cpy_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CPYEWN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CPYEWN [X1]!, [X2]!, X2", asm);
        }
        
        {
            var raw = CPYEWN(_[X1].Pre, _[X2].Pre, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CPYEWN_cpy_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CPYEWN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CPYEWN [X1]!, [X2]!, X17", asm);
        }
        
        {
            var raw = CPYEWN(_[X1].Pre, _[X2].Pre, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CPYEWN_cpy_memcms, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CPYEWN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CPYEWN [X1]!, [X2]!, XZR", asm);
        }
    }
}
