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
public class Arm64InstructionFactoryTests_LDFADDAL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADDAL_16_0()
    {
        TestInst(LDFADDAL(H0, H1, _[X3]), asm => asm.LDFADDAL(H0, H1, _[X3]), Arm64InstructionId.LDFADDAL_16, Arm64Mnemonic.LDFADDAL, "LDFADDAL H0, H1, [X3]");
        TestInst(LDFADDAL(H31, H1, _[X3]), asm => asm.LDFADDAL(H31, H1, _[X3]), Arm64InstructionId.LDFADDAL_16, Arm64Mnemonic.LDFADDAL, "LDFADDAL H31, H1, [X3]");
        TestInst(LDFADDAL(H0, H31, _[X3]), asm => asm.LDFADDAL(H0, H31, _[X3]), Arm64InstructionId.LDFADDAL_16, Arm64Mnemonic.LDFADDAL, "LDFADDAL H0, H31, [X3]");
        TestInst(LDFADDAL(H31, H31, _[X3]), asm => asm.LDFADDAL(H31, H31, _[X3]), Arm64InstructionId.LDFADDAL_16, Arm64Mnemonic.LDFADDAL, "LDFADDAL H31, H31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADDAL_32_1()
    {
        TestInst(LDFADDAL(S0, S1, _[X3]), asm => asm.LDFADDAL(S0, S1, _[X3]), Arm64InstructionId.LDFADDAL_32, Arm64Mnemonic.LDFADDAL, "LDFADDAL S0, S1, [X3]");
        TestInst(LDFADDAL(S31, S1, _[X3]), asm => asm.LDFADDAL(S31, S1, _[X3]), Arm64InstructionId.LDFADDAL_32, Arm64Mnemonic.LDFADDAL, "LDFADDAL S31, S1, [X3]");
        TestInst(LDFADDAL(S0, S31, _[X3]), asm => asm.LDFADDAL(S0, S31, _[X3]), Arm64InstructionId.LDFADDAL_32, Arm64Mnemonic.LDFADDAL, "LDFADDAL S0, S31, [X3]");
        TestInst(LDFADDAL(S31, S31, _[X3]), asm => asm.LDFADDAL(S31, S31, _[X3]), Arm64InstructionId.LDFADDAL_32, Arm64Mnemonic.LDFADDAL, "LDFADDAL S31, S31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADDAL"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADDAL_64_2()
    {
        TestInst(LDFADDAL(D0, D1, _[X3]), asm => asm.LDFADDAL(D0, D1, _[X3]), Arm64InstructionId.LDFADDAL_64, Arm64Mnemonic.LDFADDAL, "LDFADDAL D0, D1, [X3]");
        TestInst(LDFADDAL(D31, D1, _[X3]), asm => asm.LDFADDAL(D31, D1, _[X3]), Arm64InstructionId.LDFADDAL_64, Arm64Mnemonic.LDFADDAL, "LDFADDAL D31, D1, [X3]");
        TestInst(LDFADDAL(D0, D31, _[X3]), asm => asm.LDFADDAL(D0, D31, _[X3]), Arm64InstructionId.LDFADDAL_64, Arm64Mnemonic.LDFADDAL, "LDFADDAL D0, D31, [X3]");
        TestInst(LDFADDAL(D31, D31, _[X3]), asm => asm.LDFADDAL(D31, D31, _[X3]), Arm64InstructionId.LDFADDAL_64, Arm64Mnemonic.LDFADDAL, "LDFADDAL D31, D31, [X3]");
    }
}
