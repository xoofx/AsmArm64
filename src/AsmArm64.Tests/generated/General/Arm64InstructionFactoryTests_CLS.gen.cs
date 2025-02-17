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
public class Arm64InstructionFactoryTests_CLS_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CLS_32_dp_1src_0()
    {
        TestInst(CLS(W0, W1), asm => asm.CLS(W0, W1), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS W0, W1");
        TestInst(CLS(W15, W1), asm => asm.CLS(W15, W1), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS W15, W1");
        TestInst(CLS(WZR, W1), asm => asm.CLS(WZR, W1), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS WZR, W1");
        TestInst(CLS(W0, W16), asm => asm.CLS(W0, W16), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS W0, W16");
        TestInst(CLS(W15, W16), asm => asm.CLS(W15, W16), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS W15, W16");
        TestInst(CLS(WZR, W16), asm => asm.CLS(WZR, W16), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS WZR, W16");
        TestInst(CLS(W0, WZR), asm => asm.CLS(W0, WZR), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS W0, WZR");
        TestInst(CLS(W15, WZR), asm => asm.CLS(W15, WZR), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS W15, WZR");
        TestInst(CLS(WZR, WZR), asm => asm.CLS(WZR, WZR), Arm64InstructionId.CLS_32_dp_1src, Arm64Mnemonic.CLS, "CLS WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CLS"/>.
    /// </summary>
    [TestMethod]
    public void Test_CLS_64_dp_1src_1()
    {
        TestInst(CLS(X0, X1), asm => asm.CLS(X0, X1), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS X0, X1");
        TestInst(CLS(X15, X1), asm => asm.CLS(X15, X1), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS X15, X1");
        TestInst(CLS(XZR, X1), asm => asm.CLS(XZR, X1), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS XZR, X1");
        TestInst(CLS(X0, X16), asm => asm.CLS(X0, X16), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS X0, X16");
        TestInst(CLS(X15, X16), asm => asm.CLS(X15, X16), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS X15, X16");
        TestInst(CLS(XZR, X16), asm => asm.CLS(XZR, X16), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS XZR, X16");
        TestInst(CLS(X0, XZR), asm => asm.CLS(X0, XZR), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS X0, XZR");
        TestInst(CLS(X15, XZR), asm => asm.CLS(X15, XZR), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS X15, XZR");
        TestInst(CLS(XZR, XZR), asm => asm.CLS(XZR, XZR), Arm64InstructionId.CLS_64_dp_1src, Arm64Mnemonic.CLS, "CLS XZR, XZR");
    }
}
