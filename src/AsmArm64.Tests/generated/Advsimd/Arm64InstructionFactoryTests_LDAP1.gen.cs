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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_LDAP1_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDAP1"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDAP1_asisdlso_d1_0()
    {
        TestInst(LDAP1(V0.D.Group1()[1], _[X2]), asm => asm.LDAP1(V0.D.Group1()[1], _[X2]), Arm64InstructionId.LDAP1_asisdlso_d1, Arm64Mnemonic.LDAP1, "LDAP1 { V0.D }[1], [X2]");
        TestInst(LDAP1(V30.D.Group1()[1], _[X2]), asm => asm.LDAP1(V30.D.Group1()[1], _[X2]), Arm64InstructionId.LDAP1_asisdlso_d1, Arm64Mnemonic.LDAP1, "LDAP1 { V30.D }[1], [X2]");
    }
}
