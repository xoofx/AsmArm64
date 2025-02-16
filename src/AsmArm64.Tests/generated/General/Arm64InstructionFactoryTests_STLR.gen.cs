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
public class Arm64InstructionFactoryTests_STLR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLR_sl32_ldstord_0()
    {
        TestInst(STLR(W0, _[X2]), asm => asm.STLR(W0, _[X2]), Arm64InstructionId.STLR_sl32_ldstord, Arm64Mnemonic.STLR, "STLR W0, [X2]");
        TestInst(STLR(W15, _[X2]), asm => asm.STLR(W15, _[X2]), Arm64InstructionId.STLR_sl32_ldstord, Arm64Mnemonic.STLR, "STLR W15, [X2]");
        TestInst(STLR(WZR, _[X2]), asm => asm.STLR(WZR, _[X2]), Arm64InstructionId.STLR_sl32_ldstord, Arm64Mnemonic.STLR, "STLR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLR_sl64_ldstord_1()
    {
        TestInst(STLR(X0, _[X2]), asm => asm.STLR(X0, _[X2]), Arm64InstructionId.STLR_sl64_ldstord, Arm64Mnemonic.STLR, "STLR X0, [X2]");
        TestInst(STLR(X15, _[X2]), asm => asm.STLR(X15, _[X2]), Arm64InstructionId.STLR_sl64_ldstord, Arm64Mnemonic.STLR, "STLR X15, [X2]");
        TestInst(STLR(XZR, _[X2]), asm => asm.STLR(XZR, _[X2]), Arm64InstructionId.STLR_sl64_ldstord, Arm64Mnemonic.STLR, "STLR XZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLR_32s_ldapstl_writeback_2()
    {
        TestInst(STLR(W0, _[X2, -4].Pre), asm => asm.STLR(W0, _[X2, -4].Pre), Arm64InstructionId.STLR_32s_ldapstl_writeback, Arm64Mnemonic.STLR, "STLR W0, [X2, #-4]!");
        TestInst(STLR(W15, _[X2, -4].Pre), asm => asm.STLR(W15, _[X2, -4].Pre), Arm64InstructionId.STLR_32s_ldapstl_writeback, Arm64Mnemonic.STLR, "STLR W15, [X2, #-4]!");
        TestInst(STLR(WZR, _[X2, -4].Pre), asm => asm.STLR(WZR, _[X2, -4].Pre), Arm64InstructionId.STLR_32s_ldapstl_writeback, Arm64Mnemonic.STLR, "STLR WZR, [X2, #-4]!");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLR_64s_ldapstl_writeback_3()
    {
        TestInst(STLR(X0, _[X2, -8].Pre), asm => asm.STLR(X0, _[X2, -8].Pre), Arm64InstructionId.STLR_64s_ldapstl_writeback, Arm64Mnemonic.STLR, "STLR X0, [X2, #-8]!");
        TestInst(STLR(X15, _[X2, -8].Pre), asm => asm.STLR(X15, _[X2, -8].Pre), Arm64InstructionId.STLR_64s_ldapstl_writeback, Arm64Mnemonic.STLR, "STLR X15, [X2, #-8]!");
        TestInst(STLR(XZR, _[X2, -8].Pre), asm => asm.STLR(XZR, _[X2, -8].Pre), Arm64InstructionId.STLR_64s_ldapstl_writeback, Arm64Mnemonic.STLR, "STLR XZR, [X2, #-8]!");
    }
}
