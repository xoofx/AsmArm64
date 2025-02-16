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
public class Arm64InstructionFactoryTests_AESIMC_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AESIMC"/>.
    /// </summary>
    [TestMethod]
    public void Test_AESIMC_b_cryptoaes_0()
    {
        TestInst(AESIMC(V0.T_16B, V1.T_16B), Arm64InstructionId.AESIMC_b_cryptoaes, Arm64Mnemonic.AESIMC, "AESIMC V0.16B, V1.16B");
        TestInst(AESIMC(V30.T_16B, V1.T_16B), Arm64InstructionId.AESIMC_b_cryptoaes, Arm64Mnemonic.AESIMC, "AESIMC V30.16B, V1.16B");
        TestInst(AESIMC(V0.T_16B, V31.T_16B), Arm64InstructionId.AESIMC_b_cryptoaes, Arm64Mnemonic.AESIMC, "AESIMC V0.16B, V31.16B");
        TestInst(AESIMC(V30.T_16B, V31.T_16B), Arm64InstructionId.AESIMC_b_cryptoaes, Arm64Mnemonic.AESIMC, "AESIMC V30.16B, V31.16B");
    }
}
