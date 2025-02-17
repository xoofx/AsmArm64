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
public class Arm64InstructionFactoryTests_CRC32W_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CRC32W"/>.
    /// </summary>
    [TestMethod]
    public void Test_CRC32W_32c_dp_2src_0()
    {
        TestInst(CRC32W(W0, W1, W2), asm => asm.CRC32W(W0, W1, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, W1, W2");
        TestInst(CRC32W(W15, W1, W2), asm => asm.CRC32W(W15, W1, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, W1, W2");
        TestInst(CRC32W(WZR, W1, W2), asm => asm.CRC32W(WZR, W1, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, W1, W2");
        TestInst(CRC32W(W0, W16, W2), asm => asm.CRC32W(W0, W16, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, W16, W2");
        TestInst(CRC32W(W15, W16, W2), asm => asm.CRC32W(W15, W16, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, W16, W2");
        TestInst(CRC32W(WZR, W16, W2), asm => asm.CRC32W(WZR, W16, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, W16, W2");
        TestInst(CRC32W(W0, WZR, W2), asm => asm.CRC32W(W0, WZR, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, WZR, W2");
        TestInst(CRC32W(W15, WZR, W2), asm => asm.CRC32W(W15, WZR, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, WZR, W2");
        TestInst(CRC32W(WZR, WZR, W2), asm => asm.CRC32W(WZR, WZR, W2), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, WZR, W2");
        TestInst(CRC32W(W0, W1, W17), asm => asm.CRC32W(W0, W1, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, W1, W17");
        TestInst(CRC32W(W15, W1, W17), asm => asm.CRC32W(W15, W1, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, W1, W17");
        TestInst(CRC32W(WZR, W1, W17), asm => asm.CRC32W(WZR, W1, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, W1, W17");
        TestInst(CRC32W(W0, W16, W17), asm => asm.CRC32W(W0, W16, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, W16, W17");
        TestInst(CRC32W(W15, W16, W17), asm => asm.CRC32W(W15, W16, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, W16, W17");
        TestInst(CRC32W(WZR, W16, W17), asm => asm.CRC32W(WZR, W16, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, W16, W17");
        TestInst(CRC32W(W0, WZR, W17), asm => asm.CRC32W(W0, WZR, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, WZR, W17");
        TestInst(CRC32W(W15, WZR, W17), asm => asm.CRC32W(W15, WZR, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, WZR, W17");
        TestInst(CRC32W(WZR, WZR, W17), asm => asm.CRC32W(WZR, WZR, W17), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, WZR, W17");
        TestInst(CRC32W(W0, W1, WZR), asm => asm.CRC32W(W0, W1, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, W1, WZR");
        TestInst(CRC32W(W15, W1, WZR), asm => asm.CRC32W(W15, W1, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, W1, WZR");
        TestInst(CRC32W(WZR, W1, WZR), asm => asm.CRC32W(WZR, W1, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, W1, WZR");
        TestInst(CRC32W(W0, W16, WZR), asm => asm.CRC32W(W0, W16, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, W16, WZR");
        TestInst(CRC32W(W15, W16, WZR), asm => asm.CRC32W(W15, W16, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, W16, WZR");
        TestInst(CRC32W(WZR, W16, WZR), asm => asm.CRC32W(WZR, W16, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, W16, WZR");
        TestInst(CRC32W(W0, WZR, WZR), asm => asm.CRC32W(W0, WZR, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W0, WZR, WZR");
        TestInst(CRC32W(W15, WZR, WZR), asm => asm.CRC32W(W15, WZR, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W W15, WZR, WZR");
        TestInst(CRC32W(WZR, WZR, WZR), asm => asm.CRC32W(WZR, WZR, WZR), Arm64InstructionId.CRC32W_32c_dp_2src, Arm64Mnemonic.CRC32W, "CRC32W WZR, WZR, WZR");
    }
}
