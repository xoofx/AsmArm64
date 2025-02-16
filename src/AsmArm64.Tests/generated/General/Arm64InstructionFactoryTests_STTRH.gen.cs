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
public class Arm64InstructionFactoryTests_STTRH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STTRH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STTRH_32_ldst_unpriv_0()
    {
        TestInst(STTRH(W0, _[X2, 5]), asm => asm.STTRH(W0, _[X2, 5]), Arm64InstructionId.STTRH_32_ldst_unpriv, Arm64Mnemonic.STTRH, "STTRH W0, [X2, #5]");
        TestInst(STTRH(W15, _[X2, 5]), asm => asm.STTRH(W15, _[X2, 5]), Arm64InstructionId.STTRH_32_ldst_unpriv, Arm64Mnemonic.STTRH, "STTRH W15, [X2, #5]");
        TestInst(STTRH(WZR, _[X2, 5]), asm => asm.STTRH(WZR, _[X2, 5]), Arm64InstructionId.STTRH_32_ldst_unpriv, Arm64Mnemonic.STTRH, "STTRH WZR, [X2, #5]");
    }
}
