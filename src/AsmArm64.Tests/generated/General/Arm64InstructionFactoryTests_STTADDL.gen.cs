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
public class Arm64InstructionFactoryTests_STTADDL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTADDL_ldtaddl_32_memop_unpriv_0()
    {
        TestInst(STTADDL(W0, _[X2]), asm => asm.STTADDL(W0, _[X2]), Arm64InstructionId.STTADDL_ldtaddl_32_memop_unpriv, Arm64Mnemonic.STTADDL, "STTADDL W0, [X2]");
        TestInst(STTADDL(W15, _[X2]), asm => asm.STTADDL(W15, _[X2]), Arm64InstructionId.STTADDL_ldtaddl_32_memop_unpriv, Arm64Mnemonic.STTADDL, "STTADDL W15, [X2]");
        TestInst(STTADDL(WZR, _[X2]), asm => asm.STTADDL(WZR, _[X2]), Arm64InstructionId.STTADDL_ldtaddl_32_memop_unpriv, Arm64Mnemonic.STTADDL, "STTADDL WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTADDL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTADDL_ldtaddl_64_memop_unpriv_1()
    {
        TestInst(STTADDL(X0, _[X2]), asm => asm.STTADDL(X0, _[X2]), Arm64InstructionId.STTADDL_ldtaddl_64_memop_unpriv, Arm64Mnemonic.STTADDL, "STTADDL X0, [X2]");
        TestInst(STTADDL(X15, _[X2]), asm => asm.STTADDL(X15, _[X2]), Arm64InstructionId.STTADDL_ldtaddl_64_memop_unpriv, Arm64Mnemonic.STTADDL, "STTADDL X15, [X2]");
        TestInst(STTADDL(XZR, _[X2]), asm => asm.STTADDL(XZR, _[X2]), Arm64InstructionId.STTADDL_ldtaddl_64_memop_unpriv, Arm64Mnemonic.STTADDL, "STTADDL XZR, [X2]");
    }
}
