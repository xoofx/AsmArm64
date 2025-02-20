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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_SMULL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMULL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMULL_smaddl_64wa_dp_3src_0()
    {
        TestInst(SMULL(X0, W1, W2), asm => asm.SMULL(X0, W1, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W1, W2");
        TestInst(SMULL(X15, W1, W2), asm => asm.SMULL(X15, W1, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W1, W2");
        TestInst(SMULL(XZR, W1, W2), asm => asm.SMULL(XZR, W1, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W1, W2");
        TestInst(SMULL(X0, W16, W2), asm => asm.SMULL(X0, W16, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W16, W2");
        TestInst(SMULL(X15, W16, W2), asm => asm.SMULL(X15, W16, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W16, W2");
        TestInst(SMULL(XZR, W16, W2), asm => asm.SMULL(XZR, W16, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W16, W2");
        TestInst(SMULL(X0, WZR, W2), asm => asm.SMULL(X0, WZR, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, WZR, W2");
        TestInst(SMULL(X15, WZR, W2), asm => asm.SMULL(X15, WZR, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, WZR, W2");
        TestInst(SMULL(XZR, WZR, W2), asm => asm.SMULL(XZR, WZR, W2), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, WZR, W2");
        TestInst(SMULL(X0, W1, W17), asm => asm.SMULL(X0, W1, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W1, W17");
        TestInst(SMULL(X15, W1, W17), asm => asm.SMULL(X15, W1, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W1, W17");
        TestInst(SMULL(XZR, W1, W17), asm => asm.SMULL(XZR, W1, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W1, W17");
        TestInst(SMULL(X0, W16, W17), asm => asm.SMULL(X0, W16, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W16, W17");
        TestInst(SMULL(X15, W16, W17), asm => asm.SMULL(X15, W16, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W16, W17");
        TestInst(SMULL(XZR, W16, W17), asm => asm.SMULL(XZR, W16, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W16, W17");
        TestInst(SMULL(X0, WZR, W17), asm => asm.SMULL(X0, WZR, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, WZR, W17");
        TestInst(SMULL(X15, WZR, W17), asm => asm.SMULL(X15, WZR, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, WZR, W17");
        TestInst(SMULL(XZR, WZR, W17), asm => asm.SMULL(XZR, WZR, W17), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, WZR, W17");
        TestInst(SMULL(X0, W1, WZR), asm => asm.SMULL(X0, W1, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W1, WZR");
        TestInst(SMULL(X15, W1, WZR), asm => asm.SMULL(X15, W1, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W1, WZR");
        TestInst(SMULL(XZR, W1, WZR), asm => asm.SMULL(XZR, W1, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W1, WZR");
        TestInst(SMULL(X0, W16, WZR), asm => asm.SMULL(X0, W16, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W16, WZR");
        TestInst(SMULL(X15, W16, WZR), asm => asm.SMULL(X15, W16, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W16, WZR");
        TestInst(SMULL(XZR, W16, WZR), asm => asm.SMULL(XZR, W16, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W16, WZR");
        TestInst(SMULL(X0, WZR, WZR), asm => asm.SMULL(X0, WZR, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, WZR, WZR");
        TestInst(SMULL(X15, WZR, WZR), asm => asm.SMULL(X15, WZR, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, WZR, WZR");
        TestInst(SMULL(XZR, WZR, WZR), asm => asm.SMULL(XZR, WZR, WZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, WZR, WZR");
    }
}
