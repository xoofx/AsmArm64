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
public class Arm64InstructionFactoryTests_CRC32CX_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CRC32CX"/>.
    /// </summary>
    [TestMethod]
    public void Test_CRC32CX_64c_dp_2src_0()
    {
        TestInst(CRC32CX(W0, W1, X2), asm => asm.CRC32CX(W0, W1, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, W1, X2");
        TestInst(CRC32CX(W15, W1, X2), asm => asm.CRC32CX(W15, W1, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, W1, X2");
        TestInst(CRC32CX(WZR, W1, X2), asm => asm.CRC32CX(WZR, W1, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, W1, X2");
        TestInst(CRC32CX(W0, W16, X2), asm => asm.CRC32CX(W0, W16, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, W16, X2");
        TestInst(CRC32CX(W15, W16, X2), asm => asm.CRC32CX(W15, W16, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, W16, X2");
        TestInst(CRC32CX(WZR, W16, X2), asm => asm.CRC32CX(WZR, W16, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, W16, X2");
        TestInst(CRC32CX(W0, WZR, X2), asm => asm.CRC32CX(W0, WZR, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, WZR, X2");
        TestInst(CRC32CX(W15, WZR, X2), asm => asm.CRC32CX(W15, WZR, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, WZR, X2");
        TestInst(CRC32CX(WZR, WZR, X2), asm => asm.CRC32CX(WZR, WZR, X2), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, WZR, X2");
        TestInst(CRC32CX(W0, W1, X17), asm => asm.CRC32CX(W0, W1, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, W1, X17");
        TestInst(CRC32CX(W15, W1, X17), asm => asm.CRC32CX(W15, W1, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, W1, X17");
        TestInst(CRC32CX(WZR, W1, X17), asm => asm.CRC32CX(WZR, W1, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, W1, X17");
        TestInst(CRC32CX(W0, W16, X17), asm => asm.CRC32CX(W0, W16, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, W16, X17");
        TestInst(CRC32CX(W15, W16, X17), asm => asm.CRC32CX(W15, W16, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, W16, X17");
        TestInst(CRC32CX(WZR, W16, X17), asm => asm.CRC32CX(WZR, W16, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, W16, X17");
        TestInst(CRC32CX(W0, WZR, X17), asm => asm.CRC32CX(W0, WZR, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, WZR, X17");
        TestInst(CRC32CX(W15, WZR, X17), asm => asm.CRC32CX(W15, WZR, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, WZR, X17");
        TestInst(CRC32CX(WZR, WZR, X17), asm => asm.CRC32CX(WZR, WZR, X17), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, WZR, X17");
        TestInst(CRC32CX(W0, W1, XZR), asm => asm.CRC32CX(W0, W1, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, W1, XZR");
        TestInst(CRC32CX(W15, W1, XZR), asm => asm.CRC32CX(W15, W1, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, W1, XZR");
        TestInst(CRC32CX(WZR, W1, XZR), asm => asm.CRC32CX(WZR, W1, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, W1, XZR");
        TestInst(CRC32CX(W0, W16, XZR), asm => asm.CRC32CX(W0, W16, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, W16, XZR");
        TestInst(CRC32CX(W15, W16, XZR), asm => asm.CRC32CX(W15, W16, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, W16, XZR");
        TestInst(CRC32CX(WZR, W16, XZR), asm => asm.CRC32CX(WZR, W16, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, W16, XZR");
        TestInst(CRC32CX(W0, WZR, XZR), asm => asm.CRC32CX(W0, WZR, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W0, WZR, XZR");
        TestInst(CRC32CX(W15, WZR, XZR), asm => asm.CRC32CX(W15, WZR, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX W15, WZR, XZR");
        TestInst(CRC32CX(WZR, WZR, XZR), asm => asm.CRC32CX(WZR, WZR, XZR), Arm64InstructionId.CRC32CX_64c_dp_2src, Arm64Mnemonic.CRC32CX, "CRC32CX WZR, WZR, XZR");
    }
}
