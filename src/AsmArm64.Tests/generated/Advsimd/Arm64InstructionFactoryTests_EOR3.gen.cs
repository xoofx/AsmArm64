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
public class Arm64InstructionFactoryTests_EOR3_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EOR3"/>.
    /// </summary>
    [TestMethod]
    public void Test_EOR3_vvv16_crypto4_0()
    {
        TestInst(EOR3(V0.T_16B, V1.T_16B, V2.T_16B, V3.T_16B), asm => asm.EOR3(V0.T_16B, V1.T_16B, V2.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V1.16B, V2.16B, V3.16B");
        TestInst(EOR3(V30.T_16B, V1.T_16B, V2.T_16B, V3.T_16B), asm => asm.EOR3(V30.T_16B, V1.T_16B, V2.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V1.16B, V2.16B, V3.16B");
        TestInst(EOR3(V0.T_16B, V31.T_16B, V2.T_16B, V3.T_16B), asm => asm.EOR3(V0.T_16B, V31.T_16B, V2.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V31.16B, V2.16B, V3.16B");
        TestInst(EOR3(V30.T_16B, V31.T_16B, V2.T_16B, V3.T_16B), asm => asm.EOR3(V30.T_16B, V31.T_16B, V2.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V31.16B, V2.16B, V3.16B");
        TestInst(EOR3(V0.T_16B, V1.T_16B, V0.T_16B, V3.T_16B), asm => asm.EOR3(V0.T_16B, V1.T_16B, V0.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V1.16B, V0.16B, V3.16B");
        TestInst(EOR3(V30.T_16B, V1.T_16B, V0.T_16B, V3.T_16B), asm => asm.EOR3(V30.T_16B, V1.T_16B, V0.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V1.16B, V0.16B, V3.16B");
        TestInst(EOR3(V0.T_16B, V31.T_16B, V0.T_16B, V3.T_16B), asm => asm.EOR3(V0.T_16B, V31.T_16B, V0.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V31.16B, V0.16B, V3.16B");
        TestInst(EOR3(V30.T_16B, V31.T_16B, V0.T_16B, V3.T_16B), asm => asm.EOR3(V30.T_16B, V31.T_16B, V0.T_16B, V3.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V31.16B, V0.16B, V3.16B");
        TestInst(EOR3(V0.T_16B, V1.T_16B, V2.T_16B, V1.T_16B), asm => asm.EOR3(V0.T_16B, V1.T_16B, V2.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V1.16B, V2.16B, V1.16B");
        TestInst(EOR3(V30.T_16B, V1.T_16B, V2.T_16B, V1.T_16B), asm => asm.EOR3(V30.T_16B, V1.T_16B, V2.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V1.16B, V2.16B, V1.16B");
        TestInst(EOR3(V0.T_16B, V31.T_16B, V2.T_16B, V1.T_16B), asm => asm.EOR3(V0.T_16B, V31.T_16B, V2.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V31.16B, V2.16B, V1.16B");
        TestInst(EOR3(V30.T_16B, V31.T_16B, V2.T_16B, V1.T_16B), asm => asm.EOR3(V30.T_16B, V31.T_16B, V2.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V31.16B, V2.16B, V1.16B");
        TestInst(EOR3(V0.T_16B, V1.T_16B, V0.T_16B, V1.T_16B), asm => asm.EOR3(V0.T_16B, V1.T_16B, V0.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V1.16B, V0.16B, V1.16B");
        TestInst(EOR3(V30.T_16B, V1.T_16B, V0.T_16B, V1.T_16B), asm => asm.EOR3(V30.T_16B, V1.T_16B, V0.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V1.16B, V0.16B, V1.16B");
        TestInst(EOR3(V0.T_16B, V31.T_16B, V0.T_16B, V1.T_16B), asm => asm.EOR3(V0.T_16B, V31.T_16B, V0.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V0.16B, V31.16B, V0.16B, V1.16B");
        TestInst(EOR3(V30.T_16B, V31.T_16B, V0.T_16B, V1.T_16B), asm => asm.EOR3(V30.T_16B, V31.T_16B, V0.T_16B, V1.T_16B), Arm64InstructionId.EOR3_vvv16_crypto4, Arm64Mnemonic.EOR3, "EOR3 V30.16B, V31.16B, V0.16B, V1.16B");
    }
}
