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
public class Arm64InstructionFactoryTests_ASRV_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ASRV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ASRV_32_dp_2src_0()
    {
        TestInst(ASRV(W0, W1, W2), asm => asm.ASRV(W0, W1, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, W1, W2");
        TestInst(ASRV(W15, W1, W2), asm => asm.ASRV(W15, W1, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, W1, W2");
        TestInst(ASRV(WZR, W1, W2), asm => asm.ASRV(WZR, W1, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, W1, W2");
        TestInst(ASRV(W0, W16, W2), asm => asm.ASRV(W0, W16, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, W16, W2");
        TestInst(ASRV(W15, W16, W2), asm => asm.ASRV(W15, W16, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, W16, W2");
        TestInst(ASRV(WZR, W16, W2), asm => asm.ASRV(WZR, W16, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, W16, W2");
        TestInst(ASRV(W0, WZR, W2), asm => asm.ASRV(W0, WZR, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, WZR, W2");
        TestInst(ASRV(W15, WZR, W2), asm => asm.ASRV(W15, WZR, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, WZR, W2");
        TestInst(ASRV(WZR, WZR, W2), asm => asm.ASRV(WZR, WZR, W2), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, WZR, W2");
        TestInst(ASRV(W0, W1, W17), asm => asm.ASRV(W0, W1, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, W1, W17");
        TestInst(ASRV(W15, W1, W17), asm => asm.ASRV(W15, W1, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, W1, W17");
        TestInst(ASRV(WZR, W1, W17), asm => asm.ASRV(WZR, W1, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, W1, W17");
        TestInst(ASRV(W0, W16, W17), asm => asm.ASRV(W0, W16, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, W16, W17");
        TestInst(ASRV(W15, W16, W17), asm => asm.ASRV(W15, W16, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, W16, W17");
        TestInst(ASRV(WZR, W16, W17), asm => asm.ASRV(WZR, W16, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, W16, W17");
        TestInst(ASRV(W0, WZR, W17), asm => asm.ASRV(W0, WZR, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, WZR, W17");
        TestInst(ASRV(W15, WZR, W17), asm => asm.ASRV(W15, WZR, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, WZR, W17");
        TestInst(ASRV(WZR, WZR, W17), asm => asm.ASRV(WZR, WZR, W17), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, WZR, W17");
        TestInst(ASRV(W0, W1, WZR), asm => asm.ASRV(W0, W1, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, W1, WZR");
        TestInst(ASRV(W15, W1, WZR), asm => asm.ASRV(W15, W1, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, W1, WZR");
        TestInst(ASRV(WZR, W1, WZR), asm => asm.ASRV(WZR, W1, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, W1, WZR");
        TestInst(ASRV(W0, W16, WZR), asm => asm.ASRV(W0, W16, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, W16, WZR");
        TestInst(ASRV(W15, W16, WZR), asm => asm.ASRV(W15, W16, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, W16, WZR");
        TestInst(ASRV(WZR, W16, WZR), asm => asm.ASRV(WZR, W16, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, W16, WZR");
        TestInst(ASRV(W0, WZR, WZR), asm => asm.ASRV(W0, WZR, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W0, WZR, WZR");
        TestInst(ASRV(W15, WZR, WZR), asm => asm.ASRV(W15, WZR, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR W15, WZR, WZR");
        TestInst(ASRV(WZR, WZR, WZR), asm => asm.ASRV(WZR, WZR, WZR), Arm64InstructionId.ASR_asrv_32_dp_2src, Arm64Mnemonic.ASR, "ASR WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ASRV"/>.
    /// </summary>
    [TestMethod]
    public void Test_ASRV_64_dp_2src_1()
    {
        TestInst(ASRV(X0, X1, X2), asm => asm.ASRV(X0, X1, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, X1, X2");
        TestInst(ASRV(X15, X1, X2), asm => asm.ASRV(X15, X1, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, X1, X2");
        TestInst(ASRV(XZR, X1, X2), asm => asm.ASRV(XZR, X1, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, X1, X2");
        TestInst(ASRV(X0, X16, X2), asm => asm.ASRV(X0, X16, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, X16, X2");
        TestInst(ASRV(X15, X16, X2), asm => asm.ASRV(X15, X16, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, X16, X2");
        TestInst(ASRV(XZR, X16, X2), asm => asm.ASRV(XZR, X16, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, X16, X2");
        TestInst(ASRV(X0, XZR, X2), asm => asm.ASRV(X0, XZR, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, XZR, X2");
        TestInst(ASRV(X15, XZR, X2), asm => asm.ASRV(X15, XZR, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, XZR, X2");
        TestInst(ASRV(XZR, XZR, X2), asm => asm.ASRV(XZR, XZR, X2), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, XZR, X2");
        TestInst(ASRV(X0, X1, X17), asm => asm.ASRV(X0, X1, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, X1, X17");
        TestInst(ASRV(X15, X1, X17), asm => asm.ASRV(X15, X1, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, X1, X17");
        TestInst(ASRV(XZR, X1, X17), asm => asm.ASRV(XZR, X1, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, X1, X17");
        TestInst(ASRV(X0, X16, X17), asm => asm.ASRV(X0, X16, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, X16, X17");
        TestInst(ASRV(X15, X16, X17), asm => asm.ASRV(X15, X16, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, X16, X17");
        TestInst(ASRV(XZR, X16, X17), asm => asm.ASRV(XZR, X16, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, X16, X17");
        TestInst(ASRV(X0, XZR, X17), asm => asm.ASRV(X0, XZR, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, XZR, X17");
        TestInst(ASRV(X15, XZR, X17), asm => asm.ASRV(X15, XZR, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, XZR, X17");
        TestInst(ASRV(XZR, XZR, X17), asm => asm.ASRV(XZR, XZR, X17), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, XZR, X17");
        TestInst(ASRV(X0, X1, XZR), asm => asm.ASRV(X0, X1, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, X1, XZR");
        TestInst(ASRV(X15, X1, XZR), asm => asm.ASRV(X15, X1, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, X1, XZR");
        TestInst(ASRV(XZR, X1, XZR), asm => asm.ASRV(XZR, X1, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, X1, XZR");
        TestInst(ASRV(X0, X16, XZR), asm => asm.ASRV(X0, X16, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, X16, XZR");
        TestInst(ASRV(X15, X16, XZR), asm => asm.ASRV(X15, X16, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, X16, XZR");
        TestInst(ASRV(XZR, X16, XZR), asm => asm.ASRV(XZR, X16, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, X16, XZR");
        TestInst(ASRV(X0, XZR, XZR), asm => asm.ASRV(X0, XZR, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X0, XZR, XZR");
        TestInst(ASRV(X15, XZR, XZR), asm => asm.ASRV(X15, XZR, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR X15, XZR, XZR");
        TestInst(ASRV(XZR, XZR, XZR), asm => asm.ASRV(XZR, XZR, XZR), Arm64InstructionId.ASR_asrv_64_dp_2src, Arm64Mnemonic.ASR, "ASR XZR, XZR, XZR");
    }
}
