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
public class Arm64InstructionFactoryTests_STUMINL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STUMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STUMINL_lduminl_32_memop_0()
    {
        TestInst(STUMINL(W0, _[X2]), asm => asm.STUMINL(W0, _[X2]), Arm64InstructionId.STUMINL_lduminl_32_memop, Arm64Mnemonic.STUMINL, "STUMINL W0, [X2]");
        TestInst(STUMINL(W15, _[X2]), asm => asm.STUMINL(W15, _[X2]), Arm64InstructionId.STUMINL_lduminl_32_memop, Arm64Mnemonic.STUMINL, "STUMINL W15, [X2]");
        TestInst(STUMINL(WZR, _[X2]), asm => asm.STUMINL(WZR, _[X2]), Arm64InstructionId.STUMINL_lduminl_32_memop, Arm64Mnemonic.STUMINL, "STUMINL WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STUMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STUMINL_lduminl_64_memop_1()
    {
        TestInst(STUMINL(X0, _[X2]), asm => asm.STUMINL(X0, _[X2]), Arm64InstructionId.STUMINL_lduminl_64_memop, Arm64Mnemonic.STUMINL, "STUMINL X0, [X2]");
        TestInst(STUMINL(X15, _[X2]), asm => asm.STUMINL(X15, _[X2]), Arm64InstructionId.STUMINL_lduminl_64_memop, Arm64Mnemonic.STUMINL, "STUMINL X15, [X2]");
        TestInst(STUMINL(XZR, _[X2]), asm => asm.STUMINL(XZR, _[X2]), Arm64InstructionId.STUMINL_lduminl_64_memop, Arm64Mnemonic.STUMINL, "STUMINL XZR, [X2]");
    }
}
