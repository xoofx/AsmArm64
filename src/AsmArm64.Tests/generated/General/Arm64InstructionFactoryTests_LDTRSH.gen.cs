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
public class Arm64InstructionFactoryTests_LDTRSH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTRSH_32_ldst_unpriv_0()
    {
        TestInst(LDTRSH(W0, _[X2, 5]), asm => asm.LDTRSH(W0, _[X2, 5]), Arm64InstructionId.LDTRSH_32_ldst_unpriv, Arm64Mnemonic.LDTRSH, "LDTRSH W0, [X2, #5]");
        TestInst(LDTRSH(W15, _[X2, 5]), asm => asm.LDTRSH(W15, _[X2, 5]), Arm64InstructionId.LDTRSH_32_ldst_unpriv, Arm64Mnemonic.LDTRSH, "LDTRSH W15, [X2, #5]");
        TestInst(LDTRSH(WZR, _[X2, 5]), asm => asm.LDTRSH(WZR, _[X2, 5]), Arm64InstructionId.LDTRSH_32_ldst_unpriv, Arm64Mnemonic.LDTRSH, "LDTRSH WZR, [X2, #5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDTRSH"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDTRSH_64_ldst_unpriv_1()
    {
        TestInst(LDTRSH(X0, _[X2, 5]), asm => asm.LDTRSH(X0, _[X2, 5]), Arm64InstructionId.LDTRSH_64_ldst_unpriv, Arm64Mnemonic.LDTRSH, "LDTRSH X0, [X2, #5]");
        TestInst(LDTRSH(X15, _[X2, 5]), asm => asm.LDTRSH(X15, _[X2, 5]), Arm64InstructionId.LDTRSH_64_ldst_unpriv, Arm64Mnemonic.LDTRSH, "LDTRSH X15, [X2, #5]");
        TestInst(LDTRSH(XZR, _[X2, 5]), asm => asm.LDTRSH(XZR, _[X2, 5]), Arm64InstructionId.LDTRSH_64_ldst_unpriv, Arm64Mnemonic.LDTRSH, "LDTRSH XZR, [X2, #5]");
    }
}
