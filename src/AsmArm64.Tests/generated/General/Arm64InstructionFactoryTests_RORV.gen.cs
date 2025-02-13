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
public class Arm64InstructionFactoryTests_RORV_General
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RORV"/>.
    /// </summary>
    [TestMethod]
    public void Test_RORV_32_dp_2src_0()
    {
        
        {
            var raw = RORV(W0, W1, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, W1, W2", asm);
        }
        
        {
            var raw = RORV(W15, W1, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, W1, W2", asm);
        }
        
        {
            var raw = RORV(WZR, W1, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, W1, W2", asm);
        }
        
        {
            var raw = RORV(W0, W16, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, W16, W2", asm);
        }
        
        {
            var raw = RORV(W15, W16, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, W16, W2", asm);
        }
        
        {
            var raw = RORV(WZR, W16, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, W16, W2", asm);
        }
        
        {
            var raw = RORV(W0, WZR, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, WZR, W2", asm);
        }
        
        {
            var raw = RORV(W15, WZR, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, WZR, W2", asm);
        }
        
        {
            var raw = RORV(WZR, WZR, W2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, WZR, W2", asm);
        }
        
        {
            var raw = RORV(W0, W1, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, W1, W17", asm);
        }
        
        {
            var raw = RORV(W15, W1, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, W1, W17", asm);
        }
        
        {
            var raw = RORV(WZR, W1, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, W1, W17", asm);
        }
        
        {
            var raw = RORV(W0, W16, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, W16, W17", asm);
        }
        
        {
            var raw = RORV(W15, W16, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, W16, W17", asm);
        }
        
        {
            var raw = RORV(WZR, W16, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, W16, W17", asm);
        }
        
        {
            var raw = RORV(W0, WZR, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, WZR, W17", asm);
        }
        
        {
            var raw = RORV(W15, WZR, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, WZR, W17", asm);
        }
        
        {
            var raw = RORV(WZR, WZR, W17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, WZR, W17", asm);
        }
        
        {
            var raw = RORV(W0, W1, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, W1, WZR", asm);
        }
        
        {
            var raw = RORV(W15, W1, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, W1, WZR", asm);
        }
        
        {
            var raw = RORV(WZR, W1, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, W1, WZR", asm);
        }
        
        {
            var raw = RORV(W0, W16, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, W16, WZR", asm);
        }
        
        {
            var raw = RORV(W15, W16, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, W16, WZR", asm);
        }
        
        {
            var raw = RORV(WZR, W16, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, W16, WZR", asm);
        }
        
        {
            var raw = RORV(W0, WZR, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W0, WZR, WZR", asm);
        }
        
        {
            var raw = RORV(W15, WZR, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR W15, WZR, WZR", asm);
        }
        
        {
            var raw = RORV(WZR, WZR, WZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_32_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR WZR, WZR, WZR", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RORV"/>.
    /// </summary>
    [TestMethod]
    public void Test_RORV_64_dp_2src_1()
    {
        
        {
            var raw = RORV(X0, X1, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, X1, X2", asm);
        }
        
        {
            var raw = RORV(X15, X1, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, X1, X2", asm);
        }
        
        {
            var raw = RORV(XZR, X1, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, X1, X2", asm);
        }
        
        {
            var raw = RORV(X0, X16, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, X16, X2", asm);
        }
        
        {
            var raw = RORV(X15, X16, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, X16, X2", asm);
        }
        
        {
            var raw = RORV(XZR, X16, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, X16, X2", asm);
        }
        
        {
            var raw = RORV(X0, XZR, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, XZR, X2", asm);
        }
        
        {
            var raw = RORV(X15, XZR, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, XZR, X2", asm);
        }
        
        {
            var raw = RORV(XZR, XZR, X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, XZR, X2", asm);
        }
        
        {
            var raw = RORV(X0, X1, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, X1, X17", asm);
        }
        
        {
            var raw = RORV(X15, X1, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, X1, X17", asm);
        }
        
        {
            var raw = RORV(XZR, X1, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, X1, X17", asm);
        }
        
        {
            var raw = RORV(X0, X16, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, X16, X17", asm);
        }
        
        {
            var raw = RORV(X15, X16, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, X16, X17", asm);
        }
        
        {
            var raw = RORV(XZR, X16, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, X16, X17", asm);
        }
        
        {
            var raw = RORV(X0, XZR, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, XZR, X17", asm);
        }
        
        {
            var raw = RORV(X15, XZR, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, XZR, X17", asm);
        }
        
        {
            var raw = RORV(XZR, XZR, X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, XZR, X17", asm);
        }
        
        {
            var raw = RORV(X0, X1, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, X1, XZR", asm);
        }
        
        {
            var raw = RORV(X15, X1, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, X1, XZR", asm);
        }
        
        {
            var raw = RORV(XZR, X1, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, X1, XZR", asm);
        }
        
        {
            var raw = RORV(X0, X16, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, X16, XZR", asm);
        }
        
        {
            var raw = RORV(X15, X16, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, X16, XZR", asm);
        }
        
        {
            var raw = RORV(XZR, X16, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, X16, XZR", asm);
        }
        
        {
            var raw = RORV(X0, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X0, XZR, XZR", asm);
        }
        
        {
            var raw = RORV(X15, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR X15, XZR, XZR", asm);
        }
        
        {
            var raw = RORV(XZR, XZR, XZR);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.ROR_rorv_64_dp_2src, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.ROR, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("ROR XZR, XZR, XZR", asm);
        }
    }
}
