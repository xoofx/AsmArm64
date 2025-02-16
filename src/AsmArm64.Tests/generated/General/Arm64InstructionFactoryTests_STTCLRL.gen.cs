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
public class Arm64InstructionFactoryTests_STTCLRL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTCLRL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTCLRL_ldtclrl_32_memop_unpriv_0()
    {
        TestInst(STTCLRL(W0, _[X2]), asm => asm.STTCLRL(W0, _[X2]), Arm64InstructionId.STTCLRL_ldtclrl_32_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL W0, [X2]");
        TestInst(STTCLRL(W15, _[X2]), asm => asm.STTCLRL(W15, _[X2]), Arm64InstructionId.STTCLRL_ldtclrl_32_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL W15, [X2]");
        TestInst(STTCLRL(WZR, _[X2]), asm => asm.STTCLRL(WZR, _[X2]), Arm64InstructionId.STTCLRL_ldtclrl_32_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTCLRL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTCLRL_ldtclrl_64_memop_unpriv_1()
    {
        TestInst(STTCLRL(X0, _[X2]), asm => asm.STTCLRL(X0, _[X2]), Arm64InstructionId.STTCLRL_ldtclrl_64_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL X0, [X2]");
        TestInst(STTCLRL(X15, _[X2]), asm => asm.STTCLRL(X15, _[X2]), Arm64InstructionId.STTCLRL_ldtclrl_64_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL X15, [X2]");
        TestInst(STTCLRL(XZR, _[X2]), asm => asm.STTCLRL(XZR, _[X2]), Arm64InstructionId.STTCLRL_ldtclrl_64_memop_unpriv, Arm64Mnemonic.STTCLRL, "STTCLRL XZR, [X2]");
    }
}
