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
public class Arm64InstructionFactoryTests_SHA512SU0_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SHA512SU0"/>.
    /// </summary>
    [TestMethod]
    public void Test_SHA512SU0_vv2_cryptosha512_2_0()
    {
        TestInst(SHA512SU0(V0.T_2D, V1.T_2D), asm => asm.SHA512SU0(V0.T_2D, V1.T_2D), Arm64InstructionId.SHA512SU0_vv2_cryptosha512_2, Arm64Mnemonic.SHA512SU0, "SHA512SU0 V0.2D, V1.2D");
        TestInst(SHA512SU0(V30.T_2D, V1.T_2D), asm => asm.SHA512SU0(V30.T_2D, V1.T_2D), Arm64InstructionId.SHA512SU0_vv2_cryptosha512_2, Arm64Mnemonic.SHA512SU0, "SHA512SU0 V30.2D, V1.2D");
        TestInst(SHA512SU0(V0.T_2D, V31.T_2D), asm => asm.SHA512SU0(V0.T_2D, V31.T_2D), Arm64InstructionId.SHA512SU0_vv2_cryptosha512_2, Arm64Mnemonic.SHA512SU0, "SHA512SU0 V0.2D, V31.2D");
        TestInst(SHA512SU0(V30.T_2D, V31.T_2D), asm => asm.SHA512SU0(V30.T_2D, V31.T_2D), Arm64InstructionId.SHA512SU0_vv2_cryptosha512_2, Arm64Mnemonic.SHA512SU0, "SHA512SU0 V30.2D, V31.2D");
    }
}
