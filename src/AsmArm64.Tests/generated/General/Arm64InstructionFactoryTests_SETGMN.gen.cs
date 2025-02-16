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
public class Arm64InstructionFactoryTests_SETGMN_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SETGMN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SETGMN_set_memcms_0()
    {
        TestInst(SETGMN(_[X1].Pre, X1, X2), asm => asm.SETGMN(_[X1].Pre, X1, X2), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, X1, X2");
        TestInst(SETGMN(_[X1].Pre, X16, X2), asm => asm.SETGMN(_[X1].Pre, X16, X2), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, X16, X2");
        TestInst(SETGMN(_[X1].Pre, XZR, X2), asm => asm.SETGMN(_[X1].Pre, XZR, X2), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, XZR, X2");
        TestInst(SETGMN(_[X1].Pre, X1, X17), asm => asm.SETGMN(_[X1].Pre, X1, X17), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, X1, X17");
        TestInst(SETGMN(_[X1].Pre, X16, X17), asm => asm.SETGMN(_[X1].Pre, X16, X17), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, X16, X17");
        TestInst(SETGMN(_[X1].Pre, XZR, X17), asm => asm.SETGMN(_[X1].Pre, XZR, X17), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, XZR, X17");
        TestInst(SETGMN(_[X1].Pre, X1, XZR), asm => asm.SETGMN(_[X1].Pre, X1, XZR), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, X1, XZR");
        TestInst(SETGMN(_[X1].Pre, X16, XZR), asm => asm.SETGMN(_[X1].Pre, X16, XZR), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, X16, XZR");
        TestInst(SETGMN(_[X1].Pre, XZR, XZR), asm => asm.SETGMN(_[X1].Pre, XZR, XZR), Arm64InstructionId.SETGMN_set_memcms, Arm64Mnemonic.SETGMN, "SETGMN [X1]!, XZR, XZR");
    }
}
