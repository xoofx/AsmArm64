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
public class Arm64InstructionFactoryTests_STFMIN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMIN_16_0()
    {
        TestInst(STFMIN(H0, _[X2]), asm => asm.STFMIN(H0, _[X2]), Arm64InstructionId.STFMIN_16, Arm64Mnemonic.STFMIN, "STFMIN H0, [X2]");
        TestInst(STFMIN(H31, _[X2]), asm => asm.STFMIN(H31, _[X2]), Arm64InstructionId.STFMIN_16, Arm64Mnemonic.STFMIN, "STFMIN H31, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMIN_32_1()
    {
        TestInst(STFMIN(S0, _[X2]), asm => asm.STFMIN(S0, _[X2]), Arm64InstructionId.STFMIN_32, Arm64Mnemonic.STFMIN, "STFMIN S0, [X2]");
        TestInst(STFMIN(S31, _[X2]), asm => asm.STFMIN(S31, _[X2]), Arm64InstructionId.STFMIN_32, Arm64Mnemonic.STFMIN, "STFMIN S31, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMIN_64_2()
    {
        TestInst(STFMIN(D0, _[X2]), asm => asm.STFMIN(D0, _[X2]), Arm64InstructionId.STFMIN_64, Arm64Mnemonic.STFMIN, "STFMIN D0, [X2]");
        TestInst(STFMIN(D31, _[X2]), asm => asm.STFMIN(D31, _[X2]), Arm64InstructionId.STFMIN_64, Arm64Mnemonic.STFMIN, "STFMIN D31, [X2]");
    }
}
