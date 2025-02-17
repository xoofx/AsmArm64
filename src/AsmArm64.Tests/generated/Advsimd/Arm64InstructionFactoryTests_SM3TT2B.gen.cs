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
public class Arm64InstructionFactoryTests_SM3TT2B_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SM3TT2B"/>.
    /// </summary>
    [TestMethod]
    public void Test_SM3TT2B_vvv_crypto3_imm2_0()
    {
        TestInst(SM3TT2B(V0.T_4S, V1.T_4S, V2.S[1]), asm => asm.SM3TT2B(V0.T_4S, V1.T_4S, V2.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V0.4S, V1.4S, V2.S[1]");
        TestInst(SM3TT2B(V30.T_4S, V1.T_4S, V2.S[1]), asm => asm.SM3TT2B(V30.T_4S, V1.T_4S, V2.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V30.4S, V1.4S, V2.S[1]");
        TestInst(SM3TT2B(V0.T_4S, V31.T_4S, V2.S[1]), asm => asm.SM3TT2B(V0.T_4S, V31.T_4S, V2.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V0.4S, V31.4S, V2.S[1]");
        TestInst(SM3TT2B(V30.T_4S, V31.T_4S, V2.S[1]), asm => asm.SM3TT2B(V30.T_4S, V31.T_4S, V2.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V30.4S, V31.4S, V2.S[1]");
        TestInst(SM3TT2B(V0.T_4S, V1.T_4S, V0.S[1]), asm => asm.SM3TT2B(V0.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V0.4S, V1.4S, V0.S[1]");
        TestInst(SM3TT2B(V30.T_4S, V1.T_4S, V0.S[1]), asm => asm.SM3TT2B(V30.T_4S, V1.T_4S, V0.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V30.4S, V1.4S, V0.S[1]");
        TestInst(SM3TT2B(V0.T_4S, V31.T_4S, V0.S[1]), asm => asm.SM3TT2B(V0.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V0.4S, V31.4S, V0.S[1]");
        TestInst(SM3TT2B(V30.T_4S, V31.T_4S, V0.S[1]), asm => asm.SM3TT2B(V30.T_4S, V31.T_4S, V0.S[1]), Arm64InstructionId.SM3TT2B_vvv_crypto3_imm2, Arm64Mnemonic.SM3TT2B, "SM3TT2B V30.4S, V31.4S, V0.S[1]");
    }
}
