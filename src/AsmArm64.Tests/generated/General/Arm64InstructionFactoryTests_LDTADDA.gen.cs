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
public class Arm64InstructionFactoryTests_LDTADDA_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTADDA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTADDA_32_memop_unpriv_0()
    {
        
        {
            var raw = LDTADDA(W0, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA W0, W1, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(W15, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA W15, W1, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(WZR, W1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA WZR, W1, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(W0, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA W0, W16, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(W15, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA W15, W16, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(WZR, W16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA WZR, W16, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(W0, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA W0, WZR, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(W15, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA W15, WZR, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(WZR, WZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_32_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA WZR, WZR, [X3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTADDA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTADDA_64_memop_unpriv_1()
    {
        
        {
            var raw = LDTADDA(X0, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA X0, X1, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(X15, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA X15, X1, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(XZR, X1, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA XZR, X1, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(X0, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA X0, X16, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(X15, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA X15, X16, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(XZR, X16, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA XZR, X16, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(X0, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA X0, XZR, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(X15, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA X15, XZR, [X3]", asm);
        }
        
        {
            var raw = LDTADDA(XZR, XZR, _[X3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LDTADDA_64_memop_unpriv, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LDTADDA, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LDTADDA XZR, XZR, [X3]", asm);
        }
    }
}
