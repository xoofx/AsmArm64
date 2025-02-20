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
public class Arm64InstructionFactoryTests_LDAPR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPR_32l_ldapstl_writeback_0()
    {
        TestInst(LDAPR(W0, _[X2], 4), asm => asm.LDAPR(W0, _[X2], 4), Arm64InstructionId.LDAPR_32l_ldapstl_writeback, Arm64Mnemonic.LDAPR, "LDAPR W0, [X2], #4");
        TestInst(LDAPR(W15, _[X2], 4), asm => asm.LDAPR(W15, _[X2], 4), Arm64InstructionId.LDAPR_32l_ldapstl_writeback, Arm64Mnemonic.LDAPR, "LDAPR W15, [X2], #4");
        TestInst(LDAPR(WZR, _[X2], 4), asm => asm.LDAPR(WZR, _[X2], 4), Arm64InstructionId.LDAPR_32l_ldapstl_writeback, Arm64Mnemonic.LDAPR, "LDAPR WZR, [X2], #4");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPR_64l_ldapstl_writeback_1()
    {
        TestInst(LDAPR(X0, _[X2], 8), asm => asm.LDAPR(X0, _[X2], 8), Arm64InstructionId.LDAPR_64l_ldapstl_writeback, Arm64Mnemonic.LDAPR, "LDAPR X0, [X2], #8");
        TestInst(LDAPR(X15, _[X2], 8), asm => asm.LDAPR(X15, _[X2], 8), Arm64InstructionId.LDAPR_64l_ldapstl_writeback, Arm64Mnemonic.LDAPR, "LDAPR X15, [X2], #8");
        TestInst(LDAPR(XZR, _[X2], 8), asm => asm.LDAPR(XZR, _[X2], 8), Arm64InstructionId.LDAPR_64l_ldapstl_writeback, Arm64Mnemonic.LDAPR, "LDAPR XZR, [X2], #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPR_32l_memop_2()
    {
        TestInst(LDAPR(W0, _[X2]), asm => asm.LDAPR(W0, _[X2]), Arm64InstructionId.LDAPR_32l_memop, Arm64Mnemonic.LDAPR, "LDAPR W0, [X2]");
        TestInst(LDAPR(W15, _[X2]), asm => asm.LDAPR(W15, _[X2]), Arm64InstructionId.LDAPR_32l_memop, Arm64Mnemonic.LDAPR, "LDAPR W15, [X2]");
        TestInst(LDAPR(WZR, _[X2]), asm => asm.LDAPR(WZR, _[X2]), Arm64InstructionId.LDAPR_32l_memop, Arm64Mnemonic.LDAPR, "LDAPR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPR"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPR_64l_memop_3()
    {
        TestInst(LDAPR(X0, _[X2]), asm => asm.LDAPR(X0, _[X2]), Arm64InstructionId.LDAPR_64l_memop, Arm64Mnemonic.LDAPR, "LDAPR X0, [X2]");
        TestInst(LDAPR(X15, _[X2]), asm => asm.LDAPR(X15, _[X2]), Arm64InstructionId.LDAPR_64l_memop, Arm64Mnemonic.LDAPR, "LDAPR X15, [X2]");
        TestInst(LDAPR(XZR, _[X2]), asm => asm.LDAPR(XZR, _[X2]), Arm64InstructionId.LDAPR_64l_memop, Arm64Mnemonic.LDAPR, "LDAPR XZR, [X2]");
    }
}
