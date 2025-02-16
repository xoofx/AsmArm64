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
public class Arm64InstructionFactoryTests_LDFADD_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADD_16_0()
    {
        TestInst(LDFADD(H0, H1, _[X3]), Arm64InstructionId.LDFADD_16, Arm64Mnemonic.LDFADD, "LDFADD H0, H1, [X3]");
        TestInst(LDFADD(H31, H1, _[X3]), Arm64InstructionId.LDFADD_16, Arm64Mnemonic.LDFADD, "LDFADD H31, H1, [X3]");
        TestInst(LDFADD(H0, H31, _[X3]), Arm64InstructionId.LDFADD_16, Arm64Mnemonic.LDFADD, "LDFADD H0, H31, [X3]");
        TestInst(LDFADD(H31, H31, _[X3]), Arm64InstructionId.LDFADD_16, Arm64Mnemonic.LDFADD, "LDFADD H31, H31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADD_32_1()
    {
        TestInst(LDFADD(S0, S1, _[X3]), Arm64InstructionId.LDFADD_32, Arm64Mnemonic.LDFADD, "LDFADD S0, S1, [X3]");
        TestInst(LDFADD(S31, S1, _[X3]), Arm64InstructionId.LDFADD_32, Arm64Mnemonic.LDFADD, "LDFADD S31, S1, [X3]");
        TestInst(LDFADD(S0, S31, _[X3]), Arm64InstructionId.LDFADD_32, Arm64Mnemonic.LDFADD, "LDFADD S0, S31, [X3]");
        TestInst(LDFADD(S31, S31, _[X3]), Arm64InstructionId.LDFADD_32, Arm64Mnemonic.LDFADD, "LDFADD S31, S31, [X3]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LDFADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_LDFADD_64_2()
    {
        TestInst(LDFADD(D0, D1, _[X3]), Arm64InstructionId.LDFADD_64, Arm64Mnemonic.LDFADD, "LDFADD D0, D1, [X3]");
        TestInst(LDFADD(D31, D1, _[X3]), Arm64InstructionId.LDFADD_64, Arm64Mnemonic.LDFADD, "LDFADD D31, D1, [X3]");
        TestInst(LDFADD(D0, D31, _[X3]), Arm64InstructionId.LDFADD_64, Arm64Mnemonic.LDFADD, "LDFADD D0, D31, [X3]");
        TestInst(LDFADD(D31, D31, _[X3]), Arm64InstructionId.LDFADD_64, Arm64Mnemonic.LDFADD, "LDFADD D31, D31, [X3]");
    }
}
