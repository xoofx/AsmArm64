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
public class Arm64InstructionFactoryTests_CINV_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_CINV_csinv_32_condsel_0()
    {
        
        {
            var raw = CINV(W0, W1, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W0, W1, NE", asm);
        }
        
        {
            var raw = CINV(W15, W1, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W15, W1, NE", asm);
        }
        
        {
            var raw = CINV(WZR, W1, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV WZR, W1, NE", asm);
        }
        
        {
            var raw = CINV(W0, W16, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W0, W16, NE", asm);
        }
        
        {
            var raw = CINV(W15, W16, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W15, W16, NE", asm);
        }
        
        {
            var raw = CINV(WZR, W16, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV WZR, W16, NE", asm);
        }
        
        {
            var raw = CINV(W0, WZR, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CSETM_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CSETM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CSETM W0, NE", asm);
        }
        
        {
            var raw = CINV(W15, WZR, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CSETM_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CSETM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CSETM W15, NE", asm);
        }
        
        {
            var raw = CINV(WZR, WZR, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CSETM_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CSETM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CSETM WZR, NE", asm);
        }
        
        {
            var raw = CINV(W0, W1, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W0, W1, HS", asm);
        }
        
        {
            var raw = CINV(W15, W1, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W15, W1, HS", asm);
        }
        
        {
            var raw = CINV(WZR, W1, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV WZR, W1, HS", asm);
        }
        
        {
            var raw = CINV(W0, W16, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W0, W16, HS", asm);
        }
        
        {
            var raw = CINV(W15, W16, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV W15, W16, HS", asm);
        }
        
        {
            var raw = CINV(WZR, W16, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV WZR, W16, HS", asm);
        }
        
        {
            var raw = CINV(W0, WZR, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CSETM_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CSETM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CSETM W0, HS", asm);
        }
        
        {
            var raw = CINV(W15, WZR, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CSETM_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CSETM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CSETM W15, HS", asm);
        }
        
        {
            var raw = CINV(WZR, WZR, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CSETM_csinv_32_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CSETM, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CSETM WZR, HS", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CINV"/>.
    /// </summary>
    [TestMethod]
    public void Test_CINV_csinv_64_condsel_1()
    {
        
        {
            var raw = CINV(X0, X1, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X0, X1, NE", asm);
        }
        
        {
            var raw = CINV(X15, X1, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X15, X1, NE", asm);
        }
        
        {
            var raw = CINV(XZR, X1, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV XZR, X1, NE", asm);
        }
        
        {
            var raw = CINV(X0, X16, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X0, X16, NE", asm);
        }
        
        {
            var raw = CINV(X15, X16, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X15, X16, NE", asm);
        }
        
        {
            var raw = CINV(XZR, X16, NE);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV XZR, X16, NE", asm);
        }
        
        {
            var raw = CINV(X0, X1, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X0, X1, HS", asm);
        }
        
        {
            var raw = CINV(X15, X1, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X15, X1, HS", asm);
        }
        
        {
            var raw = CINV(XZR, X1, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV XZR, X1, HS", asm);
        }
        
        {
            var raw = CINV(X0, X16, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X0, X16, HS", asm);
        }
        
        {
            var raw = CINV(X15, X16, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV X15, X16, HS", asm);
        }
        
        {
            var raw = CINV(XZR, X16, HS);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.CINV_csinv_64_condsel, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.CINV, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("CINV XZR, X16, HS", asm);
        }
    }
}
