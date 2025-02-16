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
public class Arm64InstructionFactoryTests_STFMAXNML_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMAXNML"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMAXNML_16_0()
    {
        TestInst(STFMAXNML(H0, _[X2]), Arm64InstructionId.STFMAXNML_16, Arm64Mnemonic.STFMAXNML, "STFMAXNML H0, [X2]");
        TestInst(STFMAXNML(H31, _[X2]), Arm64InstructionId.STFMAXNML_16, Arm64Mnemonic.STFMAXNML, "STFMAXNML H31, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMAXNML"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMAXNML_32_1()
    {
        TestInst(STFMAXNML(S0, _[X2]), Arm64InstructionId.STFMAXNML_32, Arm64Mnemonic.STFMAXNML, "STFMAXNML S0, [X2]");
        TestInst(STFMAXNML(S31, _[X2]), Arm64InstructionId.STFMAXNML_32, Arm64Mnemonic.STFMAXNML, "STFMAXNML S31, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STFMAXNML"/>.
    /// </summary>
    [TestMethod]
    public void Test_STFMAXNML_64_2()
    {
        TestInst(STFMAXNML(D0, _[X2]), Arm64InstructionId.STFMAXNML_64, Arm64Mnemonic.STFMAXNML, "STFMAXNML D0, [X2]");
        TestInst(STFMAXNML(D31, _[X2]), Arm64InstructionId.STFMAXNML_64, Arm64Mnemonic.STFMAXNML, "STFMAXNML D31, [X2]");
    }
}
