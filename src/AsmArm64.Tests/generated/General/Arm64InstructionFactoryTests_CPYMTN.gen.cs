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
public class Arm64InstructionFactoryTests_CPYMTN_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CPYMTN"/>.
    /// </summary>
    [TestMethod]
    public void Test_CPYMTN_cpy_memcms_0()
    {
        TestInst(CPYMTN(_[X1].Pre, _[X2].Pre, X2), asm => asm.CPYMTN(_[X1].Pre, _[X2].Pre, X2), Arm64InstructionId.CPYMTN_cpy_memcms, Arm64Mnemonic.CPYMTN, "CPYMTN [X1]!, [X2]!, X2");
        TestInst(CPYMTN(_[X1].Pre, _[X2].Pre, X17), asm => asm.CPYMTN(_[X1].Pre, _[X2].Pre, X17), Arm64InstructionId.CPYMTN_cpy_memcms, Arm64Mnemonic.CPYMTN, "CPYMTN [X1]!, [X2]!, X17");
        TestInst(CPYMTN(_[X1].Pre, _[X2].Pre, XZR), asm => asm.CPYMTN(_[X1].Pre, _[X2].Pre, XZR), Arm64InstructionId.CPYMTN_cpy_memcms, Arm64Mnemonic.CPYMTN, "CPYMTN [X1]!, [X2]!, XZR");
    }
}
