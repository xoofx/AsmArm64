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
namespace AsmArm64.Tests.System;

[TestClass]
public class Arm64InstructionFactoryTests_SYS_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SYS"/>.
    /// </summary>
    [TestMethod]
    public void Test_SYS_cr_systeminstrs_0()
    {
        TestInst(SYS(5, C1, C2, 5, X4), asm => asm.SYS(5, C1, C2, 5, X4), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C1, C2, #5, X4");
        TestInst(SYS(5, C15, C2, 5, X4), asm => asm.SYS(5, C15, C2, 5, X4), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C15, C2, #5, X4");
        TestInst(SYS(5, C1, C15, 5, X4), asm => asm.SYS(5, C1, C15, 5, X4), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C1, C15, #5, X4");
        TestInst(SYS(5, C15, C15, 5, X4), asm => asm.SYS(5, C15, C15, 5, X4), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C15, C15, #5, X4");
        TestInst(SYS(5, C1, C2, 5, X19), asm => asm.SYS(5, C1, C2, 5, X19), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C1, C2, #5, X19");
        TestInst(SYS(5, C15, C2, 5, X19), asm => asm.SYS(5, C15, C2, 5, X19), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C15, C2, #5, X19");
        TestInst(SYS(5, C1, C15, 5, X19), asm => asm.SYS(5, C1, C15, 5, X19), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C1, C15, #5, X19");
        TestInst(SYS(5, C15, C15, 5, X19), asm => asm.SYS(5, C15, C15, 5, X19), Arm64InstructionId.SYS_cr_systeminstrs, Arm64Mnemonic.SYS, "SYS #5, C15, C15, #5, X19");
    }
}
