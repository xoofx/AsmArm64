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
public class Arm64InstructionFactoryTests_LDFADDA_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADDA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADDA_16_0()
    {
        TestInst(LDFADDA(H0, H1, _[X3]), Arm64InstructionId.LDFADDA_16, Arm64Mnemonic.LDFADDA, "LDFADDA H0, H1, [X3]");
        TestInst(LDFADDA(H31, H1, _[X3]), Arm64InstructionId.LDFADDA_16, Arm64Mnemonic.LDFADDA, "LDFADDA H31, H1, [X3]");
        TestInst(LDFADDA(H0, H31, _[X3]), Arm64InstructionId.LDFADDA_16, Arm64Mnemonic.LDFADDA, "LDFADDA H0, H31, [X3]");
        TestInst(LDFADDA(H31, H31, _[X3]), Arm64InstructionId.LDFADDA_16, Arm64Mnemonic.LDFADDA, "LDFADDA H31, H31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADDA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADDA_32_1()
    {
        TestInst(LDFADDA(S0, S1, _[X3]), Arm64InstructionId.LDFADDA_32, Arm64Mnemonic.LDFADDA, "LDFADDA S0, S1, [X3]");
        TestInst(LDFADDA(S31, S1, _[X3]), Arm64InstructionId.LDFADDA_32, Arm64Mnemonic.LDFADDA, "LDFADDA S31, S1, [X3]");
        TestInst(LDFADDA(S0, S31, _[X3]), Arm64InstructionId.LDFADDA_32, Arm64Mnemonic.LDFADDA, "LDFADDA S0, S31, [X3]");
        TestInst(LDFADDA(S31, S31, _[X3]), Arm64InstructionId.LDFADDA_32, Arm64Mnemonic.LDFADDA, "LDFADDA S31, S31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADDA"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADDA_64_2()
    {
        TestInst(LDFADDA(D0, D1, _[X3]), Arm64InstructionId.LDFADDA_64, Arm64Mnemonic.LDFADDA, "LDFADDA D0, D1, [X3]");
        TestInst(LDFADDA(D31, D1, _[X3]), Arm64InstructionId.LDFADDA_64, Arm64Mnemonic.LDFADDA, "LDFADDA D31, D1, [X3]");
        TestInst(LDFADDA(D0, D31, _[X3]), Arm64InstructionId.LDFADDA_64, Arm64Mnemonic.LDFADDA, "LDFADDA D0, D31, [X3]");
        TestInst(LDFADDA(D31, D31, _[X3]), Arm64InstructionId.LDFADDA_64, Arm64Mnemonic.LDFADDA, "LDFADDA D31, D31, [X3]");
    }
}
