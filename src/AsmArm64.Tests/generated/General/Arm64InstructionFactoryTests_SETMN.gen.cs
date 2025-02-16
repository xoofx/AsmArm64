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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_SETMN_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SETMN"/>.
    /// </summary>
    [TestMethod]
    public void Test_SETMN_set_memcms_0()
    {
        TestInst(SETMN(_[X1].Pre, X1, X2), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, X1, X2");
        TestInst(SETMN(_[X1].Pre, X16, X2), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, X16, X2");
        TestInst(SETMN(_[X1].Pre, XZR, X2), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, XZR, X2");
        TestInst(SETMN(_[X1].Pre, X1, X17), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, X1, X17");
        TestInst(SETMN(_[X1].Pre, X16, X17), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, X16, X17");
        TestInst(SETMN(_[X1].Pre, XZR, X17), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, XZR, X17");
        TestInst(SETMN(_[X1].Pre, X1, XZR), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, X1, XZR");
        TestInst(SETMN(_[X1].Pre, X16, XZR), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, X16, XZR");
        TestInst(SETMN(_[X1].Pre, XZR, XZR), Arm64InstructionId.SETMN_set_memcms, Arm64Mnemonic.SETMN, "SETMN [X1]!, XZR, XZR");
    }
}
