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
public class Arm64InstructionFactoryTests_LDAPURSB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPURSB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPURSB_32_ldapstl_unscaled_0()
    {
        TestInst(LDAPURSB(W0, _[X2, 5]), asm => asm.LDAPURSB(W0, _[X2, 5]), Arm64InstructionId.LDAPURSB_32_ldapstl_unscaled, Arm64Mnemonic.LDAPURSB, "LDAPURSB W0, [X2, #5]");
        TestInst(LDAPURSB(W15, _[X2, 5]), asm => asm.LDAPURSB(W15, _[X2, 5]), Arm64InstructionId.LDAPURSB_32_ldapstl_unscaled, Arm64Mnemonic.LDAPURSB, "LDAPURSB W15, [X2, #5]");
        TestInst(LDAPURSB(WZR, _[X2, 5]), asm => asm.LDAPURSB(WZR, _[X2, 5]), Arm64InstructionId.LDAPURSB_32_ldapstl_unscaled, Arm64Mnemonic.LDAPURSB, "LDAPURSB WZR, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAPURSB"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAPURSB_64_ldapstl_unscaled_1()
    {
        TestInst(LDAPURSB(X0, _[X2, 5]), asm => asm.LDAPURSB(X0, _[X2, 5]), Arm64InstructionId.LDAPURSB_64_ldapstl_unscaled, Arm64Mnemonic.LDAPURSB, "LDAPURSB X0, [X2, #5]");
        TestInst(LDAPURSB(X15, _[X2, 5]), asm => asm.LDAPURSB(X15, _[X2, 5]), Arm64InstructionId.LDAPURSB_64_ldapstl_unscaled, Arm64Mnemonic.LDAPURSB, "LDAPURSB X15, [X2, #5]");
        TestInst(LDAPURSB(XZR, _[X2, 5]), asm => asm.LDAPURSB(XZR, _[X2, 5]), Arm64InstructionId.LDAPURSB_64_ldapstl_unscaled, Arm64Mnemonic.LDAPURSB, "LDAPURSB XZR, [X2, #5]");
    }
}
