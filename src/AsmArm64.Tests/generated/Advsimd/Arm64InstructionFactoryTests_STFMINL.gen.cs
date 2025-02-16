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
public class Arm64InstructionFactoryTests_STFMINL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMINL_16_0()
    {
        TestInst(STFMINL(H0, _[X2]), Arm64InstructionId.STFMINL_16, Arm64Mnemonic.STFMINL, "STFMINL H0, [X2]");
        TestInst(STFMINL(H31, _[X2]), Arm64InstructionId.STFMINL_16, Arm64Mnemonic.STFMINL, "STFMINL H31, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMINL_32_1()
    {
        TestInst(STFMINL(S0, _[X2]), Arm64InstructionId.STFMINL_32, Arm64Mnemonic.STFMINL, "STFMINL S0, [X2]");
        TestInst(STFMINL(S31, _[X2]), Arm64InstructionId.STFMINL_32, Arm64Mnemonic.STFMINL, "STFMINL S31, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMINL_64_2()
    {
        TestInst(STFMINL(D0, _[X2]), Arm64InstructionId.STFMINL_64, Arm64Mnemonic.STFMINL, "STFMINL D0, [X2]");
        TestInst(STFMINL(D31, _[X2]), Arm64InstructionId.STFMINL_64, Arm64Mnemonic.STFMINL, "STFMINL D31, [X2]");
    }
}
