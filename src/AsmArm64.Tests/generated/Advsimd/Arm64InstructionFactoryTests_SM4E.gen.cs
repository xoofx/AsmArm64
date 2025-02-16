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
public class Arm64InstructionFactoryTests_SM4E_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SM4E"/>.
    /// </summary>
    [TestMethod]
    public void Test_SM4E_vv4_cryptosha512_2_0()
    {
        TestInst(SM4E(V0.T_4S, V1.T_4S), asm => asm.SM4E(V0.T_4S, V1.T_4S), Arm64InstructionId.SM4E_vv4_cryptosha512_2, Arm64Mnemonic.SM4E, "SM4E V0.4S, V1.4S");
        TestInst(SM4E(V30.T_4S, V1.T_4S), asm => asm.SM4E(V30.T_4S, V1.T_4S), Arm64InstructionId.SM4E_vv4_cryptosha512_2, Arm64Mnemonic.SM4E, "SM4E V30.4S, V1.4S");
        TestInst(SM4E(V0.T_4S, V31.T_4S), asm => asm.SM4E(V0.T_4S, V31.T_4S), Arm64InstructionId.SM4E_vv4_cryptosha512_2, Arm64Mnemonic.SM4E, "SM4E V0.4S, V31.4S");
        TestInst(SM4E(V30.T_4S, V31.T_4S), asm => asm.SM4E(V30.T_4S, V31.T_4S), Arm64InstructionId.SM4E_vv4_cryptosha512_2, Arm64Mnemonic.SM4E, "SM4E V30.4S, V31.4S");
    }
}
