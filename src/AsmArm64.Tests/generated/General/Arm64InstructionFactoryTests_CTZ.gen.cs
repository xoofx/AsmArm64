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
public class Arm64InstructionFactoryTests_CTZ_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CTZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_CTZ_32_dp_1src_0()
    {
        TestInst(CTZ(W0, W1), asm => asm.CTZ(W0, W1), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ W0, W1");
        TestInst(CTZ(W15, W1), asm => asm.CTZ(W15, W1), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ W15, W1");
        TestInst(CTZ(WZR, W1), asm => asm.CTZ(WZR, W1), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ WZR, W1");
        TestInst(CTZ(W0, W16), asm => asm.CTZ(W0, W16), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ W0, W16");
        TestInst(CTZ(W15, W16), asm => asm.CTZ(W15, W16), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ W15, W16");
        TestInst(CTZ(WZR, W16), asm => asm.CTZ(WZR, W16), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ WZR, W16");
        TestInst(CTZ(W0, WZR), asm => asm.CTZ(W0, WZR), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ W0, WZR");
        TestInst(CTZ(W15, WZR), asm => asm.CTZ(W15, WZR), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ W15, WZR");
        TestInst(CTZ(WZR, WZR), asm => asm.CTZ(WZR, WZR), Arm64InstructionId.CTZ_32_dp_1src, Arm64Mnemonic.CTZ, "CTZ WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CTZ"/>.
    /// </summary>
    [TestMethod]
    public void Test_CTZ_64_dp_1src_1()
    {
        TestInst(CTZ(X0, X1), asm => asm.CTZ(X0, X1), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ X0, X1");
        TestInst(CTZ(X15, X1), asm => asm.CTZ(X15, X1), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ X15, X1");
        TestInst(CTZ(XZR, X1), asm => asm.CTZ(XZR, X1), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ XZR, X1");
        TestInst(CTZ(X0, X16), asm => asm.CTZ(X0, X16), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ X0, X16");
        TestInst(CTZ(X15, X16), asm => asm.CTZ(X15, X16), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ X15, X16");
        TestInst(CTZ(XZR, X16), asm => asm.CTZ(XZR, X16), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ XZR, X16");
        TestInst(CTZ(X0, XZR), asm => asm.CTZ(X0, XZR), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ X0, XZR");
        TestInst(CTZ(X15, XZR), asm => asm.CTZ(X15, XZR), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ X15, XZR");
        TestInst(CTZ(XZR, XZR), asm => asm.CTZ(XZR, XZR), Arm64InstructionId.CTZ_64_dp_1src, Arm64Mnemonic.CTZ, "CTZ XZR, XZR");
    }
}
