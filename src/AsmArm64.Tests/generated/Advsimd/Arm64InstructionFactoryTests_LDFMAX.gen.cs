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
public class Arm64InstructionFactoryTests_LDFMAX_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAX_16_0()
    {
        TestInst(LDFMAX(H0, H1, _[X3]), asm => asm.LDFMAX(H0, H1, _[X3]), Arm64InstructionId.LDFMAX_16, Arm64Mnemonic.LDFMAX, "LDFMAX H0, H1, [X3]");
        TestInst(LDFMAX(H31, H1, _[X3]), asm => asm.LDFMAX(H31, H1, _[X3]), Arm64InstructionId.LDFMAX_16, Arm64Mnemonic.LDFMAX, "LDFMAX H31, H1, [X3]");
        TestInst(LDFMAX(H0, H31, _[X3]), asm => asm.LDFMAX(H0, H31, _[X3]), Arm64InstructionId.LDFMAX_16, Arm64Mnemonic.LDFMAX, "LDFMAX H0, H31, [X3]");
        TestInst(LDFMAX(H31, H31, _[X3]), asm => asm.LDFMAX(H31, H31, _[X3]), Arm64InstructionId.LDFMAX_16, Arm64Mnemonic.LDFMAX, "LDFMAX H31, H31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAX_32_1()
    {
        TestInst(LDFMAX(S0, S1, _[X3]), asm => asm.LDFMAX(S0, S1, _[X3]), Arm64InstructionId.LDFMAX_32, Arm64Mnemonic.LDFMAX, "LDFMAX S0, S1, [X3]");
        TestInst(LDFMAX(S31, S1, _[X3]), asm => asm.LDFMAX(S31, S1, _[X3]), Arm64InstructionId.LDFMAX_32, Arm64Mnemonic.LDFMAX, "LDFMAX S31, S1, [X3]");
        TestInst(LDFMAX(S0, S31, _[X3]), asm => asm.LDFMAX(S0, S31, _[X3]), Arm64InstructionId.LDFMAX_32, Arm64Mnemonic.LDFMAX, "LDFMAX S0, S31, [X3]");
        TestInst(LDFMAX(S31, S31, _[X3]), asm => asm.LDFMAX(S31, S31, _[X3]), Arm64InstructionId.LDFMAX_32, Arm64Mnemonic.LDFMAX, "LDFMAX S31, S31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAX"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAX_64_2()
    {
        TestInst(LDFMAX(D0, D1, _[X3]), asm => asm.LDFMAX(D0, D1, _[X3]), Arm64InstructionId.LDFMAX_64, Arm64Mnemonic.LDFMAX, "LDFMAX D0, D1, [X3]");
        TestInst(LDFMAX(D31, D1, _[X3]), asm => asm.LDFMAX(D31, D1, _[X3]), Arm64InstructionId.LDFMAX_64, Arm64Mnemonic.LDFMAX, "LDFMAX D31, D1, [X3]");
        TestInst(LDFMAX(D0, D31, _[X3]), asm => asm.LDFMAX(D0, D31, _[X3]), Arm64InstructionId.LDFMAX_64, Arm64Mnemonic.LDFMAX, "LDFMAX D0, D31, [X3]");
        TestInst(LDFMAX(D31, D31, _[X3]), asm => asm.LDFMAX(D31, D31, _[X3]), Arm64InstructionId.LDFMAX_64, Arm64Mnemonic.LDFMAX, "LDFMAX D31, D31, [X3]");
    }
}
