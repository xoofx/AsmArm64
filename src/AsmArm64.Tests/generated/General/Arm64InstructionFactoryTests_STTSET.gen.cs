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
public class Arm64InstructionFactoryTests_STTSET_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTSET"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTSET_ldtset_32_memop_unpriv_0()
    {
        TestInst(STTSET(W0, _[X2]), asm => asm.STTSET(W0, _[X2]), Arm64InstructionId.STTSET_ldtset_32_memop_unpriv, Arm64Mnemonic.STTSET, "STTSET W0, [X2]");
        TestInst(STTSET(W15, _[X2]), asm => asm.STTSET(W15, _[X2]), Arm64InstructionId.STTSET_ldtset_32_memop_unpriv, Arm64Mnemonic.STTSET, "STTSET W15, [X2]");
        TestInst(STTSET(WZR, _[X2]), asm => asm.STTSET(WZR, _[X2]), Arm64InstructionId.STTSET_ldtset_32_memop_unpriv, Arm64Mnemonic.STTSET, "STTSET WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTSET"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTSET_ldtset_64_memop_unpriv_1()
    {
        TestInst(STTSET(X0, _[X2]), asm => asm.STTSET(X0, _[X2]), Arm64InstructionId.STTSET_ldtset_64_memop_unpriv, Arm64Mnemonic.STTSET, "STTSET X0, [X2]");
        TestInst(STTSET(X15, _[X2]), asm => asm.STTSET(X15, _[X2]), Arm64InstructionId.STTSET_ldtset_64_memop_unpriv, Arm64Mnemonic.STTSET, "STTSET X15, [X2]");
        TestInst(STTSET(XZR, _[X2]), asm => asm.STTSET(XZR, _[X2]), Arm64InstructionId.STTSET_ldtset_64_memop_unpriv, Arm64Mnemonic.STTSET, "STTSET XZR, [X2]");
    }
}
