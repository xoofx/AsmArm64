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
public class Arm64InstructionFactoryTests_PACDA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACDA"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACDA_64p_dp_1src_0()
    {
        TestInst(PACDA(X0, X2), asm => asm.PACDA(X0, X2), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA X0, X2");
        TestInst(PACDA(X15, X2), asm => asm.PACDA(X15, X2), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA X15, X2");
        TestInst(PACDA(XZR, X2), asm => asm.PACDA(XZR, X2), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA XZR, X2");
        TestInst(PACDA(X0, X18), asm => asm.PACDA(X0, X18), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA X0, X18");
        TestInst(PACDA(X15, X18), asm => asm.PACDA(X15, X18), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA X15, X18");
        TestInst(PACDA(XZR, X18), asm => asm.PACDA(XZR, X18), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA XZR, X18");
        TestInst(PACDA(X0, SP), asm => asm.PACDA(X0, SP), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA X0, SP");
        TestInst(PACDA(X15, SP), asm => asm.PACDA(X15, SP), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA X15, SP");
        TestInst(PACDA(XZR, SP), asm => asm.PACDA(XZR, SP), Arm64InstructionId.PACDA_64p_dp_1src, Arm64Mnemonic.PACDA, "PACDA XZR, SP");
    }
}
