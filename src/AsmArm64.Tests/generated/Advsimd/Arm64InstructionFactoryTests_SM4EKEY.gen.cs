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
public class Arm64InstructionFactoryTests_SM4EKEY_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SM4EKEY"/>.
    /// </summary>
    [TestMethod]
    public void Test_SM4EKEY_vvv4_cryptosha512_3_0()
    {
        
        {
            var raw = SM4EKEY(V0.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V0.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V30.T_4S, V1.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V30.4S, V1.4S, V2.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V0.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V0.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V30.T_4S, V31.T_4S, V2.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V30.4S, V31.4S, V2.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V0.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V0.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V30.T_4S, V1.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V30.4S, V1.4S, V0.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V0.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V0.4S, V31.4S, V0.4S", asm);
        }
        
        {
            var raw = SM4EKEY(V30.T_4S, V31.T_4S, V0.T_4S);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.SM4EKEY_vvv4_cryptosha512_3, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.SM4EKEY, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("SM4EKEY V30.4S, V31.4S, V0.4S", asm);
        }
    }
}
