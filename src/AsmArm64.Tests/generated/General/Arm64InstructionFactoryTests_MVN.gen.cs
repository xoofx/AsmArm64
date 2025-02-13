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
public class Arm64InstructionFactoryTests_MVN_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MVN"/>.
    /// </summary>
    [TestMethod]
    public void Test_MVN_orn_32_log_shift_0()
    {
        
        {
            var raw = MVN(W0, W1, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W1", asm);
        }
        
        {
            var raw = MVN(W15, W1, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W1", asm);
        }
        
        {
            var raw = MVN(WZR, W1, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W1", asm);
        }
        
        {
            var raw = MVN(W0, W16, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W16", asm);
        }
        
        {
            var raw = MVN(W15, W16, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W16", asm);
        }
        
        {
            var raw = MVN(WZR, W16, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W16", asm);
        }
        
        {
            var raw = MVN(W0, WZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, WZR", asm);
        }
        
        {
            var raw = MVN(W15, WZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, WZR", asm);
        }
        
        {
            var raw = MVN(WZR, WZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, WZR", asm);
        }
        
        {
            var raw = MVN(W0, W1, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W1, LSL #1", asm);
        }
        
        {
            var raw = MVN(W15, W1, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W1, LSL #1", asm);
        }
        
        {
            var raw = MVN(WZR, W1, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W1, LSL #1", asm);
        }
        
        {
            var raw = MVN(W0, W16, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W16, LSL #1", asm);
        }
        
        {
            var raw = MVN(W15, W16, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W16, LSL #1", asm);
        }
        
        {
            var raw = MVN(WZR, W16, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W16, LSL #1", asm);
        }
        
        {
            var raw = MVN(W0, WZR, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, WZR, LSL #1", asm);
        }
        
        {
            var raw = MVN(W15, WZR, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, WZR, LSL #1", asm);
        }
        
        {
            var raw = MVN(WZR, WZR, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, WZR, LSL #1", asm);
        }
        
        {
            var raw = MVN(W0, W1, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W1, LSR #10", asm);
        }
        
        {
            var raw = MVN(W15, W1, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W1, LSR #10", asm);
        }
        
        {
            var raw = MVN(WZR, W1, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W1, LSR #10", asm);
        }
        
        {
            var raw = MVN(W0, W16, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W16, LSR #10", asm);
        }
        
        {
            var raw = MVN(W15, W16, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W16, LSR #10", asm);
        }
        
        {
            var raw = MVN(WZR, W16, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W16, LSR #10", asm);
        }
        
        {
            var raw = MVN(W0, WZR, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, WZR, LSR #10", asm);
        }
        
        {
            var raw = MVN(W15, WZR, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, WZR, LSR #10", asm);
        }
        
        {
            var raw = MVN(WZR, WZR, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, WZR, LSR #10", asm);
        }
        
        {
            var raw = MVN(W0, W1, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W1, ASR #12", asm);
        }
        
        {
            var raw = MVN(W15, W1, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W1, ASR #12", asm);
        }
        
        {
            var raw = MVN(WZR, W1, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W1, ASR #12", asm);
        }
        
        {
            var raw = MVN(W0, W16, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W16, ASR #12", asm);
        }
        
        {
            var raw = MVN(W15, W16, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W16, ASR #12", asm);
        }
        
        {
            var raw = MVN(WZR, W16, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W16, ASR #12", asm);
        }
        
        {
            var raw = MVN(W0, WZR, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, WZR, ASR #12", asm);
        }
        
        {
            var raw = MVN(W15, WZR, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, WZR, ASR #12", asm);
        }
        
        {
            var raw = MVN(WZR, WZR, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, WZR, ASR #12", asm);
        }
        
        {
            var raw = MVN(W0, W1, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W1, ROR #7", asm);
        }
        
        {
            var raw = MVN(W15, W1, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W1, ROR #7", asm);
        }
        
        {
            var raw = MVN(WZR, W1, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W1, ROR #7", asm);
        }
        
        {
            var raw = MVN(W0, W16, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, W16, ROR #7", asm);
        }
        
        {
            var raw = MVN(W15, W16, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, W16, ROR #7", asm);
        }
        
        {
            var raw = MVN(WZR, W16, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, W16, ROR #7", asm);
        }
        
        {
            var raw = MVN(W0, WZR, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W0, WZR, ROR #7", asm);
        }
        
        {
            var raw = MVN(W15, WZR, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN W15, WZR, ROR #7", asm);
        }
        
        {
            var raw = MVN(WZR, WZR, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_32_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN WZR, WZR, ROR #7", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MVN"/>.
    /// </summary>
    [TestMethod]
    public void Test_MVN_orn_64_log_shift_1()
    {
        
        {
            var raw = MVN(X0, X1, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X1", asm);
        }
        
        {
            var raw = MVN(X15, X1, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X1", asm);
        }
        
        {
            var raw = MVN(XZR, X1, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X1", asm);
        }
        
        {
            var raw = MVN(X0, X16, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X16", asm);
        }
        
        {
            var raw = MVN(X15, X16, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X16", asm);
        }
        
        {
            var raw = MVN(XZR, X16, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X16", asm);
        }
        
        {
            var raw = MVN(X0, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, XZR", asm);
        }
        
        {
            var raw = MVN(X15, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, XZR", asm);
        }
        
        {
            var raw = MVN(XZR, XZR, _LSL, 0);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, XZR", asm);
        }
        
        {
            var raw = MVN(X0, X1, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X1, LSL #1", asm);
        }
        
        {
            var raw = MVN(X15, X1, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X1, LSL #1", asm);
        }
        
        {
            var raw = MVN(XZR, X1, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X1, LSL #1", asm);
        }
        
        {
            var raw = MVN(X0, X16, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X16, LSL #1", asm);
        }
        
        {
            var raw = MVN(X15, X16, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X16, LSL #1", asm);
        }
        
        {
            var raw = MVN(XZR, X16, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X16, LSL #1", asm);
        }
        
        {
            var raw = MVN(X0, XZR, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, XZR, LSL #1", asm);
        }
        
        {
            var raw = MVN(X15, XZR, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, XZR, LSL #1", asm);
        }
        
        {
            var raw = MVN(XZR, XZR, _LSL, 1);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, XZR, LSL #1", asm);
        }
        
        {
            var raw = MVN(X0, X1, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X1, LSR #10", asm);
        }
        
        {
            var raw = MVN(X15, X1, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X1, LSR #10", asm);
        }
        
        {
            var raw = MVN(XZR, X1, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X1, LSR #10", asm);
        }
        
        {
            var raw = MVN(X0, X16, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X16, LSR #10", asm);
        }
        
        {
            var raw = MVN(X15, X16, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X16, LSR #10", asm);
        }
        
        {
            var raw = MVN(XZR, X16, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X16, LSR #10", asm);
        }
        
        {
            var raw = MVN(X0, XZR, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, XZR, LSR #10", asm);
        }
        
        {
            var raw = MVN(X15, XZR, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, XZR, LSR #10", asm);
        }
        
        {
            var raw = MVN(XZR, XZR, _LSR, 10);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, XZR, LSR #10", asm);
        }
        
        {
            var raw = MVN(X0, X1, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X1, ASR #12", asm);
        }
        
        {
            var raw = MVN(X15, X1, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X1, ASR #12", asm);
        }
        
        {
            var raw = MVN(XZR, X1, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X1, ASR #12", asm);
        }
        
        {
            var raw = MVN(X0, X16, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X16, ASR #12", asm);
        }
        
        {
            var raw = MVN(X15, X16, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X16, ASR #12", asm);
        }
        
        {
            var raw = MVN(XZR, X16, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X16, ASR #12", asm);
        }
        
        {
            var raw = MVN(X0, XZR, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, XZR, ASR #12", asm);
        }
        
        {
            var raw = MVN(X15, XZR, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, XZR, ASR #12", asm);
        }
        
        {
            var raw = MVN(XZR, XZR, _ASR, 12);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, XZR, ASR #12", asm);
        }
        
        {
            var raw = MVN(X0, X1, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X1, ROR #7", asm);
        }
        
        {
            var raw = MVN(X15, X1, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X1, ROR #7", asm);
        }
        
        {
            var raw = MVN(XZR, X1, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X1, ROR #7", asm);
        }
        
        {
            var raw = MVN(X0, X16, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, X16, ROR #7", asm);
        }
        
        {
            var raw = MVN(X15, X16, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, X16, ROR #7", asm);
        }
        
        {
            var raw = MVN(XZR, X16, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, X16, ROR #7", asm);
        }
        
        {
            var raw = MVN(X0, XZR, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X0, XZR, ROR #7", asm);
        }
        
        {
            var raw = MVN(X15, XZR, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN X15, XZR, ROR #7", asm);
        }
        
        {
            var raw = MVN(XZR, XZR, _ROR, 7);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.MVN_orn_64_log_shift, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.MVN, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("MVN XZR, XZR, ROR #7", asm);
        }
    }
}
