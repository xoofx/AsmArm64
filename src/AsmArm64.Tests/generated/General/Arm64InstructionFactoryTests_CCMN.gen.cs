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
public class Arm64InstructionFactoryTests_CCMN_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CCMN"/>.
    /// </summary>
    [TestMethod]
    public void Test_CCMN_32_condcmp_imm_0()
    {
        
        {
            var raw = CCMN(W0, 5, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, #5, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W15, 5, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, #5, #5, NE", asm);
        }
        
        {
            var raw = CCMN(WZR, 5, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, #5, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W0, 5, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, #5, #5, HS", asm);
        }
        
        {
            var raw = CCMN(W15, 5, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, #5, #5, HS", asm);
        }
        
        {
            var raw = CCMN(WZR, 5, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, #5, #5, HS", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CCMN"/>.
    /// </summary>
    [TestMethod]
    public void Test_CCMN_64_condcmp_imm_1()
    {
        
        {
            var raw = CCMN(X0, 5, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, #5, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X15, 5, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, #5, #5, NE", asm);
        }
        
        {
            var raw = CCMN(XZR, 5, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, #5, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X0, 5, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, #5, #5, HS", asm);
        }
        
        {
            var raw = CCMN(X15, 5, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, #5, #5, HS", asm);
        }
        
        {
            var raw = CCMN(XZR, 5, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_imm, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, #5, #5, HS", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CCMN"/>.
    /// </summary>
    [TestMethod]
    public void Test_CCMN_32_condcmp_reg_2()
    {
        
        {
            var raw = CCMN(W0, W1, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, W1, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W15, W1, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, W1, #5, NE", asm);
        }
        
        {
            var raw = CCMN(WZR, W1, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, W1, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W0, W16, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, W16, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W15, W16, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, W16, #5, NE", asm);
        }
        
        {
            var raw = CCMN(WZR, W16, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, W16, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W0, WZR, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, WZR, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W15, WZR, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, WZR, #5, NE", asm);
        }
        
        {
            var raw = CCMN(WZR, WZR, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, WZR, #5, NE", asm);
        }
        
        {
            var raw = CCMN(W0, W1, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, W1, #5, HS", asm);
        }
        
        {
            var raw = CCMN(W15, W1, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, W1, #5, HS", asm);
        }
        
        {
            var raw = CCMN(WZR, W1, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, W1, #5, HS", asm);
        }
        
        {
            var raw = CCMN(W0, W16, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, W16, #5, HS", asm);
        }
        
        {
            var raw = CCMN(W15, W16, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, W16, #5, HS", asm);
        }
        
        {
            var raw = CCMN(WZR, W16, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, W16, #5, HS", asm);
        }
        
        {
            var raw = CCMN(W0, WZR, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W0, WZR, #5, HS", asm);
        }
        
        {
            var raw = CCMN(W15, WZR, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN W15, WZR, #5, HS", asm);
        }
        
        {
            var raw = CCMN(WZR, WZR, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_32_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN WZR, WZR, #5, HS", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CCMN"/>.
    /// </summary>
    [TestMethod]
    public void Test_CCMN_64_condcmp_reg_3()
    {
        
        {
            var raw = CCMN(X0, X1, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, X1, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X15, X1, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, X1, #5, NE", asm);
        }
        
        {
            var raw = CCMN(XZR, X1, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, X1, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X0, X16, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, X16, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X15, X16, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, X16, #5, NE", asm);
        }
        
        {
            var raw = CCMN(XZR, X16, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, X16, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X0, XZR, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, XZR, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X15, XZR, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, XZR, #5, NE", asm);
        }
        
        {
            var raw = CCMN(XZR, XZR, 5, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, XZR, #5, NE", asm);
        }
        
        {
            var raw = CCMN(X0, X1, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, X1, #5, HS", asm);
        }
        
        {
            var raw = CCMN(X15, X1, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, X1, #5, HS", asm);
        }
        
        {
            var raw = CCMN(XZR, X1, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, X1, #5, HS", asm);
        }
        
        {
            var raw = CCMN(X0, X16, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, X16, #5, HS", asm);
        }
        
        {
            var raw = CCMN(X15, X16, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, X16, #5, HS", asm);
        }
        
        {
            var raw = CCMN(XZR, X16, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, X16, #5, HS", asm);
        }
        
        {
            var raw = CCMN(X0, XZR, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X0, XZR, #5, HS", asm);
        }
        
        {
            var raw = CCMN(X15, XZR, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN X15, XZR, #5, HS", asm);
        }
        
        {
            var raw = CCMN(XZR, XZR, 5, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CCMN_64_condcmp_reg, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CCMN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CCMN XZR, XZR, #5, HS", asm);
        }
    }
}
