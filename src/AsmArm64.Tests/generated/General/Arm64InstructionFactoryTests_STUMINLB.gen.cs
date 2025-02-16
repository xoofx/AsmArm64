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
public class Arm64InstructionFactoryTests_STUMINLB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STUMINLB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STUMINLB_lduminlb_32_memop_0()
    {
        TestInst(STUMINLB(W0, _[X2]), asm => asm.STUMINLB(W0, _[X2]), Arm64InstructionId.STUMINLB_lduminlb_32_memop, Arm64Mnemonic.STUMINLB, "STUMINLB W0, [X2]");
        TestInst(STUMINLB(W15, _[X2]), asm => asm.STUMINLB(W15, _[X2]), Arm64InstructionId.STUMINLB_lduminlb_32_memop, Arm64Mnemonic.STUMINLB, "STUMINLB W15, [X2]");
        TestInst(STUMINLB(WZR, _[X2]), asm => asm.STUMINLB(WZR, _[X2]), Arm64InstructionId.STUMINLB_lduminlb_32_memop, Arm64Mnemonic.STUMINLB, "STUMINLB WZR, [X2]");
    }
}
