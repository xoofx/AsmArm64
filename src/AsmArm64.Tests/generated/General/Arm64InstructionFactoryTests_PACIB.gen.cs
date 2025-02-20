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
public class Arm64InstructionFactoryTests_PACIB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACIB"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACIB_64p_dp_1src_0()
    {
        TestInst(PACIB(X0, X2), asm => asm.PACIB(X0, X2), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB X0, X2");
        TestInst(PACIB(X15, X2), asm => asm.PACIB(X15, X2), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB X15, X2");
        TestInst(PACIB(XZR, X2), asm => asm.PACIB(XZR, X2), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB XZR, X2");
        TestInst(PACIB(X0, X18), asm => asm.PACIB(X0, X18), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB X0, X18");
        TestInst(PACIB(X15, X18), asm => asm.PACIB(X15, X18), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB X15, X18");
        TestInst(PACIB(XZR, X18), asm => asm.PACIB(XZR, X18), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB XZR, X18");
        TestInst(PACIB(X0, SP), asm => asm.PACIB(X0, SP), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB X0, SP");
        TestInst(PACIB(X15, SP), asm => asm.PACIB(X15, SP), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB X15, SP");
        TestInst(PACIB(XZR, SP), asm => asm.PACIB(XZR, SP), Arm64InstructionId.PACIB_64p_dp_1src, Arm64Mnemonic.PACIB, "PACIB XZR, SP");
    }
}
