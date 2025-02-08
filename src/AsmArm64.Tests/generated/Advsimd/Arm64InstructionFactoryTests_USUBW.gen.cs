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
public class Arm64InstructionFactoryTests_USUBW_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.USUBW"/>.
    /// </summary>
    [TestMethod]
    public void Test_USUBW_asimddiff_w_0()
    {
        
        {
            var raw = USUBW(V0.T_8H, V1.T_8H, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.8H, V1.8H, V2.8B", asm);
        }
        
        {
            var raw = USUBW(V30.T_8H, V1.T_8H, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.8H, V1.8H, V2.8B", asm);
        }
        
        {
            var raw = USUBW(V0.T_8H, V31.T_8H, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.8H, V31.8H, V2.8B", asm);
        }
        
        {
            var raw = USUBW(V30.T_8H, V31.T_8H, V2.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.8H, V31.8H, V2.8B", asm);
        }
        
        {
            var raw = USUBW(V0.T_8H, V1.T_8H, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.8H, V1.8H, V0.8B", asm);
        }
        
        {
            var raw = USUBW(V30.T_8H, V1.T_8H, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.8H, V1.8H, V0.8B", asm);
        }
        
        {
            var raw = USUBW(V0.T_8H, V31.T_8H, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.8H, V31.8H, V0.8B", asm);
        }
        
        {
            var raw = USUBW(V30.T_8H, V31.T_8H, V0.T_8B);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.8H, V31.8H, V0.8B", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.USUBW"/>.
    /// </summary>
    [TestMethod]
    public void Test_USUBW_asimddiff_w_1()
    {
        
        {
            var raw = USUBW(V0.T_4S, V1.T_4S, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.4S, V1.4S, V2.4H", asm);
        }
        
        {
            var raw = USUBW(V30.T_4S, V1.T_4S, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.4S, V1.4S, V2.4H", asm);
        }
        
        {
            var raw = USUBW(V0.T_4S, V31.T_4S, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.4S, V31.4S, V2.4H", asm);
        }
        
        {
            var raw = USUBW(V30.T_4S, V31.T_4S, V2.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.4S, V31.4S, V2.4H", asm);
        }
        
        {
            var raw = USUBW(V0.T_4S, V1.T_4S, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.4S, V1.4S, V0.4H", asm);
        }
        
        {
            var raw = USUBW(V30.T_4S, V1.T_4S, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.4S, V1.4S, V0.4H", asm);
        }
        
        {
            var raw = USUBW(V0.T_4S, V31.T_4S, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.4S, V31.4S, V0.4H", asm);
        }
        
        {
            var raw = USUBW(V30.T_4S, V31.T_4S, V0.T_4H);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.4S, V31.4S, V0.4H", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.USUBW"/>.
    /// </summary>
    [TestMethod]
    public void Test_USUBW_asimddiff_w_2()
    {
        
        {
            var raw = USUBW(V0.T_2D, V1.T_2D, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.2D, V1.2D, V2.2S", asm);
        }
        
        {
            var raw = USUBW(V30.T_2D, V1.T_2D, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.2D, V1.2D, V2.2S", asm);
        }
        
        {
            var raw = USUBW(V0.T_2D, V31.T_2D, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.2D, V31.2D, V2.2S", asm);
        }
        
        {
            var raw = USUBW(V30.T_2D, V31.T_2D, V2.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.2D, V31.2D, V2.2S", asm);
        }
        
        {
            var raw = USUBW(V0.T_2D, V1.T_2D, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.2D, V1.2D, V0.2S", asm);
        }
        
        {
            var raw = USUBW(V30.T_2D, V1.T_2D, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.2D, V1.2D, V0.2S", asm);
        }
        
        {
            var raw = USUBW(V0.T_2D, V31.T_2D, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V0.2D, V31.2D, V0.2S", asm);
        }
        
        {
            var raw = USUBW(V30.T_2D, V31.T_2D, V0.T_2S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.USUBW_asimddiff_w, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.USUBW, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("USUBW V30.2D, V31.2D, V0.2S", asm);
        }
    }
}
