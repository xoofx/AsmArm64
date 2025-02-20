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
public class Arm64InstructionFactoryTests_STBFMAXNML_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STBFMAXNML"/>.
    /// </summary>
    [TestMethod]
    public void Test_STBFMAXNML_16_0()
    {
        TestInst(STBFMAXNML(H0, _[X2]), asm => asm.STBFMAXNML(H0, _[X2]), Arm64InstructionId.STBFMAXNML_16, Arm64Mnemonic.STBFMAXNML, "STBFMAXNML H0, [X2]");
        TestInst(STBFMAXNML(H31, _[X2]), asm => asm.STBFMAXNML(H31, _[X2]), Arm64InstructionId.STBFMAXNML_16, Arm64Mnemonic.STBFMAXNML, "STBFMAXNML H31, [X2]");
    }
}
