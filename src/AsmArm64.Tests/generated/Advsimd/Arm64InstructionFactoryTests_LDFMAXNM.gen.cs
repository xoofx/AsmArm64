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
public class Arm64InstructionFactoryTests_LDFMAXNM_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAXNM_16_0()
    {
        TestInst(LDFMAXNM(H0, H1, _[X3]), asm => asm.LDFMAXNM(H0, H1, _[X3]), Arm64InstructionId.LDFMAXNM_16, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM H0, H1, [X3]");
        TestInst(LDFMAXNM(H31, H1, _[X3]), asm => asm.LDFMAXNM(H31, H1, _[X3]), Arm64InstructionId.LDFMAXNM_16, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM H31, H1, [X3]");
        TestInst(LDFMAXNM(H0, H31, _[X3]), asm => asm.LDFMAXNM(H0, H31, _[X3]), Arm64InstructionId.LDFMAXNM_16, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM H0, H31, [X3]");
        TestInst(LDFMAXNM(H31, H31, _[X3]), asm => asm.LDFMAXNM(H31, H31, _[X3]), Arm64InstructionId.LDFMAXNM_16, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM H31, H31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAXNM_32_1()
    {
        TestInst(LDFMAXNM(S0, S1, _[X3]), asm => asm.LDFMAXNM(S0, S1, _[X3]), Arm64InstructionId.LDFMAXNM_32, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM S0, S1, [X3]");
        TestInst(LDFMAXNM(S31, S1, _[X3]), asm => asm.LDFMAXNM(S31, S1, _[X3]), Arm64InstructionId.LDFMAXNM_32, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM S31, S1, [X3]");
        TestInst(LDFMAXNM(S0, S31, _[X3]), asm => asm.LDFMAXNM(S0, S31, _[X3]), Arm64InstructionId.LDFMAXNM_32, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM S0, S31, [X3]");
        TestInst(LDFMAXNM(S31, S31, _[X3]), asm => asm.LDFMAXNM(S31, S31, _[X3]), Arm64InstructionId.LDFMAXNM_32, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM S31, S31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMAXNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMAXNM_64_2()
    {
        TestInst(LDFMAXNM(D0, D1, _[X3]), asm => asm.LDFMAXNM(D0, D1, _[X3]), Arm64InstructionId.LDFMAXNM_64, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM D0, D1, [X3]");
        TestInst(LDFMAXNM(D31, D1, _[X3]), asm => asm.LDFMAXNM(D31, D1, _[X3]), Arm64InstructionId.LDFMAXNM_64, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM D31, D1, [X3]");
        TestInst(LDFMAXNM(D0, D31, _[X3]), asm => asm.LDFMAXNM(D0, D31, _[X3]), Arm64InstructionId.LDFMAXNM_64, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM D0, D31, [X3]");
        TestInst(LDFMAXNM(D31, D31, _[X3]), asm => asm.LDFMAXNM(D31, D31, _[X3]), Arm64InstructionId.LDFMAXNM_64, Arm64Mnemonic.LDFMAXNM, "LDFMAXNM D31, D31, [X3]");
    }
}
