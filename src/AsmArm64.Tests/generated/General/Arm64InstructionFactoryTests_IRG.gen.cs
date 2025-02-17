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
public class Arm64InstructionFactoryTests_IRG_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.IRG"/>.
    /// </summary>
    [TestMethod]
    public void Test_IRG_64i_dp_2src_0()
    {
        TestInst(IRG(X1, X2, X2), asm => asm.IRG(X1, X2, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X1, X2, X2");
        TestInst(IRG(X17, X2, X2), asm => asm.IRG(X17, X2, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X17, X2, X2");
        TestInst(IRG(SP, X2, X2), asm => asm.IRG(SP, X2, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG SP, X2, X2");
        TestInst(IRG(X1, X18, X2), asm => asm.IRG(X1, X18, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X1, X18, X2");
        TestInst(IRG(X17, X18, X2), asm => asm.IRG(X17, X18, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X17, X18, X2");
        TestInst(IRG(SP, X18, X2), asm => asm.IRG(SP, X18, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG SP, X18, X2");
        TestInst(IRG(X1, SP, X2), asm => asm.IRG(X1, SP, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X1, SP, X2");
        TestInst(IRG(X17, SP, X2), asm => asm.IRG(X17, SP, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X17, SP, X2");
        TestInst(IRG(SP, SP, X2), asm => asm.IRG(SP, SP, X2), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG SP, SP, X2");
        TestInst(IRG(X1, X2, X17), asm => asm.IRG(X1, X2, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X1, X2, X17");
        TestInst(IRG(X17, X2, X17), asm => asm.IRG(X17, X2, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X17, X2, X17");
        TestInst(IRG(SP, X2, X17), asm => asm.IRG(SP, X2, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG SP, X2, X17");
        TestInst(IRG(X1, X18, X17), asm => asm.IRG(X1, X18, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X1, X18, X17");
        TestInst(IRG(X17, X18, X17), asm => asm.IRG(X17, X18, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X17, X18, X17");
        TestInst(IRG(SP, X18, X17), asm => asm.IRG(SP, X18, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG SP, X18, X17");
        TestInst(IRG(X1, SP, X17), asm => asm.IRG(X1, SP, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X1, SP, X17");
        TestInst(IRG(X17, SP, X17), asm => asm.IRG(X17, SP, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG X17, SP, X17");
        TestInst(IRG(SP, SP, X17), asm => asm.IRG(SP, SP, X17), Arm64InstructionId.IRG_64i_dp_2src, Arm64Mnemonic.IRG, "IRG SP, SP, X17");
    }
}
