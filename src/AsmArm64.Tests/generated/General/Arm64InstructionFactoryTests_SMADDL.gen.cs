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
public class Arm64InstructionFactoryTests_SMADDL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMADDL_64wa_dp_3src_0()
    {
        TestInst(SMADDL(X0, W1, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W1, W2, X3");
        TestInst(SMADDL(X15, W1, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W1, W2, X3");
        TestInst(SMADDL(XZR, W1, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W1, W2, X3");
        TestInst(SMADDL(X0, W16, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W16, W2, X3");
        TestInst(SMADDL(X15, W16, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W16, W2, X3");
        TestInst(SMADDL(XZR, W16, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W16, W2, X3");
        TestInst(SMADDL(X0, WZR, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, WZR, W2, X3");
        TestInst(SMADDL(X15, WZR, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, WZR, W2, X3");
        TestInst(SMADDL(XZR, WZR, W2, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, WZR, W2, X3");
        TestInst(SMADDL(X0, W1, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W1, W17, X3");
        TestInst(SMADDL(X15, W1, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W1, W17, X3");
        TestInst(SMADDL(XZR, W1, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W1, W17, X3");
        TestInst(SMADDL(X0, W16, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W16, W17, X3");
        TestInst(SMADDL(X15, W16, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W16, W17, X3");
        TestInst(SMADDL(XZR, W16, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W16, W17, X3");
        TestInst(SMADDL(X0, WZR, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, WZR, W17, X3");
        TestInst(SMADDL(X15, WZR, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, WZR, W17, X3");
        TestInst(SMADDL(XZR, WZR, W17, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, WZR, W17, X3");
        TestInst(SMADDL(X0, W1, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W1, WZR, X3");
        TestInst(SMADDL(X15, W1, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W1, WZR, X3");
        TestInst(SMADDL(XZR, W1, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W1, WZR, X3");
        TestInst(SMADDL(X0, W16, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W16, WZR, X3");
        TestInst(SMADDL(X15, W16, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W16, WZR, X3");
        TestInst(SMADDL(XZR, W16, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W16, WZR, X3");
        TestInst(SMADDL(X0, WZR, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, WZR, WZR, X3");
        TestInst(SMADDL(X15, WZR, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, WZR, WZR, X3");
        TestInst(SMADDL(XZR, WZR, WZR, X3), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, WZR, WZR, X3");
        TestInst(SMADDL(X0, W1, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W1, W2, X18");
        TestInst(SMADDL(X15, W1, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W1, W2, X18");
        TestInst(SMADDL(XZR, W1, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W1, W2, X18");
        TestInst(SMADDL(X0, W16, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W16, W2, X18");
        TestInst(SMADDL(X15, W16, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W16, W2, X18");
        TestInst(SMADDL(XZR, W16, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W16, W2, X18");
        TestInst(SMADDL(X0, WZR, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, WZR, W2, X18");
        TestInst(SMADDL(X15, WZR, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, WZR, W2, X18");
        TestInst(SMADDL(XZR, WZR, W2, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, WZR, W2, X18");
        TestInst(SMADDL(X0, W1, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W1, W17, X18");
        TestInst(SMADDL(X15, W1, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W1, W17, X18");
        TestInst(SMADDL(XZR, W1, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W1, W17, X18");
        TestInst(SMADDL(X0, W16, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W16, W17, X18");
        TestInst(SMADDL(X15, W16, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W16, W17, X18");
        TestInst(SMADDL(XZR, W16, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W16, W17, X18");
        TestInst(SMADDL(X0, WZR, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, WZR, W17, X18");
        TestInst(SMADDL(X15, WZR, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, WZR, W17, X18");
        TestInst(SMADDL(XZR, WZR, W17, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, WZR, W17, X18");
        TestInst(SMADDL(X0, W1, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W1, WZR, X18");
        TestInst(SMADDL(X15, W1, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W1, WZR, X18");
        TestInst(SMADDL(XZR, W1, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W1, WZR, X18");
        TestInst(SMADDL(X0, W16, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, W16, WZR, X18");
        TestInst(SMADDL(X15, W16, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, W16, WZR, X18");
        TestInst(SMADDL(XZR, W16, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, W16, WZR, X18");
        TestInst(SMADDL(X0, WZR, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X0, WZR, WZR, X18");
        TestInst(SMADDL(X15, WZR, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL X15, WZR, WZR, X18");
        TestInst(SMADDL(XZR, WZR, WZR, X18), Arm64InstructionId.SMADDL_64wa_dp_3src, Arm64Mnemonic.SMADDL, "SMADDL XZR, WZR, WZR, X18");
        TestInst(SMADDL(X0, W1, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W1, W2");
        TestInst(SMADDL(X15, W1, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W1, W2");
        TestInst(SMADDL(XZR, W1, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W1, W2");
        TestInst(SMADDL(X0, W16, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W16, W2");
        TestInst(SMADDL(X15, W16, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W16, W2");
        TestInst(SMADDL(XZR, W16, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W16, W2");
        TestInst(SMADDL(X0, WZR, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, WZR, W2");
        TestInst(SMADDL(X15, WZR, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, WZR, W2");
        TestInst(SMADDL(XZR, WZR, W2, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, WZR, W2");
        TestInst(SMADDL(X0, W1, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W1, W17");
        TestInst(SMADDL(X15, W1, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W1, W17");
        TestInst(SMADDL(XZR, W1, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W1, W17");
        TestInst(SMADDL(X0, W16, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W16, W17");
        TestInst(SMADDL(X15, W16, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W16, W17");
        TestInst(SMADDL(XZR, W16, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W16, W17");
        TestInst(SMADDL(X0, WZR, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, WZR, W17");
        TestInst(SMADDL(X15, WZR, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, WZR, W17");
        TestInst(SMADDL(XZR, WZR, W17, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, WZR, W17");
        TestInst(SMADDL(X0, W1, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W1, WZR");
        TestInst(SMADDL(X15, W1, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W1, WZR");
        TestInst(SMADDL(XZR, W1, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W1, WZR");
        TestInst(SMADDL(X0, W16, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, W16, WZR");
        TestInst(SMADDL(X15, W16, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, W16, WZR");
        TestInst(SMADDL(XZR, W16, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, W16, WZR");
        TestInst(SMADDL(X0, WZR, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X0, WZR, WZR");
        TestInst(SMADDL(X15, WZR, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL X15, WZR, WZR");
        TestInst(SMADDL(XZR, WZR, WZR, XZR), Arm64InstructionId.SMULL_smaddl_64wa_dp_3src, Arm64Mnemonic.SMULL, "SMULL XZR, WZR, WZR");
    }
}
