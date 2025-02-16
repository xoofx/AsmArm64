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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_LDFMINNM_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMINNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMINNM_16_0()
    {
        TestInst(LDFMINNM(H0, H1, _[X3]), Arm64InstructionId.LDFMINNM_16, Arm64Mnemonic.LDFMINNM, "LDFMINNM H0, H1, [X3]");
        TestInst(LDFMINNM(H31, H1, _[X3]), Arm64InstructionId.LDFMINNM_16, Arm64Mnemonic.LDFMINNM, "LDFMINNM H31, H1, [X3]");
        TestInst(LDFMINNM(H0, H31, _[X3]), Arm64InstructionId.LDFMINNM_16, Arm64Mnemonic.LDFMINNM, "LDFMINNM H0, H31, [X3]");
        TestInst(LDFMINNM(H31, H31, _[X3]), Arm64InstructionId.LDFMINNM_16, Arm64Mnemonic.LDFMINNM, "LDFMINNM H31, H31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMINNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMINNM_32_1()
    {
        TestInst(LDFMINNM(S0, S1, _[X3]), Arm64InstructionId.LDFMINNM_32, Arm64Mnemonic.LDFMINNM, "LDFMINNM S0, S1, [X3]");
        TestInst(LDFMINNM(S31, S1, _[X3]), Arm64InstructionId.LDFMINNM_32, Arm64Mnemonic.LDFMINNM, "LDFMINNM S31, S1, [X3]");
        TestInst(LDFMINNM(S0, S31, _[X3]), Arm64InstructionId.LDFMINNM_32, Arm64Mnemonic.LDFMINNM, "LDFMINNM S0, S31, [X3]");
        TestInst(LDFMINNM(S31, S31, _[X3]), Arm64InstructionId.LDFMINNM_32, Arm64Mnemonic.LDFMINNM, "LDFMINNM S31, S31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFMINNM"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFMINNM_64_2()
    {
        TestInst(LDFMINNM(D0, D1, _[X3]), Arm64InstructionId.LDFMINNM_64, Arm64Mnemonic.LDFMINNM, "LDFMINNM D0, D1, [X3]");
        TestInst(LDFMINNM(D31, D1, _[X3]), Arm64InstructionId.LDFMINNM_64, Arm64Mnemonic.LDFMINNM, "LDFMINNM D31, D1, [X3]");
        TestInst(LDFMINNM(D0, D31, _[X3]), Arm64InstructionId.LDFMINNM_64, Arm64Mnemonic.LDFMINNM, "LDFMINNM D0, D31, [X3]");
        TestInst(LDFMINNM(D31, D31, _[X3]), Arm64InstructionId.LDFMINNM_64, Arm64Mnemonic.LDFMINNM, "LDFMINNM D31, D31, [X3]");
    }
}
