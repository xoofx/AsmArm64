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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_SM3PARTW2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SM3PARTW2"/>.
    /// </summary>
    [TestMethod]
    public void Test_SM3PARTW2_vvv4_cryptosha512_3_0()
    {
        TestInst(SM3PARTW2(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.SM3PARTW2(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V0.4S, V1.4S, V2.4S");
        TestInst(SM3PARTW2(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.SM3PARTW2(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V30.4S, V1.4S, V2.4S");
        TestInst(SM3PARTW2(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.SM3PARTW2(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V0.4S, V31.4S, V2.4S");
        TestInst(SM3PARTW2(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.SM3PARTW2(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V30.4S, V31.4S, V2.4S");
        TestInst(SM3PARTW2(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.SM3PARTW2(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V0.4S, V1.4S, V0.4S");
        TestInst(SM3PARTW2(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.SM3PARTW2(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V30.4S, V1.4S, V0.4S");
        TestInst(SM3PARTW2(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.SM3PARTW2(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V0.4S, V31.4S, V0.4S");
        TestInst(SM3PARTW2(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.SM3PARTW2(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.SM3PARTW2_vvv4_cryptosha512_3, Arm64Mnemonic.SM3PARTW2, "SM3PARTW2 V30.4S, V31.4S, V0.4S");
    }
}
