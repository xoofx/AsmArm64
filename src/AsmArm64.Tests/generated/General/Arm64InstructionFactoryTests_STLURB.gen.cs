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
public class Arm64InstructionFactoryTests_STLURB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLURB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLURB_32_ldapstl_unscaled_0()
    {
        TestInst(STLURB(W0, _[X2, 5]), asm => asm.STLURB(W0, _[X2, 5]), Arm64InstructionId.STLURB_32_ldapstl_unscaled, Arm64Mnemonic.STLURB, "STLURB W0, [X2, #5]");
        TestInst(STLURB(W15, _[X2, 5]), asm => asm.STLURB(W15, _[X2, 5]), Arm64InstructionId.STLURB_32_ldapstl_unscaled, Arm64Mnemonic.STLURB, "STLURB W15, [X2, #5]");
        TestInst(STLURB(WZR, _[X2, 5]), asm => asm.STLURB(WZR, _[X2, 5]), Arm64InstructionId.STLURB_32_ldapstl_unscaled, Arm64Mnemonic.STLURB, "STLURB WZR, [X2, #5]");
    }
}
