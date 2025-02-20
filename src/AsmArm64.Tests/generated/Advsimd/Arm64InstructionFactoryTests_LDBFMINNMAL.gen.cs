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
public class Arm64InstructionFactoryTests_LDBFMINNMAL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDBFMINNMAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDBFMINNMAL_16_0()
    {
        TestInst(LDBFMINNMAL(H0, H1, _[X3]), asm => asm.LDBFMINNMAL(H0, H1, _[X3]), Arm64InstructionId.LDBFMINNMAL_16, Arm64Mnemonic.LDBFMINNMAL, "LDBFMINNMAL H0, H1, [X3]");
        TestInst(LDBFMINNMAL(H31, H1, _[X3]), asm => asm.LDBFMINNMAL(H31, H1, _[X3]), Arm64InstructionId.LDBFMINNMAL_16, Arm64Mnemonic.LDBFMINNMAL, "LDBFMINNMAL H31, H1, [X3]");
        TestInst(LDBFMINNMAL(H0, H31, _[X3]), asm => asm.LDBFMINNMAL(H0, H31, _[X3]), Arm64InstructionId.LDBFMINNMAL_16, Arm64Mnemonic.LDBFMINNMAL, "LDBFMINNMAL H0, H31, [X3]");
        TestInst(LDBFMINNMAL(H31, H31, _[X3]), asm => asm.LDBFMINNMAL(H31, H31, _[X3]), Arm64InstructionId.LDBFMINNMAL_16, Arm64Mnemonic.LDBFMINNMAL, "LDBFMINNMAL H31, H31, [X3]");
    }
}
