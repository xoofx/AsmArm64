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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_REV_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV_32_dp_1src_0()
    {
        TestInst(REV(W0, W1), asm => asm.REV(W0, W1), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV W0, W1");
        TestInst(REV(W15, W1), asm => asm.REV(W15, W1), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV W15, W1");
        TestInst(REV(WZR, W1), asm => asm.REV(WZR, W1), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV WZR, W1");
        TestInst(REV(W0, W16), asm => asm.REV(W0, W16), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV W0, W16");
        TestInst(REV(W15, W16), asm => asm.REV(W15, W16), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV W15, W16");
        TestInst(REV(WZR, W16), asm => asm.REV(WZR, W16), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV WZR, W16");
        TestInst(REV(W0, WZR), asm => asm.REV(W0, WZR), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV W0, WZR");
        TestInst(REV(W15, WZR), asm => asm.REV(W15, WZR), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV W15, WZR");
        TestInst(REV(WZR, WZR), asm => asm.REV(WZR, WZR), Arm64InstructionId.REV_32_dp_1src, Arm64Mnemonic.REV, "REV WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.REV"/>.
    /// </summary>
    [TestMethod]
    public void Test_REV_64_dp_1src_1()
    {
        TestInst(REV(X0, X1), asm => asm.REV(X0, X1), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X0, X1");
        TestInst(REV(X15, X1), asm => asm.REV(X15, X1), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X15, X1");
        TestInst(REV(XZR, X1), asm => asm.REV(XZR, X1), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV XZR, X1");
        TestInst(REV(X0, X16), asm => asm.REV(X0, X16), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X0, X16");
        TestInst(REV(X15, X16), asm => asm.REV(X15, X16), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X15, X16");
        TestInst(REV(XZR, X16), asm => asm.REV(XZR, X16), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV XZR, X16");
        TestInst(REV(X0, XZR), asm => asm.REV(X0, XZR), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X0, XZR");
        TestInst(REV(X15, XZR), asm => asm.REV(X15, XZR), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV X15, XZR");
        TestInst(REV(XZR, XZR), asm => asm.REV(XZR, XZR), Arm64InstructionId.REV_64_dp_1src, Arm64Mnemonic.REV, "REV XZR, XZR");
    }
}
