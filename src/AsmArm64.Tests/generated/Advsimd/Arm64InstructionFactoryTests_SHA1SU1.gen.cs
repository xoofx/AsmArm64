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
public class Arm64InstructionFactoryTests_SHA1SU1_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHA1SU1"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHA1SU1_vv_cryptosha2_0()
    {
        TestInst(SHA1SU1(V0.T_4S, V1.T_4S), asm => asm.SHA1SU1(V0.T_4S, V1.T_4S), Arm64InstructionId.SHA1SU1_vv_cryptosha2, Arm64Mnemonic.SHA1SU1, "SHA1SU1 V0.4S, V1.4S");
        TestInst(SHA1SU1(V30.T_4S, V1.T_4S), asm => asm.SHA1SU1(V30.T_4S, V1.T_4S), Arm64InstructionId.SHA1SU1_vv_cryptosha2, Arm64Mnemonic.SHA1SU1, "SHA1SU1 V30.4S, V1.4S");
        TestInst(SHA1SU1(V0.T_4S, V31.T_4S), asm => asm.SHA1SU1(V0.T_4S, V31.T_4S), Arm64InstructionId.SHA1SU1_vv_cryptosha2, Arm64Mnemonic.SHA1SU1, "SHA1SU1 V0.4S, V31.4S");
        TestInst(SHA1SU1(V30.T_4S, V31.T_4S), asm => asm.SHA1SU1(V30.T_4S, V31.T_4S), Arm64InstructionId.SHA1SU1_vv_cryptosha2, Arm64Mnemonic.SHA1SU1, "SHA1SU1 V30.4S, V31.4S");
    }
}
