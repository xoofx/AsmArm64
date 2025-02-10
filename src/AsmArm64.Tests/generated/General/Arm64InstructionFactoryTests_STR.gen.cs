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
public class Arm64InstructionFactoryTests_STR_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_32_ldst_immpost_0()
    {
        
        {
            var raw = STR(W0, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W0, [X2], #5", asm);
        }
        
        {
            var raw = STR(W15, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W15, [X2], #5", asm);
        }
        
        {
            var raw = STR(WZR, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR WZR, [X2], #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_64_ldst_immpost_1()
    {
        
        {
            var raw = STR(X0, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X0, [X2], #5", asm);
        }
        
        {
            var raw = STR(X15, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X15, [X2], #5", asm);
        }
        
        {
            var raw = STR(XZR, _[X2], 5);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_immpost, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR XZR, [X2], #5", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_32_ldst_immpre_2()
    {
        
        {
            var raw = STR(W0, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W0, [X2, #5]!", asm);
        }
        
        {
            var raw = STR(W15, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W15, [X2, #5]!", asm);
        }
        
        {
            var raw = STR(WZR, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR WZR, [X2, #5]!", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_64_ldst_immpre_3()
    {
        
        {
            var raw = STR(X0, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X0, [X2, #5]!", asm);
        }
        
        {
            var raw = STR(X15, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X15, [X2, #5]!", asm);
        }
        
        {
            var raw = STR(XZR, _[X2, 5].Pre);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_immpre, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR XZR, [X2, #5]!", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_32_ldst_pos_4()
    {
        
        {
            var raw = STR(W0, _[X2, 20]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W0, [X2, #20]", asm);
        }
        
        {
            var raw = STR(W15, _[X2, 20]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W15, [X2, #20]", asm);
        }
        
        {
            var raw = STR(WZR, _[X2, 20]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR WZR, [X2, #20]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_64_ldst_pos_5()
    {
        
        {
            var raw = STR(X0, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X0, [X2, #5]", asm);
        }
        
        {
            var raw = STR(X15, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X15, [X2, #5]", asm);
        }
        
        {
            var raw = STR(XZR, _[X2, 5]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_pos, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR XZR, [X2, #5]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_32_ldst_regoff_6()
    {
        
        {
            var raw = STR(W0, _[X2, X3, _LSL, 2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W0, [X2, X3, LSL #2]", asm);
        }
        
        {
            var raw = STR(W15, _[X2, X3, _LSL, 2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR W15, [X2, X3, LSL #2]", asm);
        }
        
        {
            var raw = STR(WZR, _[X2, X3, _LSL, 2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_32_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR WZR, [X2, X3, LSL #2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_32_ldst_regoff_7()
    {
        Assert.Inconclusive("Not handled STR_32_ldst_regoff - STR         Wt, [Xn|SP, (Wm|Xm){, extend, {amount}}]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_64_ldst_regoff_8()
    {
        
        {
            var raw = STR(X0, _[X2, X3, _LSL, 3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X0, [X2, X3, LSL #3]", asm);
        }
        
        {
            var raw = STR(X15, _[X2, X3, _LSL, 3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR X15, [X2, X3, LSL #3]", asm);
        }
        
        {
            var raw = STR(XZR, _[X2, X3, _LSL, 3]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.STR_64_ldst_regoff, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.STR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("STR XZR, [X2, X3, LSL #3]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STR_64_ldst_regoff_9()
    {
        Assert.Inconclusive("Not handled STR_64_ldst_regoff - STR         Xt, [Xn|SP, (Wm|Xm){, extend, {amount}}]");
    }
}
