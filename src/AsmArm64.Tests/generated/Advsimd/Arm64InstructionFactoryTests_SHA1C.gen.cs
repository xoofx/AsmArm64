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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_SHA1C_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHA1C"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHA1C_qsv_cryptosha3_0()
    {
        TestInst(SHA1C(Q0, S1, V2.T_4S), asm => asm.SHA1C(Q0, S1, V2.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q0, S1, V2.4S");
        TestInst(SHA1C(Q31, S1, V2.T_4S), asm => asm.SHA1C(Q31, S1, V2.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q31, S1, V2.4S");
        TestInst(SHA1C(Q0, S31, V2.T_4S), asm => asm.SHA1C(Q0, S31, V2.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q0, S31, V2.4S");
        TestInst(SHA1C(Q31, S31, V2.T_4S), asm => asm.SHA1C(Q31, S31, V2.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q31, S31, V2.4S");
        TestInst(SHA1C(Q0, S1, V0.T_4S), asm => asm.SHA1C(Q0, S1, V0.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q0, S1, V0.4S");
        TestInst(SHA1C(Q31, S1, V0.T_4S), asm => asm.SHA1C(Q31, S1, V0.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q31, S1, V0.4S");
        TestInst(SHA1C(Q0, S31, V0.T_4S), asm => asm.SHA1C(Q0, S31, V0.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q0, S31, V0.4S");
        TestInst(SHA1C(Q31, S31, V0.T_4S), asm => asm.SHA1C(Q31, S31, V0.T_4S), Arm64InstructionId.SHA1C_qsv_cryptosha3, Arm64Mnemonic.SHA1C, "SHA1C Q31, S31, V0.4S");
    }
}
