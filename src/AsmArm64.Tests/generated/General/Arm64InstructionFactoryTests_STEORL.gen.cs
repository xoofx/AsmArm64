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
public class Arm64InstructionFactoryTests_STEORL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STEORL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STEORL_ldeorl_32_memop_0()
    {
        TestInst(STEORL(W0, _[X2]), asm => asm.STEORL(W0, _[X2]), Arm64InstructionId.STEORL_ldeorl_32_memop, Arm64Mnemonic.STEORL, "STEORL W0, [X2]");
        TestInst(STEORL(W15, _[X2]), asm => asm.STEORL(W15, _[X2]), Arm64InstructionId.STEORL_ldeorl_32_memop, Arm64Mnemonic.STEORL, "STEORL W15, [X2]");
        TestInst(STEORL(WZR, _[X2]), asm => asm.STEORL(WZR, _[X2]), Arm64InstructionId.STEORL_ldeorl_32_memop, Arm64Mnemonic.STEORL, "STEORL WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STEORL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STEORL_ldeorl_64_memop_1()
    {
        TestInst(STEORL(X0, _[X2]), asm => asm.STEORL(X0, _[X2]), Arm64InstructionId.STEORL_ldeorl_64_memop, Arm64Mnemonic.STEORL, "STEORL X0, [X2]");
        TestInst(STEORL(X15, _[X2]), asm => asm.STEORL(X15, _[X2]), Arm64InstructionId.STEORL_ldeorl_64_memop, Arm64Mnemonic.STEORL, "STEORL X15, [X2]");
        TestInst(STEORL(XZR, _[X2]), asm => asm.STEORL(XZR, _[X2]), Arm64InstructionId.STEORL_ldeorl_64_memop, Arm64Mnemonic.STEORL, "STEORL XZR, [X2]");
    }
}
